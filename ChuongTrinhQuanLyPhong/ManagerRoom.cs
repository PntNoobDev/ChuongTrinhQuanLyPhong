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
using System.Data.SqlClient;

namespace ChuongTrinhQuanLyPhong
{
    public partial class ManagerRoom : Form
    {
        Fution fn = new Fution();
        String query;
        public ManagerRoom()
        {
            InitializeComponent();
        }

     

        private void ManagerRoom_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            query = "SELECT * FROM room ";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddRoom ad = new AddRoom();
            ad.Show();
        }
    }
}
