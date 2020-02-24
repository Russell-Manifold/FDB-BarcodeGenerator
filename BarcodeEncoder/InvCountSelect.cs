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
    public partial class InvCountSelect : MetroFramework.Forms.MetroForm
    {
        public InvCountSelect()
        {
            InitializeComponent();
            GetAllOpencounts();
        }

        public void GetAllOpencounts() {

            string Qstr = "SELECT CountID as [ID], Description, CreatedDate as [Created Date], Whse as [WH] FROM dbo.InventoryHeader WHERE Active =1 ORDER BY CountID";
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "DocumentSQLConnection";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?qry={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client.Execute(Request);
                if (res.StatusCode.ToString().Contains("OK"))
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    gridCountHeader.DataSource = ds.Tables[0];
                    gridCountHeader.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    gridCountHeader.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    gridCountHeader.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    gridCountHeader.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
            }

        }

        private void gridCountHeader_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = gridCountHeader.Rows[e.RowIndex];
                var frm = new InvCountItems(row.Cells["ID"].Value.ToString());
                frm.ShowDialog();
            }         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Open New Inventory Count?", "Open New", MessageBoxButtons.YesNo);
            if (result.ToString() == "Yes") {
                this.Close();
                var frm = new InvCountNew();
                frm.ShowDialog();
            }
        }

        private void InvCountSelect_Activated(object sender, EventArgs e)
        {
            GetAllOpencounts();
        }
    }
}
