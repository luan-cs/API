using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosM1.BusinessLayer;
using VVPosM1.Entities;
using VVPosM1.Common;
using System.Configuration;



namespace VVPosM1.Screen

{
    public partial class frmManageReceip : Form
    {
        // bien  toan cuc trong form nay
        private Receipts receipt;
        private Receipts receSea;
        private ReceiptDetails receDeSea;
        private ReceiptsBLL receBLL;


        private int CurPage;
        private double totalPage;
        public frmManageReceip()
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
            //lblTitle.Text = Common.clsLanguages.GetResource("TitleReceipt");
            lblFromDate.Text = Common.clsLanguages.GetResource("FromDate");
            lblToDate.Text = Common.clsLanguages.GetResource("ToDate");

            btnSearch.Text = Common.clsLanguages.GetResource("Search");
            btnReset.Text = Common.clsLanguages.GetResource("Reset");
            btnExit.Text = Common.clsLanguages.GetResource("Exit");
            // datagridview
            gbSearch.Text = Common.clsLanguages.GetResource("List");
            gbInfo.Text = Common.clsLanguages.GetResource("Detail");

            this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            this.RceiptCode.HeaderText = Common.clsLanguages.GetResource("ReceiptId1");
            this.TotalBeforeTax.HeaderText = Common.clsLanguages.GetResource("TotalAmountBeforeTax");
            this.Tax.HeaderText = Common.clsLanguages.GetResource("TotalTaxAmount");
            this.TotalAmount.HeaderText = Common.clsLanguages.GetResource("TotalAmount");
            this.TotalSale.HeaderText = Common.clsLanguages.GetResource("TotalSale1");
            this.TotalFinal.HeaderText = Common.clsLanguages.GetResource("TotalFinal1");
            this.Creator.HeaderText = Common.clsLanguages.GetResource("CreateBy");
            this.CreatedDate.HeaderText = Common.clsLanguages.GetResource("CreateDate");
            this.Print.HeaderText = Common.clsLanguages.GetResource("PrintReceipt1");

            this.STT1.HeaderText = Common.clsLanguages.GetResource("No");
            this.ReceiptId1.HeaderText = Common.clsLanguages.GetResource("ReceiptId1");
            this.InfoProduct1.HeaderText = Common.clsLanguages.GetResource("InformationOfProduct");
            this.Quantity1.HeaderText = Common.clsLanguages.GetResource("Quantity");
            this.ProductPrice1.HeaderText = Common.clsLanguages.GetResource("ProductPrice");
            this.TotalBeforTax1.HeaderText = Common.clsLanguages.GetResource("TotalAmountBeforeTax");
            this.TotalTax.HeaderText = Common.clsLanguages.GetResource("TotalTaxAmount");
            this.TotalAmount1.HeaderText = Common.clsLanguages.GetResource("TotalAmount1");

            this.STT2.HeaderText = Common.clsLanguages.GetResource("No");
            this.Receipt2.HeaderText = Common.clsLanguages.GetResource("ReceiptId1");
            this.InfoCard2.HeaderText = Common.clsLanguages.GetResource("InfoCard1");

        }


        private void frmManageReceip_Load(object sender, EventArgs e)
        {

            // khởi tạo các đối tượng 
            receBLL = new ReceiptsBLL();

            Load_Loc();
        }
        private void Load_Loc()
        {
            //load cboLoc 1243
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("0", VVPosM1.Common.clsLanguages.GetResource("Loc_0"));
            test.Add("1", VVPosM1.Common.clsLanguages.GetResource("Loc_1"));
            test.Add("2", VVPosM1.Common.clsLanguages.GetResource("Loc_2"));
            test.Add("3", VVPosM1.Common.clsLanguages.GetResource("Loc_4"));
            test.Add("4", VVPosM1.Common.clsLanguages.GetResource("Loc_3"));

            cboLoc.DataSource = new BindingSource(test, null);
            cboLoc.DisplayMember = "Value";
            cboLoc.ValueMember = "Key";
        }



