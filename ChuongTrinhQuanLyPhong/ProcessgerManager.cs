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
    public partial class ProcessgerManager : Form
    {
        public ProcessgerManager()
        {
            InitializeComponent();
        }

        private void btnManagerRoom_Click(object sender, EventArgs e)
        {ShowRoom ad = new ShowRoom();
            ad.Show();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fn = new Form1();
            fn.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void ProcessgerManager_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ShowSinhVien show = new ShowSinhVien();
            show.Show();
           
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ButtonTk ad = new ButtonTk();
            ad.Show();
            
        }
    }
}
