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
    public partial class RevenueCorrelation : Form
    {
        public RevenueCorrelation()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        private void vebieudo()
        {
            try
            {
                // Lấy năm và hai tháng từ giao diện
                int nam = dateTimePicker1.Value.Year;
                int thang1 = int.Parse(txtThang1.Text);
                int thang2 = int.Parse(txtThang2.Text);

                // Mở kết nối đến cơ sở dữ liệu
                db.openConnection();

                // Gọi hàm GetDoanhThuTuongQuanHaiThang để lấy dữ liệu
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetDoanhThuTuongQuanHaiThang(@Nam, @Thang1, @Thang2)", db.getConnection))
                {
                    cmd.Parameters.AddWithValue("@Nam", nam);
                    cmd.Parameters.AddWithValue("@Thang1", thang1);
                    cmd.Parameters.AddWithValue("@Thang2", thang2);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Lấy doanh thu của hai tháng và tỷ lệ thay đổi
                        decimal doanhThuThang1 = (decimal)reader["DoanhThu_Thang1"];
                        decimal doanhThuThang2 = (decimal)reader["DoanhThu_Thang2"];
                        decimal? tyLeThayDoi = reader["TyLeThayDoi"] as decimal?;

                        // Xóa dữ liệu và thiết lập lại Chart control
                        chartDoanhThu.Series.Clear();
                        chartDoanhThu.ChartAreas.Clear();
                        chartDoanhThu.ChartAreas.Add(new ChartArea("MainArea"));

                        // Series cho Doanh thu dạng cột
                        var seriesDoanhThu = new Series("Doanh thu");
                        seriesDoanhThu.ChartType = SeriesChartType.Column;
                        seriesDoanhThu.Points.AddXY($"Tháng {thang1}", doanhThuThang1);
                        seriesDoanhThu.Points.AddXY($"Tháng {thang2}", doanhThuThang2);

                        // Series cho Tỷ lệ thay đổi dạng đường
                        var seriesTyLe = new Series("Tỷ lệ thay đổi (%)");
                        seriesTyLe.ChartType = SeriesChartType.Line;
                        seriesTyLe.YAxisType = AxisType.Secondary;  // Sử dụng trục Y phụ cho tỷ lệ phần trăm
                        seriesTyLe.Points.AddXY($"Tháng {thang1}", 0);
                        seriesTyLe.Points.AddXY($"Tháng {thang2}", tyLeThayDoi ?? 0);

                        // Thêm series vào Chart
                        chartDoanhThu.Series.Add(seriesDoanhThu);
                        chartDoanhThu.Series.Add(seriesTyLe);

                        // Cấu hình trục Y phụ cho tỷ lệ thay đổi
                        chartDoanhThu.ChartAreas["MainArea"].AxisY2.Title = "Tỷ lệ thay đổi (%)";
                        chartDoanhThu.ChartAreas["MainArea"].AxisY2.Enabled = AxisEnabled.True;
                    }
                    reader.Close();
                }

                // Đóng kết nối
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            vebieudo();
        }
    }
}
