using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyPhong
{
    public partial class AddRoom : Form
    {

        Fution fn = new Fution();
        String query;
        int updateCount = 0;
        private int numBeds = 0; // Biến để lưu trữ số giường

        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(390, 128);
            LbRoom2.Visible = false;
            LbRoomExist1.Visible = false;

            query = "select * from room";
            DataSet ds = fn.GetData(query);
            dgvroom.DataSource = ds.Tables[0];
            
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
            query = "SELECT * FROM room ";
            DataSet ds = fn.GetData(query);
            dgvroom.DataSource = ds.Tables[0];
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            query = "SELECT * FROM room WHERE roomNo ='" + txtRoomNo12.Text + "'";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                string roomStatus = checkbook12.Checked ? "Yes" : "No"; // Set room status based on checkbox
                string bookedStatus = "No"; // New room is not booked by default

                LbRoomExist1.Visible = false;
                numBeds = Convert.ToInt32(textBox1.Text); // Lấy số giường từ textbox
                query = $"INSERT INTO room (roomNo, roomStatus, Booked, beds) VALUES ('{txtRoomNo12.Text}', '{roomStatus}', '{bookedStatus}', {numBeds})";
                fn.setData(query, "Đã Thêm Phòng");
                Load_Data(); // Refresh data grid view
            }
            else
            {
                LbRoomExist1.Text = "Phòng Đã Có";
                LbRoomExist1.Visible = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from room where roomNo = " + txtRoomNo23.Text + "";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                LbRoom2.Text = "Phòng Này Không  Tồn Tại";
                LbRoom2.Visible = true;
                checkbook22.Checked = false;
            }
            else
            {
                LbRoom2.Text = "Đã Tìm Thấy Phòng";
                LbRoom2.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString() == "Yes")
                {
                    checkbook22.Checked = true;

                }
                else
                {
                    checkbook22.Visible = false;
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Lấy giá trị hiện tại của roomStatus và bookedStatus từ cơ sở dữ liệu
            query = $"SELECT roomStatus, Booked FROM room WHERE roomNo = {txtRoomNo23.Text}";
            DataSet dsStatus = fn.GetData(query);

            if (dsStatus.Tables[0].Rows.Count > 0)
            {
                string currentRoomStatus = dsStatus.Tables[0].Rows[0]["roomStatus"].ToString();
                string currentBookedStatus = dsStatus.Tables[0].Rows[0]["Booked"].ToString();

                string newRoomStatus;
                string newBookedStatus;

                // Kiểm tra xem phải cập nhật roomStatus thành "Yes" hay "No"
                if (currentRoomStatus == "Yes")
                {
                    newRoomStatus = "No";
                }
                else
                {
                    newRoomStatus = "Yes";
                }

                // Kiểm tra xem phải cập nhật bookedStatus thành "Yes" hay "No"
                if (currentBookedStatus == "Yes")
                {
                    newBookedStatus = "No";
                }
                else
                {
                    newBookedStatus = "Yes";
                }

                // Cập nhật roomStatus và bookedStatus vào cơ sở dữ liệu
                query = $"UPDATE room SET roomStatus = '{newRoomStatus}', Booked = '{newBookedStatus}' WHERE roomNo = {txtRoomNo23.Text}";
                fn.setData(query, "Cập Nhật Trạng Thái Phòng Thành Công!!!");

                Load_Data(); // Refresh data grid view
            }
        }

        private void checkbook1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomNo23_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    