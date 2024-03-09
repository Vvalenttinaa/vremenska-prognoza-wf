using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.DataAccess.MySql
{
    public partial class MeasurementDetails : Forms.BaseForm
    {
        public MeasurementDetails(Measurement measurement)
        {
            InitializeComponent();

            MySqlWind mySqlWind = new MySqlWind();
            MySqlWindName mySqlWindName = new MySqlWindName();
            MySqlPrecipitation mySqlPrecipitation = new MySqlPrecipitation();
            MySqlPrecipitationName mySqlPrecipitationName = new MySqlPrecipitationName();
            MySqlAddress mySqlAddress = new MySqlAddress();
            MySqlTemperature mySqlTemperature = new MySqlTemperature();
            if (mySqlTemperature.getTemperatureById(measurement.ID) != null)
            {
                lbTemperature.Text = mySqlTemperature.getTemperatureById(measurement.ID).Value.ToString() + "°C";
            }

            lbAtLocation.Text = measurement.Address.ToString().Replace(",", "," + Environment.NewLine);
          /*  if (mySqlAddress.GetAddressById(measurement.ID) != null)
            {
                String adr = mySqlAddress.GetAddressById(measurement.ID).ToString();
                lbAtLocation.Text = adr;
                int index = adr.IndexOf('-');

                if (index != -1 && index + 1 < adr.Length)
                {
                    string substring = adr.Substring(index + 1);
                    lbAtLocation.Text = substring;
                }
              */
          //  }
            lbDataAndTime.Text = measurement.DateTime.Date.ToString("d");

            if(mySqlWind.getWindById(measurement.ID) != null)
            {
                Wind wind = mySqlWind.getWindById(measurement.ID);
                lbWindName.Text = wind.Name;
                lbWindDirection.Text = wind.Direction;
                lbWindDescription.Text = wind.Description;
                lbWindStrength.Text = wind.Strength + "km/h";
            }
            else
            {
                lbWindName.Text = "x";
                lbWindDirection.Text = "x";
                lbWindDescription.Text = "x";
                lbWindStrength.Text = "x";
            }
            if(mySqlPrecipitation.getById(measurement.ID) != null)
            {
                Precipitation precipitation = mySqlPrecipitation.getById(measurement.ID);
                lbPrecAmount.Text = precipitation.Amount + "l/m";
                lbPrecDescription.Text = precipitation.Description;
                lbPrecProbability.Text = precipitation.Probability + "%";
                lbPrecName.Text = precipitation.Name;

                if (precipitation.Name.Equals("kisa") || precipitation.Name.Equals("Kisa"))
                {
                    System.Drawing.Image image = Properties.Resources.rain;
                    pictureBox.Image = image;
                }else if (precipitation.Name.Equals("Snijeg") || precipitation.Name.Equals("snijeg"))
                { 
                    System.Drawing.Image image = Properties.Resources.snow;
                    pictureBox.Image = image;
                }
            }
            else
            {
                System.Drawing.Image image = Properties.Resources.sun;
                pictureBox.Image = image;
                lbPrecAmount.Text = "x";
                lbPrecDescription.Text = "x";
                lbPrecProbability.Text = "x";
                lbPrecName.Text = "x";

            }
            lbWW.Text = Resources.WeatherWatchful;
            
            lbWDescription.Text = Resources.Description + ": ";
            lbWdirection.Text = Resources.Direction + ": ";
            lbWname.Text = Resources.Name + ": ";
            lbWStrength.Text = Resources.Strength + ": ";
            lbPAmount.Text = Resources.Amount + ": ";
            lbPDescription.Text = Resources.Description + ": ";
            lbPName.Text = Resources.Name + ": ";
            lbPProbability.Text = Resources.Probability + ": ";
            lbAtLoc.Text = Resources.Location + ": ";
            lbWind.Text = Resources.Wind + ": ";
            lbPrec.Text = Resources.Precipitation + ": ";
            lbData.Text = Resources.DataAndTime + ": ";
           
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

        private void MeasurementDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
