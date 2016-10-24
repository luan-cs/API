using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosS.Common;
using VVPosS.Entities;
using VVPosS.BusinessLayer;
using System.Configuration;

namespace VVPosS.Screen.POS
{
    public partial class frmManageBankCard : Form
    {
        // khai bao bien
        private int curPage;
        private double totalPage;
        private string sId = null;
        private ReceiptsCard receiptCard;
        private ReceiptsCard receiptCardSea;
        private BankCardBLL bankCardBLL;
        private ReceiptsBLL receiptsBLL;

        public frmManageBankCard()
        {
            InitializeComponent();
            SettingControl();
            
            //label4.Focus();
        }

        private void frmManageBankCard_Load(object sender, EventArgs e)
        {
            SetUIChanges();
            ToUpper();
            //
            receiptCard = new ReceiptsCard();
            receiptCardSea = new ReceiptsCard();
            bankCardBLL = new BankCardBLL();
            
            LoadBank();
        }
        private void SettingControl()
        {
            //this.BackgroundImage = global::VVPosS.Properties.Resources.bg;
            foreach (Control c in this.Controls) { 
                Label lb = c as Label;
                if (lb != null)
                    lb.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.FORECOLOR);
            }
        }
        private void ToUpper()
        {
            foreach (Control c in this.pButton.Controls)
            {
                Button btn = c as Button;
                if (btn != null)
                    btn.Text = btn.Text.ToUpper();
            }
        }
        public void SetUIChanges()
        {
            this.label2.Text = Common.clsLanguages.GetResource("ManageBankCard");
            //this.label4.Text = Common.clsLanguages.GetResource("CardId");
            this.lbl_receiptId.Text = Common.clsLanguages.GetResource("OrderCode");
            this.lbl_NganHang.Text = Common.clsLanguages.GetResource("ChooseBank");
            this.lbl_SoThe.Text = Common.clsLanguages.GetResource("BankCardNumber");
            this.lbl_TenChuThe.Text = Common.clsLanguages.GetResource("CardHolderName");
            this.lbl_NgayHetHan.Text = Common.clsLanguages.GetResource("DeadlineDate");
            this.lbl_LoaiThe.Text = Common.clsLanguages.GetResource("BankCardType");
            //this.lbl_AppCode.Text = Common.clsLanguages.GetResource("lbTittle1");
            this.lbCreaDate.Text = Common.clsLanguages.GetResource("CreateDate");
            //this.lbl_MerchantID.Text = Common.clsLanguages.GetResource("MerchantID");
            this.lbl_SoMayPOS.Text = Common.clsLanguages.GetResource("PosMachineNumber");
            //this.lbl_TraceNo.Text = Common.clsLanguages.GetResource("BillTraceNo");
            this.lbl_RefNo.Text = Common.clsLanguages.GetResource("BankCardRefNo");
           

            this.btnSearch.Text = Common.clsLanguages.GetResource("Search");
            this.btnUpdate.Text = Common.clsLanguages.GetResource("Edit");
            this.btnReset.Text = Common.clsLanguages.GetResource("Reset");
            this.btnExit.Text = Common.clsLanguages.GetResource("MainScreen");

            //dataGridView
            this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            //this.Id.HeaderText = Common.clsLanguages.GetResource("CardId");
            this.ReceiptId.HeaderText = Common.clsLanguages.GetResource("ReceiptNumber");
            this.InfoCard.HeaderText = Common.clsLanguages.GetResource("CardInformation");
            this.InfoTran.HeaderText = Common.clsLanguages.GetResource("TransactionInformation");
            this.TotalAmount.HeaderText = Common.clsLanguages.GetResource("TotalAmount");
            this.InfoCreate.HeaderText = Common.clsLanguages.GetResource("InfoInitiated");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmMain f = new frmMain();
            //f.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblTB1.Text = "...";
            lblTB.Text = "...";
            curPage = 1;
            totalPage = 1;

            receiptCardSea = new ReceiptsCard();
            receiptCardSea.id = sId;
            receiptCardSea.ReceiptId = txtReceiptId.Text;
            receiptCardSea.CardNo = txtCardNo.Text;
            receiptCardSea.CardHolderName = txtCardHolderName.Text;
            receiptCardSea.ExpiredDate = txtExpiredDate.Text;
            if (cbbCardType.SelectedIndex != 0)
                receiptCardSea.CardType = cbbCardType.SelectedValue.ToString();
            else
                receiptCardSea.CardType = "";
            if (cbbBank.SelectedIndex != 0)
                receiptCardSea.Bank = cbbBank.SelectedValue.ToString();
            else
                receiptCardSea.Bank = "";
            receiptCardSea.TerminalId = txtTerminalId.Text;
            receiptCardSea.MerchantId = txtMerchantID.Text;
            receiptCardSea.TransType = txtTransType.Text;
            receiptCardSea.BatchNo = txtBatchNo.Text;
            receiptCardSea.TraceNo = txtTraceNo.Text;
            receiptCardSea.RefNo = txtRefNo.Text;
            receiptCardSea.AppCode = txtAppCode.Text;
            if (chkDate.Checked == true)
            {
                receiptCardSea.CreatedDate = dtpCreateDate.Value.ToString("yyyy-MM-dd HH:mm:ss"); 
            }
            else
            {
                receiptCardSea.CreatedDate = "";
            }

            SearchObjects(1);
        }

