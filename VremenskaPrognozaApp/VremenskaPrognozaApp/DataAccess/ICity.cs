using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.DataAccess
{
    internal interface ICity
    {
        List<City> GetCites();
        void SaveCity(City city);
        void DeleteCityById(int cityId);
    }
}
