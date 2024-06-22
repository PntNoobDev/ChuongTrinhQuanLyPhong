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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "employee" && txtPassword.Text == "123")
             
            {
                MessageBox.Show("Bạn đang đăng nhập tài khoản Nhân Viên !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Dashbroad dbs = new Dashbroad();
                dbs.Show();
                this.Hide();
            }

            else if (txtUsername.Text == "manager" && txtPassword.Text == "123")
            {
                MessageBox.Show("Bạn đang đăng nhập tài khoản Quản Lí !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProcessgerManager pcs = new ProcessgerManager();
                pcs.Show();
                this.Hide();
            }
           
            else
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Chính Xác!", "Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo!", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
