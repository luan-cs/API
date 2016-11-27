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
using System.Reflection; 
using VVPosM1.BusinessLayer;
using VVPosM1.Screen;
using System.Diagnostics;
using System.Configuration;
using VVPosM1.BusinessLayer.BLLCRM;

#endregion

namespace VVPosM1
{
    public partial class frmMain : Form
    {
        #region Variable
        private Dictionary<Type, Form> SingleInstanceForms = new Dictionary<Type, Form>();

        private frmChangePassword frmChangePassword;

        protected Form ActivateForm<T>() where T : Form, new()
        {
            //Close From
            CloseForm();
            //
            if (!this.SingleInstanceForms.ContainsKey(typeof(T)))
            {
                T newForm = new T();
                // Set up the necessary properties
                newForm.FormClosed += new FormClosedEventHandler(delegate(object sender, FormClosedEventArgs e)
                {
                    this.SingleInstanceForms.Remove(sender.GetType());
                });

                this.SingleInstanceForms.Add(typeof(T), newForm);
            }
            
            Form formToActivate = this.SingleInstanceForms[typeof(T)];
            formToActivate.TopLevel = false;
            formToActivate.ControlBox = false;
            formToActivate.ShowIcon = false;
            formToActivate.Dock = DockStyle.Fill;
            formToActivate.WindowState = FormWindowState.Maximized;
            this.pMain.Controls.Add(formToActivate);
            formToActivate.Show();
            formToActivate.Activate();

            return formToActivate;
        }

