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
    public partial class frmain : Form
    {
        public frmain()
        {
            InitializeComponent();
        }
        Classqlttth obj = new Classqlttth();
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmain_Load(object sender, EventArgs e)
        {

            if (tendangnhap.Text == "Kế toán")
            {
                
                giáoViênToolStripMenuItem.Enabled = false;
                lophoc.Enabled = false;
                khoáHọcToolStripMenuItem.Enabled = false;                            
                giáoViênToolStripMenuItem1.Enabled = false;             
                họcViênToolStripMenuItem.Enabled = false;
                điểmToolStripMenuItem1.Enabled = false;
                họcViênToolStripMenuItem1.Enabled = false;
                giáoViênToolStripMenuItem1.Enabled = false;
                điểmToolStripMenuItem.Enabled = false;
                //biênLaiToolStripMenuItem1.Enabled = true;
                inBiênLaiToolStripMenuItem1.Enabled = true;
                inBiênLaiToolStripMenuItem.Enabled = false;
                danhSáchHVTheoLớpToolStripMenuItem.Enabled = false;
                dSHVĐạtChứngChỉToolStripMenuItem.Enabled = false;
                dSHVThiLạiToolStripMenuItem.Enabled = false;
                //dSHvĐãLấyChứngChỉToolStripMenuItem.Enabled = false;
                //dSHVChưaLấyChứngChỉToolStripMenuItem.Enabled = false;
                điểmToolStripMenuItem2.Enabled = false;
                inDiêmToolStripMenuItem.Enabled = false;
                điểmTheoDSLớpToolStripMenuItem.Enabled = false;
                //dSGiáoViênToolStripMenuItem1.Enabled = false;
                //dSMônHọcToolStripMenuItem1.Enabled = false;
                
            }
            else
                if (tendangnhap.Text == "Nhân viên")
                {
                    giáoViênToolStripMenuItem.Enabled = true;
                    lophoc.Enabled = true;
                    khoáHọcToolStripMenuItem.Enabled = true;
                    giáoViênToolStripMenuItem1.Enabled = true;
                    họcViênToolStripMenuItem.Enabled = true;
                    điểmToolStripMenuItem1.Enabled = true;
                    họcViênToolStripMenuItem1.Enabled = true;
                    giáoViênToolStripMenuItem1.Enabled = true;
                    điểmToolStripMenuItem.Enabled = true;
                    //biênLaiToolStripMenuItem1.Enabled = true;
                    inBiênLaiToolStripMenuItem1.Enabled = false;
                    inBiênLaiToolStripMenuItem.Enabled = true;
                    danhSáchHVTheoLớpToolStripMenuItem.Enabled = true;
                    dSHVĐạtChứngChỉToolStripMenuItem.Enabled = true;
                    dSHVThiLạiToolStripMenuItem.Enabled = true;
                    //dSHvĐãLấyChứngChỉToolStripMenuItem.Enabled = true;
                    //dSHVChưaLấyChứngChỉToolStripMenuItem.Enabled = true;
                    điểmToolStripMenuItem2.Enabled = true;
                    inDiêmToolStripMenuItem.Enabled = true;
                    điểmTheoDSLớpToolStripMenuItem.Enabled = true;
                    //dSGiáoViênToolStripMenuItem1.Enabled = true;
                    //dSMônHọcToolStripMenuItem1.Enabled = true;
                }
                //else
                //{
                //    đăngNhậpToolStripMenuItem.Enabled = false;
                //    cậpNhậtToolStripMenuItem.Enabled = true;
                //    cậpNhậtThủThưToolStripMenuItem.Enabled = true;
                //    xửLýToolStripMenuItem.Enabled = true;
                //    thốngKêToolStripMenuItem.Enabled = true;
                //}
            
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            new frlogin().Show();
            this.Hide();

            đăngXuấtToolStripMenuItem.Enabled = true;
            thayĐổiMậtKhẩuToolStripMenuItem.Enabled = true;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            đăngNhậpToolStripMenuItem.Enabled = true;
            tendangnhap.Text = "";
            cậpNhậtToolStripMenuItem.Enabled = false;
            //thốngKêToolStripMenuItem.Enabled = false;
            tìmKiếmToolStripMenuItem.Enabled = false;
            thốngKêToolStripMenuItem1.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = false;
            thayĐổiMậtKhẩuToolStripMenuItem.Enabled = false;
            
           
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frdoimatkhau frm = new frdoimatkhau();            
            frm.MdiParent = this;
            frm.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void họcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formcapnhathocvien frm = new Formcapnhathocvien();           
            frm.MdiParent = this;
            frm.Show();
        }

        private void lophoc_Click(object sender, EventArgs e)
        {
          
            frlophoc frm = new frlophoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thờiKhoáBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frlichkhaigiang frm = new frlichkhaigiang();
            //frm.MdiParent = this;
            //frm.Show();
        }

       

        private void họcViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frtimkiemhocvien frm = new frtimkiemhocvien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void họcViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frindiemlop frm = new frindiemlop();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dsGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frcapnhatgiaovien frm = new frcapnhatgiaovien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void khoáHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frcapnhatkhoahoc frm = new frcapnhatkhoahoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frketquahoctap frm = new frketquahoctap();
            frketquahoctap frm = new frketquahoctap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void giáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frtimkiemgiaovien frm = new frtimkiemgiaovien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frtkdiem frm = new frtkdiem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void biênLaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            //frreportbienlai frm = new frreportbienlai();
            frrpinbl frm = new frrpinbl();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchHọcViênThiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frreportbienlai frm = new frreportbienlai();
            frrphvthilai frm = new frrphvthilai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dSHọcViênĐạtChứngChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm");
        }

        private void điểmToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void điểmTheoDSLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frindiemlop frm = new frindiemlop();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dSHVThiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frrphvthilai frm = new frrphvthilai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dSHọcViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchHVTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frindshvlop frm = new frindshvlop();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dSHVĐạtChứngChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frhvdatchungchi frm = new frhvdatchungchi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void inDiêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frrpdiemmothv frm = new frrpdiemmothv();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dSGiáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void inBiênLaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frrpinbl frm = new frrpinbl();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýChứngChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frchungchi frm = new frchungchi();
            frm.MdiParent = this;
            frm.Show();
        }
    } 
}