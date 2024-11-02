namespace DBMSQuanLyBanHang.Manager
{
    partial class ImportOrderManager2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_tenSP = new System.Windows.Forms.ComboBox();
            this.txt_giaNhap = new System.Windows.Forms.TextBox();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.cbb_ncc = new System.Windows.Forms.ComboBox();
            this.date_time = new System.Windows.Forms.DateTimePicker();
            this.txt_total_Amount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.TongTien});
            this.dataGridView1.Location = new System.Drawing.Point(711, 413);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(660, 263);
            this.dataGridView1.TabIndex = 242;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 10;
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 10;
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 10;
            this.SoLuong.Name = "SoLuong";
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 10;
            this.TongTien.Name = "TongTien";
            // 
            // cbb_tenSP
            // 
            this.cbb_tenSP.FormattingEnabled = true;
            this.cbb_tenSP.Location = new System.Drawing.Point(317, 305);
            this.cbb_tenSP.Name = "cbb_tenSP";
            this.cbb_tenSP.Size = new System.Drawing.Size(279, 33);
            this.cbb_tenSP.TabIndex = 243;
            this.cbb_tenSP.SelectionChangeCommitted += new System.EventHandler(this.cbb_tenSP_SelectionChangeCommitted);
            // 
            // txt_giaNhap
            // 
            this.txt_giaNhap.Location = new System.Drawing.Point(317, 404);
            this.txt_giaNhap.Name = "txt_giaNhap";
            this.txt_giaNhap.Size = new System.Drawing.Size(279, 31);
            this.txt_giaNhap.TabIndex = 244;
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Location = new System.Drawing.Point(317, 597);
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(279, 31);
            this.txt_tongTien.TabIndex = 245;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(317, 495);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(279, 31);
            this.txt_soLuong.TabIndex = 246;
            this.txt_soLuong.TextChanged += new System.EventHandler(this.txt_soLuong_TextChanged);
            // 
            // cbb_ncc
            // 
            this.cbb_ncc.FormattingEnabled = true;
            this.cbb_ncc.Location = new System.Drawing.Point(1009, 140);
            this.cbb_ncc.Name = "cbb_ncc";
            this.cbb_ncc.Size = new System.Drawing.Size(279, 33);
            this.cbb_ncc.TabIndex = 247;
            // 
            // date_time
            // 
            this.date_time.Location = new System.Drawing.Point(1009, 228);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(384, 31);
            this.date_time.TabIndex = 248;
            // 
            // txt_total_Amount
            // 
            this.txt_total_Amount.Location = new System.Drawing.Point(1009, 744);
            this.txt_total_Amount.Name = "txt_total_Amount";
            this.txt_total_Amount.Size = new System.Drawing.Size(279, 31);
            this.txt_total_Amount.TabIndex = 249;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 723);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 52);
            this.button1.TabIndex = 250;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(952, 851);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(277, 52);
            this.addButton.TabIndex = 251;
            this.addButton.Text = "Tạo đơn nhập";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 252;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 253;
            this.label1.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 254;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 255;
            this.label4.Text = "Tổng Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(739, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 256;
            this.label5.Text = "Nhà Cung Cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 257;
            this.label6.Text = "Ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 25);
            this.label7.TabIndex = 258;
            this.label7.Text = "Các loại sản phẩm đã thêm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(725, 750);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 25);
            this.label8.TabIndex = 259;
            this.label8.Text = "Tổng Tiền Hóa Đơn";
            // 
            // ImportOrderManager2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 1076);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_total_Amount);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.cbb_ncc);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.txt_tongTien);
            this.Controls.Add(this.txt_giaNhap);
            this.Controls.Add(this.cbb_tenSP);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ImportOrderManager2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.ComboBox cbb_tenSP;
        private System.Windows.Forms.TextBox txt_giaNhap;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.ComboBox cbb_ncc;
        private System.Windows.Forms.DateTimePicker date_time;
        private System.Windows.Forms.TextBox txt_total_Amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}