using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_GIUAKY
{
    public partial class VATTU : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\KT_GIUAKY\KT_GIUAKY\QLVT.mdf;Integrated Security=True");
        string view_VT = "select * from VATTU";
        public VATTU(MAIN_FORM mAIN_FORM)
        {
            InitializeComponent();
            ViewVatTu(view_VT);
        }
        private void Execute(string query)
        {
            conn.Close();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
                conn.Close();
            }
        }
        private void ViewVatTu(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;

            string ma = "select distinct ma_ncc from VATTU";
            conn.Open();
            SqlCommand cmd2 = new SqlCommand(ma, conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            conn.Close();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ma_ncc";
            //listBox1.ValueMember = "ten_ncc";

        }
        

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            string query = "insert into VATTU (ma_vt, ten_vt, gia, ma_ncc ) values (@ma_vt, @ten_vt, @gia,@ma_ncc)";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlParameter ma_vt = new SqlParameter();
            ma_vt.ParameterName = "@ma_vt";
            ma_vt.Value = txt_mavt.Text;

            SqlParameter ten_vt = new SqlParameter();
            ten_vt.ParameterName = "@ten_vt";
            ten_vt.Value = txt_tenvt.Text;

            SqlParameter gia = new SqlParameter();
            gia.ParameterName = "@gia";
            gia.Value = txt_gia.Text;

            SqlParameter ma_ncc = new SqlParameter();
            ma_ncc.ParameterName = "@ma_ncc";
            ma_ncc.Value = comboBox1.Text;

            cmd.Parameters.Add(ma_vt);
            cmd.Parameters.Add(ten_vt);
            cmd.Parameters.Add(gia);
            cmd.Parameters.Add(ma_ncc);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong");
                conn.Close();
                
                ViewVatTu(view_VT);

            }
            catch (Exception)
            {
                MessageBox.Show("Them that bai");
                conn.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string key = txt_mavt.Text;
            if (MessageBox.Show("Ban co chac chan?", "C#", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                Execute("delete VATTU where ma_vt='" + key + "'");
                MessageBox.Show("Xoa thanh cong");
                ViewVatTu(view_VT);
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mavt.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_tenvt.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txt_gia.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            //comboBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();


        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            string query = "update VATTU set ten_vt = @ten_vt, gia = @gia, ma_ncc = @ma_ncc where ma_vt = @ma_vt";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlParameter ma_vt = new SqlParameter();
            ma_vt.ParameterName = "@ma_vt";
            ma_vt.Value = txt_mavt.Text;

            SqlParameter ten_vt = new SqlParameter();
            ten_vt.ParameterName = "@ten_vt";
            ten_vt.Value = txt_tenvt.Text;

            SqlParameter gia = new SqlParameter();
            gia.ParameterName = "@gia";
            gia.Value = txt_gia.Text;

            SqlParameter ma_ncc = new SqlParameter();
            ma_ncc.ParameterName = "@ma_ncc";
            ma_ncc.Value = comboBox1.Text;

            cmd.Parameters.Add(ma_vt);
            cmd.Parameters.Add(ten_vt);
            cmd.Parameters.Add(gia);
            cmd.Parameters.Add(ma_ncc);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sua thanh cong");
                conn.Close();
                ViewVatTu(view_VT);

            }
            catch (Exception)
            {
                MessageBox.Show("Sua that bai");
                conn.Close();
            }
        }
    }
}
