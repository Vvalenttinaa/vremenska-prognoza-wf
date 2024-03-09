namespace VremenskaPrognozaApp.Forms
{
    partial class CitiesForm
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
            this.lwCountries = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbIDCity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lwCountries
            // 
            this.lwCountries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.City,
            this.Country});
            this.lwCountries.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwCountries.FullRowSelect = true;
            this.lwCountries.HideSelection = false;
            this.lwCountries.Location = new System.Drawing.Point(31, 62);
            this.lwCountries.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lwCountries.Name = "lwCountries";
            this.lwCountries.Size = new System.Drawing.Size(634, 324);
            this.lwCountries.TabIndex = 0;
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
            // City
            // 
            this.City.Text = "City";
            this.City.Width = 236;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.Width = 274;
            // 
            // tbIDCity
            // 
            this.tbIDCity.Location = new System.Drawing.Point(327, 254);
            this.tbIDCity.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbIDCity.Name = "tbIDCity";
            this.tbIDCity.Size = new System.Drawing.Size(327, 47);
            this.tbIDCity.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(541, 428);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 49);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(423, 428);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 49);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(301, 428);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 49);
            this.btnEdit.TabIndex = 60;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // CitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 497);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lwCountries);
            this.Controls.Add(this.tbIDCity);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "CitiesForm";
            this.Text = "CitiesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwCountries;
        private System.Windows.Forms.TextBox tbIDCity;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}