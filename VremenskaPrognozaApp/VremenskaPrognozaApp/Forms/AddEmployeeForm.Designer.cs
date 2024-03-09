namespace VremenskaPrognozaApp.Forms
{
    partial class AddEmployeeForm
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbMetheorologistStation = new System.Windows.Forms.ComboBox();
            this.lbStation = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbFirstName.Location = new System.Drawing.Point(287, 17);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(384, 30);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbSecondName
            // 
            this.tbSecondName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbSecondName.Location = new System.Drawing.Point(287, 73);
            this.tbSecondName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(384, 30);
            this.tbSecondName.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbUsername.Location = new System.Drawing.Point(287, 131);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(384, 30);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbPassword.Location = new System.Drawing.Point(287, 186);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(384, 30);
            this.tbPassword.TabIndex = 3;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbFirstName.Location = new System.Drawing.Point(91, 24);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(96, 23);
            this.lbFirstName.TabIndex = 5;
            this.lbFirstName.Text = "First Name:";
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbSecondName.Location = new System.Drawing.Point(91, 76);
            this.lbSecondName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(121, 23);
            this.lbSecondName.TabIndex = 6;
            this.lbSecondName.Text = "Second Name:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbUsername.Location = new System.Drawing.Point(91, 131);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(91, 23);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Username:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbPassword.Location = new System.Drawing.Point(91, 193);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(84, 23);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Password:";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbRole.Location = new System.Drawing.Point(91, 259);
            this.lbRole.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(47, 23);
            this.lbRole.TabIndex = 9;
            this.lbRole.Text = "Role:";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "Metheorologist"});
            this.cbRole.Location = new System.Drawing.Point(287, 251);
            this.cbRole.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(384, 31);
            this.cbRole.TabIndex = 10;
            // 
            // cbMetheorologistStation
            // 
            this.cbMetheorologistStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetheorologistStation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMetheorologistStation.FormattingEnabled = true;
            this.cbMetheorologistStation.Location = new System.Drawing.Point(287, 321);
            this.cbMetheorologistStation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbMetheorologistStation.Name = "cbMetheorologistStation";
            this.cbMetheorologistStation.Size = new System.Drawing.Size(384, 31);
            this.cbMetheorologistStation.TabIndex = 11;
            // 
            // lbStation
            // 
            this.lbStation.AutoSize = true;
            this.lbStation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbStation.Location = new System.Drawing.Point(78, 329);
            this.lbStation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbStation.Name = "lbStation";
            this.lbStation.Size = new System.Drawing.Size(187, 23);
            this.lbStation.TabIndex = 12;
            this.lbStation.Text = "Metheorologist station:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Location = new System.Drawing.Point(482, 418);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 56);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "ADD";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAdd);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(287, 418);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(189, 56);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 505);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbStation);
            this.Controls.Add(this.cbMetheorologistStation);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbSecondName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.tbFirstName);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbMetheorologistStation;
        private System.Windows.Forms.Label lbStation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}