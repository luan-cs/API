using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using VVPosM1.BusinessLayer.BLLCRM;
using System.Globalization;

namespace VVPosM1.Screen.CRM.Employee
{
    public partial class frmAddAccount : Form
    {
        CountryBLL countryBLL = new CountryBLL();
        EmployeeBLL employeeBLL = new EmployeeBLL();
        EmployeeTypeBLL employeeTypeBLL = new EmployeeTypeBLL();
        RoleBLL roleBLL = new RoleBLL();

        private Entities.Employees1 employee;
        bool pStatusAdd = false;
        string imagePath = "";
        private void SettingControl()
        {
            //setting background for form
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            //setting title
            //this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLOR);
            //gbInformationSearch
            this.gbInformationSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.gbInformation.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);

            this.lblEmployeeNameId.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtEmployeeCode.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.lblEmployeeId.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblEmployeeName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtEmployeeName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblGender.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.rdBFemal.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.rdBMale.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblBirthday.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.dteTBirthday.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblPhoneNumber.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtPhoneNumber.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblCountry.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbBCountry.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblAddress.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtAddress.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblEmployeeType.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtAddress.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblEmployeeType.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.cbBEmployeeType.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblHourlyWages.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtHourlyWages.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblNote.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtNote.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblUserName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtUserName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblRole.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.lblRole.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.chkBManager.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.rdManager.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.chkBReception.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.rdEmployee.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.chkBTablet.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);

