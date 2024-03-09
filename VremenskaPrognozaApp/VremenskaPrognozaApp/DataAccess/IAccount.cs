using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.DataAccess
{
    internal interface IAccount
    {
        Boolean existsAccount(string password, string username, string role);
    }
}
