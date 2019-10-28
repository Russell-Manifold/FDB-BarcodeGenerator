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
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.lblCurrentSerNum = new MetroFramework.Controls.MetroLabel();
            this.lblCurrentAuthCode = new MetroFramework.Controls.MetroLabel();
            this.lblAPI = new MetroFramework.Controls.MetroLabel();
            this.txfApi = new MetroFramework.Controls.MetroTextBox();
            this.txfLocation = new MetroFramework.Controls.MetroTextBox();
            this.txfAuthCode = new MetroFramework.Controls.MetroTextBox();
            this.txfSerNum = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(14, 219);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(121, 29);
            this.btnLocation.TabIndex = 3;
            this.btnLocation.Text = "Select Database";
            this.btnLocation.UseSelectable = true;
            this.btnLocation.Click += new System.EventHandler(this.BtnLocation_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BarcodeEncoder.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(97, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblCurrentSerNum
            // 
            this.lblCurrentSerNum.AutoSize = true;
            this.lblCurrentSerNum.Location = new System.Drawing.Point(14, 69);
            this.lblCurrentSerNum.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.lblCurrentSerNum.Name = "lblCurrentSerNum";
            this.lblCurrentSerNum.Size = new System.Drawing.Size(77, 19);
            this.lblCurrentSerNum.TabIndex = 5;
            this.lblCurrentSerNum.Text = "Serial Num:";
            this.lblCurrentSerNum.Click += new System.EventHandler(this.LblCurrentSerNum_Click);
            // 
            // lblCurrentAuthCode
            // 
            this.lblCurrentAuthCode.AutoSize = true;
            this.lblCurrentAuthCode.Location = new System.Drawing.Point(14, 118);
            this.lblCurrentAuthCode.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.lblCurrentAuthCode.Name = "lblCurrentAuthCode";
            this.lblCurrentAuthCode.Size = new System.Drawing.Size(75, 19);
            this.lblCurrentAuthCode.TabIndex = 6;
            this.lblCurrentAuthCode.Text = "Auth Code:";
            // 
            // lblAPI
            // 
            this.lblAPI.AutoSize = true;
            this.lblAPI.Location = new System.Drawing.Point(14, 167);
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
            this.txfApi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txfApi.CustomButton.TabIndex = 1;
            this.txfApi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txfApi.CustomButton.UseSelectable = true;
            this.txfApi.CustomButton.Visible = false;
            this.txfApi.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BarcodeEncoder.Properties.Settings.Default, "API", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txfApi.Lines = new string[] {
        "http://localhost:7721//api/"};
            this.txfApi.Location = new System.Drawing.Point(97, 161);
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
            this.txfLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txfLocation.CustomButton.TabIndex = 1;
            this.txfLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txfLocation.CustomButton.UseSelectable = true;
            this.txfLocation.CustomButton.Visible = false;
            this.txfLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BarcodeEncoder.Properties.Settings.Default, "ConnectionString", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txfLocation.Lines = new string[] {
        "C:\\Users\\Russell - Manifold\\Desktop\\FDB2020"};
            this.txfLocation.Location = new System.Drawing.Point(14, 264);
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
            // txfAuthCode
            // 
            // 
            // 
            // 
            this.txfAuthCode.CustomButton.Image = null;
            this.txfAuthCode.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txfAuthCode.CustomButton.Name = "";
            this.txfAuthCode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txfAuthCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txfAuthCode.CustomButton.TabIndex = 1;
            this.txfAuthCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txfAuthCode.CustomButton.UseSelectable = true;
            this.txfAuthCode.CustomButton.Visible = false;
            this.txfAuthCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BarcodeEncoder.Properties.Settings.Default, "Auth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txfAuthCode.Lines = new string[] {
        "5635796"};
            this.txfAuthCode.Location = new System.Drawing.Point(97, 112);
            this.txfAuthCode.MaxLength = 32767;
            this.txfAuthCode.Name = "txfAuthCode";
            this.txfAuthCode.PasswordChar = '\0';
            this.txfAuthCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txfAuthCode.SelectedText = "";
            this.txfAuthCode.SelectionLength = 0;
            this.txfAuthCode.SelectionStart = 0;
            this.txfAuthCode.ShortcutsEnabled = true;
            this.txfAuthCode.Size = new System.Drawing.Size(255, 25);
            this.txfAuthCode.TabIndex = 1;
            this.txfAuthCode.Text = global::BarcodeEncoder.Properties.Settings.Default.Auth;
            this.txfAuthCode.UseSelectable = true;
            this.txfAuthCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txfAuthCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txfSerNum
            // 
            // 
            // 
            // 
            this.txfSerNum.CustomButton.Image = null;
            this.txfSerNum.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txfSerNum.CustomButton.Name = "";
            this.txfSerNum.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txfSerNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txfSerNum.CustomButton.TabIndex = 1;
            this.txfSerNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txfSerNum.CustomButton.UseSelectable = true;
            this.txfSerNum.CustomButton.Visible = false;
            this.txfSerNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BarcodeEncoder.Properties.Settings.Default, "SerNum", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txfSerNum.Lines = new string[] {
        "DK198110007"};
            this.txfSerNum.Location = new System.Drawing.Point(97, 63);
            this.txfSerNum.MaxLength = 32767;
            this.txfSerNum.Name = "txfSerNum";
            this.txfSerNum.PasswordChar = '\0';
            this.txfSerNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txfSerNum.SelectedText = "";
            this.txfSerNum.SelectionLength = 0;
            this.txfSerNum.SelectionStart = 0;
            this.txfSerNum.ShortcutsEnabled = true;
            this.txfSerNum.Size = new System.Drawing.Size(255, 25);
            this.txfSerNum.TabIndex = 0;
            this.txfSerNum.Text = global::BarcodeEncoder.Properties.Settings.Default.SerNum;
            this.txfSerNum.UseSelectable = true;
            this.txfSerNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txfSerNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 351);
            this.Controls.Add(this.txfApi);
            this.Controls.Add(this.lblAPI);
            this.Controls.Add(this.lblCurrentAuthCode);
            this.Controls.Add(this.lblCurrentSerNum);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.txfLocation);
            this.Controls.Add(this.txfAuthCode);
            this.Controls.Add(this.txfSerNum);
            this.Name = "AdminPanel";
            this.Text = "Configuration Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txfSerNum;
        private MetroFramework.Controls.MetroTextBox txfAuthCode;
        private MetroFramework.Controls.MetroTextBox txfLocation;
        private MetroFramework.Controls.MetroButton btnLocation;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel lblCurrentSerNum;
        private MetroFramework.Controls.MetroLabel lblCurrentAuthCode;
        private MetroFramework.Controls.MetroLabel lblAPI;
        private MetroFramework.Controls.MetroTextBox txfApi;
    }
}