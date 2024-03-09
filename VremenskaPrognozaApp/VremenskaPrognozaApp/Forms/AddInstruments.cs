using System;
using System.Collections.Generic;

using System.Text.RegularExpressions;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class AddInstruments : Form
    {
        int addressId;
        int stationId;

        public AddInstruments()
        {
            InitializeComponent();
            setValues();

            this.Text = Resources.Instruments;
            lbAddress.Text = Resources.Address;
            lbStation.Text = Resources.Station;
            btnAdd.Text = Resources.Save;
            btnCancel.Text = Resources.Cancel;
        }

        private void setValues()
        {
            MySqlAddress mySqlAddress = new MySqlAddress();
            List<AddressDetails> addresses = new List<AddressDetails>();

            addresses = mySqlAddress.GetAdresses();

            foreach (AddressDetails address in addresses)
            {
                cbAddress.Items.Add(address.ToString());
            }

            MySqlWeatherStation mySqlWeatherStation = new MySqlWeatherStation();
            List<WeatherStation> stations = new List<WeatherStation>();
            stations = mySqlWeatherStation.GetWeatherStations();
            foreach(WeatherStation station in stations)
            {
                cbStation.Items.Add(station.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbAddress!= null && cbStation != null)
            {
                MySqlInstruments mySqlInstruments = new MySqlInstruments();
                mySqlInstruments.InsertInstruments(addressId, stationId);
                this.Close();
            }
        }

        private void cbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            addressId = GetFirstNumber(cbAddress.Text);

        }
        static int GetFirstNumber(string input)
        {
            string pattern = @"\d+";
            Match match = Regex.Match(input, pattern);
            if (match.Success && int.TryParse(match.Value, out int number))
            {
                return number;
            }
            else
            {
                return 0;
            }
        }

        private void cbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            stationId = GetFirstNumber(cbStation.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
