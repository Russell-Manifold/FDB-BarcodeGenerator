using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace BarcodeEncoder
{
    public partial class Create : MetroFramework.Forms.MetroForm
    {
        Image i;
        string sSelectedFolder;
        public Create()
        {
            InitializeComponent();
            this.ActiveControl = txfMainCode;
            PicBox.Paint += new PaintEventHandler(pictureBox1_Paint);
            getLabelSizes();
        }
        private void Code_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txfMainCode.Text.ToString().Length > 0)
                {
                    PicBox.Invalidate();
                    Task.Delay(1000);
                    BarcodeWriter writer;
                    writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                    if (togValue.Checked == false)
                    {
                        writer.Options.PureBarcode = true;
                    }
                    int W = Convert.ToInt32(ddLabelSize.SelectedValue.ToString().Split('|')[0]);
                    int H = Convert.ToInt32(ddLabelSize.SelectedValue.ToString().Split('|')[1]);
                    double pixelFactor = 0.2645;
                    Double Wf = (W / pixelFactor) - 20;
                    Double Hf = (H / pixelFactor) - 20;
                    writer.Options.Width = Convert.ToInt16(Wf);
                    writer.Options.Height = Convert.ToInt16(Hf);
                   
                    i = writer.Write(txfMainCode.Text.ToUpper());
                    txfName.Text = txfMainCode.Text.ToUpper();
                    PicBox.Width = (i.Width + 20);
                    PicBox.Height = (i.Height + 20);
                    PicBox.Paint += new PaintEventHandler(pictureBox1_Paint);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not display code as barcode", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbIndexChanged(object sender, EventArgs e)
        {
            txfMainCode.Text = string.Empty;
            txfName.Text = string.Empty;
            if (i != null) {
                i.Dispose();
            }
            PicBox.Paint += new PaintEventHandler(pictureBox1_Paint);
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (i != null)
            {
                PaperSize size = new PaperSize();
                size.RawKind = (int)PaperKind.Custom;
                size.Width = PicBox.Width;
                size.Height = PicBox.Height;
                size.PaperName = "Barcode";
                PrintDocument pd = new PrintDocument();
                pd = printDocument1;
                pd.PrinterSettings = printDocument1.PrinterSettings;
                pd.PrinterSettings.DefaultPageSettings.PaperSize = size;
                pd.Print();
                //printPreviewDialog1.Document = pd;
                //printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is no barcode to be printed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void direc_Click(object sender, EventArgs e)
        {
            if (i != null)
            {
                Bitmap bmp = new Bitmap(PicBox.ClientSize.Width, PicBox.ClientSize.Height);
                PicBox.DrawToBitmap(bmp, PicBox.ClientRectangle);
                if (txfName.Text != null && txfName.Text != "")
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    fbd.SelectedPath = sSelectedFolder;
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        sSelectedFolder = fbd.SelectedPath;
                    }
                    else
                        sSelectedFolder = string.Empty;
                    if (sSelectedFolder != null && sSelectedFolder != "")
                    {
                        try
                        {
                            bmp.Save(@"" + sSelectedFolder + "\\" + txfName.Text + ".jpg", ImageFormat.Jpeg);
                            MessageBox.Show("The Barcode has been saved as " + txfName.Text, "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Please check the location and file name you have selected is valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a file Path", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Valid File Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is no barcode to save", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (i != null)
            {
                Graphics newGraphics = Graphics.FromImage(i);
                if (togBoarder.Checked == true)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 5), new Rectangle(3, 3, (i.Width + 10), (i.Height + 10)));
                } 
                e.Graphics.DrawImage(i, new PointF(10, 10));
                newGraphics.Dispose();
            }
            else
            {
                e.Graphics.Clear(Color.White);
            }
        }

        private void PrintDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(PicBox.ClientSize.Width, PicBox.ClientSize.Height);
            PicBox.DrawToBitmap(bmp, PicBox.ClientRectangle);
            try
            {
                e.Graphics.DrawImage(bmp, 0, 0);
            }
            catch (Exception)
            {
                MessageBox.Show("There was a error in previewing your barcode please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void togBoarder_CheckedChanged(object sender, EventArgs e)
        {
            Code_TextChanged(sender, EventArgs.Empty);
        }

        private void togValue_CheckedChanged(object sender, EventArgs e)
        {
            Code_TextChanged(sender, EventArgs.Empty);
        }

        private void ddLabelSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Focused) {
               Code_TextChanged(sender, EventArgs.Empty);
            }          
        }

        private void getLabelSizes() {

            string Qstr = "SELECT TOP (100) PERCENT lblWidth, lblHeight, lblDescript FROM dbo.LabelSizes ORDER BY isDefault DESC, lblWidth";
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "DocumentSQLConnection";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?qry={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client.Execute(Request);
                if (res.StatusCode.ToString()=="OK")
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dr["lblWidth"] = dr[0].ToString() + " | " + dr[1].ToString();
                    }
                        ddLabelSize.DataSource = ds.Tables[0];
                        ddLabelSize.ValueMember = "lblWidth";
                        ddLabelSize.DisplayMember = "lblDescript";
                }
            }

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked == true)
            {
                txfMainCode.UseSystemPasswordChar = true;
                togValue.Checked = false;
            }
            else {
                txfMainCode.UseSystemPasswordChar = false;
                togValue.Checked = true;
            }
        }
    }   
}
