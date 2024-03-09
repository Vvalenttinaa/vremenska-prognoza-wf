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

namespace VremenskaPrognozaApp.Forms
{
    public partial class AdressesViewForm : BaseForm
    {
        public AdressesViewForm()
        {
            InitializeComponent();
            setData();

            btnAdd.Text = Resources.Add;
            btnDelete.Text = Resources.Delete;
            this.Text = Resources.Address;

            ApplyTheme();
        }

        public void setData()
        {
            lvAddresses.Items.Clear();
            tbID.Clear();
            
            MySqlAddress mySqlAddress = new MySqlAddress();
            List<AddressDetails> addresses = new List<AddressDetails>();
            addresses = mySqlAddress.GetAdresses();

            List<ListViewItem> array = new List<ListViewItem>();
            foreach (AddressDetails ad in addresses)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = ad.ID;
                lvi.Text = ad.Street;
                lvi.SubItems.Add(ad.Number.ToString());
                lvi.SubItems.Add(ad.City.ToString());
                lvi.SubItems.Add(ad.Country.ToString());
                lvi.SubItems.Add(ad.ID.ToString());
                array.Add(lvi);
            }
            lvAddresses.Items.AddRange(array.ToArray());
        }

        private void lvAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAddresses.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvAddresses.SelectedItems[0];
                tbID.Text = selectedItem.SubItems[4].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(tbID.Text != null)
            {
                FindAndSelectRowById(tbID.Text);
            }
        }

        private void FindAndSelectRowById(string targetId)
        {
        foreach (ListViewItem item in lvAddresses.Items)
            {
            string idValue = item.SubItems[4].Text;

                if (idValue == targetId)
                {
                    MySqlAddress mySqlAddress = new MySqlAddress();
                    int id = mySqlAddress.GetId(item.Text, int.Parse(item.SubItems[1].Text), item.SubItems[2].Text);
                    if (mySqlAddress.DeleteAddressById(id))
                    {
                        MessageBox.Show("DELETED " + item.Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text);
                        lvAddresses.Items.Clear();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAddress addAddressForm = new AddAddress(this);
            addAddressForm.ShowDialog();
        }

        protected override void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected override void ApplyTheme()
        {
            base.ApplyTheme();
        }

        
    }
}
