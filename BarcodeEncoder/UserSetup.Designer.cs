namespace BarcodeEncoder
{
    partial class UserSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSetup));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ddJobTitles = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtUserNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPwd = new MetroFramework.Controls.MetroTextBox();
            this.togActive = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.btnSaveLocation = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.DDUserName = new MetroFramework.Controls.MetroComboBox();
            this.btnAddUser = new System.Windows.Forms.PictureBox();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "User Name *";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Role (Job Title) *";
            this.metroLabel2.UseMnemonic = false;
            // 
            // ddJobTitles
            // 
            this.ddJobTitles.FormattingEnabled = true;
            this.ddJobTitles.ItemHeight = 23;
            this.ddJobTitles.Location = new System.Drawing.Point(136, 163);
            this.ddJobTitles.Name = "ddJobTitles";
            this.ddJobTitles.Size = new System.Drawing.Size(215, 29);
            this.ddJobTitles.TabIndex = 2;
            this.ddJobTitles.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 69);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Number *";
            // 
            // txtUserNumber
            // 
            // 
            // 
            // 
            this.txtUserNumber.CustomButton.Image = null;
            this.txtUserNumber.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtUserNumber.CustomButton.Name = "";
            this.txtUserNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserNumber.CustomButton.TabIndex = 1;
            this.txtUserNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserNumber.CustomButton.UseSelectable = true;
            this.txtUserNumber.CustomButton.Visible = false;
            this.txtUserNumber.Enabled = false;
            this.txtUserNumber.Lines = new string[0];
            this.txtUserNumber.Location = new System.Drawing.Point(136, 69);
            this.txtUserNumber.MaxLength = 32767;
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.PasswordChar = '\0';
            this.txtUserNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserNumber.SelectedText = "";
            this.txtUserNumber.SelectionLength = 0;
            this.txtUserNumber.SelectionStart = 0;
            this.txtUserNumber.ShortcutsEnabled = true;
            this.txtUserNumber.Size = new System.Drawing.Size(95, 23);
            this.txtUserNumber.TabIndex = 5;
            this.txtUserNumber.UseSelectable = true;
            this.txtUserNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 134);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Password *";
            // 
            // txtPwd
            // 
            // 
            // 
            // 
            this.txtPwd.CustomButton.Image = null;
            this.txtPwd.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtPwd.CustomButton.Name = "";
            this.txtPwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPwd.CustomButton.TabIndex = 1;
            this.txtPwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPwd.CustomButton.UseSelectable = true;
            this.txtPwd.CustomButton.Visible = false;
            this.txtPwd.Lines = new string[] {
        "metroTextBox2"};
            this.txtPwd.Location = new System.Drawing.Point(136, 134);
            this.txtPwd.MaxLength = 32767;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPwd.SelectedText = "";
            this.txtPwd.SelectionLength = 0;
            this.txtPwd.SelectionStart = 0;
            this.txtPwd.ShortcutsEnabled = true;
            this.txtPwd.Size = new System.Drawing.Size(215, 23);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.Text = "metroTextBox2";
            this.txtPwd.UseSelectable = true;
            this.txtPwd.UseSystemPasswordChar = true;
            this.txtPwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // togActive
            // 
            this.togActive.AutoSize = true;
            this.togActive.Checked = true;
            this.togActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.togActive.Location = new System.Drawing.Point(136, 198);
            this.togActive.Name = "togActive";
            this.togActive.Size = new System.Drawing.Size(80, 17);
            this.togActive.Style = MetroFramework.MetroColorStyle.Orange;
            this.togActive.TabIndex = 3;
            this.togActive.Text = "On";
            this.togActive.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(28, 198);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Active";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::BarcodeEncoder.Properties.Resources.Print;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrint.Location = new System.Drawing.Point(28, 249);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(64, 44);
            this.btnPrint.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.BackgroundImage = global::BarcodeEncoder.Properties.Resources.Save;
            this.btnSaveLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLocation.Location = new System.Drawing.Point(297, 249);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(54, 44);
            this.btnSaveLocation.TabIndex = 5;
            this.btnSaveLocation.UseSelectable = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(10, 293);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 41);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Print Password Barcode";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.WrapToLine = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(302, 295);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 19);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "SAVE";
            // 
            // DDUserName
            // 
            this.DDUserName.FormattingEnabled = true;
            this.DDUserName.ItemHeight = 23;
            this.DDUserName.Location = new System.Drawing.Point(136, 98);
            this.DDUserName.Name = "DDUserName";
            this.DDUserName.Size = new System.Drawing.Size(215, 29);
            this.DDUserName.TabIndex = 0;
            this.DDUserName.UseSelectable = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = global::BarcodeEncoder.Properties.Resources.PalletAdd;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Location = new System.Drawing.Point(223, 13);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(33, 50);
            this.btnAddUser.TabIndex = 22;
            this.btnAddUser.TabStop = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(136, 237);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(142, 60);
            this.PicBox.TabIndex = 35;
            this.PicBox.TabStop = false;
            this.PicBox.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(137, 98);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(215, 26);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.Visible = false;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 365);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.DDUserName);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.togActive);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.ddJobTitles);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UserSetup";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "User Configuration";
            this.Load += new System.EventHandler(this.UserSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox ddJobTitles;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtUserNumber;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPwd;
        private MetroFramework.Controls.MetroToggle togActive;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroButton btnSaveLocation;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox DDUserName;
        private System.Windows.Forms.PictureBox btnAddUser;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MetroFramework.Controls.MetroTextBox txtUserName;
    }
}