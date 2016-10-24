using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VVPosS.Screen.Members
{
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
            SettingControl();
        }

        private void SettingControl()
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.BACKGROUNDCOLOR);
            this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
        }


    }
}
