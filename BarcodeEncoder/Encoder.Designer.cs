namespace BarcodeEncoder
{
    partial class Encoder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encoder));
            this.txfEncoded = new System.Windows.Forms.TextBox();
            this.txfFinalCode = new System.Windows.Forms.TextBox();
            this.txfNumOfItems = new System.Windows.Forms.TextBox();
            this.txfName = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblDesc = new MetroFramework.Controls.MetroLabel();
            this.lblMain = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.btnSaveLocation = new MetroFramework.Controls.MetroButton();
            this.PicBoxFinal = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // txfEncoded
            // 
            this.txfEncoded.Location = new System.Drawing.Point(111, 86);
            this.txfEncoded.MaxLength = 13;
            this.txfEncoded.Name = "txfEncoded";
            this.txfEncoded.Size = new System.Drawing.Size(174, 20);
            this.txfEncoded.TabIndex = 2;
            this.txfEncoded.Leave += new System.EventHandler(this.txfEncoded_TextChanged);
            // 
            // txfFinalCode
            // 
            this.txfFinalCode.Location = new System.Drawing.Point(119, 392);
            this.txfFinalCode.Name = "txfFinalCode";
            this.txfFinalCode.Size = new System.Drawing.Size(191, 20);
            this.txfFinalCode.TabIndex = 8;
            // 
            // txfNumOfItems
            // 
            this.txfNumOfItems.Location = new System.Drawing.Point(111, 171);
            this.txfNumOfItems.Name = "txfNumOfItems";
            this.txfNumOfItems.Size = new System.Drawing.Size(39, 20);
            this.txfNumOfItems.TabIndex = 10;
            this.txfNumOfItems.TextChanged += new System.EventHandler(this.TxfNumOfItems_TextChanged);
            // 
            // txfName
            // 
            this.txfName.Location = new System.Drawing.Point(119, 417);
            this.txfName.Name = "txfName";
            this.txfName.Size = new System.Drawing.Size(191, 20);
            this.txfName.TabIndex = 14;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // btnCreate
            // 
            this.btnCreate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCreate.Location = new System.Drawing.Point(14, 197);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(296, 52);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "CREATE NEW PACK CODE";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
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
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(111, 116);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(199, 52);
            this.lblDesc.TabIndex = 24;
            this.lblDesc.Text = "No Item Description";
            this.lblDesc.WrapToLine = true;
            // 
            // lblMain
            // 
            this.lblMain.Location = new System.Drawing.Point(2, 8);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(215, 46);
            this.lblMain.TabIndex = 26;
            this.lblMain.Text = "Create and Link Packing Barcodes";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(187, 116);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(28, 25);
            this.metroProgressSpinner1.TabIndex = 27;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BackgroundImage = global::BarcodeEncoder.Properties.Resources.refresh;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClear.Location = new System.Drawing.Point(291, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(19, 27);
            this.btnClear.TabIndex = 20;
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::BarcodeEncoder.Properties.Resources.Print;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrint.Location = new System.Drawing.Point(246, 443);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(64, 44);
            this.btnPrint.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.BackgroundImage = global::BarcodeEncoder.Properties.Resources.Save;
            this.btnSaveLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLocation.Location = new System.Drawing.Point(14, 443);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(54, 44);
            this.btnSaveLocation.TabIndex = 12;
            this.btnSaveLocation.UseSelectable = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.direc_Click);
            // 
            // PicBoxFinal
            // 
            this.PicBoxFinal.BackColor = System.Drawing.Color.White;
            this.PicBoxFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBoxFinal.ImageLocation = "";
            this.PicBoxFinal.Location = new System.Drawing.Point(14, 255);
            this.PicBoxFinal.Name = "PicBoxFinal";
            this.PicBoxFinal.Padding = new System.Windows.Forms.Padding(20);
            this.PicBoxFinal.Size = new System.Drawing.Size(296, 130);
            this.PicBoxFinal.TabIndex = 7;
            this.PicBoxFinal.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 393);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Pack Barcode";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 171);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Num of Items:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 116);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Item:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 87);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "EAN Barcode:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 418);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "File name:";
            // 
            // Encoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 495);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txfName);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.txfNumOfItems);
            this.Controls.Add(this.txfFinalCode);
            this.Controls.Add(this.PicBoxFinal);
            this.Controls.Add(this.txfEncoded);
            this.Controls.Add(this.lblDesc);
            this.Name = "Encoder";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txfEncoded;
        private System.Windows.Forms.PictureBox PicBoxFinal;
        private System.Windows.Forms.TextBox txfFinalCode;
        private System.Windows.Forms.TextBox txfNumOfItems;
        private MetroFramework.Controls.MetroButton btnSaveLocation;
        private System.Windows.Forms.TextBox txfName;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroButton btnClear;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MetroFramework.Controls.MetroLabel lblDesc;
        private MetroFramework.Controls.MetroLabel lblMain;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}

