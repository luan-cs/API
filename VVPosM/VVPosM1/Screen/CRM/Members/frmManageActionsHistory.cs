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
    public partial class frmManageActionsHistory : Form
    {
        #region Variable
        ActionsHistoryBLL actionsBLL = new ActionsHistoryBLL();
        MemberBLL memberBLL = new MemberBLL();
        ActionStatusBLL actionstatusBLL = new ActionStatusBLL();

        CategoryActionsBLL categoryactionsBLL = new CategoryActionsBLL();
        EmployeeBLL employeeBLL = new EmployeeBLL();
        PriorityBLL priorityBLL = new PriorityBLL();

        //delegate send data to form update
        public delegate void getData(string pActionsID);
        #endregion

        #region Contructor
        public frmManageActionsHistory()
        {
            InitializeComponent();
            SettingControl();
        }
        #endregion

        /// <summary>
        /// Setting color for controls
        /// </summary>
        private void SettingControl()
        {
            this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            //setting title
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLOR);
            //gbInformationSearch
            this.gbInformationSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.lblFromDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.dtpFromDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblToDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.dtpToDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);         

            this.btnSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);          
            this.btnEdit.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnExit.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);          
           
            this.dgvManagerAction.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.gbInformation.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
        }
     
        /// <summary>
        /// Set change text for controls
        /// </summary>
        public void SetUIChanges()
        {

            lblTitle.Text = Common.clsLanguages.GetResource("CRM162");
            ////gbInformationSearch
            gbInformationSearch.Text = Common.clsLanguages.GetResource("CRM101");
            gbInformation.Text = Common.clsLanguages.GetResource("CRM204");

            btnSearch.Text = Common.clsLanguages.GetResource("CRM24");         
            btnEdit.Text = Common.clsLanguages.GetResource("CRM188");
            btnExit.Text = Common.clsLanguages.GetResource("CRM508");

            dgvManagerAction.Columns["ID"].HeaderText = "ID";
            dgvManagerAction.Columns["ActionsID"].HeaderText = Common.clsLanguages.GetResource("CRM112");
            dgvManagerAction.Columns["ActionName"].HeaderText = "Chủ đề";
            dgvManagerAction.Columns["MemberName"].HeaderText = "Khách hàng";
            dgvManagerAction.Columns["ActionNameStatus"].HeaderText = "Tình trạng";
            dgvManagerAction.Columns["EmployeeName"].HeaderText = "Người xử lý";
            dgvManagerAction.Columns["FinishDate"].HeaderText = "Hạn hoàn thành";
            dgvManagerAction.Columns["EmployeeNameNext"].HeaderText = "Người xử lý kế tiếp";
            dgvManagerAction.Columns["DeadLine"].HeaderText = "Kỳ hạn";
            dgvManagerAction.Columns["CategoryActionName"].HeaderText = "Phân loại";
            dgvManagerAction.Columns["PriorityName"].HeaderText = "Mức ưu tiên";
        }
        
        /// <summary>
        /// Event raise when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmManageActionsHistory_Load(object sender, EventArgs e)
        {
            try
            {
                SetUIChanges();
                LoadData();
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
            dgvManagerAction.DataSource = actionsBLL.GetListsHistoryID(frmManageActions.ppHActionsID);
            dgvManagerAction.AutoGenerateColumns = false;        
       
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
           
            string fromCreateDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
            string toCreateDate = dtpToDate.Value.ToString("yyyy-MM-dd");
            if (chBAll.Checked == false)
            {
                if (!fromCreateDate.Equals(DateTime.Now.ToString("yyyy-MM-dd")) || !fromCreateDate.Equals(DateTime.Now.ToString("yyyy-MM-dd")))
                {
                    param.Add("ActionsID", frmManageActions.ppHActionsID);
                    param.Add("UpdateDate", fromCreateDate + "@" + toCreateDate);
                }
            }
          else
            {
                if (!fromCreateDate.Equals(DateTime.Now.ToString("yyyy-MM-dd")) || !fromCreateDate.Equals(DateTime.Now.ToString("yyyy-MM-dd")))
                {
                    param.Add("UpdateDate", fromCreateDate + "@" + toCreateDate);
                }
            }          

            if (param.Count != 0)
            {
                this.dgvManagerAction.DataSource = actionsBLL.SearchInformation(param);
                dgvManagerAction.AutoGenerateColumns = false;
            }
        }

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
        }
     
        //Biến lưu trạng thái thêm mới, default false tức là cập nhật
        public static bool pStatusAddNew = false;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvManagerAction.SelectedRows.Count != 0)
                {
                    pStatusAddNew = false;
                    
                    string pActionsID = this.dgvManagerAction.SelectedRows[0].Cells[0].Value.ToString();
                    frmUpdateAction frmUpAction = new frmUpdateAction();
                    getData getDB = new getData(frmUpAction.WriteData);
                    getDB(pActionsID);
                    frmUpAction.ShowDialog();
                    //Reload data
                    LoadData();
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
                string pActionsId = this.dgvManagerAction.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult r = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM374"),
                                    Common.clsLanguages.GetResource("CRM11"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
                if (r == DialogResult.Yes)
                {
                    actionsBLL.Delete(pActionsId);
                    LoadData();
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
       

        private void dgvManagerAction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }
           
        //Gửi email
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.dgvListMembers.SelectedRows.Count != 0)
            //    {
            //        string memberId = this.dgvListMembers.SelectedRows[0].Cells[0].Value.ToString();
            //        frmHistoryMember frmHistoryMember = new frmHistoryMember();
            //        getData getDB = new getData(frmHistoryMember.WriteData);
            //        getDB(memberId);
            //        frmHistoryMember.ShowDialog();
            //    }
            //    else
            //    {
            //        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM369"),
            //            Common.clsLanguages.GetResource("CRM11"),
            //            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
            //            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            //    }
            //}
            //catch (Exception)
            //{
            //    string code = System.Runtime.InteropServices.Marshal.GetExceptionCode().ToString();
            //    if (code == "-532462766")
            //    {
            //        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM292"),
            //                  Common.clsLanguages.GetResource("CRM11"),
            //                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
            //                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            //    }
            //    return;
            //}
        }

        //Xem lịch sử hoạt động của 
        private void btnHistory_Click(object sender, EventArgs e)
        {
            
                if (this.dgvManagerAction.SelectedRows.Count != 0)
                {                    
                    string pActionsID = this.dgvManagerAction.SelectedRows[0].Cells[0].Value.ToString();
                    frmUpdateAction frmUpAction = new frmUpdateAction();
                    getData getDB = new getData(frmUpAction.WriteData);
                    getDB(pActionsID);
                    frmUpAction.ShowDialog();
                    //Reload data
                    LoadData();
                }
                else
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM369"),
                        Common.clsLanguages.GetResource("CRM11"),
                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                }
           
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
        //    string fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
        //    string toDate = dtpToDate.Value.ToString("yyyy-MM-dd");

        //    if (chBAll.Checked)
        //    {
        //        this.dgvManagerAction.DataSource = actionsBLL.SearchInformation(null, fromDate, toDate);
        //        dgvManagerAction.AutoGenerateColumns = false;
        //    }
        //    else
        //    {
        //        this.dgvManagerAction.DataSource = actionsBLL.SearchInformation(param);
        //        dgvManagerAction.AutoGenerateColumns = false;

        //    }
        }
    }
}
