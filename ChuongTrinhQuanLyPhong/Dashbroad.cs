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
    public partial class Dashbroad : Form
    {
        public Dashbroad()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Dashbroad_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {

        }

        private void btnManagerRoom_Click(object sender, EventArgs e)
        {
            ShowRoom ad = new ShowRoom();
            ad.Show();
        }

       

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Form1 fn = new Form1();
            fn.Show();
            this.Close();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
         
        }

        private void btnUpdateorDelete_Click(object sender, EventArgs e)
        {
       
          
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            ShowSinhVien show = new ShowSinhVien();
            show.Show();

        }
    }
}
