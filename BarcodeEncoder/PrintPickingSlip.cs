using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ZXing;
using Microsoft.Reporting.WinForms;

namespace BarcodeEncoder
{
    public partial class PrintPickingSlip : Form
    {
        Image i;
        public PrintPickingSlip(string docnum, string doctype)
        {
            InitializeComponent();
            lblDocNum.Text = docnum;
            lblDocType.Text = doctype;
        }

        private void PrintPickingSlip_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            int totqty = 0; int thisqty;
            // get document header information
            BarcodeWriter writer;
            writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            i = writer.Write(lblDocNum.Text.ToUpper());
            i.Save(Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "barcode1.jpg"), ImageFormat.Jpeg);

            DataSet MyDs = new DataSet();
            string Qstr = "ACCHISTL|6|" + lblDocNum.Text + "|" + lblDocType.Text;
            RestSharp.RestClient client = new RestSharp.RestClient();
            string path = "GetFullDocDetails";
            client.BaseUrl = new Uri(BarcodeEncoder.Properties.Settings.Default.API + path);
            {
                string str = $"GET?qrystr={Qstr}";
                var Request = new RestSharp.RestRequest();
                Request.Resource = str;
                Request.Method = RestSharp.Method.GET;
                var cancellationTokenSource = new CancellationTokenSource();
                var res = client.Execute(Request);
                if (res.StatusCode.ToString().Contains("OK"))
                {
                    DataSet Myds = new DataSet();
                    Myds = JsonConvert.DeserializeObject<DataSet>(res.Content);
                    DataSet ds = new PickSlip();
                    DataTable dt = ds.Tables["dtPSLines"];

                    foreach (DataRow dr in Myds.Tables[0].Rows)
                    {
                        if (dr["ItemCode"].ToString().Length > 1)
                        {
                            DataRow d = dt.NewRow();
                            d["ItemCode"] = dr["ItemCode"].ToString();
                            d["ItemDescription"] = dr["ItemDesc"].ToString();
                            d["Qty"] = dr["ItemQty"].ToString();
                            d["Bin"] = dr["Bin"].ToString();
                            d["Barcode"] = dr["Barcode"].ToString();
                            thisqty = Convert.ToInt32(dr["ItemQty"].ToString());
                            totqty = totqty + thisqty;
                            dt.Rows.Add(d);
                        }
                    }

                    ReportParameter[] p = new ReportParameter[15];
                    p[0] = new ReportParameter("OrderNumber", Myds.Tables[0].Rows[0]["OrderNumber"].ToString());
                    p[1] = new ReportParameter("SupplierCode", Myds.Tables[0].Rows[0]["CustomerCode"].ToString());
                    p[2] = new ReportParameter("SupplierName", Myds.Tables[0].Rows[0]["CustomerName"].ToString());
                    p[3] = new ReportParameter("Contact", Myds.Tables[0].Rows[0]["Contact"].ToString());
                    p[4] = new ReportParameter("Address1", Myds.Tables[0].Rows[0]["Address1"].ToString());
                    p[5] = new ReportParameter("Address2", Myds.Tables[0].Rows[0]["Address2"].ToString());
                    p[6] = new ReportParameter("Address3", Myds.Tables[0].Rows[0]["Address3"].ToString());
                    p[7] = new ReportParameter("Address4", Myds.Tables[0].Rows[0]["Address4"].ToString());
                    p[8] = new ReportParameter("ExtRef", Myds.Tables[0].Rows[0]["ExtRef"].ToString());
                    p[9] = new ReportParameter("RepCode", Myds.Tables[0].Rows[0]["SalesmanCode"].ToString());
                    if (Myds.Tables[0].Rows[0]["Due_Date"].ToString().Length > 0)
                    {
                        String dteS = Myds.Tables[0].Rows[0]["Due_Date"].ToString();
                        DateTime dtD = Convert.ToDateTime(dteS);
                        p[10] = new ReportParameter("DueDate", dtD.ToString("dd MMM yyyy"));
                    }
                    else
                    {
                        p[10] = new ReportParameter("DueDate", DateTime.Today.ToString("dd MMM yyyy"));
                    }
                    p[11] = new ReportParameter("TotQty", totqty.ToString());
                    string msg = Myds.Tables[0].Rows[0]["Message_1"].ToString() + ' ' + Myds.Tables[0].Rows[0]["Message_2"].ToString() + ' ' + Myds.Tables[0].Rows[0]["Message_3"].ToString();
                    p[12] = new ReportParameter("Message2", msg);

                    if (lblDocType.Text == "102")
                    {
                        p[13] = new ReportParameter("SlipType", "Picking Slip");
                    }
                    else if (lblDocType.Text == "106")
                    {
                        p[13] = new ReportParameter("SlipType", "Receiving Slip");
                    }
                    else
                    {
                        p[13] = new ReportParameter("SlipType", "Slip");
                    }
                    p[14] = new ReportParameter("imgpath", Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "barcode1.jpg"));

                    this.reportViewer1.LocalReport.EnableExternalImages = true;
                    this.reportViewer1.LocalReport.SetParameters(p);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PickSlip", ds.Tables["dtPSLines"]));
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("No Picking Slip Available To Print", "Print Error", MessageBoxButtons.OK);
                }
            }
        }
        private void PrintPickingSlip_Close(object sender, EventArgs e)
        {
            if (File.Exists("C:\\barcode1.jpg"))
            {
                File.Delete("C:\\barcode1.jpg");
            }
        }
    }
}
