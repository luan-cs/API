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
    public partial class Classification : Form
    {
        private const int ORDERING = 0;
        private const int CATEGORY_ACTION_ID = 1;
        private const int CATEGORY_ACTION_VN = 2;
        private const int CATEGORY_ACTION_EN = 4;
        private const int CATEGORY_ACTION_JP = 3;
        string currentClassifiId;
        CategoryActionsBLL classifications = new CategoryActionsBLL();
        private void SettingControl()
        {
            //setting title
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLECOLOR);
            //gbInformationSearch
            this.gbInformation.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.gbInformationSearh.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);

            this.lblClassificationName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtClassificationName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblClassificationName2.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtClassificationName2.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.lblClassificationName3.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR);
            this.txtClassificationName3.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            this.btnSave.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);
            this.btnAddNew.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTBUTTONCOLOR);

            this.dgvClassification.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TEXTCOLOR);

            btnDelete.Enabled = false;
        }

        public void SetUIChanges()
        {

            this.Text = Common.clsLanguages.GetResource("CRMClassificationTitle");
            lblTitle.Text = Common.clsLanguages.GetResource("CRMClassificationTitle");

            //gbInformationSearch
            gbInformation.Text = Common.clsLanguages.GetResource("CRM157");
            gbInformationSearh.Text = Common.clsLanguages.GetResource("CRM218");

            lblClassificationName.Text = Common.clsLanguages.GetResource("CRM179");
            lblClassificationName2.Text = Common.clsLanguages.GetResource("CRM182");
            lblClassificationName3.Text = Common.clsLanguages.GetResource("CRM183");
            //button set 
            btnAddNew.Text = Common.clsLanguages.GetResource("CRMRefresh");
            dgvClassification.Columns["ordering"].HeaderText = Common.clsLanguages.GetResource("CRM112");
            dgvClassification.Columns["CategoryActionID"].HeaderText = Common.clsLanguages.GetResource("CRM112");
            dgvClassification.Columns["colCategoryActionName"].HeaderText = Common.clsLanguages.GetResource("CRM179");
            dgvClassification.Columns["colCategoryActionName2"].HeaderText = Common.clsLanguages.GetResource("CRM182");
            dgvClassification.Columns["colCategoryActionName3"].HeaderText = Common.clsLanguages.GetResource("CRM183");
            btnAddNew.Text = Common.clsLanguages.GetResource("CRM644");
            btnSave.Text = Common.clsLanguages.GetResource("CRM161");
            btnDelete.Text = Common.clsLanguages.GetResource("CRM110");
            dgvClassification.Columns["CategoryActionID"].Visible = false;
            dgvClassification.Columns["ordering"].Visible = false;
            //
            GetLists_InGridClassification();

        }

        public Classification()
        {
            InitializeComponent();
            SettingControl();
        }

        ///// <summary>
        ///// Get data from table Custommer_Type
        ///// </summary>
        private void GetLists_InGridClassification()
        {
            dgvClassification.DataSource = classifications.GetLists();
            txtClassificationName.Focus();

        }
        private void frmClassification_Load(object sender, EventArgs e)
        {
            try
            {
                GetLists_InGridClassification();
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
        private void dgvClassification_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvClassification.RowCount > 0)
                {
                    currentClassifiId = dgvClassification.Rows[dgvClassification.CurrentRow.Index].Cells["CategoryActionID"].Value.ToString();
                    txtClassificationName.Text = dgvClassification.Rows[dgvClassification.CurrentRow.Index].Cells["colCategoryActionName"].Value.ToString();
                    txtClassificationName2.Text = dgvClassification.Rows[dgvClassification.CurrentRow.Index].Cells["colCategoryActionName2"].Value.ToString();
                    txtClassificationName3.Text = dgvClassification.Rows[dgvClassification.CurrentRow.Index].Cells["colCategoryActionName3"].Value.ToString();

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
                CategoryActions classifi = new CategoryActions();
                classifi.CategoryActionID = currentClassifiId;
                if (!string.IsNullOrEmpty(txtClassificationName.Text.Trim()) || !string.IsNullOrEmpty(txtClassificationName2.Text.Trim()) || !string.IsNullOrEmpty(txtClassificationName3.Text.Trim()))
                {
                    classifi.CategoryActionName = txtClassificationName.Text;
                    classifi.CategoryActionName2 = txtClassificationName2.Text;
                    classifi.CategoryActionName3 = txtClassificationName3.Text;
                    DialogResult r = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM227"), Common.clsLanguages.GetResource("CRM11"), Common.Config.CUSTOM_MESSAGEBOX_ICON.Information, Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
                    if (r == DialogResult.Yes)
                    {
                        if (!string.IsNullOrEmpty(currentClassifiId))
                        {// update 
                            classifications.Edit(classifi);
                        }
                        else
                        {
                            classifications.Add(classifi);
                        }
                        GetLists_InGridClassification();

                        if (!string.IsNullOrEmpty(classifications.ErrorString))
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
            btnDelete.Enabled = false;
            currentClassifiId = "";
            txtClassificationName.Text = "";
            txtClassificationName2.Text = "";
            txtClassificationName3.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(currentClassifiId))
            {
                DialogResult r = CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM502"),
                                      Common.clsLanguages.GetResource("CRM11"),
                                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO);
                if (r == DialogResult.Yes)
                {
                    if (!classifications.Delete(currentClassifiId))
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRMDeleteTypeFailed"),
                                      Common.clsLanguages.GetResource("CRM11"),
                                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                    else
                    {
                        GetLists_InGridClassification();
                        btnAddNew_Click(sender, e);
                    }
                }
            }
        }

        private void lblClassificationName_Click(object sender, EventArgs e)
        {

        }

    }
}
