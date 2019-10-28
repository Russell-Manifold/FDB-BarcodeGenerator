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
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.BackgroundImage = global::BarcodeEncoder.Properties.Resources.link1;
            this.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScan.Location = new System.Drawing.Point(23, 53);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(200, 75);
            this.btnScan.TabIndex = 0;
            this.btnScan.UseSelectable = true;
            this.btnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = global::BarcodeEncoder.Properties.Resources.Packbox;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreate.Location = new System.Drawing.Point(23, 134);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(200, 75);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnNewBarcode
            // 
            this.btnNewBarcode.BackgroundImage = global::BarcodeEncoder.Properties.Resources.barcodetags;
            this.btnNewBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewBarcode.Location = new System.Drawing.Point(23, 215);
            this.btnNewBarcode.Name = "btnNewBarcode";
            this.btnNewBarcode.Size = new System.Drawing.Size(200, 75);
            this.btnNewBarcode.TabIndex = 7;
            this.btnNewBarcode.UseSelectable = true;
            this.btnNewBarcode.Click += new System.EventHandler(this.BtnCreateBarcode_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(103, 315);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(120, 23);
            this.metroLink1.TabIndex = 8;
            this.metroLink1.Text = "Configuration -->";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.MetroLink1_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(252, 347);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.btnNewBarcode);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnScan);
            this.Name = "DashBoard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnScan;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroButton btnNewBarcode;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}