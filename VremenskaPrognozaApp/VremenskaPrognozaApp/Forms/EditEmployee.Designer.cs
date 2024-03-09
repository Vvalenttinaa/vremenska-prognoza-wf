namespace VremenskaPrognozaApp.Forms
{
    partial class EditEmployee
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(397, 133);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 58);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Location = new System.Drawing.Point(213, 133);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 57);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbFirstName.Location = new System.Drawing.Point(189, 22);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(424, 30);
            this.tbFirstName.TabIndex = 9;
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbSecondName.Location = new System.Drawing.Point(50, 76);
            this.lbSecondName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(121, 23);
            this.lbSecondName.TabIndex = 8;
            this.lbSecondName.Text = "Second Name:";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbFirstName.Location = new System.Drawing.Point(50, 29);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(96, 23);
            this.lbFirstName.TabIndex = 7;
            this.lbFirstName.Text = "First Name:";
            // 
            // tbSecondName
            // 
            this.tbSecondName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbSecondName.Location = new System.Drawing.Point(189, 72);
            this.tbSecondName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(424, 30);
            this.tbSecondName.TabIndex = 12;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 258);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbSecondName);
            this.Controls.Add(this.lbFirstName);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbSecondName;
    }
}