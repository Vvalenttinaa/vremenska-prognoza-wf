using System;

using System.Globalization;

using System.Threading;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Forms;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp
{
    public partial class Form1 : BaseForm
    {
        public static string Username;
        public static int AccountId;
        public static int EmployeeId;
        public static Char Role;
        public static Boolean Logout;

        public Form1()
        {
            InitializeComponent();
            tbUsername.Click += tbUsername_Click;
            btnLogin.Text = Resources.Login;
           
            ApplyTheme();
            this.Text = Resources.Login;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
            public Form1(String username, String password)
        {
            InitializeComponent();
            tbUsername.Click += tbUsername_Click;
            btnLogin.Text = Resources.Login;
           
            ApplyTheme();
            this.Text = Resources.Login;
            tbPassword.Text = password;
            tbUsername.Text = username;
        }

        protected override void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected override void ApplyTheme()
        {
            base.ApplyTheme();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim(); 

            if(username != null &&  password != null) 
            {
                MySqlAccount mySqlAccount = new MySqlAccount();
                MySqlEmployee mySqlEmployee = new MySqlEmployee();
                Boolean exists = mySqlAccount.existsAccount(username, password);
                if (exists)
                {
                    Username = username;
                    AccountId = mySqlAccount.GetAccountId(username, password);
                    EmployeeId = mySqlEmployee.GetEmployeeByAccountId(AccountId).ID;
                    
                    Account a = mySqlAccount.selectAccountById(AccountId);
                    Role = a.Role;
                  
                    this.Hide();

                    if (a.Language == 1)
                    {
                        CultureInfo newCulture = new CultureInfo("sr-SR");
                        Thread.CurrentThread.CurrentUICulture = newCulture;
                        Thread.CurrentThread.CurrentCulture = newCulture;
                    }
                    else
                    {
                        CultureInfo newCulture = new CultureInfo("en-EN");
                        Thread.CurrentThread.CurrentUICulture = newCulture;
                        Thread.CurrentThread.CurrentCulture = newCulture;
                    }

                    if (a.Theme == 1)
                    {
                        filePath = "C:\\Users\\user\\source\\repos\\VremenskaPrognozaApp\\VremenskaPrognozaApp\\Themes\\Theme1.xml";

                    }
                    else if (a.Theme == 2)
                    {
                        filePath = "C:\\Users\\user\\source\\repos\\VremenskaPrognozaApp\\VremenskaPrognozaApp\\Themes\\Theme2.xml";

                    }
                    else if (a.Theme == 3)
                    {
                        filePath = "C:\\Users\\user\\source\\repos\\VremenskaPrognozaApp\\VremenskaPrognozaApp\\Themes\\Theme3.xml";

                    }
                    LoadTheme(filePath);

                    if (Role == 'm')
                    {
                        Meteorologist metheorologistForm = new Meteorologist();
                        metheorologistForm.Show();
                    }
                    else if(Role == 'a')
                    {
                        Admin1 adminForm = new Admin1();
                        adminForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("The account " + username + " doesn't exist in the database.");
                }
            }
        }

        private bool isClicked = false;
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (isClicked)
            {
                tbPassword.PasswordChar = '*';
                isClicked = !isClicked;
            }
            else
            {
                tbPassword.PasswordChar = '\0';
                isClicked = !isClicked;
            }

        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbPassword.Text = "";
                tbUsername.ForeColor = System.Drawing.Color.Black;
                tbPassword.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}
