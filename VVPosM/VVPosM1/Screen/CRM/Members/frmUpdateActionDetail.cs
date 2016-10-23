using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using VVPosM1.BusinessLayer.BLLCRM;
namespace VVPosM1.Screen.CRM.Members
{
    public partial class frmUpdateActionDetail : Form
    {
        ActionsBLL actionsBLL;
        MemberBLL memberBLL;
        ActionStatusBLL actionstatusBLL;
        ActionDetailBLL actionDetailBLL;

        CategoryActionsBLL categoryactionsBLL;
        EmployeeBLL employeeBLL;
        PriorityBLL priorityBLL;
        public string ActionID;
        private bool refresh = false;
        private bool deadlineChanged = false;

        private string currentPIC = "";
        private string currentStatus = "";
        private string currentPriority = "";

        private DateTime currentDeadline = DateTime.Now.AddMonths(1);


        /// <summary>
        /// Blag save value to define form is add or edit
        /// if true is add
        /// if false is edit
        /// </summary>
        //private static bool blag = frmManageActions.pStatusAddNew;

        /// <summary>
        /// Setting color for controls
        /// </summary>
        private void SettingControl()
        {
            //setting background for form
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;

        }

        /// <summary>
        /// Set language for form
        /// </summary>
        private void SetUIChanges()
        {
                
            this.Text = Common.clsLanguages.GetResource("CRM578");

            gbInformation.Text = Common.clsLanguages.GetResource("CRM127");
            lblActionsID1.Text = Common.clsLanguages.GetResource("CRM112");
            //chBAutoID.Text = Common.clsLanguages.GetResource("CRM576");
            lblCustomName1.Text = Common.clsLanguages.GetResource("CRM568");
            lblActionName1.Text = Common.clsLanguages.GetResource("CRM198");

            lblBriefContent1.Text = Common.clsLanguages.GetResource("CRM599");
            lblActionStatus1.Text = Common.clsLanguages.GetResource("CRM569");
            lblCategoryActionID1.Text = Common.clsLanguages.GetResource("CRM565");
            lblDeadLine1.Text = Common.clsLanguages.GetResource("CRM593");            

            //lblUserActionID.Text = Common.clsLanguages.GetResource("CRM566");
            //  lblFinishDate.Text = Common.clsLanguages.GetResource("CRM570");
            lblPriority1.Text = Common.clsLanguages.GetResource("CRM567");
            //   chbFinishStatus.Text = Common.clsLanguages.GetResource("CRM577");
            //lblUserActionNext.Text = Common.clsLanguages.GetResource("CRM573");
            lblCreatorID1.Text = Common.clsLanguages.GetResource("CRM168");
            lblCreatedDate1.Text = Common.clsLanguages.GetResource("CRM121");
            //button set            
            //btnAdd.Text = Common.clsLanguages.GetResource("CRM109");
            // btnEdit.Text = Common.clsLanguages.GetResource("CRM188");
            btnReset.Text = Common.clsLanguages.GetResource("CRM134");
            //btnDelete.Text = Common.clsLanguages.GetResource("CRM110");
            //btnExit.Text = Common.clsLanguages.GetResource("CRM133");
            btnSave.Text = Common.clsLanguages.GetResource("CRM161");

            lblDetailContent1.Text = Common.clsLanguages.GetResource("CRM600");
            lblStatus1.Text = Common.clsLanguages.GetResource("CRM569");

            lblPIC1.Text = Common.clsLanguages.GetResource("CRM601");
            lblDetailPriority1.Text = Common.clsLanguages.GetResource("CRM567");


            dataGridView.Columns["STT"].HeaderText = Common.clsLanguages.GetResource("CRM71");
            //Content
            dataGridView.Columns["Content"].HeaderText = Common.clsLanguages.GetResource("CRM600");
            //PICName
            dataGridView.Columns["PICName"].HeaderText = Common.clsLanguages.GetResource("CRM601");
            //StatusName
            dataGridView.Columns["StatusName"].HeaderText = Common.clsLanguages.GetResource("CRM569");
            //PriorityName
            dataGridView.Columns["PriorityName"].HeaderText = Common.clsLanguages.GetResource("CRM567");
            //CreatorName
            dataGridView.Columns["CreatorName"].HeaderText = Common.clsLanguages.GetResource("CRM168");
            //CreatedDate
            dataGridView.Columns["CreatedDate"].HeaderText = Common.clsLanguages.GetResource("CRM121");

            lbNguoiPhuTrachTitle.Text = Common.clsLanguages.GetResource("CRM601");
            gbActionsInfo.Text = Common.clsLanguages.GetResource("CRMGroupActionInfo");

            cbbActionStatus.SelectedValue = currentStatus;
            cbbPIC.SelectedValue = currentPIC;
            cbBPriority.SelectedValue = currentPriority;
        }

