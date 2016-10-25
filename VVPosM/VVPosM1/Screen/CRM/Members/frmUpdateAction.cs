using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using VVPosM1.BusinessLayer.BLLCRM;
using VVPosM1.Screen.CRM.Members;
namespace VVPosM1.Screen.CRM.Members
{
    public partial class frmUpdateAction : Form
    {
        ActionsBLL actionsBLL;
        MemberBLL memberBLL;
        ActionStatusBLL actionstatusBLL;

        CategoryActionsBLL categoryactionsBLL;
        EmployeeBLL employeeBLL;
        PriorityBLL priorityBLL;

        private static string staticmemberId;


        /// <summary>
        /// Blag save value to define form is add or edit
        /// if true is add
        /// if false is edit
        /// </summary>
        private static bool blag = frmManageActions.pStatusAddNew;

        /// <summary>
        /// Setting color for controls
        /// </summary>
        private void SettingControl()
        {
            //setting background for form
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            //setting title
            //this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLOR);
            //gbInformationSearch          
            this.gbInformation.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);

            this.lblCustomID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            //   this.txtCustomID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.cbBCustomID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblActionName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtActionName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblActionContent.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtActionContent.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblActionStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbbActionStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblCategoryActionID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbBCategoryAction.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            //this.lblUserActionNext.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            //this.cbBUserActionNext.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblDeadLine.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.daTDeadLine.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblCreatorID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            //this.cbbCreator.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            //  this.chbFinishStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            //this.lblUserActionID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            //this.cbBUserActionID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            //   this.lblFinishDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            //   this.daTFinishDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblPriority.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbBPriority.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            //this.btnAdd.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            //this.btnEdit.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnReset.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            //this.btnDelete.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            //this.btnExit.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnSave.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);

        }

        /// <summary>
        /// Set language for form
        /// </summary>
        private void SetUIChanges()
        {
            if (staticmemberId == null)
            {
                //Tiêu đề form thêm mới
                this.Text = Common.clsLanguages.GetResource("CRM578");
            }
            else
            {
                //Tiêu đề form cập nhật
                this.Text = Common.clsLanguages.GetResource("CRM578");
            }
            gbInformation.Text = Common.clsLanguages.GetResource("CRM127");
         
            lblCustomID.Text = Common.clsLanguages.GetResource("CRM568");
            lblActionName.Text = Common.clsLanguages.GetResource("CRM563");

            lblActionContent.Text = Common.clsLanguages.GetResource("CRM199");
            lblActionStatus.Text = Common.clsLanguages.GetResource("CRM569");
            lblCategoryActionID.Text = Common.clsLanguages.GetResource("CRM565");
            lblDeadLine.Text = Common.clsLanguages.GetResource("CRM593");
            lblCreatorID.Text = Common.clsLanguages.GetResource("CRM168");
            lblPriority.Text = Common.clsLanguages.GetResource("CRM567");
            lblCreatorID1.Text = Common.clsLanguages.GetResource("CRM168");
            lblUpdaterID1.Text = Common.clsLanguages.GetResource("CRM544");
            lblFinishedDate1.Text = Common.clsLanguages.GetResource("CRM594");
            btnReset.Text = Common.clsLanguages.GetResource("CRM134");
            btnSave.Text = Common.clsLanguages.GetResource("CRM161");
            //cbBPriority.SelectedIndex = 2;
            if (!Program.lstRole.Contains("admin")) btnSave.Visible = false;

        }

        public frmUpdateAction()
        {
            InitializeComponent();
            SettingControl();
        }

        private void CreateObject()
        {
            actionsBLL = new ActionsBLL();
            memberBLL = new MemberBLL();
            actionstatusBLL = new ActionStatusBLL();
            categoryactionsBLL = new CategoryActionsBLL();
            employeeBLL = new EmployeeBLL();
            priorityBLL = new PriorityBLL();

        }

