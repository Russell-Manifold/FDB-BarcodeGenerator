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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CMBXJobTitles = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.BackgroundImage = global::BarcodeEncoder.Properties.Resources.PalletAdd;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.metroButton1.Location = new System.Drawing.Point(598, 29);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(62, 58);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(155, 205);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select a Job Title";
            // 
            // CMBXJobTitles
            // 
            this.CMBXJobTitles.FormattingEnabled = true;
            this.CMBXJobTitles.ItemHeight = 23;
            this.CMBXJobTitles.Location = new System.Drawing.Point(293, 195);
            this.CMBXJobTitles.Name = "CMBXJobTitles";
            this.CMBXJobTitles.Size = new System.Drawing.Size(121, 29);
            this.CMBXJobTitles.TabIndex = 2;
            this.CMBXJobTitles.UseSelectable = true;
            this.CMBXJobTitles.SelectedIndexChanged += new System.EventHandler(this.CMBXJobTitles_SelectedIndexChanged);
            // 
            // JobTitleSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.CMBXJobTitles);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Name = "JobTitleSetUp";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Job Title SetUp";
            this.Activated += new System.EventHandler(this.JobTitleSetUp_Activated);
            this.Load += new System.EventHandler(this.JobTitleSetUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox CMBXJobTitles;
    }
}