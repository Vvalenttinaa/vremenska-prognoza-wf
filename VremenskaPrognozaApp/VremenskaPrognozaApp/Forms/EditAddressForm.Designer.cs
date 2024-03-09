namespace VremenskaPrognozaApp.Forms
{
    partial class EditAddressForm
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
            this.lbStreet = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbStreet.Location = new System.Drawing.Point(31, 110);
            this.lbStreet.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(58, 23);
            this.lbStreet.TabIndex = 0;
            this.lbStreet.Text = "Street:";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbNumber.Location = new System.Drawing.Point(31, 145);
            this.lbNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(77, 23);
            this.lbNumber.TabIndex = 1;
            this.lbNumber.Text = "Number:";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbCity.Location = new System.Drawing.Point(31, 206);
            this.lbCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(43, 23);
            this.lbCity.TabIndex = 2;
            this.lbCity.Text = "City:";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbCountry.Location = new System.Drawing.Point(31, 268);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(75, 23);
            this.lbCountry.TabIndex = 3;
            this.lbCountry.Text = "Country:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 90);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(448, 31);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(195, 137);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(448, 31);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(195, 198);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(448, 31);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(195, 260);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(448, 31);
            this.comboBox4.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Location = new System.Drawing.Point(328, 323);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 58);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(496, 323);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 58);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 432);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbStreet);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "EditAddressForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}