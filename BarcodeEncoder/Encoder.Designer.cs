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
            this.PicBoxFinal = new System.Windows.Forms.PictureBox();
            this.txfFinalCode = new System.Windows.Forms.TextBox();
            this.txfNumOfItems = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveLocation = new MetroFramework.Controls.MetroButton();
            this.txfName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDesc = new MetroFramework.Controls.MetroLabel();
            this.SpinnerLoading = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblMain = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // txfEncoded
            // 
            this.txfEncoded.Location = new System.Drawing.Point(134, 86);
            this.txfEncoded.MaxLength = 13;
            this.txfEncoded.Name = "txfEncoded";
            this.txfEncoded.Size = new System.Drawing.Size(130, 20);
            this.txfEncoded.TabIndex = 2;
            this.txfEncoded.TextChanged += new System.EventHandler(this.txfEncoded_TextChanged);
            // 
            // PicBoxFinal
            // 
            this.PicBoxFinal.BackColor = System.Drawing.Color.White;
            this.PicBoxFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBoxFinal.ImageLocation = "";
            this.PicBoxFinal.Location = new System.Drawing.Point(23, 255);
            this.PicBoxFinal.Name = "PicBoxFinal";
            this.PicBoxFinal.Padding = new System.Windows.Forms.Padding(20);
            this.PicBoxFinal.Size = new System.Drawing.Size(241, 130);
            this.PicBoxFinal.TabIndex = 7;
            this.PicBoxFinal.TabStop = false;
            // 
            // txfFinalCode
            // 
            this.txfFinalCode.Location = new System.Drawing.Point(134, 391);
            this.txfFinalCode.Name = "txfFinalCode";
            this.txfFinalCode.Size = new System.Drawing.Size(130, 20);
            this.txfFinalCode.TabIndex = 8;
            // 
            // txfNumOfItems
            // 
            this.txfNumOfItems.Location = new System.Drawing.Point(134, 171);
            this.txfNumOfItems.Name = "txfNumOfItems";
            this.txfNumOfItems.Size = new System.Drawing.Size(39, 20);
            this.txfNumOfItems.TabIndex = 10;
            this.txfNumOfItems.TextChanged += new System.EventHandler(this.TxfNumOfItems_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of items:";
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Location = new System.Drawing.Point(23, 459);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(92, 28);
            this.btnSaveLocation.TabIndex = 12;
            this.btnSaveLocation.Text = "Save File";
            this.btnSaveLocation.UseSelectable = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.direc_Click);
            // 
            // txfName
            // 
            this.txfName.Location = new System.Drawing.Point(134, 417);
            this.txfName.Name = "txfName";
            this.txfName.Size = new System.Drawing.Size(130, 20);
            this.txfName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "File Name:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(161, 459);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 28);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(20, 57);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(23, 197);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(241, 52);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(189, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "EAN Barcode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "FDB Code:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Description:";
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(134, 109);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(130, 59);
            this.lblDesc.TabIndex = 24;
            this.lblDesc.Text = "No Item Description";
            this.lblDesc.WrapToLine = true;
            // 
            // SpinnerLoading
            // 
            this.SpinnerLoading.Location = new System.Drawing.Point(270, 86);
            this.SpinnerLoading.Maximum = 100;
            this.SpinnerLoading.Name = "SpinnerLoading";
            this.SpinnerLoading.Size = new System.Drawing.Size(19, 20);
            this.SpinnerLoading.TabIndex = 25;
            this.SpinnerLoading.UseSelectable = true;
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
            // Encoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 495);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.SpinnerLoading);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txfName);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txfNumOfItems);
            this.Controls.Add(this.txfFinalCode);
            this.Controls.Add(this.PicBoxFinal);
            this.Controls.Add(this.txfEncoded);
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
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnSaveLocation;
        private System.Windows.Forms.TextBox txfName;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroButton btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroLabel lblDesc;
        private MetroFramework.Controls.MetroProgressSpinner SpinnerLoading;
        private MetroFramework.Controls.MetroLabel lblMain;
    }
}

