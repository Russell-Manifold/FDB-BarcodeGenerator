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
    public partial class JobTitleSetUp : MetroFramework.Forms.MetroForm
    {
        bool loaded = false;
        public JobTitleSetUp()
        {
            InitializeComponent();
        }

        private void JobTitleSetUp_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            loaded = false;
            string path = "DocumentSQLConnection";
            string Qstr = "SELECT TitleID, JobTitle FROM dbo.JobTitles ORDER BY JobTitle";
            RestSharp.RestClient client1 = new RestSharp.RestClient();
            client1.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?qry={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client1.Execute(Request);
                if (res.StatusCode.ToString().Contains("OK"))
                {
                    DataSet ds1 = new DataSet();
                    ds1 = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    CMBXJobTitles.DataSource = ds1.Tables[0];
                    CMBXJobTitles.DisplayMember = "JobTitle";
                    CMBXJobTitles.ValueMember = "TitleID";
                    CMBXJobTitles.SelectedIndex = -1;
                }
            }
            loaded = true;
        }

        private void CMBXJobTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBXJobTitles.SelectedIndex!=-1&&loaded)
            {
                JobTitleConfig jobTitleConfig = new JobTitleConfig(CMBXJobTitles.SelectedValue.ToString());
                jobTitleConfig.Show();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            JobTitleConfig jobTitleConfig = new JobTitleConfig("0");
            jobTitleConfig.Show();
        }

        private void JobTitleSetUp_Activated(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
