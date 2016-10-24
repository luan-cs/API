using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosS.BusinessLayer;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Configuration;
using VVPosS.Entities;
using VVPosS.Common;
using System.Drawing.Printing;


namespace VVPosS.Screen.POS
{
    public partial class frmReceipt : Form
    {
        public bool IsClose, IsAll = true;
        private string WhatFocusOn;
        public double Card_Amount, Discount = 0, _dbCashPayAmt = 0;
        private string ReceiptID_Success;
     

        private OrderBLL orderBLL = new OrderBLL();
        private OrderDetailBLL orderdetailBLL = new OrderDetailBLL();
        private DeskBLL deskBLL = new DeskBLL();
        private ReceiptsBLL RptsBLL = new ReceiptsBLL();

        public frmReceipt()
        {
            InitializeComponent();
            SettingControl();
            IsClose = false;
            
        }

        public void SetUIChanges()
        {
            this.gbPromotion.Text = Common.clsLanguages.GetResource("ApplyingPromotion");
            this.gbSelectOrder.Text = Common.clsLanguages.GetResource("PleaseSelectOrders");
            this.gbReceiptDetail.Text = Common.clsLanguages.GetResource("ReceiptDetailInfo");

            this.btnALlOrders.Text = Common.clsLanguages.GetResource("All");
            this.btnDeskOrder.Text = Common.clsLanguages.GetResource("SelectATable");
            this.btnExit.Text = Common.clsLanguages.GetResource("MainScreen");
            this.btnMember.Text = Common.clsLanguages.GetResource("Customers");
            this.btnCard.Text = Common.clsLanguages.GetResource("CardPayment");
            this.btnRefresh.Text = Common.clsLanguages.GetResource("Reset");
            //this.btnPrint.Text = Common.clsLanguages.GetResource("PrintBill");
            this.btnComplete.Text = Common.clsLanguages.GetResource("Payment");
            this.btnPrintTemp.Text = Common.clsLanguages.GetResource("SaveTemp");

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

            //dataGridViewListOrder
            this.dataGridViewListOrder.Columns[0].HeaderText = Common.clsLanguages.GetResource("No");//
            this.dataGridViewListOrder.Columns[1].HeaderText = Common.clsLanguages.GetResource("OrderIDNo");
            this.dataGridViewListOrder.Columns[2].HeaderText = Common.clsLanguages.GetResource("TableIDNo");
            this.dataGridViewListOrder.Columns[3].HeaderText = Common.clsLanguages.GetResource("TableOrderingInfo");
            this.dataGridViewListOrder.Columns[4].HeaderText = Common.clsLanguages.GetResource("TotalMoney");//
            this.dataGridViewListOrder.Columns[5].HeaderText = Common.clsLanguages.GetResource("CreateDate");//

            //dataGridViewReceiptDetail
            this.dataGridViewReceiptDetail.Columns[0].HeaderText = Common.clsLanguages.GetResource("No");
            this.dataGridViewReceiptDetail.Columns[1].HeaderText = Common.clsLanguages.GetResource("OrderIDNo");
            this.dataGridViewReceiptDetail.Columns[2].HeaderText = Common.clsLanguages.GetResource("ProductID");
            this.dataGridViewReceiptDetail.Columns[3].HeaderText = Common.clsLanguages.GetResource("PromotionID");
            this.dataGridViewReceiptDetail.Columns[4].HeaderText = Common.clsLanguages.GetResource("ProductInfo");
            this.dataGridViewReceiptDetail.Columns[5].HeaderText = Common.clsLanguages.GetResource("ReceiptProQty");
            this.dataGridViewReceiptDetail.Columns[6].HeaderText = Common.clsLanguages.GetResource("ReceiptProPrice");
            this.dataGridViewReceiptDetail.Columns[7].HeaderText = Common.clsLanguages.GetResource("ReceiptProTotal");
            this.dataGridViewReceiptDetail.Columns[8].HeaderText = Common.clsLanguages.GetResource("ReceiptProTax");
            this.dataGridViewReceiptDetail.Columns[9].HeaderText = Common.clsLanguages.GetResource("ReceiptProTotalAfterTax");
            this.dataGridViewReceiptDetail.Columns[10].HeaderText = Common.clsLanguages.GetResource("ReceiptProDel");
            this.dataGridViewReceiptDetail.Columns[11].HeaderText = Common.clsLanguages.GetResource("ReceiptProEdit");

            //dataGridViewPromotion
            this.dataGridViewPromotion.Columns[0].HeaderText = Common.clsLanguages.GetResource("No");
            this.dataGridViewPromotion.Columns[1].HeaderText = Common.clsLanguages.GetResource("ReceiptProEdit");
            this.dataGridViewPromotion.Columns[2].HeaderText = Common.clsLanguages.GetResource("ReceiptProEdit");
            this.dataGridViewPromotion.Columns[3].HeaderText = Common.clsLanguages.GetResource("ReceiptProEdit");
            this.dataGridViewPromotion.Columns[4].HeaderText = Common.clsLanguages.GetResource("ReceiptProEdit");
        }

        private void SettingControl()
        {
            this.Size = new Size(1024, 768);
            this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            this.gbSelectOrder.ForeColor = this.gbReceiptDetail.ForeColor = this.lblCustomers.ForeColor = 
                System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);

