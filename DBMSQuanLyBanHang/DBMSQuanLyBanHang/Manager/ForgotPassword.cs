using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSQuanLyBanHang.Manager
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        string randomCode;
        public static string to;
        public string GetMail
        {
            get { return to; }
        }
        private void verifyBtn_Click(object sender, EventArgs e)
        {

            if (txt_email.Text.Trim() == "")
            {
                MessageBox.Show("please enter your email adddress", "forget password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();

            MailMessage message = new MailMessage();
            MessageBox.Show(randomCode);
            to = txt_email.Text.Trim();

            from = "conlocmuahe2004@gmail.com"; // Enter your Gmail address here
            pass = "yhaf zcmu alsl bzwo"; // Enter your Gmail password here
            messageBody = "Code: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "password reset code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                EnterCode code = new EnterCode(randomCode);
                smtp.Send(message);
                MessageBox.Show("Code sent successfully", "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //timerSendCode.Enabled = true;

                code.Show(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
