using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using VVPosM1.BusinessLayer;

namespace VVPosM1.Screen
{
    public partial class frmRpt_ByProduct : Form
    {
        private rptByProductBLL byProductBLL;
        public frmRpt_ByProduct()
        {
            InitializeComponent();
            SetUIChanges();
            byProductBLL = new rptByProductBLL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.rptViewByProduct.RefreshReport();
            LoadProduct();
        }
        public void SetUIChanges()
        {
            this.Text = Common.clsLanguages.GetResource("ReportByProduct"); 
            gb_SelectInformation.Text = Common.clsLanguages.GetResource("SelectInformation");         
            lb_FromDate.Text = Common.clsLanguages.GetResource("FromDate");
            lb_ToDate.Text = Common.clsLanguages.GetResource("ToDate");
            btn_ViewReport.Text = Common.clsLanguages.GetResource("ViewReport");        
            btnThoat.Text = Common.clsLanguages.GetResource("Exit");
            gb_ReportDetail.Text = Common.clsLanguages.GetResource("ReportDetail");
            lb_SPorNSP.Text = Common.clsLanguages.GetResource("ProductOrProductGroup");
            chkProduct.Text = Common.clsLanguages.GetResource("chkProduct");
            chkGroupProduct.Text = Common.clsLanguages.GetResource("chkProductGroup");
        }

        private void chk_change(object sender, EventArgs e)
        {
            if (chkProduct.Checked)
            {

                chkGroupProduct.Checked = false;
                LoadProduct();
            }
            else if (!chkProduct.Checked)
            {
                chkGroupProduct.Checked = true;
                LoadGroupProduct();
            }
            //if(chkNhomSanPham.Checked)
            //    {
            //        chkSanPham.Checked = false;
            //    }

        }

        private void chk_changeGroup(object sender, EventArgs e)
        {
            if (chkGroupProduct.Checked)
            {
                chkProduct.Checked = false;
                LoadGroupProduct();
            }
            else if (!chkGroupProduct.Checked)
            {
                chkProduct.Checked = true;
                LoadProduct();
            }
           

        }
      