        /// <summary>
        /// Close form not frmMain, frmLogin
        /// </summary>
        private void CloseForm()
        {
            foreach (Form f in GetFormListActive())
            {
                if (f.Name != "frmMain" && f.Name != "frmLogin")
                {
                    f.Close();
                }
            }
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
        #endregion

        #region Contructor

        public frmMain()
        {
            InitializeComponent();
            //set color for control on form
            SetUIChanges();
            SettingControl();
            

        }

        public void SetUIChanges()
        {
            this.Text= Common.clsLanguages.GetResource("SoftwareTilte");
            this.toolStripMenuItem1.Text = Common.clsLanguages.GetResource("GeneralInformation");
            this.objectToolStripMenuItem.Text = Common.clsLanguages.GetResource("ManagerUser");
            this.productToolStripMenuItem.Text = Common.clsLanguages.GetResource("Product");
            this.promotionToolStripMenuItem.Text = Common.clsLanguages.GetResource("Promotion");
            this.recieptToolStripMenuItem.Text = Common.clsLanguages.GetResource("Receipt");
           // this.utilityToolStripMenuItem.Text = Common.clsLanguages.GetResource("Report_Statistics");

            this.reportToolStripMenuItem.Text = Common.clsLanguages.GetResource("Report_Statistics");
            this.mnReport.Text = Common.clsLanguages.GetResource("ReportPriceOfProduct");
            this.BaoCaoDoanhThuToolStripMenuItem.Text = Common.clsLanguages.GetResource("ReportOfEmployeeRevenues2");
            this.ByProductToolStripMenuItem.Text = Common.clsLanguages.GetResource("ReportByProduct2");
            this.RpHourToolStripMenuItem.Text = Common.clsLanguages.GetResource("ReportByHour2");
            this.RpMonthToolStripMenuItem.Text = Common.clsLanguages.GetResource("ReportByMonth2");
            this.RpABCToolStripMenuItem.Text = Common.clsLanguages.GetResource("ABCAnalysisReport2");

            this.mnProducts.Text = Common.clsLanguages.GetResource("Product");
            this.mnProductPrice.Text = Common.clsLanguages.GetResource("ProductPrice");
            this.mnPromotion.Text = Common.clsLanguages.GetResource("Promotion");
            this.utilityToolStripMenuItem.Text = Common.clsLanguages.GetResource("Utilities");
            this.mnReciept.Text = Common.clsLanguages.GetResource("ReceiptOfPaymentManagement");
            this.orderToolStripMenuItem.Text = Common.clsLanguages.GetResource("OrderManagement");
            //this.mnPromotion.Text = Common.clsLanguages.GetResource("PromotionManagement");
           // this.orderToolStripMenuItem.Text = Common.clsLanguages.GetResource("Promotion");

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
            DialogResult dr = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AreYouSureExit"),
                        Common.clsLanguages.GetResource("Information"),
                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
            //exit if yes
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Event raise when user click languages button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLanguage_Click(object sender, EventArgs e)
        {
            //open form language
            frmLanguages frmLanguage = new frmLanguages();
            frmLanguage.ShowDialog();
            //get blag from form language
            bool blag = frmLanguage.Blag;
            //if change langauge (blag is true)
            if (blag)
            {
                //set text to language for form
                SetUIChanges();
                foreach (Form frm in Application.OpenForms)
                {
                    //if current screen is Services is load again
                    if (frm.Name == "frmServices")
                    {
                        //frm.Close();
                        //frmServices = new frmServices();
                        //AddFormToMainPanel(frmServices);
                        //break;
                    }
                    ////if current screen is Payments is load again
                    //if (frm.Name == "frmPayments")
                    //{
                    //    frm.Close();
                    //    frmPayments = new frmPayments();
                    //    AddFormToMainPanel(frmPayments);
                    //    break;
                    //}
                    ////if current screen is ManageMember is load again
                    //if (frm.Name == "frmManageMembers")
                    //{
                    //    frm.Close();
                    //    frmManageMembers = new frmManageMembers();
                    //    AddFormToMainPanel(frmManageMembers);
                    //    break;
                    //}
                }
            }

        }

        /// <summary>
        /// Event raise when user click manage button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManage_Click(object sender, EventArgs e)
        {
            ////if form management is hide, show form management
            //if (Application.OpenForms["frmManagement"] != null)
            //{
            //    Screen.Administrator.frmManagement frm = (Screen.Administrator.frmManagement)Application.OpenForms["frmManagement"];
            //    frm.SetUIChanges();
            //    frm.Show();
            //    //Application.OpenForms["frmManagement"].Show();
            //}
            //else //if form management is not hide, create form management and show
            //{
            //    Screen.Administrator.frmManagement frmManage = new Screen.Administrator.frmManagement();
            //    frmManage.Show();
            //}
            ////hide form main
            //this.Hide();
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
        }


        /// <summary>
        /// Event raise when user click timekeeping button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimekeeping_Click(object sender, EventArgs e)
        {
            //open form timekeeping
            //frmTimekeepings = new frmTimekeepings();
            //frmTimekeepings.ShowDialog();
        }
        #endregion

        #region User method

        /// <summary>
        /// get employee information to show
        /// </summary>
        private void GetEmployeeInformation()
        {
            //employeeBLL = new EmployeeBLL();
            //lblFullName.Text = Program.employee.EmployeeName;
            //pbImage.BackgroundImage = Common.ge
        }

        /// <summary>
        /// Setting color for control on form
        /// </summary>
        private void SettingControl()
        {
            this.Size = new Size(1024, 768);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.BACKGROUNDCOLOR);
            this.BackgroundImage = Common.Utility.GetImageFromService("ShopImg", "bg7.png");

        }

        /// <summary>
        /// Set text for control
        /// </summary>




        /// <summary>
        /// Count number of customer is visitting spa
        /// </summary>
        public void SetCountCustomer()
        {
            //ReceiptBLL receiptBLL = new ReceiptBLL();
            //this.btnTotalCustomer.Text = receiptBLL.CountCurrentCustomerInNow(DateTime.Now.ToString("yyyy-MM-dd"), 0).ToString();
        }


        #endregion

        private void btnCRM_Click(object sender, EventArgs e)
        {
            //if form manage members is not open is open it
            //if (frmManageAction == null || !Form.ActiveForm.Contains(frmManageAction))
            //{
            //    CloseForm();
            //    frmManageAction = new Screen.Members.frmManageActions();
            //    AddFormToMainPanel(frmManageAction);
            //}
        }


        /// <summary>
        /// Event raise when user click change password button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntChangePass_Click(object sender, EventArgs e)
        {
            //open form change password
            frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
        }

        /// <summary>
        /// Event raise when user click logout button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntLogout_Click(object sender, EventArgs e)
        {
            //Show messagebox : are you sure to logout?
            DialogResult dr = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AreYouSureWantToExit"),
                        Common.clsLanguages.GetResource("Information"),
                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
            //if yes is open form login and close form main
            if (dr == DialogResult.Yes)
            {
                frmLogin frm = (frmLogin)Application.OpenForms["frmLogin"];
                frm.SetUIChanges();
                frm.Show();
                this.Close();
            }
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnObject_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmManageOject>();
        }

        private void mnUser_Click(object sender, EventArgs e)
        {

            this.ActivateForm<frmManageEmployee>();

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Program.user.RoleId == "admin")
            {
                this.ActivateForm<frmManageUser>();
            }
            else
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NoRole"),
                                        Common.clsLanguages.GetResource("Information"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }

        }


