namespace ESMSystem.Print
{
    partial class FrmPrintBill
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
            this.BillingCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BillingCrystalReportViewer
            // 
            this.BillingCrystalReportViewer.ActiveViewIndex = -1;
            this.BillingCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BillingCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.BillingCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BillingCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.BillingCrystalReportViewer.Name = "BillingCrystalReportViewer";
            this.BillingCrystalReportViewer.Size = new System.Drawing.Size(1200, 673);
            this.BillingCrystalReportViewer.TabIndex = 0;
            // 
            // FrmPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 673);
            this.Controls.Add(this.BillingCrystalReportViewer);
            this.Name = "FrmPrintBill";
            this.Text = "FrmPrintBill";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer BillingCrystalReportViewer;
    }
}