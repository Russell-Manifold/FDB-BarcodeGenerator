using PasSDK;
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
using System.Windows.Xps.Packaging;
using ZXing;
using Microsoft.VisualBasic.CompilerServices;

namespace BarcodeEncoder
{
    public partial class Encoder : MetroFramework.Forms.MetroForm
    {
        string sSelectedFolder;
        Image i;
        PastelInfoClass info = new PastelInfoClass();
        string itemCode="";
        string Desc = "No Item Found";
        public Encoder()
        {
            InitializeComponent();
            PicBoxFinal.Paint += new PaintEventHandler(pictureBox1_Paint);
            txfNumOfItems.Enabled = false;
           
        }
        private void Encoder_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txfEncoded;
        }
        private async void txfEncoded_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(100);
            if (txfEncoded.TextLength==13&&itemCode=="")
            {
                SpinnerLoading.Show();
                itemCode = FindItemCode(txfEncoded.Text);
                  if (itemCode != "")
                  {
                    txfEncoded.BackColor = Color.LightGreen;
                    lblDesc.Text = Desc;
                    txfNumOfItems.Enabled = true;
                    this.ActiveControl = txfNumOfItems;                     
                  }
                  else
                  {
                    MessageBox.Show("There is no item with this barcode!", "Error!");
                    txfEncoded.BackColor = Color.Orange;
                    txfNumOfItems.Enabled = false;
                    this.ActiveControl = txfEncoded;
                  }
                SpinnerLoading.Hide();
            }
            else if(txfEncoded.TextLength != 13&&txfEncoded.BackColor == Color.LightGreen&& txfEncoded.TextLength != 0)
            {
                itemCode = "";
                Desc="No Item Found";
                lblDesc.Text = Desc;
                txfNumOfItems.Enabled = false;
                txfEncoded.BackColor = Color.Orange;
            }else if (txfEncoded.TextLength == 0)
            {
                itemCode = "";
                Desc = "No Item Found";
                lblDesc.Text = Desc;
                txfNumOfItems.Enabled = false;
                txfEncoded.BackColor = Color.White;
            }

        }
        private async void TxfNumOfItems_TextChanged(object sender, EventArgs e)
        {
            if (txfNumOfItems.Text != "")
            {
                await Task.Delay(500);
                int qty = 0;
                try
                {
                    qty = Convert.ToInt32(txfNumOfItems.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unrecognised Quantity", "Quantity Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (qty > 99)
                {
                    MessageBox.Show("Invalid Quantity", "Quantity Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (qty == 0)
                {
                    MessageBox.Show("Invalid Quantity", "Quantity Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }

        }
        private void direc_Click(object sender, EventArgs e)
        {
            if (i!=null) {
                if (txfName.Text != null && txfName.Text != "")
                {
                    PastelInfoClass SerNum = new PastelInfoClass();
                    string output = linkBarcodes();
                    if (output == "0")
                    {
                        MessageBox.Show("The items were linked, Please select a place to save the barcode to", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bitmap bmp = new Bitmap(PicBoxFinal.ClientSize.Width, PicBoxFinal.ClientSize.Height);
                        PicBoxFinal.DrawToBitmap(bmp, PicBoxFinal.ClientRectangle);
                        FolderBrowserDialog fbd = new FolderBrowserDialog();
                        fbd.SelectedPath = sSelectedFolder;
                        if (fbd.ShowDialog() == DialogResult.OK)
                        {
                            sSelectedFolder = fbd.SelectedPath;
                        }
                        else
                        {
                            sSelectedFolder = string.Empty;
                        }
                        if (sSelectedFolder != null)
                        {
                            try
                            {
                                bmp.Save(@"" + sSelectedFolder + "\\" + txfName.Text + ".jpg", ImageFormat.Jpeg);
                                MessageBox.Show("The Barcode has been saved as " + txfName.Text, "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearPage();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Please check the location and file name you have selected is valid ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a file Path", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (output == "")
                    {
                        MessageBox.Show("There was a error in linking the items", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("The Items were not Linked, Error code\n" + SerNum.GetResultDesc(output), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Valid File Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is no barcode to be saved!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(PicBoxFinal.ClientSize.Width, PicBoxFinal.ClientSize.Height);
            PicBoxFinal.DrawToBitmap(bmp, PicBoxFinal.ClientRectangle);
            Bitmap newpic = new Bitmap(bmp, new Size(bmp.Width, bmp.Height));
            try
            {
                e.Graphics.DrawImage(newpic, 0, 0);
            }
            catch (Exception)
            {
                MessageBox.Show("There was a error in previewing your barcode please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (i!=null)
            {
                PaperSize size = new PaperSize();
                size.RawKind = (int)PaperKind.Custom;
                size.Width = 135;
                size.Height = 125;
                size.PaperName = "Barcode";
                PrintDocument pd = new PrintDocument();
                pd = printDocument1;
                pd.PrinterSettings = printDocument1.PrinterSettings;
                pd.PrinterSettings.DefaultPageSettings.PaperSize = size;
                Console.Out.WriteLine("My paper size: " + pd.DefaultPageSettings.PaperSize);
                PrintDialog printDialog = new PrintDialog(); // to choose printer
                printDialog.Document = pd;
                printPreviewDialog1.Document = pd;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is no barcode to be printed","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dash = new DashBoard();
            dash.ShowDialog();
            this.Close();
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string auth = @"DK198110007|5635796|C:\Users\Russell - Manifold\Desktop\FDB2020";
                string Qstr = "ACCBOML|2|" + itemCode+"|"+txfNumOfItems.Text.Trim();
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "CheckBOMExists";
                client.BaseUrl = new Uri("http://localhost:7721//api/" + path);
                {
                    string str = $"GET?authDetails={auth}&qrystr={Qstr}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.GET;
                    var res = client.Execute(Request);
                    if (res.IsSuccessful)
                    {
                        string returnVal = res.Content.Substring(1, res.Content.Length - 2);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to the API","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            try
            {
                PicBoxFinal.Invalidate();
                string newCode = "";
                string items = "";
                if (Convert.ToInt32(txfNumOfItems.Text) < 10)
                {
                    items = "0" + txfNumOfItems.Text;
                }
                else if (Convert.ToInt32(txfNumOfItems.Text) > 100)
                {
                    items = "99";
                }
                else
                {
                    items = txfNumOfItems.Text;
                }
                newCode = "F" + items + txfEncoded.Text.Substring(txfEncoded.TextLength - 6, 5);
                try
                {
                    BarcodeWriter writer;
                    if (newCode.Length == 11)
                    {
                        writer = new BarcodeWriter() { Format = BarcodeFormat.UPC_E };
                    }
                    else if (newCode.Length == 13)
                    {
                        writer = new BarcodeWriter() { Format = BarcodeFormat.EAN_13 };
                    }
                    else
                    {
                        writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                    }
                    i = writer.Write(newCode);
                    PicBoxFinal.Width = (i.Width + 20);
                    PicBoxFinal.Height = (i.Height + 20);
                    txfFinalCode.Text = newCode;
                    this.ActiveControl = txfName;
                }
                catch (Exception)
                {
                    MessageBox.Show("The Barcode could not be generated, Please try again!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure you have the correct item code", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (i != null)
            {
                Graphics newGraphics = Graphics.FromImage(i);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 5), new Rectangle(3, 3, (i.Width + 10), (i.Height + 10)));
                e.Graphics.DrawImage(i, new PointF(10, 10));
                newGraphics.Dispose();
            }
            else
            {
                e.Graphics.Clear(Color.White);
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearPage();
        }
        private string linkCodesInPastel(string itemCode, string barcode)
        {
            try
            {
                string auth = @"DK198110007|5635796|C:\Users\Russell - Manifold\Desktop\FDB2020";
                string BOMHead = "" + barcode + "|BOM HEADER|12.1|12.2|12.3|12.4|12.5|12.6|12.7|12.8|12.9|12|10|20|30|100|200|300|" + itemCode + "|Y|Y|N||N|N|001";
                string line = "" + barcode + "|" + itemCode + "|" + txfNumOfItems.Text.Trim() + "|001#";
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "POSTBOM";
                client.BaseUrl = new Uri("http://localhost:7721//api/" + path);
                {
                    string str = $"POST?authDetails={auth}&BOMHead={BOMHead}&line={line}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.POST;
                    var res = client.Execute(Request);
                    if (res.StatusCode.ToString().Contains("OK"))
                    {                                       
                        return res.Content.Substring(1, res.Content.Length - 2);
                    }
                    else
                    {
                        MessageBox.Show(info.GetResultDesc(res.Content.Substring(1, res.Content.Length - 2)) + "", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not link items", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }
        private  string FindItemCode(string barcode)
        {
            try
            {
                string auth = @"DK198110007|5635796|C:\Users\Russell - Manifold\Desktop\FDB2020";
                string Qstr = "ACCPRD|4|" + barcode;
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "FindDescAndCode";
                client.BaseUrl = new Uri("http://localhost:7721//api/" + path);
                {
                    string str = $"GET?authDetails={auth}&qrystr={Qstr}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.GET;
                    var res = client.Execute(Request);
                    if (res.IsSuccessful)
                    {
                        string returnVal = res.Content.Substring(1, res.Content.Length - 2);
                        Desc = returnVal.Split('|')[3];
                        return returnVal.Split('|')[2];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to the API", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }
        public string linkBarcodes()
        {           
            if (itemCode!="")
            {
              return linkCodesInPastel(itemCode, txfFinalCode.Text);
            }
            else
            {
                MessageBox.Show("There is no item with this code, Please try again","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return "";
        }   
        public void ClearPage()
        {
            itemCode = "";
            txfEncoded.Text = "";
            txfNumOfItems.Text = "";
            txfFinalCode.Text = "";
            txfName.Text = "";
            PicBoxFinal.Image = null;
            PicBoxFinal.Width = 241;
            PicBoxFinal.Height = 130;
            Desc = "No Item Found";
            i = null;
            PicBoxFinal.Invalidate();
            this.ActiveControl = txfEncoded;
        }
    }
}
