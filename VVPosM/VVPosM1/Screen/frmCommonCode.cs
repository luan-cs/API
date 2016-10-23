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

using System.Text.RegularExpressions;


namespace VVPosM1.Screen
{
    public partial class frmCommonCode : Form
    {
        private ProductGroupBLL objBLL;
        //private CommonCodeBLL commonCodeBLL;
        private Entities.ProductGroup objSea;
        private int CurPage;
        private double totalPage;
        private string objTempId;
        private Boolean soAm = true;
        private Boolean thapPhan = true;

        public frmCommonCode()
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
            gbResult.Text = Common.clsLanguages.GetResource("CommonCodeList");
            lbCommonTypeId.Text = Common.clsLanguages.GetResource("TypeId");
            lbCommonId.Text = Common.clsLanguages.GetResource("CommonId");
            //lbStrValue1.Text = Common.clsLanguages.GetResource("lblStrValue1");
            //lbStrValue2.Text = Common.clsLanguages.GetResource("lblStrValue2");
            //lbNumValue1.Text = Common.clsLanguages.GetResource("lblNumValue1");
            //lbNumValue2.Text = Common.clsLanguages.GetResource("lblNumValue2");

            btnSearch.Text = Common.clsLanguages.GetResource("Search");
            btnSave.Text = Common.clsLanguages.GetResource("Save");
            btnReset.Text = Common.clsLanguages.GetResource("Reset");
            btnExcel.Text = Common.clsLanguages.GetResource("ExportExcelFile");
            btnExit.Text = Common.clsLanguages.GetResource("Exit");


            this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            //this.ID.HeaderText = Common.clsLanguages.GetResource("TypeId");
            //this.CommonId.HeaderText = Common.clsLanguages.GetResource("CommonId");
            //this.Value.HeaderText = Common.clsLanguages.GetResource("Value");
            //this.CreateInfo.HeaderText = Common.clsLanguages.GetResource("InfoInitiated");
            this.Delete.HeaderText = Common.clsLanguages.GetResource("Delete");
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCommonCode_Load(object sender, EventArgs e)
        {
            objBLL = new ProductGroupBLL();
        }
        

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            CurPage = 1;
            totalPage = 1;
            //Truyen gia tri vao doi tuong objSea
            objSea = new ProductGroup();
            objSea.ProductGroupId = tbCommonId.Text;
            objSea.ProductGroupName = txtName.Text;

            SearchCommonCode(1);
        }

