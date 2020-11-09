using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace KT_GIUAKY
{
    public partial class MAIN_FORM : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\KT_GIUAKY\KT_GIUAKY\QLVT.mdf;Integrated Security=True");
        string sql;
        
        public MAIN_FORM(Form1 form1)
        {
            InitializeComponent();
            
        }

        private void nHÀCUNGCẤPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NCC ncc = new NCC(this);
            ncc.Show();
            this.Hide();
        }

        private void vẬTTƯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VATTU vattu = new VATTU(this);
            vattu.Show();
            this.Close();

        }
        private void ViewDT(string sql)
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        
        private void btn_tim_Click(object sender, EventArgs e)
        {
            string key = txt_mancc.Text;
            string sql = "select ma_ncc from NCC where ma_ncc='" + key + "'";
            
            //string key = txt_mancc.Text;
            try
            {
                string sql_view = "select ma_ncc, ma_vt, ten_vt from VATTU where ma_ncc='" + key + "'";
                ViewDT(sql_view);
            }
            catch (Exception)
            {
                MessageBox.Show("Khong tim thay");
            }
            
              
            
            
        }
    }
}
