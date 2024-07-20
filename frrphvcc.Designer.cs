namespace TrungTamTinHoc
{
    partial class frrphvcc
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
            this.crvchungchi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvchungchi
            // 
            this.crvchungchi.ActiveViewIndex = -1;
            this.crvchungchi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvchungchi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvchungchi.Location = new System.Drawing.Point(0, 0);
            this.crvchungchi.Name = "crvchungchi";
            this.crvchungchi.SelectionFormula = "";
            this.crvchungchi.Size = new System.Drawing.Size(284, 264);
            this.crvchungchi.TabIndex = 0;
            this.crvchungchi.ViewTimeSelectionFormula = "";
            this.crvchungchi.Load += new System.EventHandler(this.crvchungchi_Load);
            // 
            // frrphvcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.crvchungchi);
            this.Name = "frrphvcc";
            this.Text = "frrphvcc";
            this.ResumeLayout(false);

        }

        #endregion

       //private CrystalDecisions.Windows.Forms.CrystalReportViewer crvchungchi;
    }
}