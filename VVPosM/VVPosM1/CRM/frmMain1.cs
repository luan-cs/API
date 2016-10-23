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
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Net;
using System.Text.RegularExpressions;
using VVPosM1.Screen.CRM.Members;
using VVPosM1.Screen.CRM.Employee;
using System.Reflection;
using VVPosM1.BusinessLayer.BLLCRM;
using VVPosM1.Screen.CRM.Types;

#endregion

namespace VVPosM1.CRM

{
    public partial class frmMain1 : Form
    {
        #region Variable

        private frmManageMembers frmManageMembers;
      
        private frmChangePassword frmChangePassword;
        
        private EmployeeBLL employeeBLL;

        //Luan add 21/10/2014
        private VVPosM1.Screen.CRM.Members.frmManageMembers frmMember;
        //end Luan add 21/10/2014

        //Diep them vao 20140501
        public Screen.CRM.Members.frmManageActions frmManageAction;

        //Nghi 2-12-2014
        private frmEmployee frmEmployee;
        private frmCustommerType frmCusType;
        private frmEmployeeType frmEmpType;
        
        #endregion

        #region Contructor

        public frmMain1()
        {
            InitializeComponent();
            //set color for control on form
          //  SettingControl();
            //load form services when open form main (default)
            //frmServices = new Screen.POS.frmServices();
            //AddFormToMainPanel(frmServices);
            frmMember = new frmManageMembers(this);
            AddFormToMainPanel(frmMember);
        }

        #endregion

        
        #region Form function
        /// <summary>
        /// Event raise when user click exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //messagebo show: Are you sure?
            DialogResult dr = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM21"), 
                        Common.clsLanguages.GetResource("CRM11"), 
                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information, 
                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
            //exit if yes
            if (dr == DialogResult.Yes)
            {
                this.Close();
                frmMain frm = new frmMain();
                frm.Show();
            }
        }
       
        /// <summary>
        /// Event raise when user click member button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMember_Click(object sender, EventArgs e)
        {
            //if form manage members is not open is open it
            if (frmManageMembers == null || !Form.ActiveForm.Contains(frmManageMembers))
            {
                CloseForm();
                frmManageMembers = new Screen.CRM.Members.frmManageMembers(this);
                AddFormToMainPanel(frmManageMembers);
            }
        }
      

        /// <summary>
        /// Event raise when user click logout button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Show messagebox : are you sure to logout?
            DialogResult dr = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM54"),
                        Common.clsLanguages.GetResource("CRM11"),
                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
            //if yes is open form login and close form main
            if (dr == DialogResult.Yes)
            {
                frmLogin frm = (frmLogin) Application.OpenForms["frmLogin"];
                frm.SetUIChanges();
                frm.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Event raise when user click change password button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //open form change password
            frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
        }


