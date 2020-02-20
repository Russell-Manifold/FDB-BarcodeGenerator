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
    public partial class InProgressDisplay : MetroFramework.Forms.MetroForm
    {
        string Qstr = string.Empty;
        string doctyp = string.Empty;
        DataTable inProgTbl; DataTable ColTbl; DataRow dtblRow;
        public InProgressDisplay(int doctype)
        {
            InitializeComponent();
            doctyp = doctype.ToString();
        }

        private void InProgressDisplay_Load(object sender, EventArgs e)
        {
            lblrefreshtime.Text = DateTime.Now.ToString();
            if (doctyp == "106")
            {
                lblHeader.Text = "Purchase Orders";
            }
            GetSlips();
        }

        private void GetSlips() {
            Qstr = "ACCHISTH|7|" + doctyp;
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "GetDocStatusSummary";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?qrystr={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client.Execute(Request);
                if (res.IsSuccessful)
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    ds.Tables[0].Columns.Remove("Printed");
                    ds.Tables[0].DefaultView.RowFilter = " Status <> '" + "Complete" + "'";
                    inProgTbl = ds.Tables[0];
                    inProgTbl.DefaultView.Sort = "Due_Date";
                    dataGridView1.DataSource = inProgTbl;
                    int rwcnt = inProgTbl.Rows.Count;
                    
                    int i = 0; int colcnt = inProgTbl.Columns.Count;
                    ColTbl = new DataTable();
                    ColTbl.Columns.Add("Colname");
                    while (i < colcnt) {
                        dtblRow = ColTbl.NewRow();
                        dtblRow["Colname"] = inProgTbl.Columns[i].ColumnName;
                        ColTbl.Rows.Add(dtblRow);
                        i = i += 1;
                    }
                    DDsearchBy.DataSource = ColTbl;
                    DDsearchBy.ValueMember = "Colname";
                    DDsearchBy.DisplayMember = "Colname";

                    formatgridlines();
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Unable to display Picking slips", "Unable to connect", MessageBoxButtons.OK);
                }
            }
        }


        //private async Task<string>GetSlipsOnTimer()
        private Task<string> GetSlipsOnTimer()
        {
            if (togrefresh.Checked == true) {
                var frm = new frmwait();
                frm.Show();
                frm.Refresh();

                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "GetDocStatusSummary";
                client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
                {
                    string str = $"GET?qrystr={Qstr}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.GET;
                    //var cancellationTokenSource = new CancellationTokenSource();
                    var res = client.Execute(Request);
                    if (res.IsSuccessful)
                    {
                        DataSet ds = new DataSet();
                        ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                        ds.Tables[0].Columns.Remove("Printed");
                        ds.Tables[0].DefaultView.RowFilter = " Status <> '" + "Complete" + "'";
                        inProgTbl = ds.Tables[0];
                        dataGridView1.DataSource = inProgTbl;
                        int rwcnt = inProgTbl.Rows.Count;
                        int i = 0; int colcnt = inProgTbl.Columns.Count;
                        ColTbl = new DataTable();
                        ColTbl.Columns.Add("Colname");
                        while (i < colcnt)
                        {
                            dtblRow = ColTbl.NewRow();
                            dtblRow["Colname"] = inProgTbl.Columns[i].ColumnName;
                            ColTbl.Rows.Add(dtblRow);
                            i = i += 1;
                        }
                        DDsearchBy.DataSource = ColTbl;
                        DDsearchBy.ValueMember = "Colname";
                        DDsearchBy.DisplayMember = "Colname";
                        formatgridlines();
                    }
                    else
                    {
                        MessageBox.Show("Unable to display Picking slips", "Unable to connect", MessageBoxButtons.OK);
                    }
                }
                frm.Hide();
            }
            return null;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
           await GetSlipsOnTimer();
        }

        private void Sort_Rows (object sender, EventArgs e) {
            formatgridlines();
        }

        private void formatgridlines() {
            lblrefreshtime.Text = DateTime.Now.ToString();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            if (doctyp == "106") {
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }
            dataGridView1.Columns["Due_Date"].DefaultCellStyle.Format = "dd MMM yyyy";
            dataGridView1.Columns["Due_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lblReccount.Text = dataGridView1.Rows.Count.ToString() + " Records";
            foreach (DataGridViewRow grw in dataGridView1.Rows)
            {
                if (grw.Cells["Status"].Value != null) { 
                    if (grw.Cells["Status"].Value.ToString() == "Collected")
                    {
                        grw.Cells["Status"].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    else if (grw.Cells["Status"].Value.ToString() == "In Progress")
                    {
                        grw.Cells["Status"].Style.BackColor = Color.LightGreen;
                    }
                    else if (grw.Cells["Status"].Value.ToString() == "Picked")
                    {
                        grw.Cells["Status"].Style.BackColor = Color.PaleGreen;
                    }
                    else if (grw.Cells["Status"].Value.ToString() == "Packed")
                    {
                        grw.Cells["Status"].Style.BackColor = Color.Orange;
                    }
                }
                if (Convert.ToDateTime(grw.Cells["Due_Date"].Value) <= DateTime.Today.AddDays(-1))
                {
                    grw.Cells["Due_Date"].Style.BackColor = Color.Orange;
                } else if (Convert.ToDateTime(grw.Cells["Due_Date"].Value).ToString() == DateTime.Today.Date.ToString()) {
                    grw.Cells["Due_Date"].Style.BackColor = Color.LightGreen;
               }
            }
        }

        private void togrefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (togrefresh.Checked == true)
            {
                GetSlips();
            } else {
                timer1.Stop();
            }
        }

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
                 inProgTbl.DefaultView.RowFilter = String.Format(DDsearchBy.Text + " LIKE '%{0}%'", txtfind.Text);
                 lblReccount.Text = dataGridView1.Rows.Count.ToString() + " Records";
        }

        private void DDsearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDsearchBy.Text == "Due_Date")
            {
                dateTimePicker1.Visible = true;
                txtfind.Visible = false;
            }
            else
            {
                dateTimePicker1.Visible = false;
                txtfind.Visible = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            inProgTbl.DefaultView.RowFilter = String.Format(" Due_Date = '{0}'", dateTimePicker1.Text);
            lblReccount.Text = dataGridView1.Rows.Count.ToString() + " Records";
        }

        private void InProgressDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (togrefresh.Checked == true)
            {
                timer1.Stop();
            }           
        }
    }
}
