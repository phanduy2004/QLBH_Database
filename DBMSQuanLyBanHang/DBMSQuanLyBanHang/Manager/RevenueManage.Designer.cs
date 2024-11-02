namespace DBMSQuanLyBanHang.Manager
{
    partial class RevenueManage
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
            this.buttonDoanhThuTheoNgay = new System.Windows.Forms.Button();
            this.buttonDoanhThuTheoThang = new System.Windows.Forms.Button();
            this.buttonDoanhThuTheoNam = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDoanhThuTheoNgay
            // 
            this.buttonDoanhThuTheoNgay.Location = new System.Drawing.Point(79, 150);
            this.buttonDoanhThuTheoNgay.Name = "buttonDoanhThuTheoNgay";
            this.buttonDoanhThuTheoNgay.Size = new System.Drawing.Size(191, 23);
            this.buttonDoanhThuTheoNgay.TabIndex = 6;
            this.buttonDoanhThuTheoNgay.Text = "DOANH THU THEO NGÀY";
            this.buttonDoanhThuTheoNgay.UseVisualStyleBackColor = true;
            this.buttonDoanhThuTheoNgay.Click += new System.EventHandler(this.buttonDoanhThuTheoNgay_Click);
            // 
            // buttonDoanhThuTheoThang
            // 
            this.buttonDoanhThuTheoThang.Location = new System.Drawing.Point(333, 150);
            this.buttonDoanhThuTheoThang.Name = "buttonDoanhThuTheoThang";
            this.buttonDoanhThuTheoThang.Size = new System.Drawing.Size(191, 23);
            this.buttonDoanhThuTheoThang.TabIndex = 7;
            this.buttonDoanhThuTheoThang.Text = "DOANH THU THEO THÁNG";
            this.buttonDoanhThuTheoThang.UseVisualStyleBackColor = true;
            this.buttonDoanhThuTheoThang.Click += new System.EventHandler(this.buttonDoanhThuTheoThang_Click);
            // 
            // buttonDoanhThuTheoNam
            // 
            this.buttonDoanhThuTheoNam.Location = new System.Drawing.Point(585, 150);
            this.buttonDoanhThuTheoNam.Name = "buttonDoanhThuTheoNam";
            this.buttonDoanhThuTheoNam.Size = new System.Drawing.Size(191, 23);
            this.buttonDoanhThuTheoNam.TabIndex = 8;
            this.buttonDoanhThuTheoNam.Text = "DOANH THU THEO NĂM";
            this.buttonDoanhThuTheoNam.UseVisualStyleBackColor = true;
            this.buttonDoanhThuTheoNam.Click += new System.EventHandler(this.buttonDoanhThuTheoNam_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 32);
            this.label8.TabIndex = 53;
            this.label8.Text = "QUẢN LÝ DOANH THU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 56;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(236, 100);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(212, 22);
            this.dateTimePicker.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Ngày: ";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.Location = new System.Drawing.Point(45, 234);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(98, 32);
            this.lblDoanhThu.TabIndex = 59;
            this.lblDoanhThu.Text = "label5";
            // 
            // RevenueManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDoanhThuTheoNam);
            this.Controls.Add(this.buttonDoanhThuTheoThang);
            this.Controls.Add(this.buttonDoanhThuTheoNgay);
            this.Name = "RevenueManage";
            this.Text = "RevenueManage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDoanhThuTheoNgay;
        private System.Windows.Forms.Button buttonDoanhThuTheoThang;
        private System.Windows.Forms.Button buttonDoanhThuTheoNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDoanhThu;
    }
}