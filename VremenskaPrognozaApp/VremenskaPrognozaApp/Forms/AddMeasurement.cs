using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class AddMeasurement : BaseForm
    {
        Measurement measurement;

        public AddMeasurement()
        {
            InitializeComponent();
            setValues();
            lbUsername.Text = Form1.Username;
            measurement = new Measurement();
            windControlsDisable();
            precipitationControlsDisable();
            lbName.Text = Resources.Name;
            lbProbability.Text = Resources.Probability;
            lbDescription.Text = Resources.Description;
            lbTemp.Text = Resources.Temperature;
            lbInstrumentsAt.Text = Resources.Instruments;
            lbName.Text = Resources.Name;
            lbAmount.Text = Resources.Amount;
            lbWindDescription.Text = Resources.Description;
            lbWindDirection.Text = Resources.Direction;
            lbWindName.Text = Resources.Name;
            lbWindStrength.Text = Resources.Strength;
            
            cbWind.Text = Resources.Wind;
            cbWindName.Text = Resources.Name;
            cbPrecipitation.Text = Resources.Precipitation;
            cbPrecName.Text = Resources.Name;
            btnAdd.Text = Resources.AddMeasurement;
            btnCancel.Text = Resources.Cancel;
            btnAdd.Text = Resources.Add;
            lbAtLocation.Text = Resources.Location;
            lbInstrumentsAt.Text = Resources.Instruments;

            this.Text = Resources.AddMeasurement;

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

        private void setValues()
        {
            setLoations();
            setInstrumentLocations();

            /*
            MySqlInstruments mySqlInstruments = new MySqlInstruments();
            List<WeatherInstruments> instruments = new List<WeatherInstruments>();

            instruments = mySqlInstruments.GetInstruments();

            foreach (WeatherInstruments instrument in instruments)
            {
                cbInstrumentsLocation.Items.Add(instrument.AddressDetails.ToString());
            }
            */

            MySqlPrecipitationName mySqlPrecipitationName = new MySqlPrecipitationName();
            List<PrecipitationName> precipitationNames = mySqlPrecipitationName.GetAll();

            foreach (PrecipitationName name in precipitationNames)
            {
                cbPrecName.Items.Add(name.Name.ToString());
            }

            MySqlWindName mySqlWindName = new MySqlWindName();
            List<WindName> windNames = new List<WindName>();
            windNames = mySqlWindName.GetAll();

            foreach(WindName windName in windNames)
            {
                cbWindName.Items.Add(windName.Name.ToString());
            }

            cbWindName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrecName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void setLoations()
        {

            MySqlAddress mySqlAddress = new MySqlAddress();
            List<AddressDetails> addresses = new List<AddressDetails>();
            addresses = mySqlAddress.GetAdresses();

            foreach (AddressDetails addressDetails in addresses)
            {
                ComboBoxAddress item = new ComboBoxAddress
                {
                    Text = addressDetails.ToString(),
                    Value = addressDetails.ID
                };
                cbLocation.Items.Add(item);
            }
        }

        private void setInstrumentLocations()
        {
            MySqlInstruments mySqlInstruments = new MySqlInstruments();
            List<WeatherInstruments> instruments = mySqlInstruments.GetInstruments();

            foreach (WeatherInstruments weatherInstruments in instruments)
            {
                ComboBoxAddress item = new ComboBoxAddress
                {
                    Text = weatherInstruments.AddressDetails.ToString(),
                    Value = weatherInstruments.ID
                };
                cbInstrumentsLocation.Items.Add(item);
            }
        }

        private void windControlsDisable()
        {
            cbWindName.Enabled = false;
            tbWindDescription.Enabled = false;
            tbWindDirection.Enabled = false;
            tbWindStrength.Enabled = false;
        }

        private void windControlsEnable()
        {
            cbWindName.Enabled = true;
            tbWindDescription.Enabled = true;
            tbWindDirection.Enabled = true;
            tbWindStrength.Enabled = true;
        }

        private void precipitationControlsDisable()
        {
            cbPrecName.Enabled = false;
            tbPrecDescription.Enabled = false;
            tbPrecProbability.Enabled = false;
            tbPrecAmount.Enabled = false;
            
        }

        private void precipitationControlsEnable()
        {
            cbPrecName.Enabled = true;
            tbPrecDescription.Enabled = true;
            tbPrecProbability.Enabled = true;
            tbPrecAmount.Enabled = true;
        }


        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocation.SelectedItem is ComboBoxAddress selectedAddress)
            {
                MySqlAddress mySqlAddress = new MySqlAddress();
                measurement.Address = mySqlAddress.GetAddressById(selectedAddress.Value);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbTemp!= null && dateTimePicker1.Value!= null && cbInstrumentsLocation!=null && cbLocation != null)
            {
                MySqlMeasurement sqlMeasurement = new MySqlMeasurement();
                int id = sqlMeasurement.InsertMeasurement(measurement.Address.ID, Form1.EmployeeId, measurement.WeatherInstruments.ID, measurement.DateTime);
                
                MySqlTemperature mySqlTemperature = new MySqlTemperature();
                mySqlTemperature.InsertTemperature(new Temperature() { Measurenment = sqlMeasurement.getMeasurenmentById(id), Value = int.Parse(tbTemp.Text) });

                if (cbWind.Checked)
                {
                    if(cbWindName!=null && tbWindDirection!=null && tbWindStrength != null)
                    {
                        Wind wind = new Wind();
                        wind.Strength = tbWindStrength.Text;
                        wind.Direction = tbWindDirection.Text;
                        wind.Description = tbWindDescription.Text;
                        wind.Name = cbWindName.Text;

                        wind.Measurement = sqlMeasurement.getMeasurenmentById(id);

                        MySqlWind mySqlWind = new MySqlWind();
                        mySqlWind.InsertWind(wind);
                    }
                    else
                    {
                        MessageBox.Show("Please insert all details about wind!");
                    }
                }

                if(cbPrecipitation.Checked)
                {
                    if(cbPrecName != null && tbPrecProbability != null && tbPrecAmount != null)
                    {
                        Precipitation precipitation = new Precipitation();
                        precipitation.Probability = tbPrecProbability.Text;
                        precipitation.Description = tbPrecDescription.Text;
                        precipitation.Amount = tbPrecAmount.Text;
                        precipitation.Name = cbPrecName.Text;
                        precipitation.Measurement = sqlMeasurement.getMeasurenmentById(id);

                        MySqlPrecipitation mySqlPrecipation = new MySqlPrecipitation();
                        mySqlPrecipation.Insert(precipitation);
                    }
                    else
                    {
                        MessageBox.Show("Please insert all details about precipitation!");
                    }
                }
            }
        }

        private void cbInstrumentsLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbInstrumentsLocation.SelectedItem is ComboBoxAddress selectedAddress)
            {
                MySqlInstruments mySqlInstruments = new MySqlInstruments();
                measurement.WeatherInstruments = mySqlInstruments.GetInstrumentsById(selectedAddress.Value);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbWind_CheckedChanged(object sender, EventArgs e)
        {
            if(cbWind.Checked)
            {
                windControlsEnable();
            }
            else
            {
                windControlsDisable();
            }
        }

        private void cbPrecipitation_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPrecipitation.Checked)
            {
                precipitationControlsEnable();
            }
            else
            {
                precipitationControlsDisable();
            }
        }

        private void cbLocation_Clicked(object sender, EventArgs e)
        {
            setLoations();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            measurement.DateTime = dateTimePicker1.Value;
        }

    }
    public class ComboBoxAddress
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
