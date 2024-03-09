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
    public partial class AddCity : BaseForm
    {
        CitiesForm citiesForm;
        String country;
        public AddCity(CitiesForm citiesForm)
        {
            InitializeComponent();
            this.citiesForm = citiesForm;
            setValues();
            ApplyTheme();
            this.Text = Resources.City;
            lbCountry.Text = Resources.Country;
            lbName.Text = Resources.Name;
            btnAdd.Text = Resources.Add;
            this.citiesForm = citiesForm;
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
            MySqlCountry mySqlCountry = new MySqlCountry();
            List<Country> countries = mySqlCountry.GetCountries();
            foreach (Country country in countries)
            {
                cboCountry.Items.Add(country.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text != null && tbName.Text.Length > 0 && country != null)
            {
                MySqlCity mySqlCity = new MySqlCity();
                mySqlCity.InsertCity(tbName.Text, cboCountry.Text);
                this.Close();
                citiesForm.setData();
            }

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
             country = cboCountry.SelectedItem.ToString();            
        }
    }
}
