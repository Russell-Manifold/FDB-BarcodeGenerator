namespace BarcodeEncoder
{
    partial class PrintPickingSlip
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPickingSlip));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblDocNum = new MetroFramework.Controls.MetroLabel();
            this.lblDocType = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "headerDS";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BarcodeEncoder.PickSlip.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 715);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblDocNum
            // 
            this.lblDocNum.AutoSize = true;
            this.lblDocNum.Location = new System.Drawing.Point(417, 16);
            this.lblDocNum.Name = "lblDocNum";
            this.lblDocNum.Size = new System.Drawing.Size(81, 19);
            this.lblDocNum.TabIndex = 1;
            this.lblDocNum.Text = "metroLabel1";
            this.lblDocNum.Visible = false;
            // 
            // lblDocType
            // 
            this.lblDocType.AutoSize = true;
            this.lblDocType.Location = new System.Drawing.Point(532, 16);
            this.lblDocType.Name = "lblDocType";
            this.lblDocType.Size = new System.Drawing.Size(81, 19);
            this.lblDocType.TabIndex = 2;
            this.lblDocType.Text = "metroLabel1";
            this.lblDocType.Visible = false;
            // 
            // PrintPickingSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 714);
            this.Controls.Add(this.lblDocType);
            this.Controls.Add(this.lblDocNum);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintPickingSlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Slip";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PrintPickingSlip_Load);
            this.Disposed += new System.EventHandler(this.PrintPickingSlip_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroLabel lblDocNum;
        private MetroFramework.Controls.MetroLabel lblDocType;
    }
}