            this.lblAmt_Card.ForeColor = this.lblAmt_ReturnAmt.ForeColor = this.lblAmt_TotalAfterTax.ForeColor =
                this.lblAmt_TotalAmount.ForeColor = this.lblAmt_TotalAmtBeforeTax.ForeColor = this.lblAmt_TotalTax.ForeColor =
                this.lblCard.ForeColor = this.lblDiscount.ForeColor = this.lblMoneyVAT.ForeColor =
                this.lblReceiveMoney.ForeColor = this.lblReturnMoney.ForeColor = this.lblTotalAfterTax.ForeColor =
                this.lblTotalBeforeTax.ForeColor = this.lblTotalPricePayment.ForeColor = this.lblServiceCharge.ForeColor = 
                this.lblServiceChargeVal.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
        }

        private void ToUpper() {
            foreach (Control c in this.Controls)
            {
                Button btn = c as Button;
                if (btn != null)
                    btn.Text = btn.Text.ToUpper();
            }
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            SetUIChanges();
            ToUpper();
            //
            this.lblServiceCharge.Text = this.lblServiceCharge.Text + " (" + ConfigurationManager.AppSettings["SeviceCostPercent"] + "%)";
            this.lblMoneyVAT.Text = this.lblMoneyVAT.Text + " (" + ConfigurationManager.AppSettings["VAT"] + "%)";
            if(ConfigurationManager.AppSettings["DiscountPercent"] == "1")
                this.lblDiscount.Text = this.lblDiscount.Text + " (%)";
            LoadData_Orders_And_Refresh(0);
        }

        #region Functions

        #region Load các order chưa thanh toán
        private void LoadData_Orders_And_Refresh(int Option)
        {
            // Biến & Label
            WhatFocusOn = ""; // Discount or Customer
            lblAmt_TotalAmtBeforeTax.Text = "0";
            txtDiscount.Text = "0";
            lblAmt_TotalTax.Text = "0";
            lblAmt_TotalAmount.Text = "0";
            txtCustomer.Text = "0";
            lblAmt_Card.Text = "0";
            lblAmt_ReturnAmt.Text = "0";
            lblCustomers.Text = "";
            lblAmt_TotalAfterTax.Text = "0";
            lblAmt_TotalAmount.Text = "0";
            lblServiceChargeVal.Text = "0";

            Program.lstCard = null;
            Program.rep_mb = null;
            Program.rep_info = null;

            // Grid
            dataGridViewListOrder.Rows.Clear();
            dataGridViewPromotion.Rows.Clear();
            dataGridViewReceiptDetail.Rows.Clear();

            //Loaddata Order
            DataTable dtOrder = orderBLL.GetOrders_For_Payment(Option);
            if (dtOrder != null)
            {
                int i = 0;
                foreach (DataRow dr in dtOrder.Rows)
                {
                    dataGridViewListOrder.Rows.Add();
                    dataGridViewListOrder.Rows[i].Cells[0].Value = i.ToString(); //STT
                    dataGridViewListOrder.Rows[i].Cells[1].Value = dr["OrderId"].ToString(); // OrderId
                    dataGridViewListOrder.Rows[i].Cells[2].Value = dr["DeskId"].ToString();
                    //string str = "Mã bàn: "+dr["DeskId"].ToString() +"\n"; //TT Bàn 
                    string str = ""; //TT Bàn 
                    DataTable dtDesk = orderBLL.GetDeskInfo(dr["DeskId"].ToString());
                    if (dtDesk != null)
                    {
                        
                        if (dtDesk.Rows.Count == 1)
                        {
                            DataRow drr = dtDesk.Rows[0];
                            str = str + Common.clsLanguages.GetResource("TableIDNo") + ": " + drr["DeskNo"].ToString() + "\n";
                            str = str + Common.clsLanguages.GetResource("Description") + ": " + drr["Description"].ToString() + "\n";

                            //get Name of DeskLocation
                            CommonCode cm1 = new CommonCode();
                            cm1.CommonTypeId = "DeskLocation";
                            cm1.CommonId = drr["DeskLocation"].ToString();
                            DataTable dt2 = new DataTable();
                            dt2 = deskBLL.GetStatusName(cm1);
                            str = str + Common.clsLanguages.GetResource("Location") + ": " + dt2.Rows[0]["StrValue1"].ToString() + "\n";
                        }
                    }

                    dataGridViewListOrder.Rows[i].Cells[3].Value = str;
                    string str1 = Common.clsLanguages.GetResource("bankCardTotalPayAmount") + ": " + double.Parse(dr["TotalMoney"].ToString()).ToString("0,0") + "\n";
                    DataTable dtOr = orderBLL.GetPaymentOfOrder(dr["OrderId"].ToString());
                    if (dtOr != null)
                    {
                        DataRow drr = dtOr.Rows[0];
                        if (!string.IsNullOrEmpty(drr["totalPaid"].ToString()))
                        {
                            str1 = str1 + Common.clsLanguages.GetResource("IsPaid") + ": " + double.Parse(drr["totalPaid"].ToString()).ToString("0,0") + "\n";
                        }
                        if (!string.IsNullOrEmpty(drr["totalNotPaid"].ToString()))
                        {
                            str1 = str1 + Common.clsLanguages.GetResource("Unpaid") + ": " + double.Parse(drr["totalNotPaid"].ToString()).ToString("0,0");
                        }
                    }
                    dataGridViewListOrder.Rows[i].Cells[4].Value = str1; // Tổng tiền
                    dataGridViewListOrder.Rows[i].Cells[5].Value = dr["CreatedDate"].ToString(); // Ngày tạo

                    DataGridViewRow row = dataGridViewListOrder.Rows[i];
                    row.Height = 90;
                    i++;
                }
            }
        }
        #endregion

