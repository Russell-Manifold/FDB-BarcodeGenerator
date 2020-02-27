using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.Threading;
using RestSharp;

namespace BarcodeEncoder
{
    public partial class Encoder : MetroFramework.Forms.MetroForm
    {
        string sSelectedFolder;
        Image i;
        PastelInfoClass info = new PastelInfoClass();
        string itemCode="";
        string Desc = "No Item Found";
        bool exists = false;
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
            exists = false;
            if (txfEncoded.TextLength==13&&itemCode=="")
            {
                lblDesc.Hide();
                metroProgressSpinner1.Show();
                itemCode =await FindItemCode(txfEncoded.Text);
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
                lblDesc.Show();
                metroProgressSpinner1.Hide();
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
        private async void direc_Click(object sender, EventArgs e)
        {
            string output;
            if (i!=null) {
                if (txfName.Text != null && txfName.Text != "")
                {
                    PastelInfoClass SerNum = new PastelInfoClass();
                    if (exists)
                    {
                        output = "0";
                    }
                    else
                    {
                        output = await linkBarcodes();
                    }                   
                    if (output == "0")
                    {
                        MessageBox.Show("The items are linked, Please select a place to save the barcode to", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private async void BtnCreate_Click(object sender, EventArgs e)
        {
            string newCode =await Check();           
            try
            {
                PicBoxFinal.Invalidate();               
                try
                {
                    BarcodeWriter writer;
                    writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                    i = writer.Write(newCode);
                    PicBoxFinal.Width = (i.Width + 20);
                    PicBoxFinal.Height = (i.Height + 20);
                    txfFinalCode.Text = newCode;
                    txfName.Text = newCode;
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
        private async Task<string> linkCodesInPastel(string itemCode, string barcode)
        {
            try
            {
                string BOMHead = "" + barcode + "|BOM HEADER|12.1|12.2|12.3|12.4|12.5|12.6|12.7|12.8|12.9|12|10|20|30|100|200|300|" + itemCode + "|Y|Y|N||N|N|001";
                string line = "" + barcode + "|" + itemCode + "|" + txfNumOfItems.Text.Trim() + "|001#";
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "POSTBOM";
                client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
                {
                    string str = $"POST?BOMHead={BOMHead}&line={line}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.POST;
                    var cancellationTokenSource = new CancellationTokenSource();
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
        private async Task<string> FindItemCode(string barcode)
        {
            await Task.Delay(1000);
            try
            {
                string Qstr = "ACCPRD|4|" + barcode;
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "FindDescAndCode";
                client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
                {
                    string str = $"GET?qrystr={Qstr}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.GET;
                    var cancellationTokenSource = new CancellationTokenSource();
                    var res = client.Execute(Request);
                    if (res.StatusCode.ToString()=="OK")
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
        public async Task<string> linkBarcodes()
        {           
            if (itemCode!="")
            {
              return await linkCodesInPastel(itemCode, txfFinalCode.Text);
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
            exists = false;
        }
        public async Task<string> Check()
        {
            string newCode = "";
            string items = "";
            try
            {
                string Qstr = "ACCBOML|2|" + itemCode + "|" + txfNumOfItems.Text.Trim();
                RestSharp.RestClient client = new RestSharp.RestClient();
                string path = "CheckBOMExists";
                client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
                {
                    string str = $"GET?qrystr={Qstr}";
                    var Request = new RestSharp.RestRequest();
                    Request.Resource = str;
                    Request.Method = RestSharp.Method.GET;
                    var cancellationTokenSource = new CancellationTokenSource();
                    var res=client.Execute(Request);
                    if (res.StatusCode.ToString().Contains("OK"))
                    {
                        string returnVal = res.Content.Substring(1, res.Content.Length - 2);
                        if (returnVal.Split('|')[0] == "0")
                        {
                            newCode = returnVal.Split('|')[1];
                            exists = true;
                            MessageBox.Show("There is already a BOM with this same quatity and the same item code", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return newCode;
                        }
                        else
                        {
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
                            exists = false;
                            return newCode;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to the API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

    }
}
