using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VVPosS.Screen.POS
{
    public partial class frmInputPrice : Form
    {
        public frmInputPrice()
        {
            InitializeComponent();
            txtPrice.Text = "0";
        }
        public double _dblprice;
        public double _dblPrice
        {
            get { return _dblprice; }
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text != "") {
                _dblprice = double.Parse(txtPrice.Text);
                this.Close();
            }
            else {
                //Bạn chưa nhập giá, vui lòng nhập vào giá!
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseInputInformationLogin"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtPrice.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _dblprice = 0;
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text != "")
            {
                _dblprice = double.Parse(txtPrice.Text);
                txtPrice.Text = _dblprice.ToString("###,###,##0");
                txtPrice.SelectionStart = txtPrice.Text.Length;
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            Common.Utility.MaskDigit_keyDown(e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Utility.MaskDigit(e);
        }
    }
}
