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
    public partial class CategoryTypeView : Form
    {
        public CategoryTypeView()
        {
            InitializeComponent();
            LoadDanhMucLoaiSanPham();
        }
        private void LoadDanhMucLoaiSanPham()
        {
            MY_DB db = new MY_DB();  // Use the MY_DB class for connection handling

            try
            {
                db.openConnection(); // Open the connection using MY_DB

                // SQL query to get data from the view
                string query = "SELECT * FROM v_DanhMucLoaiSanPham";

                // Use SqlDataAdapter to retrieve the data
                SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection);

                // Create a DataTable to hold the data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with data from the adapter
                adapter.Fill(dataTable);

                // Assign the data to the DataGridView
                dataGridView1.DataSource = dataTable;
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
