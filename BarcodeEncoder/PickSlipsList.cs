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
        DataTable picktbl;
        public PickSlipsList()
        {
            InitializeComponent();
        }

        private void GetPickingSlips() {

            //metroProgressSpinner1.Show(); 
            string Qstr = "ACCHISTH|7|102";
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "GetDocumentList";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?qrystr={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                //var cancellationTokenSource = new CancellationTokenSource();
                var res = client.Execute(Request);
                if (res.StatusCode.ToString().Contains("OK"))
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    ds.Tables[0].DefaultView.RowFilter = " Status <> '" + "Complete" + "'";
                    picktbl = new DataTable();
                    picktbl = ds.Tables[0];
                    GridPickSlips.DataSource = ds.Tables[0];
                    GridPickSlips.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    lblReccount.Text = ds.Tables[0].Rows.Count.ToString() + " Records";
                }
                else {
                    MessageBox.Show("Unable to display Picking slips", "Unable to connect", MessageBoxButtons.OK);
                }
            }
            //metroProgressSpinner1.Hide();
        }

        private void PickSlipsList_Load(object sender, EventArgs e)
        {
            GetPickingSlips();
        }

        private void GridPickSlips_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var frm = new PrintYesNo(GridPickSlips[2, e.RowIndex].Value.ToString(), "102");
            frm.ShowDialog();
        }

        private void txtPickFind_TextChanged(object sender, EventArgs e)
        {
            picktbl.DefaultView.RowFilter = String.Format("Number LIKE '%{0}%'", txtPickFind.Text);
        }
    }
}
