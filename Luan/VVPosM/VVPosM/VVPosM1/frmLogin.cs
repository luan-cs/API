#region (c) 2012 Viet Vang - All rights reserved
/*             			COPYRIGHT NOTICE
 *-----------------------------------------------------------------------
 * All materials (including but not limited to source code, compiled
 * assemblies, images, resources, etc.) are copyrighted to Viet Vang.
 * No usage is allowed unless permitted by written consent.
 * You may not use, reverse-engineer these materials under any 
 * circumstances.
 * 
 *
 *				PROJECT DESCRIPTION
 *-----------------------------------------------------------------------
 * Project		: V2SoftMEMDIWINF1308
 * Class		: frmMain
 * Developer    : Tran Thanh Luan
 */
#endregion

#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VVPosM1.BusinessLayer;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Configuration;
using System.Net;

#endregion

namespace VVPosM1
{
    public partial class frmLogin : Form
    {
        #region Variable

        /// <summary>
        /// Object of user in roll bll
        /// </summary>

        private SplashScreen sf = new SplashScreen();

        #endregion

        #region Contructor

        public frmLogin()
        {
            this.Hide();
            Thread splashthread = new Thread(new ThreadStart(Entities.clsSplashScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();
            InitializeComponent();
            //set color for control
            SettingControl();
        }

        #endregion

        #region System fuction
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtServer.Text = ConfigurationManager.AppSettings["MyLastURL"];
            try
            {
                Entities.clsSplashScreen.UdpateStatusText("Connecting…");
                Thread.Sleep(1000);
                //string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                if (1 == 1) //if (Program.destopService.IsServiceReady() && Program.destopService.IsDataReady())
                {
                    Entities.clsSplashScreen.UdpateStatusTextWithStatus("Connected.", Entities.TypeOfMessage.Success);
                    Thread.Sleep(1000);
                    this.Show();
                    Entities.clsSplashScreen.CloseSplashScreen();
                    this.Activate();
                    Common.clsLanguages.StrCulture = "vi-VN";

                    GlobalizeApp();
                }
                else
                {
                    Entities.clsSplashScreen.UdpateStatusTextWithStatus("Failed to connect. Please try again.", Entities.TypeOfMessage.Error);
                    Thread.Sleep(2000);
                    this.Close();
                }


            }
            catch (Exception)
            {
                Entities.clsSplashScreen.UdpateStatusTextWithStatus("Currently the device is not connected to the network .", Entities.TypeOfMessage.Error);
                Thread.Sleep(2000);
                this.Close();
            }
        }

        /// <summary>
        /// event rise when user click Agree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        /// <summary>
        /// event rise when user click cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult r = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AreYouSureCancel"), Common.clsLanguages.GetResource("Information"), Common.Config.CUSTOM_MESSAGEBOX_ICON.Information, Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// event rise when user choose language for app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbLanguage_DropDownClosed(object sender, EventArgs e)
        {
            changeLanguage();
            SetSelectedIndexForCombobox();
        }

        /// <summary>
        /// event rise when frmLogin paint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            //Form frm = (Form)sender;
            ////float conner = 30;
            //System.Drawing.Drawing2D.GraphicsPath frmPath = new System.Drawing.Drawing2D.GraphicsPath();
            //// Set a new rectangle to the same size as the button's 
            //// ClientRectangle property.
            //System.Drawing.Rectangle newRectangle = frm.ClientRectangle;
            //ControlPaint.DrawBorder(e.Graphics, newRectangle,
            //    System.Drawing.ColorTranslator.FromHtml(Common.Config.BACKGROUNDCOLOR), 10, ButtonBorderStyle.Outset,
            //    System.Drawing.ColorTranslator.FromHtml(Common.Config.BACKGROUNDCOLOR), 10, ButtonBorderStyle.Outset,
            //    System.Drawing.ColorTranslator.FromHtml(Common.Config.BACKGROUNDCOLOR), 10, ButtonBorderStyle.Inset,
            //    System.Drawing.ColorTranslator.FromHtml(Common.Config.BACKGROUNDCOLOR), 10, ButtonBorderStyle.Inset);
            /*frmPath.AddArc(newRectangle.X, newRectangle.Y, conner, conner, 180, 90);
            frmPath.AddArc(newRectangle.X + newRectangle.Width - conner, newRectangle.Y, conner, conner, 270, 90);
            frmPath.AddArc(newRectangle.X + newRectangle.Width - conner, newRectangle.Y + newRectangle.Height - conner, conner, conner, 0, 90);
            frmPath.AddArc(newRectangle.X, newRectangle.Y + newRectangle.Height - conner, conner, conner, 90, 90);
            frm.Region = new System.Drawing.Region(frmPath);
            */
        }
        #endregion

        #region Custom method
        /// <summary>
        /// Setting for control of form
        /// </summary>
        private void SettingControl()
        {
            this.BackgroundImage = Common.Utility.GetImageFromService("ShopImg", "login3.png");
            //this.pbImage.BackgroundImage = Common.Config.LOGO;
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLOR);
            this.lblLanguage.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.lblUsername.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.lblPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbbLanguage.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.txtUsername.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.txtPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.btnAgree.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnCancel.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.pbImage.Image = Common.Utility.GetImageFromService("ShopImg", "logo_m.png");

        }

        /// <summary>
        /// Globalize Application
        /// </summary>
        private void GlobalizeApp()
        {
            Common.clsLanguages.SetCulture(Common.clsLanguages.StrCulture);
            Common.clsLanguages.SetResource();
            SetUIChanges();
        }

