using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using VVPosM1.BusinessLayer.BLLCRM;
namespace VVPosM1.Screen.CRM.Member
{
    public partial class frmUpdateMember : Form
    {
        public bool ThemMoi;

        MemberBLL memberBLL;
        CountryBLL countryBLL;
        EmployeeBLL employeeBLL;
        MemberTypeBLL memberTypeBLL;
       // ReceiptBLL receiptBLL;
        //Linh 25-12-2014
        CategoryActionsBLL categoryactionsBLL = new CategoryActionsBLL();
        private static string staticmemberId;

        //Điệp Add 20140418
        CallNameBLL callnameBLL;
        RegencyBLL regencyBLL;

        /// <summary>
        /// Blag save value to define form is add or edit
        /// if true is add
        /// if false is edit
        /// </summary>
        private static bool blag;

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
            this.gbMemberType.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.gbInformation.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);

            this.lblMemberCode.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtMemberCode.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblMemberName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtMemerName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblBirthDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.dtpBirthDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblPhoneNumber.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtPhoneNumber.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblAddress.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtAddress.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lstMemberType.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblNationality.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.lblNationality.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblCurator.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbbCurator.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.chbIsLock.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblLockDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.dtpLockDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblTotalScore.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtTotalScore.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblNumberOfVissits.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtNumberOfVissits.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.lblLastDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblCreatedDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.dtpCreatedDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblUpdatedDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.dtpUpdatedDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblLastDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.dtpLastDate.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.btnReset.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnSave.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);

            this.lblCurrentScore.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtCurrentScore.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            //Điệp Add CRM

            this.lblRegency.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblCompanyName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtCompanyName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblCompanyEMail.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtCompanyEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.txtChucDanh.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblMobilePhone.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtMobilePhone.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblTaxCode.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtTaxCode.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblWebsite.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtWebsite.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblDescription.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.REQUIRECOLOR);
            this.txtDescription.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblCallName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbBCallName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.chBAutoID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.lblCategoryActionID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            
        }

        /// <summary>
        /// Set language for form
        /// </summary>
        private void SetUIChanges()
        {
            if (staticmemberId == null)
            {
                this.Text = Common.clsLanguages.GetResource("CRM375");
            }
            else
            {
                this.Text = Common.clsLanguages.GetResource("CRM376");
            }

            //gbInformationSearch
            gbInformation.Text = Common.clsLanguages.GetResource("CRM127");
            lblMemberCode.Text = Common.clsLanguages.GetResource("CRMCustomerID");
            lblMemberName.Text = Common.clsLanguages.GetResource("CRM113");
            lblEmail.Text = Common.clsLanguages.GetResource("CRM116");
            lblBirthDate.Text = Common.clsLanguages.GetResource("CRM105");
            lblLastDate.Text = Common.clsLanguages.GetResource("CRM167");
            lblNationality.Text = Common.clsLanguages.GetResource("CRM250");
            lblPhoneNumber.Text = Common.clsLanguages.GetResource("CRM26");
            lblAddress.Text = Common.clsLanguages.GetResource("CRM117");
            lblCurator.Text = Common.clsLanguages.GetResource("CRM641");
            // lblIsLock.Text = Common.clsLanguages.GetResource("CRM119");
            chbIsLock.Text = Common.clsLanguages.GetResource("CRM170");
            lblLockDate.Text = Common.clsLanguages.GetResource("CRM370");

            gbMemberType.Text = Common.clsLanguages.GetResource("CRMCustomerType");
            lblTotalScore.Text = Common.clsLanguages.GetResource("CRM316");
            lblCurrentScore.Text = Common.clsLanguages.GetResource("CRM538");

            lblNumberOfVissits.Text = Common.clsLanguages.GetResource("CRM171");
            lblCreatedDate.Text = Common.clsLanguages.GetResource("CRM121");
            lblUpdatedDate.Text = Common.clsLanguages.GetResource("CRM122");

            //button set            
            btnReset.Text = Common.clsLanguages.GetResource("CRM134");
            btnSave.Text = Common.clsLanguages.GetResource("CRM161");

            //Thêm vào sau này
            chBAutoID.Text = Common.clsLanguages.GetResource("CRM576");
            lblCallName.Text = Common.clsLanguages.GetResource("CRM583");

            lblRegency.Text = Common.clsLanguages.GetResource("CRM584");
            lblCompanyName.Text = Common.clsLanguages.GetResource("CRM582");
            lblCompanyEMail.Text = Common.clsLanguages.GetResource("CRMCustomerEmails");

            lblMobilePhone.Text = Common.clsLanguages.GetResource("CRMMobilePhone");
            lblTaxCode.Text = Common.clsLanguages.GetResource("CRM587");
            lblDescription.Text = Common.clsLanguages.GetResource("CRM128");

            //set watermark for textboxs
            txtAddress.WaterMarkText = lblAddress.Text;
            txtChucDanh.WaterMarkText = lblRegency.Text;
            txtCompanyEmail.WaterMarkText = Common.clsLanguages.GetResource("CRMEmailSeparated");
            txtCompanyName.WaterMarkText = lblCompanyName.Text;
            txtMemberCode.WaterMarkText = lblMemberCode.Text;
            txtMemerName.WaterMarkText = lblMemberName.Text;
            txtMobilePhone.WaterMarkText = lblMobilePhone.Text;
            txtPhoneNumber.WaterMarkText = lblPhoneNumber.Text;
            txtTaxCode.WaterMarkText = lblTaxCode.Text;
            txtWebsite.WaterMarkText = lblWebsite.Text;

            dtpBirthDate.Enabled = false;


            txtDescription.WaterMarkText = "";

            dtpBirthDate.CustomFormat = "yyyy-MM-dd";
            lblCategoryActionID.Text = Common.clsLanguages.GetResource("CRM229");

        }      

        public frmUpdateMember()
        {
            InitializeComponent();
            SettingControl();
        }

        /// <summary>
        /// Load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            try
            {
                CreateObject();
                LoadData();
                this.dtpLastDate.Enabled = false;
                this.dtpCreatedDate.Enabled = false;
                this.dtpUpdatedDate.Enabled = false;

                SetUIChanges();

                if (ThemMoi == false)
                {
                    blag = false;
                    if(!Program.employee1.EmployeeId.Equals(memberBLL.getCurator(staticmemberId)) && !Program.lstRole.Contains("admin"))
                    {
                        cbbCurator.Enabled = false;
                    }
                }
            }
            catch (Exception exp)
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
                Entities.Member member = new Entities.Member();
                //memberId
                member.MemberId = staticmemberId;
                //validate member code
                string strMemberCode = "";
                if (chBAutoID.Checked)
                {
                    member.MemberCode = GetAutoMemberCode(cbbNationality.SelectedValue.ToString());
                }
                else
                {
                    strMemberCode = txtMemberCode.Text.Trim();
                    if (string.IsNullOrEmpty(strMemberCode))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM37"),
                                        Common.clsLanguages.GetResource("CRM11"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                    else
                    {
                        member.MemberCode = strMemberCode;
                    }
                }
                //validate membername or company name not ether null

                if (string.IsNullOrEmpty(txtMemerName.Text.Trim()) && string.IsNullOrEmpty(txtCompanyName.Text.Trim()))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM628"),
                                  Common.clsLanguages.GetResource("CRM11"),
                                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
                else
                {
                    member.MemberName = txtMemerName.Text.Trim();
                    member.CompanyName = txtCompanyName.Text.Trim();
                }

                //validate birthdate
                DateTime birthdate = dtpBirthDate.Value;
                member.BirthDate = birthdate;
                if (chkNgaySinh.Checked == true)
                {
                    member.birthDay = true;
                }
                else
                {
                    member.birthDay = false;
                }

                //validate email
                string strEmail = txtCompanyEmail.Text.Trim();
                string[] emails = strEmail.Split(';');
                int lenght = emails.Length;
                string opSpace = "";
                strEmail = "";

                for (int i = 0; i < lenght; i++)
                {
                    if (!string.IsNullOrEmpty(emails[i]) && !Common.Validation.ValidateEmail(emails[i].Trim()))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM311"),
                                          Common.clsLanguages.GetResource("CRM11"),
                                          Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                           Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }

                    strEmail += opSpace + emails[i];
                    opSpace = ";";
                }

                member.CompanyEmail = strEmail;

                member.Email = strEmail;

                //phone number
                member.PhoneNumber = System.Text.RegularExpressions.Regex.Replace(txtPhoneNumber.Text.Trim(), "( ( )*)", " ");


                //address
                if (!string.IsNullOrEmpty(txtAddress.Text.Trim()))
                {
                    member.Address = txtAddress.Text.Trim();
                }

                //validate nationality
                if (cbbNationality.Text == "")
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM373"),
                                    Common.clsLanguages.GetResource("CRM11"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
                else
                {
                    member.Country.CountryId = cbbNationality.SelectedValue.ToString();
                }

                //creator
                member.Creator.EmployeeId = Program.employee1.EmployeeId;
                try
                {
                    member.Curator.EmployeeId = cbbCurator.SelectedValue.ToString();
                }
                catch
                {
                    member.Curator.EmployeeId = null;
                }
                try
                {
                    if (cbBCategoryAction.SelectedValue.ToString() != "")
                    {
                        member.CategoryID.CategoryActionID = cbBCategoryAction.SelectedValue.ToString();
                    }
                    else
                    {
                        member.CategoryID.CategoryActionID = "";
                    }
                }
                catch (Exception)
                {
                    member.CategoryID.CategoryActionID = "";
                }
                

                //chuc vu
                member.Regency = txtChucDanh.Text.Trim();

                //total score
                string strTotalScore = txtTotalScore.Text.Trim();
                if (!string.IsNullOrEmpty(strTotalScore))
                {
                    if (!Common.Validation.ValidateNumber(strTotalScore))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM98"),
                                    Common.clsLanguages.GetResource("CRM12"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                    else
                    {
                        member.TotalScore = Int32.Parse(strTotalScore);
                    }
                }
                //total CurrentScore
                string strCurrentScore = txtCurrentScore.Text.Trim();
                if (!string.IsNullOrEmpty(strCurrentScore))
                {
                    if (!Common.Validation.ValidateNumber(strCurrentScore))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM98"),
                                    Common.clsLanguages.GetResource("CRM12"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                    else
                    {
                        member.CurrentScore = Int32.Parse(strCurrentScore);
                    }
                }

                //numberOfVissits
                string strNumberOfVissits = txtNumberOfVissits.Text.Trim();
                if (!string.IsNullOrEmpty(strNumberOfVissits))
                {
                    if (!Common.Validation.ValidateNumber(strNumberOfVissits))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM98"),
                                    Common.clsLanguages.GetResource("CRM12"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                    else
                    {
                        member.NumberOfVissits = Int32.Parse(strNumberOfVissits);
                    }
                }

                //member type
                //List<string> lstMemberTypeName = new List<string>();
                List<Entities.MemberType> lstMemberTypeName = new List<Entities.MemberType>();
                int otherIndex = -1;
                for (int i = 0; i < lstMemberType.Items.Count; i++)
                {
                    DataRowView dr = (DataRowView)lstMemberType.Items[i];
                    if (lstMemberType.GetItemChecked(i))
                    {
                        Entities.MemberType mt = new Entities.MemberType();
                        mt.MemberTypeId = int.Parse(dr["MemberTypeId"].ToString());
                        mt.MemberTypeName = dr["MemberTypeName"].ToString();
                        mt.MemberTypeName2 = dr["MemberTypeName2"].ToString();
                        mt.MemberTypeName3 = dr["MemberTypeName3"].ToString();
                        //mt.MemberTypeId
                        lstMemberTypeName.Add(mt);
                    }
                    if (dr["MemberTypeCode"].ToString().Equals("OT")) // other type
                        otherIndex = i;
                }
                if (lstMemberTypeName.Count != 0)
                {
                    member.List_MemberType = lstMemberTypeName;
                }
                else
                {
                    if (otherIndex >= 0)
                    {
                        DataRowView dr = (DataRowView)lstMemberType.Items[otherIndex];
                        Entities.MemberType mt = new Entities.MemberType();
                        mt.MemberTypeId = int.Parse(dr["MemberTypeId"].ToString());
                        mt.MemberTypeName = dr["MemberTypeName"].ToString();
                        mt.MemberTypeName2 = dr["MemberTypeName2"].ToString();
                        mt.MemberTypeName3 = dr["MemberTypeName3"].ToString();
                        lstMemberTypeName.Add(mt);

                        member.List_MemberType = lstMemberTypeName;
                    }
                    else
                    {
                        member.List_MemberType = null;
                    }
                }

                //member.MemberType.MemberTypeId = Int32.Parse(memberType);

                //Lastest Date
                member.LastestDate = DateTime.Now;
                //Created date
                member.CreatedDate = DateTime.Now;
                //Updated date
                member.UpdatedDate = DateTime.Now;

                //islock
                int isLock = 0;
                if (chbIsLock.Checked)
                {
                    isLock = 1;
                }
                member.IsLock = isLock;

                //LockDate
                member.LockDate = DateTime.Now;
                member.MobilePhone = txtMobilePhone.Text.Trim();

                //validate website
                string url = txtWebsite.Text.Trim();

                if (!string.IsNullOrEmpty(url) && !Common.Validation.ValidateWebsite(url))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRMErrorURLNotValid"),
                                        Common.clsLanguages.GetResource("CRM12"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }

                member.Website = url;

                member.TaxCode = txtTaxCode.Text.Trim();
                member.Description = txtDescription.Text.Trim();
                if (cbBCallName.SelectedValue != null)
                {
                    member.CallName.CallNameID = (int)cbBCallName.SelectedValue;
                }


                DialogResult dialog = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM227"),
                                               Common.clsLanguages.GetResource("CRM11"),
                                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
                if (dialog == DialogResult.Yes)
                {

                    //If is add
                    if (blag)
                    {
                        if (memberBLL.CheckMemberCodeExist(strMemberCode))
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM539"),
                                            Common.clsLanguages.GetResource("CRM12"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                            this.txtMemberCode.Clear();
                            this.txtMemberCode.Focus();
                            return;
                        }
                        memberBLL.Add(member);

                        if (staticmemberId != null)
                        {
                            staticmemberId = member.MemberId;
                        }
                    }
                    //If is edit
                    else
                    {

                        memberBLL.Edit(member);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM292"),
                                               Common.clsLanguages.GetResource("CRM12"),
                                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
        }

        private List<string> GetListMemberTypeName()
        {
            List<string> arr = new List<string>();
            for (int i = 0; i < lstMemberType.CheckedItems.Count; i++)
            {
                arr.Add(lstMemberType.GetItemText(lstMemberType.CheckedItems[i]));
            }
            return arr;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
              

        private void CreateObject()
        {
            memberBLL = new MemberBLL();
            countryBLL = new CountryBLL();
            employeeBLL = new EmployeeBLL();
            memberTypeBLL = new MemberTypeBLL();
           // receiptBLL = new ReceiptBLL();
            callnameBLL = new CallNameBLL();
            regencyBLL = new RegencyBLL();
        }

        public void ResetData()
        {
            this.txtMemberCode.Clear();
            this.txtMemerName.Clear();
            this.dtpBirthDate.Value = DateTime.Now;
            this.txtEmail.Clear();
            this.txtPhoneNumber.Clear();
            this.txtAddress.Clear();
            this.cbbNationality.SelectedIndex = -1;
            this.txtTotalScore.Clear();
            this.txtNumberOfVissits.Clear();

            for (int i = 0; i < lstMemberType.Items.Count; i++)
            {
                lstMemberType.SetItemChecked(i, false);
            }
            this.dtpLastDate.Value = DateTime.Now;
        }
                
        public void LoadData()
        {
            //load membertype
            DataTable dt = new DataTable();
            dt = memberTypeBLL.GetListsNameNotNull();
            if (dt != null)
            {
                lstMemberType.DataSource = dt;
                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                {
                    lstMemberType.DisplayMember = dt.Columns["MemberTypeName"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                {
                    lstMemberType.DisplayMember = dt.Columns["MemberTypeName3"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                {
                    lstMemberType.DisplayMember = dt.Columns["MemberTypeName2"].ToString();
                }

                lstMemberType.ValueMember = dt.Columns["MemberTypeId"].ToString();
            }
            //load data for cbb nationality
            DataTable dtCountry = new DataTable();
            dtCountry = countryBLL.GetLists();
            if (dtCountry != null)
            {
                this.cbbNationality.DataSource = dtCountry;
                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                {
                    this.cbbNationality.DisplayMember = dtCountry.Columns["CountryName"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                {
                    this.cbbNationality.DisplayMember = dtCountry.Columns["CountryName3"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                {
                    this.cbbNationality.DisplayMember = dtCountry.Columns["CountryName2"].ToString();
                }
                this.cbbNationality.ValueMember = dtCountry.Columns["CountryId"].ToString();
            }
            //Điệp add 20140418

            //load data for cbb CallName
            DataTable dtCallName = new DataTable();
            dtCallName = callnameBLL.GetLists();
            if (dtCallName != null)
            {
                this.cbBCallName.DataSource = dtCallName;
                this.cbBCallName.ValueMember = dtCallName.Columns["CallNameID"].ToString();
                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                {
                    this.cbBCallName.DisplayMember = dtCallName.Columns["Name1"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                {
                    this.cbBCallName.DisplayMember = dtCallName.Columns["Name2"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                {
                    for (int i = 1; i < dtCallName.Rows.Count; i++)
                    {
                        dtCallName.Rows[i].Delete();
                    }

                    this.cbBCallName.DisplayMember = dtCallName.Columns["Name3"].ToString();
                     this.cbBCallName.SelectedIndex = (Common.clsLanguages.StrCulture.Equals("ja-JP")) ? 0 : dtCallName.Rows.Count - 1;
                }
            }

            //End Điệp add 20140418

            //Begin Linh 25-12-2014
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
                this.cbBCategoryAction.SelectedIndex = 1;
            }

            #endregion End CategoryAction
            //End Linh 25-12-2014

            //load data for cbb Employee
            DataTable dtEmployee = new DataTable();
            dtEmployee = employeeBLL.GetLists();
            if (dtEmployee != null)
            {
                this.cbbCurator.DataSource = dtEmployee;
                this.cbbCurator.DisplayMember = dtEmployee.Columns["EmployeeName"].ToString();
                this.cbbCurator.ValueMember = dtEmployee.Columns["EmployeeId"].ToString();
            }
            if (staticmemberId == null)
            {
                blag = true;
                this.cbbNationality.SelectedIndex = 0;
                this.chbIsLock.Visible = false;
                this.dtpLockDate.Visible = false;
                this.lblLockDate.Visible = false;
                try
                {
                    cbbCurator.SelectedValue = Program.employee1.EmployeeId;
                }
                catch (Exception) { }
            }
            else
            {
                Entities.Member member = new Entities.Member();
                member = memberBLL.GetById(staticmemberId);
                this.txtMemberCode.Text = member.MemberCode;
                this.txtMemerName.Text = member.MemberName;
                if (member.birthDay == true)
                {
                    this.chkNgaySinh.Checked = true;
                    dtpBirthDate.Enabled = true;
                }
                else
                {
                    this.chkNgaySinh.Checked = false;
                    dtpBirthDate.Enabled = false;
                }

                this.txtChucDanh.Text = member.Regency;
                this.dtpBirthDate.Value = member.BirthDate;
                this.txtEmail.Text = member.Email;
                this.txtPhoneNumber.Text = member.PhoneNumber;
                this.txtAddress.Text = member.Address;
                this.cbbNationality.SelectedValue = member.Country.CountryId;                
                this.txtTotalScore.Text = member.TotalScore.ToString();
                this.txtNumberOfVissits.Text = member.NumberOfVissits.ToString();
                this.dtpLastDate.Value = member.LastestDate;
                this.dtpCreatedDate.Value = member.CreatedDate;
                this.dtpUpdatedDate.Value = member.UpdatedDate;
                //Linh 29-12-2014
                try
                {
                    this.cbbCurator.SelectedValue = member.Curator.EmployeeId;
                    this.cbBCategoryAction.SelectedValue = member.CategoryID.CategoryActionID;
                }
                catch(Exception)
                {
                    this.cbbCurator.SelectedValue = Program.employee1.EmployeeId;
                    this.cbBCategoryAction.SelectedIndex = 1;
                }


                //Điệp edit
                this.txtCurrentScore.Text = member.CurrentScore.ToString();

                List<string> lstMemberTypeName = new List<string>();
                ///
                List<int> lst_mbt = new List<int>();
                if (member.List_MemberType != null)
                {
                    foreach (Entities.MemberType mt in member.List_MemberType)
                    {
                        lst_mbt.Add(mt.MemberTypeId);
                    }
                }

                lstMemberTypeName = memberTypeBLL.GetListMemberTypeName_New(lst_mbt);
                for (int i = 0; i < lstMemberType.Items.Count; i++)
                {
                   /* string[] arr = lstMemberType.GetItemText(lstMemberType.Items[i]).Split('/');
                    for (int j = 0; j < lstMemberTypeName.Count; j++)
                    {
                        if (arr[0].Equals(lstMemberTypeName[j]))
                        {
                            lstMemberType.SetItemChecked(i, true);
                            break;
                        }
                    }
                    */
                    int index = int.Parse(((DataRowView)lstMemberType.Items[i])["MemberTypeId"].ToString());
                    if(lst_mbt.Contains(index))
                    {
                        lstMemberType.SetItemChecked(i, true);
                    }

                }

                if (member.IsLock == 1)
                {
                    chbIsLock.Checked = true;
                    lblLockDate.Visible = true;
                    dtpLockDate.Visible = true;
                }
                else
                {
                    lblLockDate.Visible = false;
                    dtpLockDate.Visible = false;
                }

                if (member.LockDate != new DateTime())
                {
                    this.dtpLockDate.Value = member.LockDate;
                }

                //Điệp Add 20140418
                this.txtMobilePhone.Text = member.MobilePhone;
                this.txtWebsite.Text = member.Website;
                this.txtTaxCode.Text = member.TaxCode;
                this.txtCompanyName.Text = member.CompanyName;
                this.txtDescription.Text = System.Text.RegularExpressions.Regex.Replace(member.Description, "\n", "\r\n");

                if (!Common.clsLanguages.StrCulture.Equals("ja-JP")) this.cbBCallName.SelectedValue = member.CallName.CallNameID;
                this.txtCompanyEmail.Text = member.Email;
                //End Điệp add 20140418
            }
        }

        public void WriteData(string memberId)
        {
            staticmemberId = memberId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            staticmemberId = null;
        }

        private void chBAutoID_CheckedChanged(object sender, EventArgs e)
        {
            if (chBAutoID.Checked)
            {
                txtMemberCode.Enabled = false;
            }
            else
                txtMemberCode.Enabled = true;
        }
        public string GetAutoMemberCode(string pCountry)
        {
            string pQG = "";
            string pNamThangNgay = "";
            int pAutoID = 1;
            pQG = cbbNationality.SelectedValue.ToString();
            pNamThangNgay = DateTime.Now.ToString("yy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd");
            string pkq = "0";
            try
            {
                pkq = memberBLL.GetMemberCode();
            }
            catch (Exception)
            {
                pkq = (pkq == "") ? "0" : pkq;
            }
           
            pAutoID = int.Parse(pkq.ToString()) + 1;

            string pKqAuto = "";
            if (pAutoID < 10)
            {
                pKqAuto = "0000" + pAutoID;
            }
            else if (pAutoID >= 10 && pAutoID < 100)
            {
                pKqAuto = "000" + pAutoID;
            }
            else if (pAutoID >= 100 && pAutoID < 1000)
            {
                pKqAuto = "00" + pAutoID;
            }
            else if (pAutoID >= 1000 && pAutoID < 10000)
            {
                pKqAuto = "0" + pAutoID;
            }
            else
            {
                pKqAuto = pAutoID.ToString();
            }
            return pQG + pNamThangNgay + pKqAuto;
        }

        private void lstMemberType_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= lstMemberType.Items.Count; i++)
            {
                // lstMemberType.Items[i].
            }
        }

        private void chkNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNgaySinh.Checked)
            {
                dtpBirthDate.Enabled = true;
            }
            else
            {
                dtpBirthDate.Enabled = false;
            }
        }

        private void chbIsLock_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsLock.Checked)
            {
                lblLockDate.Visible = true;
                dtpLockDate.Visible = true;
            }
            else
            {
                lblLockDate.Visible = false;
                dtpLockDate.Visible = false;
            }
        }
               
    }
}
