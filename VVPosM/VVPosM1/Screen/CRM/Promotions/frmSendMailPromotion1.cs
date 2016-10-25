using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Collections;
//using VVPosM1.BusinessLayer;
using System.IO;
using VVPosM1;
using System.Security.Cryptography;
using VVPosM1.BusinessLayer.BLLCRM;

namespace VVPosM1.Screen.CRM.Promotions
{
    public partial class frmSendMailPromotion1 : Form
    {
        PromotionBLL promoBLL = new PromotionBLL();

        private const int TIMER_INTERVAL = 50;
        private const int SMTP_SERVER = 0;
        private const int SMTP_PORT = 1;
        private const int SMTP_SSL = 2;
        private const int SENDING_MAIL = 3;
        private const int SENDING_MAIL_PASS = 4;
        private const int SENDING_MAIL_NAME = 5;

        private bool MailSent;
        //Email variable
        private string SMTPserver, IDstr, FromEmail, FromName, ToList, Subject, Body, Password;
        private int Port;
        private bool bSSL;
        public ArrayList arr = new ArrayList();
        string[] bbc = null;
        //__________________________

        public frmSendMailPromotion1()
        {
            InitializeComponent();
            SettingControl();
        }

        private void SettingControl()
        {

        }

        /// <summary>
        /// Set text for control
        /// </summary>
        public void SetUIChanges()
        {
            lblTitle.Text = Common.clsLanguages.GetResource("CRM189");

            //gbInformationSearch
            gbInformationSearch.Text = Common.clsLanguages.GetResource("CRM194");
            btnSendMail.Text = Common.clsLanguages.GetResource("CRM195");

            lblTo.Text = Common.clsLanguages.GetResource("CRM196");
            //lblToCC.Text = Common.clsLanguages.GetResource("CRM197");
            lblSubject.Text = Common.clsLanguages.GetResource("CRM198");
            gbInformation.Text = Common.clsLanguages.GetResource("CRM199");

            lblAttachment.Text = Common.clsLanguages.GetResource("CRM359");
            lbfailList.Text = Common.clsLanguages.GetResource("CRMEmailFailList");
            lbfailList.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.REQUIRECOLOR);

        }        

        private void frmSendMailPromotion_Load(object sender, EventArgs e)
        {
            SetUIChanges();
            funData(this.arr);
        }

