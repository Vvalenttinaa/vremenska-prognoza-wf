using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognozaApp.Model
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public String Country { get; set; }

        public override bool Equals(object obj)
        {
            return obj is City city &&
                   ID == city.ID &&
                   Name == city.Name &&
                   Country == city.Country; 
        }

        public override int GetHashCode()
        {
            int hashCode = 1226553799;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Country);
            return hashCode;
        }
    }
}
