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
    public partial class EmployeeView : Form
    {
        public EmployeeView()
        {
            InitializeComponent();
            LoadNhanVienData();
        }

        private void LoadNhanVienData()
        {
            MY_DB db = new MY_DB();  // Use your MY_DB class
            try
            {
                db.openConnection(); // Open the connection using MY_DB

                SqlCommand command = new SqlCommand("SELECT * FROM v_DanhMucNhanVien", db.getConnection); // Use the existing connection from MY_DB
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Assuming you have a DataGridView control named dgvNhanVien on your form
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection(); // Ensure the connection is closed after operation
            }
        }

    }
}