        public frmUpdateActionDetail()
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
            actionDetailBLL = new ActionDetailBLL();

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
            }
            catch (Exception)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM292"),
                                               Common.clsLanguages.GetResource("CRM12"),
                                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
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
            if (!refresh)
            {
                try
                {
                    if (CheckSelectAndEmpty() == true)
                    {
                        string content = txtDetailContent.Text;
                        string newActionStatus = (string)((DataRowView)cbbActionStatus.Items[cbbActionStatus.SelectedIndex])[cbbActionStatus.DisplayMember.ToString()];
                        string newPriority = (string)((DataRowView)cbBPriority.Items[cbBPriority.SelectedIndex])[cbBPriority.DisplayMember.ToString()];
                        string newPIC = (string)((DataRowView)cbbPIC.Items[cbbPIC.SelectedIndex])[cbbPIC.DisplayMember.ToString()];

                        string space = "\n**************************\n";
                        if (!newActionStatus.Equals(lblActionStatusName.Text))
                        {
                            content += space + lblActionStatus1.Text.Trim() + ": " + lblActionStatusName.Text.Trim() + " --> " + newActionStatus.Trim() + "\n";
                            space = "";
                        }
                        if (!newPriority.Equals(lblProrityName.Text))
                        {
                            content += space + lblPriority1.Text.Trim() + ": " + lblProrityName.Text.Trim() + " --> " + newPriority.Trim() + "\n";
                            space = "";
                        }
                        if (!newPIC.Equals(lbNguoiPhuTrach.Text))
                        {
                            content += space + lbNguoiPhuTrachTitle.Text.Trim() + ": " + lbNguoiPhuTrach.Text.Trim() + " --> " + newPIC + "\n";
                            space = "";
                        }

                        if(deadlineChanged && !currentDeadline.Equals(dtDeadline.Value))
                        {
                            content += space + Common.clsLanguages.GetResource("CRMNewDeadline") + ": " + currentDeadline.ToString("yyyy-M-dd H:mm:ss") + " --> " + dtDeadline.Value.ToString("yyyy-M-dd H:mm:ss");
                            
                        }
                        if (!string.IsNullOrEmpty(content))
                        {
                            DialogResult result = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM227"),
                                                Common.clsLanguages.GetResource("CRM11"),
                                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
                            if (result == DialogResult.Yes)
                            {
                                Entities.Action_Detail ad = new Entities.Action_Detail();
                                ad.ActionsID = ActionID;
                                ad.Content = content;
                                ad.CreatorID.EmployeeId = Program.employee1.EmployeeId;
                                DataRowView emPIC = (DataRowView)cbbPIC.SelectedItem;
                                ad.PIC.EmployeeId = emPIC["EmployeeId"].ToString();
                                DataRowView pr = (DataRowView)cbBPriority.SelectedItem;
                                ad.Priority.PriorityID = pr["PriorityID"].ToString();
                                DataRowView ast = (DataRowView)cbbActionStatus.SelectedItem;
                                ad.Status.ActionStatusID = ast["ActionStatusID"].ToString();
                                if (deadlineChanged)
                                {
                                    string newDeadline = dtDeadline.Value.ToString("yyyy-M-dd H:mm:ss");
                                    actionDetailBLL.AddIncludeDeadline(ad, newDeadline);
                                }
                                else
                                {
                                    actionDetailBLL.Add(ad);
                                }
                                if (string.IsNullOrEmpty(actionDetailBLL.ErrorString))
                                {
                                    LoadDataMasterAndDetail();
                                    ColorGrid();
                                    deadlineChanged = false;
                                    currentDeadline = dtDeadline.Value;
                                }
                            }
                        }
                        else
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM100"),
                                                Common.clsLanguages.GetResource("CRM12"),
                                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                            return;
                        }
                    }
                    else
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM100"),
                                                Common.clsLanguages.GetResource("CRM12"),
                                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                }
                catch (Exception)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM292"),
                                                   Common.clsLanguages.GetResource("CRM12"),
                                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
            }
             
            refreshAction();
        }

        private void refreshAction()
        {
            this.refresh = false;
            btnSave.Text = Common.clsLanguages.GetResource("CRM161");

            txtDetailContent.Text = "";
            txtDetailContent.ReadOnly = false;
            cbbActionStatus.Enabled = true;
            cbbPIC.Enabled = true;
            cbBPriority.Enabled = true;
            cbbActionStatus.SelectedValue = currentStatus;
            cbbPIC.SelectedValue = currentPIC;
            cbBPriority.SelectedValue = currentPriority;
            dtDeadline.Value = currentDeadline;

            dtDeadline.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!currentStatus.Equals(cbbActionStatus.SelectedValue.ToString())
                || !currentPriority.Equals(cbBPriority.SelectedValue.ToString())
                || !currentPIC.Equals(cbbPIC.SelectedValue.ToString())
                || (txtDetailContent.Enabled && !string.IsNullOrEmpty(txtDetailContent.Text))
                || !currentDeadline.Equals(dtDeadline.Value))
            {
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM588"), Common.clsLanguages.GetResource("CRM589")) == DialogResult.Yes)
                {
                    this.Close();

                }
            }
            else
            {
                this.Close();
            }
        }


        //Load dữ liện lên form
        public void LoadData()
        {

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

            # region CoboBox data for cbbPIC
            DataTable dtEmployee = new DataTable();
            dtEmployee = employeeBLL.GetLists();
            if (dtEmployee != null)
            {
                this.cbbPIC.DataSource = dtEmployee;
                cbbPIC.DisplayMember = "EmployeeName";
                cbbPIC.ValueMember = "EmployeeId";
            }
            #endregion End cbbPIC Employee

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
            #endregion End ComboBox  cbBPriority

            #region lấy dữ liệu ActionDetail & Action
            if (!string.IsNullOrEmpty(ActionID))
            {
                DataSet ds = actionDetailBLL.GetInfoForActions(ActionID);
                if (string.IsNullOrEmpty(actionDetailBLL.ErrorString))
                {
                    if (ds != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0) // master
                        {
                            DataRow lastAction = actionDetailBLL.GetLast(ActionID);

                            lblActionsID.Text = ds.Tables[0].Rows[0]["ActionsID"].ToString();
                            lblActionName.Text = ds.Tables[0].Rows[0]["ActionName"].ToString();
                            lblBriefContent.Text = ds.Tables[0].Rows[0]["BriefContent"].ToString();
                            lblCreatedDate.Text = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                            dtDeadline.Value = DateTime.Parse(Convert.ToDateTime(ds.Tables[0].Rows[0]["DeadLine"].ToString()).ToString("yyy-M-dd H:mm:ss"));
                            currentDeadline = dtDeadline.Value;
                            //
                            Entities.Member mb = actionDetailBLL.GetMember(ds.Tables[0].Rows[0]["CustomID"].ToString());
                            lblCustomName.Text = actionDetailBLL.GetNameOrCompany(ds.Tables[0].Rows[0]["CustomID"].ToString());
                            //
                            Entities.ActionStatus aSt = actionDetailBLL.GetActionStatus(ds.Tables[0].Rows[0]["Status"].ToString());
                            if (aSt != null)
                            {
                                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                                {
                                    lblActionStatusName.Text = aSt.ActionName;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                                {
                                    lblActionStatusName.Text = aSt.ActionName3;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                                {
                                    lblActionStatusName.Text = aSt.ActionName2;
                                }

                                currentStatus = aSt.ActionStatusID;
                            }

                            /////
                            Entities.Priorities pr = actionDetailBLL.GetActionPriorities(ds.Tables[0].Rows[0]["Priority"].ToString());
                            if (pr != null)
                            {
                                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                                {
                                    lblProrityName.Text = pr.PriorityName;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                                {
                                    lblProrityName.Text = pr.PriorityName3;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                                {
                                    lblProrityName.Text = pr.PriorityName2;
                                }

                                currentPriority = pr.PriorityID;
                            }
                            if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["CreatorID"].ToString()))
                            {
                                Entities.Employees1 em = actionDetailBLL.GetEmployees(ds.Tables[0].Rows[0]["CreatorID"].ToString());
                                lblCreatorID.Text = em.EmployeeName;
                            }
                            if (lastAction != null)
                            {
                                Entities.Employees1 emp = employeeBLL.GetById(lastAction["PIC"].ToString());
                                if (emp != null)
                                {
                                    lbNguoiPhuTrach.Text = emp.EmployeeName;
                                    currentPIC = emp.EmployeeId;
                                }
                                else
                                {
                                    lbNguoiPhuTrach.Text = lblCreatorID.Text;
                                    currentPIC = ds.Tables[0].Rows[0]["CreatorID"].ToString();
                                }
                            }
                            else
                            {
                                lbNguoiPhuTrach.Text = lblCreatorID.Text;
                                currentPIC = ds.Tables[0].Rows[0]["CreatorID"].ToString();
                            }

                            Entities.CategoryActions cat = actionDetailBLL.GetCategoryActions(ds.Tables[0].Rows[0]["CategoryID"].ToString());
                            if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                            {
                                lblCategoryName.Text = cat.CategoryActionName;
                            }
                            else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                            {
                                lblCategoryName.Text = cat.CategoryActionName3;
                            }
                            else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                            {
                                lblCategoryName.Text = cat.CategoryActionName2;
                            }
                            if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["UpdaterID"].ToString()))
                            {
                                Entities.Employees1 em = actionDetailBLL.GetEmployees(ds.Tables[0].Rows[0]["UpdaterID"].ToString());
                            }
                        }

                        DisplayGridView(ds.Tables[1]);
                    }
                }
            }
            #endregion

            ColorGrid();
        }

        private void DisplayGridView(DataTable dt)
        {
            if (dt.Rows.Count > 0)//detail
            {
                int i = 0;
                dataGridView.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[i].Cells["STT"].Value = (i + 1).ToString();
                    dataGridView.Rows[i].Cells["ActionsID"].Value = dr["ActionID"];
                    dataGridView.Rows[i].Cells["id"].Value = dr["id"];
                    dataGridView.Rows[i].Cells["Content"].Value = dr["Content"];
                    dataGridView.Rows[i].Cells["PIC"].Value = dr["PIC"];
                    Entities.Employees1 emp = actionDetailBLL.GetEmployees(dr["PIC"].ToString());
                    if (emp != null)
                    {
                        dataGridView.Rows[i].Cells["PICName"].Value = emp.EmployeeName;
                    }
                    dataGridView.Rows[i].Cells["Status"].Value = dr["Status"];
                    Entities.ActionStatus ats = actionDetailBLL.GetActionStatus(dr["Status"].ToString());
                    if (ats != null)
                    {
                        if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                        {
                            dataGridView.Rows[i].Cells["StatusName"].Value = ats.ActionName;
                        }
                        else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                        {
                            dataGridView.Rows[i].Cells["StatusName"].Value = ats.ActionName3;
                        }
                        else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                        {
                            dataGridView.Rows[i].Cells["StatusName"].Value = ats.ActionName2;
                        }

                    }
                    dataGridView.Rows[i].Cells["Priority"].Value = dr["Priority"];

                    Entities.Priorities prr = actionDetailBLL.GetActionPriorities(dr["Priority"].ToString());                                //'
                    if (prr != null)
                    {
                        if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                        {
                            dataGridView.Rows[i].Cells["PriorityName"].Value = prr.PriorityName;
                        }
                        else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                        {
                            dataGridView.Rows[i].Cells["PriorityName"].Value = prr.PriorityName3;
                        }
                        else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                        {
                            dataGridView.Rows[i].Cells["PriorityName"].Value = prr.PriorityName2;
                        }
                    }
                    dataGridView.Rows[i].Cells["CreatorID"].Value = dr["CreatorID"];
                    emp = actionDetailBLL.GetEmployees(dr["CreatorID"].ToString());
                    if (emp != null)
                    {
                        dataGridView.Rows[i].Cells["CreatorName"].Value = emp.EmployeeName;
                    }
                    dataGridView.Rows[i].Cells["CreatedDate"].Value = dr["CreatedDate"];
                    i++;
                }

            }
        }

        private void LoadDataDetail()
        {
            DataTable dt = actionDetailBLL.GetListDetail(ActionID);
            DisplayGridView(dt);
        }

        private void LoadDataMasterAndDetail()
        {
            DataSet ds = actionDetailBLL.GetInfoForActions(ActionID);
            if (string.IsNullOrEmpty(actionDetailBLL.ErrorString))
            {
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0) // master
                    {
                        DataRow lastAction = ds.Tables[1].Rows[0];

                        lblActionsID.Text = ds.Tables[0].Rows[0]["ActionsID"].ToString();
                        lblActionName.Text = ds.Tables[0].Rows[0]["ActionName"].ToString();
                        lblBriefContent.Text = ds.Tables[0].Rows[0]["BriefContent"].ToString();
                        lblCreatedDate.Text = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                        //
                        Entities.Member mb = actionDetailBLL.GetMember(ds.Tables[0].Rows[0]["CustomID"].ToString());
                        lblCustomName.Text = mb.MemberName;

                        if (!currentPIC.Equals(lastAction["PIC"].ToString()))
                        {
                            Entities.Employees1 emp = employeeBLL.GetById(lastAction["PIC"].ToString());
                            if (emp != null)
                            {
                                lbNguoiPhuTrach.Text = emp.EmployeeName;
                                currentPIC = emp.EmployeeId;
                            }
                            else
                            {
                                lbNguoiPhuTrach.Text = lblCreatorID.Text; // if there is no PIC, PIC is creater
                            }
                        }

                        if (!currentStatus.Equals(lastAction["Status"].ToString()))
                        {
                            Entities.ActionStatus aSt = actionDetailBLL.GetActionStatus(lastAction["Status"].ToString());
                            if (aSt != null)
                            {
                                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                                {
                                    lblActionStatusName.Text = aSt.ActionName;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                                {
                                    lblActionStatusName.Text = aSt.ActionName3;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                                {
                                    lblActionStatusName.Text = aSt.ActionName2;
                                }

                                currentStatus = aSt.ActionStatusID;
                            }
                        }

                        if (!currentPriority.Equals(lastAction["Priority"].ToString()))
                        {
                            Entities.Priorities pr = actionDetailBLL.GetActionPriorities(lastAction["Priority"].ToString());
                            if (pr != null)
                            {
                                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                                {
                                    lblProrityName.Text = pr.PriorityName;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                                {
                                    lblProrityName.Text = pr.PriorityName3;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                                {
                                    lblProrityName.Text = pr.PriorityName2;
                                }

                                currentPriority = pr.PriorityID;
                            }
                        }
                    }
                    //string 
                    if (ds.Tables[1].Rows.Count > 0)//detail
                    {
                        int i = 0;
                        dataGridView.Rows.Clear();
                        foreach (DataRow dr in ds.Tables[1].Rows)
                        {
                            dataGridView.Rows.Add();
                            dataGridView.Rows[i].Cells["STT"].Value = (i + 1).ToString();
                            dataGridView.Rows[i].Cells["ActionsID"].Value = dr["ActionID"];
                            dataGridView.Rows[i].Cells["id"].Value = dr["id"];
                            dataGridView.Rows[i].Cells["Content"].Value = dr["Content"];
                            dataGridView.Rows[i].Cells["PIC"].Value = dr["PIC"];
                            Entities.Employees1 emp = actionDetailBLL.GetEmployees(dr["PIC"].ToString());
                            if (emp != null)
                            {
                                dataGridView.Rows[i].Cells["PICName"].Value = emp.EmployeeName;
                            }
                            dataGridView.Rows[i].Cells["Status"].Value = dr["Status"];
                            Entities.ActionStatus ats = actionDetailBLL.GetActionStatus(dr["Status"].ToString());
                            if (ats != null)
                            {
                                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                                {
                                    dataGridView.Rows[i].Cells["StatusName"].Value = ats.ActionName;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                                {
                                    dataGridView.Rows[i].Cells["StatusName"].Value = ats.ActionName3;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                                {
                                    dataGridView.Rows[i].Cells["StatusName"].Value = ats.ActionName2;
                                }
                                
                            }
                            dataGridView.Rows[i].Cells["Priority"].Value = dr["Priority"];

                            Entities.Priorities prr = actionDetailBLL.GetActionPriorities(dr["Priority"].ToString());                                //'
                            if (prr != null)
                            {
                                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                                {
                                    dataGridView.Rows[i].Cells["PriorityName"].Value = prr.PriorityName;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                                {
                                    dataGridView.Rows[i].Cells["PriorityName"].Value = prr.PriorityName3;
                                }
                                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                                {
                                    dataGridView.Rows[i].Cells["PriorityName"].Value = prr.PriorityName2;
                                }
                                
                            }
                            dataGridView.Rows[i].Cells["CreatorID"].Value = dr["CreatorID"];
                            emp = actionDetailBLL.GetEmployees(dr["CreatorID"].ToString());
                            if (emp != null)
                            {

                                dataGridView.Rows[i].Cells["CreatorName"].Value = emp.EmployeeName;
                            }
                            dataGridView.Rows[i].Cells["CreatedDate"].Value = dr["CreatedDate"];
                            i++;
                        }

                    }
                }
            }
        }

        private void ColorGrid()
        {
            if (dataGridView.Rows.Count > 0)
            {
                Color[] cc = { Color.AliceBlue, Color.Moccasin, Color.LavenderBlush, Color.PapayaWhip, Color.Linen, Color.PaleTurquoise, Color.LightCyan, Color.OldLace };
                //foreach (DataGridViewRow row in dataGridView.Rows)
                //    if (Convert.ToInt32(row.Cells[7].Value) < Convert.ToInt32(row.Cells[10].Value))
                //    {
                //        row.DefaultCellStyle.BackColor = Color.Red;
                //    }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView.Rows[i];
                    if (!string.IsNullOrEmpty(row.Cells["Status"].Value.ToString()))
                    {
                        int aa = int.Parse(row.Cells["Status"].Value.ToString());
                        if (aa > 7)
                        {
                            row.DefaultCellStyle.BackColor = cc[0];
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = cc[aa];
                        }
                    }

                }
            }
        }

        private bool CheckSTT_InGrid(string stt)
        {
            bool res = false;
            if (dataGridView.RowCount > 0)
            {
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    if (stt == dataGridView.Rows[i].Cells["STT"].ToString())
                    {
                        res = true;
                        break;
                    }
                }
            }

            return res;
        }

        private bool CheckSelectAndEmpty()
        {
            bool res = true;
            if (cbbActionStatus.SelectedIndex< 0)
            {
                res = false;
            }
            if (cbbPIC.SelectedIndex < 0)
            {
                res = false;
            }
            if (cbBPriority.SelectedIndex < 0)
            {
                res = false;
            }
            return res;
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtDetailContent.Text = System.Text.RegularExpressions.Regex.Replace(row.Cells["Content"].Value.ToString(), "\n", "\r\n");

                cbbPIC.SelectedValue = row.Cells["PIC"].Value.ToString();
                cbbActionStatus.SelectedValue = row.Cells["Status"].Value.ToString();
                cbBPriority.SelectedValue = row.Cells["Priority"].Value.ToString();

                btnSave.Text = Common.clsLanguages.GetResource("CRMRefresh");

                cbbActionStatus.Enabled = false;
                cbbPIC.Enabled = false;
                cbBPriority.Enabled = false;
                dtDeadline.Enabled = false;
                txtDetailContent.Enabled = false;
                refresh = true;
            }
        }

        private void dtDeadline_ValueChanged(object sender, EventArgs e)
        {
            deadlineChanged = true;
        }                
    }

}
