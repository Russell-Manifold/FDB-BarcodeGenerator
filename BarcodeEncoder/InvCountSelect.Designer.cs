namespace BarcodeEncoder
{
    partial class InvCountSelect
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
            this.gridCountHeader = new System.Windows.Forms.DataGridView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCountHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCountHeader
            // 
            this.gridCountHeader.AllowUserToAddRows = false;
            this.gridCountHeader.AllowUserToDeleteRows = false;
            this.gridCountHeader.AllowUserToResizeColumns = false;
            this.gridCountHeader.AllowUserToResizeRows = false;
            this.gridCountHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCountHeader.Location = new System.Drawing.Point(23, 143);
            this.gridCountHeader.Name = "gridCountHeader";
            this.gridCountHeader.Size = new System.Drawing.Size(418, 228);
            this.gridCountHeader.TabIndex = 0;
            this.gridCountHeader.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCountHeader_CellDoubleClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(159, 70);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(144, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Open Inventory Counts";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BarcodeEncoder.Properties.Resources.FDBicon1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(366, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 60);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BarcodeEncoder.Properties.Resources.PalletAdd;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(406, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(301, 116);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 15);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Create New Count";
            // 
            // InvCountSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 397);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.gridCountHeader);
            this.Name = "InvCountSelect";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Inventory Count Master";
            this.Activated += new System.EventHandler(this.InvCountSelect_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridCountHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCountHeader;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}