        private void SearchCommonCode(int page)
        {
            CurPage = page;

            int total = 0;
            DataTable dt = objBLL.SearchProductGroup(objSea, CurPage, out total);
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
                    string str = "";
                    dgvResult.Rows.Add();
                    //STT
                    dgvResult.Rows[i].Cells[0].Value = (stt + 1).ToString();
                    //Mã loại
                    dgvResult.Rows[i].Cells[1].Value = dr["ProductGroupId"].ToString();
                    //Tên
                    dgvResult.Rows[i].Cells[2].Value = dr["ProductGroupName"].ToString();

                    i++; stt++;
                }
            }
            linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
            lblTB.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string commonTypeId = dgvResult.Rows[e.RowIndex].Cells[1].Value.ToString();
                ProductGroup ctId = new ProductGroup();
                ctId = objBLL.GetProductGroupId(commonTypeId);

                if (e.ColumnIndex == 3)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("Delete01"),
                               Common.clsLanguages.GetResource("Information"),
                               Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                               Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {

                        int Xoa = objBLL.Delete(commonTypeId);
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


                        //DataTable tb = new DataTable();
                        //    tb = objBLL.GetChildren(commonTypeId, commonId);
                        //    if (tb == null || tb.Rows.Count == 0)
                        //    {
                        //        CommonType cmt = new CommonType();
                        //        cmt = objBLL.GetTableColumnByCommonTypeId(commonTypeId);
                        //        if (cmt != null && cmt.TableColumUser.ToString() != null)
                        //        {
                        //            if (cmt.TableColumUser.ToString() != "")
                        //            {
                        //                string[] lines2 = Regex.Split(cmt.TableColumUser.ToString(), ",");
                        //                string table = lines2[0];
                        //                string column = lines2[1];
                        //                Boolean c = objBLL.CheckUser(table, column, commonId);
                        //                if (c == true)
                        //                {
                        //                    int Xoa = objBLL.Detele(commonTypeId, commonId);
                        //                    // xóa thành côg

                        //                    if (Xoa == 1)
                        //                    {
                        //                        dgvResult.Rows.RemoveAt(e.RowIndex);
                        //                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DeleteSuccess"),
                        //                                        Common.clsLanguages.GetResource("Information"),
                        //                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        //                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        //                        lblTB.Text = "...";
                        //                        lblTB1.Text = "...";
                        //                        //đánh lại stt
                        //                        int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                        //                        for (int i = 0; i < dgvResult.Rows.Count; i++)
                        //                        {
                        //                            dgvResult.Rows[i].Cells[0].Value = ((CurPage - 1) * RecPerPage + (i + 1)).ToString();
                        //                        }
                        //                    }
                        //                }
                        //                else
                        //                {
                        //                    CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("Đang được sử dụng, không thể xóa"),// đang được sử dụng
                        //                      Common.clsLanguages.GetResource("Information"),
                        //                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        //                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        //                }
                        //            }
                        //                else
                        //            {
                        //             int Xoa = objBLL.Detele(commonTypeId, commonId);
                        //                    // xóa thành côg

                        //                    if (Xoa == 1)
                        //                    {
                        //                        dgvResult.Rows.RemoveAt(e.RowIndex);
                        //                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DeleteSuccess"),
                        //                                        Common.clsLanguages.GetResource("Information"),
                        //                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        //                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        //                        lblTB.Text = "...";
                        //                        lblTB1.Text = "...";
                        //                        //đánh lại stt
                        //                        int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
                        //                        for (int i = 0; i < dgvResult.Rows.Count; i++)
                        //                        {
                        //                            dgvResult.Rows[i].Cells[0].Value = ((CurPage - 1) * RecPerPage + (i + 1)).ToString();
                        //                        }
                        //                    }
                        //            }
                        //        }
                        //          else
                        //            {
                        //                CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("NoDelete, vì đang được sử dụng"),// đang được sử dụng
                        //                  Common.clsLanguages.GetResource("Information"),
                        //                  Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        //                  Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        //            }
                        //        }

                        //    else
                        //    {
                        //        CustomMessageBox.MessageBox.ShowCustomMessageBox(clsLanguages.GetResource("Có chứa phần tử con, không thể xóa"),// đang được sử dụng
                        //                      Common.clsLanguages.GetResource("Information"),
                        //                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        //                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        //    }
                        //}

                    }
                    
                }
                else
                {
                    if (ctId != null)
                    {
                        tbCommonId.Text = ctId.ProductGroupId;
                        txtName.Text = ctId.ProductGroupName;
                    }
                }
            }
        }

        private void btnPre_Click(object sender, System.EventArgs e)
        {
            if (CurPage > 1)
            {
                SearchCommonCode(CurPage - 1);
            }
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            if (CurPage < totalPage)
            {
                SearchCommonCode(CurPage + 1);
            }
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            foreach (Control c in this.pnInput.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = String.Empty;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedValue = "";
                }
            }

            foreach (Control c in this.gbResult.Controls)
            {
                if (c is DataGridView)
                {
                    ((DataGridView)c).Rows.Clear();
                }
            }
            lblTB.Text = @"...";
            lblTB1.Text = @"...";
            linkNumber.Text = "0";
            totalPage = 0;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            string objCtId = tbCommonId.Text;

            ProductGroup obj = new ProductGroup();
            obj = objBLL.GetProductGroupId(objCtId);

            objSea.ProductGroupId = tbCommonId.Text;
            objSea.ProductGroupName = txtName.Text;
            
                if (obj != null)
                {
                    //cập nhật
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox("Loại đã tồn tại. Bạn có muốn cập nhật hay không?",
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                       
                        int i = objBLL.Update(objSea);
                        if (i == 1)
                        {
                            lblTB1.Text = Common.clsLanguages.GetResource("UpdateSuccess1");
                        }
                        else
                        {
                            lblTB1.Text = Common.clsLanguages.GetResource("UpdateNoSuccess1");
                        }
                    }
                }
                else
                {
                    //thêm mới
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox("Bạn chắc chắn muốn tạo mới loại?",
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        int i = objBLL.Insert(objSea);
                        if (i == 1)
                        {
                            lblTB1.Text = Common.clsLanguages.GetResource("InsertSuccess1");
                        }
                        else
                        {
                            lblTB1.Text = Common.clsLanguages.GetResource("InsertNoSuccess1");
                        }
                    }
                }
                SearchCommonCode(1);
            

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            DataTable Final = new DataTable();
            int total = 0;
            Final = objBLL.SearchProductGroup(objSea, 1, out total);
            double RecordPerPage = 20;
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            for (int i = 2; i <= totalPage; i++) // duyet tat ca cac trang
            {
                DataTable dt = objBLL.SearchProductGroup(objSea, i, out total);
                int j = Final.Rows.Count;
                foreach (DataRow dr in dt.Rows)
                {
                    Final.Rows.Add();
                    int k = 0;
                    for (k = 0; k < dt.Columns.Count; k++)
                    {
                        Final.Rows[j][k] = dr[k];
                    }
                    j++;
                }
            }
            ExportExcelAlgorithms epex = new ExportExcelAlgorithms();

            epex.ExportFileFromDataTable_Dung(Final, "CommonCode_" + DateTime.Now.ToString("ddMMyy_HHmmss"),
                "List of " + "CommonCode_" + DateTime.Now.ToString("ddMMyy_HHmmss"), null);
        }

        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        private void tbNumValue1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Common.Utility.MaskDecimal(e);
        }


        private void tbNumValue2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            #region chỉ được nhập số
            //if (string.IsNullOrEmpty(tbNumValue2.Text))
            //{
            //    soAm = true;
            //    thapPhan = true;
            //}
            //if (((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) || (e.KeyChar < (char)32) || (e.KeyChar == 43) || (e.KeyChar == '-') || (e.KeyChar == '.'))
            //{
            //    if (e.KeyChar == '.')
            //    {
            //        if (thapPhan)
            //        {
            //            e.Handled = false;
            //            thapPhan = false;
            //        }
            //        else
            //        {
            //            e.Handled = true;
            //        }
            //    }
            //    else
            //    {
            //        if (e.KeyChar == '-')
            //        {
            //            if (soAm)
            //            {
            //                e.Handled = false;
            //            }
            //            else
            //            {
            //                e.Handled = true;
            //            }
            //        }
            //        else
            //        {
            //            e.Handled = false;
            //        }
            //    }
            //    soAm = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
            #endregion
            Common.Utility.MaskDecimal(e);
        }

        

        #region Text Events

        private void tbCommonId_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(tbCommonId, 20);
        }

        private void tbStrValue1_TextChanged(object sender, EventArgs e)
        {
            //Common.Utility.TextLengthValid(tbStrValue1, 255);
        }

        private void tbStrValue2_TextChanged(object sender, EventArgs e)
        {
            //Common.Utility.TextLengthValid(tbStrValue2, 255);
        }

        private void tbNumValue1_TextChanged(object sender, EventArgs e)
        {
            //Common.Utility.TextLengthValid(tbNumValue1, 26);
            //Common.Utility.TextFormatNumber(tbNumValue1, ConfigurationManager.AppSettings["TextFormatNum"]);
        }

        private void tbNumValue2_TextChanged(object sender, EventArgs e)
        {
            //Common.Utility.TextLengthValid(tbNumValue2, 26);
            //Common.Utility.TextFormatNumber(tbNumValue2, ConfigurationManager.AppSettings["TextFormatNum"]);
        }

        

        #endregion

        //hung 19-01-2015
        string CommonTypeId = "";
        string CommonId2 = null;
        string gach = "";
        private void LoadParent()
        {
            //if (cbCommonTypeId.SelectedIndex != 0)
            //{
            //    CommonTypeId = cbCommonTypeId.SelectedValue.ToString();
            //    commonCodeBLL = new CommonCodeBLL();
            //    Dictionary<string, string> test = new Dictionary<string, string>();
            //    test.Add("", VVPosM1.Common.clsLanguages.GetResource("Gender_null"));
            //    dequyParent(ref test,CommonTypeId, CommonId2,gach);
            //    cbParent.DataSource = new BindingSource(test, null);
            //    cbParent.DisplayMember = "Value";
            //    cbParent.ValueMember = "Key";
            //     CommonTypeId = "";
            //     CommonId2 = null;
            //}
            //else
            //{
            //    Dictionary<string, string> test = new Dictionary<string, string>();
            //    test.Add("", VVPosM1.Common.clsLanguages.GetResource("Gender_null"));
            //    cbParent.DataSource = new BindingSource(test, null);
            //    cbParent.DisplayMember = "Value";
            //    cbParent.ValueMember = "Key";
            //}
        }

        private void cbCommonTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParent();
        }

        private void dequyParent(ref Dictionary<string, string> test,string CommonTypeId1, string CommonId1,string gach)
        {
            //DataTable dt = commonCodeBLL.GetParent(CommonTypeId1, CommonId1);
            //if (dt != null)
            //{
            //    gach = gach + "--";
            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            string str = dr["CommonTypeId"].ToString() + "," + dr["CommonId"].ToString();
            //            string str1 =gach+ dr["CommonId"].ToString() + "." + dr["StrValue1"].ToString();
            //            test.Add(str, str1);
            //            CommonTypeId = dr["CommonTypeId"].ToString();
            //            CommonId2 = dr["CommonId"].ToString();
            //            dequyParent(ref test,CommonTypeId, CommonId2,gach);
            //        }
                    
            //}
        
        }
        int kt = 0;
        private Boolean ktdequyParent(string CommonTypeId1, string CommonId1, string parentSelect)
        {
            return true;
            //DataTable dt = commonCodeBLL.GetChildren(CommonTypeId1, CommonId1);
            //if (dt != null)
            //{
                
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        if (parentSelect == (dr["CommonTypeId"].ToString() + "," + dr["CommonId"].ToString()))
            //        {
                       
            //            kt=1;
            //        }
            //        CommonTypeId = dr["CommonTypeId"].ToString();
            //        CommonId2 = dr["CommonId"].ToString();                   
            //        ktdequyParent(CommonTypeId, CommonId2,parentSelect);
                    
            //    }
            //    //if (kt == 1)
            //    //    return false;

            //}
            //if (kt == 1)
            //    return false;
            //else return true;
            //kt = 0;

        }

    }
}
