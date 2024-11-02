using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSQuanLyBanHang.Manager
{
    public partial class EnterCode : Form
    {
        private string _randomCode;
        public EnterCode(string randomCode)
        {
            InitializeComponent();
            _randomCode = randomCode;
          
        }

        private void btt_verify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Code.Text))
            {
                MessageBox.Show("Please enter your code", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_randomCode == txt_Code.Text.Trim())
            {
                ResetPassword resetPass = new ResetPassword();
                resetPass.typeAccount = 1;
                this.Hide();
                if (resetPass.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong code", "Code Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
