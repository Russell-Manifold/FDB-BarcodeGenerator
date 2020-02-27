namespace BarcodeEncoder
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.btnScan = new MetroFramework.Controls.MetroButton();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.btnNewBarcode = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.btnPickSlipsList = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.BackgroundImage = global::BarcodeEncoder.Properties.Resources.link;
            this.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.Enabled = false;
            this.btnScan.Location = new System.Drawing.Point(133, 326);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(200, 75);
            this.btnScan.TabIndex = 2;
            this.btnScan.UseSelectable = true;
            this.btnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = global::BarcodeEncoder.Properties.Resources.Packbox1;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(133, 407);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(200, 75);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnNewBarcode
            // 
            this.btnNewBarcode.BackgroundImage = global::BarcodeEncoder.Properties.Resources.newbarcode;
            this.btnNewBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewBarcode.Enabled = false;
            this.btnNewBarcode.Location = new System.Drawing.Point(133, 245);
            this.btnNewBarcode.Name = "btnNewBarcode";
            this.btnNewBarcode.Size = new System.Drawing.Size(200, 75);
            this.btnNewBarcode.TabIndex = 1;
            this.btnNewBarcode.UseSelectable = true;
            this.btnNewBarcode.Click += new System.EventHandler(this.BtnCreateBarcode_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.Location = new System.Drawing.Point(320, 670);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(120, 23);
            this.metroLink1.TabIndex = 8;
            this.metroLink1.Text = "Configuration -->";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Visible = false;
            this.metroLink1.Click += new System.EventHandler(this.MetroLink1_Click);
            // 
            // btnPickSlipsList
            // 
            this.btnPickSlipsList.BackColor = System.Drawing.Color.Transparent;
            this.btnPickSlipsList.BackgroundImage = global::BarcodeEncoder.Properties.Resources.pickslip1;
            this.btnPickSlipsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPickSlipsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickSlipsList.Enabled = false;
            this.btnPickSlipsList.Location = new System.Drawing.Point(133, 164);
            this.btnPickSlipsList.Name = "btnPickSlipsList";
            this.btnPickSlipsList.Size = new System.Drawing.Size(200, 75);
            this.btnPickSlipsList.TabIndex = 0;
            this.btnPickSlipsList.UseSelectable = true;
            this.btnPickSlipsList.Click += new System.EventHandler(this.btnPickSlipsList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarcodeEncoder.Properties.Resources.FDBicon1;
            this.pictureBox1.Location = new System.Drawing.Point(350, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BarcodeEncoder.Properties.Resources.MainIconLogin;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(10, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 131);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::BarcodeEncoder.Properties.Resources.InvCount2;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Enabled = false;
            this.metroButton1.Location = new System.Drawing.Point(133, 490);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(200, 75);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::BarcodeEncoder.Properties.Resources.WIP1;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.Enabled = false;
            this.metroButton2.Location = new System.Drawing.Point(133, 571);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(200, 75);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(139, 134);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 19);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "metroLabel1";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(446, 706);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPickSlipsList);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.btnNewBarcode);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnScan);
            this.Name = "DashBoard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnScan;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroButton btnNewBarcode;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton btnPickSlipsList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel lblUserName;
    }
}