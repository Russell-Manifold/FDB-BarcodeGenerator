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
        Timer delayTimer = new Timer();
        public LogIn()
        {
            InitializeComponent();
            delayTimer.Tick += TickTimer;
            delayTimer.Interval = 2000;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            delayTimer.Stop();
            delayTimer.Start();          
        }
        void TickTimer(object sender, EventArgs e)
        {
            delayTimer.Stop();
            CheckUser(textBox1.Text);
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
                if (res.StatusCode.ToString().Contains("OK"))
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    DataRow UserDeatils = ds.Tables[0].Rows[0];
                    if (Convert.ToInt32(UserDeatils["Id"])>0)
                    {
                        DashBoard db = new DashBoard(UserDeatils);
                        this.Hide();
                        db.FormClosed += (s, args) => this.Close();
                        db.Show();   
                    }
                }
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