        private void mnReport_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmRpt_ProductPrice>();
        }

        private void mnProducts_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmManageProduct>();
        }


        private void mnReciept_Click(object sender, EventArgs e)
        {
            frmManageReceip f = new frmManageReceip();
            f.Show();
        }

        private void mnCommonCode_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmCommonCode>();
        }





        private void commonTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmCommonType>();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmOrder>();
        }

        private void mnReciept_Click_1(object sender, EventArgs e)
        {
            this.ActivateForm<frmManageReceip>();
        }

        private void mnProductPrice_Click(object sender, EventArgs e)
        {
            //frmManageProductPrice f = new frmManageProductPrice();
            //f.Show();

            this.ActivateForm<frmManageProductPrice>();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmRpt_DoanhThu>();
        }

        private void báoCáoDoanhSốTheoSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmRpt_ByProduct>();
        }

        private void báoCáoDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmRpt_RevenueProductHour>();
        }

        private void báoCáoDoanhThuTheoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmRpt_TotalCustomerProductMoth>();
        }

        private void báoCáoABCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmRpt_ABC>();
        }

        private void báoCáoDoanhSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.ActivateForm<formRptTotalAmountByProduct>();
        }

        private void mnChangepassword_Click(object sender, EventArgs e)
        {
            frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
        }

        private void mnLogout_Click(object sender, EventArgs e)
        {

            //Show messagebox : are you sure to logout?
            DialogResult dr = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AreYouSureWantToExit"),
                        Common.clsLanguages.GetResource("Information"),
                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
            //if yes is open form login and close form main
            if (dr == DialogResult.Yes)
            {
                frmLogin frm = (frmLogin)Application.OpenForms["frmLogin"];
                frm.SetUIChanges();
                frm.Show();
                this.Close();
            }
        }

        private void mnLanguages_Click(object sender, EventArgs e)
        {
            //open form language
            frmLanguages frmLanguage = new frmLanguages();
            if (frmLanguage.ShowDialog() == DialogResult.Cancel)
            {
                //get blag from form language
                bool blag = frmLanguage.Blag;
                //if change langauge (blag is true)
                if (blag)
                {
                    //set text to language for form
                    SetUIChanges();
                    foreach (Form frm in Application.OpenForms)
                    {
                        //if current screen is Services is load again
                        if (frm.Name == "frmServices")
                        {
                            frm.Close();
                            //frmServices = new frmServices();
                            //AddFormToMainPanel(frmServices);
                            break;
                        }
                        ////if current screen is Payments is load again
                        //if (frm.Name == "frmPayments")
                        //{
                        //    frm.Close();
                        //    frmPayments = new frmPayments();
                        //    AddFormToMainPanel(frmPayments);
                        //    break;
                        //}
                        ////if current screen is ManageMember is load again
                        //if (frm.Name == "frmManageMembers")
                        //{
                        //    frm.Close();
                        //    frmManageMembers = new frmManageMembers();
                        //    AddFormToMainPanel(frmManageMembers);
                        //    break;
                        //}
                    }
                }
            }
        }     

        private void cRMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Process p = new Process();
            //p.StartInfo.FileName = ConfigurationManager.AppSettings["CallExe"];
            //p.Start();

           // this.ActivateForm<VVPosM1.CRM.frmMain1>();
           //userIroleBLL = new UserInRole();
           // Program.lstRole = userIroleBLL.GetRoleOfUser(Program.employee1.EmployeeId);
           // this.Close();
           // VVPosM1.CRM.frmMain1 frm = new VVPosM1.CRM.frmMain1();
           // frm.Show();
        }

        private void ReportCardBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmRpt_Card>();
        }

        private void quảnLýĐịnhLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmManageMeasure>();
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmInput frm = new frmInput();
            //frm.ShowDialog();
            this.ActivateForm<frmInput>();
        }

        private void NccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmManageSupplier>();
            
            //frmManageSupplier f = new frmManageSupplier();
            //f.TopLevel = false;
            ////f.ControlBox = false;
            //f.Dock = DockStyle.Top;
            //f.WindowState = FormWindowState.Maximized; ;
            ////f.FormBorderStyle = FormBorderStyle.FixedSingle;

            ///*I assume this code is in your ParentForm and so 'this' points to ParentForm that contains ContainerPanel*/
            //this.pMain.Controls.Add(f);
            //f.Show();
        }

        private void ingreadientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmManageIngreadient>();
        }

        private void baoCaoTônKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActivateForm<frmRpt_Inventory>();
        }
    }
}