        public bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException exp)
            {
                return false;
            }
        }


        /// <summary>
        /// SendEmail need set port, userName, passWord, fromUser, toUser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public bool sendMail(bool bSSL, string SMTPserver, string IDstr, string Password, int Port, string FromEmail, string FromName, string ToList, string Subject, string Body, List<Attachment> pAttach)
        {
            MailMessage Msg = new MailMessage();
            //change body into html format
            //Body = Body.Replace("\n", "<br>");
            //set message sender
            Msg.From = new MailAddress(FromEmail, FromName);
            //sets the mail recipients                              
            //(in this case 2 person will be emailed)
            Msg.To.Add(new MailAddress(ToList));

            //set to true if you want to use html in the body
            Msg.IsBodyHtml = true;
            Msg.Subject = Subject;
            //body of the email message with html tag
            Msg.Body = Body;

            //Allows applications to send e-mail
            // host server :  smtp.gmail.com
            //port number : 587
            //SmtpClient objMail = new SmtpClient("smtp.vietvang.net", 25);

            //Some SMTP servers require you to authenticate first
            //gmail uses SSL      
            //info object contains the gmail
            //username, and password
            //objMail.UseDefaultCredentials = true;
            //NetworkCredential info = new NetworkCredential("crm@vietvang.net", "vietvangcrm");

            SmtpClient objMail = new SmtpClient(SMTPserver, Port);

            //Some SMTP servers require you to authenticate first
            //gmail uses SSL      
            //info object contains the gmail
            //username, and password
            objMail.UseDefaultCredentials = true;
            NetworkCredential info = new NetworkCredential(IDstr, Password);
            objMail.DeliveryMethod = SmtpDeliveryMethod.Network;
            objMail.Credentials = info;
            objMail.EnableSsl = false;

            if (pAttach != null && pAttach.Count > 0)
            {
                foreach (var item in pAttach)
                {
                    Msg.Attachments.Add(item);
                }
            }

            try
            {
                objMail.Send(Msg);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            string pPathFile = "";
            int totalEmail = 0;
            string totalMailList = "";
            txtFailList.Text = string.Empty;

            //List check send mail fail
            List<string> pListFail = new List<string>();
            try
            {
                               
                progressBar1.Value = 5;

                if (string.IsNullOrEmpty(txtTo.Text))
                {
                    lblTB.Text = Common.clsLanguages.GetResource("CRM362");
                    return;
                }
                if (string.IsNullOrEmpty(txtSubject.Text.Trim()))
                {
                    lblTB.Text = Common.clsLanguages.GetResource("CRM363");
                    return;
                }

                //Read file *.txt, para are SMTPserver, Port, bSSL, IDstr, Password, FromEmail, FromName           
                pPathFile = Path.GetDirectoryName(Application.ExecutablePath) + "\\setConfigurationMail.txt";

                if (string.IsNullOrEmpty(pPathFile))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM364"),
                            Common.clsLanguages.GetResource("CRM11"),
                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
            }
            catch(Exception exp)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM364"),
                            Common.clsLanguages.GetResource("CRM11"),
                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
            }
            try
            {
                //progressBar1.Value = 10;

                string[] srr = null;
                //progressBar1.Value = 10;
                try
                {
                    byte[] cryptText = System.IO.File.ReadAllBytes(pPathFile);
                    byte[] clearText = System.Security.Cryptography.ProtectedData.Unprotect(cryptText, Common.Constants.CRYPTO_ENTROPY, DataProtectionScope.LocalMachine);
                    string str = System.Text.Encoding.Unicode.GetString(clearText);
                    srr = str.Split('$');
                }
                catch (Exception exp)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM364"),
                            Common.clsLanguages.GetResource("CRM11"),
                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
                if (srr != null)
                {
                    SMTPserver = srr[SMTP_SERVER];
                    Port = int.Parse(srr[SMTP_PORT]);
                    bSSL = bool.Parse(srr[SMTP_SSL]);
                    IDstr = srr[SENDING_MAIL];
                    Password = srr[SENDING_MAIL_PASS];
                    FromEmail = IDstr;
                    FromName = srr[SENDING_MAIL_NAME]; //From name
                }


                //progressBar1.Value = 60;
                Subject = txtSubject.Text.ToString();
                Body = htmlEditorControl1.InnerHtml;

                //TimeStamp = "\n\n\n\nNgày gửi->" + DateTime.Now.ToLocalTime();
                //Body = Body + TimeStamp;
                //progressBar1.Value = 80;

                //Set para for Body mail
                string[] ab = new string[4];
                string pName = "";
                string pEmail = "";
                string pBody = "";

                //Linh 26-12-2014
                Common.KeyChecking checkkey = new Common.KeyChecking();

                for (int i = 0; i < this.arr.Count; i++)
                {
                    progressBar1.Value = (int)Math.Floor((double) (100 * i / this.arr.Count));
                    ab = (string[])this.arr[i];
                    pName = ab[1];
                    pEmail = ab[3];
                    pBody = Common.clsLanguages.GetResource("CRM526") + " " + pName + "<br />";
                    if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                    {
                        pBody = pName + " " + Common.clsLanguages.GetResource("CRM526") + "<br />";
                    }


                    if (checkkey.checkLicense())
                    {
                        pBody = pBody + Body;
                    }
                    else
                    {
                        pBody = pBody + Body + "<p>This email is sent by VV-CRM software (trial version) - Copyright of VietVang JSC (vietvang.net).</p>";
                    }


                    string[] emailArr = pEmail.Split(';');
                    foreach (string email in emailArr)
                    {
                        
                        //Linh 03-12-2014
                        //Check valid list email
                        if (!string.IsNullOrEmpty(email.Trim()))
                        {
                            if (IsValidEmail(email.Trim()) == false)
                            {
                                pListFail.Add(email);
                                txtFailList.Text += email + "; \r\n";
                            }
                            else
                            {
                                MailSent = sendMail(bSSL, SMTPserver, IDstr, Password, Port, FromEmail, FromName, email.Trim(), Subject, pBody, pList_attachments);
                                if (!MailSent)
                                {
                                    pListFail.Add(email);
                                    txtFailList.Text += email + "; \r\n";
                                }
                            }
                            totalEmail++;
                            totalMailList += email + "; ";
                        }
                    }
                }

                //Linh 04-12-2014
                //Gửi mail  Bcc
                if (txtToCC.Text != "")
                {
                    string[] listBcc = txtToCC.Text.Split(';');
                    foreach (string itemBcc in listBcc)
                    {
                        pEmail = itemBcc.Trim();
                        if( (pEmail != "") && IsValidEmail(pEmail))
                        {
                            pBody = Common.clsLanguages.GetResource("CRM526") + "<br />";
                            pBody = pBody + Body;
                            MailSent = sendMail(bSSL, SMTPserver, IDstr, Password, Port, FromEmail, FromName, pEmail, Subject, pBody, pList_attachments);
                            if (!MailSent)
                            {
                                pListFail.Add(pEmail);
                                txtFailList.Text += pEmail + "; \r\n";
                            }

                            totalMailList += pEmail + "; ";
                            totalEmail++;
                        }
                    }
                }

                progressBar1.Value = 100;
                //progressBar1.Value = 0;            

                //MessageBox.Show("Mail đã gửi xong! SUCESS!,\r\n Các email gửi không được là: " + pListFailItem, "Thông báo gửi mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if(totalEmail >= pListFail.Count) lblTB.Text = (totalEmail - pListFail.Count) + "/" + totalEmail + " "   + Common.clsLanguages.GetResource("CRM603"); // Success
                
                pList_attachments = null;
                
                //send final mail
                Subject = "Email(s) sending result: " + Subject;
                
                pBody = "Content:";
                pBody += "<br />---------------------------------------<br />";
                pBody += Body ;
                pBody += "<br />---------------------------------------<br />"; 
                pBody += (totalEmail - pListFail.Count) + "/" + totalEmail + " " + Common.clsLanguages.GetResource("CRM603");
                pBody += "<br />-------<br />";
                pBody += "Email(s) send to:<br />" + totalMailList + "<br />";
                pBody += "<br />-------<br />";
                pBody += "Email(s) failed:<br />" + txtFailList.Text;
                MailSent = sendMail(bSSL, SMTPserver, IDstr, Password, Port, FromEmail, FromName, FromEmail, Subject, pBody, pList_attachments);

                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM649"),
                           Common.clsLanguages.GetResource("CRM11"),
                           Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                           Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;

            }
            catch (Exception)
            {
                if (totalEmail >= pListFail.Count) lblTB.Text = (totalEmail - pListFail.Count) + "/" + totalEmail + " " + Common.clsLanguages.GetResource("CRM603");
                else
                    lblTB.Text = Common.clsLanguages.GetResource("CRM602"); // fail
                return;
            }
           
        }


        /// <summary>
        ///Arr get by select form frmMemberMail
        /// </summary>

        public void funData(ArrayList arr)
        {
            string pName = "";
            pName = txtTo.Text;
            string[] ab = new string[4];

            for (int i = 0; i < arr.Count; i++)
            {
                ab = (string[])arr[i];
                if (pName.IndexOf(ab[1]) >= 0)
                {
                }
                else
                {
                    if (ab[1] != "")
                    {
                        pName += ab[1] + "; "; //Member name
                    }
                    else
                    {
                        pName += "[" + ab[0] + "]; "; //Company Name
                    }
                }
            }
            
            txtTo.Text = pName;
        }

        List<Attachment> pList_attachments; //them1

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog attFile = new OpenFileDialog();
            attFile.Filter = "All File|*.*";
            attFile.Multiselect = true;
            attFile.ShowDialog();
            if (!string.IsNullOrEmpty(attFile.FileName))
            {
                FileInfo fe = new FileInfo(attFile.FileName);
                string pFile = "";

                pList_attachments = new List<Attachment>(); //them1
                foreach (var item in attFile.FileNames)
                {
                    pFile = pFile + "" + item + "; ";
                    pList_attachments.Add(new Attachment(item)); //them1                 
                }
                txtAttachment.Text = "";
                txtAttachment.Text = pFile;
            }
        }

    }
}
