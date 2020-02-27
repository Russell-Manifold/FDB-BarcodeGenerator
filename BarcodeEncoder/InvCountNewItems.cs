using Newtonsoft.Json;
using RestSharp;
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
        string couldNotAdd = "";
        DataTable invDtbl;      
        bool ShowZero=false;
        public InvCountNewItems(string whid, Boolean inclzero)
        {
            InitializeComponent();
            ShowZero = inclzero;
            GetFullInventoryList(whid);
        }
        private void GetFullInventoryList(string whid)
        {
            //47 sec OLD
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
                if (res.StatusCode.ToString().Contains("OK"))
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    ds.Tables[0].Columns.Add("Incl", typeof(Boolean));
                    invDtbl = ds.Tables[0];
                    //invDtbl.DefaultView.RowFilter = "Category = '" + "1234" + "'";
                    if (ShowZero == false) {

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
        private void txfFilterText_TextChanged(object sender, EventArgs e)
        {
            if (txfFilterText.Text.Length != 0)
            {
                if (ShowZero == false)
                {
                    if (CMBXFilterBy.SelectedIndex == -1)
                    {
                        CMBXFilterBy.SelectedIndex = 0;
                    }
                    switch (CMBXFilterBy.SelectedItem.ToString())
                    {
                        case "Description":
                            invDtbl.DefaultView.RowFilter = $"ItemDescription LIKE '%{txfFilterText.Text}%' AND OnHand > 0  ";
                            break;
                        case "Category":
                            invDtbl.DefaultView.RowFilter = $"Category LIKE '%{txfFilterText.Text}%' AND OnHand > 0  ";
                            break;
                        case "Item Code":
                            invDtbl.DefaultView.RowFilter = $"ItemCode LIKE '%{txfFilterText.Text}%' AND OnHand > 0  ";
                            break;
                        case "BarCode":
                            invDtbl.DefaultView.RowFilter = $"BarCode LIKE '%{txfFilterText.Text}%' AND OnHand > 0  ";
                            break;
                        case "On Hand Qty":
                            invDtbl.DefaultView.RowFilter = $"OnHand={txfFilterText.Text} AND OnHand > 0  ";
                            break;
                        default:
                            invDtbl.DefaultView.RowFilter = $"ItemDescription LIKE '%{txfFilterText.Text}%' AND OnHand > 0  ";
                            break;
                    }
                }
                else
                {
                    if (CMBXFilterBy.SelectedIndex == -1)
                    {
                        CMBXFilterBy.SelectedIndex = 0;
                    }
                    switch (CMBXFilterBy.SelectedItem.ToString())
                    {
                        case "Description":
                            invDtbl.DefaultView.RowFilter = $"ItemDescription LIKE '%{txfFilterText.Text}%'";
                            break;
                        case "Category":
                            invDtbl.DefaultView.RowFilter = $"Category LIKE '%{txfFilterText.Text}%'";
                            break;
                        case "Item Code":
                            invDtbl.DefaultView.RowFilter = $"ItemCode LIKE '%{txfFilterText.Text}%'";
                            break;
                        case "BarCode":
                            invDtbl.DefaultView.RowFilter = $"BarCode LIKE '%{txfFilterText.Text}%'";
                            break;
                        case "On Hand Qty":
                            invDtbl.DefaultView.RowFilter = $"OnHand={txfFilterText.Text}";
                            break;
                        default:
                            invDtbl.DefaultView.RowFilter = $"ItemDescription LIKE '%{txfFilterText.Text}%' AND OnHand > 0  ";
                            break;
                    }
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var result =MessageBox.Show("Are you sure you would like to save this Count","Confirm?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            List<DataRow> lsRows = new List<DataRow>();
            foreach (DataRow row in invDtbl.Rows)
            {
                if (row["Incl"].ToString()!="")
                {
                    if (Convert.ToBoolean(row["Incl"]))
                    {
                        lsRows.Add(row);
                    }
                }             
            }
            InsertItems(lsRows);
        }
        private void InsertItems(List<DataRow> drL)
        {
            RestClient client = new RestClient();
            string path = "DocumentSQLConnection";
            string CountID = "";
            RestRequest Request = new RestRequest();
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                Request = new RestRequest("GET?qry=SELECT MAX(CountID) AS CountID FROM InventoryHeader", Method.GET);
                var resul = client.Execute(Request);
                if (resul.StatusCode.ToString().Contains("OK"))
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(resul.Content);
                    CountID = ds.Tables[0].Rows[0]["CountID"].ToString();
                }
                else if (resul.Content==null)
                {
                    MessageBox.Show("Could not find reccent count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Could not connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (DataRow row in drL)
                {
                    string str = $"POST?qry=INSERT INTO InventoryLines(CountID,ItemCode,ItemDesc,BarCode, Bin)VALUES({CountID},'{row["ItemCode"].ToString()}','{row["ItemDescription"]}','{row["BarCode"]}' ,'{row["Bin"].ToString()}')";
                    Request = new RestRequest(str,Method.POST);
                    var res = client.Execute(Request);
                    if (res.StatusCode.ToString().Contains("OK") && !res.Content.Contains("Complete"))
                    {
                        couldNotAdd += ""+row["ItemDescription"].ToString();  
                    }
                    else if (!res.StatusCode.ToString().Contains("OK"))
                    {
                        MessageBox.Show("There was a error in Connecting online", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (couldNotAdd.Length>1)
                {
                    MessageBox.Show($"{couldNotAdd} Could not be added to the count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("All the data has been saved","Complete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Dispose();
                }
            }                                                                  
        }
        private void metroLabel3_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(null,null);
        }
    }
}
