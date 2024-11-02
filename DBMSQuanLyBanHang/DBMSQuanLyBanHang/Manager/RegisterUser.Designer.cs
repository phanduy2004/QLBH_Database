namespace DBMSQuanLyBanHang.Manager
{
    partial class RegisterUser
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
            this.cbb_maNV = new System.Windows.Forms.ComboBox();
            this.cbb_viTri = new System.Windows.Forms.ComboBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbb_maNV
            // 
            this.cbb_maNV.FormattingEnabled = true;
            this.cbb_maNV.Location = new System.Drawing.Point(507, 124);
            this.cbb_maNV.Name = "cbb_maNV";
            this.cbb_maNV.Size = new System.Drawing.Size(370, 33);
            this.cbb_maNV.TabIndex = 148;
            // 
            // cbb_viTri
            // 
            this.cbb_viTri.FormattingEnabled = true;
            this.cbb_viTri.Location = new System.Drawing.Point(507, 220);
            this.cbb_viTri.Name = "cbb_viTri";
            this.cbb_viTri.Size = new System.Drawing.Size(370, 33);
            this.cbb_viTri.TabIndex = 149;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(507, 407);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(370, 31);
            this.txt_username.TabIndex = 150;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(507, 503);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(370, 31);
            this.txt_password.TabIndex = 151;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 97);
            this.button1.TabIndex = 152;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(507, 312);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(370, 31);
            this.txt_email.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 155;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 156;
            this.label2.Text = "Vị Trí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 157;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 158;
            this.label4.Text = "Tên Tài Khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 159;
            this.label5.Text = "Mật Khẩu";
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 777);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.cbb_viTri);
            this.Controls.Add(this.cbb_maNV);
            this.Name = "RegisterUser";
            this.Text = "RegisterUser";
            this.Load += new System.EventHandler(this.RegisterUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbb_maNV;
        private System.Windows.Forms.ComboBox cbb_viTri;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}