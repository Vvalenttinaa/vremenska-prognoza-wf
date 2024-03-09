using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class AddEmployeeForm : BaseForm
    {
        EmployersView employersView;
        public AddEmployeeForm(EmployersView employersView)
        {
            InitializeComponent();
            setValues();
            this.employersView = employersView;

            lbFirstName.Text = Resources.FirstName;
            lbSecondName.Text = Resources.SecondName;
            lbRole.Text = Resources.Role;
            lbPassword.Text = Resources.Password;
            lbStation.Text = Resources.Station;
            lbUsername.Text = Resources.Username;

            btnCancel.Text = Resources.Cancel;
            btnSave.Text = Resources.Save;

            this.Text = Resources.Employee;

            ApplyTheme();
        }

        protected override void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected override void ApplyTheme()
        {
            base.ApplyTheme();
        }

        private void setValues()
        {
            MySqlWeatherStation mySqlWeatherStation = new MySqlWeatherStation();
            List<WeatherStation> weatherStations = mySqlWeatherStation.GetWeatherStations();

            foreach (WeatherStation weatherStation in weatherStations)
            {
                ComboBoxStation item = new ComboBoxStation
                {
                    Text = weatherStation.AddressDetails.ToString(),
                    Value = weatherStation.ID
                };

                cbMetheorologistStation.Items.Add(item);
            }
        }

        private void btnAdd(object sender, EventArgs e)
        {
            char Rolee = '0';
            string selectedRole = cbRole.SelectedItem.ToString();

            if (selectedRole == "Admin")
            {
                Rolee = 'a';
            }
            else if (selectedRole == "Metheorologist")
            {
                Rolee = 'm';
            }

            if (cbMetheorologistStation.SelectedItem is ComboBoxStation selectedStation)
            {
                Account account = new Account()
                {
                    Username = tbUsername.Text,
                    Password = tbPassword.Text,
                    Role = Rolee,
                };

                MySqlAccount mySqlAccount = new MySqlAccount();
                bool exists = mySqlAccount.existsAccount(account.Password, account.Username);

                if (exists)
                {
                    MessageBox.Show("Account already exists!");
                }
                else
                {
                    int accountId = mySqlAccount.insertAccount(account);

                    Employee emp = new Employee()
                    {
                        FirstName = tbFirstName.Text,
                        LastName = tbSecondName.Text,
                        weatherStationId = selectedStation.Value,
                        accountId = accountId
                    };

                    MySqlEmployee mySqlEmployee = new MySqlEmployee();
                    mySqlEmployee.insertEmployee(emp);
                    employersView.setData();
                }
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ComboBoxStation
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
