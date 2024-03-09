using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class EditStation : BaseForm
    {
        private readonly int idStation;
        private readonly StationViewForm stationViewForm;

        public EditStation(int idStation, StationViewForm stationViewForm)
        {
            InitializeComponent();
            this.idStation = idStation;
            this.stationViewForm = stationViewForm;
            btnCancel.Text = Resources.Cancel;
            btnSave.Text = Resources.Save;
            lbLocation.Text = Resources.Location;
            this.Text = Resources.Station;
            ApplyTheme();
            SetValues();
        }

        private void SetValues()
        {
            MySqlAddress mySqlAddress = new MySqlAddress();
            List<AddressDetails> addresses = mySqlAddress.GetAdresses();

            foreach (AddressDetails address in addresses)
            {
                // Create a combo box item with the address as the display text
                // and the ID as the tag (hidden value)
                AddressComboBoxItem item = new AddressComboBoxItem
                {
                    Text = address.ToString(),
                    Value = address.ID
                };

                // Add the item to the combo box
                cbLocation.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbLocation.SelectedItem is AddressComboBoxItem selectedAddress)
            {
                int selectedId = selectedAddress.Value;

                MySqlWeatherStation mySqlWeatherStation = new MySqlWeatherStation();
                mySqlWeatherStation.Update(selectedId, idStation);
                this.Close();
                stationViewForm.setData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected override void ApplyTheme()
        {
            base.ApplyTheme();
        }
    }

    public class AddressComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}