using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeEncoder
{
    public partial class DashBoard : MetroFramework.Forms.MetroForm
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Link NewForm = new Link();
            NewForm.ShowDialog();
            this.Close();
        }
        private void BtnCreateBarcode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create NewForm = new Create();
            NewForm.ShowDialog();
            this.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Encoder NewForm = new Encoder();
            NewForm.ShowDialog();
            this.Close();
        }
       
    }
}
