using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.IO;
using System.Globalization;
using System.Configuration;

namespace VVPosS.Common
{
    public static class Utility
    {
        public static DataTable ConvertListToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
        private static bool nonNumberEntered = false;
        ///// <summary>
        ///// MasDigit / 
        ///// </summary>
        ///// <param name="e"></param>
        public static void MaskDigit(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8) e.Handled = false;
            else e.Handled = true;
        }

        public static void MaskDigit_keyDown(System.Windows.Forms.KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }

            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        public static void MaskDecimal(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == 8) e.Handled = false;
            else e.Handled = true;
        }
        //Hàm lấy hình từ url
        public static Image GetImageFromUrl(string url)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);

                using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (Stream stream = httpWebReponse.GetResponseStream())
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public static Image GetImageFromService(string subfolder, string filename)
        {
            string host = Program.destopService.Url;
            host = host.Substring(0, host.IndexOf("VVPosService.asmx"));
            host = host + "Image/";
            string host1 = host + subfolder + "/" + filename;
            Image img = GetImageFromUrl(host1);
            if (img == null)
            {
                img = GetImageFromUrl(host + "noimg.png");
            }
            return img;
        }

        public static double ParseDouble(string value)
        {
            double d = 0;
            double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out d);
            return d;
        }

        public static void ERROR_INTERNET_CANNOT_CONNECT()
        {
            string code = System.Runtime.InteropServices.Marshal.GetExceptionCode().ToString();
            if (code == "-532462766")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CurrentlyTheDeviceIsNotConnectedInternet"),
                          Common.clsLanguages.GetResource("Information"),
                          Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                          Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
            return;
        }

        public static void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor, Control c)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(c.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
        public static void DrawGroupBoxNonBorder(GroupBox box, Graphics g, Color textColor, Control c)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                //Brush borderBrush = new SolidBrush(borderColor);
                //Pen borderPen = new Pen(borderBrush);
                //SizeF strSize = g.MeasureString(box.Text, box.Font);
                //Rectangle rect = new Rectangle(box.ClientRectangle.X,
                //                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                //                               box.ClientRectangle.Width - 1,
                //                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(c.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);
            }
        }

        public static void SetColumnSortMode(DataGridView dataGridView, DataGridViewColumnSortMode sortMode)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = sortMode;
            }
        }

    static string APPNODE = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".Properties.Settings";
    //Utilities.UpdateConfig(APPNODE, "lastQueryTime", now.ToString());

    public static void UpdateApplicationSettings(string section, string key, string value)
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        ClientSettingsSection applicationSettingsSection = (ClientSettingsSection)config.SectionGroups["applicationSettings"].Sections[section];
        SettingElement element = applicationSettingsSection.Settings.Get(key);

        if (null != element)
        {
            applicationSettingsSection.Settings.Remove(element);
            element.Value.ValueXml.InnerXml = value;
            applicationSettingsSection.Settings.Add(element);
        }
        else
        {
            element = new SettingElement(key, SettingsSerializeAs.String);
            element.Value = new SettingValueElement();
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            element.Value.ValueXml = doc.CreateElement("value");

            element.Value.ValueXml.InnerXml = value;
            applicationSettingsSection.Settings.Add(element);
        }

        config.Save(ConfigurationSaveMode.Modified);
        ConfigurationManager.RefreshSection("applicationSettings");            
    }
    }
}
