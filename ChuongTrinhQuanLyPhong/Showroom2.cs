using System;
using System.Collections;
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
    public partial class Showroom2 : Form
    {

        Fution fn = new Fution();
        String query;
        public Showroom2()
        {
            InitializeComponent();
        }

        private void Showroom2_Load(object sender, EventArgs e)
        {

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
        private void btnExit_Click_1(object sender, EventArgs e)
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

        private void btnSearchSV_TextChanged(object sender, EventArgs e)
        {
            string keyword = btnSearchSV.Text.Trim();
            SearchStudent(keyword);
        }
        private void UpdateData()
        {
            // Thực hiện các công việc cập nhật dữ liệu ở đây
            // Ví dụ:
            // Cập nhật dữ liệu trong cơ sở dữ liệu

            // Hiển thị thông báo cho người dùng
            MessageBox.Show("Dữ liệu đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SearchStudent(string keyword)
        {
            // Kiểm tra xem từ khóa có được nhập không rỗng không
            if (!string.IsNullOrEmpty(keyword))
            {
                // Tạo câu truy vấn SQL để tìm kiếm sinh viên với từ khóa giống nhất
                query = $@"
            SELECT * 
            FROM newStudent 
            WHERE 
                name LIKE '%{keyword}%' OR 
                fname LIKE '%{keyword}%' OR 
                mname LIKE '%{keyword}%' OR 
                email LIKE '%{keyword}%' OR 
                paddress LIKE '%{keyword}%' OR 
                college LIKE '%{keyword}%' OR 
                idproof LIKE '%{keyword}%' OR 
                roomNo LIKE '%{keyword}%' OR 
                living LIKE '%{keyword}%'";

                DataSet ds = fn.GetData(query);
                dgvStundent.DataSource = ds.Tables[0];
            }
            else
            {
                // Nếu ô tìm kiếm trống, hiển thị tất cả sinh viên
                Load_Sinhvien();
            }
        }
        private void Load_Sinhvien()
        {
            query = "SELECT * FROM newStudent ";
            DataSet ds = fn.GetData(query);
            dgvStundent.DataSource = ds.Tables[0];



            dgvStundent.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            // Lấy ra index của dòng được chọn trong DataGridView
            int selectedRowIndex = dgvStundent.SelectedCells[0].RowIndex;

            // Lấy ra giá trị của cột ID của dòng được chọn
            int studentID = Convert.ToInt32(dgvStundent.Rows[selectedRowIndex].Cells["ID"].Value);

            // Xác nhận việc xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Xây dựng câu truy vấn SQL để xóa sinh viên có ID tương ứng
                string deleteQuery = $"DELETE FROM newStudent WHERE ID = {studentID}";

                // Thực thi câu truy vấn xóa dữ liệu
                fn.setData(deleteQuery, "Sinh viên đã được xóa");

                // Load lại dữ liệu sau khi xóa
                Load_Sinhvien();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // Gọi phương thức UpdateData để cập nhật dữ liệu
            UpdateData();

            // Sau khi cập nhật, load lại DataGridView để người dùng xem
            Load_Sinhvien();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent st = new AddStudent();
            st.Show();
            this.Hide();
        }
    }
}
