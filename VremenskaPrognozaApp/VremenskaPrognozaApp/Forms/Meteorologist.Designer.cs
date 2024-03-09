namespace VremenskaPrognozaApp.Forms
{
    partial class Meteorologist
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
            this.label13 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAllMeas = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbWW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Microsoft Uighur", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(499, -192);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(323, 65);
            this.label13.TabIndex = 40;
            this.label13.Text = "WeatherWatchful";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSettings.ForeColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(38, 360);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(300, 95);
            this.btnSettings.TabIndex = 59;
            this.btnSettings.Text = "button1";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAllMeas
            // 
            this.btnAllMeas.BackColor = System.Drawing.Color.Transparent;
            this.btnAllMeas.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAllMeas.ForeColor = System.Drawing.Color.Transparent;
            this.btnAllMeas.Location = new System.Drawing.Point(38, 269);
            this.btnAllMeas.Name = "btnAllMeas";
            this.btnAllMeas.Size = new System.Drawing.Size(300, 94);
            this.btnAllMeas.TabIndex = 58;
            this.btnAllMeas.Text = "button1";
            this.btnAllMeas.UseVisualStyleBackColor = false;
            this.btnAllMeas.Click += new System.EventHandler(this.btnAllMeas_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(38, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(300, 93);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbWW
            // 
            this.lbWW.AutoSize = true;
            this.lbWW.BackColor = System.Drawing.Color.Transparent;
            this.lbWW.Font = new System.Drawing.Font("Microsoft Uighur", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWW.ForeColor = System.Drawing.Color.Transparent;
            this.lbWW.Location = new System.Drawing.Point(27, 58);
            this.lbWW.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbWW.Name = "lbWW";
            this.lbWW.Size = new System.Drawing.Size(323, 65);
            this.lbWW.TabIndex = 68;
            this.lbWW.Text = "WeatherWatchful";
            // 
            // Meteorologist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 493);
            this.Controls.Add(this.lbWW);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAllMeas);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label13);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Meteorologist";
            this.Text = "Meteorologist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAllMeas;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbWW;
    }
}