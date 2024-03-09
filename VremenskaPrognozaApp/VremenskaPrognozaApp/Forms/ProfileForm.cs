using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class ProfileForm : BaseForm
    {

        MySqlAccount mySqlAccount;
        MySqlEmployee mySqlEmployee;
        Account account = null;
        Admin1 admin1 = null;
        Meteorologist Meteorologist;

        public event EventHandler LanguageChanged;
        public event EventHandler ThemeChanged;

        public ProfileForm(Admin1 admin1, Meteorologist meteorologist)
        {
            InitializeComponent();

            if (admin1 != null)
            {
                this.admin1 = admin1;
            }
            else if (meteorologist != null)
            {
                this.Meteorologist = meteorologist;
            }

            mySqlAccount = new MySqlAccount();
            mySqlEmployee = new MySqlEmployee();

            lbfn.Text = Resources.FirstName + ":";
            lbsn.Text = Resources.SecondName + ":";
            lbr.Text = Resources.Role + ":";
            groupBox1.Text = Resources.Theme;
            groupBox2.Text = Resources.Language;
            btnEdit.Text = Resources.Edit;
            gbAccount.Text = Resources.Account;

            rb1.Text = Resources.Theme + "1";
            rb2.Text = Resources.Theme + "2";
            rb3.Text = Resources.Theme + "3";

            rbEn.Text = Resources.English;
            rbSr.Text = Resources.Serbian;

           
            this.Text = Resources.Profile;
            account = mySqlAccount.selectAccountById(Form1.AccountId);

            setValues();
            LoadTheme(filePath);
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
            
            if (account.Language == 1)
            {
                rbSr.Checked = true;
                CultureInfo newCulture = new CultureInfo("sr-SR");

                Thread.CurrentThread.CurrentUICulture = newCulture;
                Thread.CurrentThread.CurrentCulture = newCulture;
            }
            else
            {
                rbEn.Checked = true;
               
                CultureInfo newCulture = new CultureInfo("en-EN");

                Thread.CurrentThread.CurrentUICulture = newCulture;
                Thread.CurrentThread.CurrentCulture = newCulture;
            }

            if(account.Theme == 1)
            {
                rb1.Checked = true;
            }else if(account.Theme == 2)
            {
                rb2.Checked = true;
            }
            else { rb3.Checked = true; }
            
            String role = account.Role.ToString();
            if ("m".Equals(role))
            {
                lbRole.Text = "Metheorologist";
            }else if ("a".Equals(role))
            {
                lbRole.Text = "Admin";
            }

            Employee employee = mySqlEmployee.GetEmployeeByAccountId(Form1.AccountId);
            lbFirstName.Text = employee.FirstName;
            lbSecondName.Text = employee.LastName;
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            
           Application.Exit();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            SetTheme(1);
            rb2.Checked = false;
            rb3.Checked = false;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            SetTheme(2);
            rb1.Checked = false; rb3.Checked = false;
        }
        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            SetTheme(3);
            rb1.Checked = false;
            rb2.Checked = false;
        }

        private void SetTheme(int themeId)
        {
            account.Theme = themeId;
            mySqlAccount.updateAccount(account);
            OnThemeChanged(EventArgs.Empty);

            if(themeId == 1)
            {
                filePath = " C:\\Users\\user\\source\\repos\\VremenskaPrognozaApp\\VremenskaPrognozaApp\\Themes\\Theme1.xml";
            }
            else if(themeId==2)
            {
                filePath = "C:\\Users\\user\\source\\repos\\VremenskaPrognozaApp\\VremenskaPrognozaApp\\Themes\\Theme2.xml";
            }else if(themeId == 3)
            {
                filePath = "C:\\Users\\user\\source\\repos\\VremenskaPrognozaApp\\VremenskaPrognozaApp\\Themes\\Theme3.xml";
            }

            if (Meteorologist != null)
            {

                Meteorologist.UpdateTheme();
            }
            else if (admin1 != null)
            {
                admin1.UpdateTheme();
            }

            this.LoadTheme(filePath);
            this.ApplyTheme();
        }

        protected virtual void OnThemeChanged(EventArgs e)
        {
            ThemeChanged?.Invoke(this, new CustomEventArgs(EventType.ThemeChanged));
        }

        private void rbSr_CheckedChanged(object sender, EventArgs e)
        {
            rbEn.Checked = false;
            account.Language = 1;
            mySqlAccount.updateAccount(account);
            CultureInfo newCulture = new CultureInfo("sr-SR");

            Thread.CurrentThread.CurrentUICulture = newCulture;
            Thread.CurrentThread.CurrentCulture = newCulture;

            LoadTheme(filePath);
            ApplyTheme();

            lbfn.Text = Resources.FirstName + ":";
            lbsn.Text = Resources.SecondName + ":";
            lbr.Text = Resources.Role + ":";
            groupBox1.Text = Resources.Theme;
            groupBox2.Text = Resources.Language;
            btnEdit.Text = Resources.Edit;
            gbAccount.Text = Resources.Account;

            rb1.Text = Resources.Theme + "1";
            rb2.Text = Resources.Theme + "2";
            rb3.Text = Resources.Theme + "3";

            rbEn.Text = Resources.English;
            rbSr.Text = Resources.Serbian;


            this.Text = Resources.Profile;

            OnLanguageChanged(EventArgs.Empty);

            if (Meteorologist != null)
            {
                Meteorologist.changeLanguage();
            }
            else if (admin1 != null)
            {
                admin1.changeLanguage();
            }
        }

        private void rbEn_CheckedChanged(object sender, EventArgs e)
        {
            rbSr.Checked = false;
            account.Language = 2;
            mySqlAccount.updateAccount(account);
            CultureInfo newCulture = new CultureInfo("en-EN");

            Thread.CurrentThread.CurrentUICulture = newCulture;
            Thread.CurrentThread.CurrentCulture = newCulture;

            lbfn.Text = Resources.FirstName + ":";
            lbsn.Text = Resources.SecondName + ":";
            lbr.Text = Resources.Role + ":";
            groupBox1.Text = Resources.Theme;
            groupBox2.Text = Resources.Language;
            btnEdit.Text = Resources.Edit;
            gbAccount.Text = Resources.Account;

            rb1.Text = Resources.Theme + "1";
            rb2.Text = Resources.Theme + "2";
            rb3.Text = Resources.Theme + "3";

            rbEn.Text = Resources.English;
            rbSr.Text = Resources.Serbian;


            this.Text = Resources.Profile;

            OnLanguageChanged(EventArgs.Empty);
            if (Meteorologist != null)
            {
                Meteorologist.changeLanguage();
            }
            else if (admin1 != null)
            {
                admin1.changeLanguage();
            }
        }

        protected virtual void OnLanguageChanged(EventArgs e)
    {
        LanguageChanged?.Invoke(this, new CustomEventArgs(EventType.LanguageChanged));
    }

    private void btnEdit_Click(object sender, EventArgs e)
        {
            MySqlEmployee mySqlEmployee = new MySqlEmployee();
            Employee emp = mySqlEmployee.GetEmployeeById(Form1.EmployeeId);
            EditEmployee editEmployee = new EditEmployee(emp, this);
            editEmployee.ShowDialog();
            this.Close();
        }
    }
    public enum EventType
    {
        Generic,
        LanguageChanged,
        ThemeChanged
    }

    public class CustomEventArgs : EventArgs
    {
        public EventType EventType { get; }

        public CustomEventArgs(EventType eventType)
        {
            EventType = eventType;
        }
    }
}
