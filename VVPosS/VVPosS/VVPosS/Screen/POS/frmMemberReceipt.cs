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
    public partial class frmMemberReceipt : Form
    {
        private ReceiptsBLL rcpBll;
        private string mbid;
        public frmMemberReceipt()
        {
            InitializeComponent();
            
        }

        private void ToUpper() {
            lbl_quyetma.Text = lbl_quyetma.Text.ToUpper();
            lblProductName.Text = lblProductName.Text.ToUpper();
            btnThem.Text = btnThem.Text.ToUpper();
            btnExit.Text = btnExit.Text.ToUpper();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mbid))
            {

            }
            else
            {
                Program.rep_mb = null;
            }
            this.Close();
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = txtMaKH.Text.Trim();
                LoadDataMember(id);
            }
        }

        private void LoadDataMember(string memberid)
        {
            rcpBll = new ReceiptsBLL();
            DataTable dt = rcpBll.GetMemberInfo(memberid);
            if (dt != null && dt.Rows.Count > 0)
            {
                ///                `members`.`MemberId`,
                ///                `members`.`MemberCode`,
                ///                `members`.`ObjectId`,
                ///                `members`.`NumberOfVissits`,
                ///                `members`.`LastestDate`,
                ///                `members`.`MemberType`,
                ///                `members`.`MemberScore`,
                ///                `objects`.`ObjectGroup`,
                ///                `objects`.`ObjectType`,
                ///                `objects`.`Tel`,
                ///                `objects`.`Email`,
                ///                `objects`.`Gender`,
                ///                `objects`.`FullName`,
                ///                `objects`.`TemAdd`
                string str = "";
                str = str + "\n" + Common.clsLanguages.GetResource("MemberID") + ": " + dt.Rows[0]["MemberId"].ToString() + " - " + dt.Rows[0]["MemberCode"].ToString();
                str = str + "\n" + Common.clsLanguages.GetResource("CustomerName") + ": " + dt.Rows[0]["MemberName"].ToString();
                str = str + "\n" + Common.clsLanguages.GetResource("Address") + ": " + dt.Rows[0]["Address"].ToString();
                str = str + "\n" + Common.clsLanguages.GetResource("Phone") + ": " + dt.Rows[0]["PhoneNumber"].ToString();
                str = str + "\n" + Common.clsLanguages.GetResource("NumberOfVissits") + ": " + dt.Rows[0]["NumberOfVissits"].ToString();
                str = str + "\n" + Common.clsLanguages.GetResource("LastestDate") + ": " + dt.Rows[0]["LastestDate"].ToString();
                str = str + "\n" + Common.clsLanguages.GetResource("Points") + ": " + dt.Rows[0]["CurrentScore"].ToString();
                lblProductName.Text = str;
                mbid = memberid;
                Program.rep_mb = new ReceiptMember();
                Program.rep_mb.MemberId = dt.Rows[0]["MemberId"].ToString();
                Program.rep_mb.CreatedBy = Program.Username;
                Program.rep_mb.MemberCode = dt.Rows[0]["MemberCode"].ToString();
                Program.rep_mb.NumberOfVissits = dt.Rows[0]["NumberOfVissits"].ToString();
                Program.rep_mb.LastestDate = dt.Rows[0]["LastestDate"].ToString();
                Program.rep_mb.MemberType = null;
                Program.rep_mb.Tel = dt.Rows[0]["PhoneNumber"].ToString();
                Program.rep_mb.Email = dt.Rows[0]["Email"].ToString();
                Program.rep_mb.FullName = dt.Rows[0]["MemberName"].ToString();
                Program.rep_mb.TemAdd = dt.Rows[0]["Address"].ToString();
                Program.rep_mb.MemberScore = dt.Rows[0]["CurrentScore"].ToString();
            }
            else
            {
                mbid = "";
                Program.rep_mb = null;
                CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("NotFoundCustomerCode"),
                                     clsLanguages.GetResource("Information"),
                                     Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }

        private void frmMemberReceipt_Load(object sender, EventArgs e)
        {
            SetUIChanges();
            ToUpper();
            //
            if (Program.rep_mb != null && !string.IsNullOrEmpty(Program.rep_mb.MemberId))
            {
                LoadDataMember(Program.rep_mb.MemberId);
                txtMaKH.Text = Program.rep_mb.MemberId;
                txtMaKH.SelectionStart = 0;
                txtMaKH.SelectionLength = Program.rep_mb.MemberId.Length;
            }

        }

        public void SetUIChanges()
        {

            this.lbTilte.Text = Common.clsLanguages.GetResource("CustomerInformation");
            this.lbl_quyetma.Text = Common.clsLanguages.GetResource("ScanCard");
            this.btnThem.Text = Common.clsLanguages.GetResource("Add");
            this.btnExit.Text = Common.clsLanguages.GetResource("Exit");

            
        }


    }
}