        private void dgv_CellClickReceipt(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
               string id = dgvRecept.Rows[e.RowIndex].Cells[1].Value.ToString();
                receBLL = new ReceiptsBLL();
                // load thông tin chi tiết hóa đơn
                DataTable dt = receBLL.searchReceiptsDetails(id);
                dgvReceipDetail.Rows.Clear();
                if (dt != null && dt.Rows.Count > 0)
                {
                    int i = 0;
                    int stt = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvReceipDetail.Rows.Add();
                        dgvReceipDetail.Rows[i].Cells[0].Value = (stt + 1).ToString();
                        dgvReceipDetail.Rows[i].Cells[1].Value = dr["ReceiptId"].ToString();
                        // thông tin sản phẩm
                        string str = "";
                        str = str + Common.clsLanguages.GetResource("ProductId") + ": " + dr["ProductId"].ToString() + "\n";
                        str = str + Common.clsLanguages.GetResource("ProductName1") + ": " + dr["Name"].ToString() + "\n";
                        str = str + Common.clsLanguages.GetResource("PromotionID") + ": " + dr["PromotionId"].ToString() + "\n";
                        dgvReceipDetail.Rows[i].Cells[2].Value = str;
                        dgvReceipDetail.Rows[i].Cells[3].Value = dr["Qty"].ToString();
                        dgvReceipDetail.Rows[i].Cells[4].Value = string.Format("{0:0,0}", dr["Price"]);
                        dgvReceipDetail.Rows[i].Cells[5].Value = string.Format("{0:0,0}", dr["TotalAmountBeforeTax"]);
                        dgvReceipDetail.Rows[i].Cells[6].Value = string.Format("{0:0,0}", dr["TaxAmount"]);
                        dgvReceipDetail.Rows[i].Cells[7].Value = string.Format("{0:0,0}", dr["TotalAmount"]);
                        i++;
                        stt++;
                    }
                    //if (e.ColumnIndex == 5)
                    //{
                    //    if (receBLL.PrintReceipt(id, "1") == 1)
                    //    {
                    //        MessageBox.Show("In thành công!");
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("In không thành công!");
                    //    }
                    //}
                }

                // load thông tin chi tiết khách hàng
                DataTable tbinfo = receBLL.searchReceiptInfo(id);
                lblThongTinKhachHang.Text = "";
                if (tbinfo != null && tbinfo.Rows.Count > 0)
                {
                    foreach (DataRow dr in tbinfo.Rows)
                    {
                        string info = "";
                        info = info + "-" + Common.clsLanguages.GetResource("CustomerNew") + " \n";
                        info = info + "-" + Common.clsLanguages.GetResource("CustomerName") + ":" + dr["CustomerName"] + "\n";
                        info = info + "-" + Common.clsLanguages.GetResource("Address") + ":" + dr["Address"] + "\n";
                        info = info + "-" + Common.clsLanguages.GetResource("Tel") + ":" + dr["Phone"] + "\n";
                        info = info + "-" + Common.clsLanguages.GetResource("Notes") + ":" + dr["Note"] + "\n";
                        lblThongTinKhachHang.Text = info;
                    }


                }


                // load thông tin khách hàng member

                DataTable tbmember = receBLL.searchReceiptMember(id);
                lblThongTinKhachHang.Text = "";
                if (tbmember != null && tbmember.Rows.Count > 0)
                {

                    foreach (DataRow dr in tbmember.Rows)
                    {
                        string info = "";
                        info = info + "-" + Common.clsLanguages.GetResource("CustomerMember") + " \n";
                        info = info + "-" + Common.clsLanguages.GetResource("MemberID") + ":" + dr["MemberId"] + "\n";
                        info = info + "-" + Common.clsLanguages.GetResource("CreateDate") + ":" + dr["CreatedDate"] + "\n";
                        info = info + "-" + Common.clsLanguages.GetResource("CreateBy") + ":" + dr["CreatedBy"] + "\n";
                        lblThongTinKhachHang.Text = info;
                    }


                }

                // Load thông tin thẻ

