using Newtonsoft.Json;
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
    public partial class ReceiveSlipsList : MetroFramework.Forms.MetroForm
    {
        public DataSet ds = new DataSet();
        public DataTable dtbl = new DataTable();
        public ReceiveSlipsList()
        {
            InitializeComponent();
        }

        private async Task<string> GetReceiveSlips()
        {
            string Qstr = "ACCHISTH|14|106";
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "GetDocumentList";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?qrystr={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client.Execute(Request);
                if (res.StatusCode.ToString().Contains("OK"))
                {
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                     if (ds.Tables[0].Rows.Count > 0)
                    {
                        ds.Tables[0].DefaultView.RowFilter = " Status <> '" + "Complete" + "'";
                    }
                }
                else
                {
                    MessageBox.Show("Unable to display Receiving Slips", "Unable to connect", MessageBoxButtons.OK);
                }
            }
            return await Task.FromResult("");
        }

        private async void GridReceiveSlips_Load(object sender, EventArgs e)
        {
            frmwait frm1 = new frmwait();
            frm1.Show();
            frm1.TopMost = true;
            frm1.Refresh();
            var getslips = await Task.Run(GetReceiveSlips);         
            frm1.Refresh();
            if (ds.Tables[0].Rows.Count > 0)
            {
                dtbl = ds.Tables[0];
                GridReceiveSlips.DataSource = dtbl;
                frm1.Refresh();
                GridReceiveSlips.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                GridReceiveSlips.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                lblReccount.Text = dtbl.DefaultView.Count + " Records";
            }
            frm1.Dispose();
        }

        private void GridReceiveSlips_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var frm = new PrintYesNo(GridReceiveSlips[2, e.RowIndex].Value.ToString(),"106");
            frm.ShowDialog();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            dtbl.DefaultView.RowFilter = String.Format("Number LIKE '%{0}%'", txtfind.Text);
        }
        private void txtref_Changed(object sender, EventArgs e)
        {
            dtbl.DefaultView.RowFilter = String.Format("Reference LIKE '%{0}%'", txtfindref.Text);
        }

    }
}
