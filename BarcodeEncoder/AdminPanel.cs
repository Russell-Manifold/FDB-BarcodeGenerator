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
    public partial class AdminPanel : MetroFramework.Forms.MetroForm
    {
        public AdminPanel()
        {
            InitializeComponent();          
        }

        private void BtnLocation_Click(object sender, EventArgs e)
        {
            string selectedFolder = BarcodeEncoder.Properties.Settings.Default.ConnectionString;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = selectedFolder;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = fbd.SelectedPath;
            }
            else
            {
                selectedFolder = string.Empty;
            }
            if (selectedFolder != null)
            {
                try
                {
                    txfLocation.Text = selectedFolder;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check the location and file name you have selected is valid ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All the changes have been saved","SAVED!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void LblCurrentSerNum_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            BarcodeEncoder.Properties.Settings.Default.ConnectionString = txfLocation.Text;
            MessageBox.Show("Successfully Saved");
        }
    }
}
