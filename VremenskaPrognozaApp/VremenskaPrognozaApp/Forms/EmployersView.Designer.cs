namespace VremenskaPrognozaApp.Forms
{
    partial class EmployersView
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
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secondName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEmployees
            // 
            this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.firstName,
            this.secondName});
            this.lvEmployees.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lvEmployees.FullRowSelect = true;
            this.lvEmployees.HideSelection = false;
            this.lvEmployees.Location = new System.Drawing.Point(15, 76);
            this.lvEmployees.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(565, 323);
            this.lvEmployees.TabIndex = 16;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            this.lvEmployees.SelectedIndexChanged += new System.EventHandler(this.lvStations_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Tag = "ID";
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 207;
            // 
            // secondName
            // 
            this.secondName.Text = "Second Name";
            this.secondName.Width = 168;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDelete.Location = new System.Drawing.Point(446, 415);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 65);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button1.Location = new System.Drawing.Point(315, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 65);
            this.button1.TabIndex = 14;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(235, 283);
            this.tbID.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(333, 47);
            this.tbID.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAdd.Location = new System.Drawing.Point(184, 415);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 65);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EmployersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 491);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvEmployees);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbID);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "EmployersView";
            this.Text = "EmployersView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvEmployees;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader secondName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnAdd;
    }
}