        private void Add_Into_ReceiptDetail(string OrderID)
        {
            DataTable dt_OD = orderdetailBLL.GetListsDetailForPayment(OrderID);
            DataTable dt_O = orderBLL.GetLists(OrderID);
            if (double.Parse(string.IsNullOrEmpty(dt_O.Rows[0]["DisCountAmount"].ToString()) ? "0" : dt_O.Rows[0]["DisCountAmount"].ToString()) > 0)
            {
                double Tax = (double.Parse(dt_O.Rows[0]["DisCountAmount"].ToString()) * (double.Parse(ConfigurationManager.AppSettings["VAT"]) / 100));
                DataRow dt_giam = dt_OD.NewRow();
                dt_giam["OrderId"] = dt_O.Rows[0]["OrderId"].ToString();
                dt_giam["ProductId"] = "DISCOUNT";
                dt_giam["ProductName"] = "DISCOUNT";
                dt_giam["Price"] = "-" + dt_O.Rows[0]["DisCountAmount"].ToString();
                dt_giam["Qty"] = "1";
                dt_giam["AmmountBeforeTax"] = "-" + dt_O.Rows[0]["DisCountAmount"].ToString();
                dt_giam["TaxAmmount"] = "-" + Tax.ToString();
                dt_giam["TotalAmmount"] = "-" + (double.Parse(dt_O.Rows[0]["DisCountAmount"].ToString()) + Tax);
                dt_OD.Rows.Add(dt_giam);
            }
            foreach (DataRow dr in dt_OD.Rows)
            {
                int i = 0;
                for (i = 0; i < dataGridViewReceiptDetail.Rows.Count; i++)
                {
                    if (dataGridViewReceiptDetail.Rows[i].Cells[1].Value.ToString() == dr["OrderId"].ToString() && dataGridViewReceiptDetail.Rows[i].Cells[2].Value.ToString() == dr["ProductId"].ToString())
                    {
                        break;
                    }
                }

                if (i == dataGridViewReceiptDetail.Rows.Count)
                { // chưa có trong list  --> thêm mới
                    dataGridViewReceiptDetail.Rows.Add();
                    dataGridViewReceiptDetail.Rows[i].Cells[0].Value = (i + 1).ToString(); //STT
                    dataGridViewReceiptDetail.Rows[i].Cells[1].Value = dr["OrderId"].ToString(); //OrderId
                    dataGridViewReceiptDetail.Rows[i].Cells[2].Value = dr["ProductId"].ToString(); //ProductId
                    dataGridViewReceiptDetail.Rows[i].Cells[3].Value = ""; //PromotionId
                    dataGridViewReceiptDetail.Rows[i].Cells[4].Value = dr["ProductName"].ToString(); //Sản phẩm
                    dataGridViewReceiptDetail.Rows[i].Cells[5].Value = dr["Qty"].ToString(); //SL
                    dataGridViewReceiptDetail.Rows[i].Cells[6].Value = double.Parse(dr["Price"].ToString()).ToString("0,0"); //DG
                    dataGridViewReceiptDetail.Rows[i].Cells[7].Value = double.Parse(dr["AmmountBeforeTax"].ToString()).ToString("0,0"); //TT
                    dataGridViewReceiptDetail.Rows[i].Cells[8].Value = double.Parse(dr["TaxAmmount"].ToString()).ToString(); //Thuế
                    dataGridViewReceiptDetail.Rows[i].Cells[9].Value = double.Parse(dr["TotalAmmount"].ToString()).ToString("0,0"); //TT + Thuế//TotalAmmount
                    dataGridViewReceiptDetail.Rows[i].Cells[10].Value = Common.clsLanguages.GetResource("ReceiptProDel"); //Xóa
                    dataGridViewReceiptDetail.Rows[i].Cells[11].Value = Common.clsLanguages.GetResource("ReceiptProEdit"); //Sửa
                    dataGridViewReceiptDetail.Rows[i].Cells[12].Value = dr["DeskId"].ToString();
                    DataGridViewRow row = dataGridViewReceiptDetail.Rows[i];

                    row.Height = 35;
                }
                else
                { // đã có trong list --> load lại (bỏ promotion nếu có)
                    dataGridViewReceiptDetail.Rows[i].Cells[1].Value = dr["OrderId"].ToString(); //OrderId
                    dataGridViewReceiptDetail.Rows[i].Cells[2].Value = dr["ProductId"].ToString(); //ProductId
                    dataGridViewReceiptDetail.Rows[i].Cells[3].Value = ""; //PromotionId
                    dataGridViewReceiptDetail.Rows[i].Cells[4].Value = dr["ProductName"].ToString(); //Sản phẩm
                    dataGridViewReceiptDetail.Rows[i].Cells[5].Value = dr["Qty"].ToString(); //SL
                    dataGridViewReceiptDetail.Rows[i].Cells[6].Value = double.Parse(dr["Price"].ToString()).ToString("0,0"); //DG
                    dataGridViewReceiptDetail.Rows[i].Cells[7].Value = double.Parse(dr["AmmountBeforeTax"].ToString()).ToString("0,0"); //TT
                    dataGridViewReceiptDetail.Rows[i].Cells[8].Value = double.Parse(dr["TaxAmmount"].ToString()).ToString(); //Thuế
                    dataGridViewReceiptDetail.Rows[i].Cells[9].Value = double.Parse(dr["TotalAmmount"].ToString()).ToString("0,0"); //TT + Thuế//TotalAmmount
                    dataGridViewReceiptDetail.Rows[i].Cells[12].Value = dr["DeskId"].ToString();
                }
            }
            DanhLaiSTTGrid1();
        }

