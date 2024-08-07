using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrungTamTinHoc
{
    class Classqlttth
    {
        SqlConnection con = new SqlConnection();
        public Classqlttth()
        {
            con.ConnectionString = "server=HP-PAVILION;database=QLTrungTamTinHoc;uid=sa;pwd=;";
            con.Open();
        }
        //Lay DataTable bang mot cau lenh trong SQL
        //*****************************************************************
        public DataTable FillDataTable(string strQuery)
        {
            
            //Khai bao va khoi tao doi tuong DataTable
            DataTable dataTable = new DataTable();
            try
            {
                //Khai bao va khoi tao doi tuong SqlDataAdapter
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, con);
                //Khai bao va dien du lieu vao trong DataTable
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr: " + ex.Message); 
            }
            con.Close();
            return dataTable;
        }
        public DataSet getDataSet(string tableName)
        {
            string sql;
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            sql = "SELECT * FROM " + tableName;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            //***DO DU LIEU VAO DANH SACH***//
            da.Fill(ds, tableName);
            //****TRA VE DANH SACH SAU KHI DA CO DU LIEU****//
            return ds;
        }

        //******************* dua mot bang bawng cau lenh sql vao DS
        public DataSet getDataSetSQL(string sql,string tableName)
        {
            //string sql;
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            //sql = sql;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            //***DO DU LIEU VAO DANH SACH***//
            da.Fill(ds, tableName);
            //****TRA VE DANH SACH SAU KHI DA CO DU LIEU****//
            return ds;
        }
        //**********
        public DataTable getDataTable(string tableName)
        {
            return getDataSet(tableName).Tables[tableName];
        }
        //===========HAM KIEM TRA XEM MA HOC VIEN NHAP CO TRUNG KHONG================
        public bool kiemtatrungkhoahocvien(string _mahv)
        {
            string sql = "select * from hocvien where mahv='" + _mahv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }
        //----luu hoc vien-----//

        public bool luuhocvien(string _mhv, string _masv, string _ml, string _ten, string _ns, string _dc, string _nn, string _tt, string bl, string hp)
        {
            string sql = "INSERT into hocvien(mahv,mssv,malop,hoten,namsinh,diachi,nghenghiep,tinhtrang,sobl,hocphi) values(N'" + _mhv + "',N'" + _masv + "',N'" + _ml + "',N'" + _ten + "',N'" + _ns + "',N'" + _dc + "',N'" + _nn + "',N'" + _tt + "',N'" + bl + "',N'" + hp + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;

        }
        //===========XOA HOC VIEN KHOI CO SO DU LIEU================
        public bool xoahocvien(string vmahv)
        { 
            string sql ;
            sql = "delete from diem where mahv='" + vmahv + "'";
            sql += "delete from bienlai1 where mahv='" + vmahv + "'";
            sql += "delete from hocvien where mahv='" + vmahv + "'";
           
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }


        //-----//
        public DataSet hocvien()
        {
            string sql = "select * from hocvien";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
       
        //===========SUU THONG TIN HOC VIEN LUU VAO CO SO DU LIEU================
        public bool suathongtinhocvien(string _mhv, string _massv, string _ml, string _tenhv, string _ns, string _dc, string _nn, string _tt, string bl, string hp)
        {
            string sql = "update hocvien set mssv=N'" + _massv + "',malop=N'" + _ml + "',hoten=N'" + _tenhv + "',namsinh=N'" + _ns + "',diachi=N'" + _dc + "',nghenghiep=N'" + _nn + "',tinhtrang=N'" + _tt + "',sobl=N'" + bl + "',hocphi=N'" + hp + "' where mahv=N'" + _mhv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        //===========TIM KIEM HOC VIEN================
        public bool timkiemall(string tblName, string ma, string vthongtin)
        {
            string sql = "select * from " + tblName + " where " + ma + " like N'%" + vthongtin + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 1)
                return true;
            else
                return false;
        }
        //===============================
        public DataSet gettimkiemAll(string tblName, string ma, string vthongtin)
        {
            string sql = "select * from " + tblName + " where " + ma + " like N'%" + vthongtin + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===========HAM KIEM TRA XEM MA GIAO VIEN NHAP CO TRUNG KHONG================
        public bool kiemtatrungkhoagiaovien(string _magv)
        {
            string sql = "select * from giaovien where magv='" + _magv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }
        //===========================
        public bool tkdiem(string _ma)
        {
            string sql = "select * from viewdiem where mahv='" + _ma + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }
        //----luu giao vien-----//

        public bool luugiaovien(string magv, string htgv, string ns, string dc, string dt, string td, int gt)
        {
            string sql = "INSERT into giaovien(magv,hoten,namsinh,diachi,dienthoai,trinhdo,gioitinh) values(N'" +magv + "',N'" + htgv + "',N'" + ns + "',N'" + dc + "',N'" + dt + "',N'" + td + "',N'" +gt + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;

        }
        //====//
        public DataSet giaovien()
        {
            string sql = "select * from giaovien";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===========SUU THONG TIN GIAO VIEN LUU VAO CO SO DU LIEU================
        public bool suathongtingiaovien(string magv, string htgv, string ns, string dc, string dt, string td, int gt)
        {
            string sql = "update giaovien set hoten=N'" + htgv + "',namsinh=N'" + ns + "',diachi=N'" + dc + "',dienthoai=N'" + dt + "',trinhdo=N'" + td + "',gioitinh=N'" + gt + "' where magv=N'" + magv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        //===========XOA GIAO VIEN KHOI CO SO DU LIEU================
        public bool xoagiaovien(string vmagv)
        {
            string sql = "delete from lophoc where magv='" + vmagv + "'";
            sql += "delete from thoikhoabieu where magv='" + vmagv + "'";
            sql += "delete from giaovien where magv='" + vmagv + "'";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        //===========TIM KIEM GIAO VIEN================
        public bool timkiemgv(string tblName, string ma, string vthongtin)
        {
            string sql = "select * from " + tblName + " where " + ma + " like N'%" + vthongtin + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 1)
                return true;
            else
                return false;
        }
        //===========HAM KIEM TRA XEM MA KHOA HOC NHAP CO TRUNG KHONG================
        public bool kiemtatrungkhoaKH(string _makh)
        {
            string sql = "select * from khoahoc where makh='" + _makh + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }
        //----luu khoá học-----//

        public bool luukhoahoc(string makh, string tkh )
        {
            string sql = "INSERT into khoahoc(makh,tenkh) values(N'" + makh + "',N'" + tkh + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;

        }
        //====//
        public DataSet khoahoc()
        {
            string sql = "select * from khoahoc";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===========SUU THONG TIN KHOA HOC LUU VAO CO SO DU LIEU================
        public bool suathongtinkhoahoc( string mkh,string tkh)
        {
            string sql = "update khoahoc set tenkh=N'" + tkh + "' where makh=N'" + mkh + "'" ;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        //===========HAM KIEM TRA XEM MA PHONG NHAP CO TRUNG KHONG================
        public bool kiemtatrungkhoaphong(string _makh)
        {
            string sql = "select * from phong where maphong='" + _makh + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }
        //----luu phong-----//

        public bool luuphong(string makh, string tkh,string dd)
        {
            string sql = "INSERT into phong(maphong,tenphong,dacdiem) values(N'" + makh + "',N'" + tkh + "',N'" + dd + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;

        }
        public DataSet phong()
        {
            string sql = "select * from phong";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===========SUU THONG TIN PHONG LUU VAO CO SO DU LIEU================
        public bool suathongtinphong(string mkh, string tkh,string dd)
        {
            string sql = "update phong set tenphong=N'" + tkh + "',dacdiem=N'" + dd + "' where maphong=N'" + mkh + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        //===========HAM KIEM TRA USER DANG NHAP VAO HE THONG================
        public bool kiemtramanv(string _user, string _pass)
        {
            string sql = "select * from admind where ma=N'" + _user + "' AND pass=N'" + _pass + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }
        //hàm đổi mật khẩu
        public bool DOIMATKHAU(string _manv, string _pass)
        {
            string sql = "update admind set pass=N'" + _pass + "' where ma=N'" + _manv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        //===========HAM KIEM TRA USER DANG NHAP VAO HE THONG================
        public bool kiemtrauser(string _user, string _pass)
        {
            string sql = "select * from admind where ten=N'" + _user + "' AND pass=N'" + _pass + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }
        //===========HAM KIEM TRA XEM MA LOP HOC  NHAP CO TRUNG KHONG================
        public bool kiemtatrungkhoamalop(string _malop)
        {
            string sql = "select * from lophoc where malop='" + _malop + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }
        //----luu lop hoc-----//

        public bool luulophoc(string ml, string mgv, string mp, string mkh, string ca, string nbd, string nkt)
        {
            string sql = "INSERT into lophoc(malop,maphong,magv,makh,cahoc,ngaybatdau,ngayketthuc) values(N'" + ml + "',N'" + mgv + "',N'" + mp + "',N'" + mkh + "',N'" + ca + "',N'" + nbd + "',N'" + nkt + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;

        }
        //====//
        public DataSet lophoc()
        {
            string sql = "select * from lophoc";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===========SUU THONG TIN LOP HOC LUU VAO CO SO DU LIEU================
        public bool suathongtinlophoc(string ml, string mk, string mgv, string mp, string ca, string nbd, string nkt)
        {
            string sql = "update lophoc set makh=N'" + mk + "',magv=N'" + mgv + "',maphong=N'" + mp + "',cahoc=N'" + ca + "',ngaybatdau=N'" + nbd + "',ngayketthuc=N'" + nkt + "' where malop=N'" + ml + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        //===========XOA LOP KHOI CO SO DU LIEU================
        public bool xoalop(string ml)
        {
            string sql;
            sql = "delete from diem where malop='" + ml + "'";      
                   sql += "delete from hocvien where malop='" + ml+ "'";
                   sql += "delete from thoikhoabieu where malop='" + ml + "'"; 
                   sql += "delete from lophoc where malop='" + ml + "'";    
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true; ;
        }
        //----luu biên lai-----//

        public bool luubienlai(string mhv,string mkh,string hp)
        {
            string sql = "INSERT into bienlai1(mahv,makh,hocphi) values(N'" + mhv + "',N'" + mkh + "',N'" + hp + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;

        }
        //===========XOA BL KHOI CO SO DU LIEU================
        public bool xoabl(string ml)
        {
            string sql;
            sql = "delete from View1 where makh='" + ml + "'";
            //sql += "delete from thoikhoabieu where malop='" + ml + "'";
            //sql += "delete from lophoc where malop='" + ml + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        public DataSet bienlai()
        {
            string sql = "select * from bienlai1";
            //string sql = "select * from View1";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===========TIM KIEM HOC VIEN================
        public bool timkiemhv(string tblName, string ma, string vthongtin)
        {
            string sql = "select * from " + tblName + " where " + ma + " like N'%" + vthongtin + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 1)
                return true;
            else
                return false;
        }
        //===========TIM KIEM HOC VIEN da lay================
        public bool hvdalay()
        {
            string sql = "select * from viewchungchi where tinhtrang='1'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 1)
                return true;
            else
                return false;
        }
        //===========TIM KIEM HOC VIEN chua lay================
        public bool hvclay()
        {
            string sql = "select * from viewchungchi where tinhtrang='0'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 1)
                return true;
            else
                return false;
        }
         //===============================
        public DataSet gettimkiemhvchualay()
        {
            string sql = "select * from  viewchualay";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===============================
        public DataSet gettimkiemhvdalay()
        {
            string sql = "select * from  viewdalay";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===========TIM KIEM HOC VIEN THI LAI================
        public bool hvdat()
        {
            string sql = "select * from viewchungchi";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 1)
                return true;
            else
                return false;
        }
        //===========TIM KIEM HOC VIEN THI LAI================
        public bool hvthilai()
        {
            string sql = "select * from viewhvthilai";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 1)
                return true;
            else
                return false;
        }
        //===============================
        public DataSet gettimkiemhvdat()
        {
            string sql = "select * from viewhvdat";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===============================
        public DataSet gettimkiemhvthilai()
        {
            string sql = "select * from viewhvthilai";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===============================
        public DataSet gettimkiem(string tblName, string ma, string vthongtin)
        {
            string sql = "select * from " + tblName + " where " + ma + " like N'%" + vthongtin + "%' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
       
        //----luu thời khoá biểu-----//

        public bool luuthoikhoabieu(string mp, string mgv, string ml, string mkh, string ca)
        {
            string sql = "INSERT into thoikhoabieu(malop,maphong,magv,makh,cahoc) values(N'" + mp + "',N'" + mgv + "',N'" + ml + "',N'" + mkh + "',N'" + ca + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;

        }
        public DataSet thoikhoabieu()
        {
            string sql = "select * from thoikhoabieu";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===========SUU THONG TIN THOI KHOA BIEU LUU VAO CO SO DU LIEU================
        public bool suathongtintkb(string mp, string mgv, string ml, string mkh, string ca)
        {
            string sql = "update thoikhoabieu set maphong=N'" + mp + "',magv=N'" + mgv + "',makh=N'" + mkh + "',cahoc=N'" + ca + "' where malop=N'" + ml + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        //===========HAM KIEM TRA XEM MA HV VA MA KHOA HOC NHAP CO TRUNG KHONG================
        public bool kiemtratrungbl(string _mahv,string mk)
        {
            string sql = "select mahv,makh from bienlai1 where mahv='" + _mahv + "'  AND makh='" + mk + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }
        //===========HAM KIEM TRA XEM CA HOC VA PHONG HOC NHAP CO TRUNG KHONG================
        public bool kiemtratrungtkb(string mp, string ca)
        {
            string sql = "select maphong,cahoc from lophoc where maphong='" + mp + "'  AND cahoc='" + ca + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }
        //----luu diem-----//

        public bool luudiem(string mhv, string mkh, string ml, double d1, double d2, double d3, double d4, string _xl, string _gc)
        {
            string sql = "INSERT into diem(mahv,makh,malop,diem1,diem2,diem3,tongdiem,xeploai,ghichu) values(N'" + mhv + "',N'" + mkh + "',N'" + ml + "',N'" + d1 + "',N'" + d2 + "',N'" + d3 + "',N'" + d4 + "',N'" + _xl + "',N'" + _gc + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;

        }
        //===========SUU THONG TIN DIEM LUU VAO CO SO DU LIEU================
        public bool suathongtindiem(string mhv, string mkh, string ml, double d1, double d2, double d3, double d4, string xl, string gc)
        {
            string sql = "update diem set mahv=N'" + mhv + "',makh=N'" + mkh + "',malop=N'" + ml + "',diem1=N'" + d1 + "',diem2=N'" + d2 + "',diem3=N'" + d3 + "',tongdiem=N'" + d4 + "',xeploai=N'" + xl + "',ghichu=N'" + gc + "' where mahv=N'" + mhv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
       
        //===========XOA DIEM KHOI CO SO DU LIEU================
        public bool xoadiem(string mhv)
        {
            string sql;
            //sql = "delete from bienlai1 where mahv='" + mhv + "'";
            //sql += "delete from thoikhoabieu where mahv='" + mhv + "'";
            sql = "delete from diem where mahv='" + mhv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        public DataSet diem()
        {
            string sql = "select * from diem";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===========HAM KIEM TRA XEM MA HV  CO TRUNG TRONG BANG DIEM KHONG================
        public bool kiemtratrungd(string _mahv)
        {
            string sql = "select mahv from diem where mahv='" + _mahv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }

       
    }
}