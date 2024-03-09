using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class EditAddressForm : BaseForm
    {
        AdressesViewForm adressesViewForm;
        AddressDetails address;

        public EditAddressForm(AddressDetails address, AdressesViewForm adressesViewForm)
        {
            InitializeComponent();
            this.address = address;
            this.adressesViewForm = adressesViewForm;
            btnCancel.Text = Resources.Cancel;
            btnSave.Text = Resources.Save;
            lbCountry.Text = (Resources.Country.ToUpper());
            lbCity.Text = Resources.City.ToUpper();
            lbNumber.Text = Resources.Number.ToUpper();
            lbStreet.Text = Resources.Street.ToUpper();

            ApplyTheme();

            this.Text = Resources.Address;
        }

        protected override void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected override void ApplyTheme()
        {
            base.ApplyTheme();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