            this.btnCancel.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnSave.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnChoseImage.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
        }
        /// <summary>
        /// Set text for control
        /// </summary>
        private void SetUIChanges()
        {
            this.Text = Common.clsLanguages.GetResource("CRM343");
            gbInformationSearch.Text = Common.clsLanguages.GetResource("CRM127");
            //this.Text = Common.clsLanguages.GetResource("CRM137");
            lblEmployeeNameId.Text = Common.clsLanguages.GetResource("CRM103");
            //lblEmployeeId.Text = Common.clsLanguages.GetResource("CRM103");
            lblEmployeeName.Text = Common.clsLanguages.GetResource("CRM113");
            lblGender.Text = Common.clsLanguages.GetResource("CRM114");
            //chkBGender.Text = Common.clsLanguages.GetResource("CRM114");
            lblBirthday.Text = Common.clsLanguages.GetResource("CRM105");

            lblEmail.Text = Common.clsLanguages.GetResource("CRM116");
            lblPhoneNumber.Text = Common.clsLanguages.GetResource("CRM115");
            lblCountry.Text = Common.clsLanguages.GetResource("CRM118");
            lblAddress.Text = Common.clsLanguages.GetResource("CRM117");

            lblEmployeeType.Text = Common.clsLanguages.GetResource("CRM145");

            lblHourlyWages.Text = Common.clsLanguages.GetResource("CRM120");
            lblNote.Text = Common.clsLanguages.GetResource("CRM128");
            gbInformation.Text = Common.clsLanguages.GetResource("CRM129");
            lblUserName.Text = Common.clsLanguages.GetResource("CRM6");
            lblPassword.Text = Common.clsLanguages.GetResource("CRM7");
            lblRole.Text = Common.clsLanguages.GetResource("CRM130");
            chkBManager.Text = Common.clsLanguages.GetResource("CRM341");
            rdManager.Text = Common.clsLanguages.GetResource("CRM341");
            chkBReception.Text = Common.clsLanguages.GetResource("CRM131");
            rdEmployee.Text = Common.clsLanguages.GetResource("CRM131");
            chkBTablet.Text = Common.clsLanguages.GetResource("CRM132");

            rdBFemal.Text = Common.clsLanguages.GetResource("CRM342");
            rdBMale.Text = Common.clsLanguages.GetResource("CRM520");

            //button set            
            btnCancel.Text = Common.clsLanguages.GetResource("CRM133");
            btnSave.Text = Common.clsLanguages.GetResource("CRM161");
            btnChoseImage.Text = Common.clsLanguages.GetResource("CRM135");
            lblconfirmpass.Text = Common.clsLanguages.GetResource("CRM59");
        }

        public frmAddAccount()
        {
            employee = new Entities.Employees1();

            if (!frmEmployee.pStatusAddEmployee)
            {
                employee = frmEmployee.employee;
            }

            InitializeComponent();
            SettingControl();
        }

        private void IsBeginLoad(bool enable)
        {
            txtEmployeeCode.Enabled = enable;
            txtEmployeeName.Enabled = enable;
            dteTBirthday.Enabled = enable;
            txtEmail.Enabled = enable;
            txtPhoneNumber.Enabled = enable;
            cbBCountry.Enabled = enable;
            txtAddress.Enabled = enable;
            cbBEmployeeType.Enabled = enable;
            txtHourlyWages.Enabled = enable;
            txtNote.Enabled = enable;
            txtUserName.Enabled = enable;
            txtPassword.Enabled = enable;
            chkBManager.Enabled = enable;
            chkBReception.Enabled = enable;
            chkBTablet.Enabled = enable;
            btnChoseImage.Enabled = enable;
            btnSave.Visible = enable;
        }

        private void Display(Entities.Employees1 pEmployee)
        {
            if (pEmployee != null && !string.IsNullOrEmpty(pEmployee.EmployeeId))
            {
                lblEmployeeId.Text = pEmployee.EmployeeId;
                txtEmployeeCode.Text = pEmployee.EmployeeCode;
                txtEmployeeName.Text = pEmployee.EmployeeName;

                if (pEmployee.Gender == 0)
                    //chkBGender.Checked = true;
                    rdBFemal.Checked = true;
                else
                    //chkBGender.Checked = false;
                    rdBMale.Checked = true;

                dteTBirthday.Value = pEmployee.BirthDate;
                txtEmail.Text = pEmployee.Email;
                txtPhoneNumber.Text = pEmployee.PhoneNumber;
                cbBCountry.SelectedValue = pEmployee.Country.CountryId;

                txtAddress.Text = pEmployee.Address;
                cbBEmployeeType.SelectedValue = pEmployee.EmployeeType.EmployeeTypeId;
                txtHourlyWages.Text = pEmployee.HourlyWages.ToString();
                txtNote.Text = System.Text.RegularExpressions.Regex.Replace(pEmployee.Notes, "\n", "\r\n");
                txtUserName.Text = pEmployee.UserName;
                txtPassword.Text = "";
                //txtPassword.Text = pEmployee.Password;
                picBoxImage.Image = pEmployee.Image;
                //chkBManager.Checked = false;
                chkBReception.Checked = false;
                chkBTablet.Checked = false;
                txtPassword.Enabled = false;
                txtConfirm.Enabled = false;
                //txtConfirm.Enabled = false;
                chkBManager.Enabled = false;
                //rdManager.Enabled = false;
                chkBReception.Enabled = false;
                //rdEmployee.Enabled = false;

                DataTable employeeRoleTable = roleBLL.GetByUserId(pEmployee.EmployeeId);
                foreach (DataRow dataRow in employeeRoleTable.Rows)
                {
                    if (dataRow["RoleId"].ToString().Trim() == "admin")
                    {
                        chkBManager.Checked = true;
                        rdManager.Checked = true;
                    }

                    if (dataRow["RoleId"].ToString().Trim() == "letan")
                    {
                        chkBReception.Checked = true;
                        rdEmployee.Checked = true;
                    }

                    if (dataRow["RoleId"].ToString().Trim() == "tablet")
                        chkBTablet.Checked = true;

                }
            }
            else
            {
                lblEmployeeId.Text = "";
                txtEmployeeCode.Text = "";
                txtEmployeeName.Text = "";
                // chkBGender.Checked = true;
                dteTBirthday.Value = DateTime.Now;
                txtEmail.Text = "";
                txtPhoneNumber.Text = "";
                cbBCountry.SelectedIndex = 0;
                txtAddress.Text = "";
                cbBEmployeeType.SelectedIndex = 0;
                txtHourlyWages.Text = "";
                txtNote.Text = "";
                txtUserName.Text = "";
                txtPassword.Text = "";
                picBoxImage.Image = null;
                chkBManager.Checked = false;
                rdManager.Checked = false;
                //rdEmployee.Checked = true;
                //chkBReception.Checked = false;
                chkBTablet.Checked = false;
            }
        }

        private Entities.Employees1 SetEmployee()
        {
            Entities.Employees1 emp = new VVPosM1.Entities.Employees1()
            {
                EmployeeId = lblEmployeeId.Text,
                EmployeeCode = txtEmployeeCode.Text.Trim(),
                EmployeeName = txtEmployeeName.Text
            };

            if (rdBFemal.Checked == true)
                emp.Gender = 0;
            else
                emp.Gender = 1;
            emp.BirthDate = dteTBirthday.Value;
            emp.Email = txtEmail.Text;
            emp.PhoneNumber = txtPhoneNumber.Text;
            emp.Country.CountryId = cbBCountry.SelectedValue.ToString();
            emp.Address = txtAddress.Text;
            emp.EmployeeType.EmployeeTypeId = cbBEmployeeType.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(txtHourlyWages.Text.Trim()))
                emp.HourlyWages = GetNumberFromString(txtHourlyWages.Text.Trim());
            emp.Notes = txtNote.Text;
            emp.UserName = txtUserName.Text;

            if (!string.IsNullOrEmpty(txtPassword.Text))
                emp.Password = Program.ConvertStringToMD5(txtPassword.Text.Trim());
            else
                emp.Password = employee.Password;

            emp.CreatedDate = DateTime.Now;
            emp.UpdatedDate = DateTime.Now;
            if (!string.IsNullOrEmpty(imagePath))
            {
                emp.Image = Image.FromFile(imagePath);
            }            
            return emp;
        }

        /// <summary>
        /// cbBCountry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetList_Country()
        {
            DataTable dataTableCountry = countryBLL.GetLists();
            cbBCountry.DataSource = dataTableCountry;

            if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
            {
                DataRow rowContry = dataTableCountry.NewRow();
                rowContry["CountryId"] = "0000";
                rowContry["CountryName"] = "<-- " + Common.clsLanguages.GetResource("CRM393") + " -->";
                dataTableCountry.Rows.InsertAt(rowContry, 0);

                cbBCountry.DisplayMember = "CountryName";
            }
            else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
            {
                DataRow rowContry = dataTableCountry.NewRow();
                rowContry["CountryId"] = "0000";
                rowContry["CountryName2"] = "<-- " + Common.clsLanguages.GetResource("CRM393") + " -->";
                dataTableCountry.Rows.InsertAt(rowContry, 0);

                cbBCountry.DisplayMember = "CountryName2";
            }
            else if (Common.clsLanguages.StrCulture.Equals("en-US"))
            {
                DataRow rowContry = dataTableCountry.NewRow();
                rowContry["CountryId"] = "0000";
                rowContry["CountryName3"] = "<-- " + Common.clsLanguages.GetResource("CRM393") + " -->";
                dataTableCountry.Rows.InsertAt(rowContry, 0);

                cbBCountry.DisplayMember = "CountryName3";
            }
            cbBCountry.ValueMember = "CountryId";
        }

        // Get data from table EmployeeTyepe        
        private void GetLists_InEmployeeType()
        {

            DataTable empTypeTable = employeeTypeBLL.GetLists();
            cbBEmployeeType.DataSource = empTypeTable;

            if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
            {
                DataRow rowEmpType = empTypeTable.NewRow();
                rowEmpType["EmployeeTypeId"] = "000";
                rowEmpType["EmployeeTypeName"] = "<-- " + Common.clsLanguages.GetResource("CRM145") + " -->";
                empTypeTable.Rows.InsertAt(rowEmpType, 0);
                cbBEmployeeType.DisplayMember = "EmployeeTypeName";
            }
            else if (Common.clsLanguages.StrCulture.Equals("en-US"))
            {
                DataRow rowEmpType = empTypeTable.NewRow();
                rowEmpType["EmployeeTypeId"] = "000";
                rowEmpType["EmployeeTypeName3"] = "<-- " + Common.clsLanguages.GetResource("CRM145") + " -->";
                empTypeTable.Rows.InsertAt(rowEmpType, 0);
                cbBEmployeeType.DisplayMember = "EmployeeTypeName3";
            }
            else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
            {
                DataRow rowEmpType = empTypeTable.NewRow();
                rowEmpType["EmployeeTypeId"] = "000";
                rowEmpType["EmployeeTypeName2"] = "<-- " + Common.clsLanguages.GetResource("CRM145") + " -->";
                empTypeTable.Rows.InsertAt(rowEmpType, 0);
                cbBEmployeeType.DisplayMember = "EmployeeTypeName2";
            }
            cbBEmployeeType.ValueMember = "EmployeeTypeId";

        }

        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            try
            {
                IsBeginLoad(false);

                GetList_Country();
                GetLists_InEmployeeType();

                if (!string.IsNullOrEmpty(this.employee.EmployeeId))
                {
                    try
                    {
                        pStatusAdd = false;
                        IsBeginLoad(true);
                        Display(this.employee);
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
                else
                {
                    pStatusAdd = true;
                    IsBeginLoad(true);
                    Display(null);
                }

                SetUIChanges();
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
               

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            string ppEmployeeId = "";
            try
            {
                Entities.Employees1 emp = new Entities.Employees1();
                emp = SetEmployee();
                if (string.IsNullOrEmpty(emp.EmployeeCode))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM94"),
                                  Common.clsLanguages.GetResource("CRM11"),
                                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
                if (!Common.Validation.ValidateNumber(emp.EmployeeCode))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM519"),
                                  Common.clsLanguages.GetResource("CRM11"),
                                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }

                if (string.IsNullOrEmpty(emp.EmployeeName))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM312"),
                                  Common.clsLanguages.GetResource("CRM11"),
                                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }
                //if (!Common.Validation.ValidateBirthDate(emp.BirthDate))
                //{
                //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM310"),
                //                   Common.clsLanguages.GetResource("CRM11"),
                //                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //    return;
                //}
                if (!string.IsNullOrEmpty(emp.Email))
                {
                    if (!Common.Validation.ValidateEmail(emp.Email))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM311"),
                                   Common.clsLanguages.GetResource("CRM11"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                }
                if (!string.IsNullOrEmpty(emp.PhoneNumber))
                {
                    if (!Common.Validation.ValidatePhoneNumber(emp.PhoneNumber))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM47"),
                                   Common.clsLanguages.GetResource("CRM11"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                }
                if (cbBCountry.SelectedIndex == 0)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM373"),
                               Common.clsLanguages.GetResource("CRM11"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;

                }
                if (cbBEmployeeType.SelectedIndex == 0)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM514"),
                               Common.clsLanguages.GetResource("CRM11"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;

                }
                                

                if (pStatusAdd)
                {
                    //Linh 29-12-2014
                    if (txtUserName.Text != "" && txtPassword.Text != "")
                    {
                        if (txtConfirm.Text == String.Empty)
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM646"),
                                       Common.clsLanguages.GetResource("CRM11"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                            return;
                        }
                        else
                        {
                            if (string.Compare(txtPassword.Text, txtConfirm.Text) != 0)
                            {
                                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM647"),
                                       Common.clsLanguages.GetResource("CRM11"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                                return;
                            }
                        }
                    }

                    if (employeeBLL.CheckEmployeeIsExist(emp.EmployeeCode, null))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM513"),
                                   Common.clsLanguages.GetResource("CRM11"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                   ppEmployeeId = employeeBLL.AddReturnId(emp);
                }
                else
                {
                    if (employeeBLL.CheckEmployeeIsExist(emp.EmployeeCode, emp.EmployeeId))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM513"),
                                   Common.clsLanguages.GetResource("CRM11"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
                    //Check mã đã tồn tại chưa
                    DialogResult r = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM227"), Common.clsLanguages.GetResource("CRM11"), Common.Config.CUSTOM_MESSAGEBOX_ICON.Information, Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
                    if (r == DialogResult.Yes)
                    {
                        employeeBLL.Edit(emp);
                        this.Close();                        
                    }
                }

                if (!string.IsNullOrEmpty(employeeBLL.ErrorString))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM219"),
                              Common.clsLanguages.GetResource("CRM11"),
                              Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                              Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
                }

                if (!string.IsNullOrEmpty(imagePath))
                    employeeBLL.SaveImage(emp, imagePath);

                if (!string.IsNullOrEmpty(employeeBLL.ErrorString))
                {
                    MessageBox.Show(employeeBLL.ErrorString, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrEmpty(imagePath))
                    emp.Image = Image.FromFile(imagePath);
                else
                    emp.Image = employee.Image;
                #region Phân quyền
                DataTable roleTable = new DataTable();
                roleTable.Columns.Add("EmployeeId", typeof(String));
                roleTable.Columns.Add("RoleId", typeof(String));

                if (pStatusAdd)
                {
                    if(rdManager.Checked == true)//if (chkBManager.Checked == true)
                    {
                        DataRow row = roleTable.NewRow();                      
                        row["EmployeeId"] = ppEmployeeId; //for insert and update
                        row["RoleId"] = "admin";
                        roleTable.Rows.Add(row);
                    }

                    if(rdEmployee.Checked == true)// if (chkBReception.Checked == true)
                    {
                        DataRow row = roleTable.NewRow();                       
                        row["EmployeeId"] = ppEmployeeId; //for insert and update
                        row["RoleId"] = "letan";
                        roleTable.Rows.Add(row);
                    }

                    //if (chkBTablet.Checked == true)
                    //{
                    //    DataRow row = roleTable.NewRow();                      
                    //    row["EmployeeId"] = ppEmployeeId; //for insert and update
                    //    row["RoleId"] = "tablet";
                    //    roleTable.Rows.Add(row);
                    //}
                    roleBLL.UpdateRoleByUserId( ppEmployeeId, roleTable);   
                }
                else
                {
                    if (rdManager.Checked == true) //if (chkBManager.Checked == true)
                    {
                        DataRow row = roleTable.NewRow();
                        row["EmployeeId"] = emp.EmployeeId;                  
                        row["RoleId"] = "admin";
                        roleTable.Rows.Add(row);
                    }

                    if (rdEmployee.Checked == true) //if (chkBReception.Checked == true)
                    {
                        DataRow row = roleTable.NewRow();
                        row["EmployeeId"] = emp.EmployeeId;                     
                        row["RoleId"] = "letan";
                        roleTable.Rows.Add(row);
                    }

                    //if (chkBTablet.Checked == true)
                    //{
                    //    DataRow row = roleTable.NewRow();
                    //    row["EmployeeId"] = emp.EmployeeId;                       
                    //    row["RoleId"] = "tablet";
                    //    roleTable.Rows.Add(row);
                    //}
                    roleBLL.UpdateRoleByUserId(emp.EmployeeId, roleTable);    
                }
                                           
                #endregion

                if (pStatusAdd)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM308"),
                               Common.clsLanguages.GetResource("CRM11"),
                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    this.Close();

                    //btnAdd_Click(sender, e);
                }
                else
                {
                    employee = emp;
                    IsBeginLoad(false);
                    Display(this.employee);
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

        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            const string imageFilter = "All image files|*.TIF;*.TIFF;*.BMP;*.DIB;*.GIF;*.GFA;*.JPG;*.JPEG;*.JPE;*.PCX|Tag Image File Format (TIF,TIFF)|*.TIF;*TIFF|Windows bitmap (bmp,dib)|*.BMP;*.DIB|GIF files (gif,gfa)|*.GIF;*.GFA|JPEG files (jpg,jpeg,jpe)|*.JPG;*.JPEG;*.JPE|PCX Files (pcx)|*.PCX|All files|*.*";
            openFileDialog.FileName = imagePath;
            openFileDialog.Filter = imageFilter;
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                imagePath = openFileDialog.FileName;
                picBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                picBoxImage.Image = Image.FromFile(imagePath);
            }
        }

        /// <summary>
        /// get number from string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private Decimal GetNumberFromString(string str)
        {
            decimal dicNumber = 0;
            try
            {
                dicNumber = Decimal.Parse(str, NumberStyles.AllowCurrencySymbol | NumberStyles.Number,
                    System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
                //if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                //{
                //    dicNumber = Decimal.Parse(str, NumberStyles.AllowCurrencySymbol | NumberStyles.Number, System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
                //}
                //else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                //{
                //    dicNumber = Decimal.Parse(str, NumberStyles.AllowCurrencySymbol | NumberStyles.Number, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                //}
                //else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                //{
                //    dicNumber = Decimal.Parse(str, NumberStyles.AllowCurrencySymbol | NumberStyles.Number, System.Globalization.CultureInfo.GetCultureInfo("ja-JP"));
                //}
            }
            catch (Exception)
            {
            }
            return dicNumber;
        }

        private void txtHourlyWages_TextChanged(object sender, EventArgs e)
        {
            string textPrice = txtHourlyWages.Text.Trim();
            if (!String.IsNullOrEmpty(textPrice))
            {
                //if in txtPriceFromCustomer have character not 0-9 and . then remove
                string value = "";
                for (int i = 0; i < textPrice.Length; i++)
                {
                    if ((textPrice[i] >= '0' && textPrice[i] <= '9') || textPrice[i] == '.' || textPrice[i] == ',')
                    {
                        value += textPrice[i];
                    }
                }
                if (value != "")
                {
                    decimal dValue = GetNumberFromString(value);
                    //if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                    //{
                    //    txtPriceFromCustomer.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:n0}", dValue);
                    //}
                    //else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                    //{
                    //    txtPriceFromCustomer.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:n0}", dValue);
                    //}
                    //else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                    //{
                    //    txtPriceFromCustomer.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("ja-JP"), "{0:n0}", dValue);
                    //}
                    txtHourlyWages.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:n0}", dValue);
                    txtHourlyWages.SelectionStart = txtHourlyWages.Text.Trim().Length;
                }
            }
        }

        private void frmAddAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.employee = null;
        }
    }
}
