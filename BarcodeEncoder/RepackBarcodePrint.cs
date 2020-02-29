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
    public partial class RepackBarcodePrint : MetroFramework.Forms.MetroForm
    {
        Image i = null;
        public RepackBarcodePrint()
        {
            InitializeComponent();
            getLabelSizes();
        }

        private void getLabelSizes()
        {

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
                if (res.StatusCode.ToString() == "OK")
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<string> lists = GetQue();
            if (lists == null)
            {
                MessageBox.Show("There is no barcodes to print", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                int j = 0;
                while (j < lists.Count()) {
                DialogResult result = MessageBox.Show("Print " + lists[j].Split('|')[0] + " ?", "Print Pack Code?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result.ToString() == "Yes")
                    {
                        try
                        {
                            BarcodeWriter writer;
                            writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                            //writer.Options.PureBarcode = true;
                            //User setting Height and width

                            int W = Convert.ToInt32(ddLabelSize.SelectedValue.ToString().Split('|')[0]);
                            int H = Convert.ToInt32(ddLabelSize.SelectedValue.ToString().Split('|')[1]);
                            double pixelFactor = 0.2645;
                            Double Wf = (W / pixelFactor) - 20;
                            Double Hf = (H / pixelFactor) - 20;

                            writer.Options.Width = Convert.ToInt16(Wf);
                            writer.Options.Height = Convert.ToInt16(Hf);

                            i = writer.Write(lists[j].Split('|')[0]);
                            if (i != null)
                            {
                                PaperSize size = new PaperSize();
                                size.RawKind = (int)PaperKind.Custom;
                                size.Width = Convert.ToInt16((W / pixelFactor));
                                size.Height = Convert.ToInt16(H / pixelFactor);
                                size.PaperName = "Barcode";

                                PrintDocument pd = new PrintDocument();
                                pd.PrintPage += PrintPage;
                                pd = printDocument1;
                                pd.PrinterSettings = printDocument1.PrinterSettings;

                                pd.PrinterSettings.DefaultPageSettings.PaperSize = size;
                                printPreviewDialog1.Document = pd;
                                printPreviewDialog1.ShowDialog();
                                j += 1;
                                DeleteQue(Convert.ToInt16(lists[0].Split('|')[1]));
                            }
                            else
                            {
                                MessageBox.Show("There is no barcodes to print", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception) { }
                    }
                    else { j += 1; }
            }
                MessageBox.Show("Printing Complete", "Pack Code Printing!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void PrintPage(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = i;
            Point loc = new Point(0, 0);
            if (togBoarder.Checked == true)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black, 5), new Rectangle(3, 3, (i.Width + 15), (i.Height + 15)));
                loc = new Point(7, 7);
            }
            e.Graphics.DrawImage(img, loc);
        }

        private List<string> GetQue()
        {
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "DocumentSQLConnection";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?qry=SELECT * FROM tblPrintQue ORDER BY PiID";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client.Execute(Request);
                if (res.StatusCode.ToString().Contains("OK") && res.Content.Contains("Barcode"))
                {
                    DataSet ds = new DataSet();
                    ds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    var T = new List<string>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        T.Add(dr[0].ToString() + "|" + dr[2].ToString());
                    }
                    return T;
                }
                else
                {
                    return null;
                }
            }
        }
        private void DeleteQue(int id)
        {
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "DocumentSQLConnection";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"POST?qry=DELETE FROM tblPrintQue WHERE PiID = " + id;
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var res = client.Execute(Request);
            }
        }
    }
}
