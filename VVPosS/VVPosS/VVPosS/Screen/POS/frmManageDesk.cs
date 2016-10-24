using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosS.BusinessLayer;
using VVPosS.Entities;
using System.Configuration;

namespace VVPosS.Screen.POS
{
    public partial class frmManageDesk : Form
    {
        private DeskBLL deskBLL;
        private Desk desk = new Desk();
        private int _iDeskId = 0, _iCurrentPage = 1, _iTotalRecord = 0;
        //private string _sStatus = "";
        private bool _bNew = true;

        public frmManageDesk()
        {
            InitializeComponent();
            //SettingControl();
            
            
        }

        private void frmManageDesk_Load(object sender, EventArgs e)
        {
            SetUIChanges();
            ToUpper();
            //
            LoadStatus();
            //_sStatus = cboStatus.SelectedValue.ToString();
            LoadDeskLocation();
        }
       
        private void SettingControl()
        {
        }

        /// <summary>
        /// Set text for control
        /// </summary>
        public void SetUIChanges()
        {
            bntExit.Text = Common.clsLanguages.GetResource("MainScreen");
            bntLuu.Text = Common.clsLanguages.GetResource("Save");
            bntSeach.Text = Common.clsLanguages.GetResource("Search");
            bntReset.Text = Common.clsLanguages.GetResource("Reset");
            lbTilte.Text = Common.clsLanguages.GetResource("ManageDesk");
            lbDesk.Text = Common.clsLanguages.GetResource("Name");
            lbLocation.Text = Common.clsLanguages.GetResource("Location");
            lbStatus.Text = Common.clsLanguages.GetResource("Status");
            lbDescription.Text = Common.clsLanguages.GetResource("Description");
            lbSeat.Text = Common.clsLanguages.GetResource("NoOfSeat");
            //gShowDesk.Text = Common.clsLanguages.GetResource("DeskList");
            this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            this.Status.HeaderText = Common.clsLanguages.GetResource("Status");
            this.DeskNo.HeaderText = Common.clsLanguages.GetResource("Name");
            this.Description.HeaderText = Common.clsLanguages.GetResource("Description");
            this.DeskLocation.HeaderText = Common.clsLanguages.GetResource("Location");
        }

        private void ToUpper() {
            foreach (Control c in this.pButton.Controls) {
                Button btn = c as Button;
                if (btn != null)
                    btn.Text = btn.Text.ToUpper();
            }
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmMain f = new frmMain();
            //f.Visible = true;
        }


        private void bntSeach_Click(object sender, EventArgs e)
        {
            data_Desk.Rows.Clear();
            data_Desk.Refresh();
            LoadDesk(1);
        }

        private bool Kiemtra() {
            if (txtDeskNo.Text == "") {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NameNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtDeskNo.Focus();
                return false;
            }
            if (txtDeskSeat.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NoOfSeatNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtDeskSeat.Focus();
                return false;
            }
            if (cboLocation.SelectedIndex == 0)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NoOfSeatNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                cboLocation.Focus();
                return false;
            }
            if (cboStatus.SelectedIndex == 0)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ChooseStatus"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                cboStatus.Focus();
                return false;
            }
            if (rtxtDescription.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DescriptionNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                rtxtDescription.Focus();
                return false;
            }
            return true;
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // kiem tra du lieu
                if (!Kiemtra()) return;

                //insert du lieu vao data
                desk.DeskId = _iDeskId.ToString();
                desk.DeskNo = txtDeskNo.Text;
                desk.DeskLocation = cboLocation.SelectedValue.ToString();
                desk.Description = rtxtDescription.Text;
                desk.Status = cboStatus.SelectedValue.ToString();
                desk.NoOfSeat = txtDeskSeat.Text;
                //kiem tra DeskNo co ton tai hay khong
                DataTable dt = new DataTable();
                deskBLL = new DeskBLL();
                dt = deskBLL.GetLists("");
                if (dt != null || dt.Rows.Count > 0)
                {
                    DataRow[] r = dt.Select("DeskNo ='" + txtDeskNo.Text.Trim() + "'");
                    if (r == null || r.Length == 0){
                        desk.sCondition = "0";
                        //_bNew = true;
                    }
                    else{
                        desk.sCondition = "1";
                        //_bNew = false;
                    }

                }
                //if deskid = 0 then Insert else Update
                if (desk.sCondition == "0" && _iDeskId == 0)
                    deskBLL.Add(desk);
                else if (desk.sCondition == "0" && _iDeskId != 0) {
                    deskBLL.Update(desk);
                }
                else if (desk.sCondition == "1" && _iDeskId == 0)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DeskNameAlreadyAreYouWantToUpdate"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)

                        deskBLL.Update(desk);

