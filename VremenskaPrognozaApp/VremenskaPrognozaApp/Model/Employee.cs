using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognozaApp.Model
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int weatherStationId { get; set; }
        public int accountId { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   ID == employee.ID &&
                   FirstName == employee.FirstName &&
                   LastName == employee.LastName &&
                  weatherStationId == employee.weatherStationId &&
                  accountId == employee.accountId;
        }

        public override int GetHashCode()
        {
            int hashCode = 828976297;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + LastName.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + ID + " " + weatherStationId + " " + accountId ;
        }
    }
}
