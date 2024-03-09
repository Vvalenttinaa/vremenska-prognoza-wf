namespace VremenskaPrognozaApp.Forms
{
    partial class MeasurementsForm
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
            this.btnDetails = new System.Windows.Forms.Button();
            this.lvMeasurements = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbId = new System.Windows.Forms.TextBox();
            this.cbMeasurements = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDetails.Location = new System.Drawing.Point(584, 362);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(156, 69);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // lvMeasurements
            // 
            this.lvMeasurements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.City,
            this.Country,
            this.Temperature});
            this.lvMeasurements.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lvMeasurements.FullRowSelect = true;
            this.lvMeasurements.HideSelection = false;
            this.lvMeasurements.Location = new System.Drawing.Point(15, 76);
            this.lvMeasurements.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lvMeasurements.Name = "lvMeasurements";
            this.lvMeasurements.Size = new System.Drawing.Size(725, 270);
            this.lvMeasurements.TabIndex = 1;
            this.lvMeasurements.UseCompatibleStateImageBehavior = false;
            this.lvMeasurements.View = System.Windows.Forms.View.Details;
            this.lvMeasurements.SelectedIndexChanged += new System.EventHandler(this.lvMeasurements_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Tag = "ID";
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // City
            // 
            this.City.DisplayIndex = 2;
            this.City.Text = "City";
            this.City.Width = 177;
            // 
            // Country
            // 
            this.Country.DisplayIndex = 1;
            this.Country.Text = "Country";
            this.Country.Width = 292;
            // 
            // Temperature
            // 
            this.Temperature.Text = "Temperature";
            this.Temperature.Width = 413;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(594, 254);
            this.tbId.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(83, 47);
            this.tbId.TabIndex = 3;
            // 
            // cbMeasurements
            // 
            this.cbMeasurements.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMeasurements.FormattingEnabled = true;
            this.cbMeasurements.Items.AddRange(new object[] {
            "All measurements",
            "My measurements"});
            this.cbMeasurements.Location = new System.Drawing.Point(527, 43);
            this.cbMeasurements.Name = "cbMeasurements";
            this.cbMeasurements.Size = new System.Drawing.Size(213, 31);
            this.cbMeasurements.TabIndex = 4;
            this.cbMeasurements.SelectedIndexChanged += new System.EventHandler(this.cbMeasurements_SelectedIndexChanged);
            // 
            // MeasurementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 445);
            this.Controls.Add(this.cbMeasurements);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lvMeasurements);
            this.Controls.Add(this.tbId);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "MeasurementsForm";
            this.Text = "MeasurementsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMeasurements;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader Temperature;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ComboBox cbMeasurements;
    }
}