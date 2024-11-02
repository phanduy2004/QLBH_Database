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
    public partial class EmployeeManager : Form
    {
        MY_DB db = new MY_DB();
        public EmployeeManager()
        {
            InitializeComponent();
        }
        
        private void LoadData()
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHAN_VIEN", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView_NhanVien.DataSource = dataTable;
            db.closeConnection();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string hoNV = textBoxHoNV.Text;
            string tenNV = textBoxTenNV.Text;
            DateTime ngaySinh = dateTimePickerNgaySinh.Value;
            string sdt = textBoxSDT.Text;
            DateTime ngayTuyenDung = dateTimePickerNgayTuyenDung.Value;
            string diaChi = textBoxDiaChi.Text;

            db.openConnection();
            SqlCommand cmd = new SqlCommand("sp_ThemNhanVien", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@HoNV", SqlDbType.VarChar).Value = hoNV;
            cmd.Parameters.Add("@TenNV", SqlDbType.VarChar).Value = tenNV;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sdt;
            cmd.Parameters.Add("@NgayTuyenDung", SqlDbType.Date).Value = ngayTuyenDung;
            cmd.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = diaChi;

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại.", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string tenNV = textBoxSearch.Text;

            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemNhanVien(@TenNV)", db.getConnection);
            cmd.Parameters.AddWithValue("@TenNV", tenNV);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView_NhanVien.DataSource = dataTable;

            db.closeConnection();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int maNV = Convert.ToInt32(textBoxMaNV.Text);
            string hoNV = textBoxHoNV.Text;
            string tenNV = textBoxTenNV.Text;
            DateTime ngaySinh = dateTimePickerNgaySinh.Value;
            string sdt = textBoxSDT.Text;
            DateTime ngayTuyenDung = dateTimePickerNgayTuyenDung.Value;
            string diaChi = textBoxDiaChi.Text;

            db.openConnection();
            SqlCommand cmd = new SqlCommand("sp_SuaNhanVien", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = maNV;
            cmd.Parameters.Add("@HoNV", SqlDbType.VarChar).Value = hoNV;
            cmd.Parameters.Add("@TenNV", SqlDbType.VarChar).Value = tenNV;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sdt;
            cmd.Parameters.Add("@NgayTuyenDung", SqlDbType.Date).Value = ngayTuyenDung;
            cmd.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = diaChi;

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật nhân viên thành công!", "Cập Nhật Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại.", "Cập Nhật Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int maNV = Convert.ToInt32(textBoxMaNV.Text);

            db.openConnection();
            SqlCommand cmd = new SqlCommand("sp_XoaNhanVien", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = maNV;

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa nhân viên thành công!", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại.", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }
    }
}
