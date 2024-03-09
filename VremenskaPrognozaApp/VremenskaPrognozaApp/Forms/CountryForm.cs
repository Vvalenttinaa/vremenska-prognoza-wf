using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class CountryForm : BaseForm
    {
        public CountryForm()
        {
            InitializeComponent();
            setData();

            btnEdit.Text = Resources.Edit;
            btnAdd.Text = Resources.Add;
            btnDelete.Text = Resources.Delete;

            ApplyTheme();

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

        public void setData()
        {
            lwCountries.Items.Clear();
            tbIDCountry.Clear();
            MySqlCountry mySqlCountry = new MySqlCountry();

            List<Country> countries = new List<Country>();
            countries = mySqlCountry.GetCountries();

            List<ListViewItem> array = new List<ListViewItem>();
            foreach (Country country in countries)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = country.ID;
                lvi.Text = country.ID.ToString();
                lvi.SubItems.Add(country.Name.ToString());
                array.Add(lvi);
            }
            lwCountries.Items.AddRange(array.ToArray());
        }

        private void lwCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwCountries.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lwCountries.SelectedItems[0];
                tbIDCountry.Text = selectedItem.SubItems[0].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbIDCountry.Text != null)
            {
                FindAndSelectRowById(tbIDCountry.Text);
            }
        }

        private void FindAndSelectRowById(string targetId)
        {
            foreach (ListViewItem item in lwCountries.Items)
            {
                string idValue = item.SubItems[0].Text;

                if (idValue == targetId)
                {
                    MySqlCountry mySqlCountry = new MySqlCountry();
                    int id = mySqlCountry.GetCountryIdByName(item.SubItems[1].Text);
                    if (mySqlCountry.DeleteCountryById(id))
                    {
                        MessageBox.Show("DELETED "  + item.SubItems[1].Text);
                        lwCountries.Items.Clear();
                        setData();
                    }
                    else
                    {
                        MessageBox.Show("CANT'T DELETE, BECAUSE VALUE IS USED ALREADY");
                    }
                    return;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(tbIDCountry.Text != null && tbIDCountry.Text.Length > 0 )
            {
                MySqlCountry mySqlCountry = new MySqlCountry();
                String country = mySqlCountry.GetCountryNameById(int.Parse(tbIDCountry.Text));

                EditCountry editCountry = new EditCountry(country, this);
                editCountry.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCountryForm addCountryForm = new AddCountryForm(this);
            addCountryForm.ShowDialog();
        }
    }
}
