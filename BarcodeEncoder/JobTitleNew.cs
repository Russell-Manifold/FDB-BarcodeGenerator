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
    public partial class JobTitleNew : MetroFramework.Forms.MetroForm
    {
        public JobTitleNew()
        {
            InitializeComponent();
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.ToString().Length < 1) {
                MessageBox.Show("Please capture a valid Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDescript.Text.ToString().Length < 1)
            {
                MessageBox.Show("Please capture a valid Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Qstr = $"INSERT INTO JobTitles (JobTitleCode, JobTitle) SELECT '" + txtCode.Text.ToString() + "', '" + txtDescript.Text.ToString() + "'";
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
                    MessageBox.Show("Job Title successfully adeed", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else if (res.StatusCode.ToString().Contains("OK"))
                {
                    MessageBox.Show("Error Saving job title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
