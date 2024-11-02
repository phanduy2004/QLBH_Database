using DBMSQuanLyBanHang;
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
    public partial class SuppilerManage : Form
    {
        MY_DB db = new MY_DB();
        public SuppilerManage()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string tenNCC = textBoxTenNCC.Text;
            string diaChi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;

            db.openConnection();
            SqlCommand cmd = new SqlCommand("sp_ThemNhaCungCap", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@TenNCC", SqlDbType.VarChar).Value = tenNCC;
            cmd.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = diaChi;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sdt;

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thêm Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp thất bại.", "Thêm Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int maNCC = Convert.ToInt32(textBoxMaNCC.Text);

            db.openConnection();
            SqlCommand cmd = new SqlCommand("sp_XoaNhaCungCap", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNCC", SqlDbType.Int).Value = maNCC;

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa nhà cung cấp thành công!", "Xóa Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa nhà cung cấp thất bại.", "Xóa Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int maNCC = Convert.ToInt32(textBoxMaNCC.Text); // Mã nhà cung cấp
            string tenNCC = textBoxTenNCC.Text;
            string diaChi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;

            db.openConnection();
            SqlCommand cmd = new SqlCommand("sp_SuaNhaCungCap", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNCC", SqlDbType.Int).Value = maNCC;
            cmd.Parameters.Add("@TenNCC", SqlDbType.VarChar).Value = tenNCC;
            cmd.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = diaChi;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sdt;

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Cập Nhật Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật nhà cung cấp thất bại.", "Cập Nhật Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void SuppilerManage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHA_CUNG_CAP", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView_NCC.DataSource = dataTable;
            db.closeConnection();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
