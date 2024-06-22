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

namespace ChuongTrinhQuanLyPhong
{
    public partial class ThongKeNhanVien : Form
    {
        Fution fn = new Fution();
        String query;


        public ThongKeNhanVien()
        {
            InitializeComponent();
        }

        private void ThongKeNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                // Tạo kết nối tới cơ sở dữ liệu
                string connectionString = "Data Source=DESKTOP-HMIBQ3K\\SQLEXPRESS;Initial Catalog=hostel;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo câu lệnh SQL để lấy dữ liệu sinh viên
                    string sql = "SELECT id, ename, emobile, epaddress, working FROM newEmployee";

                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                    // Tạo DataTable để lưu trữ dữ liệu
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                    adapter.Fill(dataTable);

                    // Kiểm tra xem DataTable có dữ liệu hay không
                    if (dataTable.Rows.Count > 0)
                    {
                        // Tạo một đối tượng Crystal Report
                        CrystalReport2 report = new CrystalReport2();

                        // Đổ dữ liệu từ DataTable vào Crystal Report
                        report.SetDataSource(dataTable);

                        // Hiển thị báo cáo trong CrystalReportViewer
                        crystalReportViewer2.ReportSource = report;
                        crystalReportViewer2.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
