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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VremenskaPrognozaApp.Forms
{
    public partial class AddAddress : BaseForm
    {
        AdressesViewForm adressesViewForm;
        public AddAddress()
        {
            InitializeComponent();
            setValues();
            ApplyTheme();

            this.Text = Resources.Address;

            lbCity.Text = Resources.City.ToUpper();
            lbCountry.Text = Resources.Country.ToUpper();
            lbNumber.Text = Resources.Number.ToUpper();
            lbStreet.Text = Resources.Street.ToUpper();

            btnCancel.Text = Resources.Cancel;
            btnAddAddress.Text = Resources.Save;

            cboCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            

        }
        public AddAddress(AdressesViewForm a)
        {
            InitializeComponent();
            setValues();
            ApplyTheme();

            this.Text = Resources.Address;

            lbCity.Text = Resources.City;
            lbCountry.Text = Resources.Country;
            lbNumber.Text = Resources.Number;
            lbStreet.Text = Resources.Street;

            btnCancel.Text = Resources.Cancel;
            btnAddAddress.Text = Resources.Save;

            cboCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            adressesViewForm = a;

        }

        protected override void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected override void ApplyTheme()
        {
            base.ApplyTheme();
        }

        private void setValues()
        {
            MySqlCity mySqlCity = new MySqlCity();
            MySqlCountry mySqlCountry = new MySqlCountry();

            List<Country> countries = new List<Country>();
            List<City> cities = new List<City>();

            countries = mySqlCountry.GetCountries();

            foreach (Country country in countries)
            {
                cboCountry.Items.Add(country.Name);
            }
            /*if (cboCountry != null) 
            { 
                cities = mySqlCity.GetCitesFromCountry(cboCountry.Text);
                foreach (City city in cities)
                {
                    cboCity.Items.Add(city.Name);
                }
            }
            */

            /* if(cboCountry == null)
             {
                 cities=mySqlCity.GetCities1();
                 foreach (City city in cities)
                 {
                     MessageBox.Show(city.Name);
                     cboCity.Items.Add(city.Name);
                 }
             }
             else*/
            /*  {
                  cities = mySqlCity.GetCitesFromCountry(cboCountry.Text);
                  foreach (City city in cities)
                  {
                      cboCity.Items.Add(city.Name);
                  }
              }
            */
        }

       

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCity.Items.Clear();
            if (cboCountry.Text != null)
            {
                List<City> cities = new List<City>();
                MySqlCity mySqlCity = new MySqlCity();

                cities = mySqlCity.GetCitesFromCountry(cboCountry.Text);
                foreach (City city in cities)
                {
                    cboCity.Items.Add(city.Name);
                }
            }
        }

        private void cboCountry_TextChanged(object sender, EventArgs e)
        {
            MySqlCountry mySqlCountry = new MySqlCountry();

            if(mySqlCountry.existsCountry(cboCountry.Text))
            {
                List<City> cities = new List<City>();
                MySqlCity mySqlCity = new MySqlCity();

                cities = mySqlCity.GetCitesFromCountry(cboCountry.Text);
                foreach (City city in cities)
                {
                    cboCity.Items.Add(city.Name);
                }
            }
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStreet.Items.Clear();
            if (cboCity.Text != null)
            {
                List<Address> addresses = new List<Address>();
                MySqlAddress mySqlAddress = new MySqlAddress();

                addresses = mySqlAddress.GetAdressesFromCity(cboCity.Text);
                foreach (Address a in addresses)
                {
                    cboStreet.Items.Add(a.StreetName);
                }
            }
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
           
            MySqlCountry mySqlCountry = new MySqlCountry();
            MySqlCity mySqlCity = new MySqlCity();
            MySqlAddress mySqlAddress = new MySqlAddress();

            if (!mySqlCountry.existsCountry(cboCountry.Text))
            {
                mySqlCountry.InsertCountry(cboCountry.Text);
                List<City> cities = new List<City>();

                cities = mySqlCity.GetCitesFromCountry(cboCountry.Text);
                foreach (City city in cities)
                {
                    cboCity.Items.Add(city.Name);
                }
            }

            if (!mySqlCity.existsCity(cboCity.Text))
            {
                mySqlCity.InsertCity(cboCity.Text, cboCountry.Text);
            }

            int.TryParse(cboNumber.Text, out int num);
            int numCity=mySqlCity.GetId(cboCity.Text);

            if (!mySqlAddress.existsAddress(cboStreet.Text, num, numCity))
            {
                mySqlAddress.InsertAdress(cboStreet.Text, num, mySqlCity.GetId(cboCity.Text));
            }
            if (adressesViewForm != null)
            {
                adressesViewForm.setData();
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