        /// <summary>
        /// Event raise when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //set text for control of form to language
            SetUIChanges();
            GetEmployeeInformation();
            //SetCountCustomer();
            //Linh 26-12-2014
            Common.KeyChecking checkkey = new Common.KeyChecking();
            if (!checkkey.checkLicense())
            {
                lblTrial.Visible = true;
                btnUpGrade.Visible = true;
            }
        }
               
        #endregion

        #region User method

        /// <summary>
        /// get employee information to show
        /// </summary>
        private void GetEmployeeInformation()
        {
            employeeBLL = new EmployeeBLL();
            lblFullName.Text = Program.employee1.EmployeeName;
            pbImage.BackgroundImage = employeeBLL.GetImage(Program.employee1.EmployeeId);
            
            //Linh 05-12-2014
            string employeeTypeId = Program.employee1.EmployeeType.EmployeeTypeId;
        }

        /// <summary>
        /// Setting color for control on form
        /// </summary>
        private void SettingControl()
        {
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.BACKGROUNDCOLOR);
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            this.pbLogo.BackgroundImage = Common.Config.LOGO;
            this.lblFullName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.btnChangePassword.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnLogout.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnMember.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnExit.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
        }

        /// <summary>
        /// Set text for control
        /// </summary>
        public void SetUIChanges()
        {
            btnChangePassword.Text = Common.clsLanguages.GetResource("CRM13");
            btnLogout.Text = Common.clsLanguages.GetResource("CRM14");
           // btnRegisterService.Text = Common.clsLanguages.GetResource("CRM15");
            btnMember.Text = Common.clsLanguages.GetResource("CRM16");
            btnExit.Text = Common.clsLanguages.GetResource("CRM20");
            lblIPLocal.Text = getLocalIp();
            lblGlobalIP.Text = Common.clsRegistry.GetStringRegistryValue("IP", ""); //getExternalIp();
            lblPort.Text = Common.clsRegistry.GetStringRegistryValue("Port", "");
            //getExternalIp(); 

            btnCRM.Text = Common.clsLanguages.GetResource("CRM619");
            btnMasterSetting.Text = Common.clsLanguages.GetResource("CRM643");
            btnMinimize.Text = Common.clsLanguages.GetResource("CRM650");
        }

        /// <summary>
        /// Get list form is activing (open)
        /// </summary>
        /// <returns></returns>
        private List<Form> GetFormListActive()
        {
            List<Form> frmlist = new List<Form>();
            foreach (Form f in Application.OpenForms)
            {
                frmlist.Add(f);
            }
            
            return frmlist;
        }

        /// <summary>
        /// Add new form to main panel
        /// </summary>
        /// <param name="frm"></param>
        public void AddFormToMainPanel(Form frm)
        {
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            
            pnMainContainer.Controls.Add(frm);
        }

        /// <summary>
        /// Close form not frmMain, frmManagement, frmLogin
        /// </summary>
        public void CloseForm()
        {
            foreach (Form f in GetFormListActive())
            {
                if (f.Name != "frmMain1" && f.Name != "frmManagement" && f.Name != "frmLogin")
                {
                    f.Close();
                }
            }
        }

        #endregion

        private void btnCRM_Click(object sender, EventArgs e)
        {
            //if form manage members is not open is open it
            if (frmManageAction == null || !Form.ActiveForm.Contains(frmManageAction))
            {
                CloseForm();
                frmManageAction = new Screen.CRM.Members.frmManageActions();
                AddFormToMainPanel(frmManageAction);
            }
        }

        public void btnSeachAction(object sender, EventArgs e, string key)
        {
            if (frmManageAction == null || !Form.ActiveForm.Contains(frmManageAction))
            {
                CloseForm();
                frmManageAction = new Screen.CRM.Members.frmManageActions();
                frmManageAction.key = key;
                AddFormToMainPanel(frmManageAction);
            }
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            if (frmEmployee == null || !Form.ActiveForm.Contains(frmEmployee))
            {
                CloseForm();
                //frmEmployee = new frmEmployee();
                Screen.CRM.Setting.frmMasterSetting frmMaster = new Screen.CRM.Setting.frmMasterSetting();
                AddFormToMainPanel(frmMaster);
            }
            
        }

        private void btnEmployeeType_Click(object sender, EventArgs e)
        {
            if (frmEmpType == null || !Form.ActiveForm.Contains(frmEmpType))
            {
                CloseForm();
                frmEmpType = new frmEmployeeType();
                AddFormToMainPanel(frmEmpType);
            }
        }

        private void btnCustomerType_Click(object sender, EventArgs e)
        {
            if (frmCusType == null || !Form.ActiveForm.Contains(frmCusType))
            {
                CloseForm();
                frmCusType = new frmCustommerType();
                AddFormToMainPanel(frmCusType);
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfiguration config = new frmConfiguration();
            config.Show();
        }

        //Linh 04-12-2014
        private string getLocalIp()
        {
            string hostName = Dns.GetHostName();
            string myIP = "";
            for (int i = 0; i < Dns.GetHostEntry(hostName).AddressList.Length; i++)
            {
                if (!Dns.GetHostEntry(hostName).AddressList[i].IsIPv6LinkLocal)
                {
                    myIP = Dns.GetHostEntry(hostName).AddressList[i].ToString();
                    break;
                }
            }
            return myIP;
        }

        //Linh 04-12-2014
        private string getExternalIp()
        {
            try
            {
                string externalIP;
                externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
                externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"))
                             .Matches(externalIP)[0].ToString();
                return externalIP;
            }
            catch { return null; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUpGrade_Click(object sender, EventArgs e)
        {
            //frmKeyActivation frm = new frmKeyActivation();
            //frm.ShowDialog();
        }


    }
}
