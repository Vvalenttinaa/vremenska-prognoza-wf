namespace VremenskaPrognozaApp.Forms
{
    partial class AdressesViewForm
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
            this.lvAddresses = new System.Windows.Forms.ListView();
            this.Street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Location = new System.Drawing.Point(837, 438);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelete.Location = new System.Drawing.Point(699, 438);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 45);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lvAddresses
            // 
            this.lvAddresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Street,
            this.Number,
            this.City,
            this.Country,
            this.ID});
            this.lvAddresses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lvAddresses.FullRowSelect = true;
            this.lvAddresses.HideSelection = false;
            this.lvAddresses.Location = new System.Drawing.Point(16, 101);
            this.lvAddresses.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lvAddresses.Name = "lvAddresses";
            this.lvAddresses.Size = new System.Drawing.Size(959, 321);
            this.lvAddresses.TabIndex = 0;
            this.lvAddresses.UseCompatibleStateImageBehavior = false;
            this.lvAddresses.View = System.Windows.Forms.View.Details;
            this.lvAddresses.SelectedIndexChanged += new System.EventHandler(this.lvAddresses_SelectedIndexChanged);
            // 
            // Street
            // 
            this.Street.DisplayIndex = 1;
            this.Street.Text = "Street";
            this.Street.Width = 192;
            // 
            // Number
            // 
            this.Number.DisplayIndex = 2;
            this.Number.Text = "Number";
            this.Number.Width = 80;
            // 
            // City
            // 
            this.City.DisplayIndex = 3;
            this.City.Text = "City";
            this.City.Width = 186;
            // 
            // Country
            // 
            this.Country.DisplayIndex = 4;
            this.Country.Text = "Country";
            this.Country.Width = 319;
            // 
            // ID
            // 
            this.ID.DisplayIndex = 0;
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(226, 263);
            this.tbID.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(327, 47);
            this.tbID.TabIndex = 1;
            // 
            // AdressesViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 493);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvAddresses);
            this.Controls.Add(this.tbID);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "AdressesViewForm";
            this.Text = "AdressesViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAddresses;
        private System.Windows.Forms.ColumnHeader Street;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}