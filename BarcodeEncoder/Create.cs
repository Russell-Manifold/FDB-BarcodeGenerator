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
            DDCodeType.SelectedIndex = 0;
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
                    switch (DDCodeType.Text)
                    {
                        case "QR_CODE":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.QR_CODE };
                            break;
                        case "UPC_A":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.UPC_A };
                            break;
                        case "CODE_128 (General)":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                            break;
                        case "EAN_13":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.EAN_13 };
                            break;
                        case "CODE_39":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_39 };
                            break;
                        case "All_1D":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.All_1D };
                            break;
                        case "AZTEC":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.AZTEC };
                            break;
                        case "CODABAR":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.CODABAR };
                            break;
                        case "CODE_93":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_93 };
                            break;
                        case "DATA_MATRIX":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.DATA_MATRIX };
                            break;
                        case "EAN_8":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.EAN_8 };
                            break;
                        case "IMB":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.IMB };
                            break;
                        case "ITF":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.ITF };
                            break;
                        case "MAXICODE":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.MAXICODE };
                            break;
                        case "MSI":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.MSI };
                            break;
                        case "PDF_417":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.PDF_417 };
                            break;
                        case "PHARMA_CODE":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.PHARMA_CODE };
                            break;
                        case "PLESSEY":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.PLESSEY };
                            break;
                        case "RSS_14":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.RSS_14 };
                            break;
                        case "RSS_EXPANDED":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.RSS_EXPANDED };
                            break;
                        case "UPC_E":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.UPC_E };
                            break;
                        case "UPC_EAN_EXTENSION":
                            writer = new BarcodeWriter() { Format = BarcodeFormat.UPC_EAN_EXTENSION };
                            break;
                    }
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

                    if (DDCodeType.Text == "EAN_13")
                    {
                        if (txfMainCode.Text.Length == 12)
                        {
                            i = writer.Write(txfMainCode.Text.ToUpper());
                            PicBox.Width = (i.Width + 20);
                            PicBox.Height = (i.Height + 20);
                        }
                        else
                        {
                            i = null;
                        }
                    }
                    else
                    if (DDCodeType.Text == "UPC_A")
                    {
                        if (txfMainCode.Text.Length == 11)
                        {
                            i = writer.Write(txfMainCode.Text.ToUpper());
                            PicBox.Width = (i.Width + 20);
                            PicBox.Height = (i.Height + 20);
                        }
                        else
                        {
                            i = null;
                        }
                    }

                    else
                    {
                        i = writer.Write(txfMainCode.Text.ToUpper());
                        PicBox.Width = (i.Width + 20);
                        PicBox.Height = (i.Height + 20);
                    }
                    txfName.Text = txfMainCode.Text.ToUpper();
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
                var frm1 = new frmwait();
                frm1.Show();
                frm1.Refresh();
                Bitmap bmp = new Bitmap(PicBox.ClientSize.Width, PicBox.ClientSize.Height);
                PicBox.DrawToBitmap(bmp, PicBox.ClientRectangle);
                bmp.Save(System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "barcode1Print.jpg"), ImageFormat.Jpeg);
                var frm = new BarcodePrint();
                frm.Show();
                frm.TopMost = true;
                frm1.Hide();
            }
            else
            {
                MessageBox.Show("No barcode present", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
