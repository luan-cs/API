using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace VVPosS
{
    public partial class frmUtility : Form
    {
        //private string sPrinterName, sPrinter = "PrinterCard";
        public frmUtility()
        {
            InitializeComponent();
            //SettingControl();
        }
        private void frmUtility_Load(object sender, EventArgs e)
        {
            //Set UI;
            SetUIChanges();
            //ToUper
            ToUpper();

            LoadData();
        }
        private void SettingControl()
        {
            //this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(160)))));
        }

        private void ToUpper()
        {
            lbTittle1.Text = lbTittle1.Text.ToUpper();
        }

        public void SetUIChanges()
        {
            lbTittle1.Text = Common.clsLanguages.GetResource("Config");
            lbVat.Text = Common.clsLanguages.GetResource("VAT");
            lbServiceCharge.Text = Common.clsLanguages.GetResource("ServiceCharge");
            lbPhoneContact.Text = Common.clsLanguages.GetResource("Phone");
            lbPrintTran.Text = Common.clsLanguages.GetResource("PrintAtTheKitchen");
            rdYes.Text = Common.clsLanguages.GetResource("Yes_1");
            rdNo.Text = Common.clsLanguages.GetResource("No_1");
            btnReset.Text = Common.clsLanguages.GetResource("Reset");
            //btnConnect.Text = Common.clsLanguages.GetResource("Status");
            btnCancel.Text = Common.clsLanguages.GetResource("Exit");

        }

       

        private void LoadData() {
            txtVat.Text = ConfigurationManager.AppSettings["VAT"];
            txtServiceCharge.Text = ConfigurationManager.AppSettings["SeviceCostPercent"];
            txtPhoneContact.Text = ConfigurationManager.AppSettings["PhoneContact"];
            if (ConfigurationManager.AppSettings["IsPrintTran"] == "1")
            {
                rdYes.Checked = true;
            }
            else rdNo.Checked = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control cl in Controls) {
                if (cl is TextBox) {
                    ((TextBox)cl).Text = String.Empty;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try {
                if (!CheckData()) return;
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuration.AppSettings.Settings["VAT"].Value = txtVat.Text;
                configuration.AppSettings.Settings["SeviceCostPercent"].Value = txtServiceCharge.Text;
                configuration.AppSettings.Settings["PhoneContact"].Value = txtPhoneContact.Text;
                if (rdNo.Checked) configuration.AppSettings.Settings["IsPrintTran"].Value = "0";
                else configuration.AppSettings.Settings["IsPrintTran"].Value = "1";
                //configuration.Save(ConfigurationSaveMode.Modified, false);
                //ConfigurationManager.RefreshSection("appSettings");

                
                    configuration.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("UpdateSuccess"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
            catch (Exception) {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("UpdateFailed"),
                                           Common.clsLanguages.GetResource("Information"),
                                           Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                           Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }

        private bool CheckData() {
            
            if (txtPhoneContact.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PhoneContactNotEmpty"),
                                    Common.clsLanguages.GetResource("Warning"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Warning,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtPhoneContact.Focus();
                return false;
            }
           
            return true;
        }


        private void txtTenantName_TextChanged(object sender, EventArgs e)
        {
            if (txtVat.Text.Length > 3 || Common.Utility.ParseDouble(txtVat.Text.Trim()) > 99)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DataMaxLength") + " " + 3 + " " + Common.clsLanguages.GetResource("Character"),
                                    Common.clsLanguages.GetResource("Warning"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Warning,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtVat.Text = txtVat.Text.Substring(0, txtVat.Text.Length - 1);
                txtVat.SelectionStart = txtVat.Text.Length;
                txtVat.Focus();
                return;
            }
        }

        private void txtTenantCode_TextChanged(object sender, EventArgs e)
        {
            if (txtServiceCharge.Text.Length > 3 || Common.Utility.ParseDouble(txtVat.Text.Trim()) > 999)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DataMaxLength") + " " + 3 + " " + Common.clsLanguages.GetResource("Character"),
                                    Common.clsLanguages.GetResource("Warning"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Warning,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtServiceCharge.Text = txtServiceCharge.Text.Substring(0, txtServiceCharge.Text.Length - 1);
                txtServiceCharge.SelectionStart = txtServiceCharge.Text.Length;
                txtServiceCharge.Focus();
                return;
            }
        }

        private void txtPhoneContact_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneContact.Text.Length > 20)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DataMaxLength") + " " + 20 + " " + Common.clsLanguages.GetResource("Character"),
                                    Common.clsLanguages.GetResource("Warning"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Warning,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtPhoneContact.Text.Substring(txtPhoneContact.Text.Length - 1);
                txtPhoneContact.Focus();
                return;
            }
        }



        private void txtServiceCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Utility.MaskDecimal(e);
        }

    }
}