        private void DanhLaiSTTGrid1()
        {
            double TongTienTruocThue = 0;
            double PhiDichVu = 0;
            double TongTienThue = 0;
            double TongTienSauThue = 0;
            if (dataGridViewReceiptDetail.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewReceiptDetail.Rows.Count; i++)
                {
                    dataGridViewReceiptDetail.Rows[i].Cells[0].Value = (i + 1).ToString();
                    double tt = double.Parse(dataGridViewReceiptDetail.Rows[i].Cells[7].Value.ToString());
                    double thue = double.Parse(dataGridViewReceiptDetail.Rows[i].Cells[8].Value.ToString());
                    double tt_and_Thue = double.Parse(dataGridViewReceiptDetail.Rows[i].Cells[9].Value.ToString());
                    TongTienThue = TongTienThue + thue;
                    TongTienTruocThue = TongTienTruocThue + tt;
                    TongTienSauThue = TongTienSauThue + tt_and_Thue;
                }
            }
            PhiDichVu = TongTienTruocThue * (double.Parse(ConfigurationManager.AppSettings["SeviceCostPercent"]) / 100);
            lblAmt_TotalAmtBeforeTax.Text = TongTienTruocThue.ToString("0,0");
            lblAmt_TotalTax.Text = TongTienThue.ToString("0,0");
            lblAmt_TotalAfterTax.Text = TongTienSauThue.ToString("0,0");
            lblServiceChargeVal.Text = PhiDichVu.ToString("0,0");

            double discount = double.Parse(txtDiscount.Text);
            double TongTien = TongTienSauThue + PhiDichVu - discount;
            lblAmt_TotalAmount.Text = TongTien.ToString("0,0");

