﻿using System;
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
    public partial class frmServices : Form
    {
        private frmOrderList frmOrderList;
        private PayForm payForm;

        private ProductsBLL productsBLL = new ProductsBLL();
        private ProductPriceBLL productpriceBLL = new ProductPriceBLL();
        private CommonCodeBLL commonCodeBLL = new CommonCodeBLL();
        private OrderBLL orderBLL = new OrderBLL();
        private OrderDetailBLL orderdetailBLL = new OrderDetailBLL();
        private ReceiptsBLL receiptsBLL = new ReceiptsBLL();

        private DataTable dtOrder = new DataTable();
        private string _sType = "", _sName = "", _sProductId = "", _sIsBuffet = "", _sOrderTemp = "", _sDeskName = Common.clsLanguages.GetResource("UnSelectDesk"),
            str = "", sOrderId = "", _sParentId = null, _sCustomInfor = "";
        private double _TongtienAmount = 0, _TotalTax = 0, Discount = 0, TotalMoney = 0, _TotalAmountBeforeTax = 0, dbThueSuat;
        private bool IsPrint = false, IsTemp = false, IsNode = false, IsBuffet = false;
        private int _iDeskId = 0;
        private int _iCurrentPage = 1, _iTotalRecord = 0, _iTotalMenu = 0, _iCurrentPageMenu = 1;
        private int _iLx = 8, _iLy = 8, _iW = 100, _iDelta = 3;
        private List<string> lstMenu = new List<string>();         
        //lấy từ Store Aeon qua
        //private int curPage;
        //private double totalPage;
        //private string protoType = "00";
        //private string productType = null;
        //private int level = 1;
        //private string preProtoType = "00";
        //private int preCurPage;
        public frmServices()
        {
            InitializeComponent();
            //pMCenter.MinimumSize = new System.Drawing.Size(0, this.Height - pMTop.Height - pMBottom.MaximumSize.Height);
            //pMCenter.Height = 1000;
            SettingControl();
            
            lbtotal.Text = "0";
        }

        private void frmServices_Load(object sender, EventArgs e)
        {
            SetUIChanges();
            ToUpper();

            LoadMenu(null, 1, IsNode);
            lstMenu.Add("");
            LoadProducts(1, "");
            if (ConfigurationManager.AppSettings["IsPrintTran"] == "1")
            {
                ckbIsPrint.Checked = true;
            }
            if (ConfigurationManager.AppSettings["IsDiscount"] == "0")
            {
                lbDiscount.Enabled = false;
                txtDiscount.Enabled = false;
            }
            dbThueSuat = double.Parse(ConfigurationManager.AppSettings["VAT"]) / 100;
        }

        private void ToUpper() {
            bntAll.Text = bntAll.Text.ToUpper();
            //bntThucAn.Text = bntThucAn.Text.ToUpper();
            //bntNuocUong.Text = bntNuocUong.Text.ToUpper();
            //bntKhac.Text = bntKhac.Text.ToUpper();

            btnFrmPay.Text = btnFrmPay.Text.ToUpper();
            bntFrmMain.Text = bntFrmMain.Text.ToUpper();

            bntDesk.Text = bntDesk.Text.ToUpper();
            bntTamtinh.Text = bntTamtinh.Text.ToUpper();
            bntShowTamTinh.Text = bntShowTamTinh.Text.ToUpper();
            btnOrder.Text = btnOrder.Text.ToUpper();
            bntFinish.Text = bntFinish.Text.ToUpper();
        }
        /// <summary>
        /// Set text for control
        /// </summary>
        public void SetUIChanges()
        {
            bntAll.Text = Common.clsLanguages.GetResource("All");
            //bntThucAn.Text = Common.clsLanguages.GetResource("Foods");
            //bntNuocUong.Text = Common.clsLanguages.GetResource("Drinks");
            //bntKhac.Text = Common.clsLanguages.GetResource("Another");
            this.btnFrmPay.Text = Common.clsLanguages.GetResource("PaymentScreen");
            this.btnOrder.Text = Common.clsLanguages.GetResource("OrderList");
            bntFrmMain.Text = Common.clsLanguages.GetResource("MainScreen");
            bntFinish.Text = Common.clsLanguages.GetResource("Save");
            bntDesk.Text = Common.clsLanguages.GetResource("ChooseADesk");
            bntTamtinh.Text = Common.clsLanguages.GetResource("SaveTemp");
            bntShowTamTinh.Text = Common.clsLanguages.GetResource("ListTemps");
            //gSanpham.Text = Common.clsLanguages.GetResource("ProductsList");
            //gOrder.Text = Common.clsLanguages.GetResource("OrdersList");
            //lbBan.Text = Common.clsLanguages.GetResource("Desk_");
            //lbKhachHang.Text = Common.clsLanguages.GetResource("Customer_");
            this.stt.HeaderText = Common.clsLanguages.GetResource("No");
            this.ProductName.HeaderText = Common.clsLanguages.GetResource("ProductName");
            this.Qty.HeaderText = Common.clsLanguages.GetResource("Quantity");
            this.Price.HeaderText = Common.clsLanguages.GetResource("Price");
            this.AmountBeforeTax1.HeaderText = Common.clsLanguages.GetResource("Total");
            this.TotalAmount.HeaderText = Common.clsLanguages.GetResource("Total");
            //lbCustomerName.Text = Common.clsLanguages.GetResource("UnSelectCustomer");
            //lbDeskName.Text = Common.clsLanguages.GetResource("UnSelectDesk");
            lbDiscount.Text = Common.clsLanguages.GetResource("Discount");
            lbtotal.Text = Common.clsLanguages.GetResource("TotalAll");
            lbTotalLang.Text = Common.clsLanguages.GetResource("TotalAmount");
            ckbIsPrint.Text = Common.clsLanguages.GetResource("PrintAtTheKitchen"); //PrintAtTheKitchen
        }
        private void SettingControl()
        {
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.BACKGROUNDCOLOR);
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            pMTop.Width = pMCenter.Width = pMBottom.Width = this.Width;

        }

        private void Reset_Amount() {
            _TongtienAmount = 0;
            _TotalTax = 0;
            TotalMoney = 0;
            Discount = 0;
            _TotalAmountBeforeTax = 0;
            lbtotal.Text = "0";
        }

        #region Load Menu & Products

        private void LoadMenu(string ParentId, int page, bool Node)
        {
            DataTable dt = new DataTable();
            //Get List menu here
            dt = commonCodeBLL.GetMenus("ProductType", page, out _iTotalMenu, ParentId, Node);
            //Foreach
            if(dt.Rows.Count > 0){
                //pLstsub.Controls.Clear();
                //int i = 1;
                Button btn;
                foreach (DataRow r in dt.Rows) {
                    btn = new Button();

                    btn.BackColor = System.Drawing.Color.Transparent;
                    btn.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
                    btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    btn.Cursor = System.Windows.Forms.Cursors.Hand;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                    btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                    btn.ForeColor = System.Drawing.Color.Black;
                    btn.Image = global::VVPosS.Properties.Resources.khac_icon;
                    btn.Location = new System.Drawing.Point((int)_iLx, (int)_iLy);
                    btn.Tag =  r["CommonId"].ToString();
                    btn.Size = new System.Drawing.Size(100, 61);
                    btn.Text = r["StrValue1"].ToString();
                    btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    btn.UseVisualStyleBackColor = false;
                    btn.Click += new System.EventHandler(this.btn_Click);

                    pLstsub.Controls.Add(btn);
                    //if (Node && i == 3) break;
                    _iLx += _iW + _iDelta;
                    //i++;
                }
            }
            //_iTotalRecord = _iTotalMenu;
            _sParentId = ParentId;
            _iCurrentPageMenu = page;
        }

        private void btn_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            string sParentId = btn.Tag.ToString();

            IsBuffet = true;
            //Clear list menu if have sub node
            bntAll.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
            if(this.CheckHaveSubNode(sParentId)){
                pLstsub.Controls.Clear();
                _iLx = 8;
                IsNode = true;

                //xử lý hiệu ứng và vị trí 
                btn.BackgroundImage = global::VVPosS.Properties.Resources.ds_order_button;
                btn.Location = new System.Drawing.Point((int)_iLx, (int)_iLy);

                pLstsub.Controls.Add(btn);
                _iLx += _iW + _iDelta;

                //xử lý load menu
                LoadMenu(sParentId, 1, IsNode);
            }
            else {
                int i = 0;
                foreach (Control c in pLstsub.Controls) {
                    Button btn1 = c as Button;
                    if (btn1 != null && i != 0)
                        btn1.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
                    i++;
                }
                btn.BackgroundImage = global::VVPosS.Properties.Resources.ds_all_button;
            }

            //xử lý load sản phẩm
            string sLstNode = null;
            this.GetFullNode(sParentId, ref sLstNode);

            if (null != sLstNode)
            {
                sLstNode = "'" + sParentId + "'," + sLstNode;
                LoadProducts(1, sLstNode.Trim().Trim(','));
            }
            else LoadProducts(1, "'" + sParentId + "'");
        }

        private void GetFullNode(string sParentId, ref string sLstNode)
        {
            DataTable dt = new DataTable();
            dt = commonCodeBLL.LstChildNode(sParentId, "ProductType");
            if(dt != null){
                foreach (DataRow r in dt.Rows)
                {
                    string sNodeParent = r["CommonId"].ToString();
                    if (sParentId != sNodeParent)
                        sLstNode += "'" +  sNodeParent + "',";
                    this.GetFullNode(sNodeParent, ref sLstNode);
                }
            }
            else {
                //show message
            }
        }

        private bool CheckHaveSubNode(string sParentId) { 
            bool _Have = false;
            DataTable dt = new DataTable();
            dt = commonCodeBLL.LstChildNode(sParentId, "ProductType");
            if (dt != null) _Have = true;
            return _Have;
        }

        public void LoadProducts(int page, string type) {
            lstSp.Clear();
            imageList1.Images.Clear();
            DataTable dt = new DataTable();
            int totalRec = 0;

            //dt = productsBLL.GetList(type, page, out totalRec);
            //BEGIN Phần Modifile buffet
            if (IsBuffet) {
                dt = productsBLL.GetList(type, page, out totalRec);
            }
            else{
                if (!string.IsNullOrEmpty(type))
                    dt = productsBLL.GetListNotBuffet(type, page, out totalRec);
                else{
                    type = commonCodeBLL.GetListBuffet().Trim().Trim(',');
                    dt = productsBLL.GetListNotBuffet(type, page, out totalRec);
                }
            }
            //END Phần Modifile buffet

            lstSp.BeginUpdate();

            this.lstSp.View = View.LargeIcon;
            this.lstSp.ForeColor = System.Drawing.Color.Black;
            this.imageList1.ImageSize = new Size(95, 80);//115,80
            this.imageList1.ColorDepth = ColorDepth.Depth16Bit;
            lstSp.LargeImageList = imageList1;

            //Now add the images into the imageList..
            int i = 0;
            if (dt == null) return;
            foreach (DataRow dr in dt.Rows)
            {
                //Now add the images into the imageList..
                
                Image img1 = Utility.GetImageFromService("Products", dr["Image"].ToString());
                imageList1.Images.Add(img1);

                //Get Price
                //DataTable dtPrice = new DataTable();
                //dtPrice = productpriceBLL.GetProductsPriceByProductId(dr["ProductId"].ToString());
                ListViewItem listItem = new ListViewItem();
                listItem.ForeColor = System.Drawing.Color.Black;
                decimal _price = decimal.Parse(dr["Price"].ToString());

                Tuple<string, string> result = receiptsBLL.GetProductInfoForReceipt(dr["ProductId"].ToString());
                string sIsBuffet = result.Item2;
                //if (dtPrice != null && dtPrice.Rows.Count > 0)
                //{
                //    _price = decimal.Parse(dtPrice.Rows[0][0].ToString());
                //    listItem = new ListViewItem(dr["Name"].ToString() + " \n" + _price.ToString("0,0"));
                //}
                //else
                //{
                //    listItem = new ListViewItem(dr["Name"].ToString() + " \n" + Common.clsLanguages.GetResource("NotPrice"));//NotPrice
                //}
                listItem = new ListViewItem(dr["Name"].ToString() + " \n" + _price.ToString("0,0"));

                listItem.ImageIndex = i;
                
                // Add sub-items for Details view.
                listItem.SubItems.Add(dr["ProductId"].ToString());
                listItem.SubItems.Add(dr["Name"].ToString());
                listItem.SubItems.Add(_price.ToString("0,0.0"));
                listItem.SubItems.Add(sIsBuffet);

                lstSp.Items.Add(listItem);
                i++;
            }

           
            _iTotalRecord = totalRec;
            //
            int iOffset = int.Parse(ConfigurationManager.AppSettings["MaxRecord"]);
            double de = (double)_iTotalRecord / (double)iOffset;
            double _iTotalPage = Math.Ceiling(de);
            this.linkNumber.Text = page + "/" + _iTotalPage;
            //
            _sType = type;
            _iCurrentPage = page;


            // Re-enable the display.
            lstSp.EndUpdate();
        }


        #endregion

        private void GoPre()
        {
            if (_iCurrentPage > 1) {
                LoadProducts(_iCurrentPage-1, _sType);
            }
        }


        private void GoNext() { 
             int iOffset = int.Parse(ConfigurationManager.AppSettings["MaxRecord"]);
             double de = (double)_iTotalRecord / (double)iOffset;
            //decimal _iTotalPage=Math.Round(de,MidpointRounding.AwayFromZero);
             double _iTotalPage = Math.Ceiling(de);
            if (_iCurrentPage < _iTotalPage) {
                LoadProducts(_iCurrentPage + 1, _sType);
            }
        }

        private void GoPreMenu()
        {
            if (_iCurrentPageMenu > 1)
            {
                _iLx = 8;
                if (!IsNode)
                {
                    pLstsub.Controls.Clear();
                }else{
                    int i;
                    for (i = pLstsub.Controls.Count - 1; i >= 0; i--)
                    {
                        if (i != 0)
                            pLstsub.Controls.RemoveAt(i);
                    }

                    _iLx += _iW + _iDelta;
                }
                LoadMenu(_sParentId, _iCurrentPageMenu - 1, IsNode);
                //LoadProducts(0, _sParentId);

                //lstMenu.RemoveAt(lstMenu.Count - 1);
                //if (lstMenu.Count == 1) IsNode = false;
                //LoadMenu(lstMenu[lstMenu.Count - 1], _iCurrentPageMenu - 1, IsNode);
                //LoadProducts(0, lstMenu[lstMenu.Count - 1]);
            }
        }


        private void GoNextMenu()
        {
            int iOffset = int.Parse(ConfigurationManager.AppSettings["MaxMenu"]);
            if (IsNode) iOffset = iOffset - 1;
            double de = (double)_iTotalMenu / (double)iOffset;
            //decimal _iTotalPage=Math.Round(de,MidpointRounding.AwayFromZero);
            double _iTotolMenu = Math.Ceiling(de);
            
            if (_iCurrentPageMenu < _iTotolMenu)
            {
                _iLx = 8;
                if (!IsNode)
                {
                    pLstsub.Controls.Clear();
                    //LoadMenu(_sParentId, _iCurrentPageMenu + 1, IsNode);
                }else{
                    int i;
                    for(i = pLstsub.Controls.Count - 1; i >= 0; i--)
                    {
                        if (i != 0)
                            pLstsub.Controls.RemoveAt(i);
                    }
                
                    _iLx += _iW + _iDelta;
                }
                LoadMenu(_sParentId, _iCurrentPageMenu + 1, IsNode);
               // LoadProducts(0, _sParentId);
                //if (!lstMenu.Contains(_sParentId))
                //    lstMenu.Add(_sParentId);
            }
        }

        /// <summary>
        /// Click san pham se insert vao datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstSp_Click(object sender, EventArgs e)
        {
            //if (_iDeskId == 0 && Program.IsRestaurant == 1)
            //{
            //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PlsSelectTable"),
            //                    Common.clsLanguages.GetResource("Information"),
            //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
            //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            //    return;
            //}
            ListViewItem item = lstSp.SelectedItems[0];
            _sProductId = item.SubItems[1].Text;
            _sName = item.SubItems[2].Text;
            _sIsBuffet = item.SubItems[4].Text;
            double _dePrice = double.Parse(item.SubItems[3].Text);
            Products pro = new Products();
            pro.ProductId = _sProductId;
            pro.Name = _sName;
            pro.IsBuffet = _sIsBuffet;
            

            //Check require if have buffet
            if(pro.IsBuffet == "1" && _dePrice <= 0){
                bool _bBuffet = false;
                foreach (DataGridViewRow r in DataGridView1.Rows) {
                    if (r.Cells["colIsBuffet"].Value.ToString() == "1")
                    {
                        _bBuffet = true;
                        break;
                    }
                }

                if (!_bBuffet) { 
                    if (!orderBLL.HaveProIsBuffet(_iDeskId)) {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PlsBuffetPrice"),
                                  Common.clsLanguages.GetResource("Information"),
                                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                }
            }
            /* check price
             * if < 0 then input price
             */
            //if (_dePrice <= 0) {
                //frmInputPrice f = new frmInputPrice();
                //if (f.ShowDialog() == DialogResult.OK)
                //{
                //    _dePrice = f._dblPrice;
                //    InsertIntoGridDDH(pro, _dePrice, dbThueSuat, 1);
                //    goto end;
                //}
                //else goto end;
            //    CustomMessageBox.MessageBox.ShowCustomMessageBox("Sản phẩm chưa có giá",
            //                  Common.clsLanguages.GetResource("Information"),
            //                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
            //                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            //    return;
            //}
            
            //insert to datagridview
            InsertIntoGridDDH(pro, _dePrice, dbThueSuat,1);
            //AddItemOrder();
        //end:
        //    str = "khong lam gi het";
            //st 
        }

        #region Insert DataGridView
        /// <summary>
        /// Insert datagridview
        /// </summary>
        /// <param name="pro"></param>
        /// <param name="DGNhap"></param>
        /// <param name="thuesuat"></param>
        /// <param name="sl_moi"></param>
        private void InsertIntoGridDDH(Products pro, double DGNhap, double thuesuat, double sl_moi)
        {
            int sum = DataGridView1.Rows.Count;
            int i = 0;
            for (i = 0; i < DataGridView1.Rows.Count; i++)
            {
                if (DataGridView1.Rows[i].Cells["ProductId"].Value.ToString() == pro.ProductId)
                {
                    // cập nhật vào hàng này
                   // double sl_moi = double.Parse(txtSL.Text);
                    double sl_cu = double.Parse(DataGridView1.Rows[i].Cells["Qty"].Value.ToString());
                    double sl = sl_cu + sl_moi;
                    
                    //tt = sl * (DGNhap) * (1 + thuesuat);
                    double TotalAmountBeforeTax  = sl * DGNhap;
                    double TotalTax = thuesuat * (sl * DGNhap);
                    double TongtienAmount = TotalAmountBeforeTax + TotalTax;

                    //dataGridView1.Rows[j].Cells[2].Value = String.Format("{0:0,0,0,0}", dr["DG"]);
                    DataGridView1.Rows[i].Cells["Qty"].Value = sl.ToString("0,0");
                    DataGridView1.Rows[i].Cells["Price"].Value = DGNhap.ToString("0,0");
                    DataGridView1.Rows[i].Cells["VAT"].Value = TotalTax.ToString("0,0");
                    DataGridView1.Rows[i].Cells["AmountBeforeTax1"].Value = TotalAmountBeforeTax.ToString("0,0");
                    DataGridView1.Rows[i].Cells["TotalAmount"].Value = TongtienAmount.ToString("0,0");
                    DataGridView1.Rows[i].Cells["colNotes"].Value = "";
                    //dataGridView1.Rows[i].Cells[8].Value = "Xóa";
                    break;
                }
            }
            if (i == DataGridView1.Rows.Count)
            {
                //Đưa vào lưới
                i = DataGridView1.Rows.Count;
                double sl = sl_moi;
                double tt = sl * DGNhap * (1 + thuesuat);
                double TotalAmountBeforeTax = sl * DGNhap;
                double TotalTax = thuesuat * (sl * DGNhap);
                double TongtienAmount = TotalAmountBeforeTax + TotalTax;

                DataGridView1.Rows.Add();
                DataGridView1.Rows[i].Cells["OrderId"].Value = "";
                DataGridView1.Rows[i].Cells["stt"].Value = "";
                DataGridView1.Rows[i].Cells["ProductId"].Value = pro.ProductId;
                DataGridView1.Rows[i].Cells["ProductName"].Value = pro.Name;
                DataGridView1.Rows[i].Cells["Qty"].Value = sl.ToString("0,0");
                DataGridView1.Rows[i].Cells["Price"].Value = DGNhap.ToString("0,0");
                DataGridView1.Rows[i].Cells["VAT"].Value = TotalTax.ToString("0,0");
                DataGridView1.Rows[i].Cells["AmountBeforeTax1"].Value = TotalAmountBeforeTax.ToString("0,0");
                DataGridView1.Rows[i].Cells["TotalAmount"].Value = TongtienAmount.ToString("0,0");
                DataGridView1.Rows[i].Cells["colNotes"].Value = "";
                DataGridView1.Rows[i].Cells["colIsBuffet"].Value = pro.IsBuffet;
                //DataGridView1.Rows[i].Cells["colDelete"].Value = "Xóa";

               

                DataGridViewRow row = DataGridView1.Rows[i];
                row.Height = 40;
            }
            DanhLaiSTTGrid1();
        }

        #endregion 

        #region Load DataGridview Order Detail
        private void DanhLaiSTTGrid1()
        {
            double TotalTax = 0;
            double TongtienAmount = 0;
            double TotalAmountBeforeTax = 0;
            //double TotalMoney = 0;
            if (DataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
                    DataGridView1.Rows[i].Cells[1].Value = (i + 1).ToString();
                    double sl = double.Parse(DataGridView1.Rows[i].Cells["Qty"].Value.ToString());
                    double dg = double.Parse(DataGridView1.Rows[i].Cells["Price"].Value.ToString());
                    //double thuesuat = double.Parse(DataGridView1.Rows[i].Cells["VAT"].Value.ToString());
                    double row_TienThue = double.Parse(DataGridView1.Rows[i].Cells["VAT"].Value.ToString());
                    double amountBefore = double.Parse(DataGridView1.Rows[i].Cells["AmountBeforeTax1"].Value.ToString());
                    double tt = double.Parse(DataGridView1.Rows[i].Cells["TotalAmount"].Value.ToString());
                    //double row_TienThue = sl * dg * thuesuat;
                    TotalTax = TotalTax + row_TienThue;
                    TongtienAmount = TongtienAmount + tt;
                    TotalAmountBeforeTax = TotalAmountBeforeTax + amountBefore;

                }
                _TotalAmountBeforeTax = TotalAmountBeforeTax;
                _TotalTax = TotalTax;
                _TongtienAmount = TongtienAmount;
                //TotalMoney = TotalAmountBeforeTax - Discount;
                TotalMoney = _TongtienAmount - Discount;
            }
            else {
                //_TotalAmountBeforeTax = 0;
                _TongtienAmount = 0;
                TotalMoney = 0; 
            }
            lbtotal.Text = TotalMoney.ToString("0,0");// TotalMoney.ToString("###,###,##0");


        }

        #endregion

        /// <summary>
        /// Lưu order vao list tam tinh --> chua lưu vao database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void InsertOrder()//string OrderId
        {
            
            Orders or = new Orders();
            or.OrderId = "";
            or.DeskId = _iDeskId.ToString() ;
            or.CreatedBy = Program.Username;
            or.Status = "0";
            or.TotalAmmount = _TongtienAmount.ToString();
            or.TotalTax = _TotalTax.ToString();
            or.DisCountAmount = Discount.ToString();
            or.TotalAmountBeforeTax = _TotalAmountBeforeTax.ToString();
            or.TotalMoney = TotalMoney.ToString();
            or.Note = _sCustomInfor;

            string[][][] lstDetail = new string[DataGridView1.Rows.Count][][];
            int i = 0;
            foreach (DataGridViewRow r in DataGridView1.Rows)
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
                                    new string[] {"total_ammount",double.Parse(r.Cells["TotalAmount"].Value.ToString()).ToString()},
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
                ClearDataGridView();
                if (!IsPrintServer && IsPrint)
                {
                    if (!DoPrintingKitchen()) {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NotFoundPrintPleaseCheck"),
                              Common.clsLanguages.GetResource("Information"),
                              Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                              Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                }
            }
            else
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AddNewFailed"),
                                Common.clsLanguages.GetResource("Error"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);


        }

        #region Do Printing
        private bool DoPrinting()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["Printer"];
            pd.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize(Program.PaperSizeName, 211, 10000);
            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);

            pd.Print();


            return true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // load data hoa don
            // load data hoa don
            OrderAll rcAll = new OrderAll();
            rcAll = orderBLL.GetOrderInfo(sOrderId);
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
            Rectangle logo = new Rectangle(0, 10, 70, 40);
            e.Graphics.DrawImage(imgLogo, logo);

            Rectangle strHoaDon = new Rectangle(70, 5, 120, 20);
            string data = Common.clsLanguages.GetResource("Receipt");//"HÓA ĐƠN";
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.DarkSlateBlue, strHoaDon, strfmt_Right);

            //Ngày hóa đơn
            Rectangle strRec = new Rectangle(70, 25, 120, 15);
            data = Common.clsLanguages.GetResource("ReceiptDate") + rcAll.order.CreateDate; //"Ngày :"
            e.Graphics.DrawString(data, new Font("Arial", 6, FontStyle.Regular), Brushes.DarkSlateBlue, strRec, strfmt_Right);


            Rectangle RecLine1 = new Rectangle(70, 40, 120, 2);
            var Line1 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line1, RecLine1);

            Rectangle strRec1 = new Rectangle(100, 42, 90, 18);
            string strSoHD = rcAll.order.OrderId;
            int soHD = int.Parse(strSoHD.Substring(10));
            data = Common.clsLanguages.GetResource("ReceiptNumber") + " : 11#" + soHD.ToString(); //"Số HĐ: "
            e.Graphics.DrawString(data, new Font("Arial", 6, FontStyle.Italic), Brushes.DarkSlateBlue, strRec1, strfmt_Right);

            //// Cty....
            Rectangle strCty = new Rectangle(0, 50, 100, 40);//20
            data = Common.clsLanguages.GetResource("MerchantName");// "HD Tech";           
            e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Bold), Brushes.DarkSlateBlue, strCty, strfmt_Left);
            //Địa chỉ Cty
            Rectangle strDCCty = new Rectangle(0, 90, 190, 50);//50
            data = Common.clsLanguages.GetResource("MerchantAddress") + "\n" + Common.clsLanguages.GetResource("MerchantTel") + "\n" + Common.clsLanguages.GetResource("MerchantWeb");
            e.Graphics.DrawString(data, new Font("Arial", 6, FontStyle.Regular), Brushes.DarkSlateBlue, strDCCty, strfmt_Left);

            //Headers
            Rectangle strHD_STT = new Rectangle(0, 140, 15, 18);
            data = Common.clsLanguages.GetResource("No");// "STT";           
            e.Graphics.DrawString(data, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, strHD_STT, strfmt_Center);

            Rectangle strHD_SP = new Rectangle(16, 140, 79, 18);
            data = Common.clsLanguages.GetResource("Product");//"Sản phẩm ";           
            e.Graphics.DrawString(data, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, strHD_SP, strfmt_Left_Center);

            Rectangle strHD_SL = new Rectangle(95, 140, 15, 18);
            data = Common.clsLanguages.GetResource("ReceiptProQty");//"SL";
            e.Graphics.DrawString(data, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, strHD_SL, strfmt_Center);

            Rectangle strHD_DG = new Rectangle(110, 140, 40, 18);
            data = Common.clsLanguages.GetResource("ReceiptProPrice");//"ĐG";
            e.Graphics.DrawString(data, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, strHD_DG, strfmt_Right_Center);

            Rectangle strHD_TT = new Rectangle(150, 140, 40, 18);
            data = Common.clsLanguages.GetResource("ReceiptProTotal");//ReceiptProTotalAfterTax "TT + Thuế";
            e.Graphics.DrawString(data, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, strHD_TT, strfmt_Right_Center);

            Rectangle RecLine2 = new Rectangle(0, 158, 190, 2);
            var Line2 = Common.Utility.GetImageFromService("ShopImg", "line2.png");
            e.Graphics.DrawImage(Line2, RecLine2);

            if (rcAll.lst_Detail != null && rcAll.lst_Detail.Count > 0)
            {
                y_p = 160;

                int i = 0;
                foreach (OrderDetails dtl in rcAll.lst_Detail)
                {
                    i++;
                    //Headers
                    h_s = 22;
                    //Common.clsLanguages.GetResource("ProductID") + " " + dtl.ProductId + " - " +
                    double _dbLength = (dtl.ProductName).Length;
                    if (_dbLength > 85 / 5)
                    {
                        int _iCelling = (int)Math.Ceiling((_dbLength * 5) / 85);
                        h_s = 14 * _iCelling + 12;
                    }

					//if (dtl.IsBuffet == "0" || (dtl.IsBuffet == "1" && double.Parse(dtl.Price) > 0))
					//{
					Rectangle strCT_STT = new Rectangle(0, y_p, 30, h_s);
					data = i.ToString();
					e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, strCT_STT, strfmt_Center);

					Rectangle strCT_SP = new Rectangle(30, y_p, 160, h_s);
					data = dtl.ProductName;
					e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, strCT_SP, strfmt_Left_Center);

					//y_p += h_s;
					//Rectangle strCT_SL = new Rectangle(30, y_p, 80, h_s);
					//data = dtl.Qty;
					//e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, strCT_SL, strfmt_Center);

					y_p += h_s;
					Rectangle strTT_DG = new Rectangle(30, y_p, 80, h_s);
					//data = (double.Parse(dtl.Price) + (double.Parse(dtl.TaxAmount) / double.Parse(dtl.Qty))).ToString("0,0");
					data = dtl.Qty + " x " + dtl.Price;
					e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, strTT_DG, strfmt_Right_Center);

					Rectangle strTT_TT = new Rectangle(110, y_p, 80, h_s);
					data = dtl.TotalAmount;
					e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, strTT_TT, strfmt_Right_Center);

					y_p += h_s;
					Rectangle RecLineCT = new Rectangle(0, y_p, 190, 1);
					var LineCT = Common.Utility.GetImageFromService("ShopImg", "linect.png");
					e.Graphics.DrawImage(LineCT, RecLineCT);
					//}
					//else
					//{
					//    Rectangle strCT_SP = new Rectangle(43, y_p, 147, h_s);//60
					//    data = dtl.ProductName;
					//    e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SP, strfmt_Left_Center);

					//    Rectangle strCT_SL = new Rectangle(190, y_p, 30, h_s);
					//    data = dtl.Qty;
					//    e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, strCT_SL, strfmt_Right_Center);

					//    y_p += h_s;
					//    Rectangle RecLineCT = new Rectangle(43, y_p, 247, 1);
					//    var LineCT = Common.Utility.GetImageFromService("ShopImg", "linect.png");
					//    e.Graphics.DrawImage(LineCT, RecLineCT);

					//}


				}
            }


            ///Tổng tiền trước thuế /sau thuế
            Rectangle RecTTST = new Rectangle(0, y_p, 129, 15);
            data = Common.clsLanguages.GetResource("TotalAmount");
            e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, RecTTST, strfmt_Right);

            Rectangle RecTTST_Val = new Rectangle(129, y_p, 61, 15);
            data = rcAll.order.TotalAmountBeforeTax;
            e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Bold), Brushes.Black, RecTTST_Val, strfmt_Right);
            y_p = y_p + 15;

            ///phí dịch vụ
            Rectangle RecPDV = new Rectangle(0, y_p, 129, 15);
            data = Common.clsLanguages.GetResource("TaxAndServiceChange") + " (" + (int.Parse(ConfigurationManager.AppSettings["SeviceCostPercent"]) +
                int.Parse(ConfigurationManager.AppSettings["VAT"])) + " %)"; //Common.clsLanguages.GetResource("TotalServiceCharge");//
            e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, RecPDV, strfmt_Right);

            Rectangle RecPDV_Val = new Rectangle(129, y_p, 61, 15);
            data = /*(double.Parse(rcAll.order.ServiceCostAmount) +*/ double.Parse(rcAll.order.TotalTax).ToString("0,0");
            e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Bold), Brushes.Black, RecPDV_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Giảm giá
            Rectangle RecDIS = new Rectangle(0, y_p, 129, 15);
            data = Common.clsLanguages.GetResource("TotalDiscountAmount");//"Giảm giá ";
            e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, RecDIS, strfmt_Right);

            Rectangle RecDIS_Val = new Rectangle(129, y_p, 61, 15);
            data = rcAll.order.DisCountAmount;
            e.Graphics.DrawString(data, new Font("Arial", 7, FontStyle.Bold), Brushes.Black, RecDIS_Val, strfmt_Right);
            y_p = y_p + 15;

            ///Tổng tiền thanh toán
            Rectangle RecPAY = new Rectangle(0, y_p, 129, 15);
            data = Common.clsLanguages.GetResource("TotalMoney");//"TC Cần thanh toán";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecPAY, strfmt_Right);

            Rectangle RecPAY_Val = new Rectangle(129, y_p, 61, 15);
            data = rcAll.order.TotalMoney;
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecPAY_Val, strfmt_Right);
            y_p = y_p + 15;

            ////
            //Rectangle RecLine3 = new Rectangle(90, y_p, 200, 1);
            //var Line3 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            //e.Graphics.DrawImage(Line3, RecLine3);
            //y_p = y_p + 2;

            /////Tổng tiền mặt
            //Rectangle RecCASH = new Rectangle(80, y_p, 120, 15);
            //data = Common.clsLanguages.GetResource("CashPayment");//Common.clsLanguages.GetResource("TotalCashCustomer");//"Tiền mặt khách đưa";
            //e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecCASH, strfmt_Right);

            //Rectangle RecCASH_Val = new Rectangle(200, y_p, 80, 15);
            //data = rcAll.order.CashPayAmt;
            //e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecCASH_Val, strfmt_Right);
            //y_p = y_p + 15;

            /////Tổng tiền thẻ
            //Rectangle RecCARD = new Rectangle(80, y_p, 120, 15);
            //data = Common.clsLanguages.GetResource("CardPayment");//Common.clsLanguages.GetResource("TotalCardAmount");//"Tiền thẻ khách:";
            //e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecCARD, strfmt_Right);

            //Rectangle RecCARD_Val = new Rectangle(200, y_p, 80, 15);
            //data = rcAll.receipt.CardPayAmt;
            //e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecCARD_Val, strfmt_Right);
            //y_p = y_p + 15;

            /////Số tiền thối lại
            //Rectangle RecRefun = new Rectangle(80, y_p, 120, 15);
            //data = Common.clsLanguages.GetResource("TotalReturnAmount");//Common.clsLanguages.GetResource("TotalCardAmount");//"Tiền thẻ khách:";
            //e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, RecRefun, strfmt_Right);

            //Rectangle RecRefun_Val = new Rectangle(200, y_p, 80, 15);
            //data = rcAll.receipt.ReturnAmt;
            //e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, RecRefun_Val, strfmt_Right);
            //y_p = y_p + 15;



            ////
            Rectangle RecLine6 = new Rectangle(0, y_p, 190, 2);
            var Line6 = Common.Utility.GetImageFromService("ShopImg", "line1.png");
            e.Graphics.DrawImage(Line6, RecLine6);
            y_p = y_p + 4;

            Rectangle RecTK = new Rectangle(0, y_p, 190, 18);
            data = Common.clsLanguages.GetResource("ReceiptFooterText"); //"Cám ơn & hẹn gặp lại quý khách !";
            e.Graphics.DrawString(data, new Font("Arial", 8, FontStyle.Italic), Brushes.Black, RecTK, strfmt_Left);

            //Rectangle RecPower = new Rectangle(200, y_p, 95, 47);
            //var LineP = Common.Utility.GetImageFromService("VVImg", "powered by vv.emf");
            //e.Graphics.DrawImage(LineP, RecPower);
            //y_p = y_p + 47;

        }

        #endregion 

        #region Do printing kitchen
        private bool DoPrintingKitchen()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["PrinterKitchen"];
            pd.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize(Program.PaperSizeName, 211, 10000);

            pd.PrintPage += new PrintPageEventHandler(this.printDocumentOrderKitchen_PrintPage);

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
            Rectangle strDesk = new Rectangle(5, y_p, 150, 22);
            data = Common.clsLanguages.GetResource("Desk_") + " " + rcAll.order.DeskId;
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strDesk, strfmt_Left);

            Rectangle strDate = new Rectangle(5, y_p + 22, 150, 22);
            data = Common.clsLanguages.GetResource("ReceiptDate") + " " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strDate, strfmt_Left);

            Rectangle strReceiptId1 = new Rectangle(111, y_p, 100, 30);
            data = Int32.Parse(rcAll.order.OrderId.Substring(10)).ToString();
            e.Graphics.DrawString(data, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, strReceiptId1, strfmt_Right);

            y_p += 45;
            Rectangle strReceiptId = new Rectangle(5, y_p, 206, 22);
            data = Common.clsLanguages.GetResource("OrderIDNo") + " : 10#" + rcAll.order.OrderId.Substring(10);
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strReceiptId, strfmt_Left);

            y_p += 23;
            Rectangle strHD_STT = new Rectangle(5, y_p, 15, 22); // đổi , 30-28
            data = Common.clsLanguages.GetResource("No");
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_STT, strfmt_Left);

            Rectangle strHD_SP = new Rectangle(20, y_p, 171, 22);
            data = Common.clsLanguages.GetResource("Product");//"Sản phẩm ";  
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_SP, strfmt_Left);

            Rectangle strHD_SL = new Rectangle(191, y_p, 15, 22);
            data = Common.clsLanguages.GetResource("ReceiptProQty");//"SL";
            e.Graphics.DrawString(data, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, strHD_SL, strfmt_Left);
            y_p += 30;
            for (int i = 0; i < list.Length; i++)
            {
                //Headers
                Rectangle strCT_STT = new Rectangle(5, y_p, 15, 22);
                data = (i + 1).ToString();
                e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, strCT_STT, strfmt_Left);

                data = list[i][1];
                int heightl = Int32.Parse(Math.Ceiling((double)data.Length / 17).ToString()) * 18 + 5;
                Rectangle strCT_SP = new Rectangle(20, y_p, 121, heightl);
                e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, strCT_SP, strfmt_Left);

                Rectangle strCT_SL = new Rectangle(191, y_p, 15, 22);

                data = list[i][2];
                e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, strCT_SL, strfmt_Left);


                data = list[i][3];
                int height = Int32.Parse(Math.Ceiling((double)data.Length / 17).ToString()) * 18 + 4;
                Rectangle notes = new Rectangle(5, y_p + heightl, 201, height);
                e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, notes, strfmt_Left);

                Rectangle RecLineCT = new Rectangle(5, y_p + heightl + height, 201, 22);
                data = "-----------------------------------------------------------------------";
                e.Graphics.DrawString(data, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, RecLineCT, strfmt_Left);


                y_p = y_p + height + heightl + 20;
            }
        }
        #endregion
        private void CreateOrderid(out string _sOrderId)
        {
            DataTable dt = orderBLL.GetLastOrderId();
            if (dt.Rows.Count > 0)
            {
                _sOrderId = dt.Rows[0][0].ToString();
                Int64 iOrderId = Int64.Parse(_sOrderId) + 1;
                _sOrderId = iOrderId.ToString();
            }
            else _sOrderId = "10" + DateTime.Today.ToString("yyyyMMdd") + "00001";
        }

        public void ClearDataGridView()
        {
            DataGridView1.Rows.Clear();
            DataGridView1.Refresh();
            TotalMoney = 0;
            lbtotal.Text = "";
            _TongtienAmount = 0;
            _TotalTax = 0;
            Discount = 0;
            _TotalAmountBeforeTax = 0;
            lbtotal.Text = "0";
            txtDiscount.Text = "0";
            //lbDeskName.Text = "";
            _iDeskId = 0;
           // lbCustomerName.Text = Common.clsLanguages.GetResource("UnSelectCustomer");
           // _sDeskName = lbDeskName.Text = Common.clsLanguages.GetResource("UnSelectDesk");
        }

        /// <summary>
        /// show data from tam tinh
        /// </summary>
        private void ShowData()
        {
            // gan vao cac control (so ban, total, discount...) tu dt  obj.order
            List<OrderDetails> lst = new List<OrderDetails>();
            foreach (OrderObject obj in Program.lstTemp)
            {
                if (obj.order.OrderId == _sOrderTemp)
                {
                    lbtotal.Text = double.Parse(obj.order.TotalMoney.ToString()).ToString("0,0");
                    TotalMoney = double.Parse(obj.order.TotalMoney.ToString());

                    if (double.Parse(obj.order.DisCountAmount.ToString()) > 0)
                    {
                        txtDiscount.Text = double.Parse(obj.order.DisCountAmount.ToString()).ToString("0,0");
                    }
                    else txtDiscount.Text = "0";

                    Discount = double.Parse(obj.order.DisCountAmount.ToString());

                    //_sDeskName = lbDeskName.Text = obj.order.DeskName;
                    _iDeskId = int.Parse(obj.order.DeskId.ToString());
                    //txtDiscount.Text = obj.order.DisCountAmount;
                    lst = obj.ListOrederDetail;
                }
            }
            // gan vao Grid tu list tu obj.ListOrederDetail
            dtOrder = Utility.ConvertListToDataTable<OrderDetails>(lst);
            ////////////// Show ra
            int i = 0;
            foreach (DataRow r in dtOrder.Rows)
            {
                DataGridView1.Rows.Add();
                DataGridView1.Rows[i].Cells["OrderId"].Value = _sOrderTemp;
                DataGridView1.Rows[i].Cells["stt"].Value = i + 1;
                DataGridView1.Rows[i].Cells["ProductId"].Value = r["ProductId"];
                DataGridView1.Rows[i].Cells["ProductName"].Value = r["ProductName"];
                DataGridView1.Rows[i].Cells["Qty"].Value = double.Parse(r["Qty"].ToString()).ToString("0,0");
                DataGridView1.Rows[i].Cells["Price"].Value = double.Parse(r["Price"].ToString()).ToString("0,0");
                DataGridView1.Rows[i].Cells["VAT"].Value = double.Parse(r["TaxAmmount"].ToString()).ToString("0,0");
                DataGridView1.Rows[i].Cells["AmountBeforeTax1"].Value = double.Parse(r["AmmountBeforeTax"].ToString()).ToString("0,0");
                DataGridView1.Rows[i].Cells["TotalAmount"].Value = double.Parse(r["TotalAmount"].ToString()).ToString("0,0");
                DataGridView1.Rows[i].Cells["ColNotes"].Value = r["Note"].ToString();
                DataGridView1.Rows[i].Cells["colIsBuffet"].Value = r["IsBuffet"].ToString();
                DataGridViewRow row = DataGridView1.Rows[i];
                row.Height = 40;
                i++;
            }
            IsTemp = false;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (DataGridView1.Rows.Count <= 0) return;

                if (DataGridView1.CurrentCell.OwningColumn.Name == "colNotes")
                {
                    //Reset ReadOnly columns
                    DataGridView1.Columns["colNotes"].ReadOnly = true;

                    DataGridView1.Rows[e.RowIndex].Cells["colNotes"].ReadOnly = false;
                    DataGridViewCell cell = DataGridView1.Rows[e.RowIndex].Cells["colNotes"];
                    DataGridView1.CurrentCell = cell;
                    DataGridView1.BeginEdit(true); 
                }

                //giảm số lượng  
                if (DataGridView1.CurrentCell.OwningColumn.Name == "colSub")
                {
                    int sl_cu = int.Parse(DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value.ToString());

                    if (sl_cu > 1)
                    {
                        string ProductId = DataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
                        double _price = double.Parse(DataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString());
                        int i = 0;
                        for (i = 0; i < DataGridView1.Rows.Count; i++)
                        {
                            if (DataGridView1.Rows[i].Cells["ProductId"].Value.ToString() == ProductId)
                            {
                                // cập nhật vào hàng này
                                // double sl_moi = double.Parse(txtSL.Text);
                                double sl = sl_cu - 1;

                                //tt = sl * (DGNhap) * (1 + thuesuat);
                                double TongtienAmount = sl * _price;
                                double TotalTax = 0 * (sl * _price);
                                double TotalAmountBeforeTax = TongtienAmount + TotalTax;


                                //dataGridView1.Rows[j].Cells[2].Value = String.Format("{0:0,0,0,0}", dr["DG"]);
                                DataGridView1.Rows[i].Cells["Qty"].Value = sl.ToString("0,0");
                                DataGridView1.Rows[i].Cells["Price"].Value = _price.ToString("0,0");
                                DataGridView1.Rows[i].Cells["VAT"].Value = 0;
                                DataGridView1.Rows[i].Cells["AmountBeforeTax1"].Value = TotalAmountBeforeTax.ToString("0,0");
                                DataGridView1.Rows[i].Cells["TotalAmount"].Value = TongtienAmount.ToString("0,0");
                                //dataGridView1.Rows[i].Cells[8].Value = "Xóa";
                                break;
                            }
                        }
                        //if (_sOrderTemp != "") {
                        //    if (Program.lstTemp.Count > 0)
                        //    {
                        //        for (int j = 0; j < Program.lstTemp.Count; j++)
                        //        {
                        //            foreach (OrderDetails odt in Program.lstTemp[j].ListOrederDetail)
                        //            {
                        //                if(odt.ProductId == ProductId)
                        //                odt.Qty = (sl_cu - 1).ToString();
                        //            }
                        //        }
                        //    }
                        //}
                        //
                        DanhLaiSTTGrid1();
                    }
                }

                //delete dataviewrow
                if (DataGridView1.CurrentCell.OwningColumn.Name == "colDelete")
                {
                    string id = DataGridView1.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                    string productId = DataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
                    if (id == "")
                    {
                        DataGridView1.Rows.RemoveAt(e.RowIndex);
                        DanhLaiSTTGrid1();
                    }
                    else
                    {

                        DataGridView1.Rows.RemoveAt(e.RowIndex);
                        DanhLaiSTTGrid1();
                        //Remove Order Detail
                    /*    foreach (OrderObject obj in Program.lstTemp)
                        {
                            if (obj.order.OrderId == id)
                            {
                                
                                int k = 0;
                                foreach (OrderDetails odt in obj.ListOrederDetail)
                                {
                                    if (odt.OrderId == id)
                                    {
                                        obj.ListOrederDetail.RemoveAt(k);
                                        DataGridView1.Rows.RemoveAt(e.RowIndex);
                                        DanhLaiSTTGrid1();
                                        obj.order.TotalMoney = TotalMoney.ToString();
                                        goto DeleteOrder;
                                    }
                                    k++;
                                }
                            }
                        }
                    //foreach (OrderDetails obj in Program.lstOrderDetail)
                    //{
                    //    if (obj.OrderId == id && obj.ProductId == productId)
                    //    {
                    //        Program.lstOrderDetail.RemoveAt(j);
                    //        DanhLaiSTTGrid1();
                    //        goto DeleteOrder;
                    //    }
                    //    j++;
                    //}

                        DeleteOrder:
                        //if dataridview total record = 0, then remove Order
                        if (DataGridView1.RowCount == 0)
                        {
                            int i = 0;
                            foreach (OrderObject obj in Program.lstTemp)
                            {
                                if (obj.order.OrderId == id)
                                {
                                    break;
                                }
                                i++;
                            }
                            Program.lstTemp.RemoveAt(i);
                            _sOrderTemp = "";
                        }


                        DanhLaiSTTGrid1();*/
                    }
                }
            
        }

        private bool CheckDataGridView() {
            bool res = true;
            if (DataGridView1.RowCount == 0)                
                res = false;
            return res;
        }

        private void ShowWarning() {
            //Vui long chon san pham truoc
            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseSelectProduct"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        }

        private void ckbIsPrint_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbIsPrint.Checked) IsPrint = true;
            else IsPrint = false;
        }

        #region Button Events

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntFrmMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm f = new MainForm();
            f.Visible = true;
        }

        private void bntFinish_Click(object sender, EventArgs e)
        {
            if (!CheckDataGridView())
            {
                ShowWarning();
                return;
            }
            if (_iDeskId == 0 && Program.IsRestaurant == 1) {
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
                //List<OrderObject> lstoro = new List<OrderObject>();
                //OrderObject oro = new OrderObject();
                //List<OrderDetails> lstOrderDetail = new List<OrderDetails>();
                //foreach (OrderObject objo in Program.lstTemp)
                //{


                //    Orders master = new Orders();
                //    master.OrderId = j.ToString();
                //    master.DeskId = objo.order.DeskId;
                //    master.CreatedBy = objo.order.CreatedBy;
                //    master.CreateDate = objo.order.CreateDate;
                //    master.Status = objo.order.Status;
                //    master.TotalAmmount = objo.order.TotalAmmount;
                //    master.TotalAmountBeforeTax = objo.order.TotalAmountBeforeTax;
                //    master.TotalTax = objo.order.TotalTax;
                //    master.TotalMoney = objo.order.TotalMoney;


                //    foreach (OrderDetails objdt in objo.ListOrederDetail)
                //    {
                //        OrderDetails odd = new OrderDetails();
                //        odd.OrderId = j.ToString();
                //        odd.ProductId = objdt.ProductId;
                //        odd.ProductName = objdt.ProductName;
                //        odd.Qty = objdt.Qty;
                //        odd.Price = objdt.Price;
                //        odd.CreateBy = objdt.CreateBy;
                //        odd.CreateDate = objdt.CreateDate;
                //        odd.Status = objdt.Status;
                //        odd.AmmountBeforeTax = objdt.AmmountBeforeTax;
                //        odd.TaxAmmount = objdt.TaxAmmount;
                //        odd.TotalAmount = objdt.TotalAmount;

                //        lstOrderDetail.Add(odd);
                //    }
                //    j++;
                //    oro.order = master;
                //    oro.ListOrederDetail = lstOrderDetail;
                //    /////////////
                //    lstoro.Add(oro);
                //}
                //Program.lstTemp.Clear();
                //Program.lstTemp = lstoro;

            }
            _sOrderTemp = "";
            //Reset_Amount();
        }

        private void bntShowTamTinh_Click(object sender, EventArgs e)
        {
            //if (Program.lstTemp.Count != 0)
            //{
            //    frmShowOrderTemp f = new frmShowOrderTemp();
            //    if (f.ShowDialog() == DialogResult.OK)
            //    {
            //        IsTemp = true;
            //        _sOrderTemp = f.Id;
            //        ClearDataGridView();
            //        ShowData();

            //    }
            //}
            //else
            //{
            //    //khong co order nao dang tam tinh
            //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ThereIsNoOrderInTempList"),
            //                    Common.clsLanguages.GetResource("Information"),
            //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
            //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            //}
            if (frmOrderList == null || !Form.ActiveForm.Contains(frmOrderList))
            {
                this.Visible = true;
                frmOrderList = new Screen.POS.frmOrderList();
                frmOrderList.ShowDialog();

            }
        }

        private void bntTamtinh_Click(object sender, EventArgs e)
        {
            if (!CheckDataGridView())
            {
                ShowWarning();
                return;
            }

            NoteOrderForm fNote = new NoteOrderForm();
            if (fNote.ShowDialog() == DialogResult.OK)
            {
                _sCustomInfor = fNote.CustomInfor;
                //if (_sOrderTemp != "")//has save temp
                //{

                //    int k = 0;
                //    foreach (OrderObject obj in Program.lstTemp)
                //    {
                //        if (obj.order.OrderId == _sOrderTemp)
                //        {
                //            obj.order.DeskId = _iDeskId.ToString();
                //            obj.order.DeskName = _sDeskName;
                //            obj.order.CreatedBy = Program.Username;
                //            obj.order.CreateDate = DateTime.Now.ToString();
                //            obj.order.Status = "0";
                //            obj.order.TotalAmmount = _TongtienAmount.ToString();
                //            obj.order.TotalAmountBeforeTax = _TotalAmountBeforeTax.ToString();//
                //            obj.order.TotalTax = _TotalTax.ToString();
                //            obj.order.DisCountAmount = txtDiscount.Text.Trim();
                //            obj.order.TotalMoney = TotalMoney.ToString();


                //            for (int i = obj.ListOrederDetail.Count - 1; i >= 0; i--)
                //            {
                //                if (obj.ListOrederDetail[i].OrderId == _sOrderTemp)
                //                    obj.ListOrederDetail.RemoveAt(i);
                //            }
                //            double _dMoney = 0;
                //            foreach (DataGridViewRow r in DataGridView1.Rows)
                //            {
                //                OrderDetails odd = new OrderDetails();
                //                odd.OrderId = _sOrderTemp;
                //                odd.ProductId = r.Cells["ProductId"].Value.ToString();
                //                odd.ProductName = r.Cells["ProductName"].Value.ToString();
                //                odd.Qty = r.Cells["Qty"].Value.ToString();
                //                odd.Price = r.Cells["Price"].Value.ToString();
                //                odd.CreateBy = Program.Username;
                //                odd.CreateDate = DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss");
                //                odd.Status = "0";
                //                odd.AmmountBeforeTax = r.Cells["AmountBeforeTax1"].Value.ToString();
                //                odd.TaxAmmount = r.Cells["VAT"].Value.ToString();
                //                odd.TotalAmount = r.Cells["TotalAmount"].Value.ToString();
                //                odd.Note = r.Cells["colNotes"].Value.ToString();
                //                odd.IsBuffet = r.Cells["colIsBuffet"].Value.ToString();
                //                //lstOrderDetail.Add(odd);
                //                obj.ListOrederDetail.Add(odd);

                //                _dMoney += double.Parse(r.Cells["TotalAmount"].Value.ToString());
                //            }
                //            //obj.order.TotalMoney = _dMoney.ToString();
                //        }
                //        //obj.ListOrederDetail = lstOrderDetail;
                //        /////////////


                //        k++;
                //    }
                //}
                //else
                //{
                //    if (_iDeskId == 0 && Program.IsRestaurant == 1)
                //    {
                //        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PlsSelectTable"),
                //                        Common.clsLanguages.GetResource("Information"),
                //                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //        return;
                //    }

                //    int stt = 1;
                //    if (Program.lstTemp != null)
                //    {
                //        stt = Program.lstTemp.Count + 1;
                //    }

                //    OrderObject oro = new OrderObject();

                //    Orders master = new Orders();
                //    master.OrderId = stt.ToString();
                //    master.DeskId = _iDeskId.ToString();
                //    master.DeskName = _sDeskName;
                //    master.CreatedBy = Program.Username;
                //    master.CreateDate = DateTime.Now.ToString();
                //    master.Status = "0";
                //    master.TotalAmmount = _TongtienAmount.ToString();
                //    master.TotalAmountBeforeTax = _TotalAmountBeforeTax.ToString();
                //    master.TotalTax = _TotalTax.ToString();
                //    master.DisCountAmount = Discount.ToString();
                //    master.TotalMoney = TotalMoney.ToString();

                //    List<OrderDetails> lstOrderDetail = new List<OrderDetails>();
                //    int i = 0;
                //    foreach (DataGridViewRow r in DataGridView1.Rows)
                //    {
                //        OrderDetails odd = new OrderDetails();
                //        odd.OrderId = stt.ToString();
                //        odd.ProductId = r.Cells["ProductId"].Value.ToString();
                //        odd.ProductName = r.Cells["ProductName"].Value.ToString();
                //        odd.Qty = r.Cells["Qty"].Value.ToString();
                //        odd.Price = r.Cells["Price"].Value.ToString();
                //        odd.CreateBy = Program.Username;
                //        odd.CreateDate = DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss");
                //        odd.Status = "0";
                //        odd.AmmountBeforeTax = r.Cells["AmountBeforeTax1"].Value.ToString();
                //        odd.TaxAmmount = r.Cells["VAT"].Value.ToString();
                //        odd.TotalAmount = r.Cells["TotalAmount"].Value.ToString();
                //        odd.IsBuffet = r.Cells["colIsBuffet"].Value.ToString();

                //        lstOrderDetail.Add(odd);
                //        i++;
                //    }

                //    oro.order = master;
                //    oro.ListOrederDetail = lstOrderDetail;
                //    /////////////
                //    Program.lstTemp.Add(oro);
                //}
                //clear DataGridView1

                //ClearDataGridView();

                //DoPrinting();
                //Reset_Amount();


                InsertOrder();
				if (orderBLL.Res)
				{
					string isPrint = ConfigurationManager.AppSettings["IsPrint"];
					if (isPrint == "1")
					{
						DoPrinting();
					}
				}
				//print order 
			}
        }



        private void bntDesk_Click(object sender, EventArgs e)
        {
            frmDesk f = new frmDesk();
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                if (f.DeskNo != "")
                {
                    _iDeskId = f.DeskId;
                    //_sDeskName = lbDeskName.Text = f.DeskNo;
                }
            }
        }

        private void btnGoPrePro_Click(object sender, EventArgs e)
        {
            GoPre();
        }

        private void btnGoNextPro_Click(object sender, EventArgs e)
        {
            GoNext();
        }

        private void btnGoPreMenu_Click(object sender, EventArgs e)
        {
            GoPreMenu();
        }

        private void btnGoNextMenu_Click(object sender, EventArgs e)
        {
            GoNextMenu();
        }

        private void btnFrmPay_Click(object sender, EventArgs e)
        {
            if (!CheckDataGridView())
            {
                ShowWarning();
                return;
            }

            SaveTempOrder();

            if (payForm == null || !Form.ActiveForm.Contains(payForm))
            {
                //CloseForm();
                //this.Visible = false;
                payForm = new Screen.POS.PayForm(this);
                payForm.ShowDialog();
                //AddFormToMainPanel(frmServices);

            }
        }

        private void SaveTempOrder()
        {
                OrderObject oro = new OrderObject();

                Orders master = new Orders();
                master.OrderId = stt.ToString();
                master.DeskId = _iDeskId.ToString();
                master.DeskName = _sDeskName;
                master.CreatedBy = Program.Username;
                master.CreateDate = DateTime.Now.ToString();
                master.Status = "0";
                master.TotalAmmount = _TongtienAmount.ToString();
                master.TotalAmountBeforeTax = _TotalAmountBeforeTax.ToString();
                master.TotalTax = _TotalTax.ToString();
                master.DisCountAmount = Discount.ToString();
                master.TotalMoney = TotalMoney.ToString();

                List<OrderDetails> lstOrderDetail = new List<OrderDetails>();
                int i = 0;
                foreach (DataGridViewRow r in DataGridView1.Rows)
                {
                    OrderDetails odd = new OrderDetails();
                    odd.OrderId = stt.ToString();
                    odd.ProductId = r.Cells["ProductId"].Value.ToString();
                    odd.ProductName = r.Cells["ProductName"].Value.ToString();
                    odd.Qty = r.Cells["Qty"].Value.ToString();
                    odd.Price = r.Cells["Price"].Value.ToString();
                    odd.CreateBy = Program.Username;
                    odd.CreateDate = DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss");
                    odd.Status = "0";
                    odd.AmmountBeforeTax = r.Cells["AmountBeforeTax1"].Value.ToString();
                    odd.TaxAmmount = r.Cells["VAT"].Value.ToString();
                    odd.TotalAmount = r.Cells["TotalAmount"].Value.ToString();
                    odd.IsBuffet = r.Cells["colIsBuffet"].Value.ToString();

                    lstOrderDetail.Add(odd);
                    i++;
                }

                oro.order = master;
                oro.ListOrederDetail = lstOrderDetail;
            /////////////
            Program.lstTempOrder = oro;
        }

        #region Button show product
        private void bntAll_Click(object sender, EventArgs e)
        {
            _iLx = 8;
            pLstsub.Controls.Clear();
            //IsBuffet = false;
            IsNode = false;
            LoadMenu(null, 1, IsNode);
            this.bntAll.BackgroundImage = global::VVPosS.Properties.Resources.ds_all_button;
            foreach (Control c in pLstsub.Controls) {
                Button btn = c as Button;
                if (btn != null) btn.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
            }

            LoadProducts(1, "");
            //this.bntThucAn.BackgroundImage = this.bntNuocUong.BackgroundImage = this.bntKhac.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;
           
        }

        //private void bntThucAn_Click(object sender, EventArgs e)
        //{
        //    LoadProducts(1, "00");
        //    this.bntThucAn.BackgroundImage = global::VVPosS.Properties.Resources.ds_all_button;
        //    this.bntAll.BackgroundImage = this.bntNuocUong.BackgroundImage = this.bntKhac.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;
        //}

        //private void bntNuocUong_Click(object sender, EventArgs e)
        //{
        //    LoadProducts(1, "01");
        //    this.bntNuocUong.BackgroundImage = global::VVPosS.Properties.Resources.ds_all_button;
        //    this.bntAll.BackgroundImage = this.bntThucAn.BackgroundImage = this.bntKhac.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;
        //}

        //private void bntKhac_Click(object sender, EventArgs e)
        //{
        //    LoadProducts(1, "02");
        //    this.bntKhac.BackgroundImage = global::VVPosS.Properties.Resources.ds_all_button;
        //    this.bntAll.BackgroundImage = this.bntThucAn.BackgroundImage = this.bntNuocUong.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;
        //}
        #endregion

        #endregion

        #region TextBox Events
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (IsTemp) return;
            if (txtDiscount.TextLength < 20)// && sender.Equals(this.txtDiscount)==true)
            {
                if (txtDiscount.Text != "")
                {
                    //if (Convert.ToDouble(txtDiscount.Text.Trim()) <= _TotalAmountBeforeTax)
                    if (Convert.ToDouble(txtDiscount.Text.Trim()) <= TotalMoney)
                    {
                        Discount = double.Parse(txtDiscount.Text);
                        txtDiscount.Text = Discount.ToString("###,###,##0");
                        txtDiscount.SelectionStart = txtDiscount.Text.Length;
                        DanhLaiSTTGrid1();
                    }
                    else
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DiscountInputError"),
                                    Common.clsLanguages.GetResource("Error"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        //Discount = 0;
                        txtDiscount.Text = txtDiscount.Text.Substring(0, txtDiscount.Text.Length - 1);
                        txtDiscount.SelectionStart = txtDiscount.Text.Length;
                        Discount = double.Parse(txtDiscount.Text);
                        DanhLaiSTTGrid1();
                        return;
                    }
                }
                else
                {
                    Discount = 0;
                    //txtDiscount.Text = "0";
                    //DanhLaiSTTGrid1();
                }
            }
            else
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DiscountTextLenghtError"),
                                    Common.clsLanguages.GetResource("Error"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtDiscount.Text = txtDiscount.Text.Substring(0, txtDiscount.Text.Length - 1);
                txtDiscount.SelectionStart = txtDiscount.Text.Length;
                return;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.MaskDigit(e);
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            Utility.MaskDigit_keyDown(e);
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
        #endregion 

        #region Menu, lấy từ store Aeon qua.
        //private void EnablePaginationNext(bool blag)
        //{
        //    this.btnNext.Enabled = blag;
        //    if (blag)
        //    {
        //        this.btnNext.BackColor = Color.OrangeRed;
        //    }
        //    else
        //    {
        //        this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
        //    }
        //}

        //private void EnablePaginationPre(bool blag)
        //{
        //    this.btnPre.Enabled = blag;
        //    if (blag)
        //    {
        //        this.btnPre.BackColor = Color.OrangeRed;
        //    }
        //    else
        //    {
        //        this.btnPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
        //    }
        //}

        //private void AddMenus(DataTable dt)
        //{
        //    if (dt != null && dt.Rows.Count != 0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            Button btn = new Button();
        //            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        //            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
        //            btn.Image = global::VVPosS.Properties.Resources._1404391200_food;
        //            btn.Name = "btnItem" + dt.Rows[i]["CommonId"].ToString();
        //            btn.Text = dt.Rows[i]["StrValue1"].ToString();
        //            btn.Size = new System.Drawing.Size(118, 72);
        //            btn.TabIndex = 2;
        //            btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        //            btn.UseVisualStyleBackColor = false;
        //            btn.Click += new System.EventHandler(this.btn_Click);
        //            if (i == 0)
        //            {
        //                btn.Location = new System.Drawing.Point(6, 12);
        //            }
        //            else if (i == 1)
        //            {
        //                btn.Location = new System.Drawing.Point(130, 12);
        //            }
        //            else if (i == 2)
        //            {
        //                btn.Location = new System.Drawing.Point(254, 12);
        //            }
        //            else if (i == 3)
        //            {
        //                btn.Location = new System.Drawing.Point(378, 12);
        //            }
        //            this.gbMenu.Controls.Add(btn);
        //        }
        //    }
        //}

        //private void btn_Click(object sender, EventArgs e)
        //{
        //    preCurPage = curPage;
        //    preProtoType = protoType;
        //    level = level + 1;
        //    string name = ((Button)sender).Name;
        //    productType = name.Substring(7);
        //    protoType = productType.Substring(3);
        //    GetMenus("ProductType", 1);
        //    LoadProducts(1, "");
        //}

        //private void GetMenus(string commonType, int page)
        //{
        //    curPage = page;
        //    int total = 0;
        //    double preTotal = totalPage;
        //    DataTable dt = commonCodeBLL.GetMenus(commonType, page, out total, level.ToString() + protoType);
        //    double RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxMenu"]);
        //    int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxMenu"]);
        //    double tem = (total / RecordPerPage);
        //    totalPage = Math.Ceiling(tem);
        //    if (dt.Rows.Count != 0)
        //    {
        //        this.gbMenu.Controls.Clear();
        //        AddMenus(dt);
        //        if (totalPage == 1)
        //        {
        //            EnablePaginationNext(false);
        //            EnablePaginationPre(false);
        //        }
        //        else
        //        {
        //            if (curPage == 1)
        //            {
        //                EnablePaginationNext(true);
        //                EnablePaginationPre(false);
        //            }
        //            else if (curPage > 1 && curPage < Int32.Parse(totalPage.ToString()))
        //            {
        //                EnablePaginationNext(true);
        //                EnablePaginationPre(true);
        //            }
        //            else if (curPage > 1 && curPage == Int32.Parse(totalPage.ToString()))
        //            {
        //                EnablePaginationNext(false);
        //                EnablePaginationPre(true);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        level = level - 1;
        //        if (Int32.Parse(protoType) > 0 && Int32.Parse(protoType) < 10)
        //        {
        //            protoType = "0" + (Int32.Parse(protoType) - 1).ToString();
        //        }
        //        else if (Int32.Parse(protoType) >= 10)
        //        {
        //            protoType = (Int32.Parse(protoType) - 1).ToString();
        //        }
        //        totalPage = preTotal;
        //        protoType = preProtoType;
        //        curPage = preCurPage;
        //    }
        //}
        #endregion

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

    }
}
