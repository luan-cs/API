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

namespace VVPosS.Screen.POS
{
    public partial class frmBankingCard : Form
    {
        private ReceiptsBLL receiptsBLL;
        public double SoTienCanThanhToan;
        public double ttx;
        public int autoid;
        public frmBankingCard()
        {
            InitializeComponent();
            SettingControl();
            
            //SetUIChanges(); 
            SetUIChanges();
            //ToUpper
            ToUpper();
            txtCardNo.Focus();
            LoadBank();
        }

        public string id = "";
        public string Id
        {
            get { return id; }
        }

        private void SettingControl()
        {
            //setting background for form
            //this.BackgroundImage = Common.Utility.GetImageFromService("ShopImg", "bg14.jpeg");
            //setting title
            SoTienCanThanhToan = 0;
            ttx = 0;

        }

        #region ToUpper
        private void ToUpper()
        {
            lbDesk.Text = lbTittle1.Text.ToUpper();
        }
        #endregion

        public void SetUIChanges()
        {
            this.lbl_NganHang.Text = Common.clsLanguages.GetResource("ChooseBank");
            this.lbl_SoThe.Text = Common.clsLanguages.GetResource("BankCardNumber");
            this.lbl_TenChuThe.Text = Common.clsLanguages.GetResource("CardHolderName");
            this.lbl_NgayHetHan.Text = Common.clsLanguages.GetResource("DeadlineDate");
            this.lbl_LoaiThe.Text = Common.clsLanguages.GetResource("BankCardType");
            this.lbl_SoTienThanhToan.Text = Common.clsLanguages.GetResource("BankCardAmount");
            //this.lbl_AppCode.Text = Common.clsLanguages.GetResource("lbTittle1");
            this.lbTittle1.Text = Common.clsLanguages.GetResource("SrcenCardPayment");
            this.lbDesk.Text = Common.clsLanguages.GetResource("PaymentInfomation");
            //this.lbl_MerchantID.Text = Common.clsLanguages.GetResource("MerchantID");
            this.lbl_SoMayPOS.Text = Common.clsLanguages.GetResource("PosMachineNumber");
            this.lbl_TraceNo.Text = Common.clsLanguages.GetResource("BillTraceNo");
            this.lbl_RefNo.Text = Common.clsLanguages.GetResource("BankCardRefNo");

            this.lbl_TongTien.Text = Common.clsLanguages.GetResource("bankCardTotalPayAmount");
            this.lbl_DaThanhToan.Text = Common.clsLanguages.GetResource("bankCardTotalPaidAmount");

            this.btnThem.Text = Common.clsLanguages.GetResource("Add");
            this.btnExit.Text = Common.clsLanguages.GetResource("PaymentScreen");
            
            //dataGridView
            this.dtg_BankCard_No.HeaderText = Common.clsLanguages.GetResource("No");
            this.dtg_BankCard_Infomartion.HeaderText = Common.clsLanguages.GetResource("CardInformation");
            this.dtg_BankCard_Transation.HeaderText = Common.clsLanguages.GetResource("TransactionInformation");
            this.dtg_BankCard_Total.HeaderText = Common.clsLanguages.GetResource("TotalAmount");
            this.dtg_BankCard_Delete.HeaderText = Common.clsLanguages.GetResource("Delete");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearDataGridView(DataGridView dtgv)
        {
            dtgv.Rows.Clear();
            dtgv.Refresh();
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


        private void frmBankingCard_Load(object sender, EventArgs e)
        {
            txtCardNo.Focus();
            if (SoTienCanThanhToan > 0)
            {
                lblTongTienPX.Text = SoTienCanThanhToan.ToString("0,0");
                txtSoTienTT.NumericValue = SoTienCanThanhToan;
                double daTT = 0;
                if (Program.lstCard != null && Program.lstCard.Count > 0)
                {
                    foreach (ReceiptsCard rc in Program.lstCard)
                    {
                        daTT = daTT + double.Parse(rc.TotalAmount);
                        insertIntoList(rc);
                        autoid = int.Parse(rc.id);
                    }
                    autoid = autoid + 1;
                }
                else
                {
                    autoid = 0;
                }
                lblDaThanhToan.Text = daTT.ToString("0,0");
                //txtSoTienTT.Text = daTT.ToString("0,0");
               // txtSoTienTT.NumericValue = daTT;
            }
        }

         private bool Kiemtra()
        {
            if (txtCardNo.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CardIdNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtCardNo.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!Kiemtra()) return;
            double amt = double.Parse(txtSoTienTT.Text);
            double tt = double.Parse(lblTongTienPX.Text);
            if (amt <= tt && amt > 0)
            {
                ReceiptsCard rc = new ReceiptsCard();
                rc.id = autoid.ToString();
                rc.ReceiptId = "";
                rc.CardNo = txtCardNo.Text;
                rc.CardHolderName = txtCardHolderName.Text;
                rc.ExpiredDate = txtExpiredDate.Text;
                rc.CreatedBy = Program.Username;
                if (cbbCardType.SelectedIndex != 0)
                    rc.CardType = cbbCardType.SelectedValue.ToString();
                else
                    rc.CardType = "";
                if (cbbBank.SelectedIndex != 0)
                    rc.Bank = cbbBank.SelectedValue.ToString();
                else
                    rc.Bank = "";
                rc.TotalAmount = txtSoTienTT.Text;
                rc.TerminalId = txtTerminalId.Text;
                rc.MerchantId = txtMerchantID.Text;
                rc.TransType = txtTransType.Text;
                rc.BatchNo = txtBatchNo.Text;
                rc.TraceNo = txtTraceNo.Text;
                rc.RefNo = txtRefNo.Text;
                rc.AppCode = txtAppCode.Text;
                //rc.CanUpdate = "1";
                if (Program.lstCard == null)
                {
                    Program.lstCard = new List<ReceiptsCard>();
                }
                Program.lstCard.Add(rc);

                // insert vào grid
                insertIntoList(rc);

                double daTT = double.Parse(lblDaThanhToan.Text);
                daTT = daTT + amt;
                tt = tt - amt;
                lblDaThanhToan.Text = daTT.ToString("0,0");
                lblTongTienPX.Text = tt.ToString("0,0");
                SoTienCanThanhToan = SoTienCanThanhToan - double.Parse(txtSoTienTT.Text);
                Reset();
                txtSoTienTT.Text = SoTienCanThanhToan.ToString("0,0");
                autoid++;
            }
            else
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CardAmountLimit"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }

        private void insertIntoList(ReceiptsCard rc)
        {
            int i = dataGridView.Rows.Count;
            // chưa có trong list  --> thêm mới
            dataGridView.Rows.Add();
            dataGridView.Rows[i].Cells[0].Value = (i + 1).ToString(); //STT
            dataGridView.Rows[i].Cells[1].Value = rc.id; //Id
            
            //Ttin thẻ
            string str = Common.clsLanguages.GetResource("CardHolderName")  + " " + rc.CardHolderName;
            str = str + "\n" + Common.clsLanguages.GetResource("CardNumber") + " " + rc.CardNo;
            str = str + "\n" + Common.clsLanguages.GetResource("DeadlineDate")+ ": " + rc.ExpiredDate;
            str = str + "\n" + Common.clsLanguages.GetResource("CardType") + ": " + rc.CardType;
            str = str + "\n" + Common.clsLanguages.GetResource("Banks") + ": " + rc.Bank;
            dataGridView.Rows[i].Cells[2].Value = str; //ProductId

            //ttin TransactionBanks
            str = Common.clsLanguages.GetResource("NoTracsition") + rc.TerminalId + "\n";
            str = str + "\n Batch No: " + rc.BatchNo;
            str = str + "\n Trace No: " + rc.TraceNo;
            str = str + "\n Ref No: " + rc.RefNo;
            
            dataGridView.Rows[i].Cells[3].Value = str; //PromotionId

            dataGridView.Rows[i].Cells[4].Value = rc.TotalAmount;
            //dataGridView.Rows[i].Cells[17].Value = "Xóa"; //Xóa            
            DataGridViewRow row = dataGridView.Rows[i];
            row.Height = 35;
            
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 17)
            {
                int i = e.RowIndex;
                int id = int.Parse(dataGridView.Rows[i].Cells[1].Value.ToString());
                ttx = double.Parse(dataGridView.Rows[i].Cells[4].Value.ToString());
                //xóa cell
                SoTienCanThanhToan = SoTienCanThanhToan + ttx;
                Reset();
                txtSoTienTT.Text = SoTienCanThanhToan.ToString("0,0");
                dataGridView.Rows.RemoveAt(i);
                DanhLaiSTT();
                //------
                if (Program.lstCard != null && Program.lstCard.Count > 0)
                {
                    int j = 0;
                    foreach (ReceiptsCard rc in Program.lstCard)
                    {
                        int rcid = int.Parse(rc.id);
                        if (rcid == id)
                        {
                            Program.lstCard.RemoveAt(j);
                           
                            break;
                        }
                        j++;
                    }
                }

                if (SoTienCanThanhToan > 0)
                {
                    lblTongTienPX.Text = SoTienCanThanhToan.ToString("0,0");
                    double daTT = 0;
                    if (Program.lstCard != null && Program.lstCard.Count > 0)
                    {
                        foreach (ReceiptsCard rc in Program.lstCard)
                        {
                            daTT = daTT + double.Parse(rc.TotalAmount);
                          //  insertIntoList(rc);
                            autoid = int.Parse(rc.id);
                        }
                        autoid = autoid + 1;
                    }
                    else
                    {
                        autoid = 0;
                    }
                    lblDaThanhToan.Text = daTT.ToString("0,0");
                }
            }
        }

        private void cbbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBankType();
        }

        private void gDesk_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            GroupBox box = sender as GroupBox;
            Common.Utility.DrawGroupBox(box, e.Graphics, Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(243)))), ((int)(((byte)(248))))), Color.FromArgb(3,136,160), this);
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

            }
        }

        private void DanhLaiSTT()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
    }
}
