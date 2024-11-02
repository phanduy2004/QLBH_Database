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
    public partial class ImportOrderManager : Form
    {
        public ImportOrderManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các điều khiển
            DateTime ngayNhap = dateTimePicker1.Value;
            int maNCC;

            // Kiểm tra mã nhà cung cấp có hợp lệ hay không
            if (!int.TryParse(textBox1.Text, out maNCC))
            {
                MessageBox.Show("Mã nhà cung cấp phải là số nguyên.");
                return;
            }

            // Xây dựng chuỗi chi tiết đơn nhập hàng từ DataGridView
            string chiTietDonNhap = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSanPham"].Value != null &&
                    row.Cells["SoLuong"].Value != null &&
                    row.Cells["GiaNhap"].Value != null)
                {
                    int maSP = Convert.ToInt32(row.Cells["MaSanPham"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    decimal giaNhap = Convert.ToDecimal(row.Cells["GiaNhap"].Value);

                    // Ghép các giá trị thành chuỗi 'MaSP,SoLuong,DonGia;'
                    chiTietDonNhap += $"{maSP},{soLuong},{giaNhap};";
                }
            }

            // Kiểm tra nếu chuỗi chi tiết rỗng
            if (string.IsNullOrEmpty(chiTietDonNhap))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một sản phẩm.");
                return;
            }

            // Sử dụng lớp MY_DB để kết nối với cơ sở dữ liệu
            MY_DB db = new MY_DB();
            SqlConnection conn = db.getConnection;

            try
            {
                db.openConnection(); // Mở kết nối

                using (SqlCommand cmd = new SqlCommand("ThemDonNhapHang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@NgayNH", ngayNhap);
                    cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                    cmd.Parameters.AddWithValue("@ChiTietDonNhap", chiTietDonNhap);

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm đơn nhập hàng thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đơn nhập hàng: " + ex.Message);
            }
            finally
            {
                db.closeConnection(); // Đóng kết nối
            }
        }
    }
}
