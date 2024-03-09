using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VremenskaPrognozaApp.Model
{
    internal class Account
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public char Role { get; set; }

        public int Language { get; set; }
        public int Theme { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Account account &&
                   ID == account.ID &&
                   Username == account.Username &&
                   Password == account.Password &&
                   Role == account.Role;
        }

        public override int GetHashCode()
        {
            int hashCode = -354974740;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + Role.GetHashCode();
            return hashCode;
        }
    }
}
