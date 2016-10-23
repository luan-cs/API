using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VVPosM1.CRM;
using VVPosM1.Screen;

namespace VVPosM1.Screen.CRM.Setting
{
    public partial class frmMasterSetting : Form
    {
        public frmMasterSetting()
        {
            InitializeComponent();
            permission_check();
        }

        private void permission_check()
        {
            if (!Program.lstRole.Contains("admin"))
            {
                btnEmployeeType.Visible = false;
                btnEmployee.Visible = false;
            }
        }

        private void setUILang()
        {
            lblMaster.Text = Common.clsLanguages.GetResource("CRM643");
            btnConfig.Text = Common.clsLanguages.GetResource("CRM623");
            btnEmployee.Text = Common.clsLanguages.GetResource("CRM621");
            btnEmployeeType.Text = Common.clsLanguages.GetResource("CRM622");
            btnCustomerType.Text = Common.clsLanguages.GetResource("CRM620");
            btnClassification.Text = Common.clsLanguages.GetResource("CRMClassificationTitle");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfiguration frm = new frmConfiguration();
            frm.ShowDialog();
        }

        private void btnEmployeeType_Click(object sender, EventArgs e)
        {
            Types.frmEmployeeType frm = new Types.frmEmployeeType();
            frm.ShowDialog();
        }

        private void btnCustomerType_Click(object sender, EventArgs e)
        {
            Types.frmCustommerType frm = new Types.frmCustommerType();
            frm.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee.frmEmployee frm = new Employee.frmEmployee();
            frm.ShowDialog();
        }

        private void lblMaster_Click(object sender, EventArgs e)
        {

        }

        private void btnClassification_Click(object sender, EventArgs e)
        {
            Types.Classification frmClassification = new Types.Classification();
            frmClassification.ShowDialog();
        }

        private void frmMasterSetting_Load(object sender, EventArgs e)
        {
            setUILang();
        }
    }
}
