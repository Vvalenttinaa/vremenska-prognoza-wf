namespace VremenskaPrognozaApp.Forms
{
    partial class AddAddress
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
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboStreet = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.cboNumber = new System.Windows.Forms.ComboBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStreet.Location = new System.Drawing.Point(47, 165);
            this.lbStreet.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(79, 20);
            this.lbStreet.TabIndex = 0;
            this.lbStreet.Text = "STREET:";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(47, 223);
            this.lbNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(87, 20);
            this.lbNumber.TabIndex = 1;
            this.lbNumber.Text = "NUMBER:";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(47, 113);
            this.lbCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(55, 20);
            this.lbCity.TabIndex = 2;
            this.lbCity.Text = "CITY: ";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(47, 60);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(90, 20);
            this.lbCountry.TabIndex = 3;
            this.lbCountry.Text = "COUNTRY";
            // 
            // cboCity
            // 
            this.cboCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(207, 105);
            this.cboCity.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(294, 28);
            this.cboCity.TabIndex = 5;
            this.cboCity.SelectedIndexChanged += new System.EventHandler(this.cboCity_SelectedIndexChanged);
            // 
            // cboStreet
            // 
            this.cboStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStreet.FormattingEnabled = true;
            this.cboStreet.Location = new System.Drawing.Point(207, 162);
            this.cboStreet.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cboStreet.Name = "cboStreet";
            this.cboStreet.Size = new System.Drawing.Size(592, 28);
            this.cboStreet.TabIndex = 6;
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(207, 52);
            this.cboCountry.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(294, 28);
            this.cboCountry.TabIndex = 7;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // cboNumber
            // 
            this.cboNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumber.FormattingEnabled = true;
            this.cboNumber.Location = new System.Drawing.Point(207, 215);
            this.cboNumber.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cboNumber.Name = "cboNumber";
            this.cboNumber.Size = new System.Drawing.Size(592, 28);
            this.cboNumber.TabIndex = 8;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAddress.Location = new System.Drawing.Point(591, 269);
            this.btnAddAddress.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(208, 59);
            this.btnAddAddress.TabIndex = 9;
            this.btnAddAddress.Tag = "btnAddAddress";
            this.btnAddAddress.Text = "ADD ADDRESS";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(371, 269);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(208, 59);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Tag = "btnAddAddress";
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 404);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.cboNumber);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.cboStreet);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbStreet);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "AddAddress";
            this.Text = "AddAddress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.ComboBox cboStreet;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboNumber;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnCancel;
    }
}