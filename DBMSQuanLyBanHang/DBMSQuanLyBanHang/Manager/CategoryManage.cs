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
    public partial class CategoryManage : Form
    {
        MY_DB db = new MY_DB(); // Kết nối đến cơ sở dữ liệu

        public CategoryManage()
        {
            InitializeComponent();
        }

        

        // Tải dữ liệu sản phẩm vào DataGridView
        private void LoadData()
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SAN_PHAM", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView_SanPham.DataSource = dataTable; // Hiển thị dữ liệu lên DataGridView
            db.closeConnection();
        }

        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int maLoaiSP = Convert.ToInt32(textBoxMaLoaiSP.Text);
            string tenSP = textBoxTenSP.Text;
            decimal giaNhap = Convert.ToDecimal(textBoxGiaNhap.Text);
            decimal giaBan = Convert.ToDecimal(textBoxGiaBan.Text);
            int soLuong = Convert.ToInt32(textBoxSoLuong.Text);

            db.openConnection();
            SqlCommand cmd = new SqlCommand("sp_ThemSanPham", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaLoaiSP", SqlDbType.Int).Value = maLoaiSP;
            cmd.Parameters.Add("@TenSP", SqlDbType.VarChar).Value = tenSP;
            cmd.Parameters.Add("@GiaNhap", SqlDbType.Decimal).Value = giaNhap;
            cmd.Parameters.Add("@GiaBan", SqlDbType.Decimal).Value = giaBan;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm sản phẩm thành công!", "Thêm Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại.", "Thêm Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int maSP = Convert.ToInt32(textBoxMaSP.Text); // Lấy mã sản phẩm từ TextBox

            db.openConnection();
            SqlCommand cmd = new SqlCommand("sp_XoaSanPham", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = maSP;

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa sản phẩm thành công!", "Xóa Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại.", "Xóa Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int maSP = Convert.ToInt32(textBoxMaSP.Text); // Mã sản phẩm
            int maLoaiSP = Convert.ToInt32(textBoxMaLoaiSP.Text);
            string tenSP = textBoxTenSP.Text;
            decimal giaNhap = Convert.ToDecimal(textBoxGiaNhap.Text);
            decimal giaBan = Convert.ToDecimal(textBoxGiaBan.Text);
            int soLuong = Convert.ToInt32(textBoxSoLuong.Text);

            db.openConnection();
            SqlCommand cmd = new SqlCommand("sp_SuaSanPham", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = maSP;
            cmd.Parameters.Add("@MaLoaiSP", SqlDbType.Int).Value = maLoaiSP;
            cmd.Parameters.Add("@TenSP", SqlDbType.VarChar).Value = tenSP;
            cmd.Parameters.Add("@GiaNhap", SqlDbType.Decimal).Value = giaNhap;
            cmd.Parameters.Add("@GiaBan", SqlDbType.Decimal).Value = giaBan;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Cập Nhật Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại.", "Cập Nhật Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string tenSP = textBoxSearch.Text;

            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemSanPham(@TenSP)", db.getConnection);
            cmd.Parameters.Add("@TenSP", SqlDbType.VarChar).Value = tenSP;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView_SanPham.DataSource = dataTable;
            db.closeConnection();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CategoryManage_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
