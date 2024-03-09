using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognozaApp.Model
{
    public class Precipitation
    {
        public Measurement Measurement { get; set; }
        public String Name { get; set; }
        public String Probability { get; set; }
        public String Amount { get; set; }
        public String Description { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Precipitation precipitation &&
                   EqualityComparer<Measurement>.Default.Equals(Measurement, precipitation.Measurement) &&
                   Name == precipitation.Name &&
                   Probability == precipitation.Probability &&
                   Amount == precipitation.Amount &&
                   Description == precipitation.Description;
        }

        public override int GetHashCode()
        {
            int hashCode = 1244145967;
            hashCode = hashCode * -1521134295 + EqualityComparer<Measurement>.Default.GetHashCode(Measurement);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Probability);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Amount);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            return hashCode;
        }
    }
}