        private void SearchObjects(int page)
        {
            curPage = page;
            int total = 0;
            DataTable dt = bankCardBLL.SearchObjects(receiptCardSea, page, out total);
            double RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            dgv.Rows.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                string str;
                int i = 0;
                int stt = (page - 1) * RecPerPage;
                foreach (DataRow dr in dt.Rows)
                {
                    dgv.Rows.Add();
                    dgv.Rows[i].Cells[0].Value = (stt + 1).ToString();
                    dgv.Rows[i].Cells[1].Value = dr["Id"].ToString();
                    dgv.Rows[i].Cells[2].Value = dr["ReceiptId"].ToString();
                    str = "";
                    str = Common.clsLanguages.GetResource("CardHolderName") + "" +dr["CardHolderName"].ToString() ;
                    str = str + "\n" + Common.clsLanguages.GetResource("CardNumber") + "" +dr["CardNo"].ToString();
                    str = str + "\n" + Common.clsLanguages.GetResource("DeadlineDate") + ": " + dr["ExpiredDate"].ToString();
                  //  str = str + "\n" + Common.clsLanguages.GetResource("CardType") + ": " + dr["CardType"].ToString();
                    //CardType
                    DataTable dt01 = bankCardBLL.GetCardType(dr["CardType"].ToString());
                    if (dt01 != null && dt01.Rows.Count > 0)
                    {
                        str = str + "\n" + Common.clsLanguages.GetResource("BankCardType") + ": " + dt01.Rows[0]["StrValue1"].ToString();
                    }
                    // bank 
                   
                    DataTable dt1 = bankCardBLL.GetBankName(dr["Bank"].ToString());
                    if (dt1 != null && dt1.Rows.Count > 0)
                    {
                        str = str + "\n" + Common.clsLanguages.GetResource("ChooseBank") + ": " + dt1.Rows[0]["StrValue1"].ToString();
                    }
                    dgv.Rows[i].Cells[3].Value = str;
                   // thông tin giao dịch
                    str = "";
                    str = Common.clsLanguages.GetResource("NoTracsition") + dr["TerminalId"].ToString();
                    str = str + "\n Batch No: " +dr["BatchNo"].ToString();
                    str = str + "\n Trace No: " +dr["TraceNo"].ToString();
                    str = str + "\n Ref No: " + dr["RefNo"].ToString();
                    str = str + "\n App Code: " + dr["Appcode"].ToString();
                    str = str + "\n MerchantId: " + dr["MerchantId"].ToString();
                    dgv.Rows[i].Cells[4].Value = str;
                    dgv.Rows[i].Cells[5].Value = string.Format("{0:0,0}", dr["TotalAmount"]);
                    // thông tin khởi tạo
                    str = "";
                    str = str + Common.clsLanguages.GetResource("CreateBy") + ": " + dr["CreatedBy"].ToString() + "\n";
                    str = str + Common.clsLanguages.GetResource("CreateDate") + ": " + dr["CreatedDate"].ToString() + "\n";
                    str = str + Common.clsLanguages.GetResource("ModifiedBy") + ": " + dr["ModifiedBy"].ToString() + "\n";
                    str = str +  Common.clsLanguages.GetResource("ModifiedDate") + ": "+ dr["ModifiedDate"].ToString();
                    dgv.Rows[i].Cells[6].Value = str;
                    i++;
                    stt++;
                }
            }
            linkNumber.Text = curPage.ToString() + "/" + totalPage.ToString();
            lblTB.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
        }
        private void LoadBank()
        {
            receiptsBLL = new ReceiptsBLL();
            DataTable dt = receiptsBLL.GetBank();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("000", VVPosS.Common.clsLanguages.GetResource("Gender_null"));
            foreach (DataRow dr in dt.Rows)
            {
                test.Add(dr["CommonId"].ToString(), dr["StrValue1"].ToString());
            }
            cbbBank.DataSource = new BindingSource(test, null);
            cbbBank.DisplayMember = "Value";
            cbbBank.ValueMember = "Key";
        }

        private void LoadBankType()
        {
            string BankCommonId = "";
            if (cbbBank.SelectedIndex != 0)
            {
                BankCommonId = cbbBank.SelectedValue.ToString();
            }
            receiptsBLL = new ReceiptsBLL();
            DataTable dt = receiptsBLL.GetBankType(BankCommonId);
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosS.Common.clsLanguages.GetResource("Gender_null"));
            foreach (DataRow dr in dt.Rows)
            {
                test.Add(dr["CommonId"].ToString(), dr["StrValue1"].ToString());
            }
            cbbCardType.DataSource = new BindingSource(test, null);
            cbbCardType.DisplayMember = "Value";
            cbbCardType.ValueMember = "Key";
        }

        private void cbbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBankType();
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
                lblTB.Text = "...";
                lblTB1.Text = "...";
                dtpCreateDate.Value = DateTime.Now;
                dgv.Rows.Clear();
                //txtId.ReadOnly = false;
                txtReceiptId.ReadOnly = false;
                sId = null;
               // picbImgObject.Image = null;
            }
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                ReceiptsCard ob = bankCardBLL.GetReceiptCardWithID(id);
                if (ob != null)
                {
                    txtReceiptId.Text = ob.ReceiptId;
                    txtReceiptId.ReadOnly = true;
                   
                    if (!string.IsNullOrEmpty(ob.Bank))
                    {
                        //check trong cbo                        
                        cbbBank.SelectedIndex = 0;
                        foreach (var item in cbbBank.Items)
                        {
                            KeyValuePair<string, string> itm = (KeyValuePair<string, string>)item;
                            if (itm.Key == ob.Bank)
                            {
                                cbbBank.SelectedValue = ob.Bank;
                                break;
                            }
                        }
                    }
                    txtCardNo.Text = ob.CardNo;
                    txtCardHolderName.Text = ob.CardHolderName;
                    txtExpiredDate.Text = ob.ExpiredDate;

                    if (!string.IsNullOrEmpty(ob.CardType))
                    {
                        //LoadBankType();
                        //check trong cbo                        
                        cbbCardType.SelectedIndex = 0;
                        foreach (var item in cbbCardType.Items)
                        {
                            KeyValuePair<string, string> itm = (KeyValuePair<string, string>)item;
                            if (itm.Key == ob.CardType)
                            {
                                cbbCardType.SelectedValue = ob.CardType;
                                break;
                            }
                        }
                    }
                    dtpCreateDate.Text = ob.CreatedDate;
                    txtAppCode.Text = ob.AppCode;
                    txtBatchNo.Text = ob.BatchNo;
                    txtTransType.Text = ob.TransType;
                    txtMerchantID.Text = ob.MerchantId;
                    txtTerminalId.Text = ob.TerminalId;
                    txtTraceNo.Text = ob.TraceNo;
                    txtRefNo.Text = ob.RefNo;
                    sId = ob.id;
                }
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (curPage > 1)
            {
                SearchObjects(curPage - 1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (curPage < totalPage)
            {
                SearchObjects(curPage + 1);
            }
        }
        private bool Kiemtra()
        {
            if (cbbBank.SelectedIndex == 0)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("NotChooseBankCard"),
                                     clsLanguages.GetResource("Information"),
                                     Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                cbbBank.Focus();
                return false;
            }
            if (txtCardNo.Text=="")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("PleaseInputYourCardNumber"),
                                     clsLanguages.GetResource("Information"),
                                     Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                cbbBank.Focus();
                return false;
            }
            return true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Kiemtra()) return;
            Update();
        }

        private void Update()
        {
            // check xem có trong db chưa?
            //string id = txtId.Text.Trim();
            ReceiptsCard recard = new ReceiptsCard();
            recard = bankCardBLL.GetReceiptCardWithID(sId);

            receiptCardSea = new ReceiptsCard();
            receiptCardSea.id = sId;
            receiptCardSea.ReceiptId = txtReceiptId.Text;
            receiptCardSea.CardNo = txtCardNo.Text;
            receiptCardSea.CardHolderName = txtCardHolderName.Text;
            receiptCardSea.ExpiredDate = txtExpiredDate.Text;
            if (cbbCardType.SelectedIndex != 0)
                receiptCardSea.CardType = cbbCardType.SelectedValue.ToString();
            else
                receiptCardSea.CardType = "";
            if (cbbBank.SelectedIndex != 0)
                receiptCardSea.Bank = cbbBank.SelectedValue.ToString();
            else
                receiptCardSea.Bank = "";
            receiptCardSea.TerminalId = txtTerminalId.Text;
            receiptCardSea.MerchantId = txtMerchantID.Text;
            receiptCardSea.TransType = txtTransType.Text;
            receiptCardSea.BatchNo = txtBatchNo.Text;
            receiptCardSea.TraceNo = txtTraceNo.Text;
            receiptCardSea.RefNo = txtRefNo.Text;
            receiptCardSea.AppCode = txtAppCode.Text;

            if (recard != null)
            {// Cập nhật
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("SureUpdate"),
                                   clsLanguages.GetResource("Information"),
                                   Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                {
                    //receiptCardSea.id = id;
                    int i = bankCardBLL.Update(receiptCardSea);
                    if (i == 1)
                    {
                        //txtId.ReadOnly = false;
                        txtReceiptId.ReadOnly = false;
                        sId = null;
                        lblTB1.Text = Common.clsLanguages.GetResource("UpdateSuccess");
                    }
                    else
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("UpdateFailed");
                    }
                }
            }
           
            SearchObjects(1);

        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked == true)
            {
                dtpCreateDate.Enabled = true;
            }
            else
            {
                dtpCreateDate.Enabled = false;
            }
        }

    }
}
