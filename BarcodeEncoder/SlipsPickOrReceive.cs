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
    public partial class SlipsPickOrReceive : MetroFramework.Forms.MetroForm
    {
        PickSlipsList psList = null;
        ReceiveSlipsList recList = null;
        public SlipsPickOrReceive()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var frm = new frmwait();
            frm.Show();
            frm.Refresh();
            recList = new ReceiveSlipsList();
            recList.ShowDialog();
            frm.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var frm = new frmwait();
            frm.Show();
            frm.Refresh();
            psList = new PickSlipsList();
            psList.ShowDialog();
            frm.Hide();
        }
    }
}
