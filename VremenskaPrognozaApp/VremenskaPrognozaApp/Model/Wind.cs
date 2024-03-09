using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognozaApp.Model
{
    public class Wind
    {
        public Measurement Measurement { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Direction { get; set; }
        public string Strength { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Wind wind &&
                   EqualityComparer<Measurement>.Default.Equals(Measurement, wind.Measurement) &&
                   Name == wind.Name &&
                   Description == wind.Description &&
                   Direction == wind.Direction &&
                   Strength == wind.Strength;
        }

        public override int GetHashCode()
        {
            int hashCode = -233748740;
            hashCode = hashCode * -1521134295 + EqualityComparer<Measurement>.Default.GetHashCode(Measurement);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Direction);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Strength);
            return hashCode;
        }
    }
}
