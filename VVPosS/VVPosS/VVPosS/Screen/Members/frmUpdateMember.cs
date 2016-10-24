using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using VVPosS.BusinessLayer;
namespace VVPosS.Screen.Members
{
    public partial class frmUpdateMember : Form
    {
        public bool ThemMoi;

        
        private static string staticmemberId;

        

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
            this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
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

            this.lblCreator.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbbCreator.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            //  this.lblIsLock.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
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

            this.btnAdd.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnEdit.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnReset.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnDelete.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnExit.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnSave.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);

            this.lblCurrentScore.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtCurrentScore.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            //Điệp Add CRM

            this.lblRegency.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbBRegency.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblCompanyName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtCompanyName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblCompanyEMail.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtCompanyEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblMobilePhone.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtMobilePhone.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblTaxCode.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtTaxCode.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblWebsite.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtWebsite.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblDescription.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtDescription.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblCallName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbBCallName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.chBAutoID.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);


        }

        /// <summary>
        /// Set language for form
        /// </summary>
        private void SetUIChanges()
        {
            if (staticmemberId == null)
            {
                this.Text = Common.clsLanguages.RM.GetString("00375");
            }
            else
            {
                this.Text = Common.clsLanguages.RM.GetString("00376");
            }

            //gbInformationSearch
            gbInformation.Text = Common.clsLanguages.RM.GetString("00127");
            lblMemberCode.Text = Common.clsLanguages.RM.GetString("00163");
            lblMemberName.Text = Common.clsLanguages.RM.GetString("00113");
            lblEmail.Text = Common.clsLanguages.RM.GetString("00116");
            lblBirthDate.Text = Common.clsLanguages.RM.GetString("00105");
            lblLastDate.Text = Common.clsLanguages.RM.GetString("00167");
            lblNationality.Text = Common.clsLanguages.RM.GetString("00250");
            lblPhoneNumber.Text = Common.clsLanguages.RM.GetString("00026");
            lblAddress.Text = Common.clsLanguages.RM.GetString("00117");
            lblCreator.Text = Common.clsLanguages.RM.GetString("00168");
            // lblIsLock.Text = Common.clsLanguages.RM.GetString("00119");
            chbIsLock.Text = Common.clsLanguages.RM.GetString("00170");
            lblLockDate.Text = Common.clsLanguages.RM.GetString("00370");

            gbMemberType.Text = Common.clsLanguages.RM.GetString("00177");
            lblTotalScore.Text = Common.clsLanguages.RM.GetString("00316");
            lblCurrentScore.Text = Common.clsLanguages.RM.GetString("00538");

            lblNumberOfVissits.Text = Common.clsLanguages.RM.GetString("00171");
            lblCreatedDate.Text = Common.clsLanguages.RM.GetString("00121");
            lblUpdatedDate.Text = Common.clsLanguages.RM.GetString("00122");

            //button set            
            btnAdd.Text = Common.clsLanguages.RM.GetString("00109");
            btnEdit.Text = Common.clsLanguages.RM.GetString("00188");
            btnReset.Text = Common.clsLanguages.RM.GetString("00134");
            btnDelete.Text = Common.clsLanguages.RM.GetString("00110");
            btnExit.Text = Common.clsLanguages.RM.GetString("00133");
            btnSave.Text = Common.clsLanguages.RM.GetString("00161");

            //Thêm vào sau này
            chBAutoID.Text = Common.clsLanguages.RM.GetString("00576");
            lblCallName.Text = Common.clsLanguages.RM.GetString("00583");

            lblRegency.Text = Common.clsLanguages.RM.GetString("00584");
            lblCompanyName.Text = Common.clsLanguages.RM.GetString("00582");
            lblCompanyEMail.Text = Common.clsLanguages.RM.GetString("00585");

            lblMobilePhone.Text = Common.clsLanguages.RM.GetString("00586");
            lblTaxCode.Text = Common.clsLanguages.RM.GetString("00587");
            lblDescription.Text = Common.clsLanguages.RM.GetString("00128");

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
        //private void frmUpdateMember_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        CreateObject();
        //        LoadData();
        //        this.dtpLastDate.Enabled = false;
        //        this.dtpCreatedDate.Enabled = false;
        //        this.dtpUpdatedDate.Enabled = false;

        //        SetUIChanges();
        //        if (ThemMoi== false)
        //        {
        //            btnEdit_Click(sender, e);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00292"),
        //                                       Common.clsLanguages.RM.GetString("00012"),
        //                                       Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //                                       Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //        return;
        //    }
        //}

        /// <summary>
        /// Event raise when user click save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Entities.Members member = new Entities.Members();
        //        //memberId
        //        member.MemberId = staticmemberId;
        //        //validate member code
        //        string strMemberCode = "";
        //        if (chBAutoID.Checked)
        //        {
        //            member.MemberCode = GetAutoMemberCode(cbbNationality.SelectedValue.ToString());
        //        }
        //        else
        //        {
        //            strMemberCode = txtMemberCode.Text.Trim();
        //            if (string.IsNullOrEmpty(strMemberCode))
        //            {
        //                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00037"),
        //                                Common.clsLanguages.RM.GetString("00011"),
        //                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //                return;
        //            }
        //            //else if (!Common.Validation.ValidateMemberNumber(strMemberCode))
        //            //{
        //            //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00371"),
        //            //                    Common.clsLanguages.RM.GetString("00012"),
        //            //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
        //            //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //            //    return;
        //            //}
        //            else
        //            {
        //                member.MemberCode = strMemberCode;
        //            }
        //        }
        //        //validate membername
        //        string strMemberName = txtMemerName.Text.Trim();
        //        if (string.IsNullOrEmpty(strMemberName))
        //        {
        //            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00312"),
        //                          Common.clsLanguages.RM.GetString("00011"),
        //                          Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //                          Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //            return;
        //        }
        //        else
        //        {
        //            member.MemberName = strMemberName;
        //        }

        //        //validate birthdate
        //        DateTime birthDate = dtpBirthDate.Value;
        //        //if (!Common.Validation.ValidateBirthDate(birthDate))
        //        //{
        //        //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00310"),
        //        //                   Common.clsLanguages.RM.GetString("00011"),
        //        //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //        //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //        //    return;
        //        //}
        //        //else
        //        //{
        //        member.BirthDate = birthDate;
        //        if (chkNgaySinh.Checked == true)
        //        {
        //            member.birthDay = true;
        //        }
        //        else
        //        {
        //            member.birthDay = false;
        //        }
        //        //}

        //        //validate email
        //        string strEmail = txtEmail.Text.Trim();
        //        //if (string.IsNullOrEmpty(strEmail))
        //        //{
        //        //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00372"),
        //        //                    Common.clsLanguages.RM.GetString("00011"),
        //        //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //        //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //        //    return;
        //        //}
        //        //else 
        //        //if (!String.IsNullOrEmpty(strEmail))
        //        //{
        //        //    if (!Common.Validation.ValidateEmail(strEmail))
        //        //    {
        //        //        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00311"),
        //        //                       Common.clsLanguages.RM.GetString("00011"),
        //        //                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //        //                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //        //        return;
        //        //    }
        //        //    else
        //        //    {
        //                member.Email = strEmail;
        //        //    }
        //        //}
        //        //validate phonenumber
        //        string strPhoneNumber = txtPhoneNumber.Text.Trim();
        //        //if (string.IsNullOrEmpty(strPhoneNumber))
        //        //{
        //        //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00046"),
        //        //                    Common.clsLanguages.RM.GetString("00011"),
        //        //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //        //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //        //    return;
        //        //}
        //        //else 
        //        //if (!String.IsNullOrEmpty(strPhoneNumber))
        //        //{
        //        //    if (!Common.Validation.ValidatePhoneNumber(strPhoneNumber))
        //        //    {
        //        //        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00047"),
        //        //                        Common.clsLanguages.RM.GetString("00012"),
        //        //                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
        //        //                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //        //        return;
        //        //    }
        //        //    else
        //        //    {
        //                member.PhoneNumber = strPhoneNumber;
        //           // }
        //       // }
        //        //address
        //        if (!string.IsNullOrEmpty(txtAddress.Text.Trim()))
        //        {
        //            member.Address = txtAddress.Text.Trim();
        //        }

        //        //validate nationality
        //        if (cbbNationality.Text == "")
        //        {
        //            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00373"),
        //                            Common.clsLanguages.RM.GetString("00011"),
        //                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //            return;
        //        }
        //        else
        //        {
        //            member.Country.CountryId = cbbNationality.SelectedValue.ToString();
        //        }

        //        //creator
        //        member.Creator.EmployeeId = cbbCreator.SelectedValue.ToString();

        //        //total score
        //        string strTotalScore = txtTotalScore.Text.Trim();
        //        if (!string.IsNullOrEmpty(strTotalScore))
        //        {
        //            if (!Common.Validation.ValidateNumber(strTotalScore))
        //            {
        //                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00098"),
        //                            Common.clsLanguages.RM.GetString("00012"),
        //                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
        //                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //                return;
        //            }
        //            else
        //            {
        //                member.TotalScore = Int32.Parse(strTotalScore);
        //            }
        //        }
        //        //total CurrentScore
        //        string strCurrentScore = txtCurrentScore.Text.Trim();
        //        if (!string.IsNullOrEmpty(strCurrentScore))
        //        {
        //            if (!Common.Validation.ValidateNumber(strCurrentScore))
        //            {
        //                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00098"),
        //                            Common.clsLanguages.RM.GetString("00012"),
        //                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
        //                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //                return;
        //            }
        //            else
        //            {
        //                member.CurrentScore = Int32.Parse(strCurrentScore);
        //            }
        //        }

        //        //numberOfVissits
        //        string strNumberOfVissits = txtNumberOfVissits.Text.Trim();
        //        if (!string.IsNullOrEmpty(strNumberOfVissits))
        //        {
        //            if (!Common.Validation.ValidateNumber(strNumberOfVissits))
        //            {
        //                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00098"),
        //                            Common.clsLanguages.RM.GetString("00012"),
        //                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
        //                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //                return;
        //            }
        //            else
        //            {
        //                member.NumberOfVissits = Int32.Parse(strNumberOfVissits);
        //            }
        //        }

        //        //member type
        //        //List<string> lstMemberTypeName = new List<string>();
        //        List<Entities.MemberType> lstMemberTypeName = new List<Entities.MemberType>();
        //        string memberType = "";
        //        for (int i = 0; i < lstMemberType.Items.Count; i++)
        //        {
        //            if (lstMemberType.GetItemChecked(i))
        //            {
        //                Entities.MemberType mt = new Entities.MemberType();
        //                DataRowView dr = (DataRowView)lstMemberType.Items[i];
        //                mt.MemberTypeId = int.Parse(dr["MemberTypeId"].ToString());
        //                mt.MemberTypeName = dr["MemberTypeName"].ToString();
        //                mt.MemberTypeName2 = dr["MemberTypeName2"].ToString();
        //                mt.MemberTypeName3 = dr["MemberTypeName3"].ToString();
        //                //mt.MemberTypeId
        //                lstMemberTypeName.Add(mt);
        //            }
        //        }
        //        if (lstMemberTypeName.Count != 0)
        //        {
        //            member.List_MemberType = lstMemberTypeName;
        //        }
        //        else
        //        {
        //            member.List_MemberType = null;
        //        }

        //        //member.MemberType.MemberTypeId = Int32.Parse(memberType);

        //        //Lastest Date
        //        member.LastestDate = DateTime.Now;
        //        //Created date
        //        member.CreatedDate = DateTime.Now;
        //        //Updated date
        //        member.UpdatedDate = DateTime.Now;

        //        //islock
        //        int isLock = 0;
        //        if (chbIsLock.Checked)
        //        {
        //            isLock = 1;
        //        }
        //        member.IsLock = isLock;

        //        //LockDate
        //        member.LockDate = DateTime.Now;

        //        //Điệp Add 20140418
        //        if (cbBRegency.SelectedValue != null)
        //        {
        //            member.Regency.RegencyID = int.Parse(cbBRegency.SelectedValue.ToString());
        //        }
        //        member.MobilePhone = txtMobilePhone.Text.Trim();
        //        member.Website = txtWebsite.Text.Trim();
        //        member.TaxCode = txtTaxCode.Text.Trim();
        //        member.CompanyName = txtCompanyName.Text.Trim();
        //        member.Description = txtDescription.Text.Trim();
        //        if(cbBCallName.SelectedValue != null)
        //        {
        //            member.CallName.CallNameID = (int)cbBCallName.SelectedValue;
        //        }                
        //        member.CompanyEmail = txtCompanyEmail.Text.Trim();


        //        //If is add
        //        if (blag)
        //        {
        //            if (memberBLL.CheckMemberCodeExist(strMemberCode))
        //            {
        //                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00539"),
        //                                Common.clsLanguages.RM.GetString("00012"),
        //                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
        //                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //                this.txtMemberCode.Clear();
        //                this.txtMemberCode.Focus();
        //                return;
        //            }
        //            memberBLL.Add(member);

        //            if (staticmemberId != null)
        //            {
        //                staticmemberId = member.MemberId;
        //            }
        //        }
        //        //If is edit
        //        else
        //        {

        //            memberBLL.Edit(member);
        //        }

        //        this.Close();
        //    }
        //    catch (Exception)
        //    {
        //        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00292"),
        //                                       Common.clsLanguages.RM.GetString("00012"),
        //                                       Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //                                       Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //        return;
        //    }
        //}

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
            try
            {
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00588"), Common.clsLanguages.RM.GetString("00589")) == DialogResult.Yes)
                {
                    if (staticmemberId == null)
                    {
                        ResetData();
                        this.Close();
                    }
                    else
                    {

                        //LoadData();

                        SetVisible(true);
                        SetEnable(false);
                    }
                }
            }
            catch (Exception)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00292"),
                                               Common.clsLanguages.RM.GetString("00012"),
                                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult r = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00374"),
        //                        Common.clsLanguages.RM.GetString("00011"),
        //                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
        //        if (r == DialogResult.Yes)
        //        {
        //            if (receiptBLL.CheckDeleteMemberByMemberId(staticmemberId))
        //            {
        //                memberBLL.Delete(staticmemberId);
        //                this.Close();
        //            }
        //            else
        //            {
        //                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00377"),
        //                        Common.clsLanguages.RM.GetString("00011"),
        //                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00292"),
        //                                       Common.clsLanguages.RM.GetString("00012"),
        //                                       Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
        //                                       Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
        //        return;
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SetEnable(true);
                ResetData();

                SetVisible(false);
                blag = true;
            }
            catch (Exception)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00292"),
                                               Common.clsLanguages.RM.GetString("00012"),
                                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEnable(true);
            SetVisible(false);
            blag = false;
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

        /// <summary>
        /// Set enable for text on form
        /// </summary>
        /// <param name="boolean"></param>
        private void SetEnable(bool boolean)
        {
            this.txtMemberCode.ReadOnly = !boolean;
            this.txtMemerName.ReadOnly = !boolean;
            this.cbBRegency.Enabled = boolean;
            this.txtCompanyName.ReadOnly = !boolean;
            this.txtAddress.ReadOnly = !boolean;

            this.dtpBirthDate.Enabled = boolean;
            this.cbbNationality.Enabled = boolean;

            this.txtEmail.ReadOnly = !boolean;
            this.txtCompanyEmail.ReadOnly = !boolean;

            this.txtPhoneNumber.ReadOnly = !boolean;
            this.txtMobilePhone.ReadOnly = !boolean;
            this.txtTaxCode.ReadOnly = !boolean;
            this.txtWebsite.ReadOnly = !boolean;
            this.txtDescription.ReadOnly = !boolean;

            this.cbbCreator.Enabled = boolean;
            this.cbBCallName.Enabled = boolean;

            this.txtTotalScore.ReadOnly = !boolean;
            this.txtNumberOfVissits.ReadOnly = !boolean;
            this.lstMemberType.Enabled = boolean;
            this.chbIsLock.Enabled = boolean;
            this.dtpLockDate.Enabled = boolean;

            this.txtCurrentScore.ReadOnly = !boolean;
        }

        /// <summary>
        /// Set hide or show for button
        /// </summary>
        /// <param name="boolean"></param>
        private void SetVisible(bool boolean)
        {
            this.btnEdit.Visible = boolean;
            this.btnDelete.Visible = boolean;
            this.btnAdd.Visible = boolean;
            this.btnExit.Visible = boolean;
            this.btnSave.Visible = !boolean;
            this.btnReset.Visible = !boolean;
        }

        //public void LoadData()
        //{
        //    //load membertype
        //    DataTable dt = new DataTable();
        //    dt = memberTypeBLL.GetListsNameNotNull();
        //    if (dt != null)
        //    {
        //        lstMemberType.DataSource = dt;
        //        if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
        //        {
        //            lstMemberType.DisplayMember = dt.Columns["MemberTypeName"].ToString();
        //        }
        //        else if (Common.clsLanguages.StrCulture.Equals("en-US"))
        //        {
        //            lstMemberType.DisplayMember = dt.Columns["MemberTypeName3"].ToString();
        //        }
        //        else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
        //        {
        //            lstMemberType.DisplayMember = dt.Columns["MemberTypeName2"].ToString();
        //        }

        //        lstMemberType.ValueMember = dt.Columns["MemberTypeId"].ToString();
        //    }
        //    //load data for cbb nationality
        //    DataTable dtCountry = new DataTable();
        //    dtCountry = countryBLL.GetLists();
        //    if (dtCountry != null)
        //    {
        //        this.cbbNationality.DataSource = dtCountry;
        //        if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
        //        {
        //            this.cbbNationality.DisplayMember = dtCountry.Columns["CountryName"].ToString();
        //        }
        //        else if (Common.clsLanguages.StrCulture.Equals("en-US"))
        //        {
        //            this.cbbNationality.DisplayMember = dtCountry.Columns["CountryName3"].ToString();
        //        }
        //        else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
        //        {
        //            this.cbbNationality.DisplayMember = dtCountry.Columns["CountryName2"].ToString();
        //        }
        //        this.cbbNationality.ValueMember = dtCountry.Columns["CountryId"].ToString();
        //    }
        //    //Điệp add 20140418

        //    //load data for cbb CallName
        //    DataTable dtCallName = new DataTable();
        //    dtCallName = callnameBLL.GetLists();
        //    if (dtCallName != null)
        //    {
        //        this.cbBCallName.DataSource = dtCallName;
        //        if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
        //        {
        //            this.cbBCallName.DisplayMember = dtCallName.Columns["Name1"].ToString();
        //        }
        //        else if (Common.clsLanguages.StrCulture.Equals("en-US"))
        //        {
        //            this.cbBCallName.DisplayMember = dtCallName.Columns["Name2"].ToString();
        //        }
        //        else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
        //        {
        //            this.cbBCallName.DisplayMember = dtCallName.Columns["Name3"].ToString();
        //        }
        //        this.cbBCallName.ValueMember = dtCallName.Columns["CallNameID"].ToString();
        //    }
        //    //load data for cbb Regency
        //    DataTable dtRegency = new DataTable();
        //    dtRegency = regencyBLL.GetLists();
        //    if (dtRegency != null)
        //    {
        //        this.cbBRegency.DataSource = dtRegency;
        //        if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
        //        {
        //            this.cbBRegency.DisplayMember = dtRegency.Columns["RegencyName"].ToString();
        //        }
        //        else if (Common.clsLanguages.StrCulture.Equals("en-US"))
        //        {
        //            this.cbBRegency.DisplayMember = dtRegency.Columns["RegencyName2"].ToString();
        //        }
        //        else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
        //        {
        //            this.cbBRegency.DisplayMember = dtRegency.Columns["RegencyName3"].ToString();
        //        }
        //        this.cbBRegency.ValueMember = dtRegency.Columns["RegencyID"].ToString();
        //    }

        //    //End Điệp add 20140418

        //    //load data for cbb Employee
        //    DataTable dtEmployee = new DataTable();
        //    dtEmployee = employeeBLL.GetLists();
        //    if (dtEmployee != null)
        //    {
        //        this.cbbCreator.DataSource = dtEmployee;
        //        this.cbbCreator.DisplayMember = dtEmployee.Columns["EmployeeName"].ToString();
        //        this.cbbCreator.ValueMember = dtEmployee.Columns["EmployeeId"].ToString();
        //    }
        //    if (staticmemberId == null)
        //    {
        //        SetEnable(true);
        //        this.cbbCreator.SelectedValue = Program.employee.EmployeeId;
        //        this.cbbCreator.Enabled = false;
        //        SetVisible(false);
        //        //this.Text = "Thêm mới thành viên";
        //        blag = true;
        //        this.cbbNationality.SelectedIndex =0;
        //        this.chbIsLock.Enabled = false;
        //        this.dtpLockDate.Enabled = false;
        //    }
        //    else
        //    {
        //        Entities.Member member = new Entities.Member();
        //        member = memberBLL.GetById(staticmemberId);
        //        this.txtMemberCode.Text = member.MemberCode;
        //        this.txtMemerName.Text = member.MemberName;
        //        if (member.birthDay == true)
        //        {
        //            this.chkNgaySinh.Checked = true;
        //        }
        //        else
        //        {
        //            this.chkNgaySinh.Checked = false;
        //        }
        //        this.dtpBirthDate.Value = member.BirthDate;
        //        this.txtEmail.Text = member.Email;
        //        this.txtPhoneNumber.Text = member.PhoneNumber;
        //        this.txtAddress.Text = member.Address;
        //        this.cbbNationality.SelectedValue = member.Country.CountryId;
        //        this.cbbCreator.SelectedValue = member.Creator.EmployeeId;
        //        this.txtTotalScore.Text = member.TotalScore.ToString();
        //        this.txtNumberOfVissits.Text = member.NumberOfVissits.ToString();
        //        this.dtpLastDate.Value = member.LastestDate;
        //        this.dtpCreatedDate.Value = member.CreatedDate;
        //        this.dtpUpdatedDate.Value = member.UpdatedDate;

        //        //Điệp edit
        //        this.txtCurrentScore.Text = member.CurrentScore.ToString();

        //        List<string> lstMemberTypeName = new List<string>();
        //        ///
        //        List<int> lst_mbt = new List<int>();
        //        if (member.List_MemberType != null)
        //        {
        //            foreach (Entities.MemberType mt in member.List_MemberType)
        //            {
        //                lst_mbt.Add(mt.MemberTypeId);
        //            }
        //        }

        //        lstMemberTypeName = memberTypeBLL.GetListMemberTypeName_New(lst_mbt);
        //        for (int i = 0; i < lstMemberType.Items.Count; i++)
        //        {
        //            string[] arr = lstMemberType.GetItemText(lstMemberType.Items[i]).Split('/');
        //            //lstMemberType.SetItemChecked(i, false);
        //            for (int j = 0; j < lstMemberTypeName.Count; j++)
        //            {
        //                if (arr[0].Equals(lstMemberTypeName[j]))
        //                {
        //                    lstMemberType.SetItemChecked(i, true);
        //                    break;
        //                }
        //            }

        //        }
        //        this.cbbCreator.SelectedValue = Program.employee.EmployeeId;
        //        this.cbbCreator.Enabled = false;

        //        if (member.IsLock == 1)
        //        {
        //            chbIsLock.Checked = true;
        //        }

        //        if (member.LockDate != new DateTime())
        //        {
        //            this.dtpLockDate.Value = member.LockDate;
        //        }

        //        //Điệp Add 20140418
        //        this.txtMobilePhone.Text = member.MobilePhone;
        //        this.txtWebsite.Text = member.Website;
        //        this.txtTaxCode.Text = member.TaxCode;
        //        this.txtCompanyName.Text = member.CompanyName;
        //        this.txtDescription.Text = member.Description;

        //        this.cbBCallName.SelectedValue = member.CallName.CallNameID;
        //        this.cbBRegency.SelectedValue = member.Regency.RegencyID;
        //        this.txtCompanyEmail.Text = member.CompanyEmail;
        //        //End Điệp add 20140418

        //        SetEnable(false);
        //    }
        //}

        //public void WriteData(string memberId)
        //{
        //    staticmemberId = memberId;
        //}

        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void frmUpdateMember_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    staticmemberId = null;
        //}

        //string pMCode = "";
        //private void chBAutoID_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBAutoID.Checked)
        //    {
        //        txtMemberCode.Enabled = false;
        //    }
        //    else
        //        txtMemberCode.Enabled = true;
        //}
        //public string GetAutoMemberCode(string pCountry)
        //{
        //    string pQG = "";
        //    string pNamThangNgay = "";
        //    int pAutoID = 1;
        //    pQG = cbbNationality.SelectedValue.ToString();
        //    pNamThangNgay = DateTime.Now.ToString("yy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd");
        //    string pkq = memberBLL.GetMemberCode();
        //    pAutoID = int.Parse(pkq.ToString()) + 1;

        //    string pKqAuto = "";
        //    if (pAutoID < 10)
        //    {
        //        pKqAuto = "0000" + pAutoID;
        //    }
        //    else if (pAutoID >= 10 && pAutoID < 100)
        //    {
        //        pKqAuto = "000" + pAutoID;
        //    }
        //    else if (pAutoID >= 100 && pAutoID < 1000)
        //    {
        //        pKqAuto = "00" + pAutoID;
        //    }
        //    else if (pAutoID >= 1000 && pAutoID < 10000)
        //    {
        //        pKqAuto = "0" + pAutoID;
        //    }
        //    else
        //    {
        //        pKqAuto = pAutoID.ToString();
        //    }
        //    return pQG + pNamThangNgay + pKqAuto;
        //}

        private void lstMemberType_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= lstMemberType.Items.Count; i++)
            {
               // lstMemberType.Items[i].
            }
        }
    }
}
