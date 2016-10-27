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
 * Class		: frmOrderList
 * Developer    : Huỳnh Thị Ngọc Dung
 */
#endregion

#region Note - Please Reading Hard this region before modifile.
/*
 * 1. DataGridViewReceiptDetail: DO NOT allow End User can Sort - DataGridViewColumnSortMode = NoSortMode.
 * 2. DataGridViewReceiptDetail: DO NOT modifile Column Name.
 */
#endregion

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
using VVPosS.Entities;
using System.Configuration;
using System.Drawing.Printing;

namespace VVPosS.Screen.POS
{
    public partial class frmOrderList : Form
    {
        private PayForm payForm;
        private OrderBLL orderBLL = new OrderBLL();
        private OrderDetailBLL orderdetailBLL = new OrderDetailBLL();
        private EmployeeBLL employeeBLL = new EmployeeBLL();

        private DataTable dt_OD = new DataTable("OD"), dt_O = new DataTable("O");

        private bool IsAll = true, IsUpdate, IsUser = false, IsDelete, IsModifile, bHaveDiscount = false, IsDiscount = false, IsPrintServer = false, IsPrint = false;
        private double dbThueSuat, dbTotalMoney;
        private string sOrderId, sEmployeeId = Program.Username, str;

        public frmOrderList()
        {
            InitializeComponent();
            SettingControl();
            txtUser.Text = sEmployeeId;
        }

        private void SetUIChanges()
        {
            this.ckbIsPrint.Text = Common.clsLanguages.GetResource("PrintAtTheKitchen");
            //button
            this.btnExit.Text = Common.clsLanguages.GetResource("MHDichVu");
            this.bntFinish.Text = Common.clsLanguages.GetResource("Save");
            this.btnALlOrders.Text = Common.clsLanguages.GetResource("All");
            this.btnDeskOrder.Text = Common.clsLanguages.GetResource("SelectATable");
            this.btnAddDiscount.Text = Common.clsLanguages.GetResource("AddDiscount");

            //label
            this.lbUserText.Text = Common.clsLanguages.GetResource("EmployeeCode");
            this.lbNotes.Text = Common.clsLanguages.GetResource("Notes");

            //GroupBox
            this.lbSelectOrder.Text = Common.clsLanguages.GetResource("OrderList_full");
            this.lbReceiptDetail.Text = Common.clsLanguages.GetResource("ProductsList");

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

        }

        private void SettingControl()
        {
            this.Size = new Size(1024, 768);
            this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            this.lbSelectOrder.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);

            this.lbUserText.ForeColor = this.ckbIsPrint.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
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
        private void frmOrderList_Load(object sender, EventArgs e)
        {
            SetUIChanges();
            ToUpper();

            if (ConfigurationManager.AppSettings["IsPrintTran"] == "1")
            {
                ckbIsPrint.Checked = true;
            }
            //
            this.dataGridViewListOrder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            LoadData_Orders_And_Refresh(0);
            dbThueSuat = (double)Program.Vat / 100;
            Common.Utility.SetColumnSortMode(dataGridViewReceiptDetail, DataGridViewColumnSortMode.NotSortable);


            if (ConfigurationManager.AppSettings["IsPrintServer"] == "1") IsPrintServer = true;
        }

        #region Functions

