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
    public partial class CategoryView : Form
    {
        public CategoryView()
        {
            InitializeComponent();
            LoadProductList();
        }
        MY_DB db = new MY_DB();
        private void LoadProductList()
        {
            MY_DB db = new MY_DB();  // Use MY_DB class for connection handling

            try
            {
                db.openConnection(); // Open the connection using MY_DB

                // Create and execute SQL command
                SqlCommand cmd = new SqlCommand("SELECT * FROM v_DanhMucSanPham", db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind data to DataGridView
                dataGridView1.DataSource = dataTable;

                // Rename columns
                dataGridView1.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
                dataGridView1.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
                dataGridView1.Columns["GiaNhap"].HeaderText = "Giá Nhập";
                dataGridView1.Columns["GiaBan"].HeaderText = "Giá Bán";
                dataGridView1.Columns["SoLuong"].HeaderText = "Số Lượng";
                dataGridView1.Columns["TenLoaiSP"].HeaderText = "Tên Loại Sản Phẩm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                db.closeConnection(); // Ensure the connection is closed
            }
        }

    }
}
