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
    public partial class ReceiptManager : Form
    {
        public ReceiptManager()
        {
            InitializeComponent();
        }
        public static int maHD;
        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các điều khiển
            DateTime ngay = dateTimePicker1.Value;  // DateTimePicker để chọn ngày
            int maNV;

            // Kiểm tra mã nhân viên có hợp lệ không
            if (!int.TryParse(textBox1.Text, out maNV))
            {
                MessageBox.Show("Mã nhân viên phải là số nguyên.");
                return;
            }

            // Xây dựng chuỗi chi tiết hóa đơn từ DataGridView
            string chiTietHoaDon = "";
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["MaSanPham"].Value != null &&
                    row.Cells["SoLuong"].Value != null)
                {
                    int maSP = Convert.ToInt32(row.Cells["MaSanPham"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

                    // Lấy đơn giá sản phẩm từ database
                    decimal donGia = GetDonGiaSanPham(maSP);

                    // Ghép các giá trị thành chuỗi 'MaSP,SoLuong;'
                    chiTietHoaDon += $"{maSP},{soLuong};";

                    // Tính tổng tiền
                    tongTien += donGia * soLuong;
                }
            }

            // Kiểm tra nếu chuỗi chi tiết rỗng
            if (string.IsNullOrEmpty(chiTietHoaDon))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một sản phẩm.");
                return;
            }

            // Kết nối tới CSDL và thực thi stored procedure
            MY_DB db = new MY_DB();
            SqlConnection conn = db.getConnection; // Sử dụng đối tượng MY_DB để kết nối

            try
            {
                db.openConnection(); // Mở kết nối

                using (SqlCommand cmd = new SqlCommand("ThemHoaDon", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@Ngay", ngay);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@ChiTietHoaDon", chiTietHoaDon);

                    // Thêm tham số đầu ra để nhận giá trị maHD
                    SqlParameter outputIdParam = new SqlParameter("@MaHD", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();

                    // Lấy mã hóa đơn mới tạo ra
                    maHD = (int)outputIdParam.Value;

                    MessageBox.Show("Thêm hóa đơn thành công. Mã hóa đơn là: " + maHD);

                    // Hiển thị Form3 với tổng tiền và chi tiết hóa đơn
                    ReceiptStatus form3 = new ReceiptStatus(chiTietHoaDon, tongTien);
                    form3.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn: " + ex.Message);
            }
            finally
            {
                db.closeConnection(); // Đóng kết nối
            }
        }


        private decimal GetDonGiaSanPham(int maSP)
        {
            decimal donGia = 0;
            MY_DB db = new MY_DB();
            SqlConnection conn = db.getConnection;

            try
            {
                db.openConnection(); // Mở kết nối

                // Tạo truy vấn SQL để lấy giá của sản phẩm từ bảng SAN_PHAM
                string query = "SELECT GiaBan FROM SAN_PHAM WHERE MaSP = @MaSP";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);

                    // Thực thi truy vấn và lấy giá bán
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        donGia = Convert.ToDecimal(result);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm có mã: " + maSP);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy đơn giá sản phẩm: " + ex.Message);
            }
            finally
            {
                db.closeConnection(); // Đóng kết nối
            }

            return donGia;
        }
    }
}
