namespace StoreProject
{
    partial class FrmProductCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductCreate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbProName = new System.Windows.Forms.TextBox();
            this.tbProPrice = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbProUnit = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.nudProQuan = new System.Windows.Forms.NumericUpDown();
            this.rdoProStatusOn = new System.Windows.Forms.RadioButton();
            this.rdoProStatusOff = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbProImage = new System.Windows.Forms.PictureBox();
            this.btProImage = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "บริหารจัดการข้อมูลสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(39, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ชื้อสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(39, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "ราคาสินค้า";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(39, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "จำนวนสินค้า";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(39, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "หน่วยสินค้า";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(39, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "สถานะสินค้า";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbProName
            // 
            this.tbProName.Location = new System.Drawing.Point(142, 254);
            this.tbProName.Name = "tbProName";
            this.tbProName.Size = new System.Drawing.Size(178, 20);
            this.tbProName.TabIndex = 4;
            // 
            // tbProPrice
            // 
            this.tbProPrice.Location = new System.Drawing.Point(142, 281);
            this.tbProPrice.Name = "tbProPrice";
            this.tbProPrice.Size = new System.Drawing.Size(178, 20);
            this.tbProPrice.TabIndex = 4;
            this.tbProPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProPrice_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 306);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 20);
            this.textBox3.TabIndex = 4;
            // 
            // tbProUnit
            // 
            this.tbProUnit.Location = new System.Drawing.Point(142, 335);
            this.tbProUnit.Name = "tbProUnit";
            this.tbProUnit.Size = new System.Drawing.Size(178, 20);
            this.tbProUnit.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(142, 360);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 20);
            this.textBox5.TabIndex = 4;
            // 
            // nudProQuan
            // 
            this.nudProQuan.Location = new System.Drawing.Point(142, 309);
            this.nudProQuan.Name = "nudProQuan";
            this.nudProQuan.Size = new System.Drawing.Size(178, 20);
            this.nudProQuan.TabIndex = 5;
            // 
            // rdoProStatusOn
            // 
            this.rdoProStatusOn.AutoSize = true;
            this.rdoProStatusOn.Checked = true;
            this.rdoProStatusOn.Location = new System.Drawing.Point(142, 364);
            this.rdoProStatusOn.Name = "rdoProStatusOn";
            this.rdoProStatusOn.Size = new System.Drawing.Size(70, 17);
            this.rdoProStatusOn.TabIndex = 6;
            this.rdoProStatusOn.TabStop = true;
            this.rdoProStatusOn.Text = "พร้อมขาย";
            this.rdoProStatusOn.UseVisualStyleBackColor = true;
            // 
            // rdoProStatusOff
            // 
            this.rdoProStatusOff.AutoSize = true;
            this.rdoProStatusOff.Location = new System.Drawing.Point(235, 364);
            this.rdoProStatusOff.Name = "rdoProStatusOff";
            this.rdoProStatusOff.Size = new System.Drawing.Size(83, 17);
            this.rdoProStatusOff.TabIndex = 6;
            this.rdoProStatusOff.Text = "ไม่พร้อมขาย";
            this.rdoProStatusOff.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcbProImage);
            this.panel1.Location = new System.Drawing.Point(142, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 149);
            this.panel1.TabIndex = 8;
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
            // btProImage
            // 
            this.btProImage.Location = new System.Drawing.Point(270, 208);
            this.btProImage.Name = "btProImage";
            this.btProImage.Size = new System.Drawing.Size(24, 23);
            this.btProImage.TabIndex = 2;
            this.btProImage.Text = "...";
            this.btProImage.UseVisualStyleBackColor = true;
            this.btProImage.Click += new System.EventHandler(this.btProImage_Click);
            // 
            // btSave
            // 
            this.btSave.Image = global::StoreProject.Properties.Resources.save;
            this.btSave.Location = new System.Drawing.Point(207, 396);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(111, 39);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "บันทึกรายการ";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancle
            // 
            this.btCancle.Image = global::StoreProject.Properties.Resources.cancel;
            this.btCancle.Location = new System.Drawing.Point(75, 396);
            this.btCancle.Name = "btCancle";
            this.btCancle.Size = new System.Drawing.Size(111, 39);
            this.btCancle.TabIndex = 7;
            this.btCancle.Text = "ยกเลิก";
            this.btCancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancle.UseVisualStyleBackColor = true;
            this.btCancle.Click += new System.EventHandler(this.btCancle_Click);
            // 
            // FrmProductCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btProImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancle);
            this.Controls.Add(this.rdoProStatusOff);
            this.Controls.Add(this.rdoProStatusOn);
            this.Controls.Add(this.nudProQuan);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbProUnit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbProPrice);
            this.Controls.Add(this.tbProName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProductCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เพิ่มสินค้า - บริหารการจัดการข้อมมูลสินค้า";
            this.Load += new System.EventHandler(this.FrmProductCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbProImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbProName;
        private System.Windows.Forms.TextBox tbProPrice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbProUnit;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown nudProQuan;
        private System.Windows.Forms.RadioButton rdoProStatusOn;
        private System.Windows.Forms.RadioButton rdoProStatusOff;
        private System.Windows.Forms.Button btCancle;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btProImage;
    }
}

