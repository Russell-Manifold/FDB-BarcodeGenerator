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
        DataTable reclisttbl;
        public ReceiveSlipsList()
        {
            InitializeComponent();
        }

        private void GetReceiveSlips()
        {

            //metroProgressSpinner1.Show(); 
            string Qstr = "ACCHISTH|7|106";
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
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    ds.Tables[0].DefaultView.RowFilter = " Status <> '" + "Complete" + "'";
                    reclisttbl = new DataTable();
                    reclisttbl = ds.Tables[0];
                    GridReceiveSlips.DataSource = ds.Tables[0];
                    GridReceiveSlips.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    int rwcnt = ds.Tables[0].Rows.Count;
                }
                else
                {
                    MessageBox.Show("Unable to display Receiving Slips", "Unable to connect", MessageBoxButtons.OK);
                }
            }
            //metroProgressSpinner1.Hide();
        }

        private void GridReceiveSlips_Load(object sender, EventArgs e)
        {
            GetReceiveSlips();
        }

        private void GridReceiveSlips_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var frm = new PrintYesNo(GridReceiveSlips[2, e.RowIndex].Value.ToString(),"106");
            frm.ShowDialog();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            reclisttbl.DefaultView.RowFilter = String.Format("Number LIKE '%{0}%'", txtfind.Text);

        }
    }
}
