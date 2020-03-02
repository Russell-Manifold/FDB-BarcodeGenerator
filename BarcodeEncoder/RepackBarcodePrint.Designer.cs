namespace BarcodeEncoder
{
    partial class RepackBarcodePrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepackBarcodePrint));
            this.ddLabelSize = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblPrint = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.togBoarder = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ddLabelSize
            // 
            this.ddLabelSize.FormattingEnabled = true;
            this.ddLabelSize.ItemHeight = 23;
            this.ddLabelSize.Location = new System.Drawing.Point(149, 86);
            this.ddLabelSize.Name = "ddLabelSize";
            this.ddLabelSize.Size = new System.Drawing.Size(194, 29);
            this.ddLabelSize.TabIndex = 40;
            this.ddLabelSize.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 90);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 41;
            this.metroLabel4.Text = "Select Label Size: ";
            // 
            // lblPrint
            // 
            this.lblPrint.Location = new System.Drawing.Point(434, 158);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(69, 19);
            this.lblPrint.TabIndex = 45;
            this.lblPrint.Text = "Print Codes";
            this.lblPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = global::BarcodeEncoder.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(450, 121);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(41, 34);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrint.TabIndex = 44;
            this.btnPrint.TabStop = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarcodeEncoder.Properties.Resources.FDBicon1;
            this.pictureBox1.Location = new System.Drawing.Point(436, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "Include Boarder: ";
            // 
            // togBoarder
            // 
            this.togBoarder.AutoSize = true;
            this.togBoarder.Checked = true;
            this.togBoarder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.togBoarder.Location = new System.Drawing.Point(263, 121);
            this.togBoarder.Name = "togBoarder";
            this.togBoarder.Size = new System.Drawing.Size(80, 17);
            this.togBoarder.Style = MetroFramework.MetroColorStyle.Orange;
            this.togBoarder.TabIndex = 47;
            this.togBoarder.Text = "On";
            this.togBoarder.UseSelectable = true;
            // 
            // RepackBarcodePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 188);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.togBoarder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.ddLabelSize);
            this.Controls.Add(this.metroLabel4);
            this.Name = "RepackBarcodePrint";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Print Repacking Barcodes";
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ddLabelSize;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.PictureBox btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle togBoarder;
    }
}