        #region Load các order chưa thanh toán
        private void LoadData_Orders_And_Refresh(int Option)
        {

            // Grid
            dataGridViewListOrder.Rows.Clear();
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
                            str = str + Common.clsLanguages.GetResource("Location") + ": " + drr["DeskLocation"].ToString() + "\n";
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
                    row.Height = 70;

                    i++;
                }
            }
        }
        #endregion

        private void Add_Into_ReceiptDetail(string OrderID)
        {
            //if (dataGridViewReceiptDetail.RowCount > 0) {
            //    CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng hoàn tất order hiện tại trước !",
            //                        Common.clsLanguages.GetResource("Information"),
            //                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
            //                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            //    return;
            //}
            dataGridViewReceiptDetail.Rows.Clear();
            dt_OD = orderdetailBLL.GetListsDetailForPayment(OrderID);
            dt_O = orderBLL.GetLists(OrderID);
            if (double.Parse(string.IsNullOrEmpty(dt_O.Rows[0]["DisCountAmount"].ToString()) ? "0" : dt_O.Rows[0]["DisCountAmount"].ToString()) > 0)
            {
                bHaveDiscount = true;
                DataRow dt_giam = dt_OD.NewRow();
                dt_giam["OrderId"] = dt_O.Rows[0]["OrderId"].ToString();
                dt_giam["ProductId"] = "DISCOUNT";
                dt_giam["ProductName"] = "DISCOUNT";
                dt_giam["Price"] = "-" + dt_O.Rows[0]["DisCountAmount"].ToString();
                dt_giam["Qty"] = "1";
                dt_giam["AmmountBeforeTax"] = "-" + dt_O.Rows[0]["DisCountAmount"].ToString();
                dt_giam["TaxAmmount"] = "0";
                dt_giam["TotalAmmount"] = "-" + dt_O.Rows[0]["DisCountAmount"].ToString();
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
                    dataGridViewReceiptDetail.Rows[i].Cells[8].Value = double.Parse(dr["TaxAmmount"].ToString()).ToString("0,0"); //Thuế
                    dataGridViewReceiptDetail.Rows[i].Cells[9].Value = double.Parse(dr["TotalAmmount"].ToString()).ToString("0,0"); //TT + Thuế
                    dataGridViewReceiptDetail.Rows[i].Cells[10].Value = Common.clsLanguages.GetResource("ReceiptProDel"); //Xóa
                    dataGridViewReceiptDetail.Rows[i].Cells[11].Value = Common.clsLanguages.GetResource("ReceiptProEdit"); //Sửa
                    dataGridViewReceiptDetail.Rows[i].Cells[12].Value = dr["Status"].ToString();
                    dataGridViewReceiptDetail.Rows[i].Cells[13].Value = dr["Note"].ToString();
                    DataGridViewRow row = dataGridViewReceiptDetail.Rows[i];

                    row.Height = 35;
                }
                //else
                //{ // đã có trong list --> load lại (bỏ promotion nếu có)
                //    dataGridViewReceiptDetail.Rows[i].Cells[1].Value = dr["OrderId"].ToString(); //OrderId
                //    dataGridViewReceiptDetail.Rows[i].Cells[2].Value = dr["ProductId"].ToString(); //ProductId
                //    dataGridViewReceiptDetail.Rows[i].Cells[3].Value = ""; //PromotionId
                //    dataGridViewReceiptDetail.Rows[i].Cells[4].Value = dr["ProductName"].ToString(); //Sản phẩm
                //    dataGridViewReceiptDetail.Rows[i].Cells[5].Value = dr["Qty"].ToString(); //SL
                //    dataGridViewReceiptDetail.Rows[i].Cells[6].Value = double.Parse(dr["Price"].ToString()).ToString("0,0"); //DG
                //    dataGridViewReceiptDetail.Rows[i].Cells[7].Value = double.Parse(dr["AmmountBeforeTax"].ToString()).ToString("0,0"); //TT
                //    dataGridViewReceiptDetail.Rows[i].Cells[8].Value = double.Parse(dr["TaxAmmount"].ToString()).ToString("0,0"); //Thuế
                //    dataGridViewReceiptDetail.Rows[i].Cells[9].Value = double.Parse(dr["TotalAmmount"].ToString()).ToString("0,0"); //TT + Thuế
                //}
            }
            DanhLaiSTTGrid1();
        }

        private void DanhLaiSTTGrid1()
        {
            double TongTienTruocThue = 0;
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
                    if (dataGridViewReceiptDetail.Rows[i].Cells[2].Value.ToString() == "DISCOUNT")
                    {
                        continue;
                    }
                    dbTotalMoney = TongTienSauThue;
                }
            }
        }

        private void UpdateDataGridViewOrderDetail(int index)
        {
            int iQty = 0;
            double dbPrice = 0;
            double TongtienAmount = 0;
            double TotalTax = 0;
            double TotalAmount = 0;
            if (dataGridViewReceiptDetail.Rows[index].Cells["colQty"].Value != null)
            {
                iQty = int.Parse(dataGridViewReceiptDetail.Rows[index].Cells["colQty"].Value.ToString());
            }
            if (dataGridViewReceiptDetail.Rows[index].Cells["colPrice"].Value != null)
            {
                dbPrice = double.Parse(dataGridViewReceiptDetail.Rows[index].Cells["colPrice"].Value.ToString());
            }
            if (dataGridViewReceiptDetail.Rows[index].Cells["colProductId"].Value.ToString() != "DISCOUNT")
            {
                TongtienAmount = iQty * dbPrice;
                TotalTax = dbThueSuat * TongtienAmount;
                TotalAmount = TongtienAmount + TotalTax;
            }
            else
            {
                TongtienAmount = TotalAmount = dbPrice;
                TotalTax = 0;
            }
            dataGridViewReceiptDetail.Rows[index].Cells["colAmmountBeforeTax"].Value = TongtienAmount.ToString("0,0");
            dataGridViewReceiptDetail.Rows[index].Cells["colTaxAmmount"].Value = TotalTax.ToString("0,0");
            dataGridViewReceiptDetail.Rows[index].Cells["colTotalAmmount"].Value = TotalAmount.ToString("0,0");

            dataGridViewReceiptDetail.Rows[index].Cells["colQty"].ReadOnly = true;
            dataGridViewReceiptDetail.Rows[index].Cells["colPrice"].ReadOnly = true;

            //IsUpdate = false;
            IsModifile = true;
            DanhLaiSTTGrid1();
        }

        private bool CheckData()
        {
            if (txtUser.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleasePutInMemberCode"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return false;
            }
            if (rtxtNotes.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseInputNotes"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return false;
            }
            return true;
        }

        private void UpdateData(string Order)
        {
            dt_OD = orderdetailBLL.GetListsDetailForPayment(Order);
            dt_O = orderBLL.GetLists(Order);
            if (double.Parse(string.IsNullOrEmpty(dt_O.Rows[0]["DisCountAmount"].ToString()) ? "0" : dt_O.Rows[0]["DisCountAmount"].ToString()) > 0)
            {
                DataRow dt_giam = dt_OD.NewRow();
                dt_giam["OrderId"] = dt_O.Rows[0]["OrderId"].ToString();
                dt_giam["ProductId"] = "DISCOUNT";
                dt_giam["ProductName"] = "DISCOUNT";
                dt_giam["Price"] = "0";
                dt_giam["Qty"] = "1";
                dt_giam["AmmountBeforeTax"] = "0";
                dt_giam["TaxAmmount"] = "0";
                dt_giam["TotalAmmount"] = "0";
                dt_OD.Rows.Add(dt_giam);
            }
        }

        #region Do printing
        private bool DoPrinting(int Status)
        {
            PrintDocument pd = new PrintDocument();
            //pd.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["PrinterCard"];
            pd.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A7", 300, 10000);

            if (Status == 0)
                pd.PrintPage += new PrintPageEventHandler(this.printDocumentOrderKitchen_PrintPage);
            else if (Status == 3)
                pd.PrintPage += new PrintPageEventHandler(this.printDocumentOrderKitchen_Update_PrintPage);
            else if (Status == 2)
                pd.PrintPage += new PrintPageEventHandler(this.printDocumentOrderKitchen_Cancel_PrintPage);
            pd.Print();

            return true;
        }

        private void printDocumentOrderKitchen_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // load data hoa don
            OrderAll rcAll = new OrderAll();
            rcAll = orderBLL.GetOrderInfo(sOrderId);
            int y_p = 0;

            string[][] list = new string[rcAll.lst_Detail.Count][];
            int j = 0;
            foreach (OrderDetails dtl in rcAll.lst_Detail)
            {
                string[] arr = new string[4];
                arr[0] = j.ToString();
                //arr[1] = dtl.ProductId + " - " + dtl.ProductName;
                arr[1] = dtl.ProductName;
                arr[2] = dtl.Qty;
                arr[3] = dtl.Note;//(dtl.Notes == null) ? "" : dtl.Notes;
                list[j] = arr;
                j++;
            }
            string data;
            StringFormat strfmt_Left = new StringFormat();
            StringFormat strfmt_Center = new StringFormat();
            StringFormat strfmt_Right = new StringFormat();

            strfmt_Left.LineAlignment = StringAlignment.Near;
            strfmt_Left.Alignment = StringAlignment.Near;

            strfmt_Center.LineAlignment = StringAlignment.Center;
            strfmt_Center.Alignment = StringAlignment.Center;

            strfmt_Right.LineAlignment = StringAlignment.Far;
            strfmt_Right.Alignment = StringAlignment.Far;

            y_p += 20;
            Rectangle strDesk = new Rectangle(5, y_p, 250, 22);
            data = Common.clsLanguages.GetResource("Desk_") + " " + rcAll.order.DeskId;
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strDesk, strfmt_Left);

            Rectangle strDate = new Rectangle(5, y_p + 22, 250, 22);
            data = Common.clsLanguages.GetResource("ReceiptDate") + " " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strDate, strfmt_Left);

            Rectangle strReceiptId1 = new Rectangle(180, y_p, 100, 30);
            data = Int32.Parse(rcAll.order.OrderId.Substring(10)).ToString();
            e.Graphics.DrawString(data, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, strReceiptId1, strfmt_Right);

            y_p += 45;
            Rectangle strReceiptId = new Rectangle(5, y_p, 250, 22);
            data = Common.clsLanguages.GetResource("OrderIDNo") + " : 10#" + rcAll.order.OrderId.Substring(10);
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strReceiptId, strfmt_Left);

            y_p += 23;
            Rectangle strHD_STT = new Rectangle(5, y_p, 63, 22); // đổi , 30-28
            data = Common.clsLanguages.GetResource("No");
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_STT, strfmt_Left);

            Rectangle strHD_SP = new Rectangle(35, y_p, 220, 22);
            data = Common.clsLanguages.GetResource("Product");//"Sản phẩm ";  
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_SP, strfmt_Left);

            Rectangle strHD_SL = new Rectangle(260, y_p, 45, 22);
            data = Common.clsLanguages.GetResource("ReceiptProQty");//"SL";
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_SL, strfmt_Left);
            y_p += 30;
            for (int i = 0; i < list.Length; i++)
            {
                //Headers
                Rectangle strCT_STT = new Rectangle(5, y_p, 30, 22);
                data = (i + 1).ToString();
                e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, strCT_STT, strfmt_Left);

                data = list[i][1];
                int heightl = Int32.Parse(Math.Ceiling((double)data.Length / 17).ToString()) * 18 + 5;
                Rectangle strCT_SP = new Rectangle(35, y_p, 220, heightl);
                e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, strCT_SP, strfmt_Left);

                Rectangle strCT_SL = new Rectangle(260, y_p, 45, 22);

                data = list[i][2];
                e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, strCT_SL, strfmt_Left);


                data = list[i][3];
                int height = 0;
                if (!string.IsNullOrEmpty(data))
                {
                    height = Int32.Parse(Math.Ceiling((double)data.Length / 17).ToString()) * 18 + 4;
                    Rectangle notes = new Rectangle(5, y_p + heightl, 280, height);
                    e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, notes, strfmt_Left);
                }

                Rectangle RecLineCT = new Rectangle(5, y_p + heightl + height, 280, 22);
                data = "-----------------------------------------------------------------------";
                e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, RecLineCT, strfmt_Left);


                y_p = y_p + height + heightl + 20;
            }
        }

        private void printDocumentOrderKitchen_Update_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // load data hoa don
            OrderAll rcAll = new OrderAll();
            rcAll = orderBLL.GetOrderInfo(sOrderId);
            int y_p = 0;

            string[][] list = new string[rcAll.lst_Detail.Count][];
            int j = 0;
            foreach (OrderDetails dtl in rcAll.lst_Detail)
            {
                string[] arr = new string[5];
                arr[0] = j.ToString();
                //arr[1] = dtl.ProductId + " - " + dtl.ProductName;
                arr[1] = dtl.ProductName;
                arr[2] = dtl.Qty;
                arr[3] = dtl.Note;//(dtl.Notes == null) ? "" : dtl.Notes;
                arr[4] = dtl.Status;
                list[j] = arr;
                j++;
            }
            string data;
            StringFormat strfmt_Left = new StringFormat();
            StringFormat strfmt_Center = new StringFormat();
            StringFormat strfmt_Right = new StringFormat();

            strfmt_Left.LineAlignment = StringAlignment.Near;
            strfmt_Left.Alignment = StringAlignment.Near;

            strfmt_Center.LineAlignment = StringAlignment.Center;
            strfmt_Center.Alignment = StringAlignment.Center;

            strfmt_Right.LineAlignment = StringAlignment.Far;
            strfmt_Right.Alignment = StringAlignment.Far;


            y_p += 20;
            Rectangle strDesk = new Rectangle(5, y_p, 250, 22);
            data = Common.clsLanguages.GetResource("Desk_") + " " + rcAll.order.DeskId;
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strDesk, strfmt_Left);

            Rectangle strDate = new Rectangle(5, y_p + 22, 250, 22);
            data = Common.clsLanguages.GetResource("ReceiptDate") + " " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strDate, strfmt_Left);

            Rectangle strReceiptId1 = new Rectangle(180, y_p, 100, 30);
            data = Int32.Parse(rcAll.order.OrderId.Substring(10)).ToString();
            e.Graphics.DrawString(data, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, strReceiptId1, strfmt_Right);

            y_p += 45;
            Rectangle strReceiptId = new Rectangle(5, y_p, 250, 22);
            data = Common.clsLanguages.GetResource("UpdateOrder_1") + " : 10#" + rcAll.order.OrderId.Substring(10);
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strReceiptId, strfmt_Left);

            y_p += 23;
            Rectangle strHD_STT = new Rectangle(5, y_p, 63, 22); // đổi , 30-28
            data = Common.clsLanguages.GetResource("No");
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_STT, strfmt_Left);

            Rectangle strHD_SP = new Rectangle(35, y_p, 220, 22);
            data = Common.clsLanguages.GetResource("Product");//"Sản phẩm ";  
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_SP, strfmt_Left);

            Rectangle strHD_SL = new Rectangle(260, y_p, 45, 22);
            data = Common.clsLanguages.GetResource("ReceiptProQty");//"SL";
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_SL, strfmt_Left);
            y_p += 30;
            FontStyle ft = new FontStyle();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i][4] == "0")
                {
                    ft = FontStyle.Italic;
                }
                else if (list[i][4] == "2") ft = FontStyle.Strikeout;
                //Headers

                Rectangle strCT_STT = new Rectangle(5, y_p, 30, 22);
                data = (i + 1).ToString();
                e.Graphics.DrawString(data, new Font("Arial", 14, ft), Brushes.Black, strCT_STT, strfmt_Left);

                data = list[i][1];
                int heightl = Int32.Parse(Math.Ceiling((double)data.Length / 17).ToString()) * 18 + 5;
                Rectangle strCT_SP = new Rectangle(35, y_p, 220, heightl);
                e.Graphics.DrawString(data, new Font("Arial", 14, ft), Brushes.Black, strCT_SP, strfmt_Left);

                Rectangle strCT_SL = new Rectangle(260, y_p, 45, 22);
                data = list[i][2];
                e.Graphics.DrawString(data, new Font("Arial", 14, ft), Brushes.Black, strCT_SL, strfmt_Left);


                data = list[i][3];
                int height = 0;
                if (!string.IsNullOrEmpty(data))
                {
                    height = Int32.Parse(Math.Ceiling((double)data.Length / 17).ToString()) * 18 + 4;
                    Rectangle notes = new Rectangle(5, y_p + heightl, 280, height);
                    e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, notes, strfmt_Left);
                }

                Rectangle RecLineCT = new Rectangle(5, y_p + heightl + height, 280, 22);
                data = "-----------------------------------------------------------------------";
                e.Graphics.DrawString(data, new Font("Arial", 14, ft), Brushes.Black, RecLineCT, strfmt_Left);


                y_p = y_p + height + heightl + 20;
            }
        }

        private void printDocumentOrderKitchen_Cancel_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // load data hoa don
            OrderAll rcAll = new OrderAll();
            rcAll = orderBLL.GetOrderInfo(sOrderId);
            int y_p = 0;

            string[][] list = new string[rcAll.lst_Detail.Count][];
            int j = 0;
            foreach (OrderDetails dtl in rcAll.lst_Detail)
            {
                string[] arr = new string[5];
                arr[0] = j.ToString();
                //arr[1] = dtl.ProductId + " - " + dtl.ProductName;
                arr[1] = dtl.ProductName;
                arr[2] = dtl.Qty;
                arr[3] = dtl.Note;//(dtl.Notes == null) ? "" : dtl.Notes;
                arr[4] = dtl.Status;
                list[j] = arr;
                j++;
            }
            string data;
            StringFormat strfmt_Left = new StringFormat();
            StringFormat strfmt_Center = new StringFormat();
            StringFormat strfmt_Right = new StringFormat();

            strfmt_Left.LineAlignment = StringAlignment.Near;
            strfmt_Left.Alignment = StringAlignment.Near;

            strfmt_Center.LineAlignment = StringAlignment.Center;
            strfmt_Center.Alignment = StringAlignment.Center;

            strfmt_Right.LineAlignment = StringAlignment.Far;
            strfmt_Right.Alignment = StringAlignment.Far;

            y_p += 20;
            Rectangle strDesk = new Rectangle(5, y_p, 250, 22);
            data = Common.clsLanguages.GetResource("Desk_") + " " + rcAll.order.DeskId;
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strDesk, strfmt_Left);

            Rectangle strDate = new Rectangle(5, y_p + 22, 250, 22);
            data = Common.clsLanguages.GetResource("ReceiptDate") + " " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strDate, strfmt_Left);

            Rectangle strReceiptId1 = new Rectangle(180, y_p, 100, 30);
            data = Int32.Parse(rcAll.order.OrderId.Substring(10)).ToString();
            e.Graphics.DrawString(data, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, strReceiptId1, strfmt_Right);

            y_p += 45;
            Rectangle strReceiptId = new Rectangle(5, y_p, 250, 22);
            data = Common.clsLanguages.GetResource("CancelOrder") + " : 10#" + rcAll.order.OrderId.Substring(10);
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strReceiptId, strfmt_Left);

            y_p += 23;
            Rectangle strHD_STT = new Rectangle(5, y_p, 63, 22); // đổi , 30-28
            data = Common.clsLanguages.GetResource("No");
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_STT, strfmt_Left);

            Rectangle strHD_SP = new Rectangle(35, y_p, 220, 22);
            data = Common.clsLanguages.GetResource("Product");//"Sản phẩm ";  
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_SP, strfmt_Left);

            Rectangle strHD_SL = new Rectangle(260, y_p, 45, 22);
            data = Common.clsLanguages.GetResource("ReceiptProQty");//"SL";
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_SL, strfmt_Left);
            y_p += 30;
            FontStyle ft = FontStyle.Strikeout;
            for (int i = 0; i < list.Length; i++)
            {
                //Headers
                Rectangle strCT_STT = new Rectangle(5, y_p, 30, 22);
                data = (i + 1).ToString();
                e.Graphics.DrawString(data, new Font("Arial", 14, ft), Brushes.Black, strCT_STT, strfmt_Left);

                data = list[i][1];
                int heightl = Int32.Parse(Math.Ceiling((double)data.Length / 17).ToString()) * 18 + 5;
                Rectangle strCT_SP = new Rectangle(35, y_p, 220, heightl);
                e.Graphics.DrawString(data, new Font("Arial", 14, ft), Brushes.Black, strCT_SP, strfmt_Left);

                Rectangle strCT_SL = new Rectangle(260, y_p, 45, 22);

                data = list[i][2];
                e.Graphics.DrawString(data, new Font("Arial", 14, ft), Brushes.Black, strCT_SL, strfmt_Left);


                data = list[i][3];
                int height = 0;
                if (!string.IsNullOrEmpty(data))
                {
                    height = Int32.Parse(Math.Ceiling((double)data.Length / 17).ToString()) * 18 + 4;
                    Rectangle notes = new Rectangle(5, y_p + heightl, 280, height);
                    e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, notes, strfmt_Left);
                }

                Rectangle RecLineCT = new Rectangle(5, y_p + heightl + height, 280, 22);
                data = "-----------------------------------------------------------------------";
                e.Graphics.DrawString(data, new Font("Arial", 14, ft), Brushes.Black, RecLineCT, strfmt_Left);


                y_p = y_p + height + heightl + 20;
            }
        }
        #endregion

        #endregion

        #region DataGridView Events

        private void dataGridViewListOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListOrder.RowCount <= 0) return;
            string id = dataGridViewListOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            sOrderId = id;

            Add_Into_ReceiptDetail(id);

            if (dataGridViewListOrder.CurrentCell.OwningColumn.Name == "colPrint")
            {
                //Do event
                //IsPrintServer ? IsPrint : false
                if (!IsPrintServer)
                {
                    if (!DoPrinting(0))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NotFoundPrintPleaseCheck"),
                              Common.clsLanguages.GetResource("Information"),
                              Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                              Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                }
                else
                {
                    if (orderBLL.PrintOrder(id))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PrintSuccess"),
                                            Common.clsLanguages.GetResource("Information"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                    else
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NotFoundPrintPleaseCheck"),
                                  Common.clsLanguages.GetResource("Information"),
                                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                }
            }
            if (dataGridViewListOrder.CurrentCell.OwningColumn.Name == "colDel")
            {
                //Do event

            }
        }

        private void dataGridViewReceiptDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 11)
                {
                    //Reset ReadOnly columns
                    dataGridViewReceiptDetail.Columns["colQty"].ReadOnly = true;
                    dataGridViewReceiptDetail.Columns["colPrice"].ReadOnly = true;

                    IsUpdate = true;
                    //dataGridViewReceiptDetail.Rows[e.RowIndex].Cells["colPrice"].ReadOnly = false;
                    if (dataGridViewReceiptDetail.Rows[e.RowIndex].Cells["colProductId"].Value.ToString() != "DISCOUNT")
                    {
                        dataGridViewReceiptDetail.Rows[e.RowIndex].Cells["colQty"].ReadOnly = false;
                        DataGridViewCell cell = dataGridViewReceiptDetail.Rows[e.RowIndex].Cells["colQty"];
                        dataGridViewReceiptDetail.CurrentCell = cell;
                        dataGridViewReceiptDetail.BeginEdit(true);
                    }
                    else
                    {
                        IsDiscount = true;
                        dataGridViewReceiptDetail.Rows[e.RowIndex].Cells["colPrice"].ReadOnly = false;
                        DataGridViewCell cell = dataGridViewReceiptDetail.Rows[e.RowIndex].Cells["colPrice"];
                        dataGridViewReceiptDetail.CurrentCell = cell;
                        dataGridViewReceiptDetail.BeginEdit(true);
                    }
                    DanhLaiSTTGrid1();
                    dataGridViewListOrder.Enabled = false;
                }
                if (e.ColumnIndex == 10)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AreYouSureWantToDelete_None") + " " + dataGridViewReceiptDetail.Rows[e.RowIndex].Cells["colProductName"].Value + "'?",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        IsDelete = true;
                        dataGridViewReceiptDetail.Rows[e.RowIndex].Visible = false;
                        dataGridViewReceiptDetail.Rows[e.RowIndex].Cells["colStatus"].Value = "2";//Hủy món
                        DanhLaiSTTGrid1();
                    }
                }
            }
        }

        private void dataGridViewReceiptDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (IsUpdate)
            {
                UpdateDataGridViewOrderDetail(e.RowIndex);
            }
        }

        private void dataGridViewReceiptDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (IsUpdate)
            {
                if (dataGridViewReceiptDetail.CurrentCell.OwningColumn.Name == "colQty")// e.ColumnIndex == 5) //|| e.ColumnIndex == 6
                {
                    int i;
                    if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                    {
                        e.Cancel = true;
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseInputNumer"),
                                    Common.clsLanguages.GetResource("Error"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                    else if (i < 0)
                    {
                        e.Cancel = true;
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PlsPositiveNum"),
                                    Common.clsLanguages.GetResource("Error"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                }
                if (dataGridViewReceiptDetail.CurrentCell.OwningColumn.Name == "colPrice" && IsDiscount)// e.ColumnIndex == 5) //|| e.ColumnIndex == 6
                {
                    double i;
                    if (!double.TryParse(Convert.ToString(e.FormattedValue), out i))
                    {
                        e.Cancel = true;
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseInputNumer"),
                                    Common.clsLanguages.GetResource("Error"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                    else if (i > dbTotalMoney)
                    {
                        e.Cancel = true;
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DiscountInputError"),
                                    Common.clsLanguages.GetResource("Error"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                    else if (i < 0)
                    {
                        e.Cancel = true;
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PlsPositiveNum"),
                                    Common.clsLanguages.GetResource("Error"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                }
            }
        }

        private void dataGridViewReceiptDetail_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (IsUpdate)
            {
                if (sender.Equals(dataGridViewReceiptDetail.Columns["colQty"]))
                {
                    e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
                }
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Utility.MaskDigit(e);
        }

        #endregion

        #region Button Events

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

        private void bntFinish_Click(object sender, EventArgs e)
        {
            if (!CheckData()) return;
            //if (!IsUser) // temp cheap code - must IsUser = true
            //{
                //if (sOrderId != null)
                //{
                //    if (dataGridViewReceiptDetail.Rows.Count > 0)
                //    {
                //        if (!IsModifile && !IsDelete)
                //        {
                //            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NothingChange"),
                //                    Common.clsLanguages.GetResource("Information"),
                //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //            return;
                //        }
                //        /*
                //         * ------------------------------- Update Order ---------------------------
                //         */
                //        DataTable dt = new DataTable("ABC");

                //        //Add coulmns
                //        foreach (DataGridViewColumn dc in dataGridViewReceiptDetail.Columns)
                //        {
                //            dt.Columns.Add(dc.Name);
                //        }
                //        //Add Rows
                //        foreach (DataGridViewRow dr in dataGridViewReceiptDetail.Rows)
                //        {
                //            DataRow r = dt.NewRow();
                //            for (int iCol = 0; iCol < dataGridViewReceiptDetail.Columns.Count; iCol++)
                //            {
                //                r[iCol] = dr.Cells[iCol].Value;
                //                if (r[iCol].ToString() == "DISCOUNT") bHaveDiscount = true;
                //            }
                //            dt.Rows.Add(r);
                //        }
                //        dt.AcceptChanges();
                //        bntFinish.Cursor = Cursors.AppStarting;
                //        bool IsPrintServer = false;
                //        if (ConfigurationManager.AppSettings["IsPrintServer"] == "1") IsPrintServer = true;
                //        if (orderdetailBLL.UpdateOrderDetail(sEmployeeId, rtxtNotes.Text, sOrderId, bHaveDiscount, dt, IsPrintServer ? IsPrint : false, dbTotalMoney))
                //        {
                //            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("UpdateSuccess"),
                //                        Common.clsLanguages.GetResource("Information"),
                //                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //            if (!string.IsNullOrEmpty(orderdetailBLL.ErrorString))
                //                CustomMessageBox.MessageBox.ShowCustomMessageBox(orderdetailBLL.ErrorString,
                //                       Common.clsLanguages.GetResource("Warning"),
                //                       Common.Config.CUSTOM_MESSAGEBOX_ICON.Warning,//sua thanh Warning
                //                       Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //            //reset
                //            if (!IsPrintServer && IsPrint)
                //            {
                //                if (!DoPrinting(dataGridViewReceiptDetail.RowCount == 0 ? 2 : 3))//2 cancel, 3 update
                //                {
                //                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NotFoundPrintPleaseCheck"),
                //                          Common.clsLanguages.GetResource("Information"),
                //                          Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                          Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //                }
                //            }
                //            btnReset_Click(null, null);
                //        }
                //        else
                //        {
                //            if (orderdetailBLL.ErrorString == "DISCOUNT")
                //                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DiscountInputError"),
                //                       Common.clsLanguages.GetResource("Error"),
                //                       Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                //                       Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //            else
                //                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("UpdateFailed"),
                //                            Common.clsLanguages.GetResource("Information"),
                //                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //        }
                //        bntFinish.Cursor = Cursors.Hand;
                //    }
                //}
                //else
                //{
                //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NothingChange"),
                //                    Common.clsLanguages.GetResource("Information"),
                //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //}
            //}
            //else
            //{
            //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("EmployeeCodeNotExist"),
            //                        Common.clsLanguages.GetResource("Error"),
            //                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
            //                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            //}
            //dataGridViewListOrder.Enabled = true;

            //Payment
            if (payForm == null || !Form.ActiveForm.Contains(payForm))
            {
                //CloseForm();
                //this.Visible = false;
                payForm = new Screen.POS.PayForm(sOrderId);
                payForm.ShowDialog();
                //AddFormToMainPanel(frmServices);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IsUpdate = IsDelete = false;
            sOrderId = null;
            txtUser.Text = "";
            lbUser.Text = "";
            rtxtNotes.Text = "";
            dataGridViewReceiptDetail.Rows.Clear();
            txtUser.Text = "";
            IsUser = false;
            if (IsAll) LoadData_Orders_And_Refresh(0);
            else LoadData_Orders_And_Refresh(1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //VVPosS.Screen.POS.frmServices f = new VVPosS.Screen.POS.frmServices();
            //f.Visible = true;
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sOrderId))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseSelectOrder"),
                                            Common.clsLanguages.GetResource("Information"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
            //Check already exist DISCOUNT in grid
            if (dataGridViewReceiptDetail.Rows[dataGridViewReceiptDetail.RowCount - 1].Cells["colProductId"].Value.ToString() == "DISCOUNT")
            {
                dataGridViewReceiptDetail.Rows[dataGridViewReceiptDetail.RowCount - 1].Visible = true;
                dataGridViewReceiptDetail.Rows[dataGridViewReceiptDetail.RowCount - 1].Cells["colStatus"].Value = "0";//Mới
            }
            else
            {
                int i = dataGridViewReceiptDetail.Rows.Count;
                dataGridViewReceiptDetail.Rows.Add();
                dataGridViewReceiptDetail.Rows[i].Cells[0].Value = (i + 1).ToString(); //STT
                dataGridViewReceiptDetail.Rows[i].Cells[1].Value = dt_O.Rows[0]["OrderId"].ToString(); //OrderId
                dataGridViewReceiptDetail.Rows[i].Cells[2].Value = "DISCOUNT"; //ProductId
                dataGridViewReceiptDetail.Rows[i].Cells[3].Value = ""; //PromotionId
                dataGridViewReceiptDetail.Rows[i].Cells[4].Value = "DISCOUNT"; //Sản phẩm
                dataGridViewReceiptDetail.Rows[i].Cells[5].Value = "1"; //SL
                dataGridViewReceiptDetail.Rows[i].Cells[6].Value = "0"; //DG
                dataGridViewReceiptDetail.Rows[i].Cells[7].Value = "0"; //TT
                dataGridViewReceiptDetail.Rows[i].Cells[8].Value = "0"; //Thuế
                dataGridViewReceiptDetail.Rows[i].Cells[9].Value = "0"; //TT + Thuế
                dataGridViewReceiptDetail.Rows[i].Cells[10].Value = Common.clsLanguages.GetResource("ReceiptProDel"); //Xóa
                dataGridViewReceiptDetail.Rows[i].Cells[11].Value = Common.clsLanguages.GetResource("ReceiptProEdit"); //Sửa
                dataGridViewReceiptDetail.Rows[i].Cells[12].Value = "0";

                DataGridViewRow row = dataGridViewReceiptDetail.Rows[i];
                row.Height = 35;
            }
        }
        #endregion

        #region TextBox Events

        private void txtUser_Leave(object sender, EventArgs e)
        {
            //if (txtUser.Text != "")
            //{
            //    //check Exits and Valid EmployeeCode
            //    Employees objEmployee = new Employees();
            //    objEmployee = employeeBLL.GetEmployeeCode(txtUser.Text.Trim());
            //    if (objEmployee != null)
            //    {
            //        lbUser.Text = objEmployee.EmployeeCode;
            //        IsUser = true;
            //        sEmployeeId = objEmployee.EmployeeId;
            //    }
            //    else
            //    {
            //        str = lbUser.Text = Common.clsLanguages.GetResource("EmployeeCodeNotExist");
            //        IsUser = false;
            //    }
            //}
            //else
            //{
            //    lbUser.Text = Common.clsLanguages.GetResource("EmployeeCodeNotExist");
            //}
        }

        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                //check Exits and Valid EmployeeCode
                Employees objEmployee = new Employees();
                objEmployee = employeeBLL.GetEmployeeCode(txtUser.Text.Trim());

                if (objEmployee != null)
                {
                    lbUser.Text = objEmployee.EmployeeCode;
                    IsUser = true;
                    sEmployeeId = objEmployee.EmployeeId;
                }
                else
                {
                    str = lbUser.Text = Common.clsLanguages.GetResource("EmployeeCodeNotExist");
                    IsUser = false;
                }
            }
        }
        #endregion

        private void ckbIsPrint_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbIsPrint.Checked) IsPrint = true;
            else IsPrint = false;
        }

    }
}
