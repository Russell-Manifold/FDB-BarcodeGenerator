﻿using Newtonsoft.Json;
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
    }
}
