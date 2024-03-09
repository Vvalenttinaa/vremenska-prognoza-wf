using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognozaApp.Model
{
    public class AddressDetails
    {
        public int ID;
        public string Street;
        public int Number;
        public string City;
        public string Country;

        public override bool Equals(object obj)
        {
            return obj is AddressDetails details &&
                   ID == details.ID &&
                   Street == details.Street &&
                   Number == details.Number &&
                   City == details.City &&
                   Country == details.Country;
        }

        public override int GetHashCode()
        {
            int hashCode = 532656689;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Street);
            hashCode = hashCode * -1521134295 + Number.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Country);
            return hashCode;
        }

        public override string ToString()
        {
            return  $"{Street}" + ", "+ $"{Number}" +", " + $"{City}" +", "+ $"{Country}";
        }
    }
}
