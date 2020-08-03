using System;
using Microsoft.Reporting.WinForms;

namespace BarcodeEncoder
{
    public partial class BarcodePrint : MetroFramework.Forms.MetroForm
    {
        public BarcodePrint()
        {
            InitializeComponent();
        }

        private void BarcodePrint_Load(object sender, EventArgs e)
        {
            ReportParameter[] p = new ReportParameter[1];
            p[0] = new ReportParameter("imgpath", System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "barcode1Print.jpg"));

            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