                    else return;
                }
                else if (desk.sCondition == "1" && _iDeskId != 0)
                {
                    DataTable dt1 = deskBLL.CheckExitByNameAndNotINId(txtDeskNo.Text.Trim(), _iDeskId);
                    if (dt1.Rows.Count > 0)
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NameAlreadyPleaseInputOther"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);

                        return;
                    }
                    else deskBLL.Update(desk);
                }
                /*else if (!_bNew)
                {
                   if(_iDeskId==0){
                        if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DeskNameAlreadyAreYouWantToUpdate"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)

                            deskBLL.Update(desk);

                        else return;
                    }
                    
                    
                    else 
                    {
                        DataTable dt1 = deskBLL.CheckExitByNameAndNotINId(txtDeskNo.Text.Trim(), _iDeskId);
                       if(dt1.Rows.Count > 0){
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NameAlreadyPleaseInputOther"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);

                        return;
                       }
                       else deskBLL.Update(desk);

                    }

                }*/
                //else if (!_bNew && _iDeskId != 0)
                //{
                //     CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NameAlreadyPleaseInputOther"),
                //                     Common.clsLanguages.GetResource("Information"),
                //                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);

                //     return;
                //}
                
                if (deskBLL.Res && _bNew && _iDeskId == 0)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AddSuccess"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    Reset();
                }
                else if (deskBLL.Res)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("UpdateSuccess"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    Reset();
                }
                else if (!deskBLL.Res)
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("UpdateFailed"),
                                        Common.clsLanguages.GetResource("Error"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                LoadDesk(1);
            }
            catch (Exception obj) {
                MessageBox.Show(obj.ToString());
            }
        }

        //private void LoadDesk() {
        //    DataTable dt = deskBLL.GetLists("");

        //    int i = 0;
        //    foreach(DataRow r in dt.Rows){
        //        data_Desk.Rows.Add();
        //        data_Desk.Rows[i].Cells["STT"].Value = i+1;
        //        data_Desk.Rows[i].Cells["DesKId"].Value = r["DesKId"];
        //        data_Desk.Rows[i].Cells["DeskNo"].Value = r["DesKNo"];
        //        data_Desk.Rows[i].Cells["Description"].Value = r["Description"];
        //        data_Desk.Rows[i].Cells["NoOfSeat"].Value = r["NoOfSeat"];
        //        data_Desk.Rows[i].Cells["DeskLocation"].Value = r["DeskLocation"];
        //        data_Desk.Rows[i].Cells["StatusId"].Value = r["Status"];
        //        //get Name of status
        //        CommonCode cm = new CommonCode();
        //        cm.CommonId = r["Status"].ToString();
        //        deskBLL.GetStatusName(cm);
        //        DataSet ds = deskBLL.Ds;
        //        data_Desk.Rows[i].Cells["Status"].Value = ds.Tables[0].Rows[0]["StrValue1"].ToString();

        //        i++;
        //    }
        //}

        private void LoadStatus() {
            deskBLL = new DeskBLL();
            CommonCode cm = new CommonCode();
            cm.CommonTypeId = "DeskType";
            DataTable St = new DataTable();
            St = deskBLL.GetStatus(cm);

            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosS.Common.clsLanguages.GetResource("Status_null"));
            foreach (DataRow r in St.Rows)
            {
                test.Add(r["CommonId"].ToString(), r["StrValue1"].ToString());
            }
            cboStatus.DataSource = new BindingSource(test, null);
            cboStatus.ValueMember = "Key";
            cboStatus.DisplayMember = "Value";
            
        }

        private void LoadDeskLocation()
        {
            deskBLL = new DeskBLL();
            CommonCode cm = new CommonCode();
            cm.CommonTypeId = "DeskLocation";
            DataTable St = new DataTable();
            St = deskBLL.GetStatus(cm);
            

            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosS.Common.clsLanguages.GetResource("Status_null"));
            foreach (DataRow r in St.Rows) {
                test.Add(r["CommonId"].ToString(), r["StrValue1"].ToString());
            }
            cboLocation.DataSource = new BindingSource(test, null);
            cboLocation.ValueMember = "Key";
            cboLocation.DisplayMember = "Value";

        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_sStatus = cboStatus.SelectedValue.ToString();
        }

        private void txtDeskSeat_KeyDown(object sender, KeyEventArgs e)
        {
            VVPosS.Common.Utility.MaskDigit_keyDown(e);
        }

        private void txtDeskSeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            VVPosS.Common.Utility.MaskDigit(e);
        }

        private void bntPre_Click(object sender, EventArgs e)
        {
            GoPre();
        }
        private void GoPre()
        {
            if (_iCurrentPage > 1)
            {
                LoadDesk(_iCurrentPage - 1);
            }
        }
        private void bntNext_Click(object sender, EventArgs e)
        {
            GoNext();
        }
        private void GoNext()
        {
            int iOffset = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            decimal de = _iTotalRecord / iOffset;
            //decimal _iTotalPage=Math.Round(de,MidpointRounding.AwayFromZero);
            decimal _iTotalPage = Math.Ceiling(de);
            if (_iCurrentPage < _iTotalPage)
            {
                LoadDesk(_iCurrentPage + 1);
            }
        }
        #region Load Desk
        public void LoadDesk(int page)
        {
            data_Desk.Rows.Clear();
            DataTable dtDesk = new DataTable();
            int totalRec = 0;

            desk.DeskId = _iDeskId.ToString();
            desk.DeskNo = txtDeskNo.Text;
            desk.DeskLocation = cboLocation.SelectedValue.ToString();
            desk.Description = rtxtDescription.Text;
            desk.Status = cboStatus.SelectedValue.ToString();
            desk.NoOfSeat = txtDeskSeat.Text;
            dtDesk = deskBLL.GetLists(desk, page, out totalRec);

            if (dtDesk != null)
            {
                int i = 0;
                foreach (DataRow r in dtDesk.Rows)
                {
                    data_Desk.Rows.Add();
                    data_Desk.Rows[i].Cells["STT"].Value = i + 1;
                    data_Desk.Rows[i].Cells["DesKId"].Value = r["DesKId"];
                    data_Desk.Rows[i].Cells["DeskNo"].Value = r["DesKNo"];
                    data_Desk.Rows[i].Cells["Description"].Value = r["Description"];
                    data_Desk.Rows[i].Cells["NoOfSeat"].Value = r["NoOfSeat"];
                    data_Desk.Rows[i].Cells["DeskLocationId"].Value = r["DeskLocation"];
                    data_Desk.Rows[i].Cells["StatusId"].Value = r["Status"];
                    data_Desk.Rows[i].Cells["IsUsing"].Value = r["IsUsing"];
                    //get Name of status
                    CommonCode cm = new CommonCode();
                    cm.CommonTypeId = "DeskType";
                    cm.CommonId = r["Status"].ToString();
                    DataTable dt1 = new DataTable();
                    dt1 = deskBLL.GetStatusName(cm);
                    data_Desk.Rows[i].Cells["Status"].Value = dt1.Rows[0]["StrValue1"].ToString();

                    //get Name of DeskLocation
                    CommonCode cm1 = new CommonCode();
                    cm1.CommonTypeId = "DeskLocation";
                    cm1.CommonId = r["DeskLocation"].ToString();
                    DataTable dt2 = new DataTable();
                    dt2 = deskBLL.GetStatusName(cm1);
                    data_Desk.Rows[i].Cells["DeskLocation"].Value = dt2.Rows[0]["StrValue1"].ToString();

                    DataGridViewRow row = data_Desk.Rows[i];
                    row.Height = 40;

                    i++;
                }
            }
            else {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NotFoundData"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
            this.linkNumber.Text = page.ToString();
            _iTotalRecord = totalRec;
            _iCurrentPage = page;
           // gShowDesk.Text = Common.clsLanguages.GetResource("TotalDeskFound") + " " + totalRec;
        }
        #endregion

        private void data_Desk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_Desk.Rows.Count <= 0) return;
            if (e.RowIndex >= 0)
            {
                _iDeskId = int.Parse(data_Desk.Rows[e.RowIndex].Cells["DesKId"].Value.ToString());
                txtDeskNo.Text = data_Desk.Rows[e.RowIndex].Cells["DeskNo"].Value.ToString();
                //txtDeskLocation.Text = data_Desk.Rows[e.RowIndex].Cells["DeskLocation"].Value.ToString();
                cboLocation.SelectedValue = data_Desk.Rows[e.RowIndex].Cells["DeskLocationId"].Value.ToString();
                rtxtDescription.Text = data_Desk.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                txtDeskSeat.Text = data_Desk.Rows[e.RowIndex].Cells["NoOfSeat"].Value.ToString();
                cboStatus.SelectedValue = data_Desk.Rows[e.RowIndex].Cells["StatusId"].Value.ToString();
                if (e.ColumnIndex == 9)
                {
                    if (int.Parse(data_Desk.Rows[e.RowIndex].Cells["IsUsing"].Value.ToString()) == 1) {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("TableFull_CanNotDel"),
                                                Common.clsLanguages.GetResource("Information"),
                                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                    //AreYouSureWanToDeleteDesk
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AreYouSureWanToDeleteDesk") + " " + txtDeskNo.Text +" ?",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {

                        data_Desk.Rows.RemoveAt(e.RowIndex);
                        desk.DeskId = _iDeskId.ToString();
                        deskBLL = new DeskBLL();
                        deskBLL.Delete(desk);
                        if (deskBLL.Res)
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DeleteSuccess"),
                                            Common.clsLanguages.GetResource("Information"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                            Reset();
                            LoadDesk(1);
                        }
                    }
                }
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset() {
            _iDeskId = 0;
            txtDeskNo.Clear();
            cboLocation.SelectedIndex = 0;
            txtDeskSeat.Clear();
            rtxtDescription.Clear();
            cboStatus.SelectedIndex = 0;
        }

        private void txtDeskNo_TextChanged(object sender, EventArgs e)
        {
            if (txtDeskNo.TextLength > 10) {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DeskNoTextLenghtError"),
                                        Common.clsLanguages.GetResource("Error"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
        }

        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {
            if (rtxtDescription.TextLength > 512)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DeskDescriptionTextLenghtError"),
                                        Common.clsLanguages.GetResource("Error"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
        }

        private void txtDeskSeat_TextChanged(object sender, EventArgs e)
        {
            if (txtDeskSeat.TextLength > 11)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NoOfSeatTextLenghtError"),
                                        Common.clsLanguages.GetResource("Error"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
        }

    }
}
