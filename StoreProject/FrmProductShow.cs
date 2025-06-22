using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProject
{
    public partial class FrmProductShow : Form
    {
        public FrmProductShow()
        {
            InitializeComponent();
        }

        //เมธอตแปลง binary เป็นรูป
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
                // อาจเกิดขึ้นถ้า byte array ไม่ใช่ข้อมูลรูปภาพที่ถูกต้อง
                Console.WriteLine("Error converting byte array to image: " + ex.Message);
                return null;
            }
        }

        //สร้างเม็นธอตดึงข้อมูลท้งหมด
        private void getAllProductToLV()
        {
            //connect string เพื่อติคต่อหาฐานฃนข้อมูล
            string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;Trusted_Connection=True;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    string strSQL = "SELECT proId, proName, proPrice, proQuan, proUnit, proStatus, proImage FROM product_tb";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        lvAllProcduct.Items.Clear();
                        lvAllProcduct.Columns.Clear();
                        lvAllProcduct.FullRowSelect = true;
                        lvAllProcduct.View = View.Details;

                        if (lvAllProcduct.SmallImageList == null)
                        {
                            lvAllProcduct.SmallImageList = new ImageList();
                            lvAllProcduct.SmallImageList.ImageSize = new Size(50,50);
                            lvAllProcduct.SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
                        }
                        lvAllProcduct.SmallImageList.Images.Clear();

                        lvAllProcduct.Columns.Add("รูปภาพ", 100, HorizontalAlignment.Left);
                        lvAllProcduct.Columns.Add("รหัสสินค้า", 100, HorizontalAlignment.Left);
                        lvAllProcduct.Columns.Add("ชื้อสินค้า", 250, HorizontalAlignment.Left);
                        lvAllProcduct.Columns.Add("ราคา", 100, HorizontalAlignment.Left);
                        lvAllProcduct.Columns.Add("จำนวน", 100, HorizontalAlignment.Left);
                        lvAllProcduct.Columns.Add("หน่วย", 80, HorizontalAlignment.Left);
                        lvAllProcduct.Columns.Add("สถานะ", 120, HorizontalAlignment.Left);

                        foreach (DataRow dataRow in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem();
                            Image proImage = null;
                            if (dataRow["proImage"] != DBNull.Value)
                            {
                                byte[] imgByte = (byte[])dataRow["proImage"];
                                proImage = convertByteArrayToImage(imgByte);
                            }
                            string imageKey = null;
                            if (proImage != null)
                            {
                                imageKey = $"pro_{dataRow["proId"]}";
                                lvAllProcduct.SmallImageList.Images.Add(imageKey, proImage);
                                item.ImageKey = imageKey;
                            }
                            else
                            {
                                item.ImageIndex = -1;
                            }

                            item.SubItems.Add(dataRow["proId"].ToString());
                            item.SubItems.Add(dataRow["proName"].ToString());
                            item.SubItems.Add(dataRow["proPrice"].ToString());
                            item.SubItems.Add(dataRow["proQuan"].ToString());
                            item.SubItems.Add(dataRow["proUnit"].ToString());
                            item.SubItems.Add(dataRow["proStatus"].ToString());

                            lvAllProcduct.Items.Add(item);

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด กรูณาลองใหม่หรือติดต่อ IT : " + ex.Message);
                }
            }
        }

        // จะทำงานทุกครั้งที่จอเปิดขึ้นมา
        private void FrmProductShow_Load(object sender, EventArgs e)
        {
            // ไปคึงข้อมูลจาก product_tb มาแสดงที่ listview
            getAllProductToLV();
        }

        private void btnFrmProductCreate_Click(object sender, EventArgs e)
        {
            //เปืด From นี้จาก Dialog
            FrmProductCreate frmProductCreate = new FrmProductCreate();
            frmProductCreate.ShowDialog();
            getAllProductToLV();
        }

        private void lvAllProcduct_ItemActivate(object sender, EventArgs e)
        {
            FrmProductUpDel frmProductUpDel = new FrmProductUpDel(
                int.Parse (lvAllProcduct.SelectedItems[0].SubItems[1].Text)
            );
            frmProductUpDel.ShowDialog();
            getAllProductToLV();
        }
    }
}
