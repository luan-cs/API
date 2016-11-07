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

namespace VVPosS.Screen.POS
{
    public partial class NoteOrderForm : Form
    {
        public NoteOrderForm()
        {
            InitializeComponent();
            rtbCustomInfo.Focus();
            
        }

        private string customInfor = string.Empty;
        public string CustomInfor
        {
            get
            {
                return customInfor;
            }
            set
            {
                customInfor = value;
            }
        }
        private void bntFinish_Click(object sender, EventArgs e)
        {
            if (rtbCustomInfo.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng nhập thông tin khách hàng.",
                                   clsLanguages.GetResource("Information"),
                                   Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                rtbCustomInfo.Focus();
                return;
            }
            else
            {
                customInfor = rtbCustomInfo.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
