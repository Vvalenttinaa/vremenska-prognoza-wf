using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class EditCity : BaseForm
    {
        CitiesForm citiesForm;

        String cityName = null;
        String country = null;
        int ID;

        public EditCity(City city, CitiesForm citiesForm)
        {
            InitializeComponent();

            this.citiesForm = citiesForm;

            btnCancel.Text = Resources.Cancel;
            btnSave.Text = Resources.Save;
            lbName.Text = Resources.Name.ToUpper();
            lbCountry.Text = Resources.Country;
            this.Text = Resources.City;

            MySqlCountry mySqlCountry = new MySqlCountry();
            List<Country> countries = mySqlCountry.GetCountries();
            foreach (Country country in countries)
            {
                cboCountry.Items.Add(country.Name);
            }

            cboCountry.SelectedItem = city.Country;
            tbName.Text = city.Name;

            cityName = city.Name;
            country = city.Country;
            ID = city.ID;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!cityName.Equals(tbName.Text) || !country.Equals(cboCountry.SelectedItem.ToString())) {

                City city = new City();
                city.Name = tbName.Text;
                city.ID  = ID;
                city.Country = cboCountry.SelectedItem.ToString();
                MySqlCity mySqlCity = new MySqlCity();
                mySqlCity.UpdateCity(city);
                this.Close();
                citiesForm.setData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
