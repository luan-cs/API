using System;
using System.Data;
using System.Windows.Forms;
using VVPosM1.BusinessLayer.BLLCRM;
using VVPosM1.Common;

namespace VVPosM1.Screen.CRM.Employee
{
    public partial class frmEmployee : Form
    {
        private EmployeeBLL employeeBLL = new EmployeeBLL();
        private EmployeeTypeBLL empTypeBLL = new EmployeeTypeBLL();
        public static DataTable dataTable = new DataTable();
        public static VVPosM1.Entities.Employees1 employee = new Entities.Employees1();

        ExportExcelAlgorithms exportExcelAlgorithms;

        private void SettingControl()
        {
            //setting background for form
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            //setting title
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLOR);
            //gbInformationSearch
            this.gbInformationSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.gbInformation.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.lblSearchTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtEmployeeId.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
            this.btnSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnAdd.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnRefresh.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnDelete.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnDownload.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnEdit.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);

            this.dgv.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
        }

        /// <summary>
        /// Set text for control
        /// </summary>
        public void SetUIChanges()
        {           
            gbInformationSearch.Text = Common.clsLanguages.GetResource("CRM101");
            lblTitle.Text = Common.clsLanguages.GetResource("CRM137");

            lblSearchTitle.Text = Common.clsLanguages.GetResource("CRMSearchTextbox");

            btnSearch.Text = Common.clsLanguages.GetResource("CRM24");
            btnRefresh.Text = Common.clsLanguages.GetResource("CRM508");
            btnAdd.Text = Common.clsLanguages.GetResource("CRM109");
            btnDelete.Text = Common.clsLanguages.GetResource("CRM110");

            btnDownload.Text = Common.clsLanguages.GetResource("CRM304");
            btnEdit.Text = Common.clsLanguages.GetResource("CRM188");

            //groupbox regist services
            gbInformation.Text = Common.clsLanguages.GetResource("CRMUserList");
            dgv.Columns["EmployeeId"].HeaderText = Common.clsLanguages.GetResource("CRM112");
            dgv.Columns["EmployeeCode"].HeaderText = Common.clsLanguages.GetResource("CRM112");
            dgv.Columns["EmployeeName"].HeaderText = Common.clsLanguages.GetResource("CRM113");
            dgv.Columns["UserName"].HeaderText = Common.clsLanguages.GetResource("CRM6");
            dgv.Columns["Gender"].HeaderText = Common.clsLanguages.GetResource("CRM114");
            dgv.Columns["BirthDate"].HeaderText = Common.clsLanguages.GetResource("CRM105");
            dgv.Columns["PhoneNumber"].HeaderText = Common.clsLanguages.GetResource("CRM115");
            dgv.Columns["Email"].HeaderText = Common.clsLanguages.GetResource("CRM116");
            dgv.Columns["Address"].HeaderText = Common.clsLanguages.GetResource("CRM117");
            dgv.Columns["EmployeeTypeName"].HeaderText = Common.clsLanguages.GetResource("CRM145");
            dgv.Columns["CountryName"].HeaderText = Common.clsLanguages.GetResource("CRM118");

            //if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
            //{
            //    dgv.Columns["EmployeeTypeName"].HeaderText = Common.clsLanguages.GetResource("CRM145");
            //    dgv.Columns["CountryName"].HeaderText = Common.clsLanguages.GetResource("CRM118");
            //}
            //else if (Common.clsLanguages.StrCulture.Equals("en-US"))
            //{
            //    dgv.Columns["EmployeeTypeName3"].HeaderText = Common.clsLanguages.GetResource("CRM145");
            //    dgv.Columns["CountryName3"].HeaderText = Common.clsLanguages.GetResource("CRM118");
            //}
            //else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
            //{
            //    dgv.Columns["EmployeeTypeName2"].HeaderText = Common.clsLanguages.GetResource("CRM145");
            //    dgv.Columns["CountryName2"].HeaderText = Common.clsLanguages.GetResource("CRM118");
            //}

            //dgv.Columns["IsDelete"].HeaderText = Common.clsLanguages.GetResource("CRM119");
            dgv.Columns["HourlyWages"].HeaderText = Common.clsLanguages.GetResource("CRM120");
            dgv.Columns["CreatedDate"].HeaderText = Common.clsLanguages.GetResource("CRM121");
            dgv.Columns["UpdatedDate"].HeaderText = Common.clsLanguages.GetResource("CRM122");
            // dgv.Columns["CountryId"].HeaderText = Common.clsLanguages.GetResource("CRM111");
            //dgv.Columns["EmployeeTypeId"].HeaderText = Common.clsLanguages.GetResource("CRM111");
            //dgv.Columns["IntGender"].HeaderText = Common.clsLanguages.GetResource("CRM114");
            dgv.Columns["Notes"].HeaderText = Common.clsLanguages.GetResource("CRM128");
            //dgv.Columns["BirthDateYMD"].HeaderText = Common.clsLanguages.GetResource("CRM111");   

        }

        public frmEmployee()
        {
            InitializeComponent();
            SettingControl();
        }

        private void Display()
        {
            // 
            dataTable = employeeBLL.GetLists();
            if (dataTable != null)
            {
                dgv.Columns.Clear();
                dgv.DataSource = dataTable;
                dgv.AutoGenerateColumns = true;

                //dgv.Columns["EmployeeId"].HeaderText = "Mã";
                dgv.Columns["EmployeeId"].Width = 55;
                dgv.Columns["EmployeeId"].DisplayIndex = 1;
                dgv.Columns["EmployeeId"].Visible = false;

                // dgv.Columns["EmployeeCode"].HeaderText = "Mã số";
                dgv.Columns["EmployeeCode"].Width = 120;
                dgv.Columns["EmployeeCode"].DisplayIndex = 2;
                dgv.Columns["EmployeeCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["EmployeeCode"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns["EmployeeCode"].FillWeight = 120;

                // dgv.Columns["EmployeeName"].HeaderText = "Họ tên";
                dgv.Columns["EmployeeName"].DisplayIndex = 3;
                dgv.Columns["EmployeeName"].Width = 250;
                dgv.Columns["EmployeeName"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns["EmployeeName"].FillWeight = 250;

                // dgv.Columns["UserName"].HeaderText = "Tên đăng nhập";
                dgv.Columns["UserName"].DisplayIndex = 4;
                dgv.Columns["UserName"].Width = 180;
                dgv.Columns["UserName"].Visible = false;


                //dgv.Columns["Gender"].HeaderText = "Giới tính";
                dgv.Columns["Gender"].DisplayIndex = 5;
                dgv.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["Gender"].Visible = false;

                //dgv.Columns["BirthDate"].HeaderText = "Ngày sinh";
                dgv.Columns["BirthDate"].Width = 95;
                dgv.Columns["BirthDate"].DisplayIndex = 6;
                dgv.Columns["BirthDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["BirthDate"].Visible = false;


                //dgv.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
                dgv.Columns["PhoneNumber"].DisplayIndex = 7;
                dgv.Columns["PhoneNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["PhoneNumber"].Width = 130;
                dgv.Columns["PhoneNumber"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns["PhoneNumber"].FillWeight = 130;

                //dgv.Columns["Email"].HeaderText = "E-mail";
                dgv.Columns["Email"].DisplayIndex = 8;
                dgv.Columns["Email"].Width = 180;
                dgv.Columns["Email"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns["Email"].FillWeight = 180;

                //dgv.Columns["Address"].HeaderText = "Địa chỉ";
                dgv.Columns["Address"].DisplayIndex = 9;
                dgv.Columns["Address"].Width = 330;
                dgv.Columns["Address"].Visible = false;

                //dgv.Columns["EmployeeTypeName"].HeaderText = "Bộ phận";
                dgv.Columns["EmployeeTypeName"].DisplayIndex = 10;
                dgv.Columns["EmployeeTypeName"].Width = 230;
                dgv.Columns["EmployeeTypeName"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns["EmployeeTypeName"].FillWeight = 230;

                //dgv.Columns["CountryName"].HeaderText = "Quốc tịch";
                dgv.Columns["CountryName"].DisplayIndex = 11;
                dgv.Columns["CountryName"].Width = 150;
                dgv.Columns["CountryName"].Visible = false;

                //if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                //{
                //    //dgv.Columns["EmployeeTypeName"].HeaderText = "Bộ phận";
                //    dgv.Columns["EmployeeTypeName"].DisplayIndex = 10;
                //    dgv.Columns["EmployeeTypeName"].Width = 230;
                //    dgv.Columns["EmployeeTypeName"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                //    dgv.Columns["EmployeeTypeName"].FillWeight = 230;

                //    //dgv.Columns["CountryName"].HeaderText = "Quốc tịch";
                //    dgv.Columns["CountryName"].DisplayIndex = 11;
                //    dgv.Columns["CountryName"].Width = 150;
                //    //
                //    dgv.Columns["EmployeeTypeName2"].Visible = false;
                //    dgv.Columns["EmployeeTypeName3"].Visible = false;
                //    dgv.Columns["CountryName2"].Visible = false;
                //    dgv.Columns["CountryName3"].Visible = false;
                //}
                //else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                //{
                //    //dgv.Columns["EmployeeTypeName3"].HeaderText = "Bộ phận";
                //    dgv.Columns["EmployeeTypeName3"].DisplayIndex = 10;
                //    dgv.Columns["EmployeeTypeName3"].Width = 230;
                //    dgv.Columns["EmployeeTypeName3"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                //    dgv.Columns["EmployeeTypeName3"].FillWeight = 230;

                //    //dgv.Columns["CountryName3"].HeaderText = "Quốc tịch";
                //    dgv.Columns["CountryName3"].DisplayIndex = 11;
                //    dgv.Columns["CountryName3"].Width = 150;

                //    //
                //    dgv.Columns["EmployeeTypeName"].Visible = false;
                //    dgv.Columns["EmployeeTypeName2"].Visible = false;
                //    dgv.Columns["CountryName"].Visible = false;
                //    dgv.Columns["CountryName2"].Visible = false;
                //}
                //else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                //{
                //    //dgv.Columns["EmployeeTypeName2"].HeaderText = "Bộ phận";
                //    dgv.Columns["EmployeeTypeName2"].DisplayIndex = 10;
                //    dgv.Columns["EmployeeTypeName2"].Width = 230;
                //    dgv.Columns["EmployeeTypeName2"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                //    dgv.Columns["EmployeeTypeName2"].FillWeight = 230;

                //    //dgv.Columns["CountryName2"].HeaderText = "Quốc tịch";
                //    dgv.Columns["CountryName2"].DisplayIndex = 11;
                //    dgv.Columns["CountryName2"].Width = 150;

                //    //
                //    dgv.Columns["EmployeeTypeName"].Visible = false;
                //    dgv.Columns["EmployeeTypeName3"].Visible = false;
                //    dgv.Columns["CountryName"].Visible = false;
                //    dgv.Columns["CountryName3"].Visible = false;
                //}

                
                //dgv.Columns["CountryName2"].Visible = false;
                //dgv.Columns["CountryName3"].Visible = false;

                

                //dgv.Columns["IsDelete"].HeaderText = "Trạng thái";
                //dgv.Columns["IsDelete"].DisplayIndex = 12;
                //dgv.Columns["IsDelete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgv.Columns["IsDelete"].Visible = false;


                //dgv.Columns["HourlyWages"].HeaderText = "Lương theo giờ";
                dgv.Columns["HourlyWages"].DisplayIndex = 12;
                dgv.Columns["HourlyWages"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["HourlyWages"].Visible = false;
                
                //dgv.Columns["CreatedDate"].HeaderText = "Ngày tạo";
                dgv.Columns["CreatedDate"].DisplayIndex = 13;
                dgv.Columns["CreatedDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["CreatedDate"].Visible = false;

                //dgv.Columns["UpdatedDate"].HeaderText = "Ngày sửa";
                dgv.Columns["UpdatedDate"].DisplayIndex = 14;
                dgv.Columns["UpdatedDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["UpdatedDate"].Visible = false;

                //dgv.Columns["Notes"].DisplayIndex = 15;
                //dgv.Columns["Notes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["Notes"].Visible = false;

                //dgv.Columns["CountryId"].DisplayIndex = 16;
                //dgv.Columns["CountryId"].Visible = false;

                //dgv.Columns["EmployeeTypeId"].DisplayIndex = 17;
                //dgv.Columns["EmployeeTypeId"].Visible = false;

                //dgv.Columns["IntGender"].DisplayIndex = 18;
                //dgv.Columns["IntGender"].Visible = false;

                //dgv.Columns["IntIsDelete"].DisplayIndex = 19;
                //dgv.Columns["IntIsDelete"].Visible = false;

                //dgv.Columns["Password"].DisplayIndex = 20;
                //dgv.Columns["Password"].Visible = false;

                //dgv.Columns["BirthDateYMD"].DisplayIndex = 21;
                //dgv.Columns["BirthDateYMD"].Visible = false;

            }
            else
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM219"),
                                  Common.clsLanguages.GetResource("CRM11"),
                                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
        }

        private void frmManageAccount_Load(object sender, EventArgs e)
        {
            try
            {
                Display();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtEmployeeId.Text;
                dataTable = new DataTable();
                dataTable = employeeBLL.SearchEmployee(keyword);
                if (dataTable != null)
                {
                    //dgv.Columns.Clear();                
                    dgv.DataSource = dataTable;
                    dgv.AutoGenerateColumns = true;
                    // SetUIChanges();

                }
                else
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM219"),
                                      Common.clsLanguages.GetResource("CRM11"),
                                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return;
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

        //Handle Enter key press
        private void OnKeyDownHandler(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                this.btnSearch_Click(sender, e);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmployeeId.Text = "";

                Display();
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

        public static bool pStatusAddEmployee = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pStatusAddEmployee = true;
            frmAddAccount frmAdd = new frmAddAccount();
            frmAdd.ShowDialog();

            //Reload data
            Display();
            SetUIChanges();
            pStatusAddEmployee = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.RowCount > 0)
                {
                    if (dgv.CurrentRow != null)
                    {
                        string pCode = dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString();
                        string pEmployeeCode = dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString();
                        DialogResult r = CustomMessageBox.MessageBox.ShowCustomMessageBox(String.Format("{0} <{1}>", Common.clsLanguages.GetResource("CRM125"), pEmployeeCode), Common.clsLanguages.GetResource("CRM11"), Common.Config.CUSTOM_MESSAGEBOX_ICON.Information, Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);

                        int index = (dgv.CurrentRow.Index - 1) > 0 ? (dgv.CurrentRow.Index - 1) : 0;

                        if (r == DialogResult.Yes)
                        {
                            employeeBLL.Delete(pCode);

                            if (string.IsNullOrEmpty(employeeBLL.ErrorString))
                            {
                                Display();
                                dgv.Rows[index].Selected = true;
                            }
                            else
                            {
                                //MessageBox.Show(employeeBLL.ErrorString, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM185"),
                                      Common.clsLanguages.GetResource("CRM11"),
                                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                                return;
                            }
                        }
                    }
                    else
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM306"),
                                     Common.clsLanguages.GetResource("CRM11"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        return;
                    }
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

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.RowCount > 0 && dgv.CurrentRow != null)
                {
                    string pCode = dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString();
                    employee = employeeBLL.GetById(pCode);
                    frmAddAccount frm = new frmAddAccount();
                    frm.ShowDialog();

                    //reload data
                    Display();
                    SetUIChanges();
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
            //try
            //{
            //    #region
            //    pStatusAddEmployee = false; //case: edit
            //    int dgvRowIndex = e.RowIndex;
            //    string[] arrDate = new string[3];

            //    if (dgv.RowCount > 0 && dgv.CurrentRow != null)
            //    {
            //        employee.EmployeeId = dgv["EmployeeId", dgvRowIndex].Value.ToString();
            //        employee.EmployeeCode = dgv["EmployeeCode", dgvRowIndex].Value.ToString();
            //        employee.EmployeeName = dgv["EmployeeName", dgvRowIndex].Value.ToString();
            //        employee.UserName = dgv["UserName", dgvRowIndex].Value.ToString();
            //        //employee.Gender = int.Parse(dgv["IntGender", dgvRowIndex].Value.ToString());
            //        employee.BirthDate = DateTime.Parse(dgv["BirthDate", dgvRowIndex].Value.ToString());

            //        employee.PhoneNumber = dgv["PhoneNumber", dgvRowIndex].Value.ToString();
            //        employee.Email = dgv["Email", dgvRowIndex].Value.ToString();
            //        employee.Address = dgv["Address", dgvRowIndex].Value.ToString();
            //        //employee.EmployeeType.EmployeeTypeId = dgv["EmployeeTypeId", dgvRowIndex].Value.ToString();
            //        employee.EmployeeType.EmployeeTypeName = dgv["EmployeeTypeName", dgvRowIndex].Value.ToString();
            //        employee.Country.CountryId = dgv["CountryId", dgvRowIndex].Value.ToString();
            //        employee.Country.CountryName = dgv["CountryName", dgvRowIndex].Value.ToString();
            //        //employee.IsDelete = int.Parse(dgv["IntIsDelete", dgvRowIndex].Value.ToString());
            //        employee.HourlyWages = decimal.Parse(dgv["HourlyWages", dgvRowIndex].Value.ToString());
            //        employee.Notes = dgv["Notes", dgvRowIndex].Value.ToString();

            //        employee.CreatedDate = DateTime.Parse(dgv["CreatedDate", dgvRowIndex].Value.ToString());
            //        employee.Password = dgv["Password", dgvRowIndex].Value.ToString();
            //        employee.UpdatedDate = DateTime.Parse(dgv["UpdatedDate", dgvRowIndex].Value.ToString());

            //        employee.Image = employeeBLL.GetImage(employee.EmployeeId);

            //        frmAddAccount frm = new frmAddAccount();
            //        frm.ShowDialog();
            //        //Reload data
            //        Display();
            //        SetUIChanges();

            //    }
            //    #endregion
            //}
            //catch (Exception)
            //{
            //    /*
            //    string code = System.Runtime.InteropServices.Marshal.GetExceptionCode().ToString();
            //    if (code == "-532462766")
            //    {
            //        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM292"),
            //                  Common.clsLanguages.GetResource("CRM11"),
            //                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
            //                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            //    }
            //    return;
            //     */
            //}
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                exportExcelAlgorithms = new ExportExcelAlgorithms();
                exportExcelAlgorithms.ExportFileFromDataGridViewEmployee(dgv, "EmployeeList");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.RowCount > 0 && dgv.CurrentRow != null)
                {
                    string pCode = dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString();
                    employee = employeeBLL.GetById(pCode);
                    frmAddAccount frm = new frmAddAccount();
                    frm.ShowDialog();

                    //reload data
                    Display();
                    SetUIChanges();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
