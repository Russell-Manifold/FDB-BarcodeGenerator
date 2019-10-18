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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(23, 53);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(200, 75);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Link";
            this.btnScan.UseSelectable = true;
            this.btnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(23, 134);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(200, 75);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create ITF";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 215);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(200, 75);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Create Barcode";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.BtnCreateBarcode_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnScan);
            this.Name = "DashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnScan;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}