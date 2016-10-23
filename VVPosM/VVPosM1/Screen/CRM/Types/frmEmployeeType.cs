using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VVPosM1.BusinessLayer.BLLCRM;
using VVPosM1.Entities;

namespace VVPosM1.Screen.CRM.Types
{
    public partial class frmEmployeeType : Form
    {
        //POSEntities posEntity = new POSEntities();
        EmployeeTypeBLL empBLL = new EmployeeTypeBLL();

        private string currentId = "";

        private void SettingControl()
        {

            //setting background for form
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            //setting title
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLOR);
            //gbInformationSearch
            this.gbInformation.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.gbInformationSearh.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);

            this.lblEmployeeTypeName1.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtEmployeeTypeName1.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblEmployeeTypeName2.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtEmployeeTypeName2.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblEmployeeTypeName3.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtEmployeeTypeName3.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.btnSave.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnAddNew.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);

            this.dgvEmployeeType.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
        }

        public void SetUIChanges()
        {
            /**
             TODO
             */
            this.Text = Common.clsLanguages.GetResource("CRMStaffTypeManager");
            lblTitle.Text = Common.clsLanguages.GetResource("CRMEmpGrouInfo");

            //gbInformationSearch
            gbInformation.Text = Common.clsLanguages.GetResource("CRM157");
            gbInformationSearh.Text = Common.clsLanguages.GetResource("CRM218");

            lblEmployeeTypeName1.Text = Common.clsLanguages.GetResource("CRM179");
            lblEmployeeTypeName2.Text = Common.clsLanguages.GetResource("CRM182");
            lblEmployeeTypeName3.Text = Common.clsLanguages.GetResource("CRM183");
            //button set 
            btnSave.Text = Common.clsLanguages.GetResource("CRM161");
            btnAddNew.Text = Common.clsLanguages.GetResource("CRMRefresh");

            dgvEmployeeType.Columns["EmployeeTypeID"].HeaderText = Common.clsLanguages.GetResource("CRM112");
            dgvEmployeeType.Columns["EmployeeTypeName"].HeaderText = Common.clsLanguages.GetResource("CRM179");
            dgvEmployeeType.Columns["EmployeeTypeName2"].HeaderText = Common.clsLanguages.GetResource("CRM182");
            dgvEmployeeType.Columns["EmployeeTypeName3"].HeaderText = Common.clsLanguages.GetResource("CRM183");
            btnDelete.Text = Common.clsLanguages.GetResource("CRM110");
            //
            GetLists_InGridCustommerType();
            currentId = "";
            btnDelete.Enabled = false;

        }

        public frmEmployeeType()
        {
            InitializeComponent();
            SettingControl();
        }

        ///// <summary>
        ///// Get data from table Custommer_Type
        ///// </summary>
        private void GetLists_InGridCustommerType()
        {
            dgvEmployeeType.DataSource = empBLL.GetLists();
            txtEmployeeTypeName1.Focus();

        }
        private void frmCustommerType_Load(object sender, EventArgs e)
        {
            try
            {
                GetLists_InGridCustommerType();
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
        private void dgvEmployeeType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvEmployeeType.RowCount > 0)
                {
                    currentId = dgvEmployeeType.Rows[dgvEmployeeType.CurrentRow.Index].Cells["EmployeeTypeID"].Value.ToString();
                    txtEmployeeTypeName1.Text = dgvEmployeeType.Rows[dgvEmployeeType.CurrentRow.Index].Cells["EmployeeTypeName"].Value.ToString();
                    txtEmployeeTypeName2.Text = dgvEmployeeType.Rows[dgvEmployeeType.CurrentRow.Index].Cells["EmployeeTypeName2"].Value.ToString();
                    txtEmployeeTypeName3.Text = dgvEmployeeType.Rows[dgvEmployeeType.CurrentRow.Index].Cells["EmployeeTypeName3"].Value.ToString();
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                /*
                 * TODO
                 */
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeType mebtype = new EmployeeType();
                mebtype.EmployeeTypeId = currentId;
                if (!string.IsNullOrEmpty(txtEmployeeTypeName1.Text.Trim()) || !string.IsNullOrEmpty(txtEmployeeTypeName2.Text.Trim()) || !string.IsNullOrEmpty(txtEmployeeTypeName3.Text.Trim()))
                {
                    mebtype.EmployeeTypeName = txtEmployeeTypeName1.Text;
                    mebtype.EmployeeTypeName2 = txtEmployeeTypeName2.Text;
                    mebtype.EmployeeTypeName3 = txtEmployeeTypeName3.Text;
                    DialogResult r = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM227"), Common.clsLanguages.GetResource("CRM11"), Common.Config.CUSTOM_MESSAGEBOX_ICON.Information, Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
                    if (r == DialogResult.Yes)
                    {
                        if (!string.IsNullOrEmpty(currentId))
                        {// update
                            empBLL.Edit(mebtype);
                        }
                        else
                        {//add
                            empBLL.Add(mebtype);
                        }
                        GetLists_InGridCustommerType();

                        if (!string.IsNullOrEmpty(empBLL.ErrorString))
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM219"),
                                  Common.clsLanguages.GetResource("CRM11"),
                                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                            return;
                        }
                    }
                }

                else
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRMInpEmpTypName"),
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


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            currentId = txtEmployeeTypeName1.Text = txtEmployeeTypeName2.Text = txtEmployeeTypeName3.Text = "";
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentId))
            {
                DialogResult r = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM502"),
                                      Common.clsLanguages.GetResource("CRM11"),
                                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
                if (r == DialogResult.Yes)
                {
                    if (!empBLL.Delete(currentId))//delete fail
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRMDeleteTypeFailed"),
                                      Common.clsLanguages.GetResource("CRM11"),
                                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                    else
                    {
                        GetLists_InGridCustommerType();
                        btnAddNew_Click(sender, e);
                    }
                }
            }
        }
    }
}
