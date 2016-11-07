using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosM1.Entities;
using VVPosM1.BusinessLayer;
using Microsoft.Reporting.WinForms;
using VVPosM1.Controls;

namespace VVPosM1.Screen
{
    public partial class frmRpt_DoanhThu : Form
    {
        private rptDoanhThuBLL objBLL;
        private string userID;
        private bool _bCheck = false;
        private int _iTotalRec;

        public frmRpt_DoanhThu()
        {
           
            InitializeComponent();
            SetUIChanges();
        }
        public void SetUIChanges()
        {
            this.Text = Common.clsLanguages.GetResource("ReportOfEmployeeRevenues");
            gb_SelectInformation.Text = Common.clsLanguages.GetResource("SelectInformation");
            lb_FromDate.Text = Common.clsLanguages.GetResource("FromDate");
            lb_ToDate.Text = Common.clsLanguages.GetResource("ToDate");
            btnBaoCao.Text = Common.clsLanguages.GetResource("ViewReport");          
            btnThoat.Text = Common.clsLanguages.GetResource("Exit");
            gb_ReportDetail.Text = Common.clsLanguages.GetResource("ReportDetail");           
            cbTatCa.Text = Common.clsLanguages.GetResource("All");
            checkThoiGian.Text = Common.clsLanguages.GetResource("chkDate");
        }

        private void frmRpt_DoanhThu_Load(object sender, EventArgs e)
        {
            objBLL = new rptDoanhThuBLL();
            LoadUser();
            this.rptViewer1.RefreshReport();
            
        }

        DataTable dt1 = new DataTable();
        public void LoadUser()
        {
            dt1 = objBLL.GetUser();
            _iTotalRec = dt1.Rows.Count;
            Dictionary<string, string> test = new Dictionary<string, string>();           
            //string str;
            ObjectBLL objectBLL = new ObjectBLL();

            foreach (DataRow dr in dt1.Rows)
            {
                string fullName = objectBLL.GetObjectByObjectId(dr["ObjectId"].ToString()).Rows[0]["FullName"].ToString();
                //str = dr["UserId"].ToString() + fullName;// + "," + dr["EmployeeName"].ToString();
                test.Add(dr["UserId"].ToString(), fullName);
            }
            clbUser.DataSource = new BindingSource(test, null);
            clbUser.DisplayMember = "Value";
            clbUser.ValueMember = "Key";
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            int check = 0;
            int dem = 0;
            try
            {
                for (int i = 0; i < clbUser.Items.Count; i++)
                {
                    if (clbUser.GetItemChecked(i))
                        dem++;
                }
                if (dem == 0)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("SelectNV"),
                                          Common.clsLanguages.GetResource("Information"),
                                          Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                          Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                }
                else
                {

                    for (int i = 0; i < clbUser.Items.Count; i++)
                    {
                        if (clbUser.GetItemChecked(i))
                        {
                            // userID += "'"+clbUser.SelectedValue.ToString() + "',";
                            userID += "'" + dt1.Rows[i]["UserId"].ToString() + "',";
                        }
                    }

                    string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd");
                    string denNgay = dtpToiNgay.Value.ToString("yyyy-MM-dd");

                    userID = userID.Substring(0, userID.Length - 1);

                    //if (userID != "" || userID != null)
                    //{
                    //    userID = userID.Trim().Trim(',');
                    //}
                    //else
                    //{
                    //    userID = "";
                    //}
                    if (checkThoiGian.Checked)
                    {
                        check = 1;
                    }
                    else check = 0;

                    DataTable dt = objBLL.GetReportSTT(userID, tuNgay, denNgay, check);
                    userID = "";
                    if (dt.Rows.Count > 0)
                    {
                        rptViewer1.LocalReport.DataSources.Clear();
                        rptViewer1.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.frmDoanhThu.rdlc";
                        rptViewer1.ZoomMode = ZoomMode.PageWidth;
                        Microsoft.Reporting.WinForms.ReportDataSource ds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);

                        rptViewer1.LocalReport.DataSources.Add(ds);

                        ds.Value = dt;
                        //logo
                        string templateImage = Common.Utility.GetUrlFromService("ShopImg", "logoprint.png");
                        // gán parameters
                        ReportParameter[] lstParams = new ReportParameter[15];
                        lstParams[0] = new ReportParameter("TenCTy", Common.clsLanguages.GetResource("MerchantName"));
                        lstParams[1] = new ReportParameter("DCCty", Common.clsLanguages.GetResource("MerchantAddress"));
                        lstParams[2] = new ReportParameter("TieuDe", Common.clsLanguages.GetResource("ReportOfEmployeeRevenues"));
                        lstParams[3] = new ReportParameter("Time", Common.clsLanguages.GetResource("GetDateReport") + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                        if (check == 1)
                        {
                            lstParams[4] = new ReportParameter("Time1", Common.clsLanguages.GetResource("FromDate") + " " + dtpTuNgay.Value.ToString("dd/MM/yyyy") + " " + Common.clsLanguages.GetResource("ToDate") + " " + dtpToiNgay.Value.ToString("dd/MM/yyyy"));
                        }
                        else
                             lstParams[4] = new ReportParameter("Time1", Common.clsLanguages.GetResource("AllTime"));

                        lstParams[5] = new ReportParameter("ImageName", templateImage);
                        lstParams[6] = new ReportParameter("No", Common.clsLanguages.GetResource("No"));
                        lstParams[7] = new ReportParameter("InformationEmployee", Common.clsLanguages.GetResource("InformationEmployee"));
                        lstParams[8] = new ReportParameter("Status", Common.clsLanguages.GetResource("Status"));
                        lstParams[9] = new ReportParameter("TotalAmountBeforeTax", Common.clsLanguages.GetResource("TotalAmountBeforeTax"));
                        lstParams[10] = new ReportParameter("TotalTax", Common.clsLanguages.GetResource("TotalTaxAmount"));
                        lstParams[11] = new ReportParameter("TotalAmount", Common.clsLanguages.GetResource("TotalAmount"));
                        lstParams[12] = new ReportParameter("DiscountAmount", Common.clsLanguages.GetResource("DiscountAmount"));
                        lstParams[13] = new ReportParameter("TotalMoney", Common.clsLanguages.GetResource("TotalMoney"));
                        lstParams[14] = new ReportParameter("Total", Common.clsLanguages.GetResource("TotalAll"));
                        rptViewer1.LocalReport.EnableExternalImages = true;
                        this.rptViewer1.LocalReport.SetParameters(lstParams);
                        rptViewer1.LocalReport.Refresh();
                        rptViewer1.RefreshReport();

                    }
                    else
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DoanhThuNull"),
                                      Common.clsLanguages.GetResource("Information"),
                                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                }
            }
            //}
            catch (Exception ex)
            {

            }
            finally
            {
                rptViewer1.Refresh();
            }
        
        }

