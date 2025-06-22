using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace StoreProject
{
    public partial class FrmProductUpDel : Form
    {
        int proId;
        byte[] proImage;

        public FrmProductUpDel(int proId)
        {
            InitializeComponent();
            this.proId = proId;
        }

        private Image convertByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
            {
                return null;
            }
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error converting byte array to image: " + ex.Message);
                return null;
            }
        }

        private void FrmProductUpDel_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;Trusted_Connection=True;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    string strSQL = "SELECT proId, proName, proPrice, proQuan, proUnit, proStatus, proImage FROM product_tb WHERE proId=@proId";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection))
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@proId", proId);

                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow row = dataTable.Rows[0];

                            tbProId.Text = row["proId"].ToString();
                            tbProName.Text = row["proName"].ToString();
                            tbProPrice.Text = row["proPrice"].ToString();
                            tbProUnit.Text = row["proUnit"].ToString();
                            nudProQuan.Value = int.Parse(row["proQuan"].ToString());

                            rdoProStatusOn.Checked = row["proStatus"].ToString() == "พร้อมขาย";
                            rdoProStatusOff.Checked = !rdoProStatusOn.Checked;

                            if (row["proImage"] != DBNull.Value)
                            {
                                proImage = (byte[])row["proImage"];
                                pcbProImage.Image = convertByteArrayToImage(proImage);
                            }
                            else
                            {
                                pcbProImage.Image = null;
                                proImage = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่หรือติดต่อ IT : " + ex.Message);
                }
            }
        }

        private void btProDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;Trusted_Connection=True;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

                    string strSQL = "DELETE FROM product_tb WHERE proId=@proId";

                    using (SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                    {
                        sqlCommand.Parameters.Add("@proId", SqlDbType.Int).Value = int.Parse(tbProId.Text);

                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();

                        MessageBox.Show("ลบแล้วจ้า", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่หรือติดต่อ IT : " + ex.Message);
                }
            }
        }

        private void showWarningMSG(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btProUpdate_Click(object sender, EventArgs e)
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

                        string strSQL = "UPDATE product_tb SET " +
                                        "proName = @proName, " +
                                        "proPrice = @proPrice, " +
                                        "proQuan = @proQuan, " +
                                        "proUnit = @proUnit, " +
                                        "proStatus = @proStatus, " +
                                        "proImage = @proImage, " +
                                        "updateAt = @updateAt " +
                                        "WHERE proId = @proId";

                        using (SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                        {
                            sqlCommand.Parameters.Add("@proName", SqlDbType.NVarChar, 300).Value = tbProName.Text;
                            sqlCommand.Parameters.Add("@proPrice", SqlDbType.Float).Value = float.Parse(tbProPrice.Text);
                            sqlCommand.Parameters.Add("@proQuan", SqlDbType.Int).Value = int.Parse(nudProQuan.Value.ToString());
                            sqlCommand.Parameters.Add("@proUnit", SqlDbType.NVarChar, 50).Value = tbProUnit.Text;

                            string status = rdoProStatusOn.Checked ? "พร้อมขาย" : "ไม่พร้อมขาย";
                            sqlCommand.Parameters.Add("@proStatus", SqlDbType.NVarChar, 50).Value = status;

                            sqlCommand.Parameters.Add("@proImage", SqlDbType.Image).Value = proImage;
                            sqlCommand.Parameters.Add("@updateAt", SqlDbType.Date).Value = DateTime.Now.Date;
                            sqlCommand.Parameters.Add("@proId", SqlDbType.Int).Value = int.Parse(tbProId.Text);

                            sqlCommand.ExecuteNonQuery();
                            sqlTransaction.Commit();

                            MessageBox.Show("บันทึกเรียบร้อย", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่หรือติดต่อ IT : " + ex.Message);
                    }
                }
            }
        }

        private byte[] convertImageToByteArray(Image image, ImageFormat imageFormat)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, imageFormat);
                return ms.ToArray();
            }
        }
        private void btProImgae_Click(object sender, EventArgs e)
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
    }
}
