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
            this.txfName = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.togBoarder = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.togValue = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.PictureBox();
            this.btnSaveLocation = new System.Windows.Forms.PictureBox();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.ddLabelSize = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainCode
            // 
            this.lblMainCode.AutoSize = true;
            this.lblMainCode.Location = new System.Drawing.Point(53, 110);
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
            this.txfMainCode.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txfMainCode.CustomButton.Name = "";
            this.txfMainCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txfMainCode.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.txfMainCode.CustomButton.TabIndex = 1;
            this.txfMainCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txfMainCode.CustomButton.UseSelectable = true;
            this.txfMainCode.CustomButton.Visible = false;
            this.txfMainCode.Lines = new string[0];
            this.txfMainCode.Location = new System.Drawing.Point(168, 109);
            this.txfMainCode.MaxLength = 14;
            this.txfMainCode.Name = "txfMainCode";
            this.txfMainCode.PasswordChar = '\0';
            this.txfMainCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txfMainCode.SelectedText = "";
            this.txfMainCode.SelectionLength = 0;
            this.txfMainCode.SelectionStart = 0;
            this.txfMainCode.ShortcutsEnabled = true;
            this.txfMainCode.Size = new System.Drawing.Size(195, 23);
            this.txfMainCode.TabIndex = 1;
            this.txfMainCode.UseSelectable = true;
            this.txfMainCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txfMainCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txfMainCode.TextChanged += new System.EventHandler(this.Code_TextChanged);
            // 
            // txfName
            // 
            this.txfName.Location = new System.Drawing.Point(169, 404);
            this.txfName.Name = "txfName";
            this.txfName.Size = new System.Drawing.Size(196, 20);
            this.txfName.TabIndex = 18;
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 404);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Save As File Name: ";
            // 
            // togBoarder
            // 
            this.togBoarder.AutoSize = true;
            this.togBoarder.Checked = true;
            this.togBoarder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.togBoarder.Location = new System.Drawing.Point(283, 166);
            this.togBoarder.Name = "togBoarder";
            this.togBoarder.Size = new System.Drawing.Size(80, 17);
            this.togBoarder.Style = MetroFramework.MetroColorStyle.Orange;
            this.togBoarder.TabIndex = 26;
            this.togBoarder.Text = "On";
            this.togBoarder.UseSelectable = true;
            this.togBoarder.CheckedChanged += new System.EventHandler(this.togBoarder_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 166);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Include Boarder: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(53, 194);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Print Value: ";
            // 
            // togValue
            // 
            this.togValue.AutoSize = true;
            this.togValue.Checked = true;
            this.togValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.togValue.Location = new System.Drawing.Point(283, 194);
            this.togValue.Name = "togValue";
            this.togValue.Size = new System.Drawing.Size(80, 17);
            this.togValue.Style = MetroFramework.MetroColorStyle.Orange;
            this.togValue.TabIndex = 28;
            this.togValue.Text = "On";
            this.togValue.UseSelectable = true;
            this.togValue.CheckedChanged += new System.EventHandler(this.togValue_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(53, 138);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 19);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "Hide Characters:";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(283, 138);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToggle1.TabIndex = 32;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(36, 511);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Save ";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(363, 511);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(36, 19);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "Print";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::BarcodeEncoder.Properties.Resources.barcodetagsSmall;
            this.pictureBox1.Location = new System.Drawing.Point(188, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = global::BarcodeEncoder.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(350, 458);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(66, 50);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrint.TabIndex = 36;
            this.btnPrint.TabStop = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLocation.Image = global::BarcodeEncoder.Properties.Resources.Save;
            this.btnSaveLocation.Location = new System.Drawing.Point(23, 458);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(66, 50);
            this.btnSaveLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSaveLocation.TabIndex = 34;
            this.btnSaveLocation.TabStop = false;
            this.btnSaveLocation.Click += new System.EventHandler(this.direc_Click);
            // 
            // PicBox
            // 
            this.PicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBox.Location = new System.Drawing.Point(23, 228);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(393, 157);
            this.PicBox.TabIndex = 21;
            this.PicBox.TabStop = false;
            // 
            // ddLabelSize
            // 
            this.ddLabelSize.FormattingEnabled = true;
            this.ddLabelSize.ItemHeight = 23;
            this.ddLabelSize.Location = new System.Drawing.Point(169, 74);
            this.ddLabelSize.Name = "ddLabelSize";
            this.ddLabelSize.Size = new System.Drawing.Size(194, 29);
            this.ddLabelSize.TabIndex = 0;
            this.ddLabelSize.UseSelectable = true;
            this.ddLabelSize.SelectedIndexChanged += new System.EventHandler(this.ddLabelSize_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(51, 78);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 39;
            this.metroLabel4.Text = "Select Label Size: ";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 542);
            this.Controls.Add(this.ddLabelSize);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.togValue);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.togBoarder);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.txfName);
            this.Controls.Add(this.lblMainCode);
            this.Controls.Add(this.txfMainCode);
            this.Name = "Create";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Create Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblMainCode;
        private MetroFramework.Controls.MetroTextBox txfMainCode;
        private System.Windows.Forms.TextBox txfName;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle togBoarder;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle togValue;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.PictureBox btnSaveLocation;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox btnPrint;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox ddLabelSize;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}