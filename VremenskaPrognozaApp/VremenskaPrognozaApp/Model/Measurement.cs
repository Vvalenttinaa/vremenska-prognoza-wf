using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognozaApp.Model
{
    public class Measurement  
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public Employee Employee { get; set; }
        public AddressDetails Address { get; set; }
        public WeatherInstruments WeatherInstruments { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Measurement measurement &&
                   ID == measurement.ID &&
                   DateTime == measurement.DateTime;
        }

        public override int GetHashCode()
        {
            int hashCode = -465500432;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + DateTime.GetHashCode();
            return hashCode;
        }
    }
}
