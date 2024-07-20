using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TrungTamTinHoc
{
    public partial class frrpdiemmothv : Form
    {
        public frrpdiemmothv()
        {
            InitializeComponent();
        }

        private void frrpdiemmothv_Load(object sender, EventArgs e)
        {
            string sql;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=HP-PAVILION;database=QLTrungTamTinHoc;uid=sa;pwd=;";
            con.Open();
            sql = "select mahv from viewdiem";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "diem");
            cbmahv.DataSource = ds.Tables["diem"];
            cbmahv.DisplayMember = "mahv";
            cbmahv.ValueMember = "mahv";
            //comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ma;
            ma = cbmahv.Text;
            //mal = comboBox1.Text;
            string sql;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=HP-PAVILION;database=QLTrungTamTinHoc;uid=sa;pwd=;";
            con.Open();
            sql = "select * from viewdiem where mahv='" + ma + "'";
            //sql = "select * from viewdiem where malop='" + mal + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "diem");
            dgtkdiem.DataSource = ds.Tables["diem"];
        }
       public string chuoiloc;
        private void button1_Click(object sender, EventArgs e)
        {
            frrpdiem1hv hv = new frrpdiem1hv();
            hv.chuoiloc = "";
            hv.chuoiloc = "{viewdiem.mahv}='" + cbmahv.Text + "'";
            hv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}