using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2;

namespace ChuongTrinhQuanLyPhong
{
    public partial class AddEmployee : Form
    {
        Fution fn = new Fution();
        String query;
        public AddEmployee()
        {
            InitializeComponent();
        }

       private void Load_Employee()
        {
            query = "SELECT * FROM newEmployee ";
            DataSet ds = fn.GetData(query);
            dgvEmployee.DataSource = ds.Tables[0];
           
            dgvEmployee.Columns[0].HeaderText = "Ma Nhan Vien";
            dgvEmployee.Columns[1].HeaderText = "SDT";
            dgvEmployee.Columns[2].HeaderText = "Ho Ten";
            dgvEmployee.Columns[3].HeaderText = "Ten Cha";
            dgvEmployee.Columns[4].HeaderText = "Ten Me";
            dgvEmployee.Columns[5].HeaderText = "Email";
            dgvEmployee.Columns[6].HeaderText = "epaddress";
            dgvEmployee.Columns[7].HeaderText = "eidproof";
            dgvEmployee.Columns[8].HeaderText = "edesignation";
            dgvEmployee.Columns[9].HeaderText = "Chuc Vu";
            dgvEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
          Load_Employee();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }
    }
}
