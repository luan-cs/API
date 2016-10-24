using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VVPosS.BusinessLayer;
using VVPosS.Entities;

namespace VVPosS
{
    public partial class frmChangePassword : Form
    {
        #region Variable
        #endregion

        public frmChangePassword()
        {
            InitializeComponent();
            SettingControl();
        }

        #region System method
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text.Trim()))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseInputOldPassword"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtOldPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseInputNewPassword"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtNewPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseRequireNewPassword"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtConfirmPassword.Focus();
                return;
            }
            if (!Program.ConvertStringToMD5(txtOldPassword.Text.Trim()).Equals(Program.Password))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PasswordIncorrect"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtConfirmPassword.Focus();
                return;
            }
            if (!txtNewPassword.Text.Trim().Equals(txtConfirmPassword.Text.Trim()))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("RePasswordNotMacth"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                EmployeeBLL employeeBLL = new EmployeeBLL();
                Employees employees = new Employees();
                employees.UserName = Program.Username;
                employees.Password = Program.ConvertStringToMD5(txtNewPassword.Text.Trim());
                employeeBLL.ChangePassword(employees);
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ChangePasswordSuccess"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                frmLogin frm = (frmLogin)Application.OpenForms["frmLogin"];
                frm.SetUIChanges();
                frm.Show();
                Application.OpenForms["frmMain"].Close();
                this.Close();
            }
            catch (Exception)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ChangePasswordError"),
                                Common.clsLanguages.GetResource("Error"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
            
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            SetUIChanges();
        } 
        #endregion

        #region Custom method
        /// <summary>
        /// Set text for control
        /// </summary>
        private void SetUIChanges()
        {
            this.lblTitle.Text = Common.clsLanguages.GetResource("ChangePassword");
            this.lblOldPassword.Text = Common.clsLanguages.GetResource("OldPassword");
            this.lblNewPassword.Text = Common.clsLanguages.GetResource("NewPassword");
            this.lblConfirmPassword.Text = Common.clsLanguages.GetResource("RequirePassword");
            this.btnChange.Text = Common.clsLanguages.GetResource("Change");
            this.btnCancel.Text = Common.clsLanguages.GetResource("Cancel");
        }

        /// <summary>
        /// Set forecolor for control
        /// </summary>
        private void SettingControl()
        {
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            //this.BackgroundImage = Common.Utility.GetImageFromService("ShopImg", "bg11.png");
            //this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLORWHILE);
            //this.lblNewPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLORWHILE);
            //this.lblOldPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLORWHILE);
            //this.lblConfirmPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLORWHILE);
            //this.txtNewPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            //this.txtOldPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            //this.txtConfirmPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            //this.btnChange.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            //this.btnCancel.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
        }
        #endregion
    }
}
