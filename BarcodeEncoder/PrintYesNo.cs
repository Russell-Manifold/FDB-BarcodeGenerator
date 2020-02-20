using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BarcodeEncoder
{
    public partial class PrintYesNo : MetroFramework.Forms.MetroForm
    {
        public PrintYesNo(string ordnum, string doctype)
        {
            InitializeComponent();
            lblDocNum.Text = ordnum;
            lbldoctype.Text = doctype;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var frm1 = new frmwait();
            frm1.Show();
            frm1.Refresh();
            this.Close();
            var frm = new PrintPickingSlip(lblDocNum.Text, lbldoctype.Text);
            frm.Show();
            frm1.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintYesNo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
