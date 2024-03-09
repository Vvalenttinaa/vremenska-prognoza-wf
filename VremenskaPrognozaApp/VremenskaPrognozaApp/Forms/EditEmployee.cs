using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VremenskaPrognozaApp.DataAccess;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class EditEmployee : BaseForm
    {
        String firstName = null;
        String secondName = null;
        int ID;
        int stationId;
        int accountId;

        ProfileForm profileForm;

        public EditEmployee(Employee e)
        {
            InitializeComponent();
           
            tbFirstName.Text = e.FirstName;
            tbSecondName.Text = e.LastName;

            firstName = e.FirstName;
            secondName = e.LastName;
            ID = e.ID;
            stationId = e.weatherStationId;
            accountId = e.accountId;

            lbFirstName.Text = Resources.FirstName;
            lbSecondName.Text = Resources.SecondName;
            btnCancel.Text = Resources.Cancel;
            btnSave.Text = Resources.Save;

            this.Text = Resources.Employee;

            ApplyTheme();
        }

        public EditEmployee(Employee e, ProfileForm profileForm
            )
        {
            InitializeComponent();

            tbFirstName.Text = e.FirstName;
            tbSecondName.Text = e.LastName;

            firstName = e.FirstName;
            secondName = e.LastName;
            ID = e.ID;
            stationId = e.weatherStationId;
            accountId = e.accountId;

            lbFirstName.Text = Resources.FirstName;
            lbSecondName.Text = Resources.SecondName;
            btnCancel.Text = Resources.Cancel;
            btnSave.Text = Resources.Save;

            this.Text = Resources.Employee;

            ApplyTheme();
            this.profileForm = profileForm;
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
            if (!firstName.Equals(tbFirstName.Text) || !secondName.Equals(tbSecondName.Text))
            {
                Employee emp = 
                    new Employee();
                emp.FirstName = tbFirstName.Text;
                emp.LastName = tbSecondName.Text;
                emp.ID = ID;

                emp.weatherStationId = stationId;
                emp.accountId = accountId;


                MySqlEmployee mySqlEmployee = new MySqlEmployee();
                mySqlEmployee.Update(emp);

                this.Close();
                
                profileForm.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            profileForm.Show();
        }
    }
}
