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
    public partial class SupplierView : Form
    {
        public SupplierView()
        {
            InitializeComponent();
            LoadNhaCungCap();
        }
        MY_DB db = new MY_DB();
        private void LoadNhaCungCap()
        {
            // Mở kết nối cơ sở dữ liệu
            db.openConnection();
            // Tạo SqlCommand để truy vấn view
            SqlCommand cmd = new SqlCommand("SELECT * FROM v_DanhMucNhaCungCap", db.getConnection);
            // Tạo SqlDataAdapter và DataTable để lấy kết quả
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                // Điền dữ liệu vào DataTable
                da.Fill(dt);
                // Kiểm tra nếu DataTable có dữ liệu
                if (dt.Rows.Count > 0)
                {
                    // Hiển thị dữ liệu trong DataGridView
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có nhà cung cấp nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Lỗi SQL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối cơ sở dữ liệu
                db.closeConnection();
            }
        }
    }
}