        private void cbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            //var ob = (CheckBox)sender;
            //if (ob.Name == "cbTatCa")
            //{
                for (int i = 0; i < clbUser.Items.Count; i++)
                {

                    //clbUser.SetItemChecked(i, cbTatCa.Checked);
                    //Dung
                    if (cbTatCa.Checked) clbUser.SetItemChecked(i, cbTatCa.Checked);
                    else {
                        if (!_bCheck)
                        { 
                            clbUser.SetItemChecked(i, cbTatCa.Checked);
                            _bCheck = false;
                        }
                    }
                    //End Dung
                }
            //}
        }

        private void check_change(object sender, EventArgs e)
        {
            dtpTuNgay.Enabled = checkThoiGian.Checked;
            dtpToiNgay.Enabled = checkThoiGian.Checked;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clbUser_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (clbUser.SelectedIndex != -1)
            //    cbTatCa.Checked = false;
        }

        private void clbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (clbUser.SelectedIndices.Count != clbUser.Items.Count )
            //{
                
            //        cbTatCa.Checked = false;
                
                
            //}

            //for (int i = 0; i < clbUser.Items.Count; i++)
            //{

            //    //if (clbUser.SelectedIndices(i)) {
                
            //    }
                
            //}
        }

        #region Begin Dung
        private void clbUser_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int _iCount = clbUser.CheckedItems.Count;
            int _iCount1 = clbUser.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked) { ++_iCount1; }
            if (e.NewValue == CheckState.Unchecked) { --_iCount1; }

            if (_iCount1 < _iCount)
            {
                _bCheck = true;
                this.cbTatCa.Checked = false;

                //ckbAll_CheckedChanged(null, null);
            }
            else if (_iCount1 == _iTotalRec)
            {
                //_bCheck = true;
                this.cbTatCa.Checked = true;
                //ckbAll_CheckedChanged(null, null);
            }
            userID = "";
        }

        private void cbTatCa_Click(object sender, EventArgs e)
        {
            _bCheck = false;
        }

        #endregion End Dung

    }
}
