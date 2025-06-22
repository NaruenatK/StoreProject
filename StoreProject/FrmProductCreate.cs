using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StoreProject
{
    public partial class FrmProductCreate : Form
    {

        byte[] proImage;
        public FrmProductCreate()
        {
            InitializeComponent();
        }

        private byte[] convertImageToByteArray(Image image, ImageFormat imageFormat)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, imageFormat);
                return ms.ToArray();
            }
        }

        private void btProImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Image File (*.jpg;*.png)|*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcbProImage.Image = Image.FromFile(openFileDialog.FileName);

                if (pcbProImage.Image.RawFormat == ImageFormat.Jpeg)
                {
                    proImage = convertImageToByteArray(pcbProImage.Image, ImageFormat.Jpeg);
                }
                else
                {
                    proImage = convertImageToByteArray(pcbProImage.Image, ImageFormat.Png);
                }
            }
        }

        private void tbProPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            // อนุญาตให้กดปุ่ม backspace ได้
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // ตรวจสอบว่ากด "." และยังไม่มี "." ในข้อความแล้ว
            if (e.KeyChar == '.' && !tb.Text.Contains('.'))
            {
                return;
            }

            // ถ้าไม่เข้าเงื่อนไขใดเลย ให้ block การกด
            e.Handled = true;
        }

        private void showWarningMSG(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (proImage == null)
            {
                showWarningMSG("ป้อนรูปด้วย");
            }
            else if (tbProName.Text.Length == 0)
            {
                showWarningMSG("ป้อนชื่อสินค้าด้วย");
            }
            else if (tbProPrice.Text.Length == 0)
            {
                showWarningMSG("ป้อนราคาสินค้าด้วย");
            }
            else if (int.Parse(nudProQuan.Value.ToString()) <= 0)
            {
                showWarningMSG("จำนวนสินค้าต้องมากกว่า 0");
            }
            else if (tbProUnit.Text.Length == 0)
            {
                showWarningMSG("ป้อนหน่วยสินค้าด้วย");
            }
            else
            {
                string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;Trusted_Connection=True;";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        sqlConnection.Open();

                        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

                        string strSQL = "INSERT INTO product_tb ( proName, proPrice, proQuan, proUnit, proStatus, proImage, createAt, updateAt) " +
                                        "VALUES ( @proName, @proPrice, @proQuan, @proUnit, @proStatus, @proImage, @createAt, @updateAt)";


                        using (SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                        {
                            sqlCommand.Parameters.Add("@proName", SqlDbType.NVarChar, 300).Value = tbProName.Text;
                            sqlCommand.Parameters.Add("@proPrice", SqlDbType.Float).Value = float.Parse( tbProPrice.Text );
                            sqlCommand.Parameters.Add("@proQuan", SqlDbType.Int).Value = int.Parse( nudProQuan.Value.ToString() );
                            sqlCommand.Parameters.Add("@proUnit", SqlDbType.NVarChar, 50).Value = tbProUnit.Text;
                            if (rdoProStatusOn.Checked == true )
                            {
                                sqlCommand.Parameters.Add("@proStatus", SqlDbType.NVarChar, 50).Value = "พร้อมขาย";
                            }
                            else
                            {
                                sqlCommand.Parameters.Add("@proStatus", SqlDbType.NVarChar, 50).Value = "ไม่พร้อมขาย";
                            }
                            sqlCommand.Parameters.Add("@proImage", SqlDbType.Image).Value = proImage;
                            sqlCommand.Parameters.Add("@createAt", SqlDbType.Date).Value = DateTime.Now.Date;
                            sqlCommand.Parameters.Add("@updateAt", SqlDbType.Date).Value = DateTime.Now.Date;

                            sqlCommand.ExecuteNonQuery();
                            sqlTransaction.Commit();

                            MessageBox.Show("บันทึกเรียบร้อย", "ผลการทำงาน",MessageBoxButtons.OK,MessageBoxIcon.Information );
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("พบข้อผิดพลาด กรูณาลองใหม่หรือติดต่อ IT : " + ex.Message);
                    }
                }
            }
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            proImage = null;
            tbProName.Clear();
            tbProPrice.Clear();
            nudProQuan.Value = 0;
            tbProUnit.Clear();
            pcbProImage.Image = null;
        }

        private void FrmProductCreate_Load(object sender, EventArgs e)
        {

        }
    }
}


