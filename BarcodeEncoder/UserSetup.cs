using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace BarcodeEncoder
{
    public partial class UserSetup : MetroFramework.Forms.MetroForm
    {
        Image i;
        DataSet UserNames = new DataSet();
        Double Wf = 152;
        Double Hf = 105;
        bool loaded = false;
        public UserSetup()
        {
            InitializeComponent();
            PicBox.Paint += new PaintEventHandler(pictureBox1_Paint);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try { 
                    BarcodeWriter writer;
                    writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                    writer.Options.PureBarcode = true;
                                    
                    writer.Options.Width = Convert.ToInt16(Wf);
                    writer.Options.Height = Convert.ToInt16(Hf);

                    i = writer.Write(txtPwd.Text.ToUpper());
                    PicBox.Paint += new PaintEventHandler(pictureBox1_Paint);
           
                if (i != null)
                {
                    PaperSize size = new PaperSize();
                    size.RawKind = (int)PaperKind.Custom;
                    size.Width = Convert.ToInt16(Wf);
                    size.Height = Convert.ToInt16(Hf);
                    size.PaperName = "Barcode";
                    PrintDocument pd = new PrintDocument();
                    pd = printDocument1;
                    pd.PrinterSettings = printDocument1.PrinterSettings;
                    pd.PrinterSettings.DefaultPageSettings.PaperSize = size;
                    printPreviewDialog1.Document = pd;
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There is no password to print", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception) { }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (i != null)
            {
                Graphics newGraphics = Graphics.FromImage(i);
                e.Graphics.DrawImage(i, new PointF(0, 3));
                newGraphics.Dispose();
            }
            else
            {
                e.Graphics.Clear(Color.White);
            }
        }
        private void PrintDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(Convert.ToInt16(Wf), Convert.ToInt16(Hf));
            PicBox.DrawToBitmap(bmp, PicBox.ClientRectangle);
            try
            {
                e.Graphics.DrawImage(bmp, 0, 3);
            }
            catch (Exception)
            {
                MessageBox.Show("There was a error in previewing your barcode please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UserSetup_Load(object sender, EventArgs e)
        {
            GetAllUsers();
        }
        private void GetAllUsers()
        {
            loaded = false;
            string Qstr = "SELECT * FROM dbo.tblUser WHERE isActive = 1 ORDER BY UserName";
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
                    UserNames = JsonConvert.DeserializeObject<DataSet>(res.Content);                  
                    DDUserName.DataSource = UserNames.Tables[0];
                    DDUserName.DisplayMember = "UserName";
                    DDUserName.SelectedIndex = -1;
                }
                
            }

            Qstr = "SELECT JobTitleCode, JobTitle FROM dbo.JobTitles ORDER BY JobTitle";
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
                    ddJobTitles.DataSource = ds1.Tables[0];
                    ddJobTitles.DisplayMember = "JobTitle";
                    ddJobTitles.ValueMember = "JobTitleCode";
                }
            }
            loaded = true;
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            string Qstr = string.Empty;
            if (txtUserName.Visible == true)
            {
                Qstr = "UPDATE dbo.tblUser SET UserName = '" + DDUserName.Text.ToString() + "' ,UserBarcode = '" + txtPwd.Text.ToString() + "', iJobTitleCode = '" + ddJobTitles.SelectedValue.ToString() + "', isActive = '" + togActive.Checked + "' WHERE UserNumber = '" + DDUserName.SelectedValue+ "'";
            }
            else
            {
                Qstr = "INSERT INTO dbo.tblUser (UserName, UserNumber, iJobTitleCode, isActive, UserBarcode) SELECT '" + DDUserName.Text.ToString() + "', '" + txtUserNumber.Text + "', '" + ddJobTitles.Text.ToString() + "', 1, '" + txtPwd.Text.ToString() + "'"; 
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            txtUserNumber.Enabled = true;
            txtUserNumber.Text = "";
            txtUserNumber.Focus();
            DDUserName.Visible = false;
            txtUserName.Visible = true;
            txtPwd.Text = "";
            ddJobTitles.SelectedIndex = -1;
        }

        private void DDUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDUserName.SelectedIndex!=-1&&loaded)
            {
                DataRow row = ((DataRowView)DDUserName.SelectedItem).Row;
                txtUserNumber.Text = row["UserNumber"].ToString();
                txtPwd.Text= row["UserBarcode"].ToString();
                togActive.Checked = Convert.ToBoolean(row["isActive"]);
                ddJobTitles.SelectedValue= row["iJobTitleCode"].ToString();
            }        
        }
    }
}
