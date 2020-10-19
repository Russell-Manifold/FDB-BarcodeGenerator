using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace BarcodeEncoder
{
    public partial class DashBoard : MetroFramework.Forms.MetroForm
    {
        public static DataRow UserData;
        Link LinkForm = null;
        Create CreateForm = null;
        Encoder EncodeForm = null;
        AdminDashboard admin = null;
        SlipsPickOrReceive psList = null;
        //Image i = null;

        public DashBoard(DataRow dr)
        {          
            InitializeComponent();
            UserData = dr;
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            try
            {
                LinkForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                CreateForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                EncodeForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                admin.Close();
            }
            catch (Exception)
            { }
            LinkForm = new Link();
            LinkForm.ShowDialog();
            btnScan.Focus();
        }

        private void BtnCreateBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                LinkForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                admin.Close();
            }
            catch (Exception)
            { }
            try
            {
                CreateForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                EncodeForm.Close();
            }
            catch (Exception)
            { }
            CreateForm = new Create();
            CreateForm.ShowDialog();
            BtnCreateBarcode.Focus();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                LinkForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                admin.Close();
            }
            catch (Exception)
            { }
            try
            {
                CreateForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                EncodeForm.Close();
            }
            catch (Exception)
            { }
            EncodeForm = new Encoder();
            EncodeForm.ShowDialog();
            btnCreate.Focus();
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            try
            {
                LinkForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                admin.Close();
            }
            catch (Exception)
            { }
            try
            {
                CreateForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                EncodeForm.Close();
            }
            catch (Exception)
            { }
            admin = new AdminDashboard();
            admin.ShowDialog();
            btnScan.Focus();
        }

        private void btnPickSlipsList_Click(object sender, EventArgs e)
        {
            try
            {
                LinkForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                admin.Close();
            }
            catch (Exception)
            { }
            try
            {
                CreateForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                EncodeForm.Close();
            }
            catch (Exception)
            { }
            psList = new SlipsPickOrReceive();
            psList.ShowDialog();
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ViewProgressChoose frm = new ViewProgressChoose();
            frm.ShowDialog();
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            InvCountSelect frm = new InvCountSelect();
            frm.ShowDialog();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Hi " + UserData["UserName"].ToString();
            
            if (UserData["JobTitleCode"].ToString()=="Sup")
            {
                btnPickSlipsList.Enabled = true;
                BtnCreateBarcode.Visible = true;
                btnScan.Enabled = true;
                btnCreate.Enabled = true;
                //inv counts
                metroButton1.Enabled = true;
                //inprogressTammy
                metroButton2.Enabled = true;
                metroLink1.Visible = true;
                metroLink2.Visible = true;
            }
            else
            {
                try
                {
                    if (Convert.ToBoolean(UserData["fReceive"]))
                    {
                        btnPickSlipsList.Enabled = true;
                        btnPickSlipsList.BackColor = Color.Transparent;
                    }
                    else
                    {
                        btnPickSlipsList.Enabled = false;
                        btnPickSlipsList.BackColor = Color.LightGray;
                    }
                }
                catch
                {

                }
                try
                {
                    if (Convert.ToBoolean(UserData["CanPrintBarcodes"]))
                    {
                        metroLink2.Visible = true;
                    }
                    else
                    {
                        metroLink2.Visible= false;
                    }
                }
                catch
                {

                }
                //try
                //{

                //    if (Convert.ToBoolean(UserData["CreateBarcodes"]))
                //    {
                //        btnNewBarcode.Enabled = true;
                //        btnNewBarcode.BackColor = Color.Transparent;
                //    }
                //    else 
                //    {
                //        btnNewBarcode.Enabled = false;
                //        btnNewBarcode.BackColor = Color.LightGray;
                //    }
                //}
                //catch (Exception ex)
                //{
                //    btnNewBarcode.Enabled = false;
                //    btnNewBarcode.BackColor = Color.LightGray;
                //}
                try
                {
                    if (Convert.ToBoolean(UserData["LinkBarcodes"]))
                    {
                        btnScan.Enabled = true;
                        btnScan.BackColor = Color.Transparent;
                    }
                    else
                    {
                        btnScan.Enabled = true;
                        btnScan.BackColor = Color.LightGray;
                    }
                }
                catch (Exception ex1)
                {
                    btnScan.Enabled = true;
                    btnScan.BackColor = Color.LightGray;
                }
                try
                {
                    if (Convert.ToBoolean(UserData["CreatePackCodes"]))
                    {
                        btnCreate.Enabled = true;
                        btnCreate.BackColor = Color.Transparent;
                    }
                    else
                    {
                        btnCreate.Enabled = false;
                        btnCreate.BackColor = Color.LightGray;
                    }
                }
                catch (Exception ex2)
                {
                    btnCreate.Enabled = false;
                    btnCreate.BackColor = Color.LightGray;
                }
                try
                {
                    if (Convert.ToBoolean(UserData["fInvCount"]))
                    {
                        metroButton1.Enabled = true;
                        metroButton1.BackColor = Color.Transparent;
                    }
                    else
                    {
                        metroButton1.Enabled = false;
                        metroButton1.BackColor = Color.LightGray;
                    }
                }
                catch
                {
                    metroButton1.Enabled = false;
                    metroButton1.BackColor = Color.LightGray;
                }
                try
                {
                    if (Convert.ToBoolean(UserData["AuthDispatch"]))
                    {
                        metroButton2.Enabled = true;
                        metroButton2.BackColor = Color.Transparent;
                    }
                    else
                    {
                        metroButton2.Enabled = false;
                        metroButton2.BackColor = Color.LightGray;
                    }
                }
                catch
                {
                    metroButton2.Enabled = false;
                    metroButton2.BackColor = Color.LightGray;
                }
               
            }
           
        }
        private void metroLink2_Click(object sender, EventArgs e)
        {
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "DocumentSQLConnection";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?qry=SELECT * FROM tblPrintQue";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client.Execute(Request);
                if (res.StatusCode.ToString().Contains("OK") && res.Content.Contains("Barcode"))
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            RepackBarcodePrint frm = new RepackBarcodePrint();
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No barcodes to print", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No barcodes to print", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            // check for complete'd IO's for invoicing
           await GetReadyDocs();
        }
        private async Task <bool> GetReadyDocs()
        {
            return false;
         }
    }
}
