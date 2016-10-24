using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace VVPosS
{
    public partial class frmLanguages : Form
    {
        #region Variable
        /// <summary>
        /// string culture
        /// </summary>
        //private string strCulture = "en-US";
        /// <summary>
        /// blag define agreement of user : change language or not
        /// </summary>
        private bool blag = false;

        public bool Blag
        {
            get
            {
                return blag;
            }
        }
        #endregion

        public frmLanguages()
        {
            InitializeComponent();
            SettingControl();
        }

        #region Form method
        /// <summary>
        /// Event raise when user click cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //set blag la false
            blag = false;
            //close form
            this.Close();
        }

        /// <summary>
        /// Event raise when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLanguages_Load(object sender, EventArgs e)
        {
            //set value strCulture from registry
            //Common.clsLanguages.StrCulture = Common.clsRegistry.GetStringRegistryValue(@"Language", "vi-VN");
            //Common.clsLanguages.StrCulture =
            //set globelize for app
            GlobalizeApp();
            //set item that is selected for combobox language
            SetSelectedIndexForCombobox();
        }

        /// <summary>
        /// Event raise when user loch change button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            //set blag is true
            blag = true;
            //set value for strCulture
            SetstrCultureFromCombobox();
            //Blobalize app
            GlobalizeApp();
            //Save culture into registry
            Common.clsRegistry.SetStringRegistryValue("Language", Common.clsLanguages.StrCulture);
            //close form
            this.Close();
        }

        /// <summary>
        /// Event raise when user choose language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbLanguages_DropDownClosed(object sender, EventArgs e)
        {
            if (cbbLanguages.SelectedIndex == 0)
            {
                pbLogo.BackgroundImage = Properties.Resources.us;
            }
            if (cbbLanguages.SelectedIndex == 1)
            {
                pbLogo.BackgroundImage = Properties.Resources.japan;
            }
            if (cbbLanguages.SelectedIndex == 2)
            {
                pbLogo.BackgroundImage = Properties.Resources.vietnam;
            }
        }
        #endregion


        #region User method
        /// <summary>
        /// Set control for form
        /// </summary>
        private void SettingControl()
        {
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            //this.BackgroundImage = Common.Utility.GetImageFromService("ShopImg", "bg10.png");
            //lblLanguage.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLORWHILE);
            //cbbLanguages.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            //btnChange.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            //btnCancel.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
        }
        /// <summary>
        /// Set text for control
        /// </summary>
        public void SetUIChanges()
        {
            lblLanguage.Text = Common.clsLanguages.GetResource("Language");

            cbbLanguages.Items.Clear();
            cbbLanguages.Items.Add(Common.clsLanguages.GetResource("English"));
            cbbLanguages.Items.Add(Common.clsLanguages.GetResource("Japan"));
            cbbLanguages.Items.Add(Common.clsLanguages.GetResource("Vietnam"));

            btnChange.Text = Common.clsLanguages.GetResource("Change");
            btnCancel.Text = Common.clsLanguages.GetResource("Cancel");
        }

        /// <summary>
        /// Globalize Application
        /// </summary>
        private void GlobalizeApp()
        {
            Common.clsLanguages.SetCulture(Common.clsLanguages.StrCulture);
            //Common.clsLanguages.SetResource();
            SetUIChanges();
            foreach (Form frm in Application.OpenForms)
            {
                MethodInfo method=frm.GetType().GetMethod("SetUIChanges");
                if(method!=null)
                    method.Invoke(frm,null);
            }
        }

        /// <summary>
        /// Set selected index for cbbLanguge
        /// </summary>
        public void SetSelectedIndexForCombobox()
        {
            if (String.Compare(Common.clsLanguages.StrCulture, "en-US") == 0)
            {
                cbbLanguages.SelectedIndex = 0;
                pbLogo.BackgroundImage = Properties.Resources.us;
            }

            if (String.Compare(Common.clsLanguages.StrCulture, "ja-JP") == 0)
            {
                cbbLanguages.SelectedIndex = 1;
                pbLogo.BackgroundImage = Properties.Resources.japan;
            }

            if (String.Compare(Common.clsLanguages.StrCulture, "vi-VN") == 0)
            {
                cbbLanguages.SelectedIndex = 2;
                pbLogo.BackgroundImage = Properties.Resources.vietnam;
            }
        }

        /// <summary>
        /// Set strCulture from cbbLanguage
        /// </summary>
        public void SetstrCultureFromCombobox()
        {
            if (cbbLanguages.SelectedIndex == 0)
            {
                Common.clsLanguages.StrCulture = "en-US";
            }

            if (cbbLanguages.SelectedIndex == 1)
            {
                Common.clsLanguages.StrCulture = "ja-JP";
            }

            if (cbbLanguages.SelectedIndex == 2)
            {
                Common.clsLanguages.StrCulture = "vi-VN";
            }
        } 
        #endregion
    }
}