                  DataTable dt1 = receBLL.searchReceiptsCard(id);
                  dvgCard.Rows.Clear();
                if (dt1 != null && dt1.Rows.Count > 0)
                {
                    int i = 0;
                    
                    foreach (DataRow dr in dt1.Rows)
                    {
                        dvgCard.Rows.Add();
                        dvgCard.Rows[i].Cells[0].Value = (i + 1).ToString();
                        dvgCard.Rows[i].Cells[1].Value = dr["ReceiptId"].ToString();
                        // thông tin thẻ
                        string str = "";
                        str = str + "-"+Common.clsLanguages.GetResource("Loc_3")+": " + dr["CardNo"].ToString() + "\n";
                        str = str + "- Tên chủ thẻ: " + dr["CardHolderName"].ToString() + "\n";
                        str = str + "- Ngân hàng: " + dr["Bank"].ToString() + "\n";
                        str = str + "-"+Common.clsLanguages.GetResource("DeadlineDate")+": "+ dr["ExpiredDate"].ToString() + "\n";
                        str = str + "- Loại thẻ: " + dr["CardType"].ToString() + "\n";
                        str = str + "-" +Common.clsLanguages.GetResource("TotalAmount")+": "+ dr["TotalAmount"].ToString() + "\n";                       
                        str = str + "- TerminalId: " + dr["TerminalId"].ToString() + "\n";
                        dvgCard.Rows[i].Cells[2].Value = str;

                        // thông tin khởi tạo
                        str = "";
                        str = str + "-" + Common.clsLanguages.GetResource("CreateBy") + ": " + dr["CreatedBy"].ToString() + "\n";
                        str = str + "-" + Common.clsLanguages.GetResource("CreateDate") + ": " + dr["CreatedDate"].ToString() + "\n";
                        dvgCard.Rows[i].Cells[3].Value = str;
                        i++;
                    }
                }
            }

                }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            CurPage = 1;
            totalPage = 1;
            SearchReceipts(1);
        }

        private void SearchReceipts(int page)
        {
            CurPage = page;
            receSea = new Receipts();
            // receipt = new Receipts(); 
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd");
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd");
            // lọc theo không chọn- chỉ ngày tháng
            if (cboLoc.SelectedIndex == 0)
            {
                int total = 0;
                DataTable dt = receBLL.SearchReceipts0(receSea, tuNgay, denNgay, page, out total);
                double RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                double tem = (total / RecordPerPage);
                totalPage = Math.Ceiling(tem);

                dgvRecept.Rows.Clear();
                dgvReceipDetail.Rows.Clear();
                dvgCard.Rows.Clear();
                lblThongTinKhachHang.Text = "";
                lblTB.Text = "...";
                if (dt != null && dt.Rows.Count > 0)
                {
                    int i = 0;
                    int stt = (page - 1) * RecPerPage;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvRecept.Rows.Add();
                        dgvRecept.Rows[i].Cells[0].Value = (stt + 1).ToString();
                        dgvRecept.Rows[i].Cells[1].Value = dr["ReceiptId"].ToString();
                        dgvRecept.Rows[i].Cells[2].Value = string.Format("{0:0,0}", dr["TotalAmountBeforeTax"]);
                        dgvRecept.Rows[i].Cells[3].Value = string.Format("{0:0,0}", dr["TotalTax"]);
                        dgvRecept.Rows[i].Cells[4].Value = string.Format("{0:0,0}", dr["TotalAmount"]);
                        dgvRecept.Rows[i].Cells[5].Value = string.Format("{0:0,0}", dr["DiscountAmount"]);
                        dgvRecept.Rows[i].Cells[6].Value = string.Format("{0:0,0}", dr["TotalMoney"]); 
                        dgvRecept.Rows[i].Cells[7].Value = dr["CreatedBy"].ToString();
                        dgvRecept.Rows[i].Cells[8].Value = dr["CreatedDate"].ToString();
                        i++;
                        stt++;
                    }
                }
                linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
                lblTB.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
            }

            // lọc theo mã hóa đơn
            if (cboLoc.SelectedIndex == 1)
            {
                receSea.ReceiptId = txtLoc.Text;
                int total = 0;
                DataTable dt = receBLL.SearchReceipts0(receSea, tuNgay, denNgay, page, out total);
                double RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                double tem = (total / RecordPerPage);
                totalPage = Math.Ceiling(tem);

                dgvRecept.Rows.Clear();
                dgvReceipDetail.Rows.Clear();
                dvgCard.Rows.Clear();
                lblThongTinKhachHang.Text = "";
                lblTB.Text = "...";
                if (dt != null && dt.Rows.Count > 0)
                {
                    int i = 0;
                    int stt = (page - 1) * RecPerPage;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvRecept.Rows.Add();
                        dgvRecept.Rows[i].Cells[0].Value = (stt + 1).ToString();
                        dgvRecept.Rows[i].Cells[1].Value = dr["ReceiptId"].ToString();
                        dgvRecept.Rows[i].Cells[2].Value = string.Format("{0:0,0}", dr["TotalAmountBeforeTax"]);
                        dgvRecept.Rows[i].Cells[3].Value = string.Format("{0:0,0}", dr["TotalTax"]);
                        dgvRecept.Rows[i].Cells[4].Value = string.Format("{0:0,0}", dr["TotalAmount"]);
                        dgvRecept.Rows[i].Cells[5].Value = string.Format("{0:0,0}", dr["DiscountAmount"]);
                        dgvRecept.Rows[i].Cells[6].Value = string.Format("{0:0,0}", dr["TotalMoney"]);
                        dgvRecept.Rows[i].Cells[7].Value = dr["CreatedBy"].ToString();
                        dgvRecept.Rows[i].Cells[8].Value = dr["CreatedDate"].ToString();

                        i++;
                        stt++;
                    }
                }
                linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
                lblTB.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
            }

            //tổng số tiền
            if (cboLoc.SelectedIndex == 2)
            {
            //    double d;
            
            //bool isNum = double.TryParse(txtLoc.Text, out d);
            //if (!isNum)
            //{
            //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ABCNumberA"),
            //                                 Common.clsLanguages.GetResource("Information"),
            //                                 Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
            //                                 Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            //    txtLoc.Focus();
            //}
            //else
            //{
               
                receSea.TotalAmount = txtLoc.Text;
                int total = 0;
                DataTable dt = receBLL.SearchReceipts0(receSea, tuNgay, denNgay, page, out total);
                double RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                double tem = (total / RecordPerPage);
                totalPage = Math.Ceiling(tem);

                dgvRecept.Rows.Clear();
                dgvReceipDetail.Rows.Clear();
                dvgCard.Rows.Clear();
                lblThongTinKhachHang.Text = "";
                lblTB.Text = "...";
                if (dt != null && dt.Rows.Count > 0)
                {
                    int i = 0;
                    int stt = (page - 1) * RecPerPage;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvRecept.Rows.Add();
                        dgvRecept.Rows[i].Cells[0].Value = (stt + 1).ToString();
                        dgvRecept.Rows[i].Cells[1].Value = dr["ReceiptId"].ToString();
                        dgvRecept.Rows[i].Cells[2].Value = string.Format("{0:0,0}", dr["TotalAmountBeforeTax"]);
                        dgvRecept.Rows[i].Cells[3].Value = string.Format("{0:0,0}", dr["TotalTax"]);
                        dgvRecept.Rows[i].Cells[4].Value = string.Format("{0:0,0}", dr["TotalAmount"]);
                        dgvRecept.Rows[i].Cells[5].Value = string.Format("{0:0,0}", dr["DiscountAmount"]);
                        dgvRecept.Rows[i].Cells[6].Value = string.Format("{0:0,0}", dr["TotalMoney"]);
                        dgvRecept.Rows[i].Cells[7].Value = dr["CreatedBy"].ToString();
                        dgvRecept.Rows[i].Cells[8].Value = dr["CreatedDate"].ToString();

                        i++;
                        stt++;
                    }
                }
                linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
                lblTB.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
            }
            //}

            // lọc theo mã thành viên
            if (cboLoc.SelectedIndex == 3)
            {

                string id = txtLoc.Text;

                //  DataTable tb1 = receBLL.GetReceiptIdInCard(id);              


                //if (tb1 != null && tb1.Rows.Count > 0)
                //{
                int total = 0;
                int i = 0;

                dgvRecept.Rows.Clear();
                dgvReceipDetail.Rows.Clear();
                dvgCard.Rows.Clear();
                lblThongTinKhachHang.Text = "";
                lblTB.Text = "...";

                DataTable dt = receBLL.SearchReceipts1(id, tuNgay, denNgay, page, out total);
                if (dt != null && dt.Rows.Count > 0)
                {
                    double RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                    int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                    double tem = (total / RecordPerPage);
                    totalPage = Math.Ceiling(tem);
                    int stt = (page - 1) * RecPerPage;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvRecept.Rows.Add();
                        dgvRecept.Rows[i].Cells[0].Value = (stt + 1).ToString();
                        dgvRecept.Rows[i].Cells[1].Value = dr["ReceiptId"].ToString();
                        dgvRecept.Rows[i].Cells[2].Value = string.Format("{0:0,0}", dr["TotalAmountBeforeTax"]);
                        dgvRecept.Rows[i].Cells[3].Value = string.Format("{0:0,0}", dr["TotalTax"]);
                        dgvRecept.Rows[i].Cells[4].Value = string.Format("{0:0,0}", dr["TotalAmount"]);
                        dgvRecept.Rows[i].Cells[5].Value = string.Format("{0:0,0}", dr["DiscountAmount"]);
                        dgvRecept.Rows[i].Cells[6].Value = string.Format("{0:0,0}", dr["TotalMoney"]);
                        dgvRecept.Rows[i].Cells[7].Value = dr["CreatedBy"].ToString();
                        dgvRecept.Rows[i].Cells[8].Value = dr["CreatedDate"].ToString();

                        i++;
                        stt++;
                    }
                }
                linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
                lblTB.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
                //  }

            }

            // lọc theo mã thẻ
            if (cboLoc.SelectedIndex == 4)
            {
                string id = txtLoc.Text;

                //  DataTable tb1 = receBLL.GetReceiptIdInCard(id);              


                //if (tb1 != null && tb1.Rows.Count > 0)
                //{
                int total = 0;
                int i = 0;

                dgvRecept.Rows.Clear();
                dgvReceipDetail.Rows.Clear();
                dvgCard.Rows.Clear();
                lblThongTinKhachHang.Text = "";
                lblTB.Text = "...";

                DataTable dt = receBLL.SearchReceipts2(id, tuNgay, denNgay, page, out total);
                if (dt != null && dt.Rows.Count > 0)
                {
                    double RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                    int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                    double tem = (total / RecordPerPage);
                    totalPage = Math.Ceiling(tem);
                    int stt = (page - 1) * RecPerPage;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvRecept.Rows.Add();
                        dgvRecept.Rows[i].Cells[0].Value = (stt + 1).ToString();
                        dgvRecept.Rows[i].Cells[1].Value = dr["ReceiptId"].ToString();
                        dgvRecept.Rows[i].Cells[2].Value = string.Format("{0:0,0}", dr["TotalAmountBeforeTax"]);
                        dgvRecept.Rows[i].Cells[3].Value = string.Format("{0:0,0}", dr["TotalTax"]);
                        dgvRecept.Rows[i].Cells[4].Value = string.Format("{0:0,0}", dr["TotalAmount"]);
                        dgvRecept.Rows[i].Cells[5].Value = string.Format("{0:0,0}", dr["DiscountAmount"]);
                        dgvRecept.Rows[i].Cells[6].Value = string.Format("{0:0,0}", dr["TotalMoney"]);
                        dgvRecept.Rows[i].Cells[7].Value = dr["CreatedBy"].ToString();
                        dgvRecept.Rows[i].Cells[8].Value = dr["CreatedDate"].ToString();

                        i++;
                        stt++;
                    }
                }
                linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
                lblTB.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
                //  }
            }
        }

        private void bntPre_Click(object sender, EventArgs e)
        {
            if (CurPage > 1)
            {
                SearchReceipts(CurPage - 1);
            }
        }

        private void bntNext_Click(object sender, EventArgs e)
        {
            if (CurPage < totalPage)
            {
                SearchReceipts(CurPage + 1);
            }
        }

       

     private void btnReset_Click(object sender, EventArgs e)
     {
         Reset();
     }

     private void Reset()
     {
         foreach (Control c in this.Controls)
         {
             if (c is TextBox)
             {
                 ((TextBox)c).Text = String.Empty;
             }
             if (c is RichTextBox)
             {
                 ((RichTextBox)c).Text = String.Empty;
             }
             if (c is ComboBox)
             {
                 ((ComboBox)c).SelectedIndex = 0;
             }
             if (c is CheckBox)
             {
                 ((CheckBox)c).Checked = false;
             }

             dgvRecept.Rows.Clear();
             dgvReceipDetail.Rows.Clear();
             dvgCard.Rows.Clear();
             txtLoc.Text = "";
             cboLoc.SelectedIndex = 0;
             lblTB.Text = "...";
             lblThongTinKhachHang.Text = "...";

         }
     }

     private void btnThoat_Click(object sender, EventArgs e)
     {
         this.Close();
     }

     private void groupBox4_Enter(object sender, EventArgs e)
     {

     }

     private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
     {
         if (cboLoc.SelectedIndex == 0)
         {
             txtLoc.ReadOnly = true;
         }
         else
         {
             txtLoc.ReadOnly = false;
         }
     }

     private void txtLoc_TextChanged(object sender, EventArgs e)
     {
         if (cboLoc.SelectedIndex == 2) {
             if (txtLoc.Text != "")
             {
                 double _dblprice = double.Parse(txtLoc.Text);
                 txtLoc.Text = _dblprice.ToString("###,###,##0");
                 txtLoc.SelectionStart = txtLoc.Text.Length;
             }
         }
     }

     private void txtLoc_KeyPress(object sender, KeyPressEventArgs e)
     {
         if(cboLoc.SelectedIndex == 2){
             Common.Utility.MaskDecimal1(e);
         }
     }

     
    }
}

