using System;
using System.Collections.Generic;

using System.Windows.Forms;
using VremenskaPrognozaApp.DataAccess.MySql;
using VremenskaPrognozaApp.Model;

namespace VremenskaPrognozaApp.Forms
{
    public partial class MeasurementsForm : BaseForm
    {
        Measurement measurement;
        MySqlMeasurement mySqlMeasurement = new MySqlMeasurement();
        String choice;
        

        public MeasurementsForm()
        {
            InitializeComponent();
            setData();
            
            btnDetails.Text = Resources.Details;
            this.Text = Resources.Measurement;
            ApplyTheme();

            cbMeasurements.DropDownStyle = ComboBoxStyle.DropDownList;
            btnDetails.Text = Resources.Details;
        //    btnEdit.Text = Resources.Edit;

        }
        protected override void LoadTheme(string themeFilePath)
        {
            base.LoadTheme(themeFilePath);
        }

        protected override void ApplyTheme()
        {
            base.ApplyTheme();
        }

        private void setData()
        {
            List<Measurement> measurementList = new List<Measurement>();

            MySqlTemperature mySqlTemperature = new MySqlTemperature();
            if ( cbMeasurements.SelectedItem!= null && "My measurements".Equals(cbMeasurements.SelectedItem.ToString()))
            {
                measurementList = mySqlMeasurement.getMeasurenmentsByEmployeeId(Form1.EmployeeId);
              //  btnEdit.Visible = true;
            }
            else
            {
                measurementList = mySqlMeasurement.GetMeasurements();
               // btnEdit.Visible = false;
            }
                List<ListViewItem> array = new List<ListViewItem>();
            if (measurementList != null)
            {
                lvMeasurements.Items.Clear();
                foreach (Measurement m in measurementList)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = m.ID;
                    lvi.Text = m.ID.ToString();
                    lvi.SubItems.Add(m.Address.City);
                    lvi.SubItems.Add(m.Address.Country.ToString());

                    if (mySqlTemperature.getTemperatureById(m.ID) != null)
                    {
                        lvi.SubItems.Add(mySqlTemperature.getTemperatureById(m.ID).Value.ToString() + "°C");
                    }
                    array.Add(lvi);
                }
                lvMeasurements.Items.AddRange(array.ToArray());
            }
            else
            {
                lvMeasurements.Items.Clear();
            }
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (tbId != null && tbId.Text.Length > 0)
            {
                MeasurementDetails measurementDetails = new MeasurementDetails(measurement);
                measurementDetails.Show();
            }
        }

        private void lvMeasurements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMeasurements.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvMeasurements.SelectedItems[0];
                tbId.Text = selectedItem.SubItems[0].Text;
                measurement = mySqlMeasurement.getMeasurenmentById(int.Parse(selectedItem.SubItems[0].Text));
            }
        }

        private void cbMeasurements_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            setData();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbId.Text != null)
            {
                FindAndSelectRowById(tbId.Text);
            }
        }

        private void FindAndSelectRowById(string targetId)
        {
            foreach (ListViewItem item in lvMeasurements.Items)
            {
                string idValue = item.SubItems[0].Text;

                if (idValue == targetId)
                {
                    MySqlMeasurement mySqlMeasurement = new MySqlMeasurement();
                    Measurement m = mySqlMeasurement.getMeasurenmentById(int.Parse(tbId.Text));
                    if (mySqlMeasurement.DeleteById(m.ID))
                    {
                        MessageBox.Show("DELETED " + item.SubItems[1].Text);
                        lvMeasurements.Items.Clear();
                        setData();
                    }
                    else
                    {
                        MessageBox.Show("CANT'T DELETE, BECAUSE VALUE IS USED ALREADY");
                    }
                    return;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbId.Text != null && tbId.Text.Length > 0)
            {
                EditMeasurementForm editMeasurementForm = new EditMeasurementForm(int.Parse(tbId.Text));
                editMeasurementForm.ShowDialog();
            }
        }
    }
}
