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
using Microsoft.VisualBasic.CompilerServices;

namespace BarcodeEncoder
{
    public partial class Link : MetroFramework.Forms.MetroForm
    {
        private string MainCode;
        PastelInfoClass info = new PastelInfoClass();
        string itemCode="";
        string Desc = "";
        string auth =BarcodeEncoder.Properties.Settings.Default.SerNum+"|"+ BarcodeEncoder.Properties.Settings.Default.Auth + "|"+ BarcodeEncoder.Properties.Settings.Default.ConnectionString;
        public Link()
        {
            InitializeComponent();
            this.ActiveControl = txfItemCode;
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dash = new DashBoard();
            dash.ShowDialog();
            this.Close();
        }
        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txfQty.Text == "")
            {
                MessageBox.Show("Please enter a quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MainCode = txfMainCode.Text;
                if (MainCode != "")
                {
                    if (itemCode != "")
                    {
                        if (!await Check())
                        {
                            if (await linkCodes(itemCode, MainCode))
                            {
                                MessageBox.Show("The codes have been linked", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                itemCode = "";
                                Desc = "";
                                txfMainCode.Text = "";
                                txfQty.Text = "";
                                lblDesc.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is already a BOM with this same quatity and the same item code", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No item with that code found");
                    }
                }
                else
                {
                    MessageBox.Show("Please scan the product collection code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
        private async void txfItemCode_TextChanged(object sender, EventArgs e)
        {
                if (txfItemCode.Text.Length == 13 && itemCode == "")
                {
                    itemCode =await FindItemCode(txfItemCode.Text);
                    if (itemCode != "")
                    {
                        lblDesc.Text = Desc;
                        this.ActiveControl = txfQty;
                        txfItemCode.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        MessageBox.Show("There was a error in finding this item", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txfItemCode.BackColor = Color.Orange;
                    }
                }
                else if (txfItemCode.Text.Length != 13)
                {
                    itemCode = "";
                    Desc = "";
                    txfMainCode.Text = "";
                    txfQty.Text = "";
                    lblDesc.Text = "";
                    txfItemCode.BackColor = Color.Orange;
                }
                else if(txfItemCode.Text.Length == 0)
                {
                    txfItemCode.BackColor = Color.White;
                }
        }
        private async Task<bool> linkCodes(string itemCode,string barcode)
        {
            try
            {               
                string BOMHead = "" + barcode + "|BOM HEADER|12.1|12.2|12.3|12.4|12.5|12.6|12.7|12.8|12.9|12|10|20|30|100|200|300|" + itemCode + "|Y|Y|N||N|N|001";
                string line = "" + barcode + "|" + itemCode + "|" + txfQty.Text + "|001#";
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "POSTBOM";
                client.BaseUrl = new Uri("http://localhost:7721//api/" + path);
                {
                    string str = $"POST?authDetails={auth}&BOMHead={BOMHead}&line={line}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.POST;
                    var cancellationTokenSource = new CancellationTokenSource();
                    var res = await client.ExecuteTaskAsync(Request,cancellationTokenSource.Token);
                    if (res.StatusCode.ToString().Contains("OK"))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(info.GetResultDesc(res.Content.Substring(1,res.Content.Length-2))+"", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not link items","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        private async Task<string> FindItemCode(string barcode)
        {
            try
            {                
                string Qstr = "ACCPRD|4|" + barcode;
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "FindDescAndCode";
                client.BaseUrl = new Uri("http://localhost:7721//api/" + path);
                {
                    string str = $"GET?authDetails={auth}&qrystr={Qstr}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.GET;
                    var cancellationTokenSource = new CancellationTokenSource();
                    var res =await client.ExecuteTaskAsync(Request,cancellationTokenSource.Token);
                    if (res.IsSuccessful)
                    {
                        string returnVal = res.Content.Substring(1, res.Content.Length - 2);
                        Desc = returnVal.Split('|')[3];
                        return returnVal.Split('|')[2];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to the API", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }
        public async Task<bool> Check()
        {
            try
            {
                string Qstr = "ACCBOML|2|" + itemCode + "|" + txfQty.Text.Trim();
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "CheckBOMExists";
                client.BaseUrl = new Uri("http://localhost:7721//api/" + path);
                {
                    string str = $"GET?authDetails={auth}&qrystr={Qstr}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.GET;
                    var cancellationTokenSource = new CancellationTokenSource();
                    var res = await client.ExecuteTaskAsync(Request, cancellationTokenSource.Token);
                    if (res.IsSuccessful)
                    {
                        string returnVal = res.Content.Substring(1, res.Content.Length - 2);
                        if (returnVal.Split('|')[0] == "0")
                        {                  
                            return true;
                        }                       
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to the API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public void clear(object sender, EventArgs e)
        {
            txfQty.Text = "";
            txfMainCode.Text = "";
            txfItemCode.Text = "";
            txfItemCode.BackColor = Color.White;
        }
    }
}
