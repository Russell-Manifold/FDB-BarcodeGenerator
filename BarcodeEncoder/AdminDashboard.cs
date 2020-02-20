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
    public partial class AdminDashboard : MetroFramework.Forms.MetroForm
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var frm = new AdminPanel();
            frm.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var frm = new UserSetup();
            frm.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmJ = new JobTitleSetUp();
            frmJ.ShowDialog();
        }
    }
}
