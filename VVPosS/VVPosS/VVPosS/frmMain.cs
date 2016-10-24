#region (c) 2014 Viet Vang - All rights reserved
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
 * Project		: VVPosS
 * Class		: frmMain
 * Developer    : Huỳnh Thị Ngọc Dung
 */
#endregion

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
using VVPosS.Screen.POS;
//using VVPosS.Screen.Members;
using System.Reflection;
using VVPosS.BusinessLayer;
using System.Diagnostics;
using VVPosS.Screen;
using System.Drawing.Printing;
using System.Configuration;

namespace VVPosS
{
    public partial class frmMain : Form
    {
        #region Variable
        /// <summary>
        /// object of frmServices
        /// </summary>
        private frmServices frmServices;
        /// <summary>
        /// object of frmMoveTable
        /// </summary>
        private frmMoveTable frmMoveTable;
        /// <summary>
        /// object of frmManageDesk
        /// </summary>
        private frmManageDesk frmManageDesk;
        //private fr
        /// <summary>
        /// object of frmPayments
        /// </summary>
        private frmReceipt frmPayments;
        /// <summary>
        /// object of frmChangePassword
        /// </summary>
        private frmChangePassword frmChangePassword;
        /// <summary>
        /// object of frmUtility
        /// </summary>
        private frmUtility frmUtility;
        /// <summary>
        /// object of frmManageBankCard
        /// </summary>
        private frmManageBankCard frmManageBankCard;
        
        #endregion

        #region Contructor

