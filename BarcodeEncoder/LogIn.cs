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
    public partial class LogIn : MetroFramework.Forms.MetroForm
    {
        public LogIn()
        {
            InitializeComponent();
            txtUserCode.Focus();
        }
        
        void CheckUser(string UserName)
        {
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "GetUser";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?UserName={UserName}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client.Execute(Request);
                if (res.Content!="null")
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    if (ds != null) { 
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow UserDeatils = ds.Tables[0].Rows[0];
                            if (Convert.ToInt32(UserDeatils["Id"]) > 0)
                            {
                                DashBoard db = new DashBoard(UserDeatils);
                                this.Hide();
                                db.FormClosed += (s, args) => this.Close();
                                db.Show();
                            }
                            else
                            {
                                Error();
                            }
                        }
                        else
                        {
                            Error();
                        }
                    }
                }
                else
                {
                    Error();
                }
            }
        }
        void Error()
        {
            MessageBox.Show("Invalid User","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtUserCode.Text="";
            txtUserCode.Focus();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            txtUserCode.Focus();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (TogCodeShow.Checked == true)
            {
                txtUserCode.UseSystemPasswordChar = false;
            }
            else {
                txtUserCode.UseSystemPasswordChar = true;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserCode.Text.Length > 0)
            {
                CheckUser(txtUserCode.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Columns.Add("Cost");
                dt.Columns.Add("ItemCode");
                dt.Columns.Add("AccountGL");
                dt.Columns.Add("JnlDate");
                dt.Columns.Add("JobCode");
                dt.Columns.Add("Narration");
                dt.Columns.Add("Reference");
                dt.Columns.Add("QtyAdjust");
                dt.Columns.Add("Store");
                DataRow dr = dt.NewRow();
                dr["Cost"] = 0;
                dr["ItemCode"] = "COM/PCA";
                dr["JnlDate"] = DateTime.Now.ToString("dd MMM yyyy");
                dr["JobCode"] = "NA";
                dr["Narration"] = "Adding Item 3";
                dr["Reference"] = "Addition";
                dr["QtyAdjust"] = 3;
                dr["AccountGL"] = "";
                dr["Store"] = "JHB";
                //dr["Store"] ="DBN";
                dt.Rows.Add(dr);
                ds.Tables.Add(dt);
                string myds = Newtonsoft.Json.JsonConvert.SerializeObject(ds);

                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "PastelInv";
                client.BaseUrl = new Uri("http://localhost:7721/api/" + path);
                //client.BaseUrl = new Uri("http://192.168.0.111/AmaScanAPI/api/" + path);
            {
                    string str = $"POST?";
                    var Request = new RestSharp.RestRequest(str, RestSharp.Method.POST);
                    Request.RequestFormat = RestSharp.DataFormat.Json;
                    Request.AddJsonBody(myds);
                    var res = client.Execute(Request);
                    if (res.StatusCode.ToString().Contains("OK") && res.Content.Contains("TrfId"))
                    {
                    }
                }
        }
    }
}
