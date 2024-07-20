using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using CrystalDecisions.Shared;
//using CrystalDecisions.CrystalReports.Engine;
namespace TrungTamTinHoc
{
    public partial class frbl : Form
    {
        public frbl()
        {
            InitializeComponent();
        }
        public string chuoiloc;
        private void crvbl_Load(object sender, EventArgs e)
        {
            frrpinbl hv = new frrpinbl();
            ReportDocument crpbl = new rpbienlai();
            crpbl.RecordSelectionFormula = chuoiloc;
            crvbl.ReportSource = crpbl;
            crpbl.Refresh();
        }
    }
}