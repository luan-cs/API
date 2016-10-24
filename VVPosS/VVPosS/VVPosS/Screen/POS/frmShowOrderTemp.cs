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
using VVPosS.Common;
using System.Configuration;

namespace VVPosS.Screen.POS
{
    public partial class frmShowOrderTemp : Form
    {
        //private frmReceipt frmPayments;
        private OrderBLL orderBLL = new OrderBLL();
        private string _sOrderTemp = "", _sDeskName = Common.clsLanguages.GetResource("UnSelectDesk"),
             sOrderId = "";
        private double _TongtienAmount = 0, _TotalTax = 0, Discount = 0, TotalMoney = 0, _TotalAmountBeforeTax = 0;
        private bool IsPrint = false;
        private int _iDeskId = 0;



        public frmShowOrderTemp()
        {
            InitializeComponent();
            SettingControl();

        }

        private void frmShowOrderTemp_Load(object sender, EventArgs e)
        {
            SetUIChanges();
            ShowOrders();
            data_grid_order.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            data_grid_order.AllowUserToResizeRows = false;
            data_grid_order.RowTemplate.MinimumHeight = 200;
        }

        public string id = "";
        public string Id
        {
            get { return id; }
        }

        private void SettingControl()
        {
            //setting background for form
            //this.Size = new Size(756, 768);
            //this.BackgroundImage = Common.Utility.GetImageFromService("ShopImg", "bg5.png");
            //setting title


        }

        /// <summary>
        /// Set text for control
        /// </summary>
        public void SetUIChanges()
        {
            this.btnExit.Text = Common.clsLanguages.GetResource("Exit");
            this.lbTittle.Text = this.lbDesk.Text = Common.clsLanguages.GetResource("OrderTempList");
            this.lbChitiet.Text = Common.clsLanguages.GetResource("OrderDetail");
            this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            this.Desk.HeaderText = Common.clsLanguages.GetResource("Desk");
            this.Time.HeaderText = Common.clsLanguages.GetResource("Time");
            this.TotalMonney.HeaderText = Common.clsLanguages.GetResource("TotalAmount");
            this.Delete.HeaderText = Common.clsLanguages.GetResource("Delete");
            this.Chon.HeaderText = Common.clsLanguages.GetResource("Choose");
            this.colStt.HeaderText = Common.clsLanguages.GetResource("No");
            this.ProductName.HeaderText = Common.clsLanguages.GetResource("ProductName");
            this.Qty.HeaderText = Common.clsLanguages.GetResource("Quantity");
            this.Price.HeaderText = Common.clsLanguages.GetResource("Price");
            this.Total.HeaderText = Common.clsLanguages.GetResource("Total");
            this.btnComplete.Text = Common.clsLanguages.GetResource("Payment");
        }