            double tienThanhToan = double.Parse(txtCustomer.Text);
            double tienThoi = 0;
            if (tienThanhToan > TongTien)
            {
                tienThoi = tienThanhToan - TongTien;
            }
            else
            {
                tienThoi = 0;
            }
            lblAmt_ReturnAmt.Text = tienThoi.ToString("0,0");
            //lblConNo.Text = tienNo.ToString("0,0.0");
        }

        private void TinhToanLai()
        {
            double TongTienTruocThue = double.Parse(lblAmt_TotalAmtBeforeTax.Text);
            double TongTienThue = double.Parse(lblAmt_TotalTax.Text);
            double TongTienSauThue = double.Parse(lblAmt_TotalAfterTax.Text);

            double PhiDichVu = double.Parse(lblServiceChargeVal.Text);
            //double discount = double.Parse(txtDiscount.Text);
            //double TongTien = TongTienSauThue - discount;

            if (ConfigurationManager.AppSettings["DiscountPercent"] == "1")
            {
                Discount = double.Parse(txtDiscount.Text) * TongTienTruocThue / 100;
            }
            else Discount = double.Parse(txtDiscount.Text);

            double TongTien = TongTienSauThue + PhiDichVu - Discount;
            lblAmt_TotalAmount.Text = TongTien.ToString("0,0");

            double Cash_money = double.Parse(txtCustomer.Text);
            double Card_money = double.Parse(lblAmt_Card.Text);
            double tienThoi = 0;
            //if (Cash_money + Card_money > TongTien && Cash_money > TongTien - Card_money)
            //{
            //    tienThoi = Cash_money + Card_money - TongTien;
            //}
            if (Cash_money + Card_money > TongTien && Cash_money > TongTien - Card_money)
            {
                if (Card_money >= TongTien) tienThoi = Cash_money;
                else
                    tienThoi = Cash_money + Card_money - TongTien;
            }
            else
            {
                tienThoi = 0;
            }
            lblAmt_ReturnAmt.Text = tienThoi.ToString("0,0");
        }

        private int InsertNewReceipt()
        {
            // 0 : Thất bại
            // 1 : thành công
            int res = 0;
            ////
            Receipts rcp = new Receipts();
            rcp.ReceiptId = "";
            rcp.Note = ""; // click nút info sẽ thêm vào
            rcp.NoOfCustumers = ""; // click nút info sẽ thêm vào
            rcp.Status = "1";
            rcp.TotalAmountBeforeTax = lblAmt_TotalAmtBeforeTax.Text;
            rcp.TotalTax = lblAmt_TotalTax.Text;
            rcp.TotalAmount = lblAmt_TotalAfterTax.Text;
            rcp.DiscountAmount = Discount.ToString();
            rcp.TotalMoney = lblAmt_TotalAmount.Text;
            rcp.CashPayAmt = txtCustomer.Text;
            rcp.CardPayAmt = lblAmt_Card.Text;
            rcp.ReturnAmt = lblAmt_ReturnAmt.Text;
            rcp.CreatedBy = Program.Username;
            rcp.CreatedDate = "";
            rcp.ModifiedBy = "";
            rcp.ModifiedDate = "";

            rcp.ServiceCostAmount = lblServiceChargeVal.Text;
          
            /////////////
            List<ReceiptDetails> lst_rd = new List<ReceiptDetails>();
            for (int i = 0; i < dataGridViewReceiptDetail.RowCount; i++)
            {
                ReceiptDetails rd = new ReceiptDetails();
                rd.ReceiptId = "";
                rd.RefOrderId = dataGridViewReceiptDetail.Rows[i].Cells[1].Value.ToString();
                rd.ProductId = dataGridViewReceiptDetail.Rows[i].Cells[2].Value.ToString();
                rd.PromotionId = "";
                rd.Qty = dataGridViewReceiptDetail.Rows[i].Cells[5].Value.ToString();
                rd.Price = dataGridViewReceiptDetail.Rows[i].Cells[6].Value.ToString();
                rd.TotalAmountBeforeTax = dataGridViewReceiptDetail.Rows[i].Cells[7].Value.ToString();
                rd.TaxAmount = dataGridViewReceiptDetail.Rows[i].Cells[8].Value.ToString();
                rd.TotalAmount = dataGridViewReceiptDetail.Rows[i].Cells[9].Value.ToString();
                rd.CreatedBy = Program.Username;
                rd.DeskId = dataGridViewReceiptDetail.Rows[i].Cells["colDeskId"].Value.ToString();
                lst_rd.Add(rd);
            }

            if (Program.lstCard != null && Program.lstCard.Count > 0)
            {
                foreach (ReceiptsCard card in Program.lstCard)
                {
                    card.CreatedBy = Program.Username;
                }
            }
            else
            {
                Program.lstCard = null;
            }

            //////////////////
            if (Program.rep_mb != null && !string.IsNullOrEmpty(Program.rep_mb.MemberId))
            {
                Program.rep_mb.CreatedBy = Program.Username;
            }
            else
            {
                Program.rep_mb = null;
            }


            //////////////
            if (Program.rep_info != null && !string.IsNullOrEmpty(Program.rep_info.Note))
            {                
            }
            else
            {
                Program.rep_info = null;
            }

            RptsBLL.AddNew(rcp, lst_rd, Program.lstCard, Program.rep_info, Program.rep_mb, ref ReceiptID_Success);
            if (string.IsNullOrEmpty(RptsBLL.ErrorString))
            {
                res = 1;
            }
            else
            {
                res = 0;
            }

            return res;
        }

        private void ShowMessage()
        {
            //Chưa có hóa đơn để in !!!
            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseSelectReceipt"),
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
            else pd.PrintPage += new PrintPageEventHandler(this.printDocumentTemp_PrintPage);

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
                    double _dbLength = ( dtl.ProductName).Length;
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
                int.Parse(ConfigurationManager.AppSettings["VAT"])) + " %)" ; //Common.clsLanguages.GetResource("TotalServiceCharge");//
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

        private void printDocumentTemp_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // load data hoa don
            string strDesk = "";
            ReceiptsAll rcAll = RptsBLL.GetAllInfo(ReceiptID_Success);
            string[] ArrDeskId = new string[dataGridViewReceiptDetail.RowCount];
            int k = 0;
            foreach (DataGridViewRow dr in dataGridViewReceiptDetail.Rows) {
                bool has = Array.IndexOf(ArrDeskId, dr.Cells["colDeskId"].Value.ToString()) >= 0;
                if (has) continue;
                strDesk += deskBLL.GetDeskNO(dr.Cells["colDeskId"].Value.ToString()) + ",";
                ArrDeskId[k] = dr.Cells["colDeskId"].Value.ToString();
                k++;
            }
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
            string data = Common.clsLanguages.GetResource("Receipt");//Phiếu thanh toán;
            e.Graphics.DrawString(data, new Font("Arial", 12, FontStyle.Bold), Brushes.DarkSlateBlue, strHoaDon, strfmt_Right);

            //Ngày hóa đơn
            Rectangle strRec = new Rectangle(80, 25, 200, 15);
            data = Common.clsLanguages.GetResource("ReceiptDate") + DateTime.Now.ToString("d/M/yyyy H:s"); //"Ngày :"
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.DarkSlateBlue, strRec, strfmt_Right);


            Rectangle RecLine1 = new Rectangle(110, 40, 170, 2);
            var Line1 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line1, RecLine1);

            Rectangle strRec1 = new Rectangle(145, 42, 135, 18);
            //string strSoHD = rcAll.receipt.ReceiptId;
            //int soHD = int.Parse(strSoHD.Substring(10));
            data = Common.clsLanguages.GetResource("Desk_") + " " + strDesk.Trim().Trim(',');
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

            //if (rcAll.lst_Detail != null && rcAll.lst_Detail.Count > 0)
            //{
                y_p = 170;

                int i = 0;
                foreach (DataGridViewRow dtl in dataGridViewReceiptDetail.Rows)
                {
                    i++;
                    //Headers
                    h_s = 22;
                    double _dbLength = (Common.clsLanguages.GetResource("ProductID") + " " + dtl.Cells["colProductName"].Value.ToString()).Length;
                    if (_dbLength > 97 / 5)
                    {
                        int _iCelling = (int)Math.Ceiling((_dbLength * 5) / 97);
                        h_s = 14 * _iCelling + 12;
                    }

                    Rectangle strCT_STT = new Rectangle(3, y_p, 30, h_s);
                    data = i.ToString();
                    e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_STT, strfmt_Center);

                    Rectangle strCT_SP = new Rectangle(33, y_p, 97, h_s);
                    data = Common.clsLanguages.GetResource("ProductID") + " " + dtl.Cells["colProductName"].Value;
                    e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SP, strfmt_Left_Center);

                    Rectangle strCT_SL = new Rectangle(130, y_p, 30, h_s);
                    data = dtl.Cells["colQty"].Value.ToString();
                    e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SL, strfmt_Center);

                    Rectangle strTT_DG = new Rectangle(160, y_p, 60, h_s);
                    data =dtl.Cells["colPrice"].Value.ToString();
                    e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strTT_DG, strfmt_Right_Center);

                    Rectangle strTT_TT = new Rectangle(220, y_p, 60, h_s);
                    data = dtl.Cells["colAntBeforeTax"].Value.ToString();
                    e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strTT_TT, strfmt_Right_Center);

                    y_p += h_s;
                    Rectangle RecLineCT = new Rectangle(5, y_p, 290, 1);
                    var LineCT = Common.Utility.GetImageFromService("ShopImg", "linect.png");
                    e.Graphics.DrawImage(LineCT, RecLineCT);
                }
            //}


            ///Tổng tiền sau thuế
            Rectangle RecTTST = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalAmount");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecTTST, strfmt_Right);

            Rectangle RecTTST_Val = new Rectangle(200, y_p, 80, 15);
            data = lblAmt_TotalAmtBeforeTax.Text;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecTTST_Val, strfmt_Right);
            y_p = y_p + 15;

            ///phí dịch vụ
            Rectangle RecPDV = new Rectangle(50, y_p, 150, 15);
            data = Common.clsLanguages.GetResource("TaxAndServiceChange") + " (" + (int.Parse(ConfigurationManager.AppSettings["SeviceCostPercent"]) +
              int.Parse(ConfigurationManager.AppSettings["VAT"])) + " %)"; //Common.clsLanguages.GetResource("TotalServiceCharge");//
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecPDV, strfmt_Right);

            Rectangle RecPDV_Val = new Rectangle(200, y_p, 80, 15);
            data = (double.Parse(lblServiceChargeVal.Text) + double.Parse(lblAmt_TotalTax.Text)).ToString("0,0");
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecPDV_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Giảm giá
            Rectangle RecDIS = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalDiscountAmount");//"Giảm giá ";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecDIS, strfmt_Right);

            Rectangle RecDIS_Val = new Rectangle(200, y_p, 80, 15);
            data = Discount.ToString();
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecDIS_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Tổng tiền thanh toán
            Rectangle RecPAY = new Rectangle(80, y_p, 120, 15);
            data = Common.clsLanguages.GetResource("TotalMoney");//"TC Cần thanh toán";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecPAY, strfmt_Right);

            Rectangle RecPAY_Val = new Rectangle(200, y_p, 80, 15);
            data = lblAmt_TotalAmount.Text;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecPAY_Val, strfmt_Right);

        }

        #endregion 

        #endregion

        #region DataGirdView Events

        private void dataGridViewListOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dataGridViewListOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                Add_Into_ReceiptDetail(id);
            }
        }

        private void dataGridViewReceiptDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10 && e.RowIndex >= 0) // xóa
            {
                dataGridViewReceiptDetail.Rows.RemoveAt(e.RowIndex);
            }

            if (e.ColumnIndex == 11 && e.RowIndex >= 0) // Sửa
            {
                int i = e.RowIndex;
                Program.od_sua = new OrderDetails();
                Program.od_sua.ODID = e.RowIndex.ToString();
                Program.od_sua.ProductId = dataGridViewReceiptDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                Program.od_sua.ProductName = dataGridViewReceiptDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
                Program.od_sua.Qty = dataGridViewReceiptDetail.Rows[e.RowIndex].Cells[5].Value.ToString();
                Program.od_sua.Price = dataGridViewReceiptDetail.Rows[e.RowIndex].Cells[6].Value.ToString();
                Program.od_sua.AmmountBeforeTax = dataGridViewReceiptDetail.Rows[e.RowIndex].Cells[7].Value.ToString();
                Program.od_sua.TaxAmmount = dataGridViewReceiptDetail.Rows[e.RowIndex].Cells[8].Value.ToString();
                Program.od_sua.TotalAmount = dataGridViewReceiptDetail.Rows[e.RowIndex].Cells[9].Value.ToString();

                VVPosS.Screen.POS.frmEditDetailReceipt frm = new frmEditDetailReceipt();
                frm.ShowDialog();

                dataGridViewReceiptDetail.Rows[i].Cells[5].Value = Program.od_sua.Qty; //SL
                dataGridViewReceiptDetail.Rows[i].Cells[6].Value = double.Parse(Program.od_sua.Price).ToString("0,0"); //DG
                dataGridViewReceiptDetail.Rows[i].Cells[7].Value = double.Parse(Program.od_sua.AmmountBeforeTax).ToString("0,0"); //TT
                dataGridViewReceiptDetail.Rows[i].Cells[8].Value = double.Parse(Program.od_sua.TaxAmmount).ToString("0,0"); //Thuế
                dataGridViewReceiptDetail.Rows[i].Cells[9].Value = double.Parse(Program.od_sua.TotalAmount).ToString("0,0"); //TT + Thuế
            }
            DanhLaiSTTGrid1();
        }

        #endregion

        #region TextBox Events

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            WhatFocusOn = "Discount";

            //TinhToanLai();
        }

        private void txtCustomer_Leave(object sender, EventArgs e)
        {
            WhatFocusOn = "Customer";
            //double ttAmt = double.Parse(lblAmt_TotalAmount.Text);
            //double Card = double.Parse(lblAmt_Card.Text);
            //double Cash = double.Parse(txtCustomer.Text);
            //if (Card + Cash < ttAmt)
            //{
            //    MessageBox.Show("Tiền khách đưa không được ít hơn tiền thanh toán !!!");

            //    txtCustomer.NumericValue = ttAmt;
            //}                       
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            //
            if (txtDiscount.Text != "")
            {
                if (ConfigurationManager.AppSettings["DiscountPercent"] == "1")
                {
                    if (txtDiscount.TextLength > 3 || Common.Utility.ParseDouble(txtDiscount.Text.Trim()) > 99)
                    {
                        // Số tiền bạn nhập quá lớn, vui lòng kiểm tra lại ! - PleaseMoneyInformationagain
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PrecentDiscountVeryBig"),
                                              Common.clsLanguages.GetResource("Error"),
                                              Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                              Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        txtDiscount.Text = "0";
                        return;
                    }
                }
                double Num;
                bool isNum = double.TryParse(Common.Utility.ParseDouble(txtDiscount.Text.Trim()).ToString(), out Num);
                if (isNum)
                {
                    //if (Convert.ToDouble(txtDiscount.Text.Trim()) <= Convert.ToDouble(lblAmt_TotalAmount.Text))
                    //{
                        Discount = double.Parse(txtDiscount.Text);
                        txtDiscount.Text = Discount.ToString("###,###,##0");
                        txtDiscount.SelectionStart = txtDiscount.Text.Length;
                        //DanhLaiSTTGrid1();
                        TinhToanLai();
                        //TotalMoney = TotalMoney - Discount;
                    }
                    else
                    {
                        Discount = 0;
                        txtDiscount.Text = "0";
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DiscountInputError"),
                                    Common.clsLanguages.GetResource("Error"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                //}
            }
            else
            {
                Discount = 0;
                //txtDiscount.Text = "0";
            }
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomer.Text != "")
            {
                if (txtCustomer.TextLength > 14)
                {
                    // Số tiền bạn nhập quá lớn, vui lòng kiểm tra lại ! - PleaseMoneyInformationagain
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseMoneyInformationagain"),
                                          Common.clsLanguages.GetResource("Error"),
                                          Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                          Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    txtCustomer.Text = "0";
                    return;
                }
                double Num;
                bool isNum = double.TryParse(txtCustomer.Text.Trim(), out Num);
                if (isNum)
                {
                    _dbCashPayAmt = double.Parse(txtCustomer.Text);
                    txtCustomer.Text = _dbCashPayAmt.ToString("###,###,##0");
                    txtCustomer.SelectionStart = txtCustomer.Text.Length;
                    TinhToanLai();
                    //btnPayment.Enabled = false;
                }
                else
                {
                    _dbCashPayAmt = 0;
                    txtCustomer.Text = "0";
                    // Tiền khách đưa bạn nhập không đúng ! - ErrorCusmorMoney
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ErrorCusmorMoney"),
                                Common.clsLanguages.GetResource("Error"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
            }
            else
            {
                _dbCashPayAmt = 0;
                //txtCustomer.Text = "0";
            }

            //TinhToanLai();
        }

        private void txtDiscount_NumericValueChanged(object sender, EventArgs e)
        {
            double dis = double.Parse(txtDiscount.Text);
            double TongTienSauThue = double.Parse(lblAmt_TotalAfterTax.Text);
            if (dis <= TongTienSauThue)
            {

            }
            else
            {
                //MessageBox.Show("Không thể giảm giá quá số tiền hóa đơn !!!");
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CannotDiscountOver"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtDiscount.Text = "0";
            }
            TinhToanLai();
        }

        private void txtCustomer_NumericValueChanged(object sender, EventArgs e)
        {
            
            TinhToanLai();
        }

        private void txtDiscount_MouseEnter(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "0")
                txtDiscount.Clear();
        }

        private void txtDiscount_MouseLeave(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "") txtDiscount.Text = "0";
        }

        private void txtCustomer_MouseEnter(object sender, EventArgs e)
        {
            if (txtCustomer.Text == "0")
                txtCustomer.Clear();
        }

        private void txtCustomer_MouseLeave(object sender, EventArgs e)
        {
            if (txtCustomer.Text == "") txtCustomer.Text = "0";
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            Common.Utility.MaskDigit_keyDown(e);
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Utility.MaskDigit(e);
        }

        #endregion

        #region Button Events

        #region Button Number

        private void btnCE_Click(object sender, EventArgs e)
        {
            switch (WhatFocusOn)
            {
                case "Discount":
                    {
                        txtDiscount.Text = "0";
                        break;
                    }
                case "Customer":
                    {
                        txtCustomer.Text = "0";
                        break;
                    }
            }
        }

        private void AddNoUsingTouch(string no)
        {
            string str = "";

            switch (WhatFocusOn)
            {
                case "Discount":
                    {
                        str = txtDiscount.Text;
                        str = str + no;
                        txtDiscount.Text = str;
                        break;
                    }
                case "Customer":
                    {
                        str = txtCustomer.Text;
                        str = str + no;
                        txtCustomer.Text = str;
                        break;
                    }
            }

        }

        private void btnNo0_Click(object sender, EventArgs e)
        {
            AddNoUsingTouch("0");
        }

        private void btnNo1_Click(object sender, EventArgs e)
        {
            AddNoUsingTouch("1");
        }

        private void btnNo2_Click(object sender, EventArgs e)
        {
            AddNoUsingTouch("2");
        }

        private void btnNo3_Click(object sender, EventArgs e)
        {
            AddNoUsingTouch("3");
        }

        private void btnNo4_Click(object sender, EventArgs e)
        {
            AddNoUsingTouch("4");
        }

        private void btnNo5_Click(object sender, EventArgs e)
        {
            AddNoUsingTouch("5");
        }

        private void btnNo6_Click(object sender, EventArgs e)
        {
            AddNoUsingTouch("6");
        }

        private void btnNo7_Click(object sender, EventArgs e)
        {
            AddNoUsingTouch("7");
        }

        private void btnNo8_Click(object sender, EventArgs e)
        {
            AddNoUsingTouch("8");
        }

        private void btnNo9_Click(object sender, EventArgs e)
        {
            AddNoUsingTouch("9");
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            IsClose = true;
            this.Close();
            frmMain f = new frmMain();
            f.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData_Orders_And_Refresh(IsAll ? 0 : 1);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (dataGridViewReceiptDetail.Rows.Count > 0)
            {
                double cash = double.Parse(txtCustomer.Text);
                double card = double.Parse(lblAmt_Card.Text);

                double total = double.Parse(lblAmt_TotalAmount.Text);
                if (card == 0 && cash == 0)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseSelectMoneyCusomer"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);

                }
                else
                {
                    if (cash + card >= total)
                    {
                        int i = InsertNewReceipt();
                        if (i == 1)
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseSelectReceiptandPrint"),
                               Common.clsLanguages.GetResource("Information"),
                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);

                            LoadData_Orders_And_Refresh(IsAll ? 0 : 1);
                            if (!string.IsNullOrEmpty(ReceiptID_Success))
                            {
                                DoPrinting(null);
                            }
                        }
                        else
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ErrOccurs") + ": " + RptsBLL.ErrorString,
                            Common.clsLanguages.GetResource("Information"),
                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                    }
                    else
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseMoneyandRecipt"),
                           Common.clsLanguages.GetResource("Information"),
                           Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                           Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                }
            }
            else
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseSelectReceipt"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ReceiptID_Success))
            {
                DoPrinting(null);
            }
            else
            {
                ShowMessage();
                return;
            }
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            double ttt = double.Parse(lblAmt_TotalAmount.Text) - double.Parse(txtCustomer.Text) - (string.IsNullOrEmpty(lblAmt_Card.Text)? 0 : double.Parse(lblAmt_Card.Text));
            if (ttt > 0)
            {
                VVPosS.Screen.POS.frmBankingCard frm = new frmBankingCard();


                frm.SoTienCanThanhToan = ttt;
                frm.ShowDialog();
                if (Program.lstCard != null && Program.lstCard.Count > 0)
                {
                    double ttCard = 0;
                    foreach (ReceiptsCard rc in Program.lstCard)
                    {
                        ttCard = ttCard + double.Parse(rc.TotalAmount);
                    }
                    lblAmt_Card.Text = ttCard.ToString("0,0");
                }
                TinhToanLai();
            }
            else
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ZeroCannotPayWithCard"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            VVPosS.Screen.POS.frmMemberReceipt frm = new frmMemberReceipt();
            frm.ShowDialog();
            if (Program.rep_mb != null && !string.IsNullOrEmpty(Program.rep_mb.MemberId))
            {
                string str = Common.clsLanguages.GetResource("MemberID") + " - " + Program.rep_mb.MemberId + " - " + Program.rep_mb.MemberCode;
                str = str + "\n" + Common.clsLanguages.GetResource("FullName") + " - " + Program.rep_mb.FullName;
                str = str + "\n" + Common.clsLanguages.GetResource("TotalScore") + " - " + Program.rep_mb.MemberScore;
                lblCustomers.Text = str;
            }
            else
            {
                lblCustomers.Text = "";
            }
        }

        private void btnALlOrders_Click(object sender, EventArgs e)
        {
            this.btnALlOrders.BackgroundImage = global::VVPosS.Properties.Resources.ds_all_button;
            this.btnDeskOrder.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;

            LoadData_Orders_And_Refresh(0);
            IsAll = true;
        }

        private void btnDeskOrder_Click(object sender, EventArgs e)
        {
            this.btnDeskOrder.BackgroundImage = global::VVPosS.Properties.Resources.ds_all_button;
            this.btnALlOrders.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;

            LoadData_Orders_And_Refresh(1);
            IsAll = false;
        }

        #endregion

        private void gbSelectOrder_Paint(object sender, PaintEventArgs e)
        {
            //GroupBox box = (GroupBox)sender;
            //Common.Utility.DrawGroupBoxNonBorder(box, e.Graphics, ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR), this);
        }

        private void btnPrintTemp_Click(object sender, EventArgs e)
        {
            if (dataGridViewReceiptDetail.RowCount == 0) {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseSelectReceipt"),
                               Common.clsLanguages.GetResource("Information"),
                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }

            else {
                if (dataGridViewReceiptDetail.RowCount == 1) {
                    if (dataGridViewReceiptDetail.Rows[0].Cells["colProductId"].ToString() == "DISCOUNT") return;
                    else
                    {
                        if (!DoPrinting("1"))
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NotFoundPrintPleaseCheck"),
                                  Common.clsLanguages.GetResource("Information"),
                                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                }
                else {
                    if (!DoPrinting("1")) 
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NotFoundPrintPleaseCheck"),
                              Common.clsLanguages.GetResource("Information"),
                              Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                              Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                }
            }
        }

    }
}
