using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.DataAccess
{
    internal interface ITemperature
    {
        List<Wind> GetTemperatures();
        void SaveTemperature(Wind temperature);
        void DeleteTemperatureById(int temperatureId);
    }
}
