using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyPhong
{
    public partial class AddEmployeeForm : Form
    {
        Fution fn = new Fution();
        String query;

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            txtName.Clear();
            txtmobile.Clear();
            txtFName.Clear();
            txtMName.Clear();
            txtCCCD.Clear();
            txtDiachi.Clear();
            txtEmail.Clear();
            txtedes.Clear();
            txtChucVu.Clear();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            query = "SELECT id FROM newEmployee";

            DataSet ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                // Thực hiện bất kỳ xử lý cần thiết nào với id ở đây nếu cần
            }
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            // Không cần xử lý gì thêm ở đây
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Không cần xử lý gì thêm ở đây
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtmobile.Text != "" && txtFName.Text != "" && txtMName.Text != "" && txtEmail.Text != "" && txtCCCD.Text != "" && txtChucVu.Text != "" && txtedes.Text != "")
            {
                Int64 mobile;
                if (Int64.TryParse(txtmobile.Text, out mobile))
                {
                    String Name = txtName.Text;
                    String Fname = txtFName.Text;
                    String MName = txtMName.Text;
                    String email = txtEmail.Text;
                    String CCCD = txtCCCD.Text;
                    String edes = txtedes.Text;
                    String Diachi = txtDiachi.Text;
                    String ChucVu = txtChucVu.Text;

                    query = $"INSERT INTO newEmployee (emobile, ename, efname, emname, eemail, epaddress, edesignation, eidproof, class) " +
                            $"VALUES ({mobile}, '{Name}', '{Fname}', '{MName}', '{email}', '{Diachi}', '{ChucVu}', '{CCCD}', '{edes}')";
                    fn.setData(query, "Nhân viên đã được thêm");

                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