        public frmMain()
        {
            InitializeComponent();
            //set color for control on form
            SettingControl();
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
        /// Event raise when user click register service button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegisterService_Click(object sender, EventArgs e)
        {
            //if form services current not open is open it
            if (frmServices == null || !Form.ActiveForm.Contains(frmServices))
            {
                //CloseForm();
                this.Visible = false;
                frmServices = new Screen.POS.frmServices();
                frmServices.Show();
                //AddFormToMainPanel(frmServices);
                
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
            if(frmLanguage.ShowDialog() == DialogResult.Cancel){
                //get blag from form language
                bool blag = frmLanguage.Blag;
                //if change langauge (blag is true)
                if (blag)
                {
                    //set text to language for form
                    SetUIChanges();
                    CloseForm();
                }
            }
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
            SetCountOrders();
            lbFullname.Text = Program.FullName;

            //Version
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.Reflection.AssemblyName an = a.GetName();
            //FileVersionInfo fv = System.Diagnostics.FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
            //Version v = an.Version;
            lbVersion.Text = an.Name + " - v" + an.Version.Major + "." + an.Version.Minor + "\nUpdate: " + System.IO.File.GetLastWriteTime(a.ManifestModule.ToString()).ToString("dd/MM/yyyy HH:mm");
        }

        

        #endregion

        #region User method

        /// <summary>
        /// Setting color for control on form
        /// </summary>
        private void SettingControl()
        {
            this.Size = new Size(1024, 768);
            this.gbTotalCustomer.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            //this.btnTotalCustomer.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLORWHILE);
            /*this.analogClock.Draw1MinuteTicks = false;
            this.analogClock.Draw5MinuteTicks = true;
            this.analogClock.HourHandColor = System.Drawing.Color.HotPink;
            this.analogClock.MinuteHandColor = System.Drawing.Color.MediumAquamarine;
            this.analogClock.SecondHandColor = System.Drawing.Color.Yellow;
            this.analogClock.TicksColor = System.Drawing.Color.Blue;*/
        }

        /// <summary>
        /// Set text for control
        /// </summary>
        public void SetUIChanges()
        {
            bntChangePass.Text = Common.clsLanguages.GetResource("ChangePassword");
            bntLogout.Text = Common.clsLanguages.GetResource("Logout");
            btnRegisterService.Text = Common.clsLanguages.GetResource("ServicesRegistry");
            btnBan.Text = Common.clsLanguages.GetResource("ManageDesk");
            btnPayment.Text = Common.clsLanguages.GetResource("Payment");
            btnLanguage.Text = Common.clsLanguages.GetResource("Language");
            btnExit.Text = Common.clsLanguages.GetResource("Exit");
            btnMoveDesk.Text = Common.clsLanguages.GetResource("MoveTable1");
            gbTotalCustomer.Text = Common.clsLanguages.GetResource("TotalOrderNotPayment");
            btnConfig.Text = Common.clsLanguages.GetResource("Config");//
            btnMngCard.Text = Common.clsLanguages.GetResource("ManageBankCard");
            lbVersion.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            btnReport.Text = Common.clsLanguages.GetResource("TotalRevenue");
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
        private void AddFormToMainPanel(Form frm)
        {
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;

            pnMainContainer.Controls.Add(frm);
        }

        /// <summary>
        /// Close form not frmMain, frmManagement, frmLogin
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

        public void SetCountOrders() {
            OrderBLL orderBLL = new OrderBLL();
            this.btnTotalCustomer.Text = orderBLL.GetCountOrderByStatus("0").Rows[0][0].ToString();
        }

        #endregion

        /// <summary>
        /// Event raise when user click Desk button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBan_Click(object sender, EventArgs e)
        {
            //if form manage Desk is not open is open it
            if (frmManageDesk == null || !Form.ActiveForm.Contains(frmManageDesk))
            {
                //this.Visible = false;
                frmManageDesk = new Screen.POS.frmManageDesk();
                //AddFormToMainPanel(frmManageDesk);
                frmManageDesk.Show();
            }
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

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (frmPayments == null || !Form.ActiveForm.Contains(frmPayments))
            {
                //CloseForm();
                this.Visible = false;
                frmPayments = new Screen.POS.frmReceipt();
                frmPayments.Show();
                //AddFormToMainPanel(frmServices);

            }
        }

        private void btnMoveDesk_Click(object sender, EventArgs e)
        {
            if (frmMoveTable == null || !Form.ActiveForm.Contains(frmMoveTable))
            {
                //CloseForm();
                this.Visible = false;
                frmMoveTable = new Screen.POS.frmMoveTable();
                frmMoveTable.Show();
                //AddFormToMainPanel(frmServices);

            }
        }

        private void gbTotalCustomer_Paint(object sender, PaintEventArgs e)
        {
            //GroupBox box = sender as GroupBox;
            //Common.Utility.DrawGroupBox(box, e.Graphics, Color.White, Color.White, this);

            //box.BackColor = Color.Transparent;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmUtility = new frmUtility();
            frmUtility.ShowDialog();
        }

        private void btnMngCard_Click(object sender, EventArgs e)
        {
            //if form manage BankCard is not open is open it
            if (frmManageBankCard == null || !Form.ActiveForm.Contains(frmManageBankCard))
            {
                frmManageBankCard = new Screen.POS.frmManageBankCard();
                frmManageBankCard.Show();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DoPrinting();
        }

        #region Do Printing
        private bool DoPrinting()
        {
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A7", 300, 10000);
            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            pd.Print();
            return true;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ReceiptsBLL objBLL = new ReceiptsBLL();
            // load data hoa don
            DataTable rcAll = objBLL.GetReceipts();
            int y_p = 0;
            int h_s = 0;

            /// 

            StringFormat strfmt_Left = new StringFormat();
            StringFormat strfmt_Center = new StringFormat();
            StringFormat strfmt_Right = new StringFormat();
            StringFormat strfmt_Left_Right = new StringFormat();
            StringFormat strfmt_Center_Right = new StringFormat();
            StringFormat strfmt_Right_Center = new StringFormat();
            StringFormat strfmt_Left_Center = new StringFormat();

            strfmt_Left.LineAlignment = StringAlignment.Near;
            strfmt_Left.Alignment = StringAlignment.Near;

            strfmt_Center.LineAlignment = StringAlignment.Center;
            strfmt_Center.Alignment = StringAlignment.Center;

            strfmt_Right.LineAlignment = StringAlignment.Far;
            strfmt_Right.Alignment = StringAlignment.Far;

            strfmt_Left_Right.LineAlignment = StringAlignment.Far;
            strfmt_Left_Right.Alignment = StringAlignment.Near;

            strfmt_Center_Right.LineAlignment = StringAlignment.Far;
            strfmt_Center_Right.Alignment = StringAlignment.Center;

            strfmt_Right_Center.LineAlignment = StringAlignment.Center;
            strfmt_Right_Center.Alignment = StringAlignment.Far;

            strfmt_Left_Center.LineAlignment = StringAlignment.Center;
            strfmt_Left_Center.Alignment = StringAlignment.Near;

            // Logo
            var imgLogo = Common.Utility.GetImageFromService("ShopImg", "logoPrint.png");
            Rectangle logo = new Rectangle(5, 10, 60, 40);
            e.Graphics.DrawImage(imgLogo, logo);

            Rectangle strHoaDon = new Rectangle(120, 5, 165, 20);
            string data = Common.clsLanguages.GetResource("TotalRevenue");//"Doanh thu";
            e.Graphics.DrawString(data, new Font("Arial", 12, FontStyle.Bold), Brushes.DarkSlateBlue, strHoaDon, strfmt_Right);

            //Ngày hóa đơn
            Rectangle strRec = new Rectangle(80, 25, 200, 15);
            data = DateTime.Now.ToString("yyyy-MM-dd"); //"Ngày :"
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.DarkSlateBlue, strRec, strfmt_Right);

            /*
            Rectangle RecLine1 = new Rectangle(110, 40, 170, 2);
            var Line1 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line1, RecLine1);

            Rectangle strRec1 = new Rectangle(145, 42, 135, 18);
            string strSoHD = rcAll.receipt.ReceiptId;
            int soHD = int.Parse(strSoHD.Substring(10));
            data = Common.clsLanguages.GetResource("ReceiptNumber") + " : 10#" + soHD.ToString(); //"Số HĐ: "
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Italic), Brushes.DarkSlateBlue, strRec1, strfmt_Right);
            */
            //// Cty....
            /*Rectangle strCty = new Rectangle(5, 50, 140, 40);//20
            data = Common.clsLanguages.GetResource("MerchantName");// "Công ty CP Việt Vang";           
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.DarkSlateBlue, strCty, strfmt_Left);
            //Địa chỉ Cty
            Rectangle strDCCty = new Rectangle(5, 90, 290, 60);//50
            data = Common.clsLanguages.GetResource("MerchantAddress") + "\n" + Common.clsLanguages.GetResource("MerchantTel") + "\n" + Common.clsLanguages.GetResource("MerchantWeb");
            e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.DarkSlateBlue, strDCCty, strfmt_Left);
            */
            //Headers
            Rectangle strHD_STT = new Rectangle(3, 50, 30, 18);
            data = Common.clsLanguages.GetResource("No");// "STT";           
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, strHD_STT, strfmt_Center);

            Rectangle strHD_SP = new Rectangle(33, 50, 187, 18);
            data = Common.clsLanguages.GetResource("Receipt");//"Hóa đơn ";           
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, strHD_SP, strfmt_Left);

            /*Rectangle strHD_SL = new Rectangle(130, 150, 30, 18);
            data = Common.clsLanguages.GetResource("ReceiptProQty");//"SL";
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, strHD_SL, strfmt_Center);

            Rectangle strHD_DG = new Rectangle(160, 150, 60, 18);
            data = Common.clsLanguages.GetResource("ReceiptProPrice");//"ĐG";
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, strHD_DG, strfmt_Center);*/

            Rectangle strHD_TT = new Rectangle(160, 50, 110, 18);
            data = Common.clsLanguages.GetResource("TotalAmount");//ReceiptProTotalAfterTax "TT + Thuế";
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, strHD_TT, strfmt_Center);

            Rectangle RecLine2 = new Rectangle(5, 68, 290, 2);
            var Line2 = Common.Utility.GetImageFromService("ShopImg", "line2.png");
            e.Graphics.DrawImage(Line2, RecLine2);

            decimal totalMoney = 0;
            decimal serviceCostAmount = 0;
            decimal totalTax = 0;
            decimal totalAmount = 0;
            /*decimal cashPay = 0;
            decimal cardPay = 0;*/

            if ( rcAll.Rows.Count > 0)
            {
                y_p = 70;

                int i = 0;
                
                foreach (DataRow dtl in rcAll.Rows)
                {
                    i++;
                    //Headers
                    h_s = 22;
                    //Common.clsLanguages.GetResource("ProductID") + " " + dtl.ProductId + " - " +
                    double _dbLength = (dtl.ItemArray[0].ToString()).Length;
                    if (_dbLength > 97 / 5)
                    {
                        int _iCelling = (int)Math.Ceiling((_dbLength * 5) / 97);
                        h_s = 14 * _iCelling + 12;
                    }

                    /*if (dtl.IsBuffet == "0" || (dtl.IsBuffet == "1" && double.Parse(dtl.Price) > 0))
                    {*/
                        Rectangle strCT_STT = new Rectangle(3, y_p, 30, h_s);
                        data = i.ToString();
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_STT, strfmt_Center);

                        Rectangle strCT_SP = new Rectangle(33, y_p, 97, h_s);

                    string strSoHD = dtl.ItemArray[0].ToString();
                    int soHD = int.Parse(strSoHD.Substring(10));
                    data =  "10#" + soHD.ToString(); //"Số HĐ: "

                    //data = dtl.ItemArray[0].ToString();
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SP, strfmt_Left_Center);

                        /*Rectangle strCT_SL = new Rectangle(130, y_p, 30, h_s);
                        data = dtl.ItemArray[9].ToString();
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SL, strfmt_Center);

                        Rectangle strTT_DG = new Rectangle(160, y_p, 60, h_s);
                        //data = (double.Parse(dtl.Price) + (double.Parse(dtl.TaxAmount) / double.Parse(dtl.Qty))).ToString("0,0");
                        data = dtl.Price;
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strTT_DG, strfmt_Right_Center);
                        */
                        Rectangle strTT_TT = new Rectangle(160, y_p, 120, h_s);
                        data = Decimal.Parse(dtl.ItemArray[9].ToString()).ToString("#,##0");
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strTT_TT, strfmt_Right_Center);

