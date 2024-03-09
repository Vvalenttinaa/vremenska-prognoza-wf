namespace VremenskaPrognozaApp.Forms
{
    partial class EditMeasurementForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.cbInstrumentsLocation = new System.Windows.Forms.ComboBox();
            this.lbInstrumentsAt = new System.Windows.Forms.Label();
            this.lbAtLocation = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.lbTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(776, 342);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 59);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(614, 342);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 59);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DarkBlue;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 197);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(359, 26);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // tbTemp
            // 
            this.tbTemp.BackColor = System.Drawing.SystemColors.Control;
            this.tbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbTemp.Location = new System.Drawing.Point(204, 168);
            this.tbTemp.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(136, 27);
            this.tbTemp.TabIndex = 35;
            // 
            // cbInstrumentsLocation
            // 
            this.cbInstrumentsLocation.BackColor = System.Drawing.SystemColors.Control;
            this.cbInstrumentsLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstrumentsLocation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbInstrumentsLocation.FormattingEnabled = true;
            this.cbInstrumentsLocation.Location = new System.Drawing.Point(204, 293);
            this.cbInstrumentsLocation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbInstrumentsLocation.Name = "cbInstrumentsLocation";
            this.cbInstrumentsLocation.Size = new System.Drawing.Size(739, 28);
            this.cbInstrumentsLocation.TabIndex = 39;
            // 
            // lbInstrumentsAt
            // 
            this.lbInstrumentsAt.AutoSize = true;
            this.lbInstrumentsAt.BackColor = System.Drawing.Color.Transparent;
            this.lbInstrumentsAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstrumentsAt.ForeColor = System.Drawing.Color.Transparent;
            this.lbInstrumentsAt.Location = new System.Drawing.Point(81, 301);
            this.lbInstrumentsAt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbInstrumentsAt.Name = "lbInstrumentsAt";
            this.lbInstrumentsAt.Size = new System.Drawing.Size(91, 16);
            this.lbInstrumentsAt.TabIndex = 36;
            this.lbInstrumentsAt.Text = "Instruments at:";
            // 
            // lbAtLocation
            // 
            this.lbAtLocation.AutoSize = true;
            this.lbAtLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbAtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtLocation.ForeColor = System.Drawing.Color.Transparent;
            this.lbAtLocation.Location = new System.Drawing.Point(81, 263);
            this.lbAtLocation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAtLocation.Name = "lbAtLocation";
            this.lbAtLocation.Size = new System.Drawing.Size(72, 16);
            this.lbAtLocation.TabIndex = 37;
            this.lbAtLocation.Text = "At location:";
            // 
            // cbLocation
            // 
            this.cbLocation.BackColor = System.Drawing.SystemColors.Control;
            this.cbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(204, 263);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(739, 28);
            this.cbLocation.TabIndex = 38;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged_1);
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.ForeColor = System.Drawing.Color.Transparent;
            this.lbTemp.Location = new System.Drawing.Point(81, 168);
            this.lbTemp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(88, 16);
            this.lbTemp.TabIndex = 34;
            this.lbTemp.Text = "Temperature:";
            // 
            // EditMeasurementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 569);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.cbInstrumentsLocation);
            this.Controls.Add(this.lbInstrumentsAt);
            this.Controls.Add(this.lbAtLocation);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.lbTemp);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "EditMeasurementForm";
            this.Text = "EdiyMeasurementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.ComboBox cbInstrumentsLocation;
        private System.Windows.Forms.Label lbInstrumentsAt;
        private System.Windows.Forms.Label lbAtLocation;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label lbTemp;
    }
}