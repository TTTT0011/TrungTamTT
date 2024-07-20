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
    public partial class frchungchi : Form
    {
        public frchungchi()
        {
            InitializeComponent();
        }

        private void frchungchi_Load(object sender, EventArgs e)
        {
            
            ht2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ht()
        {
            string sql;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=HP-PAVILION;database=QLTrungTamTinHoc;uid=sa;pwd=;";
            con.Open();
            sql = "select mahv,malop,tongdiem,xeploai,ghichu from viewchungchi  where tinhtrang='1' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "diem");
            dgkq.DataSource = ds.Tables["diem"];
        }
        void ht1()
        {
            string sql;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=HP-PAVILION;database=QLTrungTamTinHoc;uid=sa;pwd=;";
            con.Open();
            sql = "select mahv,malop,tongdiem,xeploai,ghichu from viewchungchi  where tinhtrang='0' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "diem");
            dgkq.DataSource = ds.Tables["diem"];
        }
        void ht2()
        {
            string sql;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=HP-PAVILION;database=QLTrungTamTinHoc;uid=sa;pwd=;";
            con.Open();
            sql = "select * from viewchungchi ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "diem");
            dataGridView1.DataSource = ds.Tables["diem"];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                ht();
            else
                ht1();

        }
        public string chuoiloc;
        private void button3_Click(object sender, EventArgs e)
        {
            //DShvlop hv = new DShvlop();
            frrphvcc hv = new frrphvcc();
            hv.chuoiloc = "";
            hv.chuoiloc = "viewchungchi";
            hv.Show();
        }
    }
}