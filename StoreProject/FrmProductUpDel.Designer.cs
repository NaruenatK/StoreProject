namespace StoreProject
{
    partial class FrmProductUpDel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductUpDel));
            this.btProImgae = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbProImage = new System.Windows.Forms.PictureBox();
            this.rdoProStatusOff = new System.Windows.Forms.RadioButton();
            this.rdoProStatusOn = new System.Windows.Forms.RadioButton();
            this.nudProQuan = new System.Windows.Forms.NumericUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbProUnit = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbProPrice = new System.Windows.Forms.TextBox();
            this.tbProName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btProUpdate = new System.Windows.Forms.Button();
            this.btProDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // btProImgae
            // 
            this.btProImgae.Location = new System.Drawing.Point(264, 208);
            this.btProImgae.Name = "btProImgae";
            this.btProImgae.Size = new System.Drawing.Size(24, 23);
            this.btProImgae.TabIndex = 9;
            this.btProImgae.Text = "...";
            this.btProImgae.UseVisualStyleBackColor = true;
            this.btProImgae.Click += new System.EventHandler(this.btProImgae_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcbProImage);
            this.panel1.Location = new System.Drawing.Point(136, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 149);
            this.panel1.TabIndex = 27;
            // 
            // pcbProImage
            // 
            this.pcbProImage.Location = new System.Drawing.Point(11, 8);
            this.pcbProImage.Name = "pcbProImage";
            this.pcbProImage.Size = new System.Drawing.Size(100, 134);
            this.pcbProImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProImage.TabIndex = 1;
            this.pcbProImage.TabStop = false;
            // 
            // rdoProStatusOff
            // 
            this.rdoProStatusOff.AutoSize = true;
            this.rdoProStatusOff.Location = new System.Drawing.Point(229, 382);
            this.rdoProStatusOff.Name = "rdoProStatusOff";
            this.rdoProStatusOff.Size = new System.Drawing.Size(83, 17);
            this.rdoProStatusOff.TabIndex = 24;
            this.rdoProStatusOff.Text = "ไม่พร้อมขาย";
            this.rdoProStatusOff.UseVisualStyleBackColor = true;
            // 
            // rdoProStatusOn
            // 
            this.rdoProStatusOn.AutoSize = true;
            this.rdoProStatusOn.Checked = true;
            this.rdoProStatusOn.Location = new System.Drawing.Point(136, 382);
            this.rdoProStatusOn.Name = "rdoProStatusOn";
            this.rdoProStatusOn.Size = new System.Drawing.Size(70, 17);
            this.rdoProStatusOn.TabIndex = 23;
            this.rdoProStatusOn.TabStop = true;
            this.rdoProStatusOn.Text = "พร้อมขาย";
            this.rdoProStatusOn.UseVisualStyleBackColor = true;
            // 
            // nudProQuan
            // 
            this.nudProQuan.Location = new System.Drawing.Point(136, 327);
            this.nudProQuan.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProQuan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProQuan.Name = "nudProQuan";
            this.nudProQuan.Size = new System.Drawing.Size(178, 20);
            this.nudProQuan.TabIndex = 22;
            this.nudProQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(136, 378);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 20);
            this.textBox5.TabIndex = 21;
            // 
            // tbProUnit
            // 
            this.tbProUnit.Location = new System.Drawing.Point(136, 353);
            this.tbProUnit.Name = "tbProUnit";
            this.tbProUnit.Size = new System.Drawing.Size(178, 20);
            this.tbProUnit.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 324);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 20);
            this.textBox3.TabIndex = 19;
            // 
            // tbProPrice
            // 
            this.tbProPrice.Location = new System.Drawing.Point(136, 299);
            this.tbProPrice.Name = "tbProPrice";
            this.tbProPrice.Size = new System.Drawing.Size(178, 20);
            this.tbProPrice.TabIndex = 17;
            // 
            // tbProName
            // 
            this.tbProName.Location = new System.Drawing.Point(136, 272);
            this.tbProName.Name = "tbProName";
            this.tbProName.Size = new System.Drawing.Size(178, 20);
            this.tbProName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(33, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "สถานะสินค้า";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(33, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "หน่วยสินค้า";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(33, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "จำนวนสินค้า";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(33, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "ราคาสินค้า";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "ชื้อสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "แก้ใข/ลบสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btProUpdate
            // 
            this.btProUpdate.Image = global::StoreProject.Properties.Resources.save;
            this.btProUpdate.Location = new System.Drawing.Point(201, 414);
            this.btProUpdate.Name = "btProUpdate";
            this.btProUpdate.Size = new System.Drawing.Size(111, 39);
            this.btProUpdate.TabIndex = 26;
            this.btProUpdate.Text = "บันทึกรายการ";
            this.btProUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProUpdate.UseVisualStyleBackColor = true;
            this.btProUpdate.Click += new System.EventHandler(this.btProUpdate_Click);
            // 
            // btProDelete
            // 
            this.btProDelete.Image = global::StoreProject.Properties.Resources.cancel;
            this.btProDelete.Location = new System.Drawing.Point(69, 414);
            this.btProDelete.Name = "btProDelete";
            this.btProDelete.Size = new System.Drawing.Size(111, 39);
            this.btProDelete.TabIndex = 25;
            this.btProDelete.Text = "ลบสินค้า";
            this.btProDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProDelete.UseVisualStyleBackColor = true;
            this.btProDelete.Click += new System.EventHandler(this.btProDelete_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "รหัสสินค้า";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbProId
            // 
            this.tbProId.Location = new System.Drawing.Point(136, 247);
            this.tbProId.Name = "tbProId";
            this.tbProId.ReadOnly = true;
            this.tbProId.Size = new System.Drawing.Size(178, 20);
            this.tbProId.TabIndex = 18;
            // 
            // FrmProductUpDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btProImgae);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btProUpdate);
            this.Controls.Add(this.btProDelete);
            this.Controls.Add(this.rdoProStatusOff);
            this.Controls.Add(this.rdoProStatusOn);
            this.Controls.Add(this.nudProQuan);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbProUnit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbProPrice);
            this.Controls.Add(this.tbProId);
            this.Controls.Add(this.tbProName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductUpDel";
            this.Text = "แก้ไข/ลบสินค้า - บริหารจัดการข้อมูลสินค้า";
            this.Load += new System.EventHandler(this.FrmProductUpDel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btProImgae;
        private System.Windows.Forms.PictureBox pcbProImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btProUpdate;
        private System.Windows.Forms.Button btProDelete;
        private System.Windows.Forms.RadioButton rdoProStatusOff;
        private System.Windows.Forms.RadioButton rdoProStatusOn;
        private System.Windows.Forms.NumericUpDown nudProQuan;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbProUnit;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbProPrice;
        private System.Windows.Forms.TextBox tbProName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProId;
    }
}