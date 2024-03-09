using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VremenskaPrognozaApp.Forms
{
    public partial class Meteorologist : BaseForm
    {
        public event EventHandler LanguageChanged;

        public Meteorologist()

        {
            InitializeComponent();
            changeLanguage();
           
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

            LoadTheme(filePath);
            ApplyTheme();

    }
    protected override void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected override void ApplyTheme()
        {
            base.ApplyTheme();
        }

        public void changeLanguage()
        {
            btnAdd.Text = Resources.AddMeasurement;
            btnAllMeas.Text = Resources.AllMeasurements;
            btnSettings.Text = Resources.MyProfile;
            lbWW.Text = Resources.WeatherWatchful;
            this.Text = Resources.Metheorologist;
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            if (e is CustomEventArgs customEventArgs)
            {
                switch (customEventArgs.EventType)
                {
                    case EventType.LanguageChanged:
                        ProfileForm profileForm = new ProfileForm(null, this);
                        profileForm.LanguageChanged += ProfileForm_LanguageChanged;
                        profileForm.Show();
                        break;

                    case EventType.ThemeChanged:
                        ProfileForm profileForm1 = new ProfileForm(null, this);
                        profileForm1.ThemeChanged += ProfileForm_ThemeChanged;
                        profileForm1.Show();
                        break;

                    case EventType.Generic:
                        break;
                }
            }
        }
        private void ProfileForm_LanguageChanged(object sender, EventArgs e)
        {
            changeLanguage();
        }
        private void ProfileForm_ThemeChanged(object sender, EventArgs e)
        {
            UpdateTheme();
        }

        public void UpdateTheme()
        {
            base.LoadTheme(filePath);
            base.ApplyTheme();

            this.LoadTheme(filePath);
            this.ApplyTheme();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMeasurement addMeasurement = new AddMeasurement();
            addMeasurement.Show();
            
        }

        private void btnAllMeas_Click(object sender, EventArgs e)
        {
            MeasurementsForm allMeas = new MeasurementsForm();
            allMeas.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!Form1.Logout)
            {
                Application.Exit();
            }
            else
            {
                Form1.Logout = false;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(null, this);
            profileForm.Show();
        }
    }
}
