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
    public partial class JobTitleConfig : MetroFramework.Forms.MetroForm
    {
        public JobTitleConfig(string jobtitleid)
        {
            InitializeComponent();
            lblTitleID.Text = jobtitleid.ToString();
        }

        private void JobTitleSetUp_Load(object sender, EventArgs e)
        {
            if (lblTitleID.Text == "0")
            {
                txtCode.Enabled = true;
            }
            else {
                string Qstr = "SELECT TOP (1) PERCENT * FROM dbo.JobTitles WHERE TitleID = " + lblTitleID.Text;
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "DocumentSQLConnection";
                client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
                {
                    string str = $"GET?qry={Qstr}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.GET;
                    var res = client.Execute(Request);
                    if (res.IsSuccessful)
                    {
                        DataSet ds = new DataSet();
                        ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                        txtCode.Text = ds.Tables[0].Rows[0]["JobTitleCode"].ToString();
                        txtDescript.Text = ds.Tables[0].Rows[0]["JobTitle"].ToString();
                        chkReceive.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["fReceive"].ToString());
                        chkRepack.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["fRepack"].ToString());
                        chkInvCnt.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["fInvCount"].ToString());
                        chkWhTrf.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["fWhTrf"].ToString());
                        chkPickPack.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["fPickPack"].ToString());
                        chkChecker.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["PickChecker"].ToString());

                        chkPickControl.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["PSCollect"].ToString());
                        chkAuthWhTrf.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["AuthWHTrf"].ToString());
                        chkAuthReceive.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["AuthReceive"].ToString());
                        chkAuthDispatch.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["AuthDispatch"].ToString());
                        chkRecount.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["InvReCountAuth"].ToString());
                        chkInvCntCreate.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["CreateInvCount"].ToString());
                        chkInvCntClose.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["CloseInvCount"].ToString());
                        chkAdmin.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["SystAdmin"].ToString());
                    }
                }
            }
        }

       private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Qstr = string.Empty;
            if (lblTitleID.Text == "0")
            {
                // insert new job title
                Qstr = "INSERT INTO dbo.JobTitles (JobTitleCode, JobTitle, fReceive, fRepack, fInvCount, fWhTrf, fPickPack, PickChecker, PSCollect, AuthWHTrf, AuthReceive, AuthDispatch, CreateInvCount,  CloseInvCount, SystAdmin, InvReCountAuth )" +
                   " SELECT '" + txtCode.Text.ToString() + "', '" + txtDescript.Text.ToString() + "', '" + chkReceive.Checked.ToString() + "', '" + chkRepack.Checked.ToString() + "', '" + chkInvCnt.Checked.ToString() + "', '" + chkWhTrf.Checked.ToString() + "',  '" + chkPickPack.Checked.ToString() + "', '" + chkChecker.Checked.ToString() + "', '" + chkPickControl.Checked.ToString() + "', '" + chkAuthWhTrf.Checked.ToString() + "', '" + chkAuthReceive.Checked.ToString() + "', '" + chkAuthDispatch.Checked.ToString() + "', '" + chkInvCntCreate.Checked.ToString() + "',  '" + chkInvCntClose.Checked.ToString() + "', '" + chkAdmin.Checked.ToString() + "', '" + chkRecount.Checked.ToString() + "'";
            }
            else
            {
                // update job title
                Qstr = "UPDATE dbo.JobTitles SET JobTitleCode = '" + txtCode.Text.ToString() + "', JobTitle = '" + txtDescript.Text.ToString() + "', fReceive = '" + chkReceive.Checked.ToString() + "', fRepack = '" + chkRepack.Checked.ToString() + "', fInvCount = '" + chkInvCnt.Checked.ToString() + "', fWhTrf = '" + chkWhTrf.Checked.ToString() + "', fPickPack = '" + chkPickPack.Checked.ToString() + "', PickChecker = '" + chkChecker.Checked.ToString() + "'," +
                    " PSCollect = '" + chkPickControl.Checked.ToString() + "', AuthWHTrf = '" + chkAuthWhTrf.Checked.ToString() + "', AuthReceive = '" + chkAuthReceive.Checked.ToString() + "', AuthDispatch = '" + chkAuthDispatch.Checked.ToString() + "', CreateInvCount = '" + chkInvCntCreate.Checked.ToString() + "',  CloseInvCount = '" + chkInvCntClose.Checked.ToString() + "', SystAdmin = '" + chkAdmin.Checked.ToString() + "', InvReCountAuth = '" + chkRecount.Checked.ToString() + "'" +
                    " WHERE TitleID = " + lblTitleID.Text;
            }

            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "DocumentSQLConnection";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"POST?qry={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.POST;
                var res = client.Execute(Request);
                if (res.StatusCode.ToString() == "OK")
                {
                    MessageBox.Show("Changes successfully saved", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error saving changes - " + res.Content.ToString(), "SAVE FAILURE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Qstr = string.Empty;
            string message = "Delete this Job Title";
            string caption = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Qstr = "DELETE FROM dbo.JobTitles WHERE TitleID = " + lblTitleID.Text;
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "DocumentSQLConnection";
                client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
                {
                    string str = $"POST?qry={Qstr}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.POST;
                    var res = client.Execute(Request);
                    if (res.StatusCode.ToString() == "OK")
                    {
                        MessageBox.Show("Changes successfully saved", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error saving changes - " + res.Content.ToString(), "SAVE FAILURE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // Closes the parent form.
                this.Close();
            }
        }

        private void chkInvCntCreate_CheckedChanged(object sender, EventArgs e) 
        { 
        }
        //
    }
}
