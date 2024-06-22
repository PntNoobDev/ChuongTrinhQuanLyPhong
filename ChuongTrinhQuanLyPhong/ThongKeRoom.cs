using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ChuongTrinhQuanLyPhong
{
    public partial class ThongKeRoom : Form
    {
        Fution fn = new Fution();
        String query;

        public ThongKeRoom()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
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
                    string sql = "SELECT name, roomNo FROM newStudent";

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
                        CrystalReport1 report = new CrystalReport1();

                        // Đổ dữ liệu từ DataTable vào Crystal Report
                        report.SetDataSource(dataTable);

                        // Hiển thị báo cáo trong CrystalReportViewer
                        crystalReportViewer1.ReportSource = report;
                        crystalReportViewer1.Refresh();
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

        private void ThongKeRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
