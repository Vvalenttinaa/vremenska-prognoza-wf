using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognozaApp.Model
{
    internal class WeatherStation
    {
        public int ID { get; set; }

        public AddressDetails AddressDetails { get; set; }

        public override bool Equals(object obj)
        {
            return obj is WeatherStation station &&
                   ID == station.ID &&
                   EqualityComparer<AddressDetails>.Default.Equals(AddressDetails, station.AddressDetails);
        }

        public override int GetHashCode()
        {
            int hashCode = -1202064557;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<AddressDetails>.Default.GetHashCode(AddressDetails);
            return hashCode;
        }

        public override string ToString()
        {
            return $"{ID}" +", " +  AddressDetails.ToString();
        }
    }
}
