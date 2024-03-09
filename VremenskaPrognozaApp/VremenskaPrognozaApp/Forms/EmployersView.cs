using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace VremenskaPrognozaApp.Forms
{
    public partial class EmployersView : BaseForm
    {
        List<Employee> employees;
        public EmployersView()
        {
            InitializeComponent();
            setData();
           
            btnDelete.Text = Resources.Delete;
            btnAdd.Text = Resources.Add;
            button1.Text = Resources.Edit;
            
            this.Text = Resources.Employee;
            ApplyTheme();
        }

        protected void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected void ApplyTheme()
        {
            base.ApplyTheme();
        }
        public void setData()
        {
            lvEmployees.Items.Clear();
            MySqlEmployee mySqlEmployee = new MySqlEmployee();
            employees = mySqlEmployee.GetAll();

            List<ListViewItem> array = new List<ListViewItem>();
            foreach (Employee e in employees)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = e.ID;
                lvi.Text = e.ID.ToString();
                lvi.SubItems.Add(e.FirstName.ToString());
                lvi.SubItems.Add(e.LastName.ToString());
                array.Add(lvi);
            }
            lvEmployees.Items.AddRange(array.ToArray());
        }

        private void FindAndSelectRowById(string targetId)
        {
            foreach (ListViewItem item in lvEmployees.Items)
            {
                string idValue = item.SubItems[0].Text;

                if (idValue == targetId)
                {
                    MySqlEmployee e = new MySqlEmployee();
                    
                    Employee employee = e.GetEmployeeById(int.Parse(idValue));
                    if (e.DeleteById(int.Parse(idValue)))
                    {
                        MessageBox.Show("DELETED " + item.Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text);
                        lvEmployees.Items.Clear();
                        setData();
                    }
                    else
                    {
                        MessageBox.Show("CANT'T DELETE, BECAUSE VALUE IS USED ALREADY");
                    }
                    return;
                }
            }
            MessageBox.Show("No item with ID " + targetId + " found.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbID.Text != null)
            {
                FindAndSelectRowById(tbID.Text);
            }
        }


        private void lvStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvEmployees.SelectedItems[0];
                tbID.Text = selectedItem.SubItems[0].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbID.Text != null && tbID.Text.Length > 0)
            {
                Employee employee = null;
                foreach (Employee emp in employees)
                {
                    if (emp.ID == (int.Parse(tbID.Text)))
                    {
                        employee = emp;
                        break;
                    }
                }
                EditEmployee editEmployee = new EditEmployee(employee);
                this.Close();
                editEmployee.ShowDialog();
            }
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            CitiesForm citiesForm = new CitiesForm();
            citiesForm.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm(this);
            form.ShowDialog();
        }
    }
}
