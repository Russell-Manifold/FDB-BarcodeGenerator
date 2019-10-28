namespace BarcodeEncoder
{
    partial class Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.lblMainCode = new MetroFramework.Controls.MetroLabel();
            this.txfMainCode = new MetroFramework.Controls.MetroTextBox();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.txfName = new System.Windows.Forms.TextBox();
            this.btnSaveLocation = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbType = new MetroFramework.Controls.MetroComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainCode
            // 
            this.lblMainCode.AutoSize = true;
            this.lblMainCode.Location = new System.Drawing.Point(5, 120);
            this.lblMainCode.Name = "lblMainCode";
            this.lblMainCode.Size = new System.Drawing.Size(82, 19);
            this.lblMainCode.TabIndex = 4;
            this.lblMainCode.Text = "Enter Code: ";
            // 
            // txfMainCode
            // 
            // 
            // 
            // 
            this.txfMainCode.CustomButton.Image = null;
            this.txfMainCode.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txfMainCode.CustomButton.Name = "";
            this.txfMainCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txfMainCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txfMainCode.CustomButton.TabIndex = 1;
            this.txfMainCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txfMainCode.CustomButton.UseSelectable = true;
            this.txfMainCode.CustomButton.Visible = false;
            this.txfMainCode.Lines = new string[0];
            this.txfMainCode.Location = new System.Drawing.Point(101, 119);
            this.txfMainCode.MaxLength = 12;
            this.txfMainCode.Name = "txfMainCode";
            this.txfMainCode.PasswordChar = '\0';
            this.txfMainCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txfMainCode.SelectedText = "";
            this.txfMainCode.SelectionLength = 0;
            this.txfMainCode.SelectionStart = 0;
            this.txfMainCode.ShortcutsEnabled = true;
            this.txfMainCode.Size = new System.Drawing.Size(174, 23);
            this.txfMainCode.TabIndex = 3;
            this.txfMainCode.UseSelectable = true;
            this.txfMainCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txfMainCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txfMainCode.TextChanged += new System.EventHandler(this.Code_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::BarcodeEncoder.Properties.Resources.Print;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.Location = new System.Drawing.Point(219, 334);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(56, 42);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // txfName
            // 
            this.txfName.Location = new System.Drawing.Point(101, 308);
            this.txfName.Name = "txfName";
            this.txfName.Size = new System.Drawing.Size(174, 20);
            this.txfName.TabIndex = 18;
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.BackgroundImage = global::BarcodeEncoder.Properties.Resources.Save;
            this.btnSaveLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveLocation.Location = new System.Drawing.Point(23, 334);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(59, 42);
            this.btnSaveLocation.TabIndex = 17;
            this.btnSaveLocation.UseSelectable = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.direc_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Barcode Type:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 23;
            this.cmbType.Items.AddRange(new object[] {
            "Select Type",
            "Name",
            "PO Barcode",
            "PS Barcode"});
            this.cmbType.Location = new System.Drawing.Point(101, 89);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(174, 29);
            this.cmbType.TabIndex = 0;
            this.cmbType.UseSelectable = true;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbIndexChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(101, 145);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(174, 157);
            this.PicBox.TabIndex = 21;
            this.PicBox.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 308);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "File Name: ";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 381);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txfName);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.lblMainCode);
            this.Controls.Add(this.txfMainCode);
            this.Name = "Create";
            this.Text = "Create Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblMainCode;
        private MetroFramework.Controls.MetroTextBox txfMainCode;
        private MetroFramework.Controls.MetroButton btnPrint;
        private System.Windows.Forms.TextBox txfName;
        private MetroFramework.Controls.MetroButton btnSaveLocation;
        private System.Windows.Forms.PictureBox PicBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbType;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}