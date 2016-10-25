using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosS.BusinessLayer;
using VVPosS.Entities;

namespace VVPosS.Screen.POS
{
    public partial class PayForm : Form
    {
        private frmServices frmServices;

        private ReceiptsBLL RptsBLL = new ReceiptsBLL();
        private string ReceiptID_Success;
        private double TotalMoney = 0;
        public PayForm()
        {
            InitializeComponent();
            SettingControl();
        }

        public PayForm(frmServices frmS, double totalMoney)
        {
            InitializeComponent();
            SettingControl();
            frmServices = frmS;
            TotalMoney = totalMoney;
        }

        #region Private Methods
        public void SetUIChanges()
        {
            //this.btnPrint.Text = Common.clsLanguages.GetResource("PrintBill");
            this.btnComplete.Text = Common.clsLanguages.GetResource("Payment");

            //
            this.lblTotalBeforeTax.Text = Common.clsLanguages.GetResource("TotalAmountBeforeTax");
            this.lblMoneyVAT.Text = Common.clsLanguages.GetResource("TotalTaxAmount");
            this.lblTotalAfterTax.Text = Common.clsLanguages.GetResource("TotalAmountAfterTax");
            this.lblServiceCharge.Text = Common.clsLanguages.GetResource("TotalServiceCharge");

            //
            this.lblDiscount.Text = Common.clsLanguages.GetResource("TotalDiscountAmount");
            this.lblTotalPricePayment.Text = Common.clsLanguages.GetResource("TotalMoney");
            this.lblReceiveMoney.Text = Common.clsLanguages.GetResource("TotalCashCustomer");
            this.lblCard.Text = Common.clsLanguages.GetResource("TotalCardAmount");
            this.lblReturnMoney.Text = Common.clsLanguages.GetResource("TotalReturnAmount");

        }

        private void SettingControl()
        {
            this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;

            this.lblAmt_Card.ForeColor = this.lblAmt_ReturnAmt.ForeColor = this.lblAmt_TotalAfterTax.ForeColor =
                this.lblAmt_TotalAmount.ForeColor = this.lblAmt_TotalAmtBeforeTax.ForeColor = this.lblAmt_TotalTax.ForeColor =
                this.lblCard.ForeColor = this.lblDiscount.ForeColor = this.lblMoneyVAT.ForeColor =
                this.lblReceiveMoney.ForeColor = this.lblReturnMoney.ForeColor = this.lblTotalAfterTax.ForeColor =
                this.lblTotalBeforeTax.ForeColor = this.lblTotalPricePayment.ForeColor = this.lblServiceCharge.ForeColor =
                this.lblServiceChargeVal.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
        }

        private void ToUpper()
        {
            foreach (Control c in this.Controls)
            {
                Button btn = c as Button;
                if (btn != null)
                    btn.Text = btn.Text.ToUpper();
            }
        }
        #endregion

        #region Controls Event
        private void PayForm_Load(object sender, EventArgs e)
        {
            SetUIChanges();
            ToUpper();
            //
            this.lblServiceCharge.Text = this.lblServiceCharge.Text + " (" + ConfigurationManager.AppSettings["SeviceCostPercent"] + "%)";
            this.lblMoneyVAT.Text = this.lblMoneyVAT.Text + " (" + ConfigurationManager.AppSettings["VAT"] + "%)";
            if (ConfigurationManager.AppSettings["DiscountPercent"] == "1")
                this.lblDiscount.Text = this.lblDiscount.Text + " (%)";
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmServices f = new frmServices();
            //f.Visible = true;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //todo
            //after success clear data order
           if(frmServices != null)
                frmServices.ClearDataGridView();
           this.Close();
        }

        private void btnPrintTemp_Click(object sender, EventArgs e)
        {
            if (!DoPrinting("1"))
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NotFoundPrintPleaseCheck"),
                      Common.clsLanguages.GetResource("Information"),
                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        }

        #region Do Printing
        private bool DoPrinting(string Status)
        {
            PrintDocument pd = new PrintDocument();
            //pd.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["Printer"];
            pd.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A7", 300, 10000);
            if (Status == null)
                pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            //else pd.PrintPage += new PrintPageEventHandler(this.printDocumentTemp_PrintPage);

            pd.Print();


            return true;
        }

