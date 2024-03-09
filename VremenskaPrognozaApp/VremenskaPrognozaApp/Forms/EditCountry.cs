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
    public partial class EditCountry : BaseForm
    {
        MySqlCountry mySqlCountry;
        CountryForm countryForm;
        int id;
        public EditCountry(String name, CountryForm form)
        {
            InitializeComponent();
            countryForm = form;
            btnCancel.Text = Resources.Cancel;
            btnSave.Text = Resources.Save;
            lbName.Text = Resources.Name;
            tbCountryName.Text = name;
            mySqlCountry = new MySqlCountry();
            id = mySqlCountry.GetCountryIdByName(name);

            lbName.Text = Resources.Name;
            btnSave.Text = Resources.Save;
            btnCancel.Text = Resources.Cancel;
            this.Text = Resources.Country;

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
            Country country = new Country();
            country.Name = tbCountryName.Text;
            country.ID = id;

            mySqlCountry.UpdateCountry(country);
            this.Close();

            countryForm.setData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
