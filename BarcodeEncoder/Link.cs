using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PasSDK;

namespace BarcodeEncoder
{
    public partial class Link : MetroFramework.Forms.MetroForm
    {
        private string MainCode;
        private PastelPartnerSDK SDK = new PastelPartnerSDK();
        PastelInfoClass info = new PastelInfoClass();
        string itemCode="";
        string Desc = "";
        public Link()
        {
            InitializeComponent();
            this.ActiveControl = txfItemCode;
        }
        private object SetYourLicense(string Serno, string authcode)
        {
            SDK.SetLicense(ref Serno, ref authcode);
            return default(object);
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dash = new DashBoard();
            dash.ShowDialog();
            this.Close();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
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
                        linkCodes(itemCode, MainCode);
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
        private void txfItemCode_TextChanged(object sender, EventArgs e)
        {
                if (txfItemCode.Text.Length == 13 && itemCode == "")
                {
                    itemCode = FindItemCode(txfItemCode.Text);
                    if (itemCode != "")
                    {
                        lblDesc.Text = Desc;
                        this.ActiveControl = txfQty;
                    }
                    else
                    {
                        MessageBox.Show("There was a error in finding this item", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (txfItemCode.Text.Length != 13)
                {
                    itemCode = "";
                    Desc = "";
                    txfMainCode.Text = "";
                    txfQty.Text = "";
                    lblDesc.Text = "";
                }
        }
        private void linkCodes(string itemCode,string barcode)
        {
            try
            {               
                string auth = @"DK198110007|5635796|C:\Users\Russell - Manifold\Desktop\FDB2020";
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
                    var res = client.Execute(Request);
                    if (res.StatusCode.ToString().Contains("OK"))
                    {
                        MessageBox.Show("The codes have been linked", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        itemCode = "";
                        Desc = "";
                        txfMainCode.Text = "";
                        txfQty.Text = "";
                        lblDesc.Text = "";
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
        }
        private string FindItemCode(string barcode)
        {
            try
            {
                string auth = @"DK198110007|5635796|C:\Users\Russell - Manifold\Desktop\FDB2020";
                string Qstr = "ACCPRD|4|" + barcode;
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "FindDescAndCode";
                client.BaseUrl = new Uri("http://localhost:7721//api/" + path);
                {
                    string str = $"GET?authDetails={auth}&qrystr={Qstr}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.GET;
                    var res = client.Execute(Request);
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
    }
}
