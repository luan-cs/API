using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using VVPosM1.BusinessLayer;
using VVPosM1.Entities;
using VVPosM1.Common;

namespace VVPosM1.Screen
{
    public partial class frmCommonType : Form
    {
        private CommonTypeBLL objBLL;
        private CommonType objSea;
        // 
        private int CurPage;
        private double totalPage;

        public frmCommonType()
        {
            InitializeComponent();
            
            SettingControl();
            SetUIChanges();
        }

        private void SettingControl()
        {
            //this.BackgroundImage = Utility.GetImageFromService("ShopImg", "bg12.png");
        }

        public void SetUIChanges()
        {
            gbxResult.Text = Common.clsLanguages.GetResource("CommonTypeList");
            lblCommonTypeId.Text = Common.clsLanguages.GetResource("TypeId");
            lblNote.Text = Common.clsLanguages.GetResource("Notes");
            lblDescription.Text = Common.clsLanguages.GetResource("Description2");


            btnSearch.Text = Common.clsLanguages.GetResource("Search");
            btnSave.Text = Common.clsLanguages.GetResource("Save");
            btnReset.Text = Common.clsLanguages.GetResource("Reset");
            btnExcel.Text = Common.clsLanguages.GetResource("ExportExcelFile");
            btnExit.Text = Common.clsLanguages.GetResource("Exit");


            this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            this.ID.HeaderText = Common.clsLanguages.GetResource("TypeId");
            this.Description.HeaderText = Common.clsLanguages.GetResource("Description");
            this.Note.HeaderText = Common.clsLanguages.GetResource("Notes");
            this.CreateInfo.HeaderText = Common.clsLanguages.GetResource("InfoInitiated");
            this.Delete.HeaderText = Common.clsLanguages.GetResource("Delete");
        }

        private void frmCommonType_Load(object sender, EventArgs e)
        {
            objBLL = new CommonTypeBLL();
            objSea = new CommonType();
            objSea.CommonTypeId = tbxCommonTypeId.Text;
            objSea.Description = rtbDescrition.Text;
            objSea.Note = tbxNote.Text;
            //objSea.CreatedBy = tbxCreatedBy.Text;
            //objSea.CreatedDate = cbxCreatedDate.Checked ? dtpCreatedDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "";
            //objSea.ModifiedBy = tbxModifiedBy.Text;
            //objSea.ModifiedDate = cbxModifiedDate.Checked ? dtpCreatedDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "";
        }


        private void btnSeach_Click(object sender, EventArgs e)
        {
            CurPage = 1;
            totalPage = 1;
            #region Truyen gia tri vao doi tuong objSea
            objSea = new CommonType();
            objSea.CommonTypeId = tbxCommonTypeId.Text;
            objSea.Description = rtbDescrition.Text;
            objSea.Note = tbxNote.Text;
            //objSea.CreatedBy = tbxCreatedBy.Text;
            //objSea.CreatedDate = cbxCreatedDate.Checked ? dtpCreatedDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "";
            //objSea.ModifiedBy = tbxModifiedBy.Text;
            //objSea.ModifiedDate = cbxModifiedDate.Checked ? dtpCreatedDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "";
            #endregion

            SearchCommonType(1);
        }

        private void SearchCommonType(int page)
        {
            CurPage = page;

            int total = 0;
            DataTable dt = objBLL.SearchCommonType (objSea, page, out total);
            double RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            dgvResult.Rows.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                int i = 0;
                int stt = (page - 1) * RecPerPage;
                foreach (DataRow dr in dt.Rows)
                {
                    dgvResult.Rows.Add();
                    //STT
                    dgvResult.Rows[i].Cells[0].Value = (stt + 1).ToString();
                    //ID
                    dgvResult.Rows[i].Cells[1].Value = dr["CommonTypeId"].ToString();
                    //Mô tả
                    dgvResult.Rows[i].Cells[2].Value = dr["Description"].ToString();
                    //Ghi chú
                    dgvResult.Rows[i].Cells[3].Value = dr["Note"].ToString();
                    //Thông tin khởi tạo
                    string str = "";
                    str += Common.clsLanguages.GetResource("CommonType01") + " " + dr["CreatedBy"].ToString() + "\n";
                    str += Common.clsLanguages.GetResource("CommonType02") + " " + dr["CreatedDate"].ToString();
                    if (!string.IsNullOrEmpty(dr["ModifiedBy"].ToString()))
                    {
                        str += "\n";
                        str += Common.clsLanguages.GetResource("CommonType03") + " " + dr["ModifiedBy"].ToString() + "\n";
                        str += Common.clsLanguages.GetResource("CommonType04") + " " + dr["ModifiedDate"].ToString();
                    }
                    dgvResult.Rows[i].Cells[4].Value = str;

                    i++; stt++;
                }
            }
            linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
            lblTB1.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        //private void cbxCreatedDate_CheckedChanged(object sender, System.EventArgs e)
        //{
        //    dtpCreatedDate.Enabled = cbxCreatedDate.Checked;
        //}

        //private void cbxModifiedDate_CheckedChanged(object sender, System.EventArgs e)
        //{
        //    dtpModifiedDate.Enabled = cbxModifiedDate.Checked;
        //}

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            SaveData();
            //SearchCommonType(1);
        }

