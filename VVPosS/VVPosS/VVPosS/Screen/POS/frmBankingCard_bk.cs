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
    public partial class frmBankingCard_bk : Form
    {
        public double SoTienCanThanhToan;
        public int autoid;
        public frmBankingCard_bk()
        {
            InitializeComponent();
            SettingControl();
            SetUIChanges();         
        }

        public string id = "";
        public string Id
        {
            get { return id; }
        }

        private void SettingControl()
        {
            //setting background for form
            this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            //setting title
            SoTienCanThanhToan = 0;

        }

        public void SetUIChanges()
        {
            this.lbl_NganHang.Text = Common.clsLanguages.GetResource("ChooseBank");
            this.lbl_SoThe.Text = Common.clsLanguages.GetResource("BankCardNumber");
            this.lbl_TenChuThe.Text = Common.clsLanguages.GetResource("CardHolderName");
            this.lbl_NgayHetHan.Text = Common.clsLanguages.GetResource("CardExpiredDate");
            this.lbl_LoaiThe.Text = Common.clsLanguages.GetResource("BankCardType");
            this.lbl_SoTienThanhToan.Text = Common.clsLanguages.GetResource("BankCardAmount");
            this.lbl_AppCode.Text = Common.clsLanguages.GetResource("AppCode");
            this.lbl_BatchNo.Text = Common.clsLanguages.GetResource("BatchNo");
            this.lbl_TransactionType.Text = Common.clsLanguages.GetResource("TransactionType");
            this.lbl_MerchantID.Text = Common.clsLanguages.GetResource("MerchantID");
            this.lbl_SoMayPOS.Text = Common.clsLanguages.GetResource("PosMachineNumber");
            this.lbl_TraceNo.Text = Common.clsLanguages.GetResource("BillTraceNo");
            this.lbl_RefNo.Text = Common.clsLanguages.GetResource("BankCardRefNo");

            this.lbl_TongTien.Text = Common.clsLanguages.GetResource("bankCardTotalPayAmount");
            this.lbl_DaThanhToan.Text = Common.clsLanguages.GetResource("bankCardTotalPaidAmount");

            this.btnThem.Text = Common.clsLanguages.GetResource("Add");
            this.btnExit.Text = Common.clsLanguages.GetResource("Exit");
            
            //dataGridView
            this.dtg_BankCard_No.HeaderText = Common.clsLanguages.GetResource("No");
            this.dtg_BankCard_Infomartion.HeaderText = Common.clsLanguages.GetResource("CardInformation");
            this.dtg_BankCard_Transation.HeaderText = Common.clsLanguages.GetResource("TransactionInformation");
            this.dtg_BankCard_Total.HeaderText = Common.clsLanguages.GetResource("CardPayingAmt");
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

        private void frmBankingCard_Load(object sender, EventArgs e)
        {
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

        private void btnThem_Click(object sender, EventArgs e)
        {
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
                //rc.CardType = cbbCardType.SelectedValue.ToString();
                rc.CardType = "VISA";
                //rc.Bank = cbbBank.SelectedValue.ToString();
                rc.Bank = "ACB";
                rc.TotalAmount = txtSoTienTT.Text;

                rc.TerminalId = txtTerminalId.Text;
                rc.MerchantId = txtMerchantID.Text;
                rc.TransType = txtTransType.Text;
                rc.BatchNo = txtBatchNo.Text;
                rc.TraceNo = txtTraceNo.Text;
                rc.RefNo = txtRefNo.Text;
                rc.AppCode = txtAppCode.Text;
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
            string str = " Tên chủ thẻ: " + rc.CardHolderName;
            str = str + "\n Số thẻ: " + rc.CardNo;
            str = str + "\n Ngày hết hạn: " + rc.ExpiredDate;
            str = str + "\n Loại thẻ: " + rc.CardType;
            str = str + "\n Ngân hàng : " + rc.Bank;
            dataGridView.Rows[i].Cells[2].Value = str; //ProductId

            //ttin Transaction
            str = "Số GD: " + rc.TerminalId + "\n";
            str = str + "\n Batch No: " + rc.BatchNo;
            str = str + "\n Trace No: " + rc.TraceNo;
            str = str + "\n Ref No: " + rc.RefNo;
            
            dataGridView.Rows[i].Cells[3].Value = str; //PromotionId

            dataGridView.Rows[i].Cells[4].Value = rc.TotalAmount;
            dataGridView.Rows[i].Cells[17].Value = "Xóa"; //Xóa            
            DataGridViewRow row = dataGridView.Rows[i];
            row.Height = 35;
            
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 17)
            {
                int i = e.RowIndex;
                int id = int.Parse(dataGridView.Rows[i].Cells[1].Value.ToString());
                if (Program.lstCard != null && Program.lstCard.Count > 0)
                {
                    int j = 0;
                    foreach (ReceiptsCard rc in Program.lstCard)
                    {
                        int rcid = int.Parse(rc.id);
                        if (rcid == id)
                        {
                            Program.lstCard.RemoveAt(j);
                            dataGridView.Rows.RemoveAt(i);
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
                }
            }
        }

    }
}
