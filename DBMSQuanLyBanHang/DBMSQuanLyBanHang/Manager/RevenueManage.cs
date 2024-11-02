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
using System.Windows.Forms.DataVisualization.Charting;

namespace DBMSQuanLyBanHang.Manager
{
    public partial class RevenueManage : Form
    {
        public RevenueManage()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();




        private void buttonDoanhThuTheoNam_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ DateTimePicker
                DateTime date = dateTimePicker.Value; // Lấy giá trị DateTime

                // Mở kết nối
                db.openConnection();

                using (SqlCommand cmd = new SqlCommand("SELECT dbo.GetDoanhThuTheoNam(@Nam)", db.getConnection))
                {
                    // Truyền tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@Nam", date);

                    // Lấy kết quả từ câu lệnh SQL
                    object result = cmd.ExecuteScalar();

                    // Chuyển đổi kết quả sang decimal, nếu không có giá trị thì dùng 0
                    decimal doanhThu = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    // Hiển thị kết quả trên giao diện
                    lblDoanhThu.Text = $"Doanh thu theo năm {date.Year}: {doanhThu:N2} VND";
                }

                // Đóng kết nối
                db.closeConnection();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }




        private void buttonDoanhThuTheoNgay_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngayCanTinh = dateTimePicker.Value;

                db.openConnection();

                using (SqlCommand cmd = new SqlCommand("SELECT dbo.GetDoanhThuTheoNgay(@Ngay)", db.getConnection))
                {
                    cmd.Parameters.AddWithValue("@Ngay", ngayCanTinh.Date);

                    object result = cmd.ExecuteScalar();

                    double doanhThu = result != DBNull.Value ? Convert.ToDouble(result) : 0;

                    lblDoanhThu.Text = $"Doanh thu theo ngày {ngayCanTinh.ToString("dd/MM/yyyy")}: {doanhThu:N2} VND";
                }

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void buttonDoanhThuTheoThang_Click(object sender, EventArgs e)
        {
            try
            {
                // Giả sử bạn có một DateTimePicker với tên là dateTimePickerThangNam
                DateTime thangNam = dateTimePicker.Value; // Lấy giá trị từ DateTimePicker
                int thang = thangNam.Month; // Lấy tháng
                int nam = thangNam.Year;    // Lấy năm

                // Mở kết nối
                db.openConnection();

                using (SqlCommand cmd = new SqlCommand("SELECT dbo.GetDoanhThuTheoThang(@ThangNam)", db.getConnection))
                {
                    // Truyền tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@ThangNam", thangNam);

                    // Lấy kết quả từ câu lệnh SQL
                    object result = cmd.ExecuteScalar();

                    // Chuyển đổi kết quả sang decimal, nếu không có giá trị thì dùng 0
                    decimal doanhThu = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    // Hiển thị kết quả trên giao diện
                    lblDoanhThu.Text = $"Doanh thu theo tháng {thang}/{nam}: {doanhThu:N2} VND";
                }

                // Đóng kết nối
                db.closeConnection();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        
    }
}
