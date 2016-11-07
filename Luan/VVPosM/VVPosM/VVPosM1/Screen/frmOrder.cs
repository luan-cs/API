using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using VVPosM1.BusinessLayer;
using VVPosM1.Entities;
using VVPosM1.Common;

namespace VVPosM1.Screen
{
    public partial class frmOrder : Form
    {
        #region khai báo
        private Order obj;
        private OrderBLL objBLL;
        private Order objSea;
        // 
        private int CurPage;
        private double totalPage;
        #endregion
        Boolean soAm = true;
        Boolean thapPhan = true;

        public frmOrder()
        {
            InitializeComponent();
            SettingControl();
            SetUIChanges();
        }

        private void SettingControl()
        {
            //this.BackgroundImage = Utility.GetImageFromService("ShopImg", "bg12.png");
        }

        public void SetUIChanges()
        {
           // lblTitle.Text = Common.clsLanguages.GetResource("ManagerOrder");
            lbOrderId.Text = Common.clsLanguages.GetResource("OrderCode");
            lbDeskId.Text = Common.clsLanguages.GetResource("TableIDNo");
            lbCreatedBy.Text = Common.clsLanguages.GetResource("CreateBy");
            cbCreatedDate.Text = Common.clsLanguages.GetResource("CreateDate");
            lbTotalAmount.Text = Common.clsLanguages.GetResource("TotalAmount");
            lbDisCount.Text = Common.clsLanguages.GetResource("Discount");
            lbTotalMoney.Text = Common.clsLanguages.GetResource("TotalMoney");
            cbIsPrint.Text = Common.clsLanguages.GetResource("Print");
            rb1.Text = Common.clsLanguages.GetResource("Printed");
            rbn0.Text = Common.clsLanguages.GetResource("noPrint");

            btnSearch.Text = Common.clsLanguages.GetResource("Search");
            btnReset.Text = Common.clsLanguages.GetResource("Reset");
            btnExit.Text = Common.clsLanguages.GetResource("Exit");

            // datagridview
            gbOrder.Text = Common.clsLanguages.GetResource("ListOrder");
            gbOrderDetail.Text = Common.clsLanguages.GetResource("OrderDetail");

            this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            this.OrderId.HeaderText = Common.clsLanguages.GetResource("OrderCode");
            this.DeskNumber.HeaderText = Common.clsLanguages.GetResource("TableIDNo");
            this.Note.HeaderText = Common.clsLanguages.GetResource("Notes");
            this.InfoCreate.HeaderText = Common.clsLanguages.GetResource("InfoInitiated");
            this.Status.HeaderText = Common.clsLanguages.GetResource("Status");
            this.TotalAmount.HeaderText = Common.clsLanguages.GetResource("TotalAmount");
            this.colIsPrint.HeaderText = Common.clsLanguages.GetResource("StatusPrint");
            this.Cancel.HeaderText = Common.clsLanguages.GetResource("Cancel");
            this.PrintPlace.HeaderText = Common.clsLanguages.GetResource("PrintSpot");
            this.PrintKitchen.HeaderText = Common.clsLanguages.GetResource("PrintAtTheKitchen");

            this.STT2.HeaderText = Common.clsLanguages.GetResource("No");
            this.OrderId2.HeaderText = Common.clsLanguages.GetResource("OrderCode");
            this.NameProduct.HeaderText = Common.clsLanguages.GetResource("ProductName");//Unit
            this.Unit.HeaderText = Common.clsLanguages.GetResource("Unit");//ProductName
            this.Quantity.HeaderText = Common.clsLanguages.GetResource("Quantity");
            this.Price.HeaderText = Common.clsLanguages.GetResource("Price");
            this.TotalAmount1.HeaderText = Common.clsLanguages.GetResource("TotalAmount");

        }

