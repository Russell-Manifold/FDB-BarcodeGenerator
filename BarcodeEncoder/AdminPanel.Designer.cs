namespace BarcodeEncoder
{
    partial class AdminPanel
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
            this.btnLocation = new MetroFramework.Controls.MetroButton();
            this.lblAPI = new MetroFramework.Controls.MetroLabel();
            this.txfApi = new MetroFramework.Controls.MetroTextBox();
            this.txfLocation = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(106, 138);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(121, 29);
            this.btnLocation.TabIndex = 3;
            this.btnLocation.Text = "Select Database";
            this.btnLocation.UseSelectable = true;
            this.btnLocation.Click += new System.EventHandler(this.BtnLocation_Click);
            // 
            // lblAPI
            // 
            this.lblAPI.AutoSize = true;
            this.lblAPI.Location = new System.Drawing.Point(14, 84);
            this.lblAPI.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.lblAPI.Name = "lblAPI";
            this.lblAPI.Size = new System.Drawing.Size(61, 19);
            this.lblAPI.TabIndex = 7;
            this.lblAPI.Text = "API Path:";
            // 
            // txfApi
            // 
            // 
            // 
            // 
            this.txfApi.CustomButton.Image = null;
            this.txfApi.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txfApi.CustomButton.Name = "";
            this.txfApi.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txfApi.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.txfApi.CustomButton.TabIndex = 1;
            this.txfApi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txfApi.CustomButton.UseSelectable = true;
            this.txfApi.CustomButton.Visible = false;
            this.txfApi.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BarcodeEncoder.Properties.Settings.Default, "API", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txfApi.Lines = new string[] {
        "http://localhost:7721/api/"};
            this.txfApi.Location = new System.Drawing.Point(97, 81);
            this.txfApi.MaxLength = 32767;
            this.txfApi.Name = "txfApi";
            this.txfApi.PasswordChar = '\0';
            this.txfApi.PromptText = "http://localhost:7721//api/";
            this.txfApi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txfApi.SelectedText = "";
            this.txfApi.SelectionLength = 0;
            this.txfApi.SelectionStart = 0;
            this.txfApi.ShortcutsEnabled = true;
            this.txfApi.Size = new System.Drawing.Size(255, 25);
            this.txfApi.TabIndex = 8;
            this.txfApi.Text = global::BarcodeEncoder.Properties.Settings.Default.API;
            this.txfApi.UseSelectable = true;
            this.txfApi.WaterMark = "http://localhost:7721//api/";
            this.txfApi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txfApi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txfLocation
            // 
            // 
            // 
            // 
            this.txfLocation.CustomButton.Image = null;
            this.txfLocation.CustomButton.Location = new System.Drawing.Point(316, 1);
            this.txfLocation.CustomButton.Name = "";
            this.txfLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txfLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.txfLocation.CustomButton.TabIndex = 1;
            this.txfLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txfLocation.CustomButton.UseSelectable = true;
            this.txfLocation.CustomButton.Visible = false;
            this.txfLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BarcodeEncoder.Properties.Settings.Default, "ConnectionString", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txfLocation.Lines = new string[] {
        "C:\\Users\\Russell - Manifold\\Desktop\\FDB2020"};
            this.txfLocation.Location = new System.Drawing.Point(14, 173);
            this.txfLocation.MaxLength = 32767;
            this.txfLocation.Name = "txfLocation";
            this.txfLocation.PasswordChar = '\0';
            this.txfLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txfLocation.SelectedText = "";
            this.txfLocation.SelectionLength = 0;
            this.txfLocation.SelectionStart = 0;
            this.txfLocation.ShortcutsEnabled = true;
            this.txfLocation.Size = new System.Drawing.Size(338, 23);
            this.txfLocation.TabIndex = 2;
            this.txfLocation.Text = global::BarcodeEncoder.Properties.Settings.Default.ConnectionString;
            this.txfLocation.UseSelectable = true;
            this.txfLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txfLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::BarcodeEncoder.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(315, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(37, 32);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 9;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 448);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txfApi);
            this.Controls.Add(this.lblAPI);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.txfLocation);
            this.Name = "AdminPanel";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Configuration Settings";
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txfLocation;
        private MetroFramework.Controls.MetroButton btnLocation;
        private MetroFramework.Controls.MetroLabel lblAPI;
        private MetroFramework.Controls.MetroTextBox txfApi;
        private System.Windows.Forms.PictureBox btnSave;
    }
}