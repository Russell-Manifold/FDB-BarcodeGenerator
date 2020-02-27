namespace BarcodeEncoder
{
    partial class Link
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
            this.lblMainCode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txfQty = new MetroFramework.Controls.MetroTextBox();
            this.lblMainDesc = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblDesc = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txfItemCode = new System.Windows.Forms.TextBox();
            this.txfMainCode = new System.Windows.Forms.TextBox();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainCode
            // 
            this.lblMainCode.AutoSize = true;
            this.lblMainCode.Location = new System.Drawing.Point(56, 217);
            this.lblMainCode.Name = "lblMainCode";
            this.lblMainCode.Size = new System.Drawing.Size(91, 19);
            this.lblMainCode.TabIndex = 2;
            this.lblMainCode.Text = "Pack Barcode:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(56, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "EAN Barcode:";
            // 
            // txfQty
            // 
            // 
            // 
            // 
            this.txfQty.CustomButton.Image = null;
            this.txfQty.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.txfQty.CustomButton.Name = "";
            this.txfQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txfQty.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.txfQty.CustomButton.TabIndex = 1;
            this.txfQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txfQty.CustomButton.UseSelectable = true;
            this.txfQty.CustomButton.Visible = false;
            this.txfQty.Lines = new string[] {
        "0"};
            this.txfQty.Location = new System.Drawing.Point(147, 177);
            this.txfQty.MaxLength = 32767;
            this.txfQty.Name = "txfQty";
            this.txfQty.PasswordChar = '\0';
            this.txfQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txfQty.SelectedText = "";
            this.txfQty.SelectionLength = 0;
            this.txfQty.SelectionStart = 0;
            this.txfQty.ShortcutsEnabled = true;
            this.txfQty.Size = new System.Drawing.Size(36, 23);
            this.txfQty.TabIndex = 6;
            this.txfQty.Text = "0";
            this.txfQty.UseSelectable = true;
            this.txfQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txfQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMainDesc
            // 
            this.lblMainDesc.AutoSize = true;
            this.lblMainDesc.Location = new System.Drawing.Point(188, 161);
            this.lblMainDesc.Name = "lblMainDesc";
            this.lblMainDesc.Size = new System.Drawing.Size(0, 0);
            this.lblMainDesc.TabIndex = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(56, 181);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Qty:";
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(147, 107);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(149, 54);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.WrapToLine = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(56, 125);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Description:";
            // 
            // txfItemCode
            // 
            this.txfItemCode.Location = new System.Drawing.Point(147, 83);
            this.txfItemCode.MaxLength = 13;
            this.txfItemCode.Name = "txfItemCode";
            this.txfItemCode.Size = new System.Drawing.Size(151, 20);
            this.txfItemCode.TabIndex = 12;
            this.txfItemCode.Leave += new System.EventHandler(this.txfItemCode_TextChanged);
            // 
            // txfMainCode
            // 
            this.txfMainCode.Location = new System.Drawing.Point(147, 217);
            this.txfMainCode.MaxLength = 14;
            this.txfMainCode.Name = "txfMainCode";
            this.txfMainCode.Size = new System.Drawing.Size(172, 20);
            this.txfMainCode.TabIndex = 13;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(205, 125);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(16, 16);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressSpinner1.TabIndex = 15;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(253, 330);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 37;
            this.metroLabel6.Text = "Save Link";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::BarcodeEncoder.Properties.Resources.Save;
            this.btnAdd.Location = new System.Drawing.Point(253, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 50);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 36;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::BarcodeEncoder.Properties.Resources.linkSmall;
            this.pictureBox1.Location = new System.Drawing.Point(174, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Image = global::BarcodeEncoder.Properties.Resources.refresh;
            this.btnClear.Location = new System.Drawing.Point(301, 79);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(28, 28);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClear.TabIndex = 44;
            this.btnClear.TabStop = false;
            // 
            // Link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 366);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.txfMainCode);
            this.Controls.Add(this.txfItemCode);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblMainDesc);
            this.Controls.Add(this.txfQty);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblMainCode);
            this.Controls.Add(this.lblDesc);
            this.Name = "Link";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Link Barcodes";
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblMainCode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txfQty;
        private MetroFramework.Controls.MetroLabel lblMainDesc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblDesc;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txfItemCode;
        private System.Windows.Forms.TextBox txfMainCode;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnClear;
    }
}