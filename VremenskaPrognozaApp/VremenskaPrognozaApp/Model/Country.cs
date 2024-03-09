using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognozaApp.Model
{
    internal class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Country country &&
                   ID == country.ID &&
                   Name == country.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
