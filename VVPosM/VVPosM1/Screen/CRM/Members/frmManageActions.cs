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
    public partial class frmManageActions : Form
    {
        #region Variable
        public string key = String.Empty;
        ActionsBLL actionsBLL = new ActionsBLL();
        MemberBLL memberBLL = new MemberBLL();
        ActionStatusBLL actionstatusBLL = new ActionStatusBLL();

        CategoryActionsBLL categoryactionsBLL = new CategoryActionsBLL();
        EmployeeBLL employeeBLL = new EmployeeBLL();
        PriorityBLL priorityBLL = new PriorityBLL();

        private int statusSuccess = 5;
        private string CustomerIdFromLoad = null;
        //delegate send data to form update
        public delegate void getData(string pActionsID);
        #endregion

        #region Contructor
        public frmManageActions()
        {
            InitializeComponent();
         //   SettingControl();
        }
        public frmManageActions(string strkey, string cusID)
        {
            InitializeComponent();
        //    SettingControl();
            key = strkey;
            CustomerIdFromLoad = cusID;
        }
        #endregion

        /// <summary>
        /// Setting color for controls
        /// </summary>
        private void SettingControl()
        {
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            //setting title
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLOR);
            //gbInformationSearch
            this.gbInformationSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);

            this.lblActionName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.cbbActionStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblCategoryActionID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbBCategoryAction.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            lblActionStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            //Kỳ hạn
            lblDeadLine.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR); 
            lblPriority.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR); 

            this.daTCreateDate1.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.daTCreateDate1.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblPriority.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbBPriority.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.btnSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnAddNew.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnEdit.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnDelete.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnViewDetail.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);

            this.dgvManagerAction.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.gbInformation.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);

        }
     
        /// <summary>
        /// Set change text for controls
        /// </summary>
        public void SetUIChanges()
        {

            lblTitle.Text = Common.clsLanguages.GetResource("CRM564");
            ////gbInformationSearch
            gbInformationSearch.Text = Common.clsLanguages.GetResource("CRM101");
            gbInformation.Text = Common.clsLanguages.GetResource("CRM157");

            btnSearch.Text = Common.clsLanguages.GetResource("CRM24");
            btnAddNew.Text = Common.clsLanguages.GetResource("CRM109");
            btnEdit.Text = Common.clsLanguages.GetResource("CRM188");
            btnDelete.Text = Common.clsLanguages.GetResource("CRM110");
            btnViewDetail.Text = Common.clsLanguages.GetResource("CRM597");

            dgvManagerAction.Columns["ActionsID"].HeaderText = Common.clsLanguages.GetResource("CRM112");
            dgvManagerAction.Columns["ActionName"].HeaderText = Common.clsLanguages.GetResource("CRM563");
            dgvManagerAction.Columns["MemberName"].HeaderText = Common.clsLanguages.GetResource("CRM568");
            dgvManagerAction.Columns["ActionNameStatus"].HeaderText = Common.clsLanguages.GetResource("CRM569");
            //
            dgvManagerAction.Columns["BriefContent"].HeaderText = Common.clsLanguages.GetResource("CRM368");
            dgvManagerAction.Columns["CreatorName"].HeaderText = Common.clsLanguages.GetResource("CRM168");
            dgvManagerAction.Columns["UpdaterName"].HeaderText = Common.clsLanguages.GetResource("CRM544");
            dgvManagerAction.Columns["CreatedDate"].HeaderText = Common.clsLanguages.GetResource("CRM121");
            dgvManagerAction.Columns["UpdatedDate"].HeaderText = Common.clsLanguages.GetResource("CRM122");

            dgvManagerAction.Columns["FinishedDate"].HeaderText = Common.clsLanguages.GetResource("CRM570");
            //dgvManagerAction.Columns["EmployeeNameNext"].HeaderText = Common.clsLanguages.GetResource("CRM573");
            dgvManagerAction.Columns["DeadLine"].HeaderText = Common.clsLanguages.GetResource("CRM571");
            dgvManagerAction.Columns["CategoryActionName"].HeaderText = Common.clsLanguages.GetResource("CRM565");
            dgvManagerAction.Columns["PriorityName"].HeaderText = Common.clsLanguages.GetResource("CRM567");
            dgvManagerAction.Columns["followUp"].HeaderText = Common.clsLanguages.GetResource("CRMFollowUp");

            //Thêm vào các lable mới

            lblActionName.Text = Common.clsLanguages.GetResource("CRMSearchTextbox");          
            lblActionStatus.Text = Common.clsLanguages.GetResource("CRM569");
            lblCategoryActionID.Text = Common.clsLanguages.GetResource("CRM565");

            lblDeadLine.Text = Common.clsLanguages.GetResource("CRM571");   
            //lblUserActionID.Text = Common.clsLanguages.GetResource("CRM566");
            lblPriority.Text = Common.clsLanguages.GetResource("CRM567");
            //lblUserActionNext.Text = Common.clsLanguages.GetResource("CRM573");

            //Linh 08-12-2014
            string employeeTypeId = Program.employee1.EmployeeType.EmployeeTypeId;
            daTCreateDate2.Value = DateTime.Now;

            if(Program.lstRole.Contains("admin"))
            {
                btnDelete.Enabled = true;
            }

            //LoadData();
            //if (dgvManagerAction.RowCount > 0)
            //{
            //    SearchData();
            //}
        }
        
        /// <summary>
        /// Event raise when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmManageActions_Load(object sender, EventArgs e)
        {
            try
            {
                SetUIChanges();
                LoadData();

                if (key != String.Empty || !string.IsNullOrEmpty(CustomerIdFromLoad))
                {
                    txtKeyWord.Text = key;
                    SearchData();
                    CustomerIdFromLoad = null;
    
                }
            }
            catch (Exception)
            {
                string code = System.Runtime.InteropServices.Marshal.GetExceptionCode().ToString();
                if (code == "-532462766")
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM292"),
                              Common.clsLanguages.GetResource("CRM11"),
                              Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                              Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                }
                return;
            }
        }

        /// <summary>
        /// Load data for form
        /// </summary>
        private void LoadData()
        {

            #region ComboBox cbb CategoryActions
            DataTable dtCategory = new DataTable();
            dtCategory = categoryactionsBLL.GetLists();
            DataRow row1 = dtCategory.NewRow();
            row1["CategoryActionID"] = "";
            row1["CategoryActionName"] = Common.clsLanguages.GetResource("CRMSelectAll");
            row1["CategoryActionName3"] = Common.clsLanguages.GetResource("CRMSelectAll");
            row1["CategoryActionName2"] = Common.clsLanguages.GetResource("CRMSelectAll");
            dtCategory.Rows.Add(row1);
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

                cbBCategoryAction.SelectedIndex = dtCategory.Rows.IndexOf(row1);
            }

            #endregion End CategoryAction

            #region ComboBox ActionStatus
            DataTable dtActions = new DataTable();
            dtActions = actionstatusBLL.GetLists();
            DataRow row2 = dtActions.NewRow();
            row2["ActionStatusID"] = "";
            row2["ActionName2"] = Common.clsLanguages.GetResource("CRMSelectAll");
            row2["ActionName3"] = Common.clsLanguages.GetResource("CRMSelectAll");
            row2["ActionName"] = Common.clsLanguages.GetResource("CRMSelectAll");
            dtActions.Rows.Add(row2);
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
                cbbActionStatus.SelectedIndex = dtActions.Rows.IndexOf(row2);
            }

            #endregion End ActionStatus

            # region CoboBox data for cbBUserActionNext
            //DataTable dtEmployee2 = new DataTable();
            //dtEmployee2 = employeeBLL.GetLists();
            //if (dtEmployee2 != null)
            //{
            //    this.cbBUserActionNext.DataSource = dtEmployee2;

            //    DataRow row = dtEmployee2.NewRow();
            //    row["EmployeeName"] = "";
            //    dtEmployee2.Rows.InsertAt(row, 0);
            //    cbBUserActionNext.SelectedIndex = 0;

            //    cbBUserActionNext.DisplayMember = "EmployeeName";
            //    cbBUserActionNext.ValueMember = "EmployeeId";

            //}
            #endregion End ComboBox cbBUserActionID

            # region CoboBox data for  cbBPriority
            DataTable dtPriority = new DataTable();
            dtPriority = priorityBLL.GetLists();
            DataRow row3 = dtPriority.NewRow();
            row3["PriorityID"] = "";
            row3["PriorityName"] = Common.clsLanguages.GetResource("CRMSelectAll");
            row3["PriorityName3"] = Common.clsLanguages.GetResource("CRMSelectAll");
            row3["PriorityName2"] = Common.clsLanguages.GetResource("CRMSelectAll");
            dtPriority.Rows.Add(row3);
            if (dtPriority != null)            {
                
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

                cbBPriority.SelectedIndex = dtPriority.Rows.IndexOf(row3);

            }
            #endregion End ComboBox  cbBUserActionNext
            
            //người xữ lý tiếp theo Next2
            # region CoboBox data for cbBUserActionNext2
            //DataTable dtEmployee3 = new DataTable();
            //dtEmployee3 = employeeBLL.GetLists();
            //if (dtEmployee3 != null)
            //{
            //    this.cbBUserActionNext2.DataSource = dtEmployee3;

            //    DataRow row = dtEmployee3.NewRow();
            //    row["EmployeeName"] = "";
            //    dtEmployee3.Rows.InsertAt(row, 0);
            //    cbBUserActionNext2.SelectedIndex = 0;

            //    cbBUserActionNext2.DisplayMember = "EmployeeName";
            //    cbBUserActionNext2.ValueMember = "EmployeeId";

            //}
            #endregion End ComboBox cbBUserActionID

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(txtKeyWord.Text.Trim()))
            {
                param.Add("KeyWord", txtKeyWord.Text.Trim());
            }
            if (!string.IsNullOrEmpty(CustomerIdFromLoad))
            {
                param.Add("CustomID", CustomerIdFromLoad);
            }

            if (cbBCategoryAction.SelectedIndex >= 0)
            {
                if (!string.IsNullOrEmpty(cbBCategoryAction.SelectedValue.ToString()))
                {
                    param.Add("CategoryID", cbBCategoryAction.SelectedValue.ToString());
                }
            }
            
            if (cbBPriority.SelectedIndex >= 0)
            {
                if (!string.IsNullOrEmpty(cbBPriority.SelectedValue.ToString()))
                {
                    param.Add("Priority", cbBPriority.SelectedValue.ToString());
                }
            }

            if (cbbActionStatus.SelectedIndex >= 0 && !string.IsNullOrEmpty(cbbActionStatus.SelectedValue.ToString().Trim()))
            {
                param.Add("Status", cbbActionStatus.SelectedValue.ToString().Trim());
            }

            string fromCreateDate = daTCreateDate1.Value.ToString("yyyy-MM-dd");
            string toCreateDate = daTCreateDate2.Value.ToString("yyyy-MM-dd");
            if (chkPeriod.Checked == true)
            {
                if (!fromCreateDate.Equals(DateTime.Now.ToString("yyyy-MM-dd")) || !fromCreateDate.Equals(DateTime.Now.ToString("yyyy-MM-dd")))
                {
                    param.Add("DeadLine", fromCreateDate + "@" + toCreateDate);
                }
            }

            this.dgvManagerAction.DataSource = actionsBLL.SearchInformation(param);
            dgvManagerAction.AutoGenerateColumns = false;

            ColorGrid();
        }
        
        //Biến lưu trạng thái thêm mới, default false tức là cập nhật
        public static bool pStatusAddNew = false;

        /// <summary>
        /// Event raise when user click button add new
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //Ghi nhận đây là trạng thái thêm mới
            pStatusAddNew = true;
            frmUpdateAction frm = new frmUpdateAction();
            frm.ShowDialog();
            btnSearch_Click(sender, e);
        }
     

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvManagerAction.SelectedRows.Count != 0)
                {
                    pStatusAddNew = false;

                    string pActionsID = this.dgvManagerAction.SelectedRows[0].Cells["ActionsId"].Value.ToString();
                    frmUpdateAction frmUpAction = new frmUpdateAction();
                    getData getDB = new getData(frmUpAction.WriteData);
                    getDB(pActionsID);
                    frmUpAction.ShowDialog();
                    //if (frmUpAction.DialogResult == DialogResult.OK)
                    //{
                    //    btnSearch_Click(sender, e);
                    //}
                    //Reload data
                    btnSearch_Click(sender, e);
                }
                else
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM369"),
                        Common.clsLanguages.GetResource("CRM11"),
                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (this.dgvManagerAction.SelectedRows.Count != 0)
            {

                string pActionsId = dgvManagerAction.SelectedRows[0].Cells["ActionsId"].Value.ToString();
                DialogResult r = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM374"),
                                    Common.clsLanguages.GetResource("CRM11"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
                if (r == DialogResult.Yes)
                {
                    actionsBLL.Delete(pActionsId);
                    btnSearch_Click(sender, e);
                }
            }
            else
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM369"),
                    Common.clsLanguages.GetResource("CRM11"),
                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyWord.Clear();
            //Reload on data
            frmManageActions_Load(sender, e);
        }

        private void dgvManagerAction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnViewDetail_Click(sender, e);
        }
           
        //Gửi email
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
        }

        //Xem lịch sử hoạt động của 
        public static string ppHActionsID;
        private void btnHistory_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSendEmail_Click_1(object sender, EventArgs e)
        {

        }

        private void chkPeriod_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPeriod.Checked == true)
            {
                daTCreateDate1.Enabled = true;
                daTCreateDate2.Enabled = true;
            }
            else
            {
                daTCreateDate1.Enabled = false;
                daTCreateDate2.Enabled = false;
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (dgvManagerAction.SelectedRows.Count > 0)
            {
                //pStatusAddNew = true;
                frmUpdateActionDetail frm = new frmUpdateActionDetail();
                frm.ActionID = dgvManagerAction.SelectedRows[0].Cells["ActionsId"].Value.ToString();
                frm.ShowDialog();
                btnSearch_Click(sender, e);
            }
        }

        public void ColorGrid()
        {
            if (dgvManagerAction.Rows.Count > 0)
            {
                Color[] cc = { 
                                 Color.AliceBlue, 
                                 System.Drawing.ColorTranslator.FromHtml("#EF4836"),
                                 System.Drawing.ColorTranslator.FromHtml("#D2527F"),
                                 System.Drawing.ColorTranslator.FromHtml("#F5D76E"),
                                 Color.White                             
                             };
                //foreach (DataGridViewRow row in dataGridView.Rows)
                //    if (Convert.ToInt32(row.Cells[7].Value) < Convert.ToInt32(row.Cells[10].Value))
                //    {
                //        row.DefaultCellStyle.BackColor = Color.Red;
                //    }
                for (int i = 0; i < dgvManagerAction.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvManagerAction.Rows[i];
                    
                    if (!string.IsNullOrEmpty(row.Cells["Priority"].Value.ToString()))
                    {                        
                        //if (aa > 7)
                        //{
                        //    row.DefaultCellStyle.BackColor = cc[0]; 
                        //}
                        //else
                        //{
                        int iStatus = int.Parse(row.Cells["Status"].Value.ToString());
                        int aa = int.Parse(row.Cells["Priority"].Value.ToString());
                        try
                        {
                            if (iStatus == statusSuccess)
                            {
                                row.DefaultCellStyle.BackColor = Color.Silver;
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = cc[aa];
                            }
                        }
                        catch(Exception)
                        {
                            switch(aa)
                            {
                                case 1: row.DefaultCellStyle.BackColor = Color.Red;break;
                                case 2: row.DefaultCellStyle.BackColor = Color.Pink;break;
                                case 3: row.DefaultCellStyle.BackColor = Color.Yellow;break;
                                case 4: row.DefaultCellStyle.BackColor = Color.White;break;
                            }
                        }
                            
                            //if (aa == 6)
                            //{
                            //    row.DefaultCellStyle.ForeColor = cc[0];
                            //}
                        //}
                    }

                }
            }
        }

        private void dgvManagerAction_Sorted(object sender, EventArgs e)
        {
            ColorGrid();
        }

        private void txtKeyWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) 13)
            {
                this.btnSearch_Click(sender, e);
            }
        }

        private void gbInformationSearch_Enter(object sender, EventArgs e)
        {
            SearchData();
        }

    }
}
