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
    public partial class ImportOrderManager2 : Form
    {
        MY_DB MYDB = new MY_DB();   
        public ImportOrderManager2()
        {
            InitializeComponent();
        }

        private void TinhTongTienTatCaSanPham()
        {
            double tongTatCaSanPham = 0;

            // Lặp qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra xem dòng có giá trị hay không
                if (row.Cells["TongTien"].Value != null)
                {
                    // Cộng dồn tổng tiền
                    tongTatCaSanPham += Convert.ToDouble(row.Cells["TongTien"].Value);
                }
            }

            // Hiển thị tổng tiền
            txt_total_Amount.Text = tongTatCaSanPham.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbb_tenSP.SelectedValue != null && !string.IsNullOrEmpty(txt_soLuong.Text))
            {
                try
                {
                    // Get product details
                    string maSP = cbb_tenSP.SelectedValue.ToString(); // MaSP is bound as ValueMember
                    string tenSP = cbb_tenSP.Text; // TenSP is bound as DisplayMember
                    int soLuong = Convert.ToInt32(txt_soLuong.Text);
                    int tongtien = Convert.ToInt32(txt_tongTien.Text);
                    // Add new row to DataGridView
                    dataGridView1.Rows.Add(maSP, tenSP, soLuong, tongtien);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Số lượng phải là số nguyên hợp lệ.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng.");
            }
            TinhTongTienTatCaSanPham();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin đơn nhập
                int maNCC = Convert.ToInt32(cbb_ncc.SelectedValue.ToString());
                double tongtien = Convert.ToDouble(txt_tongTien.Text);
                DateTime dt = date_time.Value;

                // Mở kết nối cơ sở dữ liệu
                MYDB.openConnection();

                // Tạo SqlCommand cho thủ tục thêm đơn nhập
                SqlCommand cmd = new SqlCommand("Them_Don_Nhap", MYDB.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào thủ tục
                cmd.Parameters.Add("@MaNCC", SqlDbType.Int).Value = maNCC;
                cmd.Parameters.Add("@TriGiaDonNH", SqlDbType.Float).Value = tongtien;
                cmd.Parameters.Add("@NgayNH", SqlDbType.Date).Value = dt;

                // Thực hiện thủ tục thêm đơn nhập
                cmd.ExecuteNonQuery();

                // Lặp qua từng dòng trong DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["MaSP"].Value != null && row.Cells["SoLuong"].Value != null)
                    {
                        // Lấy giá trị mã sản phẩm và số lượng từ DataGridView
                        int maSP = Convert.ToInt32(row.Cells["MaSP"].Value);
                        int soLuongNhap = Convert.ToInt32(row.Cells["SoLuong"].Value);

                        // Tạo SqlCommand cho thủ tục cập nhật số lượng sản phẩm
                        SqlCommand updateCmd = new SqlCommand("Update_SoLuong_SanPham", MYDB.getConnection);
                        updateCmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số vào thủ tục cập nhật số lượng sản phẩm
                        updateCmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = maSP;
                        updateCmd.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = soLuongNhap;

                        // Thực hiện thủ tục cập nhật số lượng sản phẩm
                        updateCmd.ExecuteNonQuery();
                    }
                }

                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm đơn nhập và cập nhật số lượng sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có xảy ra
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng
                MYDB.closeConnection();
            }
        }

        private void cbb_tenSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Ensure the selected value is not null and can be converted to an integer
            if (cbb_tenSP.SelectedValue != null)
            {
                try
                {
                    // Cast the selected value to an integer
                    int productId = Convert.ToInt32(cbb_tenSP.SelectedValue.ToString());

                    // Open the connection
                    MYDB.openConnection();

                    // Create the SQL command and set the stored procedure name
                    SqlCommand cmd = new SqlCommand("TimKiemSanPhamTheoID", MYDB.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add the parameter for the product ID
                    cmd.Parameters.Add(new SqlParameter("@MaSP", productId));

                    // Execute the stored procedure and get the data
                    DataTable table = dulieusp(cmd);

                    // Check if any data is returned
                    if (table.Rows.Count > 0)
                    {
                        // Assuming the field name is "GiaNhap" in the DataTable
                        txt_giaNhap.Text = table.Rows[0]["GiaNhap"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No product found with ID: " + productId);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    MYDB.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Please select a valid product.");
            }
        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {
            double giaban = Double.Parse(txt_giaNhap.Text);

            int soluong = Convert.ToInt32(txt_soLuong.Text);

            double tongTien = soluong * giaban;
            txt_tongTien.Text = tongTien.ToString();
        }
        void refresh()
        {
            SqlCommand cmd = new SqlCommand("TimKiemTatCaSanPham", MYDB.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable table = dulieusp(cmd);
            cbb_tenSP.DataSource = table;
            cbb_tenSP.DisplayMember = "TenSP";
            cbb_tenSP.ValueMember = "MaSP";

            SqlCommand cmd1 = new SqlCommand("TimKiemTatCaNCC", MYDB.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            table = dulieusp(cmd1);
            cbb_ncc.DataSource = table;
            cbb_ncc.DisplayMember = "TenNCC";
            cbb_ncc.ValueMember = "MaNCC";
        }
        public DataTable dulieusp(SqlCommand cmd)
        {

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}

