using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyPhong
{
    public partial class ShowRoom : Form
    {
        Fution fn = new Fution();
        String query;
        public ShowRoom()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem form trước đó là gì
            if (this.Owner != null)
            {
                // Hiển thị form trước đó
                this.Owner.Show();
            }

            // Đóng form hiện tại
            this.Close();
        }
        private void Load_Data()
        {
            query = "SELECT * FROM room";
            DataSet ds = fn.GetData(query);
            showrooms.DataSource = ds.Tables[0];
        }
        private void SearchRoom(string keyword)
        {
            // Kiểm tra xem từ khóa có được nhập không rỗng không
            if (!string.IsNullOrEmpty(keyword))
            {
                // Tạo câu truy vấn SQL để tìm kiếm phòng với từ khóa xuất hiện trong cột roomNo hoặc trong cột khác
                string query = $"SELECT * FROM room WHERE roomNo LIKE '%{keyword}%'";

                // Thực hiện truy vấn SQL và cập nhật DataGridView
                DataSet ds = fn.GetData(query);
                showrooms.DataSource = ds.Tables[0];
            }
            else
            {
                // Nếu TextBox trống, hiển thị tất cả phòng
                Load_Data();
            }
        }

        private void btndeleteRoom_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (showrooms.SelectedRows.Count > 0)
            {
                // Lấy mã phòng từ dòng được chọn
                string roomNo = showrooms.SelectedRows[0].Cells["roomNo"].Value.ToString();

                // Xác nhận với người dùng trước khi xóa phòng
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phòng {roomNo}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện câu truy vấn SQL để xóa phòng
                    query = $"DELETE FROM room WHERE roomNo = '{roomNo}'";
                    fn.setData(query, "Phòng đã được xóa.");

                    // Cập nhật lại DataGridView để hiển thị thông tin mới
                    Load_Data();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearchRoom_TextChanged(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ TextBox
            string keyword = btnSearchRoom.Text.Trim();

            // Gọi phương thức SearchRoom để thực hiện tìm kiếm
            SearchRoom(keyword);
        }

        private void ShowRoom_Load(object sender, EventArgs e)
        {
            Load_Data();

        }

        private void showrooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddroom_Click(object sender, EventArgs e)
        {
            AddRoom ad = new AddRoom();
            ad.Show();
        }
    }
}