        private void SaveData()
        {
            string objId = tbxCommonTypeId.Text.Trim();
            CommonType obj = new CommonType();
            obj = objBLL.GetCommonTypeById(objId);
            objSea = new CommonType();
            objSea.CommonTypeId = tbxCommonTypeId.Text;
            objSea.Description = rtbDescrition.Text;
            objSea.Note = tbxNote.Text;
            if (string.IsNullOrEmpty(objSea.CommonTypeId))
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("NotEnterCommonId"),
                                       clsLanguages.GetResource("Information"),
                                       Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                       Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                tbxCommonTypeId.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(objSea.Description))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("NotEnterNote"),
                                       clsLanguages.GetResource("Information"),
                                       Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                       Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    rtbDescrition.Focus();
                }
                else
                {

                    if (obj != null)
                    {
                        //cập nhật
                        if (CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("CommonCodeUpdate"),
                                   clsLanguages.GetResource("Information"),
                                   Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                        {
                            objSea.CommonTypeId = obj.CommonTypeId;
                            int i = objBLL.Update(objSea);
                            if (i == 1)
                            {
                                lblTB.Text = Common.clsLanguages.GetResource("UpdateSuccess1");
                            }
                            else
                            {
                                lblTB.Text = Common.clsLanguages.GetResource("UpdateNoSuccess1");
                            }
                        }
                    }
                    else
                    {
                        //thêm mới
                        if (CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("CommonCodeCreate"),
                                   clsLanguages.GetResource("Information"),
                                   Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                        {
                            int i = objBLL.Insert(objSea);
                            if (i == 1)
                            {
                                lblTB.Text = Common.clsLanguages.GetResource("InsertSuccess1");
                            }
                            else
                            {
                                lblTB.Text = Common.clsLanguages.GetResource("InsertNoSuccess1");
                            }
                        }
                    }
                }
                SearchCommonType(1);
            }
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string commonTypeId = dgvResult.Rows[e.RowIndex].Cells[1].Value.ToString();
                CommonType ctId = new CommonType();
                ctId = objBLL.GetCommonTypeById(commonTypeId);
                if (ctId != null)
                {
                    tbxCommonTypeId.Text = string.IsNullOrEmpty(ctId.CommonTypeId) ? "" : ctId.CommonTypeId;
                    rtbDescrition.Text = string.IsNullOrEmpty(ctId.Description) ? "" : ctId.Description;
                    tbxNote.Text = string.IsNullOrEmpty(ctId.Note) ? "" : ctId.Note;
                }

                if (e.ColumnIndex == 5)
                {
                   
                        if (ctId.CanDelete == "1")
                        {
                            if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("Delete01"),
                                       Common.clsLanguages.GetResource("Information"),
                                       Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                       Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                            {

                                int Xoa = objBLL.Detele(commonTypeId);
                                // xóa thành côg

                                if (Xoa == 1)
                                {
                                    dgvResult.Rows.RemoveAt(e.RowIndex);
                                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DeleteSuccess"),
                                                    Common.clsLanguages.GetResource("Information"),
                                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                                    lblTB.Text = "...";
                                    lblTB1.Text = "...";
                                    //đánh lại stt
                                    int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                                    for (int i = 0; i < dgvResult.Rows.Count; i++)
                                    {
                                        dgvResult.Rows[i].Cells[0].Value = ((CurPage - 1) * RecPerPage + (i + 1)).ToString();
                                    }
                                
                                 }
                         }
                        }
                        else
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("NoDelete"),
                                                    Common.clsLanguages.GetResource("Information"),
                                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }

                    }
                }

            
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            foreach (Control c in this.pnlInput.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = String.Empty;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
            dgvResult.Rows.Clear();
            totalPage = 0;
            lblTB.Text = "...";
            lblTB1.Text = "...";
        }

        private void btnPre_Click(object sender, System.EventArgs e)
        {
            if (CurPage > 1)
            {
                SearchCommonType(CurPage - 1);
            }
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            if (CurPage < totalPage)
            {
                SearchCommonType(CurPage + 1);
            }
        }

        private void btnExcel_Click(object sender, System.EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToExcel()
        {
            DataTable Final = new DataTable();
            int total = 0;
            Final = objBLL.SearchCommonType(objSea, 1, out total);
            double RecordPerPage = 20;            
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            for (int i = 2; i <= totalPage; i++) // duyet tat ca cac trang
            {
                DataTable dt = objBLL.SearchCommonType(objSea, i, out total);
                int j = Final.Rows.Count;
                foreach (DataRow dr in dt.Rows)
                {
                    Final.Rows.Add();
                    for (int k = 0; k < dt.Columns.Count; k++)
                    {
                        Final.Rows[j][k] = dr[k];
                    }
                    j++;
                }
            }
            ExportExcelAlgorithms epex = new ExportExcelAlgorithms();

            epex.ExportFileFromDataTable_Dung(Final, "CommonType_" + DateTime.Now.ToString("ddMMyy_HHmmss"), 
                "List of " + "CommonType_" + DateTime.Now.ToString("ddMMyy_HHmmss"), null);
        }

        #region TextBox Events

        private void tbxCommonTypeId_TextChanged(object sender, System.EventArgs e)
        {
            Common.Utility.TextLengthValid(tbxCommonTypeId, 20);
        }

        private void tbxNote_TextChanged(object sender, System.EventArgs e)
        {
            Common.Utility.TextLengthValid(tbxCommonTypeId, 255);
        }

        private void rtbDescrition_TextChanged(object sender, System.EventArgs e)
        {
            if (rtbDescrition.Text.Length > 255)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseEnterLessThan99Characters"),
                                           Common.clsLanguages.GetResource("Information"),
                                           Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                           Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                rtbDescrition.Text = rtbDescrition.Text.Substring(0, rtbDescrition.Text.Length - 1);
                rtbDescrition.SelectionStart = rtbDescrition.Text.Length;
                return;
            }
        }
        #endregion

    }
}