        /// <summary>
        /// Load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUpdateAction_Load(object sender, EventArgs e)
        {
            try
            {
                //Tạo đối tượng
                CreateObject();
                //Load dữ liệu
                LoadData();
                //Thiết lập các control
                SetUIChanges();
                blag = frmManageActions.pStatusAddNew;
            }
            catch (Exception)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM292"),
                                               Common.clsLanguages.GetResource("CRM12"),
                                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
        }

        /// <summary>
        /// Event raise when user click save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                Entities.Actions actions = new Entities.Actions();
                if (!blag) //Edit => Gán mã hoạt động bằng biến stacticmemberID truyền bên form quản trị qua
                {
                    actions.ActionsID = staticmemberId;
                }
                /*else
                {
                    
                        string strActionsID = "HD" + DateTime.Now.ToString("yyyyMMddHmmss");
                        int IdIsExist = actionsBLL.ActionsIdExist(strActionsID);
                        int increment = 0;
                        while(IdIsExist != 0)
                        {
                            if(IdIsExist == -1 || increment > 10000) // error or repeat more than 10.000 times
                                return;
                            strActionsID = "HD" + DateTime.Now.AddSeconds(++increment).ToString("yyyyMMddHmmss");
                            IdIsExist = actionsBLL.ActionsIdExist(strActionsID);
                        }
                        actions.ActionsID = strActionsID;
                }
                 * */
                //Ngày tạo
                //DateTime dtNow = new DateTime();
                //dtNow = DateTime.Today;
                actions.CreatedDate = DateTime.Now;
                if (cbBCustomID.SelectedValue != null)
                {
                    actions.CustomID.MemberId = cbBCustomID.SelectedValue.ToString();
                }
                else
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRMSelectCustomerError"),
                                    Common.clsLanguages.GetResource("CRM11"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
                //}
                //Chủ đề
                if (string.IsNullOrEmpty(txtActionName.Text.Trim()))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM575"),
                                    Common.clsLanguages.GetResource("CRM11"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
                else
                {
                    actions.ActionName = txtActionName.Text.Trim();
                }
                //Nội dung
                actions.BriefContent = txtActionContent.Text.Trim();
                //Trạng thái
                actions.Status.ActionStatusID = cbbActionStatus.SelectedValue.ToString();
                //Phân loại
                actions.CategoryID.CategoryActionID = cbBCategoryAction.SelectedValue.ToString();
                //Người xử lý tiếp theo         
                //if (!string.IsNullOrEmpty(cbBUserActionNext.SelectedValue.ToString()))
                //{
                //    actions.UserActionNext = cbBUserActionNext.SelectedValue.ToString();
                //}
                //Ký hạn xử lý
                actions.DeadLine = daTDeadLine.Value;

                //Người tạo
                actions.CreatorID = Program.employee1;
                //cbbCreator.SelectedValue.ToString();
                //Đã kết thúc hoạt động
                //if (chbFinishStatus.Checked)
                //{
                //    actions.FinishStatus = 1;
                //}
                //Người xử lý
                //actions.UserActionID.EmployeeId = cbBUserActionID.SelectedValue.ToString();
                //Hạn hoàn thành "Hiện tại y/c xóa nhưng thấy ko nên xóa, nên để biết hạn hoàn thành chung"
                //  actions.FinishDate = daTFinishDate.Value;
                actions.FinishedDate = DateTime.Now;

                //Mức độ ưu tiên
                actions.Priority.PriorityID = cbBPriority.SelectedValue.ToString();
                //Ngày cập nhật
                actions.UpdatedDate = DateTime.Now;

                //If is add
                if (blag)
                {
                    actionsBLL.Add(actions);
                }
                else //If is edit
                {
                    actionsBLL.Edit(actions);
                }
                //int i = actionsBLL.Add_New(actions);
                if (string.IsNullOrEmpty(actionsBLL.ErrorString))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM308"),
                           Common.clsLanguages.GetResource("CRM11"),
                           Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                           Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    this.Close();
                }
                else
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM219"),
                         Common.clsLanguages.GetResource("CRM11"),
                         Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                         Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }

