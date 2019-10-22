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
            this.label2 = new System.Windows.Forms.Label();
            this.txfName = new System.Windows.Forms.TextBox();
            this.btnSaveLocation = new MetroFramework.Controls.MetroButton();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbType = new MetroFramework.Controls.MetroComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainCode
            // 
            this.lblMainCode.AutoSize = true;
            this.lblMainCode.Location = new System.Drawing.Point(23, 120);
            this.lblMainCode.Name = "lblMainCode";
            this.lblMainCode.Size = new System.Drawing.Size(48, 19);
            this.lblMainCode.TabIndex = 4;
            this.lblMainCode.Text = "Code: ";
            // 
            // txfMainCode
            // 
            // 
            // 
            // 
            this.txfMainCode.CustomButton.Image = null;
            this.txfMainCode.CustomButton.Location = new System.Drawing.Point(104, 1);
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
            this.txfMainCode.Size = new System.Drawing.Size(126, 23);
            this.txfMainCode.TabIndex = 3;
            this.txfMainCode.UseSelectable = true;
            this.txfMainCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txfMainCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txfMainCode.TextChanged += new System.EventHandler(this.Code_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(128, 334);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 28);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "File Name:";
            // 
            // txfName
            // 
            this.txfName.Location = new System.Drawing.Point(101, 308);
            this.txfName.Name = "txfName";
            this.txfName.Size = new System.Drawing.Size(130, 20);
            this.txfName.TabIndex = 18;
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Location = new System.Drawing.Point(12, 334);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(92, 28);
            this.btnSaveLocation.TabIndex = 17;
            this.btnSaveLocation.Text = "Save File";
            this.btnSaveLocation.UseSelectable = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.direc_Click);
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(23, 145);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(204, 157);
            this.PicBox.TabIndex = 21;
            this.PicBox.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 23;
            this.cmbType.Items.AddRange(new object[] {
            "Name",
            "PO Barcode",
            "PS Barcode"});
            this.cmbType.Location = new System.Drawing.Point(101, 89);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(126, 29);
            this.cmbType.TabIndex = 24;
            this.cmbType.UseSelectable = true;
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
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 381);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txfName);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.lblMainCode);
            this.Controls.Add(this.txfMainCode);
            this.Name = "Create";
            this.Text = "Create Barcodes";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblMainCode;
        private MetroFramework.Controls.MetroTextBox txfMainCode;
        private MetroFramework.Controls.MetroButton btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txfName;
        private MetroFramework.Controls.MetroButton btnSaveLocation;
        private System.Windows.Forms.PictureBox PicBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbType;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}