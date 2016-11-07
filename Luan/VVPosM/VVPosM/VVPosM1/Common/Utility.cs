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
using System.Net.Mail;

namespace VVPosM1.Common
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
        public static void MaskDecimal1(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) ||  e.KeyChar == 8) e.Handled = false;
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

        public static string GetUrlFromService(string subfolder, string filename)
        {
            string host = Program.destopService.Url;
            host = host.Substring(0, host.IndexOf("VVPosService.asmx"));
            host = host + "Image/";
            string host1 = host + subfolder + "/" + filename;
            
            return host1;
        }

        /// <summary>
        /// Check length Valid of TextBox
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="length"></param>
        public static void TextLengthValid(TextBox txt, int length)
        {
            if (txt.Text.Length > length)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Chỉ được nhập tối đa " + length + " ký tự !",
                                           Common.clsLanguages.GetResource("Information"),
                                           Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                           Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
                txt.SelectionStart = txt.Text.Length;
                return;
            }
        }

        /// <summary>
        /// Format Number Text Change
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="format"></param>
        public static void TextFormatNumber(TextBox txt, string format) {
            if (txt.Text != "") {
                double _dbNum = double.Parse(txt.Text);
                txt.Text = _dbNum.ToString(format);
                txt.SelectionStart = txt.Text.Length;
            }
        }

        /// <summary>
        /// this function check mail isvalid; Dung add 2014-08-06
        /// </summary>
        /// <param name="emailaddress"></param>
        /// <returns>true, [mail isvalid]; otherwise false</returns>
        public static bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
