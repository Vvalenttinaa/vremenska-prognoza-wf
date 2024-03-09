namespace VremenskaPrognozaApp.Forms
{
    partial class CountryForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lwCountries = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbIDCountry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Location = new System.Drawing.Point(131, 386);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 49);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelete.Location = new System.Drawing.Point(462, 384);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 51);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.Location = new System.Drawing.Point(297, 384);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 51);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lwCountries
            // 
            this.lwCountries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Country});
            this.lwCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lwCountries.FullRowSelect = true;
            this.lwCountries.HideSelection = false;
            this.lwCountries.Location = new System.Drawing.Point(15, 39);
            this.lwCountries.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lwCountries.Name = "lwCountries";
            this.lwCountries.Size = new System.Drawing.Size(588, 329);
            this.lwCountries.TabIndex = 14;
            this.lwCountries.UseCompatibleStateImageBehavior = false;
            this.lwCountries.View = System.Windows.Forms.View.Details;
            this.lwCountries.SelectedIndexChanged += new System.EventHandler(this.lwCities_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Tag = "ID";
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.Width = 440;
            // 
            // tbIDCountry
            // 
            this.tbIDCountry.Location = new System.Drawing.Point(86, 269);
            this.tbIDCountry.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbIDCountry.Name = "tbIDCountry";
            this.tbIDCountry.Size = new System.Drawing.Size(327, 47);
            this.tbIDCountry.TabIndex = 15;
            // 
            // CountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lwCountries);
            this.Controls.Add(this.tbIDCountry);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "CountryForm";
            this.Text = "CountryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbIDCountry;
        private System.Windows.Forms.ListView lwCountries;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.Button btnAdd;
    }
}