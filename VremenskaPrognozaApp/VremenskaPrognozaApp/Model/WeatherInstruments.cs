using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognozaApp.Model
{
    public class WeatherInstruments
    {
        public int ID { get; set; }
        public AddressDetails AddressDetails { get; set; }
        public int WeatherStation { get; set; }

        public override bool Equals(object obj)
        {
            return obj is WeatherInstruments instruments &&
                   ID == instruments.ID &&
                   AddressDetails == instruments.AddressDetails &&
                   WeatherStation == instruments.WeatherStation;
        }

        public override int GetHashCode()
        {
            int hashCode = 583039319;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + AddressDetails.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return ID + " - " +  AddressDetails.ToString();
        }
    }
}
