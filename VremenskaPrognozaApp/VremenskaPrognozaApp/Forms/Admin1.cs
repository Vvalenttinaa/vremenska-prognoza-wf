using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class Admin1 : BaseForm
    {
        public event EventHandler LanguageChanged;

        public Admin1()
        {
            InitializeComponent();

            changeLanguage();
            LoadTheme(filePath);
            ApplyTheme();
        }

        public void changeLanguage()
        {
            lbWW.Text = Resources.WeatherWatchful;
            btnCountry.Text = Resources.Country;
            btnCity.Text = Resources.City;
            btnEmployee.Text = Resources.Employee;
            btnStation.Text = Resources.Station;
            btnAddress.Text = Resources.Address;
            btnSettings.Text = Resources.MyProfile;
            this.Text = Resources.WeatherWatchful;
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            if (e is CustomEventArgs customEventArgs)
            {
                switch (customEventArgs.EventType)
                {
                    case EventType.LanguageChanged:
                        ProfileForm profileForm = new ProfileForm(this, null);
                        profileForm.LanguageChanged += ProfileForm_LanguageChanged;
                        profileForm.Show();
                        break;

                    case EventType.ThemeChanged:
                        ProfileForm profileForm1 = new ProfileForm(this, null);
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

        protected void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected void ApplyTheme()
        {
            base.ApplyTheme();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            AdressesViewForm adressesViewForm = new AdressesViewForm();
            adressesViewForm.ShowDialog();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            CountryForm form = new CountryForm();
            form.ShowDialog();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            CitiesForm citiesForm = new CitiesForm();
            citiesForm.ShowDialog();
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            StationViewForm stationViewForm = new StationViewForm();
            stationViewForm.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployersView employersView = new EmployersView();
            employersView.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(this, null);
            profileForm.ShowDialog();
        }
    }
}
