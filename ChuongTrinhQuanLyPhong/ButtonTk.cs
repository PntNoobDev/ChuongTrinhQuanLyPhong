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
    public partial class ButtonTk : Form
    {
        public ButtonTk()
        {
            InitializeComponent();
        }

        private void tkRoom_Click(object sender, EventArgs e)
        {
            ThongKeRoom room = new ThongKeRoom();
            room.Show();
        }

        private void tkNv_Click(object sender, EventArgs e)
        {
            ThongKeNhanVien nv = new ThongKeNhanVien();
            nv.Show();
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
    }
}
