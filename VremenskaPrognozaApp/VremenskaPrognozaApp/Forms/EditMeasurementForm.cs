using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.Exceptions;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VremenskaPrognozaApp.Forms
{
    public partial class EditMeasurementForm : BaseForm
    {
        Measurement measurement;
        Temperature temperature;
        
        MySqlTemperature mySqlTemperature;

        public EditMeasurementForm(int id)
        {
            InitializeComponent();
            MySqlMeasurement mySqlMeasurement = new MySqlMeasurement();
            measurement = mySqlMeasurement.getMeasurenmentById(id);
            setValues();
            initializeData();
            
            cbInstrumentsLocation.DropDownStyle = ComboBoxStyle.Simple;
            cbInstrumentsLocation.Enabled = false;

            cbLocation.Enabled = false;
            cbLocation.DropDownStyle = ComboBoxStyle.Simple;

            lbTemp.Text = Resources.Temperature;
            lbInstrumentsAt.Text = Resources.Instruments;
        
            btnAdd.Text = Resources.AddMeasurement;
            btnCancel.Text = Resources.Cancel;
            btnAdd.Text = Resources.Add;
            lbAtLocation.Text = Resources.Location;
            lbInstrumentsAt.Text = Resources.Instruments;
            btnAdd.Text = Resources.Save;
            
            ApplyTheme();
        }

        protected void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected void ApplyTheme()
        {
            base.ApplyTheme();
        }
        private void initializeData()
        {
            mySqlTemperature = new MySqlTemperature();

            temperature = mySqlTemperature.getTemperatureById(measurement.ID);
            tbTemp.Text = temperature.Value.ToString();
            dateTimePicker1.Value = measurement.DateTime;
            cbLocation.Text = measurement.Address.ToString();
            cbInstrumentsLocation.Text = measurement.WeatherInstruments.ToString();
  
        }

        private void setValues()
        {
            setLoations();

            MySqlInstruments mySqlInstruments = new MySqlInstruments();
            List<WeatherInstruments> instruments = new List<WeatherInstruments>();

            instruments = mySqlInstruments.GetInstruments();

            foreach (WeatherInstruments instrument in instruments)
            {
                cbInstrumentsLocation.Items.Add(instrument.ToString());
            }

            MySqlPrecipitationName mySqlPrecipitationName = new MySqlPrecipitationName();
            List<PrecipitationName> precipitationNames = mySqlPrecipitationName.GetAll();

            

            MySqlWindName mySqlWindName = new MySqlWindName();
            List<WindName> windNames = new List<WindName>();
            windNames = mySqlWindName.GetAll();

           
        }

        private void setLoations()
        {

            MySqlAddress mySqlAddress = new MySqlAddress();
            List<AddressDetails> addresses = new List<AddressDetails>();

            addresses = mySqlAddress.GetAdresses();

            foreach (AddressDetails address in addresses)
            {
                cbLocation.Items.Add(address.ToString());
            }
        }
      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(int.Parse(tbTemp.Text) != temperature.Value)
            {
                MySqlTemperature mySqlTemperature = new MySqlTemperature();
                Temperature t = new Temperature();
                t.Value = int.Parse(tbTemp.Text);
                t.Measurenment = temperature.Measurenment;
                mySqlTemperature.Update(t);
            }

      

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbLocation_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}