        private void printDocument1_PrintPage1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // load data hoa don
            ReceiptsAll rcAll = RptsBLL.GetAllInfo(ReceiptID_Success);
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
            string data = Common.clsLanguages.GetResource("Receipt");//"HÓA ĐƠN";
            e.Graphics.DrawString(data, new Font("Arial", 12, FontStyle.Bold), Brushes.DarkSlateBlue, strHoaDon, strfmt_Right);

            //Ngày hóa đơn
            Rectangle strRec = new Rectangle(80, 25, 200, 15);
            data = Common.clsLanguages.GetResource("ReceiptDate") + rcAll.receipt.CreatedDate; //"Ngày :"
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.DarkSlateBlue, strRec, strfmt_Right);


            Rectangle RecLine1 = new Rectangle(110, 40, 170, 2);
            var Line1 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line1, RecLine1);

            //Rectangle strRec1 = new Rectangle(145, 42, 135, 18);
            //string strSoHD = rcAll.receipt.ReceiptId;
            //int soHD = int.Parse(strSoHD.Substring(10));
            //data = Common.clsLanguages.GetResource("ReceiptNumber") + " : 10#" + soHD.ToString(); //"Số HĐ: "
            //e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Italic), Brushes.DarkSlateBlue, strRec1, strfmt_Right);

            //// Cty....
            Rectangle strCty = new Rectangle(5, 50, 140, 40);//20
            data = Common.clsLanguages.GetResource("MerchantName");// "Công ty CP Việt Vang";           
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.DarkSlateBlue, strCty, strfmt_Left);
            //Địa chỉ Cty
            Rectangle strDCCty = new Rectangle(5, 90, 290, 60);//50
            data = Common.clsLanguages.GetResource("MerchantAddress") + "\n" + Common.clsLanguages.GetResource("MerchantTel") + "\n" + Common.clsLanguages.GetResource("MerchantWeb");
            e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.DarkSlateBlue, strDCCty, strfmt_Left);

            //Headers
            Rectangle strHD_STT = new Rectangle(3, 150, 30, 18);
            data = Common.clsLanguages.GetResource("No");// "STT";           
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, strHD_STT, strfmt_Center);

            Rectangle strHD_SP = new Rectangle(33, 150, 97, 18);
            string strSoHD = rcAll.receipt.ReceiptId;
            int soHD = int.Parse(strSoHD.Substring(10));
            data = Common.clsLanguages.GetResource("ReceiptNumber") + " : 10#" + soHD.ToString();

            //Rectangle strHD_SL = new Rectangle(130, 150, 30, 18);
            //data = Common.clsLanguages.GetResource("ReceiptProQty");//"SL";
            //e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, strHD_SL, strfmt_Center);

            //Rectangle strHD_DG = new Rectangle(160, 150, 60, 18);
            //data = Common.clsLanguages.GetResource("ReceiptProPrice");//"ĐG";
            //e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, strHD_DG, strfmt_Center);

            Rectangle strHD_TT = new Rectangle(220, 150, 70, 18);
            data = Common.clsLanguages.GetResource("ReceiptProTotal");//ReceiptProTotalAfterTax "TT + Thuế";
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, strHD_TT, strfmt_Center);

            Rectangle RecLine2 = new Rectangle(5, 168, 290, 2);
            var Line2 = Common.Utility.GetImageFromService("ShopImg", "line2.png");
            e.Graphics.DrawImage(Line2, RecLine2);

            if (rcAll.lst_Detail != null && rcAll.lst_Detail.Count > 0)
            {
                y_p = 170;

                int i = 0;
                foreach (ReceiptDetails dtl in rcAll.lst_Detail)
                {
                    i++;
                    //Headers
                    h_s = 22;
                    //Common.clsLanguages.GetResource("ProductID") + " " + dtl.ProductId + " - " +
                    double _dbLength = (dtl.ProductName).Length;
                    if (_dbLength > 97 / 5)
                    {
                        int _iCelling = (int)Math.Ceiling((_dbLength * 5) / 97);
                        h_s = 14 * _iCelling + 12;
                    }

                    if (dtl.IsBuffet == "0" || (dtl.IsBuffet == "1" && double.Parse(dtl.Price) > 0))
                    {
                        Rectangle strCT_STT = new Rectangle(3, y_p, 30, h_s);
                        data = i.ToString();
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_STT, strfmt_Center);

                        Rectangle strCT_SP = new Rectangle(33, y_p, 97, h_s);
                        data = dtl.ProductName;
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SP, strfmt_Left_Center);

                        Rectangle strCT_SL = new Rectangle(130, y_p, 30, h_s);
                        data = dtl.Qty;
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SL, strfmt_Center);

                        Rectangle strTT_DG = new Rectangle(160, y_p, 60, h_s);
                        //data = (double.Parse(dtl.Price) + (double.Parse(dtl.TaxAmount) / double.Parse(dtl.Qty))).ToString("0,0");
                        data = dtl.Price;
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strTT_DG, strfmt_Right_Center);

                        Rectangle strTT_TT = new Rectangle(220, y_p, 60, h_s);
                        data = dtl.TotalAmountBeforeTax;
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strTT_TT, strfmt_Right_Center);

                        y_p += h_s;
                        Rectangle RecLineCT = new Rectangle(5, y_p, 290, 1);
                        var LineCT = Common.Utility.GetImageFromService("ShopImg", "linect.png");
                        e.Graphics.DrawImage(LineCT, RecLineCT);
                    }
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

                    }


                }
            }


            ///Tổng tiền trước thuế /sau thuế
            Rectangle RecTTST = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalAmount");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecTTST, strfmt_Right);

            Rectangle RecTTST_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.TotalAmountBeforeTax;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecTTST_Val, strfmt_Right);
            y_p = y_p + 15;

            ///phí dịch vụ
            Rectangle RecPDV = new Rectangle(50, y_p, 150, 15);
            data = Common.clsLanguages.GetResource("TaxAndServiceChange") + " (" + (int.Parse(ConfigurationManager.AppSettings["SeviceCostPercent"]) +
                int.Parse(ConfigurationManager.AppSettings["VAT"])) + " %)"; //Common.clsLanguages.GetResource("TotalServiceCharge");//
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecPDV, strfmt_Right);

            Rectangle RecPDV_Val = new Rectangle(200, y_p, 80, 15);
            data = (double.Parse(rcAll.receipt.ServiceCostAmount) + double.Parse(rcAll.receipt.TotalTax)).ToString("0,0");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecPDV_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Giảm giá
            Rectangle RecDIS = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalDiscountAmount");//"Giảm giá ";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecDIS, strfmt_Right);

            Rectangle RecDIS_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.DiscountAmount;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecDIS_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Tổng tiền thanh toán
            Rectangle RecPAY = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalMoney");//"TC Cần thanh toán";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecPAY, strfmt_Right);

            Rectangle RecPAY_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.TotalMoney;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecPAY_Val, strfmt_Right);
            y_p = y_p + 15;

            ////
            Rectangle RecLine3 = new Rectangle(90, y_p, 200, 1);
            var Line3 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line3, RecLine3);
            y_p = y_p + 2;

            ///Tổng tiền mặt
            Rectangle RecCASH = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("CashPayment");//Common.clsLanguages.GetResource("TotalCashCustomer");//"Tiền mặt khách đưa";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecCASH, strfmt_Right);

            Rectangle RecCASH_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.CashPayAmt;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecCASH_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Tổng tiền thẻ
            Rectangle RecCARD = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("CardPayment");//Common.clsLanguages.GetResource("TotalCardAmount");//"Tiền thẻ khách:";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecCARD, strfmt_Right);

            Rectangle RecCARD_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.CardPayAmt;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecCARD_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Số tiền thối lại
            Rectangle RecRefun = new Rectangle(80, y_p, 120, 15);
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

            ////
            Rectangle RecLine6 = new Rectangle(5, y_p, 290, 2);
            var Line6 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line6, RecLine6);
            y_p = y_p + 4;

            Rectangle RecTK = new Rectangle(5, y_p, 190, 18);
            data = Common.clsLanguages.GetResource("ReceiptFooterText"); //"Cám ơn & hẹn gặp lại quý khách !";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Italic), Brushes.Black, RecTK, strfmt_Left);

            //Rectangle RecPower = new Rectangle(200, y_p, 95, 47);
            //var LineP = Common.Utility.GetImageFromService("VVImg", "powered by vv.emf");
            //e.Graphics.DrawImage(LineP, RecPower);
            //y_p = y_p + 47;

            // show các PromoText
            DataTable dtPromo = RptsBLL.GetValidPromotionToPrint();
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
            }

        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // load data hoa don
            ReceiptsAll rcAll = RptsBLL.GetAllInfo(ReceiptID_Success);
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
            string data = Common.clsLanguages.GetResource("Receipt");//"HÓA ĐƠN";
            e.Graphics.DrawString(data, new Font("Arial", 12, FontStyle.Bold), Brushes.DarkSlateBlue, strHoaDon, strfmt_Right);

            //Ngày hóa đơn
            Rectangle strRec = new Rectangle(80, 25, 200, 15);
            data = Common.clsLanguages.GetResource("ReceiptDate") + rcAll.receipt.CreatedDate; //"Ngày :"
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.DarkSlateBlue, strRec, strfmt_Right);


            Rectangle RecLine1 = new Rectangle(110, 40, 170, 2);
            var Line1 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line1, RecLine1);

            Rectangle strRec1 = new Rectangle(145, 42, 135, 18);
            string strSoHD = rcAll.receipt.ReceiptId;
            int soHD = int.Parse(strSoHD.Substring(10));
            data = Common.clsLanguages.GetResource("ReceiptNumber") + " : 10#" + soHD.ToString(); //"Số HĐ: "
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Italic), Brushes.DarkSlateBlue, strRec1, strfmt_Right);

            //// Cty....
            Rectangle strCty = new Rectangle(5, 50, 140, 40);//20
            data = Common.clsLanguages.GetResource("MerchantName");// "Công ty CP Việt Vang";           
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.DarkSlateBlue, strCty, strfmt_Left);
            //Địa chỉ Cty
            Rectangle strDCCty = new Rectangle(5, 90, 290, 60);//50
            data = Common.clsLanguages.GetResource("MerchantAddress") + "\n" + Common.clsLanguages.GetResource("MerchantTel") + "\n" + Common.clsLanguages.GetResource("MerchantWeb");
            e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.DarkSlateBlue, strDCCty, strfmt_Left);

            //Headers
            Rectangle strHD_STT = new Rectangle(3, 150, 30, 18);
            data = Common.clsLanguages.GetResource("No");// "STT";           
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, strHD_STT, strfmt_Center);

            Rectangle strHD_SP = new Rectangle(33, 150, 97, 18);
            data = Common.clsLanguages.GetResource("Product");//"Sản phẩm ";           
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, strHD_SP, strfmt_Left);

            Rectangle strHD_SL = new Rectangle(130, 150, 30, 18);
            data = Common.clsLanguages.GetResource("ReceiptProQty");//"SL";
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, strHD_SL, strfmt_Center);

            Rectangle strHD_DG = new Rectangle(160, 150, 60, 18);
            data = Common.clsLanguages.GetResource("ReceiptProPrice");//"ĐG";
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, strHD_DG, strfmt_Center);

            Rectangle strHD_TT = new Rectangle(220, 150, 70, 18);
            data = Common.clsLanguages.GetResource("ReceiptProTotal");//ReceiptProTotalAfterTax "TT + Thuế";
            e.Graphics.DrawString(data, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, strHD_TT, strfmt_Center);

            Rectangle RecLine2 = new Rectangle(5, 168, 290, 2);
            var Line2 = Common.Utility.GetImageFromService("ShopImg", "line2.png");
            e.Graphics.DrawImage(Line2, RecLine2);

            if (rcAll.lst_Detail != null && rcAll.lst_Detail.Count > 0)
            {
                y_p = 170;

                int i = 0;
                foreach (ReceiptDetails dtl in rcAll.lst_Detail)
                {
                    i++;
                    //Headers
                    h_s = 22;
                    //Common.clsLanguages.GetResource("ProductID") + " " + dtl.ProductId + " - " +
                    double _dbLength = (dtl.ProductName).Length;
                    if (_dbLength > 97 / 5)
                    {
                        int _iCelling = (int)Math.Ceiling((_dbLength * 5) / 97);
                        h_s = 14 * _iCelling + 12;
                    }

                    if (dtl.IsBuffet == "0" || (dtl.IsBuffet == "1" && double.Parse(dtl.Price) > 0))
                    {
                        Rectangle strCT_STT = new Rectangle(3, y_p, 30, h_s);
                        data = i.ToString();
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_STT, strfmt_Center);

                        Rectangle strCT_SP = new Rectangle(33, y_p, 97, h_s);
                        data = dtl.ProductName;
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SP, strfmt_Left_Center);

                        Rectangle strCT_SL = new Rectangle(130, y_p, 30, h_s);
                        data = dtl.Qty;
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SL, strfmt_Center);

                        Rectangle strTT_DG = new Rectangle(160, y_p, 60, h_s);
                        //data = (double.Parse(dtl.Price) + (double.Parse(dtl.TaxAmount) / double.Parse(dtl.Qty))).ToString("0,0");
                        data = dtl.Price;
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strTT_DG, strfmt_Right_Center);

                        Rectangle strTT_TT = new Rectangle(220, y_p, 60, h_s);
                        data = dtl.TotalAmountBeforeTax;
                        e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strTT_TT, strfmt_Right_Center);

                        y_p += h_s;
                        Rectangle RecLineCT = new Rectangle(5, y_p, 290, 1);
                        var LineCT = Common.Utility.GetImageFromService("ShopImg", "linect.png");
                        e.Graphics.DrawImage(LineCT, RecLineCT);
                    }
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

                    }


                }
            }


            ///Tổng tiền trước thuế /sau thuế
            Rectangle RecTTST = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalAmount");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecTTST, strfmt_Right);

            Rectangle RecTTST_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.TotalAmountBeforeTax;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecTTST_Val, strfmt_Right);
            y_p = y_p + 15;

            ///phí dịch vụ
            Rectangle RecPDV = new Rectangle(40, y_p, 160, 15);
            data = Common.clsLanguages.GetResource("TaxAndServiceChange") + " (" + (int.Parse(ConfigurationManager.AppSettings["SeviceCostPercent"]) +
                int.Parse(ConfigurationManager.AppSettings["VAT"])) + " %)"; //Common.clsLanguages.GetResource("TotalServiceCharge");//
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecPDV, strfmt_Right);

            Rectangle RecPDV_Val = new Rectangle(200, y_p, 80, 15);
            data = (double.Parse(rcAll.receipt.ServiceCostAmount) + double.Parse(rcAll.receipt.TotalTax)).ToString("0,0");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecPDV_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Giảm giá
            Rectangle RecDIS = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalDiscountAmount");//"Giảm giá ";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecDIS, strfmt_Right);

            Rectangle RecDIS_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.DiscountAmount;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecDIS_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Tổng tiền thanh toán
            Rectangle RecPAY = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalMoney");//"TC Cần thanh toán";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecPAY, strfmt_Right);

            Rectangle RecPAY_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.TotalMoney;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecPAY_Val, strfmt_Right);
            y_p = y_p + 15;

            ////
            Rectangle RecLine3 = new Rectangle(90, y_p, 200, 1);
            var Line3 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line3, RecLine3);
            y_p = y_p + 2;

            ///Tổng tiền mặt
            Rectangle RecCASH = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("CashPayment");//Common.clsLanguages.GetResource("TotalCashCustomer");//"Tiền mặt khách đưa";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecCASH, strfmt_Right);

            Rectangle RecCASH_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.CashPayAmt;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecCASH_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Tổng tiền thẻ
            Rectangle RecCARD = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("CardPayment");//Common.clsLanguages.GetResource("TotalCardAmount");//"Tiền thẻ khách:";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecCARD, strfmt_Right);

            Rectangle RecCARD_Val = new Rectangle(200, y_p, 80, 15);
            data = rcAll.receipt.CardPayAmt;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecCARD_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Số tiền thối lại
            Rectangle RecRefun = new Rectangle(80, y_p, 120, 15);
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

            ////
            Rectangle RecLine6 = new Rectangle(5, y_p, 290, 2);
            var Line6 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line6, RecLine6);
            y_p = y_p + 4;

            Rectangle RecTK = new Rectangle(5, y_p, 290, 18);
            data = Common.clsLanguages.GetResource("ReceiptFooterText"); //"Cám ơn & hẹn gặp lại quý khách !";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Italic), Brushes.Black, RecTK, strfmt_Left);

            //Rectangle RecPower = new Rectangle(200, y_p, 95, 47);
            //var LineP = Common.Utility.GetImageFromService("VVImg", "powered by vv.emf");
            //e.Graphics.DrawImage(LineP, RecPower);
            //y_p = y_p + 47;

            // show các PromoText
            DataTable dtPromo = RptsBLL.GetValidPromotionToPrint();
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
            }

        }


        #endregion 
    }
}
