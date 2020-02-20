namespace BarcodeEncoder
{
    partial class InvCountNew
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DDWhse = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chkManual = new MetroFramework.Controls.MetroCheckBox();
            this.txtDescript = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.chkZero = new MetroFramework.Controls.MetroCheckBox();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // DDWhse
            // 
            this.DDWhse.FormattingEnabled = true;
            this.DDWhse.Location = new System.Drawing.Point(172, 122);
            this.DDWhse.Name = "DDWhse";
            this.DDWhse.Size = new System.Drawing.Size(200, 21);
            this.DDWhse.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(83, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Due Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(83, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Warehouse";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BarcodeEncoder.Properties.Resources.Save;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(277, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 29);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(276, 389);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(173, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Save and Go To Select items";
            // 
            // chkManual
            // 
            this.chkManual.AutoSize = true;
            this.chkManual.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkManual.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkManual.Location = new System.Drawing.Point(32, 264);
            this.chkManual.Name = "chkManual";
            this.chkManual.Size = new System.Drawing.Size(340, 19);
            this.chkManual.TabIndex = 6;
            this.chkManual.Text = "Allow users to capture quantities without scanning?";
            this.chkManual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkManual.UseSelectable = true;
            // 
            // txtDescript
            // 
            // 
            // 
            // 
            this.txtDescript.CustomButton.Image = null;
            this.txtDescript.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txtDescript.CustomButton.Name = "";
            this.txtDescript.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.txtDescript.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescript.CustomButton.TabIndex = 1;
            this.txtDescript.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescript.CustomButton.UseSelectable = true;
            this.txtDescript.CustomButton.Visible = false;
            this.txtDescript.Lines = new string[0];
            this.txtDescript.Location = new System.Drawing.Point(172, 150);
            this.txtDescript.MaxLength = 100;
            this.txtDescript.Multiline = true;
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.PasswordChar = '\0';
            this.txtDescript.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescript.SelectedText = "";
            this.txtDescript.SelectionLength = 0;
            this.txtDescript.SelectionStart = 0;
            this.txtDescript.ShortcutsEnabled = true;
            this.txtDescript.Size = new System.Drawing.Size(200, 68);
            this.txtDescript.TabIndex = 7;
            this.txtDescript.UseSelectable = true;
            this.txtDescript.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescript.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(83, 150);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Description";
            // 
            // chkZero
            // 
            this.chkZero.AutoSize = true;
            this.chkZero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkZero.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkZero.Location = new System.Drawing.Point(177, 239);
            this.chkZero.Name = "chkZero";
            this.chkZero.Size = new System.Drawing.Size(195, 19);
            this.chkZero.TabIndex = 9;
            this.chkZero.Text = "Include Zero Balance Items?";
            this.chkZero.UseSelectable = true;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(277, 295);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(57, 56);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressSpinner1.TabIndex = 28;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Visible = false;
            // 
            // InvCountNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 426);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.chkZero);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtDescript);
            this.Controls.Add(this.chkManual);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DDWhse);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "InvCountNew";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "New Inventory Count";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox DDWhse;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox chkManual;
        private MetroFramework.Controls.MetroTextBox txtDescript;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox chkZero;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}