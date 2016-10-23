using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using VVPosM1.BusinessLayer.BLLCRM;
using VVPosM1.Common;
using VVPosM1.CRM;
using VVPosM1.Screen.CRM.Member;

namespace VVPosM1.Screen.CRM.Members
{
    public partial class frmManageMembers : Form
    {
        #region Variable

        /// <summary>
        /// Object export for excel file
        /// </summary>
        ExportExcelAlgorithms exportExcelAlgorithms;
        /// <summary>
        /// Object memberTypeBLL
        /// </summary>
        MemberTypeBLL memberTypeBLL;
        /// <summary>
        /// Object memberBLL
        /// </summary>
        MemberBLL memberBLL;
        /// <summary>
        /// Object countryBLL
        /// </summary>
        CountryBLL countryBLL;
        /// <summary>
        /// Object employeBLL
        /// </summary>
        EmployeeBLL employeeBLL;
        /// <summary>
        /// Object receiptBLL
        /// </summary>
       // ReceiptBLL receiptBLL;
        //delegate send data to form update
        public frmMain1 frmFormMain;
        public delegate void getData(string memberId);

        //Linh 25-12-2014
        CategoryActionsBLL categoryactionsBLL = new CategoryActionsBLL();

        bool changeInside = false;
        private frmMain1 frmMain1;
        #endregion

        #region Contructor
        public frmManageMembers()
        {
            InitializeComponent();
          //  SettingControl();
        }

        public frmManageMembers(VVPosM1.CRM.frmMain1 frm)
        {
            InitializeComponent();
          //  SettingControl();
            frmFormMain = frm;
        }

