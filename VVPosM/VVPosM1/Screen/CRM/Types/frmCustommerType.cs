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
    public partial class frmCustommerType : Form
    {
        //POSEntities posEntity = new POSEntities();
        MemberTypeBLL memBLL = new MemberTypeBLL();
        private string currentId = string.Empty;

        private void SettingControl()
        {

            //setting background for form
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            //setting title
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLOR);
            //gbInformationSearch
            this.gbInformation.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.gbInformationSearh.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);

            this.lblMemberTypeName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtMemberTypeName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblMemberTypeName2.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtMemberTypeName2.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblMemberTypeName3.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtMemberTypeName3.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.btnSave.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnAddNew.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);

            this.dgvCustomerType.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);
        }

        public void SetUIChanges()
        {

            this.Text = Common.clsLanguages.GetResource("CRM620");
            lblTitle.Text = Common.clsLanguages.GetResource("CRM620");

            //gbInformationSearch
            gbInformation.Text = Common.clsLanguages.GetResource("CRM157");
            gbInformationSearh.Text = Common.clsLanguages.GetResource("CRM218");

            lblMemberTypeName.Text = Common.clsLanguages.GetResource("CRM179");
            lblMemberTypeName2.Text = Common.clsLanguages.GetResource("CRM182");
            lblMemberTypeName3.Text = Common.clsLanguages.GetResource("CRM183");
            //button set 
            //btnAddNew.Text = Common.clsLanguages.GetResource("CRMRefresh");
            dgvCustomerType.Columns["MemberTypeID"].HeaderText = Common.clsLanguages.GetResource("CRM112");
            dgvCustomerType.Columns["MemberTypeCode"].HeaderText = Common.clsLanguages.GetResource("CRM112");
            dgvCustomerType.Columns["MemberTypeName"].HeaderText = Common.clsLanguages.GetResource("CRM179");
            dgvCustomerType.Columns["MemberTypeName2"].HeaderText = Common.clsLanguages.GetResource("CRM182");
            dgvCustomerType.Columns["MemberTypeName3"].HeaderText = Common.clsLanguages.GetResource("CRM183");
            btnAddNew.Text = Common.clsLanguages.GetResource("CRM644");
            btnSave.Text = Common.clsLanguages.GetResource("CRM161");
            btnDelete.Text = Common.clsLanguages.GetResource("CRM110");

            dgvCustomerType.Columns["MemberTypeID"].Visible = false;
            currentId = string.Empty;

            //GetLists_InGridCustommerType();
            btnDelete.Enabled = false;

        }

        public frmCustommerType()
        {
            InitializeComponent();
            SettingControl();
        }

        ///// <summary>
        ///// Get data from table Custommer_Type
        ///// </summary>
        private void GetLists_InGridCustommerType()
        {
            dgvCustomerType.DataSource = memBLL.GetLists();
            txtMemberTypeName.Focus();

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
        private void dgvCustomerType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCustomerType.RowCount > 0)
                {
                    currentId = dgvCustomerType.Rows[dgvCustomerType.CurrentRow.Index].Cells["MemberTypeID"].Value.ToString();

                    txtMemberTypeName.Text = dgvCustomerType.Rows[dgvCustomerType.CurrentRow.Index].Cells["MemberTypeName"].Value.ToString();
                    txtMemberTypeName2.Text = dgvCustomerType.Rows[dgvCustomerType.CurrentRow.Index].Cells["MemberTypeName2"].Value.ToString();
                    txtMemberTypeName3.Text = dgvCustomerType.Rows[dgvCustomerType.CurrentRow.Index].Cells["MemberTypeName3"].Value.ToString();
                    btnDelete.Enabled = true;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MemberType mebtype = new MemberType();

                if (currentId != String.Empty)
                {
                    mebtype.MemberTypeId = int.Parse(currentId);
                }
                    
                    if (!string.IsNullOrEmpty(txtMemberTypeName.Text.Trim()) || !string.IsNullOrEmpty(txtMemberTypeName2.Text.Trim()) || !string.IsNullOrEmpty(txtMemberTypeName3.Text.Trim()))
                    {
                        mebtype.MemberTypeName = txtMemberTypeName.Text;
                        mebtype.MemberTypeName2 = txtMemberTypeName2.Text;
                        mebtype.MemberTypeName3 = txtMemberTypeName3.Text;
                        DialogResult r = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM227"), Common.clsLanguages.GetResource("CRM11"), Common.Config.CUSTOM_MESSAGEBOX_ICON.Information, Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
                        if (r == DialogResult.Yes)
                        {
                            if (!string.IsNullOrEmpty(currentId))
                            {// update
                                memBLL.Edit(mebtype);
                            }
                            else
                            {//add
                                memBLL.Add(mebtype);
                            }
                            GetLists_InGridCustommerType();

                            if (!string.IsNullOrEmpty(memBLL.ErrorString))
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
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRMErrEmpCusType"),
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
            currentId = "";
            txtMemberTypeName.Text = "";
            txtMemberTypeName2.Text = "";
            txtMemberTypeName3.Text = "";

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
                    if (!memBLL.Delete(currentId))//delete fail
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
