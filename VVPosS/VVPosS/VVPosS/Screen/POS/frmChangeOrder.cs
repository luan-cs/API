using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosS.BusinessLayer;
using VVPosS.Common;

namespace VVPosS.Screen.POS
{
    public partial class frmChangeOrder : Form
    {
        public frmChangeOrder()
        {
            InitializeComponent();
            SetUI();
        }

        private void SetUI()
        {
            label1.Text = "Hủy Hóa Đơn";
            lblNotes.Text = clsLanguages.GetResource("Notes");
            lblReceiptId.Text = clsLanguages.GetResource("ReceiptNumber");
            btnOK.Text = clsLanguages.GetResource("Agree");
            btnCancel.Text = clsLanguages.GetResource("Exit");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (String.IsNullOrWhiteSpace(txtReceiptId.Text.Trim()))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng nhập vào mã hóa đơn.",
                                    clsLanguages.GetResource("Information"),
                                    Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtReceiptId.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(rtxtNotes.Text.Trim()))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng nhập lý do hủy.",
                                    clsLanguages.GetResource("Information"),
                                    Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                rtxtNotes.Focus();
                return;
            }
            DialogResult dr = CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("AreYouSureCancel"),
                                clsLanguages.GetResource("Information"),
                                Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    ReceiptsBLL receiptBll = new ReceiptsBLL();
                    string strFirst = "11";
                    //strFirst += ConfigurationManager.AppSettings["ShopId"];
                    string strMiddle = receiptBll.GetCurDateServer();
                    string strId = "";
                    int iId = Int32.Parse(txtReceiptId.Text.Trim());
                    if (iId < 10)
                    {
                        strId = "0000" + iId;
                    }
                    else if (iId >= 10 && iId <= 99)
                    {
                        strId = "000" + iId;
                    }
                    else if (iId >= 100 && iId <= 999)
                    {
                        strId = "00" + iId;
                    }
                    else if (iId >= 1000 && iId <= 9999)
                    {
                        strId = "0" + iId;
                    }
                    else if (iId >= 10000 && iId <= 99999)
                    {
                        strId = iId.ToString();
                    }
                    
                    string notes = rtxtNotes.Text;
                    if (receiptBll.GetReceiptById(strFirst + strMiddle + strId))
                    {
                        receiptBll.CancelReceipt(strFirst + strMiddle + strId, notes);
                        result = true;
                    }
                    else
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox("Mã hóa đơn không tồn tại trong hệ thống.",
                                clsLanguages.GetResource("Error"),
                                Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        txtReceiptId.Clear();
                        return;
                    }
                }
                catch
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox("Không thành công.",
                                    clsLanguages.GetResource("Information"),
                                    Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
                if (result)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox("Hủy hóa đơn thành công.",
                                    clsLanguages.GetResource("Information"),
                                    Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    this.Close();
                }
                else
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox("Không thành công.",
                                    clsLanguages.GetResource("Information"),
                                    Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                }
                
            }
        }

        private void txtReceiptId_KeyDown(object sender, KeyEventArgs e)
        {
            Utility.MaskDigit_keyDown(e);
        }

        private void txtReceiptId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.MaskDigit(e);
        }

        private void txtReceiptId_TextChanged(object sender, EventArgs e)
        {
            if (txtReceiptId.Text.Trim().Length > 6)
            {
                txtReceiptId.Text = txtReceiptId.Text.Trim().Substring(0, 6);
                txtReceiptId.SelectionStart = txtReceiptId.Text.Length;
            }
        }

        private void txtReceiptId_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtReceiptId_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmChangeOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
