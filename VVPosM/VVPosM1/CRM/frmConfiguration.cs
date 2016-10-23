using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Net.Mail;
using System.Net;
using VVPosM1.Screen.CRM.Promotions;

namespace VVPosM1.CRM
{
    public partial class frmConfiguration : Form
    {
        public frmConfiguration()
        {
            InitializeComponent();
        }

        private const int SMTP_SERVER = 0;
        private const int SMTP_PORT = 1;
        private const int SMTP_SSL = 2;
        private const int SENDING_MAIL = 3;
        private const int SENDING_MAIL_PASS = 4;
        private const int SENDING_MAIL_NAME = 5;
        //Email variable
        private string SMTPserver, IDstr, Subject, FromEmail, FromName, Password;
        private int Port;
        private bool bSSL;

        private const string MAIL_SERVER_CONFIG = "econf";

        public void setUIChanges()
        {       
            
            //string pPathFile = Path.GetDirectoryName(Application.ExecutablePath) + "\\setConfigurationMail.txt";

            string[] srr = null;
            try
            {
                //byte[] cryptText = System.IO.File.ReadAllBytes(pPathFile);
                string emailConfigStr = Common.clsRegistry.GetStringRegistryValue(MAIL_SERVER_CONFIG, "");
                if (!string.IsNullOrEmpty(emailConfigStr))
                {
                    byte[] cryptText = Convert.FromBase64String(emailConfigStr);
                    byte[] clearText = System.Security.Cryptography.ProtectedData.Unprotect(cryptText, Common.Constants.CRYPTO_ENTROPY, DataProtectionScope.LocalMachine);
                    string str = System.Text.Encoding.Unicode.GetString(clearText);
                    srr = str.Split('$');
                    if (srr.Length > 0)
                    {
                        txtFrom.Text = srr[SENDING_MAIL_NAME];
                        txtMailServer.Text = srr[SMTP_SERVER];
                        txtPassword.Text = srr[SENDING_MAIL_PASS];
                        txtMailPort.Text = srr[SMTP_PORT];
                        if (srr[SMTP_SSL] == "true")
                        {
                            cbSSL.Checked = true;
                        }
                        txtEmail.Text = srr[SENDING_MAIL];
                    }
                }
                
            }
            catch
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lbmessage.Visible = false;
            string smtp = txtMailServer.Text;
            if (smtp.Length <= 0) {
                lbmessage.Visible = true;
                lbmessage.Text = "Email server address is required";
            }
            else
            {
                string email = txtEmail.Text;
                if (email.Length <= 0) {
                    lbmessage.Visible = true;
                    lbmessage.Text = "Email address is required";
                    }
                else
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(email, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"))
                    {
                        lbmessage.Visible = true;
                        lbmessage.Text = "Email address is not valid";
                    }
                    else
                    {
                        string password = txtPassword.Text;
                        if (password.Length <= 0)
                        {
                            lbmessage.Text = "Password is required";
                            lbmessage.Visible = true;
                        }
                        else
                        {
                            string sFromName = txtFrom.Text;
                            string port = txtMailPort.Text;
                            if (port.Length <= 0) port = "25";
                            string ssl;
                            if (cbSSL.Checked) ssl = "true";
                            else ssl = "false";

                            //string pPathFile = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\setConfigurationMail.txt";

                            String writeToFile = smtp + "$" + port + "$" + ssl + "$" + email + "$" + password + "$" + sFromName;
                            try
                            {
                                byte[] clearText = System.Text.Encoding.Unicode.GetBytes(writeToFile);
                                //encrypt and write to file
                                byte[] encText = ProtectedData.Protect(clearText, VVPosM1.Common.Constants.CRYPTO_ENTROPY, System.Security.Cryptography.DataProtectionScope.LocalMachine);
                                //System.IO.File.WriteAllBytes(pPathFile, encText);
                                string encStr = Convert.ToBase64String(encText);
                                VVPosM1.Common.clsRegistry.SetStringRegistryValue(MAIL_SERVER_CONFIG, encStr);
                                this.Close();
                            }
                            catch (Exception eee)
                            {
                                lbmessage.Text = "Something was wrong! Please try again.";
                                lbmessage.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            setUIChanges();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lbmessage.Visible = true;

            bool bFlag = false;
            lbmessage.Text = "Connecting...";

            frmSendMailPromotion1 frmMail = new frmSendMailPromotion1();
            SMTPserver = txtMailServer.Text.Trim();
            Port = int.Parse(txtMailPort.Text.Trim());
            bSSL = (cbSSL.Checked) ? true : false;
            IDstr = txtEmail.Text.Trim();
            Password = txtPassword.Text;
            FromEmail = IDstr;
            FromName = txtFrom.Text.Trim(); 

            string pBody = "This is an e-mail message sent automatically by CRM Viet Vang while testing.";

            bFlag = frmMail.sendMail(bSSL, SMTPserver, IDstr, Password, Port, FromEmail, FromName, IDstr, Subject, pBody, null);
            if (bFlag)
            {
                lbmessage.Text = "Email is connected";
            }
            else
            {
                lbmessage.Text = "Email is not connected";
            }
        }

        private void frmConfiguration_Paint(object sender, PaintEventArgs e)
        {
            Form frm = (Form)sender;
            //float conner = 30;
            System.Drawing.Drawing2D.GraphicsPath frmPath = new System.Drawing.Drawing2D.GraphicsPath();
            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = frm.ClientRectangle;
            ControlPaint.DrawBorder(e.Graphics, newRectangle,
                System.Drawing.ColorTranslator.FromHtml("#916F5D"), 1, ButtonBorderStyle.Outset,
                System.Drawing.ColorTranslator.FromHtml("#916F5D"), 1, ButtonBorderStyle.Outset,
                System.Drawing.ColorTranslator.FromHtml("#916F5D"), 1, ButtonBorderStyle.Inset,
                System.Drawing.ColorTranslator.FromHtml("#916F5D"), 1, ButtonBorderStyle.Inset);
        }
    }
}
