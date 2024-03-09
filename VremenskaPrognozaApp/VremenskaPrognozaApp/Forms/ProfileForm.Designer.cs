namespace VremenskaPrognozaApp.Forms
{
    partial class ProfileForm
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
            this.lbfn = new System.Windows.Forms.Label();
            this.lbsn = new System.Windows.Forms.Label();
            this.lbr = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSr = new System.Windows.Forms.RadioButton();
            this.rbEn = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbfn
            // 
            this.lbfn.AutoSize = true;
            this.lbfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfn.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbfn.Location = new System.Drawing.Point(9, 66);
            this.lbfn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbfn.Name = "lbfn";
            this.lbfn.Size = new System.Drawing.Size(109, 25);
            this.lbfn.TabIndex = 0;
            this.lbfn.Text = "First name:";
            // 
            // lbsn
            // 
            this.lbsn.AutoSize = true;
            this.lbsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsn.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbsn.Location = new System.Drawing.Point(9, 102);
            this.lbsn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbsn.Name = "lbsn";
            this.lbsn.Size = new System.Drawing.Size(140, 25);
            this.lbsn.TabIndex = 1;
            this.lbsn.Text = "Second name:";
            // 
            // lbr
            // 
            this.lbr.AutoSize = true;
            this.lbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbr.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbr.Location = new System.Drawing.Point(9, 135);
            this.lbr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbr.Name = "lbr";
            this.lbr.Size = new System.Drawing.Size(57, 25);
            this.lbr.TabIndex = 2;
            this.lbr.Text = "Role:";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbFirstName.Location = new System.Drawing.Point(256, 117);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(64, 25);
            this.lbFirstName.TabIndex = 6;
            this.lbFirstName.Text = "label7";
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbSecondName.Location = new System.Drawing.Point(256, 153);
            this.lbSecondName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(64, 25);
            this.lbSecondName.TabIndex = 7;
            this.lbSecondName.Text = "label7";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbRole.Location = new System.Drawing.Point(256, 186);
            this.lbRole.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(64, 25);
            this.lbRole.TabIndex = 8;
            this.lbRole.Text = "label7";
            // 
            // pbLogout
            // 
            this.pbLogout.Image = global::VremenskaPrognozaApp.Properties.Resources.logout;
            this.pbLogout.InitialImage = global::VremenskaPrognozaApp.Properties.Resources.logout;
            this.pbLogout.Location = new System.Drawing.Point(572, 51);
            this.pbLogout.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(45, 41);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogout.TabIndex = 53;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(34, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 156);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Themes";
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(17, 108);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(97, 27);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "Theme 3";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(17, 75);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(97, 27);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Theme 2";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(17, 42);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(97, 27);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Theme 1";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSr);
            this.groupBox2.Controls.Add(this.rbEn);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.Location = new System.Drawing.Point(261, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 156);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Languages";
            // 
            // rbSr
            // 
            this.rbSr.AutoSize = true;
            this.rbSr.Location = new System.Drawing.Point(16, 66);
            this.rbSr.Name = "rbSr";
            this.rbSr.Size = new System.Drawing.Size(75, 27);
            this.rbSr.TabIndex = 1;
            this.rbSr.TabStop = true;
            this.rbSr.Text = "Srpski";
            this.rbSr.UseVisualStyleBackColor = true;
            this.rbSr.CheckedChanged += new System.EventHandler(this.rbSr_CheckedChanged);
            // 
            // rbEn
            // 
            this.rbEn.AutoSize = true;
            this.rbEn.Location = new System.Drawing.Point(16, 30);
            this.rbEn.Name = "rbEn";
            this.rbEn.Size = new System.Drawing.Size(85, 27);
            this.rbEn.TabIndex = 0;
            this.rbEn.TabStop = true;
            this.rbEn.Text = "English";
            this.rbEn.UseVisualStyleBackColor = true;
            this.rbEn.CheckedChanged += new System.EventHandler(this.rbEn_CheckedChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.Location = new System.Drawing.Point(489, 377);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 48);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.lbr);
            this.gbAccount.Controls.Add(this.lbfn);
            this.gbAccount.Controls.Add(this.lbsn);
            this.gbAccount.Location = new System.Drawing.Point(34, 51);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(381, 202);
            this.gbAccount.TabIndex = 57;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Account";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 445);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbSecondName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.gbAccount);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbfn;
        private System.Windows.Forms.Label lbsn;
        private System.Windows.Forms.Label lbr;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSr;
        private System.Windows.Forms.RadioButton rbEn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbAccount;
    }
}