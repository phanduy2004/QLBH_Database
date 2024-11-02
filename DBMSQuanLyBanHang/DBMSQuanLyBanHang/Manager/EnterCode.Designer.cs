namespace DBMSQuanLyBanHang.Manager
{
    partial class EnterCode
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
            this.btt_verify = new System.Windows.Forms.Button();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt_verify
            // 
            this.btt_verify.Location = new System.Drawing.Point(255, 270);
            this.btt_verify.Name = "btt_verify";
            this.btt_verify.Size = new System.Drawing.Size(227, 42);
            this.btt_verify.TabIndex = 5;
            this.btt_verify.Text = "Send";
            this.btt_verify.UseVisualStyleBackColor = true;
            this.btt_verify.Click += new System.EventHandler(this.btt_verify_Click);
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(172, 192);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(401, 31);
            this.txt_Code.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hãy nhập code mà bận nhận được:";
            // 
            // EnterCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btt_verify);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.label1);
            this.Name = "EnterCode";
            this.Text = "EnterCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_verify;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label1;
    }
}