using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognozaApp.Model
{
    public class Address
    {
        public int ID { get; set; }
        public string StreetName { get; set; }
        public int Number { get; set; }
        public int CityId { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Address address &&
                   ID == address.ID &&
                   StreetName == address.StreetName &&
                   Number == address.Number &&
                   CityId == address.CityId;
        }

       
    }
}
