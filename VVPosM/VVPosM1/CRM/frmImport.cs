using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VVPosM1.BusinessLayer.BLLCRM;

namespace VVPosM1.CRM
{
    public partial class frmImport : Form
    {
        MemberBLL memberBLL;
        CountryBLL countryBLL;
        string countryID = "OT";
        int CallNameID = 3;
        EmployeeBLL employeeBLL;
        MemberTypeBLL memberTypeBLL;

        //Điệp Add 20140418
        CallNameBLL callnameBLL;
        RegencyBLL regencyBLL;

        private string filepath = string.Empty;
        public frmImport()
        {
            InitializeComponent();
        }

        private void SetUI()
        {
            gbLine.Text = Common.clsLanguages.GetResource("CRMlimit");
            lblFromLine.Text = Common.clsLanguages.GetResource("CRMfrom");
            lblToLine.Text = Common.clsLanguages.GetResource("CRMto");
            txtFirstLine.WaterMarkText = Common.clsLanguages.GetResource("CRMfromline");
            txtEndLine.WaterMarkText = Common.clsLanguages.GetResource("CRMtoline");
            gbInformation.Text = Common.clsLanguages.GetResource("CRM127");
            lblMemberCode.Text = Common.clsLanguages.GetResource("CRMCustomerID");
            chBAutoID.Text = Common.clsLanguages.GetResource("CRM576");
            lblPhoneNumber.Text = Common.clsLanguages.GetResource("CRM26");
            lblMobilePhone.Text = Common.clsLanguages.GetResource("CRMMobilePhone");
            lblMemberName.Text = Common.clsLanguages.GetResource("CRM113");
            lblRegency.Text = Common.clsLanguages.GetResource("CRM584");
            lblTaxCode.Text = Common.clsLanguages.GetResource("CRM587");
            lblCompanyName.Text = Common.clsLanguages.GetResource("CRM582");
            lblAddress.Text = Common.clsLanguages.GetResource("CRM117");
            lblDescription.Text = Common.clsLanguages.GetResource("CRM128");
            lblBirthDate.Text = Common.clsLanguages.GetResource("CRM105");
            lblCreator.Text = Common.clsLanguages.GetResource("CRM641");
            txtMemberCode.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            txtCompanyEmail.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            txtMemerName.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            txtPhoneNumber.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            txtMobilePhone.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            txtChucDanh.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            txtTaxCode.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            txtCompanyName.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            txtWebsite.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            txtAddress.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            txtDescription.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            txtBirthday.WaterMarkText = Common.clsLanguages.GetResource("CRMcol");
            lblNote.Text = Common.clsLanguages.GetResource("CRM630");
            lblCol.Text = Common.clsLanguages.GetResource("CRM631");
            lblReque.Text = Common.clsLanguages.GetResource("CRM632");
            lblInfo.Text = Common.clsLanguages.GetResource("CRM633");
            gbFile.Text = Common.clsLanguages.GetResource("CRM634");
            lblFile.Text = Common.clsLanguages.GetResource("CRM640");
            btnReset.Text = Common.clsLanguages.GetResource("CRM134");
            chBOveride.Text = Common.clsLanguages.GetResource("CRM635");
            cbbDatetimeFormat.SelectedIndex = 0;

        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            CreateObject();
            LoadData();
            SetUI();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // Set filter options and filter index.
            dialog.Filter = "Excel Files|*.xls;*.xlsx";
            dialog.FilterIndex = 1;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = dialog.FileName;
                filepath = dialog.FileName;
            }
            else
            {
                txtFile.Text = string.Empty;
                filepath = string.Empty;
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean checkLimitData()
        {
            Boolean bFlag = false;
            int MaxData = 65000;
            if (txtFirstLine.Text != string.Empty && txtEndLine.Text != string.Empty)
            {
                try
                {
                    if (int.Parse(txtFirstLine.Text) > MaxData || int.Parse(txtEndLine.Text) > MaxData)
                    {
                        bFlag = false;
                    }
                    else if (int.Parse(txtFirstLine.Text) > int.Parse(txtEndLine.Text))
                    {
                        bFlag = false;
                    }
                    else
                    {
                        bFlag = true;
                    }
                }
                catch (Exception)
                {
                    bFlag = false;
                }
            }                       

            return bFlag;
        }

        private void CreateObject()
        {
            memberBLL = new MemberBLL();
            countryBLL = new CountryBLL();
            employeeBLL = new EmployeeBLL();
            memberTypeBLL = new MemberTypeBLL();
            callnameBLL = new CallNameBLL();
            regencyBLL = new RegencyBLL();
        }

        private void LoadData()
        {
            //load data for cbb Employee
            DataTable dtEmployee = new DataTable();
            dtEmployee = employeeBLL.GetLists();
            if (dtEmployee != null)
            {
                this.cbbCreator.DataSource = dtEmployee;
                this.cbbCreator.DisplayMember = dtEmployee.Columns["EmployeeName"].ToString();
                this.cbbCreator.ValueMember = dtEmployee.Columns["EmployeeId"].ToString();

                try
                {
                    cbbCreator.SelectedValue = Program.employee1.EmployeeId;
                }
                catch (Exception) { }
            }
        }

        private void srollEndLine()
        {
            rTxtLog.SelectionStart = rTxtLog.Text.Length;
            rTxtLog.ScrollToCaret();
        }

        private Boolean validation()
        {
            Boolean bFlag = false;
            if (filepath != string.Empty)
            {
                if (checkLimitData() == true)
                {
                    if (txtMemberCode.Text == string.Empty)
                    {
                        if (chBAutoID.Checked == false)
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM37"),
                                            Common.clsLanguages.GetResource("CRM12"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                        else
                        {
                            //if (txtMemerName.Text == string.Empty || txtCompanyName.Text == string.Empty)
                            //{
                            //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM628"),
                            //                    Common.clsLanguages.GetResource("CRM11"),
                            //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                            //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                            //}

                            if (txtMemerName.Text != string.Empty || txtCompanyName.Text != string.Empty)
                            {
                                bFlag = true;
                            }
                            else
                            {
                                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM628"),
                                               Common.clsLanguages.GetResource("CRM11"),
                                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                            }
                        }                        
                    }
                    else
                    {
                        if (txtMemerName.Text != string.Empty || txtCompanyName.Text != string.Empty)
                        {
                            bFlag = true;
                        }
                        else
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM628"),
                                           Common.clsLanguages.GetResource("CRM11"),
                                           Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                           Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                    }
                }
                else
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM627"),
                                                       Common.clsLanguages.GetResource("CRM12"),
                                                       Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                                       Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                }   
                
            }
            else
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM626"),
                                               Common.clsLanguages.GetResource("CRM12"),
                                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }   
            return bFlag;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            //rTxtLog.Text = string.Empty;
            Cursor.Current = Cursors.WaitCursor;
            
                string connString = string.Empty;
                string status   = "Status: \t";
                string serror   = "Error:  \t";
                string swaring  = "Waring: \t";

                BusinessLayer.BLLCRM.MemberBLL memberBLL = new BusinessLayer.BLLCRM.MemberBLL();
                if (validation())
                {
                    rTxtLog.AppendText(status + "Opening Excel File...\n");
                    rTxtLog.AppendText(status + "File is opened, waiting for welcome message...\n");

                    DataTable dtExcel = VVPosM1.BusinessLayer.BLLCRM.ImportMember.ReadExcelFile(filepath);
                        Boolean bFlagUpdate = false;
                        int iRowError = 0;
                        int iRowSuccess = 0;
                        int iTotalRecord = 0;

                        //Set Column Label
                        string strMemberCode    =   txtMemberCode.Text.Trim();
                        string[] strFullName    =   txtMemerName.Text.Split(';');
                        string strChucDanh      =   txtChucDanh.Text.Trim();
                        string strCompanyName   =   txtCompanyName.Text.Trim();
                        string strAddress       =   txtAddress.Text.Trim();
                        string[] strEmails      =   txtCompanyEmail.Text.Split(';');
                        string strPhone         =   txtPhoneNumber.Text;
                        string strmPhone        =   txtMobilePhone.Text;
                        string strWebsite       =   txtWebsite.Text;
                        string strTaxCode       =   txtTaxCode.Text;
                        string[] strNotes       =   txtDescription.Text.Split(';');
                        string strBirthDay      =   txtBirthday.Text;

                        int iTemps = -1;

                        string strTemp          =   string.Empty;
                        int iBegin              =   (int.Parse(txtFirstLine.Text) - 1) > 0 ? int.Parse(txtFirstLine.Text) - 1 : 0;


                        for (int iCount = iBegin; iCount < int.Parse(txtEndLine.Text); iCount++)
                        {
                               
                            if (iCount >= dtExcel.Rows.Count)
                            {
                                break;
                            }

                            DataRow dr = dtExcel.Rows[iCount];
                            Entities.Member member = new Entities.Member();
                            int iLineError = 0;

                            //Count total record
                            iTotalRecord++;

                            rTxtLog.AppendText("Reading line: " + iTotalRecord.ToString() + "\n");
                                                        
                                //Get Col MemberCode
                                if (chBAutoID.Checked == true)
                                {
                                    try
                                    {
                                        member.MemberCode = BusinessLayer.BLLCRM.ImportMember.GetAutoMemberCode();
                                    }
                                    catch (Exception)
                                    {
                                        rTxtLog.AppendText(swaring + "Customer code is null.\n");
                                        iLineError++;
                                    }
                                }
                                else
                                {
                                    iTemps = BusinessLayer.BLLCRM.ImportMember.returnCellName(strMemberCode);
                                    
                                        try
                                        {
                                            if (dr[iTemps].ToString() != string.Empty)
                                            {
                                                member.MemberCode = dr[iTemps].ToString();

                                                    //Check exists
                                                    if (chBOveride.Checked == true)
                                                    {
                                                        if (memberBLL.CheckMemberCodeExist(member.MemberCode))
                                                        {
                                                            if (memberBLL.getMemberId(member.MemberCode) != string.Empty)
                                                            {
                                                                member.MemberId = memberBLL.getMemberId(member.MemberCode);
                                                                bFlagUpdate = true;
                                                            }
                                                            else
                                                            {
                                                                rTxtLog.AppendText(serror + "Customer ID is not getted. SQL command error.\n");
                                                                iLineError++;
                                                            }
                                                        }
                                                    }
                                              
                                            }
                                            else
                                            {
                                                rTxtLog.AppendText(serror + "Customer code is null.\n");
                                                iLineError++;
                                            }                                            
                                        }
                                        catch (Exception)
                                        {
                                            rTxtLog.AppendText(serror + "Customer code is null.\n");
                                            iLineError++;
                                        }                                    
                                }

                                 
                            //Get Fullname
                            strTemp = string.Empty;
                            if (strFullName.Length > 0)
                            {
                                foreach (var item in strFullName)
                                {
                                    if (item != "")
                                    {
                                        iTemps = BusinessLayer.BLLCRM.ImportMember.returnCellName(item.Trim());
                                        try
                                        {
                                            strTemp += dr[iTemps].ToString() + " ";
                                        }
                                        catch (Exception)
                                        {
                                            rTxtLog.AppendText(serror + "Column " + item + ": data not found.\n");
                                            //iLineError++;
                                        }
                                    }
                                }
                            }                            
                            
                            member.MemberName = strTemp.Trim();
                            

                            //Get Chuc Danh

                            if (strChucDanh != string.Empty)
                            {
                                iTemps = BusinessLayer.BLLCRM.ImportMember.returnCellName(strChucDanh);

                                try
                                {
                                    member.Regency = dr[iTemps].ToString();
                                }
                                catch (Exception)
                                {
                                    member.Regency = string.Empty;
                                    rTxtLog.AppendText(serror + "Column " + strChucDanh + ": data not found.\n");
                                }
                            }
                            else
                            {
                                member.Regency = string.Empty;
                            }    
                        

                            //Get Company name
                            if (strCompanyName != string.Empty)
                            {
                                iTemps = BusinessLayer.BLLCRM.ImportMember.returnCellName(strCompanyName);
                                try
                                {
                                    member.CompanyName = dr[iTemps].ToString();
                                }
                                catch (Exception)
                                {
                                    member.CompanyName = string.Empty;
                                    rTxtLog.AppendText(serror + "Column " + strCompanyName + ": data not found.\n");
                                }
                            }
                            else
                            {
                                member.CompanyName = string.Empty;
                            }

                            //Check Member name or Company name is not null
                            if (member.MemberName == string.Empty && member.CompanyName == string.Empty)
                            {
                                iLineError++;
                                rTxtLog.AppendText(serror + "Customer name or company name are not null.\n");
                            }
                            else
                            {
                                if (member.MemberName == string.Empty)
                                {
                                    rTxtLog.AppendText(swaring + "Customer name is null\n");
                                }

                                if(member.CompanyName == string.Empty)
                                {
                                    rTxtLog.AppendText(swaring + "Company name is null\n");
                                }
                            }

                            //Get Address
                            if (strAddress != string.Empty)
                            {
                                iTemps = BusinessLayer.BLLCRM.ImportMember.returnCellName(strAddress);

                                try
                                {
                                    member.Address = dr[iTemps].ToString();
                                }
                                catch (Exception)
                                {
                                    member.Address = string.Empty;
                                    rTxtLog.AppendText(serror + "Column " + strAddress + ": data not found.\n");
                                }
                            }
                            else
                            {
                                member.Address = string.Empty;
                            }
                            

                            //Get Email
                            strTemp = string.Empty;
                            int iTemp = 1;

                            if (strEmails.Length > 0)
                            {
                                foreach (var item in strEmails)
                                {
                                    if (item != "")
                                    {
                                        try
                                        {
                                            iTemps = BusinessLayer.BLLCRM.ImportMember.returnCellName(item.Trim());
                                            if (Common.Validation.ValidateEmail(dr[iTemps].ToString()))
                                            {
                                                strTemp += dr[iTemps].ToString() + ";";
                                            }
                                            else
                                            {
                                                rTxtLog.AppendText(swaring + "Email " + iTemp + ": incorrect email format.\n");
                                                iTemp++;
                                                //iLineError++;
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            rTxtLog.AppendText(swaring + "Column " + item + ": data not found.\n");
                                            //iLineError++;
                                        }
                                    }
                                }
                            }

                            char[] charsToTrim = { ',', '.', ' ', ';' };
                            strTemp = strTemp.Trim();
                            strTemp = strTemp.TrimEnd(charsToTrim);
                            member.CompanyEmail = strTemp;
                            member.Email = strTemp;

                            //Get Phone number
                            if (strPhone != string.Empty)
                            {
                                iTemps = ImportMember.returnCellName(strPhone);
                                try
                                {
                                    member.PhoneNumber = dr[iTemps].ToString();
                                }
                                catch (Exception)
                                {
                                    member.PhoneNumber = string.Empty;
                                    rTxtLog.AppendText(swaring + "Column " + strPhone + ": data not found.\n");
                                }
                            }
                            else
                            {
                                member.PhoneNumber = string.Empty;
                            }
                            

                            //Get mobile phone
                            if (strmPhone != string.Empty)
                            {
                                iTemps = ImportMember.returnCellName(strmPhone);
                                try
                                {
                                    member.MobilePhone = dr[iTemps].ToString();
                                }
                                catch (Exception)
                                {
                                    member.MobilePhone = string.Empty;
                                    rTxtLog.AppendText(swaring + "Column " + strmPhone + ": data not found.\n");
                                }
                            }
                            else
                            {
                                member.MobilePhone = string.Empty;
                            }                            

                            //Get Tax code
                            if (strTaxCode != string.Empty)
                            {
                                iTemps = ImportMember.returnCellName(strTaxCode);
                                try
                                {
                                    member.TaxCode = dr[iTemps].ToString();
                                }
                                catch (Exception)
                                {
                                    member.TaxCode = string.Empty;
                                    rTxtLog.AppendText(swaring + "Column " + strTaxCode + ": data not found.\n");
                                }
                            }
                            else
                            {
                                member.TaxCode = string.Empty;
                            }
                            

                            //Get website
                            if (strWebsite != string.Empty)
                            {
                                iTemps = ImportMember.returnCellName(strWebsite);
                                try
                                {
                                    if (Common.Validation.ValidateWebsite(dr[iTemps].ToString()))
                                    {
                                        member.Website = dr[iTemps].ToString();
                                    }
                                    else
                                    {
                                        rTxtLog.AppendText(swaring + "Website incorrect format.\n");
                                    }
                                }
                                catch (Exception)
                                {
                                    member.Website = string.Empty;
                                    rTxtLog.AppendText(swaring + "Column " + strWebsite + ": data not found.\n");
                                }
                            }
                            else
                            {
                                member.Website = string.Empty;
                            }
                            


                            strTemp = string.Empty;
                            iTemp = 1;

                            
                            if (strNotes.Length > 0)
                            {
                                foreach (var item in strNotes)
                                {
                                    iTemps = ImportMember.returnCellName(item.Trim());
                                    try
                                    {
                                        strTemp += (dr[iTemps].ToString() + "'\r\n'");
                                    }
                                    catch (Exception)
                                    {
                                        rTxtLog.AppendText(swaring + "Column " + item + ": data not found.\n");
                                    }
                                }
                            }


                            member.Description  = strTemp;

                            //Get birthday
                            if (strBirthDay != string.Empty)
                            {
                                iTemps = ImportMember.returnCellName(strBirthDay);
                                try
                                {
                                    member.birthDay = true;
                                    member.BirthDate = DateTime.ParseExact(dr[iTemps].ToString(), cbbDatetimeFormat.SelectedItem.ToString(), System.Globalization.DateTimeFormatInfo.CurrentInfo, System.Globalization.DateTimeStyles.None); //Common.Utility.StringToDateTimeVer2(dr[iTemps].ToString());                                    
                                }
                                catch (Exception)
                                {
                                    member.birthDay = false;
                                    //member.BirthDate =  DateTime.Now;
                                    rTxtLog.AppendText(swaring + "Column " + strBirthDay + ": data not found.\n");
                                }
                            }
                            else
                            {
                                member.birthDay = false;
                                member.BirthDate = DateTime.Now;
                            }

                            //creator
                            member.Creator.EmployeeId = Program.employee1.EmployeeId;
                            member.Curator.EmployeeId = cbbCreator.SelectedValue.ToString();

                            //Get Country ID OT
                            member.Country.CountryId  = countryID;

                            //Member Type
                            List<Entities.MemberType> lstMemberTypeName = new List<Entities.MemberType>();
                            MemberTypeBLL mt = new MemberTypeBLL();
                            DataTable dt = mt.GetLists();                            
                            Entities.MemberType mbt = new Entities.MemberType();

                            int iFlag = 0;
                            foreach (DataRow drtemp in dt.Rows)
                            {
                                if(drtemp["MemberTypeCode"].ToString().Equals("OT"))
                                {
                                    mbt.MemberTypeId = int.Parse(drtemp["MemberTypeId"].ToString());
                                    mbt.MemberTypeName = drtemp["MemberTypeName"].ToString();
                                    mbt.MemberTypeName2 = drtemp["MemberTypeName2"].ToString();
                                    mbt.MemberTypeName3 = drtemp["MemberTypeName3"].ToString();
                                    mbt.MemberTypeCode= drtemp["MemberTypeCode"].ToString();
                                    iFlag = 1;
                                    break;
                                }                               
                            }
                            
                            if(iFlag == 0)
                            {
                                    mbt.MemberTypeId = int.Parse(dt.Rows[0]["MemberTypeId"].ToString());
                                    mbt.MemberTypeName = dt.Rows[0]["MemberTypeName"].ToString();
                                    mbt.MemberTypeName2 = dt.Rows[0]["MemberTypeName2"].ToString();
                                    mbt.MemberTypeName3 = dt.Rows[0]["MemberTypeName3"].ToString();
                                    mbt.MemberTypeCode= dt.Rows[0]["MemberTypeCode"].ToString();
                            }
                            
                            lstMemberTypeName.Add(mbt);
                            
                            member.List_MemberType = lstMemberTypeName;
                            
                            //member.Email        = string.Empty;
                            
                            member.TotalScore   = 0;
                            member.CurrentScore = 0;
                            member.NumberOfVissits = 0;
                            member.IsLock       = 0;
                            member.CallName.CallNameID = CallNameID;
                            //Lastest Date
                            member.LastestDate = DateTime.Now;
                            //Created date
                            member.CreatedDate = DateTime.Now;
                            //Updated date
                            member.UpdatedDate = DateTime.Now;

                            if(chBOveride.Checked == true)
                            {
                                if(bFlagUpdate == true)
                                {
                                    try
                                    {
                                        memberBLL.Edit(member);
                                    }
                                    catch(Exception)
                                    {
                                        rTxtLog.AppendText(status + "Row " + iTotalRecord.ToString() + " is not update.\n");
                                        iLineError++;
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        if (!memberBLL.CheckMemberCodeExist(member.MemberCode))
                                        {
                                            memberBLL.Add(member);
                                        }
                                        else
                                        {
                                            rTxtLog.AppendText(status + "Row " + iTotalRecord.ToString() + ": member code is exists.\n");
                                            iLineError++;
                                        }
                                    }
                                    catch(Exception)
                                    {
                                        rTxtLog.AppendText(status + "Row " + iTotalRecord.ToString() + " is not insert.\n");
                                        iLineError++;
                                    }
                                }
                            }
                            else
                            {
                                    try
                                    {
                                        if (!memberBLL.CheckMemberCodeExist(member.MemberCode))
                                        {
                                            memberBLL.Add(member);
                                        }
                                        else
                                        {
                                            rTxtLog.AppendText(status + "Row " + iTotalRecord.ToString() + ": member code is exists.\n");
                                            iLineError++;
                                        }
                                    }
                                    catch(Exception)
                                    {
                                        rTxtLog.AppendText(status + "Row " + iTotalRecord.ToString() + " is not insert.\n");
                                        iLineError++;
                                    }
                            }
                            

                            if (iLineError == 0)
                            {
                                rTxtLog.AppendText(status + "Row " + iTotalRecord.ToString() + " is inserted database.\n");    
                                iRowSuccess++;
                            }
                            else
                            {
                                rTxtLog.AppendText(status + "Row " + iTotalRecord.ToString() + " is error.\n");
                                iRowError++;
                            }
                            iLineError = 0;
                        }        

                        rTxtLog.AppendText(status + "Closing Excel File...\n");
                        rTxtLog.AppendText(status + "File is closed\n");
                        rTxtLog.AppendText(iRowError + " error record. " + iRowSuccess + " success record.\n");
                        rTxtLog.AppendText("Total " + iTotalRecord.ToString() + " record.\n");

                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM629"),
                                            Common.clsLanguages.GetResource("CRM11"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);

                }                         
        }

       

        private void txtMemberCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void chBAutoID_CheckedChanged(object sender, EventArgs e)
        {
            if (chBAutoID.Checked)
            {
                txtMemberCode.Enabled = false;
            }
            else
            {
                txtMemberCode.Enabled = true;
            }
        }

        private void txtFirstLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
