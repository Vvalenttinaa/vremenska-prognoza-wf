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
    public partial class StationViewForm : BaseForm
    {
        public StationViewForm()
        {
            InitializeComponent();
            setData();

            btnEdit.Text = Resources.Edit;
            btnAdd.Text = Resources.Add;
            btnDelete.Text = Resources.Delete;
            this.Text = Resources.Station;


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

        public void setData()
        {
          
            lvStations.Items.Clear();
            tbID.Clear();
            MySqlWeatherStation mySqlStation = new MySqlWeatherStation();

            List<WeatherStation> stations = new List<WeatherStation>();
            stations = mySqlStation.GetWeatherStations();

            List<ListViewItem> array = new List<ListViewItem>();
            foreach (WeatherStation ws in stations)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = ws.ID;
                lvi.Text = ws.AddressDetails.ID.ToString();
            //    lvi.SubItems.Add(ws.ID.ToString());
                lvi.SubItems.Add(ws.AddressDetails.Street.ToString());
                lvi.SubItems.Add(ws.AddressDetails.Number.ToString());
                lvi.SubItems.Add(ws.AddressDetails.City.ToString());
                lvi.SubItems.Add(ws.AddressDetails.Country.ToString());
                array.Add(lvi);
            }
            lvStations.Items.AddRange(array.ToArray());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbID.Text != null)
            {
                FindAndSelectRowById(tbID.Text);
            }
        }

        private void FindAndSelectRowById(string targetId)
        {
            foreach (ListViewItem item in lvStations.Items)
            {
                string idValue = item.SubItems[0].Text;

                if (idValue == targetId)
                {
                    MySqlWeatherStation ws = new MySqlWeatherStation();
                    int id = ws.GetId(item.SubItems[1].Text, int.Parse(item.SubItems[2].Text), item.SubItems[3].Text);
                    if (ws.DeleteStationById(id))
                    {
                        MessageBox.Show("DELETED " + item.Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text);
                        lvStations.Items.Clear();
                        setData();
                    }
                    else
                    {
                        MessageBox.Show("CANT'T DELETE, BECAUSE VALUE IS USED ALREADY");
                    }
                    return;
                }
            }
            MessageBox.Show("Error.");
        }

        private void lvStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStations.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvStations.SelectedItems[0];
                tbID.Text = selectedItem.SubItems[0].Text;
            }
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            CountryForm countryForm = new CountryForm();
            countryForm.ShowDialog();
            this.Close();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            CitiesForm cityForm = new CitiesForm();
            cityForm.ShowDialog();
            this.Close();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            AdressesViewForm adressesViewForm = new AdressesViewForm();
            adressesViewForm.Show();
            this.Close();
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            StationViewForm st  = new StationViewForm();
            st.ShowDialog();    
            st.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployersView employersView = new EmployersView();
            employersView.Show();
            this.Close();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbID.Text != null && tbID.Text.Length > 0)
            {
                MySqlWeatherStation mySqlWeatherStation = new MySqlWeatherStation();
                
                int id = mySqlWeatherStation.GetIdByAddressId(int.Parse(tbID.Text));

                EditStation editStation = new EditStation(id, this);
                editStation.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStationForm addStationForm = new AddStationForm(this);
            addStationForm.ShowDialog();
        }
    }
}
