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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }
        MY_DB  MYDB = new MY_DB();
        private void RegisterUser_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("TimNhanVienChuaCoTaiKhoan", MYDB.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable table = dulieusp(cmd);
            cbb_maNV.DataSource = table;
            cbb_maNV.DisplayMember = "MaNV";
            cbb_maNV.ValueMember = "MaNV";
            cbb_viTri.Items.Add("NhanVien");
            cbb_viTri.Items.Add("QuanLy");
        }
        public DataTable dulieusp(SqlCommand cmd)
        {

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(cbb_maNV.SelectedValue);
            string vitri = cbb_viTri.Text;
            string tentk = txt_username.Text;
            string matkhau = txt_password.Text;
            string email = txt_email.Text;
            MYDB.openConnection();

            // Tạo SqlCommand cho thủ tục thêm user
            SqlCommand cmd = new SqlCommand("ThemUser", MYDB.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm các tham số cho thủ tục
            cmd.Parameters.AddWithValue("@MaUser", id);
            cmd.Parameters.AddWithValue("@TenUser", tentk);
            cmd.Parameters.AddWithValue("@MatKhauUser", matkhau);
            cmd.Parameters.AddWithValue("@ViTri", vitri);
            cmd.Parameters.AddWithValue ("@Email", email);

            int rowsAffected = cmd.ExecuteNonQuery();
            MYDB.closeConnection();

            if (rowsAffected > 0)
            {
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
