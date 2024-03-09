namespace VremenskaPrognozaApp.Forms
{
    partial class AddCity
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(96, 50);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(67, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "NAME: ";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(219, 42);
            this.tbName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(380, 30);
            this.tbName.TabIndex = 1;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(96, 98);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(96, 23);
            this.lbCountry.TabIndex = 2;
            this.lbCountry.Text = "COUNTRY: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(219, 137);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(380, 63);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD CITY";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboCountry
            // 
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(219, 90);
            this.cboCountry.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(380, 31);
            this.cboCountry.TabIndex = 5;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // AddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 283);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "AddCity";
            this.Text = "AddCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboCountry;
    }
}