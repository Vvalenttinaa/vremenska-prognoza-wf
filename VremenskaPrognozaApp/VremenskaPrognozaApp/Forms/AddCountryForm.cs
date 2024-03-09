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

namespace VremenskaPrognozaApp.Forms
{
    public partial class AddCountryForm : BaseForm
    {
        private CountryForm countryForm;
        public AddCountryForm(CountryForm countryForm)
        {
            this.countryForm = countryForm;
            InitializeComponent();
            ApplyTheme();

            lbName.Text = Resources.Name;
            btnAdd.Text = Resources.Save;
            this.Text = Resources.Country;
        }

        protected override void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected override void ApplyTheme()
        {
            base.ApplyTheme();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlCountry mySqlCountry = new MySqlCountry();
            mySqlCountry.InsertCountry(tbName.Text);
            this.Close();
            countryForm.setData();
        }
    }
}
