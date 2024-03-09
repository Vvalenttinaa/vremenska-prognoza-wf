using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class AddStationForm : BaseForm
    {
        StationViewForm station;
        public AddStationForm(StationViewForm stationViewForm)
        {
            InitializeComponent();
            setValues();
            ApplyTheme();

            this.Text = Resources.Station;
            lbLocation.Text = Resources.Location;
            btnAdd.Text = Resources.Save;
            btnCancel.Text = Resources.Cancel;
            this.station = stationViewForm;
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
            MySqlAddress mySqlAddress = new MySqlAddress();
            List<AddressDetails> addresses = new List<AddressDetails>();

            addresses = mySqlAddress.GetAdresses();

            foreach (AddressDetails address in addresses)
            {
                ComboBoxItem item = new ComboBoxItem(address.ToString(), address.ID);
                cbLocation.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlWeatherStation mySqlWeatherStation = new MySqlWeatherStation();
            if (cbLocation.SelectedItem is ComboBoxItem selectedAddress)
            {
                int id = selectedAddress.Value;
                mySqlWeatherStation.InsertWeatherStation(id);
            }
            station.setData();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; }
        public int Value { get; }

        public ComboBoxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}