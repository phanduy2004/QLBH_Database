using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSQuanLyBanHang.Manager
{
    public partial class ResetPassword : Form
    {
        internal int typeAccount;
        public ResetPassword()
        {
            InitializeComponent();
        }

        MY_DB db = new MY_DB();
        ForgotPassword f = new ForgotPassword();
        string email;

        private void button2_Click(object sender, EventArgs e)
        {
            string pass = txt_newpass.Text;
            email = f.GetMail;

            // Kiểm tra xem email có giá trị hợp lệ không
            if (!string.IsNullOrEmpty(email))
            {
                try
                {
                    // Mở kết nối đến cơ sở dữ liệu
                    db.openConnection();

                    // Thực hiện truy vấn cập nhật mật khẩu
                    SqlCommand command = new SqlCommand("Pr_updateMatkhau", db.getConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MatKhauUser", SqlDbType.VarChar).Value = pass;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;

                    // Kiểm tra kết quả của truy vấn
                    if (command.ExecuteNonQuery() == 1)
                    {
                        // Nếu thành công, thông báo và đóng kết nối
                        MessageBox.Show("Password reset successfully.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Nếu không thành công, thông báo lỗi
                        MessageBox.Show("Error resetting password.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có xảy ra
                    MessageBox.Show("An error occurred: " + ex.Message, "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Đảm bảo kết nối được đóng
                    db.closeConnection();
                }
            }
            else
            {
                // Nếu không tìm thấy email, hiển thị thông báo lỗi
                MessageBox.Show("Email not found.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