        //public frmManageMembers(frmMain1 frmMain1)
        //{
        //    // TODO: Complete member initialization
        //    this.frmMain1 = frmMain1;
        //}
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
            this.lblMemberNumber.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblSearchKeyWord.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtSearchText.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            //   this.txtToTotalPrice.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.lblBirthdate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblNationality.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbbNationality.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblCreator.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbbCreator.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.btnSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnAddNew.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnEdit.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnReset.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnDelete.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnDownload.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnSelectAll.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnGuiMail.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnImport.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            //btnSelectAll
            this.lstMemberTypes.BackColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.BACKGROUNDCOLOR);
            this.gbMemberTypeList.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.gbInformation.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.dgvListMembers.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.lblCurator.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.lblCategoryActionID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
        }
        /// <summary>
        /// Set change text for controls
        /// </summary>
        public void SetUIChanges()
        {
            try
            {
                lblNotify.Text = Common.clsLanguages.GetResource("CRM624");
                lblTitle.Text = Common.clsLanguages.GetResource("CRM162");
                //gbInformationSearch
                gbInformationSearch.Text = Common.clsLanguages.GetResource("CRM101");
                gbInformation.Text = Common.clsLanguages.GetResource("CRM204");
                lblMemberNumber.Text = Common.clsLanguages.GetResource("CRM163");
                lblSearchKeyWord.Text = Common.clsLanguages.GetResource("CRMSearchTextbox");
                lblBirthdate.Text = Common.clsLanguages.GetResource("CRM166");
                lblNationality.Text = Common.clsLanguages.GetResource("CRM250");
                lblCreator.Text = Common.clsLanguages.GetResource("CRM168");
                gbMemberTypeList.Text = Common.clsLanguages.GetResource("CRMCustomerType");
                btnSearch.Text = Common.clsLanguages.GetResource("CRM24");
                btnReset.Text = Common.clsLanguages.GetResource("CRM508");
                btnAddNew.Text = Common.clsLanguages.GetResource("CRM109");
                btnEdit.Text = Common.clsLanguages.GetResource("CRM188");
                btnDelete.Text = Common.clsLanguages.GetResource("CRM110");
                btnDownload.Text = Common.clsLanguages.GetResource("CRM507");
                btnSelectAll.Text = Common.clsLanguages.GetResource("CRM186");

                lbBirthdateFrom.Text = Common.clsLanguages.GetResource("CRMFromDate");
                lbBirthdateTo.Text = Common.clsLanguages.GetResource("CRMToDate");
                chbchooseAll.Text = Common.clsLanguages.GetResource("CRMSelectedAll");

                dgvListMembers.Columns["STT"].HeaderText = Common.clsLanguages.GetResource("CRM71");
                //dgvListMembers.Columns["SelectCol"].HeaderText = Common.clsLanguages.GetResource("CRM590");
                //dgvListMembers.Columns["STT"].DisplayIndex
                dgvListMembers.Columns["colMemberId"].HeaderText = Common.clsLanguages.GetResource("CRM112");
                dgvListMembers.Columns["colMemberCode"].HeaderText = Common.clsLanguages.GetResource("CRM112");
                dgvListMembers.Columns["colMemberName"].HeaderText = Common.clsLanguages.GetResource("CRM113");
                dgvListMembers.Columns["colBirthDate"].HeaderText = Common.clsLanguages.GetResource("CRM105");
                dgvListMembers.Columns["colPhoneNumber"].HeaderText = Common.clsLanguages.GetResource("CRM26"); //"Điện thoai bàn";
                dgvListMembers.Columns["colEmail"].HeaderText = Common.clsLanguages.GetResource("CRM116"); //"Email cá nhân";
                dgvListMembers.Columns["colAddress"].HeaderText = Common.clsLanguages.GetResource("CRM117");
                //dgvListMembers.Columns["colTotalScore"].HeaderText = Common.clsLanguages.GetResource("CRM316");
                //dgvListMembers.Columns["colCurrentScore"].HeaderText = Common.clsLanguages.GetResource("CRM538");

                dgvListMembers.Columns["colLanguageName"].HeaderText = Common.clsLanguages.GetResource("CRM118");
                //dgvListMembers.Columns["colMemberTypeName"].HeaderText = Common.clsLanguages.GetResource("CRMCustomerType");
                //dgvListMembers.Columns["colCreator"].HeaderText = Common.clsLanguages.GetResource("CRM168");
                //dgvListMembers.Columns["colIsLock"].HeaderText = Common.clsLanguages.GetResource("CRM170");
                //dgvListMembers.Columns["colNumberOfVissits"].HeaderText = Common.clsLanguages.GetResource("CRM151");
                //dgvListMembers.Columns["colLastestDate"].HeaderText = Common.clsLanguages.GetResource("CRM167");
                ////.Columns["colCreatedDate"].HeaderText = Common.clsLanguages.GetResource("CRM121");
                //dgvListMembers.Columns["colUpdatedDate"].HeaderText = Common.clsLanguages.GetResource("CRM122");
                //
                dgvListMembers.Columns["colMobilePhone"].HeaderText = Common.clsLanguages.GetResource("CRM115"); //"Điện thoại di động";
                dgvListMembers.Columns["colCompanyName"].HeaderText = Common.clsLanguages.GetResource("CRM582");
                //dgvListMembers.Columns["colCompanyEmail"].HeaderText = Common.clsLanguages.GetResource("CRM116"); //"Email công ty";

                //Linh 27-12-2014
                //dgvListMembers.Columns["colCurator"].HeaderText = Common.clsLanguages.GetResource("CRM641"); //"Người phụ trách";
                //dgvListMembers.Columns["colCategoryID"].HeaderText = Common.clsLanguages.GetResource("CRM229"); //"Loại khách hàng";
                btnEmpEdit.Text = Common.clsLanguages.GetResource("CRM188");
                btnSearchAction.Text = Common.clsLanguages.GetResource("CRM648");

                this.dgvListMembers.Visible = false;

                lblCurator.Text = Common.clsLanguages.GetResource("CRM641");
                lblCategoryActionID.Text = Common.clsLanguages.GetResource("CRM229");
                btnImport.Text = Common.clsLanguages.GetResource("CRM645");

                //Load data for gridview
               
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

        //Linh 12-08-2014
        private void setLoadGridView()
        {
            this.dgvListMembers.Visible = true;
            lblNotify.Visible = false;
        }
        /// <summary>
        /// Event raise when user click button add new
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateMember frm = new frmUpdateMember();
                frm.ThemMoi = true;
                frm.ShowDialog();
                //LoadData_ToGridView();
                btnSearch_Click(sender, e);
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
        /// Event raise when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmManageMembers_Load(object sender, EventArgs e)
        {
            try
            {
                CreateObject();
                SetUIChanges();
                this.dgvListMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                this.dgvListMembers.MultiSelect = true;
                LoadData();
                for (int i = 0; i < lstMemberTypes.Items.Count; i++)
                {
                    lstMemberTypes.SetItemChecked(i, true);
                }
                chbchooseAll.Checked = true;
                changeInside = false;
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

        //giúp giảm tải phải load lại
        private void LoadData_ToGridView()
        {
            setLoadGridView();
            this.dgvListMembers.DataSource = memberBLL.GetListDisplay(memberBLL.GetInfoForFrmManageMembers().Tables[3]);
        }
        /// <summary>
        /// Load data for form
        /// </summary>
        private void LoadData()
        {
            //setLoadGridView();
            DataSet ds = memberBLL.GetInfoForFrmManageMembers();
            DataTable dt = new DataTable();
            lstMemberTypes.Items.Clear(); 
            dt = ds.Tables[0];
            if (dt != null)
            {
                lstMemberTypes.DataSource = dt;
                
                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                {
                    lstMemberTypes.DisplayMember = dt.Columns["MemberTypeName"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                {
                    lstMemberTypes.DisplayMember = dt.Columns["MemberTypeName3"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                {
                    lstMemberTypes.DisplayMember = dt.Columns["MemberTypeName2"].ToString();
                }
                
                lstMemberTypes.ValueMember = dt.Columns["MemberTypeId"].ToString();

            }

            DataTable dtCountries = new DataTable();
            dtCountries = ds.Tables[1];
            if (dtCountries != null)
            {
                cbbNationality.DataSource = dtCountries;
                DataRow defaultRow = dtCountries.NewRow();
                defaultRow["CountryId"] = "-1";
                defaultRow["CountryName"] = Common.clsLanguages.GetResource("CRMSelectAll");
                defaultRow["CountryName2"] = Common.clsLanguages.GetResource("CRMSelectAll");
                defaultRow["CountryName3"] = Common.clsLanguages.GetResource("CRMSelectAll");
                dtCountries.Rows.Add(defaultRow);
                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                {
                    cbbNationality.DisplayMember = dtCountries.Columns["CountryName"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                {
                    cbbNationality.DisplayMember = dtCountries.Columns["CountryName3"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                {
                    cbbNationality.DisplayMember = dtCountries.Columns["CountryName2"].ToString();
                }
                cbbNationality.ValueMember = dtCountries.Columns["CountryId"].ToString();
                cbbNationality.SelectedIndex = dtCountries.Rows.IndexOf(defaultRow);
            }

            //Load data for combox creator
            DataTable dtCreator = new DataTable();
            //dtCreator = employeeBLL.GetLists();
            dtCreator = ds.Tables[2];
            if (dtCreator != null)
            {
                //add default row - Nghi
                DataRow defaultRow = dtCreator.NewRow();
                defaultRow["EmployeeId"] = "-1";
                defaultRow["EmployeeName"] = Common.clsLanguages.GetResource("CRMSelectAll");

                dtCreator.Rows.Add(defaultRow);

                //cbbCreator.DataSource = dtCreator;
                //cbbCreator.DisplayMember = dtCreator.Columns["EmployeeName"].ToString();
                //cbbCreator.ValueMember = dtCreator.Columns["EmployeeId"].ToString();
                //cbbCreator.SelectedIndex = dtCreator.Rows.IndexOf(defaultRow);

                //Linh 24-12-2014

                cbbCurator.DataSource = dtCreator;
                cbbCurator.DisplayMember = dtCreator.Columns["EmployeeName"].ToString();
                cbbCurator.ValueMember = dtCreator.Columns["EmployeeId"].ToString();
                cbbCurator.SelectedIndex = dtCreator.Rows.IndexOf(defaultRow);
            }

            #region ComboBox cbb CategoryActions
            DataTable dtCategory = new DataTable();
            dtCategory = categoryactionsBLL.GetLists();
            DataRow row1 = dtCategory.NewRow();
            row1["CategoryActionID"] = "-1";
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

            this.dtpBirthDate1.Value = DateTime.Now;
            this.dtpBirthDate2.Value = DateTime.Now;
        }

        private void CreateObject()
        {
            memberBLL = new MemberBLL();
            memberTypeBLL = new MemberTypeBLL();
            countryBLL = new CountryBLL();
            employeeBLL = new EmployeeBLL();
            exportExcelAlgorithms = new ExportExcelAlgorithms();
           // receiptBLL = new ReceiptBLL();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                if (!string.IsNullOrEmpty(txtSearchText.Text.Trim()))
                {
                    param.Add("SearchKeyWord", txtSearchText.Text.Trim());
                }

                if (chkSinhNhat.Checked)
                {
                    string fromBirthDate = dtpBirthDate1.Value.ToString("yyyy-MM-dd");
                    string toBirthDate = dtpBirthDate2.Value.ToString("yyyy-MM-dd");

                    if (!fromBirthDate.Equals(DateTime.Now.ToString("yyyy-MM-dd")) || !toBirthDate.Equals(DateTime.Now.ToString("yyyy-MM-dd")))
                    {
                        fromBirthDate += " 00:00:00";
                        toBirthDate += " 23:59:59";
                        param.Add("BirthDate", fromBirthDate + "@" + toBirthDate);

                    }
                }

                if (cbbNationality.SelectedValue != null)
                {
                    if (cbbNationality.SelectedValue.ToString() != "-1")
                    {
                        param.Add("CountryId", cbbNationality.SelectedValue.ToString());
                    }
                }

                //if (cbbCreator.SelectedValue != null)
                //{
                //    if (cbbCreator.SelectedValue.ToString() != "-1")
                //    {
                //        param.Add("Creator", cbbCreator.SelectedValue.ToString());
                //    }
                //}

                //Linh 24-12-2014
                if (cbbCurator.SelectedValue != null)
                {
                    if (cbbCurator.SelectedValue.ToString() != "-1")
                    {
                        param.Add("Curator", cbbCurator.SelectedValue.ToString());
                    }
                }
                if (cbBCategoryAction.SelectedValue != null)
                {
                    if (cbBCategoryAction.SelectedValue.ToString() != "-1")
                    {
                        param.Add("CategoryID", cbBCategoryAction.SelectedValue.ToString());
                    }
                }

                List<string> lstMemberTypeId = new List<string>();
                for (int i = 0; i < lstMemberTypes.Items.Count; i++)
                {
                    if (lstMemberTypes.GetItemChecked(i))
                    {
                        DataRowView dr = (DataRowView)lstMemberTypes.Items[i];
                        lstMemberTypeId.Add(dr["MemberTypeId"].ToString());
                    }
                }
                setLoadGridView();
                this.dgvListMembers.DataSource = memberBLL.GetListDisplay(memberBLL.SearchInformation(param, (lstMemberTypeId.Count > 0) ? lstMemberTypeId : null));
            }
            catch (Exception exp)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvListMembers.SelectedRows.Count != 0)
                {
                    string memberId = this.dgvListMembers.SelectedRows[0].Cells["colMemberId"].Value.ToString();
                    frmUpdateMember frmUpdateMember = new frmUpdateMember();
                    frmUpdateMember.ThemMoi = false;
                    getData getDB = new getData(frmUpdateMember.WriteData);
                    getDB(memberId);
                    frmUpdateMember.ShowDialog();
                    //LoadData_ToGridView();
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
            try
            {
                if (this.dgvListMembers.SelectedRows.Count != 0)
                {
                    string EmpId = Program.employee1.EmployeeId;
                    string memberIDList = "";
                    string space = "";
                    for (int i = 0; i < this.dgvListMembers.SelectedRows.Count; i++)
                    {
                        memberIDList += space + this.dgvListMembers.SelectedRows[i].Cells["colMemberId"].Value.ToString();
                        space = ",";
                    }
                    if (memberIDList.Length > 0)
                    {
                        memberIDList = "(" + memberIDList + ")";

                        string noticCode;
                        if(Program.lstRole.Contains("admin")) noticCode = "CRM374";
                        else  
                            noticCode = (memberBLL.countCurator(memberIDList, EmpId)) ? "CRM374" : "CRMNoticDeleteMember";

                        DialogResult r = CustomMessageBox.PassMessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource(noticCode),
                                            Common.clsLanguages.GetResource("CRM11"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
                        if (r == DialogResult.Yes)
                        {
                            memberBLL.Delete(EmpId, memberIDList);

                            btnSearch_Click(sender, e);
                        }
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

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            exportExcelAlgorithms.ExportFileFromDataGridView(this.dgvListMembers, "CustomersList");            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearchText.Clear();
                cbbNationality.SelectedIndex = -1;
                cbbCreator.SelectedIndex = -1;
                dtpBirthDate1.ResetText();
                dtpBirthDate2.ResetText();

                for (int i = 0; i < lstMemberTypes.Items.Count; i++)
                {
                    lstMemberTypes.SetItemChecked(i, false);
                }
                this.dgvListMembers.DataSource = memberBLL.GetListDisplay(memberBLL.GetLists());
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

        private void dgvListMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }       

        private void chkSinhNhat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSinhNhat.Checked == true)
            {
                dtpBirthDate1.Enabled = true;
                dtpBirthDate2.Enabled = true;
            }
            else
            {
                dtpBirthDate1.Enabled = false;
                dtpBirthDate2.Enabled = false;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (dgvListMembers.SelectedRows.Count == dgvListMembers.RowCount)
            {
                dgvListMembers.ClearSelection();
            }
            else
            {
                dgvListMembers.SelectAll();
            }
        }

        private void btnGuiMail_Click(object sender, EventArgs e)
        {
            // Dung change on 2014-08-06
            ArrayList arr = getMail();
            if (arr != null)
            {
                Promotions.frmSendMailPromotion1 frm = new Promotions.frmSendMailPromotion1();
                frm.arr = arr;
                frm.ShowDialog();
            }
        }

        private ArrayList getMail()
        {
            ArrayList arr = new ArrayList();
            if (dgvListMembers.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvListMembers.SelectedRows.Count; i++)
                {
                    string[] ab = new string[4];

                    ab[0] = dgvListMembers.SelectedRows[i].Cells["colCompanyName"].Value.ToString(); //Company name//dgvListMembers.SelectedRows[i].Cells["colMemberCode"].Value.ToString(); //Code
                    ab[1] = dgvListMembers.SelectedRows[i].Cells["colMemberName"].Value.ToString(); //Name
                    ab[2] = dgvListMembers.SelectedRows[i].Cells["colBirthDate"].Value.ToString(); //BrithDay
                    ab[3] = dgvListMembers.SelectedRows[i].Cells["colEmail"].Value.ToString(); //Email
                    //ab[4] = dgvListMembers.SelectedRows[i].Cells["colCompanyName"].Value.ToString(); //Company name
                    arr.Add(ab);

                }

            }
            else
            {
                arr = null;
            }
            return arr;
        }

        private void chbchooseAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbchooseAll.Checked) //select all
                {
                    for (int i = 0; i < lstMemberTypes.Items.Count; i++)
                    {
                        lstMemberTypes.SetItemChecked(i, true);
                    }
                }
                else if (!changeInside) //unselect all
                {
                    for (int i = 0; i < lstMemberTypes.Items.Count; i++)
                    {
                        lstMemberTypes.SetItemChecked(i, false);
                    }
                }
            }
            catch { }
        }

        private void lstMemberTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selected = lstMemberTypes.GetItemChecked(lstMemberTypes.SelectedIndex);
            lstMemberTypes.SetItemChecked(lstMemberTypes.SelectedIndex, !selected);
            if (lstMemberTypes.Items.Count == lstMemberTypes.CheckedItems.Count)
            {
                changeInside = false;
                chbchooseAll.Checked = true;
            }
            else
            {
                changeInside = true;
                chbchooseAll.Checked = false;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImport frm = new frmImport();
            frm.ShowDialog();
        }

        private void lstMemberTypes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstMemberTypes.Items.Count == lstMemberTypes.CheckedItems.Count)
            {
                changeInside = false;
                chbchooseAll.Checked = true;
            }
            else
            {
                changeInside = true;
                chbchooseAll.Checked = false;
            }
        }

        private void txtSearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnSearch_Click(sender, e);
            }
        }

        private void btnSearchAction_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string key = this.dgvListMembers.SelectedRows[0].Cells["colMemberName"].Value.ToString();
                    string id = this.dgvListMembers.SelectedRows[0].Cells["colMemberId"].Value.ToString();

                    frmFormMain.CloseForm();
                    frmFormMain.frmManageAction = new frmManageActions(key, id);
                    frmFormMain.AddFormToMainPanel(frmFormMain.frmManageAction);
                    frmFormMain.frmManageAction.ColorGrid();
                }
                catch
                {
                    frmFormMain.CloseForm();
                    frmFormMain.frmManageAction = new frmManageActions();
                    frmFormMain.AddFormToMainPanel(frmFormMain.frmManageAction);
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
    }
}
