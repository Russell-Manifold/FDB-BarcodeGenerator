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

namespace BarcodeEncoder
{
    public partial class PickSlipsList : MetroFramework.Forms.MetroForm
    {
        public  DataSet ds = new DataSet();
        public DataTable dtbl = new DataTable();
        public PickSlipsList()
        {
            InitializeComponent();
        }

        private async Task<DataSet> GetPickingSlips() 
        {
            string Qstr = "ACCHISTH|14|102";
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
                    if (ds.Tables[0].Rows.Count > 0) { 
                        ds.Tables[0].DefaultView.RowFilter = " Status <> '" + "Complete" + "'";
                    }
                }
                else {
                    MessageBox.Show("Unable to display Picking slips", "Unable to connect", MessageBoxButtons.OK);
                }
            }
            return await Task.FromResult(ds);
        }

        private async void PickSlipsList_Load(object sender, EventArgs e)
        {
            Refresh(); 
            frmwait frm1 = new frmwait();
            frm1.Show();
            frm1.TopMost = true;
            frm1.Refresh();
            var getslips = await Task.Run(GetPickingSlips);
            frm1.Refresh();
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dtbl = ds.Tables[0];
                    GridPickSlips.DataSource = dtbl;
                    frm1.Refresh();
                    GridPickSlips.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    GridPickSlips.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    lblReccount.Text = dtbl.DefaultView.Count + " Records";
                }
            }
        frm1.Dispose();
        }

        private void GridPickSlips_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var frm = new PrintYesNo(GridPickSlips[2, e.RowIndex].Value.ToString(), "102");
            frm.ShowDialog();
        }

        private void txtPickFind_TextChanged(object sender, EventArgs e)
        {
            dtbl.DefaultView.RowFilter = String.Format("Number LIKE '%{0}%'", txtPickFind.Text);
        }

        private void txtfindref_Click(object sender, EventArgs e)
        {
            dtbl.DefaultView.RowFilter = String.Format("Reference LIKE '%{0}%'", txtfindref.Text);
        }
    }
}