        private void cbCreatedDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpCreatedDate1.Enabled = cbCreatedDate.Checked;
            dtpCreatedDate2.Enabled = cbCreatedDate.Checked;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CurPage = 1;
            totalPage = 1;
            //Truyen gia tri vao doi tuong objSea
            objSea = new Order();
            objSea.OrderId = tbOrderId.Text;
            //objSea.DeskId = string.IsNullOrEmpty(cbDeskNo.SelectedValue.ToString()) ? "" : cbDeskNo.SelectedValue.ToString();
            objSea.Note = null;
            objSea.CreatedBy = tbCreatedBy.Text;
            objSea.CreatedDateFrom = cbCreatedDate.Checked ? dtpCreatedDate1.Value.ToString("yyyy-MM-dd") : "";
            objSea.CreatedDateTo = cbCreatedDate.Checked ? dtpCreatedDate2.Value.ToString("yyyy-MM-dd") : "";
            objSea.TotalAmmount = tbTotalAmount.Text;
            objSea.DisCountAmount = tbDisCount.Text;
            objSea.TotalMoney = tbTotalMoney.Text;
            if (cbIsPrint.Checked)
            {
                if (rb1.Checked)
                {
                    objSea.IsPrint = "1";
                }
                else
                {
                    objSea.IsPrint = "0";
                }
            }
            else
            {
                objSea.IsPrint = null;
            }
            //objSea.IsPrint = cbIsPrint.Checked ? rb1.Checked ? "1" : "0" : null;
            dgvResult.Rows.Clear();
            dgvOrderDetail.Rows.Clear();
            SearchOrder(1);
        }

        private void GetDeskNo()
        {
            DataTable dt = objBLL.GetDeskIdNo();
            Dictionary<string, string> test = new Dictionary<string, string>();

            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Status_null"));
            foreach (DataRow dr in dt.Rows)
            {
                test.Add(dr["DeskId"].ToString(), dr["DeskNo"].ToString());
            }
            cbDeskNo.DataSource = new BindingSource(test, null);
            cbDeskNo.DisplayMember = "Value";
            cbDeskNo.ValueMember = "Key";
        }

        private void SearchOrder(int page)
        {
            CurPage = page;

            int total = 0;
            objBLL = new OrderBLL();
            DataTable dt = objBLL.SearchOrder(objSea, CurPage, out total);
            double RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            dgvResult.Rows.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                int i = 0;
                int stt = (page - 1) * RecPerPage;
                foreach (DataRow dr in dt.Rows)
                {
                    string str = "";
                    dgvResult.Rows.Add();
                    //STT
                    dgvResult.Rows[i].Cells[0].Value = (stt + 1).ToString();
                    //Mã phiếu
                    dgvResult.Rows[i].Cells[1].Value = dr["OrderId"].ToString();
                    //Mã bàn
                    dgvResult.Rows[i].Cells[2].Value = dr["DeskNo"].ToString();
                    //Chú thích
                    dgvResult.Rows[i].Cells[3].Value = dr["Note"].ToString();
                    //Thông tin khởi tạo
                    str = "";
                    str += clsLanguages.GetResource("Object21") + " " + dr["CreatedBy"].ToString() + "\n";
                    str += clsLanguages.GetResource("Object22") + " " + dr["CreatedDate"].ToString();
                    dgvResult.Rows[i].Cells[4].Value = str;
                    //Trạng thái
                    str = "";
                    if(!string.IsNullOrEmpty(dr["Status"].ToString()))
                    {
                        if (dr["Status"].ToString() == "0")
                        {
                            str = clsLanguages.GetResource("NotComplete");
                        }
                        else if (dr["Status"].ToString() == "1")
                        {
                            str = clsLanguages.GetResource("Complete1");
                        }
                        else if (dr["Status"].ToString() == "2")
                        {
                            str = clsLanguages.GetResource("Cancell1");
                        }
                        else
                        {
                            str = clsLanguages.GetResource("DataIncorrect1");
                        }
                    }
                    dgvResult.Rows[i].Cells[5].Value = str;
                    dgvResult.Rows[i].Cells[6].Value = dr["Status"].ToString();
                    //Tổng tiền
                    str = "";
                    str += Common.clsLanguages.GetResource("TotalAmountAfterTax") + ": " + string.Format("{0:###,###,###,###,###}", dr["TotalAmmount"]) + "\n";
                    str += Common.clsLanguages.GetResource("Discount") + ": " + string.Format("{0:###,###,###,###,###}", dr["DisCountAmount"]) + "\n";
                    str += Common.clsLanguages.GetResource("TotalMoneyReturn") + ": " + string.Format("{0:###,###,###,###,###}", dr["TotalMoney"]) + "\n";
                    dgvResult.Rows[i].Cells[7].Value = str;
                    //Trạng thái in
                    str = "Chưa in";
                    if (!string.IsNullOrEmpty(dr["IsPrint"].ToString()))
                    {
                        if (dr["IsPrint"].ToString() == "1")
                        {
                            str = Common.clsLanguages.GetResource("Printed");
                        }
                    }
                    dgvResult.Rows[i].Cells[8].Value = str;
                    dgvResult.Rows[i].Cells[9].Value = dr["IsPrint"].ToString();

                    i++; stt++;
                }
            }
            linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
            lblTB.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (CurPage > 1)
            {
                SearchOrder(CurPage - 1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurPage < totalPage)
            {
                SearchOrder(CurPage + 1);
            }
        }

