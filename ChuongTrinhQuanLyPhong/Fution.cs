using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Xml;

namespace ChuongTrinhQuanLyPhong

{
    class Fution
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HMIBQ3K\\SQLEXPRESS;Initial Catalog=hostel;Integrated Security=True";

            return con;
           

        }
        public DataSet GetData(String query) 
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        } 

        public void setData(String query, String msg)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText= query;
            cmd.Connection = con ;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg,"THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }
            
    }
}