        private void LoadProduct()
        {

            DataTable dt = byProductBLL.GetProduct();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Null_Tatca"));
            foreach (DataRow dr in dt.Rows)
            {
                string str = dr["Name"].ToString() + "-" + dr["ProductId"].ToString();
                test.Add(dr["ProductId"].ToString(), str);
            }
            cboLoad.DataSource = new BindingSource(test, null);
            cboLoad.DisplayMember = "Value";
            cboLoad.ValueMember = "Key";
        }
        //load nhóm sản phẩm
        private void LoadGroupProduct()
        {
            DataTable dt = byProductBLL.GetProductType();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Null_Tatca"));
            foreach (DataRow dr in dt.Rows)
            {
                string str = dr["ProductType"].ToString() + "-" + dr["StrValue1"].ToString();
                test.Add(dr["ProductType"].ToString(), str);
            }
            cboLoad.DataSource = new BindingSource(test, null);
            cboLoad.DisplayMember = "Value";
            cboLoad.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string from = dtpTuNgay.Value.ToString("yyyy-MM-dd");
                string to = dtpDenNgay.Value.ToString("yyyy-MM-dd");
                string productId = cboLoad.SelectedValue.ToString();
                DataTable dt = new DataTable();
                // nếu chọn chkbox sản phẩm
                if (chkProduct.Checked)
                {
                    DataTable dtTong = byProductBLL.GetReportTong(productId, from, to);
                    dt = byProductBLL.GetReportSTT(productId, from, to);
                    //  dt = AddTotalRecord(dt,dtTong);
                    if (dt.Rows.Count > 0)
                    {
                        rptViewByProduct.LocalReport.DataSources.Clear();
                        rptViewByProduct.ZoomMode = ZoomMode.PageWidth;
                        rptViewByProduct.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.rptByProduct.rdlc";

                        Microsoft.Reporting.WinForms.ReportDataSource ds = new Microsoft.Reporting.WinForms.ReportDataSource("DataRptByProduct", dt);

                        rptViewByProduct.LocalReport.DataSources.Add(ds);

                        ds.Value = dt;
                        //logo
                        string templateImage = Common.Utility.GetUrlFromService("ShopImg", "logoprint.png");
                        // gán parameters
                        ReportParameter[] lstParams = new ReportParameter[13];
                        lstParams[0] = new ReportParameter("TenCTy", Common.clsLanguages.GetResource("MerchantName"));
                        lstParams[1] = new ReportParameter("DChiCTy", Common.clsLanguages.GetResource("MerchantAddress"));
                        lstParams[2] = new ReportParameter("TieuDe1", Common.clsLanguages.GetResource("ReportByProduct"));
                        lstParams[3] = new ReportParameter("Time1", Common.clsLanguages.GetResource("GetDateReport") + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                        lstParams[4] = new ReportParameter("TimeS1", Common.clsLanguages.GetResource("FromDate") + " " + dtpTuNgay.Value.ToString("dd/MM/yyyy") + " " + Common.clsLanguages.GetResource("ToDate") + " " + dtpDenNgay.Value.ToString("dd/MM/yyyy"));
                        lstParams[5] = new ReportParameter("ImageName", templateImage);
                        lstParams[6] = new ReportParameter("No", Common.clsLanguages.GetResource("No"));
                        lstParams[7] = new ReportParameter("Information", Common.clsLanguages.GetResource("Information"));
                        lstParams[8] = new ReportParameter("Qty", Common.clsLanguages.GetResource("Qty"));
                        lstParams[9] = new ReportParameter("TotalAmountBeforeTax", Common.clsLanguages.GetResource("TotalAmountBeforeTax"));
                        lstParams[10] = new ReportParameter("TaxAmount", Common.clsLanguages.GetResource("TaxAmount"));
                        lstParams[11] = new ReportParameter("TotalAmount", Common.clsLanguages.GetResource("TotalAmount"));
                        lstParams[12] = new ReportParameter("TotalAll", Common.clsLanguages.GetResource("TotalAll"));

                        rptViewByProduct.LocalReport.EnableExternalImages = true;
                        this.rptViewByProduct.LocalReport.SetParameters(lstParams);
                        rptViewByProduct.LocalReport.Refresh();
                        rptViewByProduct.RefreshReport();

                    }
                    else
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DataNull"),
                                      Common.clsLanguages.GetResource("Information"),
                                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                }

                    
                

                // nếu chọn nhóm sản phẩm
                if (chkGroupProduct.Checked)
                {
                    DataTable dtTong = byProductBLL.GetReportGroupTong(productId, from, to);
                    dt = byProductBLL.GetReportSTTGroup(productId, from, to);
                   // dt = AddTotalRecord(dt, dtTong);
                    if (dt.Rows.Count > 0)
                    {
                        rptViewByProduct.LocalReport.DataSources.Clear();
                        rptViewByProduct.ZoomMode = ZoomMode.PageWidth;
                        rptViewByProduct.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.rptByProduct.rdlc";

                        Microsoft.Reporting.WinForms.ReportDataSource ds = new Microsoft.Reporting.WinForms.ReportDataSource("DataRptByProduct", dt);

                        rptViewByProduct.LocalReport.DataSources.Add(ds);

                        ds.Value = dt;
                        //logo
                        string templateImage = Common.Utility.GetUrlFromService("ShopImg", "logoprint.png");
                        // gán parameters
                        ReportParameter[] lstParams = new ReportParameter[13];
                        lstParams[0] = new ReportParameter("TenCTy", Common.clsLanguages.GetResource("MerchantName"));
                        lstParams[1] = new ReportParameter("DChiCTy", Common.clsLanguages.GetResource("MerchantAddress"));
                        lstParams[2] = new ReportParameter("TieuDe1", Common.clsLanguages.GetResource("ReportByProduct"));
                        lstParams[3] = new ReportParameter("Time1", Common.clsLanguages.GetResource("GetDateReport") + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                        lstParams[4] = new ReportParameter("TimeS1", Common.clsLanguages.GetResource("FromDate") + " " + dtpTuNgay.Value.ToString("dd/MM/yyyy") + " " + Common.clsLanguages.GetResource("ToDate") + " " + dtpDenNgay.Value.ToString("dd/MM/yyyy"));
                        lstParams[5] = new ReportParameter("ImageName", templateImage);
                        lstParams[6] = new ReportParameter("No", Common.clsLanguages.GetResource("No"));
                        lstParams[7] = new ReportParameter("Information", Common.clsLanguages.GetResource("Information"));
                        lstParams[8] = new ReportParameter("Qty", Common.clsLanguages.GetResource("Qty"));
                        lstParams[9] = new ReportParameter("TotalAmountBeforeTax", Common.clsLanguages.GetResource("TotalAmountBeforeTax"));
                        lstParams[10] = new ReportParameter("TaxAmount", Common.clsLanguages.GetResource("TaxAmount"));
                        lstParams[11] = new ReportParameter("TotalAmount", Common.clsLanguages.GetResource("TotalAmount"));
                        lstParams[12] = new ReportParameter("TotalAll", Common.clsLanguages.GetResource("TotalAll"));

                        rptViewByProduct.LocalReport.EnableExternalImages = true;
                        this.rptViewByProduct.LocalReport.SetParameters(lstParams);
                        rptViewByProduct.LocalReport.Refresh();
                        rptViewByProduct.RefreshReport();

                    }
                    else
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DataNull"),
                                      Common.clsLanguages.GetResource("Information"),
                                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                }

            }

            catch (Exception ex)
            {

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // thêm dòng tổng sản phẩm
        private DataTable AddTotalRecord(DataTable dt, DataTable dtTong)
        {
            DataRow drr = dt.NewRow();
            drr["STT"] = "";
            drr["TTSPham"] = Common.clsLanguages.GetResource("TotalAll");
            drr["TotalQty"] = "0";
            drr["TotalAmountBeforeTax"] = "0";
            drr["TaxAmount"] = "0";
            drr["TotalAmount"] = "0";


            foreach (DataRow dr in dtTong.Rows)
            {
                string a2 = string.Format("{0:0,0}", dr["SoLuong"]);
                drr["TotalQty"] = a2.Replace(".", ",");
                string a3 = string.Format("{0:0,0}", dr["TongTienTruocThue"]);
                drr["TotalAmountBeforeTax"] = a3.Replace(".", ",");
                string a4 = string.Format("{0:0,0}", dr["TongTienThue"]);
                drr["TaxAmount"] = a4.Replace(".", ",");
                string a5 = string.Format("{0:0,0}", dr["DoanhThu"]);
                drr["TotalAmount"] = a5.Replace(".", ",");
               
            }

            dt.Rows.Add(drr);
            return dt;
        }
       
        // thêm dòng tổng cho group
        private DataTable AddTotalRecordGroup(DataTable dt, DataTable dtTong)
        {
            DataRow drr = dt.NewRow();
            drr["STT"] = "";
            drr["TTSPham"] = Common.clsLanguages.GetResource("TotalAll");
            drr["TotalQty"] = "0";
            drr["TotalAmountBeforeTax"] = "0";
            drr["TaxAmount"] = "0";
            drr["TotalAmount"] = "0";


            foreach (DataRow dr in dtTong.Rows)
            {
                string a2 = string.Format("{0:###,###,###}", dr["SoLuong"]);
                drr["TotalQty"] = a2.Replace(".", ",");
                string a3 = string.Format("{0:###,###,###}", dr["TongTienTruocThue"]);
                drr["TotalAmountBeforeTax"] = a3.Replace(".", ",");
                string a4 = string.Format("{0:###,###,###}", dr["TongTienThue"]);
                drr["TaxAmount"] = a4.Replace(".", ",");
                string a5 = string.Format("{0:###,###,###}", dr["DoanhThu"]);
                drr["TotalAmount"] = a5.Replace(".", ",");

            }
            dt.Rows.Add(drr);
            return dt;
        }
    }
}
