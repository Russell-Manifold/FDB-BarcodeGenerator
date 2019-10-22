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
        Link LinkForm = null;
        Create CreateForm = null;
        Encoder EncodeForm = null;
        public DashBoard()
        {
            InitializeComponent();           
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
            LinkForm = new Link();
            LinkForm.Show();           
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
            CreateForm.Show();
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
            EncodeForm.Show();
        }
       
    }
}