                        totalMoney += Decimal.Parse(dtl.ItemArray[9].ToString());
                        serviceCostAmount += Decimal.Parse(dtl.ItemArray[5].ToString());
                        totalTax += Decimal.Parse(dtl.ItemArray[6].ToString());
                        totalAmount += Decimal.Parse(dtl.ItemArray[4].ToString());
                    //cashPay += Decimal.Parse(dtl.ItemArray[10].ToString());
                    //cardPay += Decimal.Parse(dtl.ItemArray[11].ToString());

                        y_p += h_s;
                        Rectangle RecLineCT = new Rectangle(5, y_p, 290, 1);
                        var LineCT = Common.Utility.GetImageFromService("ShopImg", "linect.png");
                        e.Graphics.DrawImage(LineCT, RecLineCT);
                    /*}
                    else
                    {
                        Rectangle strCT_SP = new Rectangle(43, y_p, 147, h_s);//60
                        data = dtl.ProductName;
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SP, strfmt_Left_Center);

                        Rectangle strCT_SL = new Rectangle(190, y_p, 30, h_s);
                        data = dtl.Qty;
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SL, strfmt_Right_Center);

                        y_p += h_s;
                        Rectangle RecLineCT = new Rectangle(43, y_p, 247, 1);
                        var LineCT = Common.Utility.GetImageFromService("ShopImg", "linect.png");
                        e.Graphics.DrawImage(LineCT, RecLineCT);

                    }*/


                }
            }


            ///Tổng tiền trước thuế /sau thuế
            Rectangle RecTTST = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalAmount");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecTTST, strfmt_Right);

            Rectangle RecTTST_Val = new Rectangle(200, y_p, 80, 15);
            data = totalAmount.ToString("#,##0");
            //data = String.Format("{ 0:C}", totalMoney.ToString());
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecTTST_Val, strfmt_Right);
            y_p = y_p + 15;

            ///phí dịch vụ
            Rectangle RecPDV = new Rectangle(40, y_p, 160, 15);
            data = Common.clsLanguages.GetResource("TaxAndServiceChange") + " (" + (int.Parse(ConfigurationManager.AppSettings["SeviceCostPercent"]) +
                int.Parse(ConfigurationManager.AppSettings["VAT"])) + " %)"; //Common.clsLanguages.GetResource("TotalServiceCharge");//
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecPDV, strfmt_Right);

            Rectangle RecPDV_Val = new Rectangle(200, y_p, 80, 15);
            data = (serviceCostAmount + totalTax).ToString("#,##0");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecPDV_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Giảm giá
            /*Rectangle RecDIS = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalDiscountAmount");//"Giảm giá ";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecDIS, strfmt_Right);

            Rectangle RecDIS_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.DiscountAmount;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecDIS_Val, strfmt_Right);
            y_p = y_p + 15;*/

            ///Tổng tiền thanh toán
            Rectangle RecPAY = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalMoney");//"TC Cần thanh toán";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecPAY, strfmt_Right);

            Rectangle RecPAY_Val = new Rectangle(200, y_p, 80, 15);
            data = totalMoney.ToString("#,##0");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecPAY_Val, strfmt_Right);
            y_p = y_p + 15;

            ////
            /*Rectangle RecLine3 = new Rectangle(90, y_p, 200, 1);
            var Line3 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line3, RecLine3);
            y_p = y_p + 2;*/

            ///Tổng tiền mặt
            /*Rectangle RecCASH = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("CashPayment");//Common.clsLanguages.GetResource("TotalCashCustomer");//"Tiền mặt khách đưa";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecCASH, strfmt_Right);

            Rectangle RecCASH_Val = new Rectangle(200, y_p, 80, 15);
            data = cashPay.ToString("#,##0.00");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecCASH_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Tổng tiền thẻ
            Rectangle RecCARD = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("CardPayment");//Common.clsLanguages.GetResource("TotalCardAmount");//"Tiền thẻ khách:";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecCARD, strfmt_Right);

            Rectangle RecCARD_Val = new Rectangle(200, y_p, 80, 15);
            data = cardPay.ToString("#,##0.00");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecCARD_Val, strfmt_Right);
            y_p = y_p + 15;*/

            ///Số tiền thối lại
            /*Rectangle RecRefun = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalReturnAmount");//Common.clsLanguages.GetResource("TotalCardAmount");//"Tiền thẻ khách:";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecRefun, strfmt_Right);

            Rectangle RecRefun_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.ReturnAmt;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecRefun_Val, strfmt_Right);
            y_p = y_p + 15;

            if (rcAll.receiptMember != null && !string.IsNullOrEmpty(rcAll.receiptMember.MemberId))
            {
                ////
                Rectangle RecLine5 = new Rectangle(5, y_p, 290, 2);
                var Line5 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
                e.Graphics.DrawImage(Line5, RecLine5);
                y_p = y_p + 4;

                Rectangle RecTTKH = new Rectangle(10, y_p, 160, 18);
                data = Common.clsLanguages.GetResource("CustomerInformation");//"Thông tin khách hàng";
                e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecTTKH, strfmt_Left);
                y_p = y_p + 18;

                Rectangle RecTTKH1 = new Rectangle(10, y_p, 190, 15);
                data = Common.clsLanguages.GetResource("FullName") + " : " + rcAll.receiptMember.FullName;
                e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, RecTTKH1, strfmt_Left);

                Rectangle RecTTKH1A = new Rectangle(205, y_p, 90, 15);
                data = Common.clsLanguages.GetResource("TotalScore") + " : " + rcAll.receiptMember.MemberScore;
                e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, RecTTKH1A, strfmt_Left);
                y_p = y_p + 15;

                Rectangle RecTTKH2 = new Rectangle(10, y_p, 190, 15);
                data = Common.clsLanguages.GetResource("MemberID") + " : " + rcAll.receiptMember.MemberId;
                e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, RecTTKH2, strfmt_Left);
                y_p = y_p + 15;
            }
            */
            ////
            Rectangle RecLine6 = new Rectangle(5, y_p, 290, 2);
            var Line6 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line6, RecLine6);
            y_p = y_p + 4;

            Rectangle RecTK = new Rectangle(5, y_p, 190, 18);
            //data = Common.clsLanguages.GetResource("ReceiptFooterText"); //"Cám ơn & hẹn gặp lại quý khách !";
            data = Common.clsLanguages.GetResource("MerchantName");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Italic), Brushes.Black, RecTK, strfmt_Left);

            //Rectangle RecPower = new Rectangle(200, y_p, 95, 47);
            //var LineP = Common.Utility.GetImageFromService("VVImg", "powered by vv.emf");
            //e.Graphics.DrawImage(LineP, RecPower);
            //y_p = y_p + 47;

            // show các PromoText
            /*DataTable dtPromo = RptsBLL.GetValidPromotionToPrint();
            if (dtPromo != null && dtPromo.Rows.Count > 0)
            {
                ////
                Rectangle RecLine7 = new Rectangle(5, y_p, 290, 1);
                var Line7 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
                e.Graphics.DrawImage(Line7, RecLine7);
                y_p = y_p + 4;
                //////
                foreach (DataRow dr in dtPromo.Rows)
                {
                    Rectangle RecPromo = new Rectangle(5, y_p, 290, 130);
                    data = "\n---------------\n" + dr["PromoText"].ToString() + "\n---------------\n";
                    e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Italic), Brushes.Black, RecPromo, strfmt_Center);
                    y_p = y_p + 130;
                }
            }*/

        }
        #endregion
    }
}
