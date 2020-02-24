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
    public partial class InvCountNew : MetroFramework.Forms.MetroForm
    {
        string Qstr = string.Empty;
        public InvCountNew()
        {
            InitializeComponent();
            LoadWarehouses();
        }

        private void LoadWarehouses() {
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "GetWarehouses";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client.Execute(Request);
                if (res.StatusCode.ToString().Contains("OK"))
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    DDWhse.DataSource = ds.Tables[0];
                    DDWhse.DisplayMember = "WHdescript";
                    DDWhse.ValueMember = "WHID";  
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmwait f1 = new frmwait();
            f1.Show();
            Qstr = "INSERT INTO InventoryHeader(CreatedDate,Active, AllowCustomQty, Whse, Description) VALUES('" + Convert.ToDateTime(dateTimePicker1.Text) + "', 1, '" + chkManual.Checked + "', '" + DDWhse.SelectedValue.ToString() + "', '" + txtDescript.Text.ToString() + "')";
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "DocumentSQLConnection";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"POST?qry={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.POST;
                var res = client.Execute(Request);
                if (res.StatusCode.ToString() == "OK")
                {
                    f1.Hide();
                    DialogResult result = MessageBox.Show("Successfully created, add items now?", "SAVED!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result.ToString() == "Yes")
                    {
                        f1.Show();
                        metroProgressSpinner1.Show();
                        this.Close();
                        Boolean showzero = false;
                        if (chkZero.Checked == true) {
                            showzero = true;
                        }
                        var frm = new InvCountNewItems(DDWhse.SelectedValue.ToString(), showzero);
                        f1.Dispose();
                        frm.ShowDialog();
                    }
                }
                else
                {
                    f1.Dispose();
                    MessageBox.Show("Error saving changes - " + res.Content.ToString(), "SAVE FAILURE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
