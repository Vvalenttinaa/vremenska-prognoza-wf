namespace VremenskaPrognozaApp.Forms
{
    partial class StationViewForm
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
            this.lvStations = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(767, 444);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 65);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvStations
            // 
            this.lvStations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.street,
            this.number,
            this.city,
            this.country});
            this.lvStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvStations.FullRowSelect = true;
            this.lvStations.HideSelection = false;
            this.lvStations.Location = new System.Drawing.Point(15, 96);
            this.lvStations.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lvStations.Name = "lvStations";
            this.lvStations.Size = new System.Drawing.Size(908, 332);
            this.lvStations.TabIndex = 10;
            this.lvStations.UseCompatibleStateImageBehavior = false;
            this.lvStations.View = System.Windows.Forms.View.Details;
            this.lvStations.SelectedIndexChanged += new System.EventHandler(this.lvStations_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Tag = "ID";
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // street
            // 
            this.street.Text = "Street";
            this.street.Width = 200;
            // 
            // number
            // 
            this.number.Text = "Number";
            this.number.Width = 133;
            // 
            // city
            // 
            this.city.Text = "City";
            this.city.Width = 150;
            // 
            // country
            // 
            this.country.Text = "Country";
            this.country.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Location = new System.Drawing.Point(417, 444);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 65);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.Location = new System.Drawing.Point(592, 444);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 65);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(104, 285);
            this.tbID.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(327, 47);
            this.tbID.TabIndex = 6;
            // 
            // StationViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 541);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvStations);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbID);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "StationViewForm";
            this.Text = "StationViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ListView lvStations;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader street;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader country;
        private System.Windows.Forms.Button btnAdd;
    }
}