                this.Close();
            }
            catch (Exception excep)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM292"),
                                               Common.clsLanguages.GetResource("CRM12"),
                                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
            //if (string.IsNullOrEmpty(txtActionContent.Text) && string.IsNullOrEmpty(txtActionName.Text) && string.IsNullOrEmpty(txtActionsID.Text))
            //{
            //    this.Close();
            //}
            //else
            //{
            //    if (!Program.lstRole.Contains("admin"))
            //    {
            //        this.Close();
            //    }
            //    else if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM588"), Common.clsLanguages.GetResource("CRM589")) == DialogResult.Yes)
            //    {
            //        this.Close();
            //        LoadData();
            //    }
            //}
        }
       

        /// <summary>
        /// Set enable for text on form
        /// </summary>
        /// <param name="boolean"></param>
        private void SetEnable(bool boolean)
        {
          
            cbBCustomID.Enabled = boolean;
        }

       

        /// <summary>
        /// Set hide or show for button
        /// </summary>
        /// <param name="boolean"></param>
        private void SetVisible(bool boolean)
        {
            this.btnSave.Visible = !boolean;
            this.btnReset.Visible = !boolean;
        }

        //Nhận biến mã hoạt động bên frmManageAction truyền qua
        public void WriteData(string pActionsID)
        {
            staticmemberId = pActionsID;
        }

        //Load dữ liện lên form
        public void LoadData()
        {

            #region    ComboBox  load member
            DataTable dt = new DataTable();
            dt = memberBLL.GetListNameOrCompany();
            if (dt != null)
            {
                cbBCustomID.DataSource = dt;
                cbBCustomID.DisplayMember = dt.Columns["MemberName"].ToString();
                cbBCustomID.ValueMember = dt.Columns["MemberId"].ToString();
            }

            #endregion End load member

            #region ComboBox cbb CategoryActions
            DataTable dtCategory = new DataTable();
            dtCategory = categoryactionsBLL.GetLists();
            if (dtCategory != null)
            {
                this.cbBCategoryAction.DataSource = dtCategory;
                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                {
                    this.cbBCategoryAction.DisplayMember = dtCategory.Columns["CategoryActionName"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                {
                    this.cbBCategoryAction.DisplayMember = dtCategory.Columns["CategoryActionName3"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                {
                    this.cbBCategoryAction.DisplayMember = dtCategory.Columns["CategoryActionName2"].ToString();
                }
                this.cbBCategoryAction.ValueMember = dtCategory.Columns["CategoryActionID"].ToString();
            }

            #endregion End CategoryAction

            #region ComboBox ActionStatus
            DataTable dtActions = new DataTable();
            dtActions = actionstatusBLL.GetLists();
            if (dtActions != null)
            {
                this.cbbActionStatus.DataSource = dtActions;
                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                {
                    this.cbbActionStatus.DisplayMember = dtActions.Columns["ActionName"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                {
                    this.cbbActionStatus.DisplayMember = dtActions.Columns["ActionName3"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                {
                    this.cbbActionStatus.DisplayMember = dtActions.Columns["ActionName2"].ToString();
                }
                this.cbbActionStatus.ValueMember = dtActions.Columns["ActionStatusID"].ToString();
            }

            #endregion End ActionStatus

            # region CoboBox data for cbbCreator
            //DataTable dtEmployee = new DataTable();
            //dtEmployee = employeeBLL.GetLists();
            //if (dtEmployee != null)
            //{
            //    this.cbbCreator.DataSource = dtEmployee;
            //    cbbCreator.DisplayMember = "EmployeeName";
            //    cbbCreator.ValueMember = "EmployeeId";
            //}
            #endregion End ComboBox Employee

            # region CoboBox data for cbBUserActionID
            //DataTable dtEmployee2 = new DataTable();
            //dtEmployee2 = employeeBLL.GetLists();
            //if (dtEmployee2 != null)
            //{
            //    this.cbBUserActionID.DataSource = dtEmployee2;
            //    cbBUserActionID.DisplayMember = "EmployeeName";
            //    cbBUserActionID.ValueMember = "EmployeeId";

            //}
            #endregion End ComboBox cbBUserActionID

            # region CoboBox data for cbBUserActionNext
            //DataTable dtEmployee3 = new DataTable();
            //dtEmployee3 = employeeBLL.GetLists();
            //if (dtEmployee3 != null)
            //{
            //    this.cbBUserActionNext.DataSource = dtEmployee3;

            //    DataRow row = dtEmployee3.NewRow();
            //    row["EmployeeName"] = "";
            //    dtEmployee3.Rows.InsertAt(row, 0);
            //    cbBUserActionNext.SelectedIndex = 0;

            //    cbBUserActionNext.DisplayMember = "EmployeeName";
            //    cbBUserActionNext.ValueMember = "EmployeeId";


            //}
            #endregion End ComboBox  cbBUserActionNext

            # region CoboBox data for  cbBPriority
            DataTable dtPriority = new DataTable();
            dtPriority = priorityBLL.GetLists();
            if (dtPriority != null)
            {
                this.cbBPriority.DataSource = dtPriority;
                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                {
                    this.cbBPriority.DisplayMember = dtPriority.Columns["PriorityName"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                {
                    this.cbBPriority.DisplayMember = dtPriority.Columns["PriorityName3"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                {
                    this.cbBPriority.DisplayMember = dtPriority.Columns["PriorityName2"].ToString();
                }
                this.cbBPriority.ValueMember = dtPriority.Columns["PriorityID"].ToString();

            }
            #endregion End ComboBox  cbBUserActionNext

            if (string.IsNullOrEmpty(staticmemberId))
            {
                SetEnable(true);
                //Người tạo, người xử lý mặc định là user đăng nhập
                this.lblCreatorID.Text = Program.employee1.EmployeeName;
                //this.cbbCreator.Enabled = false;
                //this.cbBUserActionID.SelectedValue = Program.employee.EmployeeId;
                //this.cbBUserActionNext.SelectedValue = Program.employee.EmployeeId;

                //Bật cờ đánh dấu chế độ thêm mới
                //blag = true;
                this.daTDeadLine.Value = DateTime.Now.AddMonths(1);
            }
            else
            {
                //blag = false;
                Entities.Actions actions = new Entities.Actions();
                actions = actionsBLL.GetById(staticmemberId);

                //  this.txtCustomID.Text = actions.CustomID.MemberId;
                this.cbBCustomID.SelectedValue = actions.CustomID.MemberId;
                this.txtActionName.Text = actions.ActionName;

                this.txtActionContent.Text = System.Text.RegularExpressions.Regex.Replace(actions.BriefContent, "\n", "\r\n");                
                this.cbbActionStatus.SelectedValue = actions.Status.ActionStatusID;
                this.cbBCategoryAction.SelectedValue = actions.CategoryID.CategoryActionID;
               
                this.daTDeadLine.Value = DateTime.Parse(actions.DeadLine.ToString());
                this.lblFinishedDate.Text = actions.FinishedDate.ToString();

                this.cbBPriority.SelectedValue = actions.Priority.PriorityID;
                this.lblCreatorID.Text = actions.CreatorID.EmployeeName;
                this.lblUpdaterID.Text = actions.UpdaterID.EmployeeName;
                //Set trạng thái không hiển thị
                SetEnable(false);
            }

        }



        //Thoát form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Reset lại mã chuyền vào là null
        private void frmUpdateAction_FormClosed(object sender, FormClosedEventArgs e)
        {
            staticmemberId = null;
        }

    }
}
