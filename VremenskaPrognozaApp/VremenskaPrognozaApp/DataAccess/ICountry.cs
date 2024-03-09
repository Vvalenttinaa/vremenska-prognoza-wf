using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.DataAccess
{
    internal interface ICountry
    {
        List<Country> GetCountries();
        void SaveCountry(Country country);
        void DeleteCountryById(int countryId);
    }
}
