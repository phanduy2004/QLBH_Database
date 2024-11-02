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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            try
            {
                // Lấy dữ liệu từ TextBox
               

                // Mở kết nối đến cơ sở dữ liệu
                db.getConnection.Open();

                // Tạo câu lệnh truy vấn
                string sqlQuery = "SELECT dbo.Fn_LoginUser(@username, @password)";
                SqlCommand command = new SqlCommand(sqlQuery, db.getConnection);

                // Thêm tham số cho câu truy vấn
                command.Parameters.AddWithValue("@username", user.Text.ToString());
                command.Parameters.AddWithValue("@password", pass.Text.ToString());

                // Sử dụng ExecuteScalar để lấy giá trị trả về từ hàm
                object resultObj = command.ExecuteScalar();
                int result = Convert.ToInt32(resultObj ?? 0); // Chuyển đổi giá trị trả về, mặc định là 0 nếu null

                // Kiểm tra kết quả trả về
                if (result == 1)
                {
                    Index index = new Index();
                    index.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo đóng kết nối sau khi hoàn thành
                if (db.getConnection.State == ConnectionState.Open)
                {
                    db.getConnection.Close();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();    
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegisterUser user = new RegisterUser();
            user.ShowDialog();
        }
    }
}