        private void cbIsPrint_CheckedChanged(object sender, EventArgs e)
        {
            gbIsrint.Enabled = cbIsPrint.Checked;
        }

        private void dgvResult_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string orderId = dgvResult.Rows[e.RowIndex].Cells[1].Value.ToString();
                DataTable ctId = new DataTable();
                ctId = objBLL.GetOrderDetailById(orderId);

                dgvOrderDetail.Rows.Clear();
                if (ctId != null && ctId.Rows.Count > 0)
                {
                    int i = 0;
                    int stt = 0;
                    foreach (DataRow dr in ctId.Rows)
                    {
                        #region show thông tin chi tiết
                        dgvOrderDetail.Rows.Add();
                        //STT
                        dgvOrderDetail.Rows[i].Cells[0].Value = (stt + 1).ToString();
                        //Order ID
                        dgvOrderDetail.Rows[i].Cells[1].Value = dr["OrderId"].ToString();
                        //Tên sản phẩm
                        dgvOrderDetail.Rows[i].Cells[2].Value = dr["Name"].ToString();
                        //Đơn vị tính
                        dgvOrderDetail.Rows[i].Cells[3].Value = dr["Unit"].ToString();
                        //Số lượng
                        dgvOrderDetail.Rows[i].Cells[4].Value = dr["Qty"].ToString();
                        //Đơn giá
                        dgvOrderDetail.Rows[i].Cells[5].Value = string.Format("{0:###,###,###,###,###.##}", dr["Price"]);
                        //Tiền trước thuế
                        string str = "";
                        str += string.Format(Common.clsLanguages.GetResource("TotalAmountBeforeTax") + ": {0:###,###,###,###,###.##}", dr["AmmountBeforeTax"]) + "\n";
                        //Thuế
                        str += string.Format( Common.clsLanguages.GetResource("TotalTaxAmount")+": {0:###,###,###,###,###.##}", dr["TaxAmmount"]) + "\n";
                        //Tiền sau thuế
                        str += string.Format(Common.clsLanguages.GetResource("TotalAmountAfterTax") + ": {0:###,###,###,###,###.##}", dr["TotalAmmount"]);
                        dgvOrderDetail.Rows[i].Cells[6].Value = str;
                        #endregion
                        i++; stt++;
                    }
                }
                //Hủy order
                if (e.ColumnIndex == 10)
                {
                    if (dgvResult.Rows[e.RowIndex].Cells["colStatus"].Value.ToString() == "1"){
                        CustomMessageBox.MessageBox.ShowCustomMessageBox("Đã hoàn tất, không thể hủy !",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                    if (dgvResult.Rows[e.RowIndex].Cells["colStatus"].Value.ToString() == "2")
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox("Hóa đơn đã hủy trước đó!",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                    else
                    {
                        //CustomMessageBox.MessageBox("Bạn chắc chắn muốn hủy order?", 
                        if(CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AreYouSureYouWantToCancelTheOrder"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO)==DialogResult.Yes){
                        objBLL.DeleteOrder(orderId);
                        dgvResult.Rows[e.RowIndex].Cells[5].Value = Common.clsLanguages.GetResource("Cancelled");
                        dgvResult.Rows[e.RowIndex].Cells[8].ReadOnly = true;
                                    }
                    }
                }
                //else
                //    if (e.ColumnIndex == 11)
                //    {
                //        if (dgvResult.Rows[e.RowIndex].Cells["colStatus"].Value.ToString() == "2")
                //        {
                //            CustomMessageBox.MessageBox.ShowCustomMessageBox("Không thể in hóa đơn đã hủy!",
                //                    Common.clsLanguages.GetResource("Information"),
                //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //        }
                //        else
                //        {
                //            if (objBLL.PrintOrder(orderId,"1") == 1)
                //            {
                //                dgvResult.Rows[e.RowIndex].Cells[7].Value = "Đã in";
                //                CustomMessageBox.MessageBox.ShowCustomMessageBox("In thành công!",
                //                    Common.clsLanguages.GetResource("Information"),
                //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //            }
                //            else
                //            {
                //                CustomMessageBox.MessageBox.ShowCustomMessageBox("In không thành công!",
                //                    Common.clsLanguages.GetResource("Information"),
                //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //            }
                //        }
                //    }

                //In Hoa đơn // tào lao quá
                if (e.ColumnIndex == 11)
                {
                    if (dgvResult.Rows[e.RowIndex].Cells["colStatus"].Value.ToString() == "2")
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CanNotPrintCancelledTheReceipt."),
                            Common.clsLanguages.GetResource("Information"),
                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                    else
                    {
                        if (objBLL.PrintOrder(orderId, "2") == 1)
                        {
                            dgvResult.Rows[e.RowIndex].Cells[7].Value = Common.clsLanguages.GetResource("Printed");
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CompletedPrinting."),
                            Common.clsLanguages.GetResource("Information"),
                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                        else
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("FailedToPrint."),
                            Common.clsLanguages.GetResource("Information"),
                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.panel1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
            }

            dgvOrderDetail.Rows.Clear();
            dgvResult.Rows.Clear();
            linkNumber.Text = "1";
            lblTB.Text = "...";
            totalPage = 0;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            objBLL = new OrderBLL();
            //GetDeskNo();
        }


        private void tbTotalAmount_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            #region chỉ được nhập số
            if (string.IsNullOrEmpty(tbTotalAmount.Text))
            {
                soAm = true;
                thapPhan = true;
            }
            if (((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) || (e.KeyChar < (char)32) || (e.KeyChar == 43) || (e.KeyChar == '-') || (e.KeyChar == '.'))
            {
                if (e.KeyChar == '.')
                {
                    if (thapPhan)
                    {
                        e.Handled = false;
                        thapPhan = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (e.KeyChar == '-')
                    {
                        if (soAm)
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                soAm = false;
            }
            else
            {
                e.Handled = true;
            }
            #endregion
        }

        private void tbDisCount_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            #region chỉ được nhập số
            if (string.IsNullOrEmpty(tbDisCount.Text))
            {
                soAm = true;
                thapPhan = true;
            }
            if (((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) || (e.KeyChar < (char)32) || (e.KeyChar == 43) || (e.KeyChar == '-') || (e.KeyChar == '.'))
            {
                if (e.KeyChar == '.')
                {
                    if (thapPhan)
                    {
                        e.Handled = false;
                        thapPhan = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (e.KeyChar == '-')
                    {
                        if (soAm)
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                soAm = false;
            }
            else
            {
                e.Handled = true;
            }
            #endregion
        }

        private void tbTotalMoney_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            #region chỉ được nhập số
            if (string.IsNullOrEmpty(tbTotalMoney.Text))
            {
                soAm = true;
                thapPhan = true;
            }
            if (((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) || (e.KeyChar < (char)32) || (e.KeyChar == 43) || (e.KeyChar == '-') || (e.KeyChar == '.'))
            {
                if (e.KeyChar == '.')
                {
                    if (thapPhan)
                    {
                        e.Handled = false;
                        thapPhan = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (e.KeyChar == '-')
                    {
                        if (soAm)
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                soAm = false;
            }
            else
            {
                e.Handled = true;
            }
            #endregion
        }

        #region Begin Dung
        private void tbTotalAmount_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(tbTotalAmount, 26);
            Common.Utility.TextFormatNumber(tbTotalAmount, ConfigurationManager.AppSettings["TextFormatNum"]);
        }

        private void tbDisCount_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(tbDisCount, 26);
            Common.Utility.TextFormatNumber(tbDisCount, ConfigurationManager.AppSettings["TextFormatNum"]);
        }

        private void tbTotalMoney_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(tbTotalMoney, 26);
            Common.Utility.TextFormatNumber(tbTotalMoney, ConfigurationManager.AppSettings["TextFormatNum"]);
        }

        #endregion End Dung

        
    }
}
