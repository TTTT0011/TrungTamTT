using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
//using System.Windows.Forms;
//using CrystalDecisions.CrystalReports.Engine;
namespace TrungTamTinHoc
{
    public partial class frrphvcc : Form
    {
        public frrphvcc()
        {
            InitializeComponent();
        }
        public string chuoiloc;
        private void crvchungchi_Load(object sender, EventArgs e)
        {
            //frindshvlop hv = new frindshvlop();
            frchungchi cc = new frchungchi();
            ReportDocument crpbl = new rphvdatcc();
            crpbl.RecordSelectionFormula = chuoiloc;
            crvchungchi.ReportSource = crpbl;
            crpbl.Refresh();
        }
    }
}