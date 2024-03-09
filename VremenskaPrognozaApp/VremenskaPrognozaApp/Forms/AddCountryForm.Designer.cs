namespace VremenskaPrognozaApp.Forms
{
    partial class AddCountryForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbName.Location = new System.Drawing.Point(42, 81);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(144, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "COUNTRY NAME:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbName.Location = new System.Drawing.Point(214, 74);
            this.tbName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(390, 30);
            this.tbName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Location = new System.Drawing.Point(214, 135);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(394, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD COUNTRY";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 254);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "AddCountryForm";
            this.Text = "AddCountryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAdd;
    }
}