        /// <summary>
        /// Set text for control
        /// </summary>
        public void SetUIChanges()
        {
            lblTitle.Text = Common.clsLanguages.GetResource("SoftwareTilte");
            lblLanguage.Text = Common.clsLanguages.GetResource("Language");
            cbbLanguage.Items.Clear();
            cbbLanguage.Items.Add(Common.clsLanguages.GetResource("English"));
            cbbLanguage.Items.Add(Common.clsLanguages.GetResource("Japan"));
            cbbLanguage.Items.Add(Common.clsLanguages.GetResource("Vietnam"));
            lblUsername.Text = Common.clsLanguages.GetResource("Username");
            lblPassword.Text = Common.clsLanguages.GetResource("Password");
            btnAgree.Text = Common.clsLanguages.GetResource("Agree");
            btnCancel.Text = Common.clsLanguages.GetResource("Cancel");
            chkAdvanced.Text = Common.clsLanguages.GetResource("Advance");
            lblServer.Text = Common.clsLanguages.GetResource("Server");
            SetSelectedIndexForCombobox();
        }

        /// <summary>
        /// Set strCulture from cbbLanguage
        /// </summary>
        public void SetstrCultureFromCombobox()
        {
            if (cbbLanguage.SelectedIndex == 0)
            {
                Common.clsLanguages.StrCulture = "en-US";
            }

            if (cbbLanguage.SelectedIndex == 1)
            {
                Common.clsLanguages.StrCulture = "ja-JP";
            }

            if (cbbLanguage.SelectedIndex == 2)
            {
                Common.clsLanguages.StrCulture = "vi-VN";
            }
        }
        private void btnAgree_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtUsername.Text.Trim()) && String.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseInputInformationLogin"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtUsername.Text.Trim()))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseInputUsername"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseInputPassword"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
            //if (chkAdvanced.Checked == true)
            //{
            //    //Program.destopService.Url = "http://" + txtServer.Text + ":8389/DestopService.asmx";
            //    string tss = txtServer.Text;
            //    tss = tss.Replace("http://", "");
            //    tss = tss.Replace("/", "");
            //    Program.urlImage = tss;
            //    Program.destopService.Url = "http://" + tss + "/VVPosService/VVPosService.asmx";

            //    Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //    configuration.AppSettings.Settings["MyLastURL"].Value = tss;
            //    configuration.Save();

            //    ConfigurationManager.RefreshSection("appSettings");

            //    //ConfigurationManager.AppSettings["MyLastURL"] = txtServer.Text;

            //    //ConfigurationManager.AppSettings.
            //}
            try
            {

                UsersBLL usersBLL = new UsersBLL();
                string idOrUsername = txtUsername.Text;
                //string password = Program.ConvertStringToMD5(txtPassword.Text);
                string password = Program.ConvertStringToMD5(txtPassword.Text.Trim());
                bool ok = usersBLL.CheckLogin(idOrUsername, password);


                if (ok)
                {
                    if (Program.user.RoleId == "admin")
                    {
                        if (string.IsNullOrEmpty(usersBLL.ErrorString))
                        {

                            //Hung 09-12-2014
                            //string _sObjectId = usersBLL.GetUserIdByUserId(idOrUsername).Rows[0][0].ToString();

                            // ObjectBLL objectBLL = new ObjectBLL();
                            Program.FullName = Program.user.UserId;//usersBLL.GetEmployeesByUserId(idOrUsername).Rows[0]["EmployeeName"].ToString();
                            //Program.ImageUser = usersBLL.GetEmployeesByUserId(idOrUsername).Rows[0]["Image"].ToString();

                            frmMain frm = new frmMain();
                            frm.Show();
                            txtUsername.Clear();
                            txtPassword.Clear();
                            cbbLanguage.SelectedIndex = -1;
                            txtUsername.Focus();
                            this.Hide();
                        }
                        else
                            MessageBox.Show(usersBLL.ErrorString, Common.clsLanguages.GetResource("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NoRole"),
                                    Common.clsLanguages.GetResource("Error"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        txtUsername.Focus();
                        return;
                    }
                }
                else
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("LoginError"),
                                    Common.clsLanguages.GetResource("Error"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
            }
            catch (Exception)
            {
                string code = System.Runtime.InteropServices.Marshal.GetExceptionCode().ToString();
                if (code == "-532462766")
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CurrentlyTheDeviceIsNotConnectedInternet") + " - Last Link : " + Program.destopService.Url,
                              Common.clsLanguages.GetResource("Information"),
                              Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                              Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                }
                return;
            }
        }
        /// <summary>
        /// Set selected index for cbbLanguge
        /// </summary>
        public void SetSelectedIndexForCombobox()
        {
            if (String.Compare(Common.clsLanguages.StrCulture, "en-US") == 0)
            {
                cbbLanguage.SelectedIndex = 0;
            }

            if (String.Compare(Common.clsLanguages.StrCulture, "ja-JP") == 0)
            {
                cbbLanguage.SelectedIndex = 1;
            }

            if (String.Compare(Common.clsLanguages.StrCulture, "vi-VN") == 0)
            {
                cbbLanguage.SelectedIndex = 2;
            }
        }

        /// <summary>
        /// Change language and save into registry
        /// </summary>
        private void changeLanguage()
        {
            SetstrCultureFromCombobox();
            GlobalizeApp();

            Common.clsRegistry.SetStringRegistryValue("Language", Common.clsLanguages.StrCulture);
        }
        #endregion

        private void chkAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdvanced.Checked == true)
            {
                lblServer.Visible = true;
                txtServer.Visible = true;
            }
            else
            {
                lblServer.Visible = false;
                txtServer.Visible = false;
            }
        }




    }
}
