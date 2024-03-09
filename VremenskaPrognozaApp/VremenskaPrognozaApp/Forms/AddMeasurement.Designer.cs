namespace VremenskaPrognozaApp.Forms
{
    partial class AddMeasurement
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
            this.label14 = new System.Windows.Forms.Label();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.cbInstrumentsLocation = new System.Windows.Forms.ComboBox();
            this.cbPrecipitation = new System.Windows.Forms.CheckBox();
            this.lbInstrumentsAt = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbAtLocation = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.lbTemp = new System.Windows.Forms.Label();
            this.cbWind = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.cbPrecName = new System.Windows.Forms.ComboBox();
            this.tbPrecProbability = new System.Windows.Forms.TextBox();
            this.tbPrecAmount = new System.Windows.Forms.TextBox();
            this.tbPrecDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbProbability = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWindName = new System.Windows.Forms.ComboBox();
            this.tbWindStrength = new System.Windows.Forms.TextBox();
            this.tbWindDescription = new System.Windows.Forms.TextBox();
            this.tbWindDirection = new System.Windows.Forms.TextBox();
            this.lbWindStrength = new System.Windows.Forms.Label();
            this.lbWindDescription = new System.Windows.Forms.Label();
            this.lbWindDirection = new System.Windows.Forms.Label();
            this.lbWindName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(871, 482);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 59);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(698, 482);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 59);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DarkBlue;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 100);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(359, 30);
            this.dateTimePicker1.TabIndex = 72;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(258, 57);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 25);
            this.label14.TabIndex = 43;
            this.label14.Text = "°C";
            // 
            // tbTemp
            // 
            this.tbTemp.BackColor = System.Drawing.SystemColors.Control;
            this.tbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbTemp.Location = new System.Drawing.Point(161, 54);
            this.tbTemp.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(136, 30);
            this.tbTemp.TabIndex = 61;
            // 
            // cbInstrumentsLocation
            // 
            this.cbInstrumentsLocation.BackColor = System.Drawing.SystemColors.Control;
            this.cbInstrumentsLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstrumentsLocation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbInstrumentsLocation.FormattingEnabled = true;
            this.cbInstrumentsLocation.Location = new System.Drawing.Point(161, 431);
            this.cbInstrumentsLocation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbInstrumentsLocation.Name = "cbInstrumentsLocation";
            this.cbInstrumentsLocation.Size = new System.Drawing.Size(871, 33);
            this.cbInstrumentsLocation.TabIndex = 65;
            this.cbInstrumentsLocation.SelectedIndexChanged += new System.EventHandler(this.cbInstrumentsLocation_SelectedIndexChanged);
            // 
            // cbPrecipitation
            // 
            this.cbPrecipitation.AutoSize = true;
            this.cbPrecipitation.BackColor = System.Drawing.SystemColors.Control;
            this.cbPrecipitation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPrecipitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrecipitation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbPrecipitation.Location = new System.Drawing.Point(595, 167);
            this.cbPrecipitation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbPrecipitation.Name = "cbPrecipitation";
            this.cbPrecipitation.Size = new System.Drawing.Size(136, 29);
            this.cbPrecipitation.TabIndex = 53;
            this.cbPrecipitation.Text = "Precipitation";
            this.cbPrecipitation.UseVisualStyleBackColor = false;
            this.cbPrecipitation.CheckedChanged += new System.EventHandler(this.cbPrecipitation_CheckedChanged);
            // 
            // lbInstrumentsAt
            // 
            this.lbInstrumentsAt.AutoSize = true;
            this.lbInstrumentsAt.BackColor = System.Drawing.SystemColors.Control;
            this.lbInstrumentsAt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbInstrumentsAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstrumentsAt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbInstrumentsAt.Location = new System.Drawing.Point(5, 439);
            this.lbInstrumentsAt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbInstrumentsAt.Name = "lbInstrumentsAt";
            this.lbInstrumentsAt.Size = new System.Drawing.Size(140, 25);
            this.lbInstrumentsAt.TabIndex = 62;
            this.lbInstrumentsAt.Text = "Instruments at:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbUsername.Location = new System.Drawing.Point(1691, 33);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(99, 25);
            this.lbUsername.TabIndex = 71;
            this.lbUsername.Text = "username";
            // 
            // lbAtLocation
            // 
            this.lbAtLocation.AutoSize = true;
            this.lbAtLocation.BackColor = System.Drawing.SystemColors.Control;
            this.lbAtLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtLocation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbAtLocation.Location = new System.Drawing.Point(5, 390);
            this.lbAtLocation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAtLocation.Name = "lbAtLocation";
            this.lbAtLocation.Size = new System.Drawing.Size(109, 25);
            this.lbAtLocation.TabIndex = 63;
            this.lbAtLocation.Text = "At location:";
            // 
            // cbLocation
            // 
            this.cbLocation.BackColor = System.Drawing.SystemColors.Control;
            this.cbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(161, 382);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(871, 33);
            this.cbLocation.TabIndex = 64;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            this.cbLocation.Click += new System.EventHandler(this.cbLocation_Clicked);
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.BackColor = System.Drawing.SystemColors.Control;
            this.lbTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbTemp.Location = new System.Drawing.Point(15, 59);
            this.lbTemp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(130, 25);
            this.lbTemp.TabIndex = 44;
            this.lbTemp.Text = "Temperature:";
            // 
            // cbWind
            // 
            this.cbWind.AutoSize = true;
            this.cbWind.BackColor = System.Drawing.SystemColors.Control;
            this.cbWind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWind.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbWind.Location = new System.Drawing.Point(172, 164);
            this.cbWind.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbWind.Name = "cbWind";
            this.cbWind.Size = new System.Drawing.Size(76, 29);
            this.cbWind.TabIndex = 52;
            this.cbWind.Text = "Wind";
            this.cbWind.UseVisualStyleBackColor = false;
            this.cbWind.CheckedChanged += new System.EventHandler(this.cbWind_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbAmount);
            this.groupBox1.Controls.Add(this.cbPrecName);
            this.groupBox1.Controls.Add(this.tbPrecProbability);
            this.groupBox1.Controls.Add(this.tbPrecAmount);
            this.groupBox1.Controls.Add(this.tbPrecDescription);
            this.groupBox1.Controls.Add(this.lbDescription);
            this.groupBox1.Controls.Add(this.lbProbability);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(584, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 218);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(370, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(366, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 68;
            this.label2.Text = "l/m";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.SystemColors.Control;
            this.lbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbName.Location = new System.Drawing.Point(34, 73);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(70, 25);
            this.lbName.TabIndex = 56;
            this.lbName.Text = "Name:";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lbAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbAmount.Location = new System.Drawing.Point(34, 138);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(86, 25);
            this.lbAmount.TabIndex = 54;
            this.lbAmount.Text = "Amount:";
            // 
            // cbPrecName
            // 
            this.cbPrecName.BackColor = System.Drawing.SystemColors.Control;
            this.cbPrecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrecName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbPrecName.FormattingEnabled = true;
            this.cbPrecName.Location = new System.Drawing.Point(177, 65);
            this.cbPrecName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbPrecName.Name = "cbPrecName";
            this.cbPrecName.Size = new System.Drawing.Size(231, 33);
            this.cbPrecName.TabIndex = 67;
            // 
            // tbPrecProbability
            // 
            this.tbPrecProbability.BackColor = System.Drawing.SystemColors.Control;
            this.tbPrecProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecProbability.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbPrecProbability.Location = new System.Drawing.Point(177, 102);
            this.tbPrecProbability.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbPrecProbability.Name = "tbPrecProbability";
            this.tbPrecProbability.Size = new System.Drawing.Size(231, 30);
            this.tbPrecProbability.TabIndex = 58;
            // 
            // tbPrecAmount
            // 
            this.tbPrecAmount.BackColor = System.Drawing.SystemColors.Control;
            this.tbPrecAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbPrecAmount.Location = new System.Drawing.Point(177, 133);
            this.tbPrecAmount.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbPrecAmount.Name = "tbPrecAmount";
            this.tbPrecAmount.Size = new System.Drawing.Size(231, 30);
            this.tbPrecAmount.TabIndex = 59;
            // 
            // tbPrecDescription
            // 
            this.tbPrecDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbPrecDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecDescription.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbPrecDescription.Location = new System.Drawing.Point(177, 165);
            this.tbPrecDescription.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbPrecDescription.Name = "tbPrecDescription";
            this.tbPrecDescription.Size = new System.Drawing.Size(231, 30);
            this.tbPrecDescription.TabIndex = 60;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lbDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbDescription.Location = new System.Drawing.Point(33, 170);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(115, 25);
            this.lbDescription.TabIndex = 57;
            this.lbDescription.Text = "Description:";
            // 
            // lbProbability
            // 
            this.lbProbability.AutoSize = true;
            this.lbProbability.BackColor = System.Drawing.SystemColors.Control;
            this.lbProbability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProbability.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbProbability.Location = new System.Drawing.Point(34, 107);
            this.lbProbability.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbProbability.Name = "lbProbability";
            this.lbProbability.Size = new System.Drawing.Size(108, 25);
            this.lbProbability.TabIndex = 55;
            this.lbProbability.Text = "Probability:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbWindName);
            this.groupBox2.Controls.Add(this.tbWindStrength);
            this.groupBox2.Controls.Add(this.tbWindDescription);
            this.groupBox2.Controls.Add(this.tbWindDirection);
            this.groupBox2.Controls.Add(this.lbWindStrength);
            this.groupBox2.Controls.Add(this.lbWindDescription);
            this.groupBox2.Controls.Add(this.lbWindDirection);
            this.groupBox2.Controls.Add(this.lbWindName);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(161, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 218);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(309, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 69;
            this.label1.Text = "km/h";
            // 
            // cbWindName
            // 
            this.cbWindName.BackColor = System.Drawing.SystemColors.Control;
            this.cbWindName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWindName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbWindName.FormattingEnabled = true;
            this.cbWindName.Location = new System.Drawing.Point(124, 71);
            this.cbWindName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbWindName.Name = "cbWindName";
            this.cbWindName.Size = new System.Drawing.Size(248, 33);
            this.cbWindName.TabIndex = 68;
            // 
            // tbWindStrength
            // 
            this.tbWindStrength.BackColor = System.Drawing.SystemColors.Control;
            this.tbWindStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWindStrength.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbWindStrength.Location = new System.Drawing.Point(124, 170);
            this.tbWindStrength.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbWindStrength.Name = "tbWindStrength";
            this.tbWindStrength.Size = new System.Drawing.Size(248, 30);
            this.tbWindStrength.TabIndex = 51;
            // 
            // tbWindDescription
            // 
            this.tbWindDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbWindDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWindDescription.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbWindDescription.Location = new System.Drawing.Point(124, 138);
            this.tbWindDescription.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbWindDescription.Name = "tbWindDescription";
            this.tbWindDescription.Size = new System.Drawing.Size(248, 30);
            this.tbWindDescription.TabIndex = 50;
            // 
            // tbWindDirection
            // 
            this.tbWindDirection.BackColor = System.Drawing.SystemColors.Control;
            this.tbWindDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWindDirection.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbWindDirection.Location = new System.Drawing.Point(124, 105);
            this.tbWindDirection.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbWindDirection.Name = "tbWindDirection";
            this.tbWindDirection.Size = new System.Drawing.Size(248, 30);
            this.tbWindDirection.TabIndex = 49;
            // 
            // lbWindStrength
            // 
            this.lbWindStrength.AutoSize = true;
            this.lbWindStrength.BackColor = System.Drawing.SystemColors.Control;
            this.lbWindStrength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbWindStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWindStrength.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbWindStrength.Location = new System.Drawing.Point(6, 175);
            this.lbWindStrength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbWindStrength.Name = "lbWindStrength";
            this.lbWindStrength.Size = new System.Drawing.Size(92, 25);
            this.lbWindStrength.TabIndex = 48;
            this.lbWindStrength.Text = "Strength:";
            // 
            // lbWindDescription
            // 
            this.lbWindDescription.AutoSize = true;
            this.lbWindDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lbWindDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbWindDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWindDescription.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbWindDescription.Location = new System.Drawing.Point(6, 143);
            this.lbWindDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbWindDescription.Name = "lbWindDescription";
            this.lbWindDescription.Size = new System.Drawing.Size(115, 25);
            this.lbWindDescription.TabIndex = 47;
            this.lbWindDescription.Text = "Description:";
            // 
            // lbWindDirection
            // 
            this.lbWindDirection.AutoSize = true;
            this.lbWindDirection.BackColor = System.Drawing.SystemColors.Control;
            this.lbWindDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbWindDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWindDirection.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbWindDirection.Location = new System.Drawing.Point(6, 110);
            this.lbWindDirection.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbWindDirection.Name = "lbWindDirection";
            this.lbWindDirection.Size = new System.Drawing.Size(94, 25);
            this.lbWindDirection.TabIndex = 46;
            this.lbWindDirection.Text = "Direction:";
            // 
            // lbWindName
            // 
            this.lbWindName.AutoSize = true;
            this.lbWindName.BackColor = System.Drawing.SystemColors.Control;
            this.lbWindName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbWindName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWindName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbWindName.Location = new System.Drawing.Point(6, 79);
            this.lbWindName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbWindName.Name = "lbWindName";
            this.lbWindName.Size = new System.Drawing.Size(70, 25);
            this.lbWindName.TabIndex = 45;
            this.lbWindName.Text = "Name:";
            // 
            // AddMeasurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1105, 558);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.cbInstrumentsLocation);
            this.Controls.Add(this.cbPrecipitation);
            this.Controls.Add(this.lbInstrumentsAt);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbAtLocation);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.cbWind);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "AddMeasurement";
            this.Text = "AddMeasurement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.ComboBox cbInstrumentsLocation;
        private System.Windows.Forms.CheckBox cbPrecipitation;
        private System.Windows.Forms.Label lbInstrumentsAt;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbAtLocation;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label lbProbability;
        private System.Windows.Forms.ComboBox cbPrecName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbPrecProbability;
        private System.Windows.Forms.TextBox tbPrecAmount;
        private System.Windows.Forms.TextBox tbPrecDescription;
        private System.Windows.Forms.ComboBox cbWindName;
        private System.Windows.Forms.CheckBox cbWind;
        private System.Windows.Forms.TextBox tbWindStrength;
        private System.Windows.Forms.TextBox tbWindDescription;
        private System.Windows.Forms.Label lbWindName;
        private System.Windows.Forms.TextBox tbWindDirection;
        private System.Windows.Forms.Label lbWindDirection;
        private System.Windows.Forms.Label lbWindStrength;
        private System.Windows.Forms.Label lbWindDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}