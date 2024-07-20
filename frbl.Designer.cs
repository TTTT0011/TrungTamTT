namespace TrungTamTinHoc
{
    partial class frbl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvbl = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvbl
            // 
            
            this.crvbl.ActiveViewIndex = -1;
            this.crvbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvbl.Location = new System.Drawing.Point(0, 0);
            this.crvbl.Name = "crvbl";
            this.crvbl.SelectionFormula = "";
            this.crvbl.Size = new System.Drawing.Size(284, 264);
            this.crvbl.TabIndex = 0;
            this.crvbl.ViewTimeSelectionFormula = "";
            this.crvbl.Load += new System.EventHandler(this.crvbl_Load);
            
            // 
            // frbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.crvbl);
            this.Name = "frbl";
            this.Text = "frbl";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvbl;
    }
}

namespace CrystalDecisions
{
    class Windows
    {
        internal class Forms
        {
            internal class CrystalReportViewer
            {
            }
        }
    }
}