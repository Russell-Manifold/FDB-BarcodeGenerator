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
    public partial class InvCountNewItems : MetroFramework.Forms.MetroForm
    {
        DataTable invDtbl;
        public InvCountNewItems(string whid, Boolean inclzero)
        {
            InitializeComponent();
            GetFullInventoryList(whid, inclzero);
        }
        private void GetFullInventoryList(string whid, Boolean showzero)
        {
            string Qstr = "ACCSTKLK|0|001";
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "GetFullInventoryList";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?qrystr={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client.Execute(Request);
                if (res.IsSuccessful)
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    ds.Tables[0].Columns.Add("Incl", typeof(Boolean));
                    invDtbl = ds.Tables[0];
                    //invDtbl.DefaultView.RowFilter = "Category = '" + "1234" + "'";
                    if (showzero == false) {

                        invDtbl.DefaultView.RowFilter = "OnHand > 0";
                    }
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridView1.Columns[5].Width=60;
                    dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
       }
    }
}
