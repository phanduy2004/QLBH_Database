using DBMSQuanLyBanHang.Manager;
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

namespace DBMSQuanLyBanHang
{
    public partial class ReceiptStatus : Form
    {
        public ReceiptStatus()
        {
            InitializeComponent();
        }
        public ReceiptStatus(string chiTietHoaDon, decimal tongTien)
        {
            InitializeComponent();

            // Hiển thị tổng tiền
            label1.Text = "Tổng Tiền: " + tongTien.ToString("C");

            // Hiển thị các sản phẩm và giá
            string[] chiTietItems = chiTietHoaDon.Split(';');
            foreach (string item in chiTietItems)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] productInfo = item.Split(',');
                    if (productInfo.Length == 2)
                    {
                        int maSP = int.Parse(productInfo[0]);
                        int soLuong = int.Parse(productInfo[1]);

                        // Thêm vào DataGridView hoặc ListBox (tùy bạn thiết kế)
                        dataGridView1.Rows.Add(maSP, soLuong);
                    }
                }
            }
        }

        MY_DB db = new MY_DB();
        int maHD = ReceiptManager.maHD;

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = db.getConnection)
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_XacNhanThanhToan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHD", maHD );

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Thanh toán đã được xác nhận.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    db.closeConnection();
                }
            }
            MessageBox.Show("Thanh toán đã được xác nhận.");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = db.getConnection)
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_HuyHoaDon", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHD", maHD);

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Hóa đơn đã được xử lý.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    db.closeConnection();
                }
            }
            MessageBox.Show("Hóa đơn đã bị hủy.");
            this.Close();
        }
    }
}