        private void ShowOrders()
        {
            DataTable dt_Order = new DataTable();
            List<Orders> lst = new List<Orders>();
            foreach (OrderObject obj in Program.lstTemp)
            {
                lst.Add(obj.order);
            }
            dt_Order = Utility.ConvertListToDataTable<Orders>(lst);

            ////////////// Show ra
            int i = 0;
            foreach (DataRow r in dt_Order.Rows)
            {
                data_grid_order.Rows.Add();
                data_grid_order.Rows[i].Cells["STT"].Value = r["OrderId"];
                data_grid_order.Rows[i].Cells["DeskId"].Value = r["DeskId"];
                data_grid_order.Rows[i].Cells["Desk"].Value = r["DeskName"];
                data_grid_order.Rows[i].Cells["Time"].Value = DateTime.Parse(r["CreateDate"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                data_grid_order.Rows[i].Cells["TotalMonney"].Value = double.Parse(r["TotalMoney"].ToString()).ToString("0,0");
                //data_grid_order.Rows[i].Cells["TotalMonney"].Value = r["TotalMoney"];

                DataGridViewRow row = data_grid_order.Rows[i];
                row.Height = 40;

                i++;
            }
        }
        private void ShowOrdersDetail(string order)
        {
            DataTable dt_OrderDt = new DataTable();
            DataTable dt_orderDtall = new DataTable();
            DataTable dt_tam = new DataTable();
            List<OrderDetails> lst = new List<OrderDetails>();
            Dictionary<int, string> tmp = new Dictionary<int, string>();
            foreach (OrderObject obj in Program.lstTemp)
            {
                if (order == obj.order.DeskName)
                {
                    lst = obj.ListOrederDetail;
                    dt_OrderDt = Utility.ConvertListToDataTable<OrderDetails>(lst);
                    
                        //var a = item.ItemArray[2].ToString();
                        if (dt_tam.Rows.Count > 0)
                        {
                            dt_orderDtall.Clear();
                           
                            
                            foreach (DataRow item in dt_OrderDt.Rows)
                            {
                                
                                foreach (DataRow item1 in dt_tam.Rows)
                                {
                                    if (item.ItemArray[2].ToString().Equals(item1.ItemArray[2].ToString()))
                                    {
                                        #region add row
                                        DataRow dr = dt_orderDtall.NewRow();
                                        dr["ODID"] = "";
                                        dr["OrderId"] = item.ItemArray[1].ToString();
                                        dr["ProductId"] = item.ItemArray[2].ToString();
                                        dr["ProductName"] = item.ItemArray[3].ToString();
                                        dr["Qty"] = Int32.Parse(item.ItemArray[4].ToString()) + Int32.Parse(item1.ItemArray[4].ToString());
                                        dr["Price"] = item.ItemArray[5].ToString();
                                        dr["CreateDate"] = item.ItemArray[6].ToString();
                                        dr["CreateBy"] = item.ItemArray[7].ToString();
                                        dr["ModifiedBy"] = item.ItemArray[8].ToString();
                                        dr["ModifiedDate"] = item.ItemArray[9].ToString();
                                        dr["IsPrint"] = item.ItemArray[10].ToString();
                                        dr["Status"] = item.ItemArray[11].ToString();
                                        dr["Note"] = item.ItemArray[12].ToString();
                                        dr["AmmountBeforeTax"] = Decimal.Parse(item.ItemArray[13].ToString()) + Decimal.Parse(item1.ItemArray[13].ToString());
                                        dr["TaxAmmount"] = Decimal.Parse(item.ItemArray[14].ToString()) + Decimal.Parse(item1.ItemArray[14].ToString());
                                        dr["TotalAmount"] = Decimal.Parse(item.ItemArray[15].ToString()) + Decimal.Parse(item1.ItemArray[15].ToString());
                                        dr["IsBuffet"] = item.ItemArray[16].ToString();
                                        #endregion
                                        dt_orderDtall.Rows.Add(dr);
                                        //tmp.Add(j, item.ItemArray[2].ToString());
                                        //j++;
                                        break;
                                    }
                                    else if (!tmp.ContainsValue(item.ItemArray[2].ToString()))
                                    {
                                        tmp.Add(tmp.Count, item.ItemArray[2].ToString());;
                                        #region add row
                                        DataRow dr = dt_orderDtall.NewRow();
                                        dr["ODID"] = "";
                                        dr["OrderId"] = item.ItemArray[1].ToString();
                                        dr["ProductId"] = item.ItemArray[2].ToString();
                                        dr["ProductName"] = item.ItemArray[3].ToString();
                                        dr["Qty"] = item.ItemArray[4].ToString();
                                        dr["Price"] = item.ItemArray[5].ToString();
                                        dr["CreateDate"] = item.ItemArray[6].ToString();
                                        dr["CreateBy"] = item.ItemArray[7].ToString();
                                        dr["ModifiedBy"] = item.ItemArray[8].ToString();
                                        dr["ModifiedDate"] = item.ItemArray[9].ToString();
                                        dr["IsPrint"] = item.ItemArray[10].ToString();
                                        dr["Status"] = item.ItemArray[11].ToString();
                                        dr["Note"] = item.ItemArray[12].ToString();
                                        dr["AmmountBeforeTax"] = item.ItemArray[13].ToString();
                                        dr["TaxAmmount"] = item.ItemArray[14].ToString();
                                        dr["TotalAmount"] = item.ItemArray[15].ToString();
                                        dr["IsBuffet"] = item.ItemArray[16].ToString();
                                        #endregion
                                        dt_orderDtall.Rows.Add(dr);
                                    }
                                }
                            }
                        }
                        else
                        {
                            dt_orderDtall.Merge(dt_OrderDt);
                            int j = 0;
                            foreach (DataRow item in dt_OrderDt.Rows)
                            {
                                tmp.Add(j, item.ItemArray[2].ToString());
                                        j++;
                            }
                        }
                        //dt_tam = dt_orderDtall.Clone();
                        /**/
                    //}
                    if (dt_orderDtall.Rows.Count > 0)
                    {
                        dt_tam.Clear();
                        dt_tam = dt_orderDtall.Copy();
                    }
                    
                }
            }

            ////////////// Show ra
            int i = 0;
            foreach (DataRow r in dt_orderDtall.Rows)
            {
               
                data_grid_orderdt.Rows.Add();
                data_grid_orderdt.Rows[i].Cells["OrderId"].Value = _sOrderTemp;
                data_grid_orderdt.Rows[i].Cells["colStt"].Value = i + 1;
                data_grid_orderdt.Rows[i].Cells["ProductId"].Value = r["ProductId"];
                data_grid_orderdt.Rows[i].Cells["ProductName"].Value = r["ProductName"].ToString();
                data_grid_orderdt.Rows[i].Cells["Qty"].Value = double.Parse(r["Qty"].ToString()).ToString("0,0");
                data_grid_orderdt.Rows[i].Cells["Price"].Value = double.Parse(r["Price"].ToString()).ToString("0,0");
                data_grid_orderdt.Rows[i].Cells["VAT"].Value = double.Parse(r["TaxAmmount"].ToString()).ToString("0,0");
                data_grid_orderdt.Rows[i].Cells["AmountBeforeTax1"].Value = double.Parse(r["AmmountBeforeTax"].ToString()).ToString("0,0");
                data_grid_orderdt.Rows[i].Cells["Total"].Value = double.Parse(r["TotalAmount"].ToString()).ToString("0,0");
                data_grid_orderdt.Rows[i].Cells["ColNotes"].Value = r["Note"].ToString();
                data_grid_orderdt.Rows[i].Cells["ColIsBuffet"].Value = r["IsBuffet"].ToString();
                //data_grid_orderdt.Rows[i].Cells["Delete"].Value = "Xóa";

                i++;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void data_grid_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double count = 0;
            if (data_grid_order.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                ClearDataGridView(data_grid_orderdt);
                string id1 = _sOrderTemp = data_grid_order.Rows[e.RowIndex].Cells[0].Value.ToString();
                _iDeskId = int.Parse(data_grid_order.Rows[e.RowIndex].Cells[1].Value.ToString());
                ShowOrdersDetail(data_grid_order.Rows[e.RowIndex].Cells[2].Value.ToString());
                foreach (DataGridViewRow rows in data_grid_order.Rows)
                {
                    
                    if (rows.Cells["Desk"].Value.Equals(data_grid_order.Rows[e.RowIndex].Cells[2].Value.ToString()))
                    {
                        count += double.Parse(rows.Cells["TotalMonney"].Value.ToString());
                    }
                }
                this.btnComplete.Visible = true;
                this.lbTongtien.Visible = true;
                this.lbTongtienBan.Visible = true;
                this.lbTongtien.Text = Common.clsLanguages.GetResource("TotalAmount") + " Order " + data_grid_order.Rows[e.RowIndex].Cells[0].Value.ToString() + " : " + data_grid_order.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.lbTongtienBan.Text = Common.clsLanguages.GetResource("TotalAmount") + " " + Common.clsLanguages.GetResource("Desk") + " " + data_grid_order.Rows[e.RowIndex].Cells[2].Value.ToString() + " : " + count.ToString("0,0");
                //lbChitiet.Text = Common.clsLanguages.GetResource("OrderDetail") + " " + id1;
                if (e.ColumnIndex == 5)
                {

                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AreYouSureWantToDelete_None") + " Order" + id1 + "?",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        int i = 0;
                        foreach (OrderObject obj in Program.lstTemp)
                        {
                            if (obj.order.OrderId == id1)
                            {
                                break;
                            }
                            i++;
                        }
                        Program.lstTemp.RemoveAt(i);
                        ClearDataGridView(data_grid_orderdt);
                        data_grid_order.Rows.RemoveAt(i);
                        data_grid_order.Refresh();
                        lbChitiet.Text = Common.clsLanguages.GetResource("OrderDetail");
                    }

                }
                if (e.ColumnIndex == 6)
                {
                    id = data_grid_order.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }

        private void ClearDataGridView(DataGridView dtgv)
        {
            dtgv.Rows.Clear();
            dtgv.Refresh();
        }


        private void ClearDataGridView()
        {
            data_grid_orderdt.Rows.Clear();
            data_grid_orderdt.Refresh();
        }


        private void InsertOrder()//string OrderId
        {

            Orders or = new Orders();
            or.OrderId = "";
            or.DeskId = _iDeskId.ToString();
            or.CreatedBy = Program.Username;
            or.Status = "0";
            or.TotalAmmount = _TongtienAmount.ToString();
            or.TotalTax = _TotalTax.ToString();
            or.DisCountAmount = Discount.ToString();
            or.TotalAmountBeforeTax = _TotalAmountBeforeTax.ToString();
            or.TotalMoney = TotalMoney.ToString();

            string[][][] lstDetail = new string[data_grid_orderdt.Rows.Count][][];
            int i = 0;
            foreach (DataGridViewRow r in data_grid_orderdt.Rows)
            {
                string[][] param ={
                                    new string[] {"order_id",""},
                                    new string[] {"product_id",r.Cells["ProductId"].Value.ToString()},
                                    new string[] {"ProductName",r.Cells["ProductName"].Value.ToString()},
                                    new string[] {"qty_s", double.Parse(r.Cells["Qty"].Value.ToString()).ToString()},
                                    new string[] {"price_s",double.Parse(r.Cells["Price"].Value.ToString()).ToString()},
                                    new string[] {"create_by",Program.Username},
                                    new string[] {"status_s","0"},
                                    new string[] {"ammount_before_tax",double.Parse(r.Cells["AmountBeforeTax1"].Value.ToString()).ToString()},
                                    new string[] {"tax_ammount",double.Parse(r.Cells["VAT"].Value.ToString()).ToString()},
                                    new string[] {"total_ammount",double.Parse(r.Cells["Total"].Value.ToString()).ToString()},
                                    new string[] {"Note", string.IsNullOrEmpty(r.Cells["colNotes"].Value.ToString())? null: r.Cells["colNotes"].Value.ToString()},
                                    new string[] {"IsBuffet", r.Cells["colIsbuffet"].Value.ToString()}
                                    };
                lstDetail[i] = param;
                i++;
            }
            Desk desk = new Desk();
            desk.DeskId = _iDeskId.ToString();
            if (_iDeskId != 0)
                desk.IsUsing = "1";
            else desk.IsUsing = "0";
            //
            bool IsPrintServer = false;
            if (ConfigurationManager.AppSettings["IsPrintServer"] == "1") IsPrintServer = true;
            orderBLL.Add(or, lstDetail, IsPrintServer ? IsPrint : false, desk, ref sOrderId);
            if (orderBLL.Res)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AddSuccess"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                foreach (DataGridViewRow row in data_grid_order.Rows)
                {
                    if (row.Cells["DeskId"].Value.Equals(or.DeskId))
                    {                        
                        row.Cells["Delete"].Value = (System.Drawing.Image)(Properties.Resources.bg00);
                        row.Cells["Chon"].Value = (System.Drawing.Image)(Properties.Resources.bg00);
                    }
                }
            }
            else
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AddNewFailed"),
                                Common.clsLanguages.GetResource("Error"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        }


        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (_iDeskId == 0 && Program.IsRestaurant == 1)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseSelectADeskBeforeSave"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
            //Insert Order.
            InsertOrder();
            //Delete Order temp, if true.
            if (_sOrderTemp != "")
            {
                int i = 0;
                foreach (OrderObject obj in Program.lstTemp)
                {
                    if (obj.order.OrderId == _sOrderTemp)
                    {
                        break;
                    }
                    i++;
                }
                Program.lstTemp.RemoveAt(i);

                //int j = 0;
                if (Program.lstTemp.Count > 0)
                {
                    for (int j = 0; j < Program.lstTemp.Count; j++)
                    {
                        Program.lstTemp[j].order.OrderId = (j + 1).ToString();
                        foreach (OrderDetails odt in Program.lstTemp[j].ListOrederDetail)
                        {
                            odt.OrderId = (j + 1).ToString();
                        }
                    }
                }
            }
            _sOrderTemp = "";
            //this.Close();
        }
    }
}
