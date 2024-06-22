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
    public partial class AddStudentmrg : Form
    {

        Fution fn = new Fution();
        String query;
        Dictionary<Int64, int> remainingBeds = new Dictionary<Int64, int>();

        public AddStudentmrg()
        {
            InitializeComponent();
        }

        private void AddStudentmrg_Load(object sender, EventArgs e)
        {
            LoadRoomData();
        }
        private void ClearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtFName.Clear();
            txtMName.Clear();
            txtCCCD.Clear();
            txtDiachi.Clear();
            txtEmail.Clear();
            btnTruong.Clear();
            cmbRoomNo.SelectedIndex = -1;

        }
        private void LoadRoomData()
        {
            query = "SELECT roomNo, beds FROM room WHERE roomStatus = 'Yes' AND Booked = 'No'";
            DataSet ds = fn.GetData(query);
            cmbRoomNo.Items.Clear();
            remainingBeds.Clear();

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Int64 roomNo = Convert.ToInt64(row["roomNo"]);
                    int beds = Convert.ToInt32(row["beds"]);
                    remainingBeds.Add(roomNo, beds);
                    cmbRoomNo.Items.Add(new ComboBoxItem { Text = $"{roomNo} ({beds} giường còn lại)", Value = roomNo });
                }
            }
        }
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public Int64 Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void cmbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbRoomNo.SelectedIndex != -1)
            {
                ComboBoxItem selectedItem = cmbRoomNo.SelectedItem as ComboBoxItem;
                if (selectedItem != null)
                {
                    Int64 roomNo = selectedItem.Value;
                    int bedsLeft = remainingBeds[roomNo];
                    cmbRoomNo.Text = $"{roomNo} ({bedsLeft} giường còn lại)";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.Text != "" && txtMobile.Text != "" && txtFName.Text != "" && txtMName.Text != "" && txtEmail.Text != "" && txtCCCD.Text != "" && cmbRoomNo.SelectedIndex != -1 && btnTruong.Text != "" && txtLop.Text != "")
            {
                Int64 mobile;
                if (Int64.TryParse(txtMobile.Text, out mobile))
                {
                    String Name = txtName.Text;
                    String Fname = txtFName.Text;
                    String MName = txtMName.Text;
                    String email = txtEmail.Text;
                    String CCCD = txtCCCD.Text;
                    String Truong = btnTruong.Text;
                    String Diachi = txtDiachi.Text;
                    String lop = txtLop.Text;
                    Int64 roomNo = Convert.ToInt64(cmbRoomNo.Text.Split(' ')[0]);

                    // Giảm số giường còn lại của phòng
                    remainingBeds[roomNo]--;

                    if (remainingBeds[roomNo] == 0)
                    {
                        query = $"UPDATE room SET Booked = 'Yes' WHERE roomNo = {roomNo}";
                        fn.setData(query, "");
                        LoadRoomData(); // Cập nhật lại dữ liệu phòng
                    }

                    query = $"INSERT INTO newStudent(mobile, name, fname, mname, email, paddress, college, idproof, lop, roomNo) VALUES ({mobile}, '{Name}', '{Fname}', '{MName}', '{email}', '{CCCD}', '{Truong}', '{Diachi}', '{lop}', {roomNo})";
                    fn.setData(query, "Sinh viên đã được thêm");

                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearAll();
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
            this.Close();// Kiểm tra xem form trước đó là gì
            if (this.Owner != null)
            {
                // Hiển thị form trước đó
                this.Owner.Show();
            }

            // Đóng form hiện tại
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnTruong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
