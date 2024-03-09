using System;
using System.CodeDom;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using Label = System.Windows.Forms.Label;
using ListView = System.Windows.Forms.ListView;

namespace VremenskaPrognozaApp.Forms
{
    public partial class BaseForm : Form
    {
        protected Theme currentTheme;
        protected static string filePath;

        public BaseForm()
        {
            if (filePath == null)
            {
                 LoadTheme("C:\\Users\\user\\source\\repos\\VremenskaPrognozaApp\\VremenskaPrognozaApp\\Themes\\Theme1.xml");
            }
            else
            {
                LoadTheme(filePath);
            }
            
            // LoadTheme("C:\\Users\\user\\source\\repos\\VremenskaPrognozaApp\\VremenskaPrognozaApp\\Themes\\Theme2.xml");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        protected virtual void LoadTheme(string themeFilePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Theme));
                using (FileStream fileStream = new FileStream(themeFilePath, FileMode.Open))
                {
                    currentTheme = (Theme)serializer.Deserialize(fileStream);
                }

                ApplyTheme();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading theme: {ex.Message}");
            }
        }

        protected virtual void ApplyTheme()
        {
            this.BackColor = Color.FromName(currentTheme.BackgroundColor);
            this.ForeColor = Color.FromName(currentTheme.TextColor);

            try
            {
                Font font = new Font(new FontFamily(currentTheme.FontName), 18);
                this.Font = font;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading font: {ex.Message}");
            }

            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.Button button)
                {
                    if (button.BackColor != Color.FromName(currentTheme.ButtonColor))
                    {
                        button.BackColor = Color.FromName(currentTheme.ButtonColor);
                        button.ForeColor = Color.FromName(currentTheme.ButtonTextColor);
                    }
                }
                else if (control is Label label)
                {
                    label.ForeColor = Color.FromName(currentTheme.LabelColor);

                    if (label.Text.Equals("WeatherWatchful") || label.Text.Equals("VremenskaPrognoza"))
                    {
                    //    label.ForeColor = Color.FromName("Highlight");

                        if (label.Text.Equals("VremenskaPrognoza"))
                        {
                            label.Font = new System.Drawing.Font(label.Font.FontFamily, 30f);
                            label.Font = new Font(label.Font, FontStyle.Bold | FontStyle.Italic);
                        }
                    }
                }
                else if (control is System.Windows.Forms.TextBox textBox)
                {
                    textBox.BackColor = Color.FromName(currentTheme.TextFieldColor);
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.BackColor = Color.FromName(currentTheme.TextFieldColor);
                    
                }
                else if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.BackColor = Color.FromName(currentTheme.ComboBoxColor);
                    comboBox.ForeColor = Color.FromName(currentTheme.ComboBoxTextColor);
                    
                }
                else if (control is ListView list)
                {
                    list.BackColor = Color.FromName(currentTheme.ListViewColor);
                    list.OwnerDraw = true;
                    list.DrawColumnHeader += ListView_DrawColumnHeader;
                    list.DrawItem += ListView_DrawItem;
                    list.DrawSubItem += ListView_DrawSubItem;
                }
                else if (control is GroupBox groupBox)
                {
                    groupBox.BackColor = Color.FromName(currentTheme.GroupBoxColor);
                    groupBox.ForeColor = Color.FromName(currentTheme.GroupBoxTextColor);
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.ForeColor = Color.FromName(currentTheme.RadioButtonColor);
                }
                else if( control is CheckBox checkBox)
                {
                    checkBox.ForeColor = Color.FromName(currentTheme.CheckBoxColor);
                }
            }
        }

        private void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            Color columnHeaderColor = Color.FromName(currentTheme.ListViewColorHeader);

            using (Brush brush = new SolidBrush(columnHeaderColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }
        private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;

            if ((e.State & ListViewItemStates.Selected) == ListViewItemStates.Selected)
            {
                using (Brush brush = new SolidBrush(Color.FromName(currentTheme.SelectedListViewColor)))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }

                TextRenderer.DrawText(e.Graphics, e.Item.Text, e.Item.Font, e.Bounds, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;

            if ((e.ItemState & ListViewItemStates.Selected) == ListViewItemStates.Selected)
            {
                using (Brush brush = new SolidBrush(Color.FromName(currentTheme.SelectedListViewColor)))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }

                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
