namespace BarcodeEncoder
{
    partial class JobTitleSetUp
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CMBXJobTitles = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnJobTitleAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnJobTitleAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(74, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select a Job Title";
            // 
            // CMBXJobTitles
            // 
            this.CMBXJobTitles.FormattingEnabled = true;
            this.CMBXJobTitles.ItemHeight = 23;
            this.CMBXJobTitles.Location = new System.Drawing.Point(189, 103);
            this.CMBXJobTitles.Name = "CMBXJobTitles";
            this.CMBXJobTitles.Size = new System.Drawing.Size(235, 29);
            this.CMBXJobTitles.TabIndex = 2;
            this.CMBXJobTitles.UseSelectable = true;
            this.CMBXJobTitles.SelectedIndexChanged += new System.EventHandler(this.CMBXJobTitles_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(173, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 15);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Add New";
            // 
            // btnJobTitleAdd
            // 
            this.btnJobTitleAdd.BackgroundImage = global::BarcodeEncoder.Properties.Resources.PalletAdd;
            this.btnJobTitleAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJobTitleAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJobTitleAdd.Location = new System.Drawing.Point(187, 24);
            this.btnJobTitleAdd.Name = "btnJobTitleAdd";
            this.btnJobTitleAdd.Size = new System.Drawing.Size(30, 30);
            this.btnJobTitleAdd.TabIndex = 4;
            this.btnJobTitleAdd.TabStop = false;
            this.btnJobTitleAdd.Click += new System.EventHandler(this.btnJobTitleAdd_Click);
            // 
            // JobTitleSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 174);
            this.Controls.Add(this.btnJobTitleAdd);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.CMBXJobTitles);
            this.Controls.Add(this.metroLabel1);
            this.Name = "JobTitleSetUp";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Job Title SetUp";
            this.Activated += new System.EventHandler(this.JobTitleSetUp_Activated);
            this.Load += new System.EventHandler(this.JobTitleSetUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnJobTitleAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox CMBXJobTitles;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox btnJobTitleAdd;
    }
}