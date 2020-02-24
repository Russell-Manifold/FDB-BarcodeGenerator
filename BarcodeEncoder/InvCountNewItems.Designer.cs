namespace BarcodeEncoder
{
    partial class InvCountNewItems
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMBXFilterBy = new MetroFramework.Controls.MetroComboBox();
            this.txfFilterText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 553);
            this.dataGridView1.TabIndex = 0;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(607, 33);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(124, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Save Selected Items";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BarcodeEncoder.Properties.Resources.Save;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(737, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 29);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CMBXFilterBy
            // 
            this.CMBXFilterBy.FormattingEnabled = true;
            this.CMBXFilterBy.ItemHeight = 23;
            this.CMBXFilterBy.Items.AddRange(new object[] {
            "Description",
            "Category",
            "Item Code",
            "BarCode",
            "On Hand Qty"});
            this.CMBXFilterBy.Location = new System.Drawing.Point(106, 63);
            this.CMBXFilterBy.Name = "CMBXFilterBy";
            this.CMBXFilterBy.Size = new System.Drawing.Size(121, 29);
            this.CMBXFilterBy.TabIndex = 8;
            this.CMBXFilterBy.UseSelectable = true;
            // 
            // txfFilterText
            // 
            // 
            // 
            // 
            this.txfFilterText.CustomButton.Image = null;
            this.txfFilterText.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txfFilterText.CustomButton.Name = "";
            this.txfFilterText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txfFilterText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txfFilterText.CustomButton.TabIndex = 1;
            this.txfFilterText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txfFilterText.CustomButton.UseSelectable = true;
            this.txfFilterText.CustomButton.Visible = false;
            this.txfFilterText.Lines = new string[0];
            this.txfFilterText.Location = new System.Drawing.Point(233, 69);
            this.txfFilterText.MaxLength = 32767;
            this.txfFilterText.Name = "txfFilterText";
            this.txfFilterText.PasswordChar = '\0';
            this.txfFilterText.PromptText = "-Search By-";
            this.txfFilterText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txfFilterText.SelectedText = "";
            this.txfFilterText.SelectionLength = 0;
            this.txfFilterText.SelectionStart = 0;
            this.txfFilterText.ShortcutsEnabled = true;
            this.txfFilterText.ShowClearButton = true;
            this.txfFilterText.Size = new System.Drawing.Size(118, 23);
            this.txfFilterText.TabIndex = 9;
            this.txfFilterText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txfFilterText.UseSelectable = true;
            this.txfFilterText.WaterMark = "-Search By-";
            this.txfFilterText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txfFilterText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txfFilterText.TextChanged += new System.EventHandler(this.txfFilterText_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Filter By:";
            // 
            // InvCountNewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txfFilterText);
            this.Controls.Add(this.CMBXFilterBy);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InvCountNewItems";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Select Items for Inventory Count";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox CMBXFilterBy;
        private MetroFramework.Controls.MetroTextBox txfFilterText;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}