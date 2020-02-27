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
    public partial class InvCountItems : MetroFramework.Forms.MetroForm
    {
        private string CountID = "";
        public InvCountItems(string countID)
        {
            InitializeComponent();
            CountID =countID;
            getInventoryItems();
        }

        private void getInventoryItems()
        {
            string Qstr = $"SELECT BarCode AS Barcode, ItemDesc AS Description, FirstScanQty AS [Count 1], SecondScanQty AS [Count 2], SystemQty AS [Q O H], FinalScanQty - SystemQty AS Diff, Complete, ItemCode, isFirst FROM dbo.InventoryLines WHERE CountID={CountID}";            
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "DocumentSQLConnection";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?qry={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client.Execute(Request);
                if (res.StatusCode.ToString().Contains("OK") && res.Content.Contains("Description"))
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[2].Width = 50;
                    dataGridView1.Columns[3].Width = 50;
                    dataGridView1.Columns[4].Width = 50;
                    dataGridView1.Columns[5].Width = 50;
                    dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[6].ReadOnly = true;
                    dataGridView1.Columns[7].Visible=false;
                    dataGridView1.Columns[8].Visible=false;
                    formatgridcells();
                }
                else if (res.StatusCode.ToString().Contains("OK"))
                {
                    MessageBox.Show("There are no items found on this order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Close off Inventory Count as Complete - Are You Sure?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.ToString() == "Yes")
            {
                MessageBox.Show("Counting completed", "COMPLETE!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
            this.Dispose();
        }

        private void btnDeleteCount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete this stock count?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.ToString() == "Yes")
            {
                SendData();
            }
        }
        private void SendData()
        {
            string Qstr = $"DELETE FROM InventoryHeader WHERE CountID={CountID};DELETE FROM InventoryLines WHERE CountID = {CountID}; ";
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "DocumentSQLConnection";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"POST?qry={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.POST;
                var res = client.Execute(Request);
                if (res.StatusCode.ToString().Contains("OK") && res.Content.Contains("Complete"))
                {
                    MessageBox.Show("This count has been removed", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else if (res.StatusCode.ToString().Contains("OK"))
                {
                    MessageBox.Show("There was a error in deleting this count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void formatgridcells() {
            foreach (DataGridViewRow dr in dataGridView1.Rows) {
                try{
                    if (Convert.ToInt32(dr.Cells[5].Value) != 0) {
                        dr.Cells[5].Style.BackColor = System.Drawing.Color.Green;
                    }
                }
                catch (Exception) { }

            }
        }
    }
}
