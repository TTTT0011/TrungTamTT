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
    public partial class frrphvthilai : Form
    {
        public frrphvthilai()
        {
            InitializeComponent();
        }

        private void frrphvthilai_Load(object sender, EventArgs e)
        {
            string sql;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=HP-PAVILION;database=QLTrungTamTinHoc;uid=sa;pwd=;";
            con.Open();
            sql = "select mahv from viewhvthilai";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "diem");
            cbmahv.DataSource = ds.Tables["diem"];
            cbmahv.DisplayMember = "mahv";
            cbmahv.ValueMember = "mahv";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma;
            ma = cbmahv.Text;
            //mal = comboBox1.Text;
            string sql;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=HP-PAVILION;database=QLTrungTamTinHoc;uid=sa;pwd=;";
            con.Open();
            sql = "select * from diem where mahv='" + ma + "'";
            //sql = "select * from viewdiem where malop='" + mal + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "diem");
            dghvthilai.DataSource = ds.Tables["diem"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frreportbienlai inbienlai = new frreportbienlai();//form chua crvrp
            //inbienlai.chuoiloc = "";
            //inbienlai.chuoiloc = "{Viewbienlai.mahv}='" + cbmahv.Text + "'";
            //inbienlai.Show();
            inhvthilai inhv = new inhvthilai();
            inhv.chuoiloc = "";
            inhv.chuoiloc = "{viewhvthilai.mahv}='" + cbmahv.Text + "'";
            inhv.Show();
        }
    }
}