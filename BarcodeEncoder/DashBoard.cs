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
    public partial class DashBoard : MetroFramework.Forms.MetroForm
    {
        public static DataRow UserData;
        Link LinkForm = null;
        Create CreateForm = null;
        Encoder EncodeForm = null;
        AdminDashboard admin = null;
        SlipsPickOrReceive psList = null;

        public DashBoard(DataRow dr)
        {          
            InitializeComponent();
            UserData = dr;
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            try
            {
                LinkForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                CreateForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                EncodeForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                admin.Close();
            }
            catch (Exception)
            { }
            LinkForm = new Link();
            LinkForm.ShowDialog();
            btnScan.Focus();
        }

        private void BtnCreateBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                LinkForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                admin.Close();
            }
            catch (Exception)
            { }
            try
            {
                CreateForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                EncodeForm.Close();
            }
            catch (Exception)
            { }
            CreateForm = new Create();
            CreateForm.ShowDialog();
            btnNewBarcode.Focus();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                LinkForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                admin.Close();
            }
            catch (Exception)
            { }
            try
            {
                CreateForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                EncodeForm.Close();
            }
            catch (Exception)
            { }
            EncodeForm = new Encoder();
            EncodeForm.ShowDialog();
            btnCreate.Focus();
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            try
            {
                LinkForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                admin.Close();
            }
            catch (Exception)
            { }
            try
            {
                CreateForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                EncodeForm.Close();
            }
            catch (Exception)
            { }
            admin = new AdminDashboard();
            admin.ShowDialog();
            btnScan.Focus();
        }

        private void btnPickSlipsList_Click(object sender, EventArgs e)
        {
            try
            {
                LinkForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                admin.Close();
            }
            catch (Exception)
            { }
            try
            {
                CreateForm.Close();
            }
            catch (Exception)
            { }
            try
            {
                EncodeForm.Close();
            }
            catch (Exception)
            { }
            psList = new SlipsPickOrReceive();
            psList.ShowDialog();
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ViewProgressChoose frm = new ViewProgressChoose();
            frm.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            InvCountSelect frm = new InvCountSelect();
            frm.ShowDialog();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            if (UserData["JobTitleCode"].ToString()=="Sup")
            {
                btnPickSlipsList.Enabled = true;
                btnNewBarcode.Enabled = true;
                btnScan.Enabled = true;
                btnCreate.Enabled = true;
                //inv counts
                metroButton1.Enabled = true;
                //inprogress
                metroButton2.Enabled = true;
            }
            else
            {
                try
                {
                    if (Convert.ToBoolean(UserData["fReceive"]))
                    {
                        btnPickSlipsList.Enabled = true;
                    }
                }
                catch
                {

                }
                try
                {

                    if (Convert.ToBoolean(UserData["CreateBarcodes"]))
                    {
                        btnNewBarcode.Enabled = true;
                    }
                }
                catch
                {

                }
                try
                {
                    if (Convert.ToBoolean(UserData["LinkBarcodes"]))
                    {
                        btnScan.Enabled = true;
                    }
                }
                catch
                {

                }
                try
                {
                    if (Convert.ToBoolean(UserData["CreatePackCodes"]))
                    {
                        btnCreate.Enabled = true;
                    }
                }
                catch
                {

                }
                try
                {
                    if (Convert.ToBoolean(UserData["fInvCount"]))
                    {
                        metroButton1.Enabled = true;
                    }
                }
                catch
                {

                }
                try
                {
                    if (Convert.ToBoolean(UserData["AuthDispatch"]))
                    {
                        metroButton2.Enabled = true;
                    }
                }
                catch
                {

                }
               
            }
           
        }
    }
}
