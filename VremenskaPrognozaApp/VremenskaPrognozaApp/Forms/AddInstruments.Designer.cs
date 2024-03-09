namespace VremenskaPrognozaApp.Forms
{
    partial class AddInstruments
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
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbStation = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAddress
            // 
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(184, 85);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(353, 24);
            this.cbAddress.TabIndex = 0;
            this.cbAddress.SelectedIndexChanged += new System.EventHandler(this.cbAddress_SelectedIndexChanged);
            // 
            // cbStation
            // 
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(184, 149);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(353, 24);
            this.cbStation.TabIndex = 1;
            this.cbStation.SelectedIndexChanged += new System.EventHandler(this.cbStation_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 71);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD INSTRUMENTS";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(181, 66);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(76, 16);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "ADDRESS:";
            // 
            // lbStation
            // 
            this.lbStation.AutoSize = true;
            this.lbStation.Location = new System.Drawing.Point(184, 127);
            this.lbStation.Name = "lbStation";
            this.lbStation.Size = new System.Drawing.Size(141, 16);
            this.lbStation.TabIndex = 4;
            this.lbStation.Text = "WEATHER STATION:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(370, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 71);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddInstruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 352);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbStation);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.cbAddress);
            this.Name = "AddInstruments";
            this.Text = "AddInstruments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.ComboBox cbStation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbStation;
        private System.Windows.Forms.Button btnCancel;
    }
}