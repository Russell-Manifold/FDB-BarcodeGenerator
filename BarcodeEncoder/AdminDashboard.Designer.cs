namespace BarcodeEncoder
{
    partial class AdminDashboard
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
            this.metroButton2 = new System.Windows.Forms.Button();
            this.metroButton3 = new System.Windows.Forms.Button();
            this.metroButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroButton2.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.metroButton2.FlatAppearance.BorderSize = 2;
            this.metroButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroButton2.ForeColor = System.Drawing.Color.OrangeRed;
            this.metroButton2.Location = new System.Drawing.Point(57, 138);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(189, 51);
            this.metroButton2.TabIndex = 45;
            this.metroButton2.Text = "USERS";
            this.metroButton2.UseVisualStyleBackColor = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Transparent;
            this.metroButton3.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.metroButton3.FlatAppearance.BorderSize = 2;
            this.metroButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroButton3.ForeColor = System.Drawing.Color.OrangeRed;
            this.metroButton3.Location = new System.Drawing.Point(57, 195);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(189, 51);
            this.metroButton3.TabIndex = 46;
            this.metroButton3.Text = "JOB TITLES";
            this.metroButton3.UseVisualStyleBackColor = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.metroButton1.FlatAppearance.BorderSize = 2;
            this.metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroButton1.ForeColor = System.Drawing.Color.OrangeRed;
            this.metroButton1.Location = new System.Drawing.Point(57, 252);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(189, 51);
            this.metroButton1.TabIndex = 47;
            this.metroButton1.Text = "CONNECTION";
            this.metroButton1.UseVisualStyleBackColor = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Name = "AdminDashboard";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Configuration";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button metroButton2;
        private System.Windows.Forms.Button metroButton3;
        private System.Windows.Forms.Button metroButton1;
    }
}