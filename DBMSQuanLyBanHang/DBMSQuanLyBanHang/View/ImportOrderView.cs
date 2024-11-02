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

namespace DBMSQuanLyBanHang.View
{
    public partial class ImportOrderView : Form
    {
        public ImportOrderView()
        {
            InitializeComponent();
            LoadReceiptList();
        }
        private void LoadReceiptList()
        {
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM v_DanhMucDonNhapHang", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            // Đổi tên
            dataGridView1.Columns["MaDonNH"].HeaderText = "Mã Đơn Nhập Hàng";
            dataGridView1.Columns["NgayNH"].HeaderText = "Ngày Nhập Hàng";
            dataGridView1.Columns["TriGiaDonNH"].HeaderText = "Trị Giá Đơn Nhập Hàng";
            dataGridView1.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
        }
    }
}
