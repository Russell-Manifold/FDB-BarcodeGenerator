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
    public partial class ViewProgressChoose : MetroFramework.Forms.MetroForm
    {
        public ViewProgressChoose()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var frm1 = new frmwait();
            frm1.Show();
            frm1.Refresh();
            InProgressDisplay frm = new InProgressDisplay(106);
            frm.ShowDialog();
            frm1.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var frm1 = new frmwait();
            frm1.Show();
            frm1.Refresh();
            InProgressDisplay frm = new InProgressDisplay(102);
            frm.ShowDialog();
            frm1.Hide();
        }
    }
}
