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
    public partial class CitiesForm :BaseForm
    {
        List<City> cities;
        GroupBox activeGroup;
        public CitiesForm()
        {
            InitializeComponent();
            setData();

            btnEdit.Text = Resources.Edit;
            btnAdd.Text = Resources.Add;
            btnDelete.Text = Resources.Delete;

            ApplyTheme();

            this.Text = Resources.City;
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
            tbIDCity.Clear();

            MySqlCity mySqlCity = new MySqlCity();

            cities = new List<City>();
            cities = mySqlCity.GetCities1();

            List<ListViewItem> array = new List<ListViewItem>();
            foreach (City city in cities)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = city.ID;
                lvi.Text = city.ID.ToString();
                //    lvi.SubItems.Add(ws.ID.ToString());
                lvi.SubItems.Add(city.Name.ToString());
                lvi.SubItems.Add(city.Country.ToString());
                array.Add(lvi);
            }
            lwCountries.Items.AddRange(array.ToArray());
        }

        private void lwCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwCountries.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lwCountries.SelectedItems[0];
                tbIDCity.Text = selectedItem.SubItems[0].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbIDCity.Text != null)
            {
                FindAndSelectRowById(tbIDCity.Text);
            }
        }

        private void FindAndSelectRowById(string targetId)
        {
            foreach (ListViewItem item in lwCountries.Items)
            {
                string idValue = item.SubItems[0].Text;

                if (idValue == targetId)
                {
                    MySqlCity mySqlCity = new MySqlCity();
                    int id = mySqlCity.GetId(item.SubItems[1].Text);
                    if (mySqlCity.DeleteCityById(id))
                    {
                        MessageBox.Show("DELETED " + item.Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text);
                        setData();
                    }
                    else
                    {
                        MessageBox.Show("CANT'T DELETE, BECAUSE VALUE IS USED ALREADY");
                    }
                    return;
                }
            }
            MessageBox.Show("No item with ID " + targetId + " found.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(tbIDCity.Text != null && tbIDCity.Text.Length > 0)
            {
                City city = null;
                foreach(City c in cities)
                {
                    if (c.ID == (int.Parse(tbIDCity.Text)))
                    {
                        city = c;
                        break;
                    }
                }
                EditCity editCity = new EditCity(city, this);
                editCity.ShowDialog();

            }
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            CountryForm countryForm = new CountryForm();
            countryForm.ShowDialog();
            this.Close();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            AdressesViewForm addressViewForm = new AdressesViewForm();
            addressViewForm.ShowDialog();
            this.Close();

        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            this.Close();
            StationViewForm stationViewForm = new StationViewForm();
            stationViewForm.ShowDialog();
            

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployersView employersView = new EmployersView();
            employersView.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCity addCity = new AddCity(this);
            addCity.ShowDialog();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.AccountId = 0;
            Form1.EmployeeId = 0;
            Form1.Username = null;

            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
