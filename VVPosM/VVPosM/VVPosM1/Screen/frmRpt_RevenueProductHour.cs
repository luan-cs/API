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
using VVPosM1.Entities;

namespace VVPosM1.Screen
{
   
    public partial class frmRpt_RevenueProductHour : Form
    {
        private Products pro;
        private ReceiptsBLL receiptBLL;
        public frmRpt_RevenueProductHour()
        {
            
            InitializeComponent();
            SetUIChanges();
            receiptBLL = new ReceiptsBLL();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmRpt_RevenueSevicesHour_Load(object sender, EventArgs e)
        {

            this.rptViewHour.RefreshReport();
            LoadProduct();
        }
        public void SetUIChanges()
        {
            this.Text = Common.clsLanguages.GetResource("ReportByHour");
            gb_SelectInformation.Text = Common.clsLanguages.GetResource("SelectInformation");
            lb_FromDate.Text = Common.clsLanguages.GetResource("FromDate");
            lb_ToDate.Text = Common.clsLanguages.GetResource("ToDate");
            btn_ReportView.Text = Common.clsLanguages.GetResource("ViewReport");
            btnThoat.Text = Common.clsLanguages.GetResource("Exit");
            gb_ReportDetail.Text = Common.clsLanguages.GetResource("ReportDetail");
            chkSanPham.Text = Common.clsLanguages.GetResource("chkProduct");
            chkNhomSanPham.Text = Common.clsLanguages.GetResource("chkProductGroup");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            { pro= new Products();

                // nếu chọn chkbox sản phẩm
                if (chkSanPham.Checked)
                {
                    string pTuNgayDenNgay = Common.clsLanguages.GetResource("FromDate")+" "+ dptTuNgay.Value.ToString("yyyy-MM-dd") + "  "+Common.clsLanguages.GetResource("ToDate")+" "+ dptToiNgay.Value.ToString("yyyy-MM-dd");
                    string pBeginWorkingDate = dptTuNgay.Value.ToString("yyyy-MM-dd");
                    string pEndWorkingDate = dptToiNgay.Value.ToString("yyyy-MM-dd");
                    DataTable dt = new DataTable();               
                    dt = receiptBLL.GetProductRPHourAllProduct_Aeon(dptTuNgay.Value, dptToiNgay.Value,cboLoad.SelectedValue.ToString());
                    //dt = AddTotalRecord(dt);

                    if (dt != null && dt.Rows.Count > 0)
                    {

                        //rptViewHour. = true;
                        // vị trí report và page nằm ngang
                       // System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
                        //pg.Landscape = true;
                         //rptViewHour.SetPageSettings(pg);
                        // rptViewHour.SetDisplayMode(DisplayMode.PrintLayout);
                        //rptViewTotalCustomer.ZoomMode = ZoomMode.FullPage;
                        // rptViewHour.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                        //rptViewTotalCustomer.ZoomPercent = 50;

                        rptViewHour.LocalReport.DataSources.Clear(); //clear report
                        rptViewHour.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.rptRevenueSercesHour.rdlc"; // bind reportviewer with .rdlc

                        Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt); // set the datasource
                        rptViewHour.LocalReport.DataSources.Add(dataset);
                        dataset.Value = dt;
                        //logo
                        string templateImage = Common.Utility.GetUrlFromService("ShopImg", "logoprint.png");
                        ReportParameter[] lstParams = new ReportParameter[12];
                        lstParams[0] = new ReportParameter("TCTy", Common.clsLanguages.GetResource("MerchantName"));
                        lstParams[1] = new ReportParameter("DCCTy", Common.clsLanguages.GetResource("MerchantAddress"));
                        lstParams[2] = new ReportParameter("TieuDe", Common.clsLanguages.GetResource("ReportByHour"));
                        lstParams[3] = new ReportParameter("TimeS", Common.clsLanguages.GetResource("GetDateReport") + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                        lstParams[4] = new ReportParameter("Time", Common.clsLanguages.GetResource("FromDate") + " " + dptTuNgay.Value.ToString("dd/MM/yyyy") + " " + Common.clsLanguages.GetResource("ToDate") + " " + dptToiNgay.Value.ToString("dd/MM/yyyy"));
                        lstParams[5] = new ReportParameter("ImageName", templateImage);
                        lstParams[6] = new ReportParameter("No", Common.clsLanguages.GetResource("No"));
                        lstParams[7] = new ReportParameter("Information", Common.clsLanguages.GetResource("Information"));
                        lstParams[8] = new ReportParameter("Note", Common.clsLanguages.GetResource("Notes"));
                        lstParams[9] = new ReportParameter("Revennue", Common.clsLanguages.GetResource("Revennue"));
                        lstParams[10] = new ReportParameter("OrderQuantity", Common.clsLanguages.GetResource("Orders"));
                        lstParams[11] = new ReportParameter("Total", Common.clsLanguages.GetResource("TotalAll"));
                        //lstParams[12] = new ReportParameter("Title", Common.clsLanguages.GetResource("Title1"));
                       

                        rptViewHour.LocalReport.EnableExternalImages = true;
                        this.rptViewHour.LocalReport.SetParameters(lstParams);
                        rptViewHour.LocalReport.Refresh();
                        rptViewHour.RefreshReport(); // refresh report
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
                if (chkNhomSanPham.Checked)
                {
                    string pTuNgayDenNgay = Common.clsLanguages.GetResource("FromDate") + " " + dptTuNgay.Value.ToString("yyyy-MM-dd") + "  " + Common.clsLanguages.GetResource("ToDate") + " " + dptToiNgay.Value.ToString("yyyy-MM-dd");
                    string pBeginWorkingDate = dptTuNgay.Value.ToString("yyyy-MM-dd");
                    string pEndWorkingDate = dptToiNgay.Value.ToString("yyyy-MM-dd");
                    DataTable dt = new DataTable();

                    dt = receiptBLL.GetGroupProductRPHourAllProduct_Aeon(dptTuNgay.Value, dptToiNgay.Value, cboLoad.SelectedValue.ToString());
                    //dt = AddTotalRecord(dt);

                    if (dt != null && dt.Rows.Count>0)
                    {
                        // vị trí report và page nằm ngang
                        System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
                        pg.Landscape = true;
                        rptViewHour.SetPageSettings(pg);
                        // rptViewTotalCustomer.SetDisplayMode(DisplayMode.PrintLayout);
                        //rptViewTotalCustomer.ZoomMode = ZoomMode.FullPage;
                        rptViewHour.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                        //rptViewTotalCustomer.ZoomPercent = 50;

                        rptViewHour.LocalReport.DataSources.Clear(); //clear report
                        rptViewHour.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.rptRevenueSercesHour.rdlc"; // bind reportviewer with .rdlc

                        Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt); // set the datasource
                        rptViewHour.LocalReport.DataSources.Add(dataset);
                        dataset.Value = dt;
                        //logo
                        string templateImage = Common.Utility.GetUrlFromService("ShopImg", "logoprint.png");
                        ReportParameter[] lstParams = new ReportParameter[12];
                        lstParams[0] = new ReportParameter("TCTy", Common.clsLanguages.GetResource("MerchantName"));
                        lstParams[1] = new ReportParameter("DCCTy", Common.clsLanguages.GetResource("MerchantAddress"));
                        lstParams[2] = new ReportParameter("TieuDe", Common.clsLanguages.GetResource("ReportByHour"));
                        lstParams[3] = new ReportParameter("TimeS", Common.clsLanguages.GetResource("GetDateReport") + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                        lstParams[4] = new ReportParameter("Time", Common.clsLanguages.GetResource("FromDate") + " " + dptTuNgay.Value.ToString("dd/MM/yyyy") + " " + Common.clsLanguages.GetResource("ToDate") + " " + dptToiNgay.Value.ToString("dd/MM/yyyy"));
                        lstParams[5] = new ReportParameter("ImageName", templateImage);
                        lstParams[6] = new ReportParameter("No", Common.clsLanguages.GetResource("No"));
                        lstParams[7] = new ReportParameter("Information", Common.clsLanguages.GetResource("Information"));
                        lstParams[8] = new ReportParameter("Note", Common.clsLanguages.GetResource("Notes"));
                        lstParams[9] = new ReportParameter("Revennue", Common.clsLanguages.GetResource("Revennue"));
                        lstParams[10] = new ReportParameter("OrderQuantity", Common.clsLanguages.GetResource("Orders"));
                        lstParams[11] = new ReportParameter("Total", Common.clsLanguages.GetResource("TotalAll"));
                        //lstParams[12] = new ReportParameter("Title", Common.clsLanguages.GetResource("Title2"));
                        rptViewHour.LocalReport.EnableExternalImages = true;


                        this.rptViewHour.LocalReport.SetParameters(lstParams);
                        rptViewHour.LocalReport.Refresh();
                        rptViewHour.RefreshReport(); // refresh report
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

        private DataTable AddTotalRecord(DataTable dt)
        {
            DataRow drr = dt.NewRow();

            drr["ProductId"] = Common.clsLanguages.GetResource("TotalAll");
            drr["Revenue"] = "0";
            drr["Name"] = "";
            drr["TotalCustomer"] = "0";
            for (int i = 8; i < 24; i++)
            {
                string stt = i.ToString();
                if (stt.Length == 1)
                {
                    stt = "0" + stt;
                }
                drr["HH" + stt + "_Total_Sales"] = "0";
                drr["HH" + stt + "_Total_Times"] = "0";
            }

            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 8; i < 24; i++)
                {
                    string stt = i.ToString();
                    if (stt.Length == 1)
                    {
                        stt = "0" + stt;
                    }
                    drr["HH" + stt + "_Total_Sales"] = (double.Parse(drr["HH" + stt + "_Total_Sales"].ToString()) + double.Parse(dr["HH" + stt + "_Total_Sales"].ToString())).ToString("0,0");
                    //string a1 = string.Format("{0:0,0}", (double.Parse(drr["HH" + stt + "_Total_Sales"].ToString()) + double.Parse(dr["HH" + stt + "_Total_Sales"].ToString())));
                    //drr["HH" + stt + "_Total_Sales"] = a1.Replace(".", ",");

                   drr["HH" + stt + "_Total_Times"] = (double.Parse(drr["HH" + stt + "_Total_Times"].ToString()) + double.Parse(dr["HH" + stt + "_Total_Times"].ToString())).ToString("0,0");
                    //string a2 = string.Format("{0:0,0}", (double.Parse(drr["HH" + stt + "_Total_Times"].ToString()) + double.Parse(dr["HH" + stt + "_Total_Times"].ToString())));
                    //drr["HH" + stt + "_Total_Times"] = a2.Replace(".", ",");
                
                }
                  drr["TotalCustomer"] = (double.Parse(drr["TotalCustomer"].ToString()) + double.Parse(dr["TotalCustomer"].ToString())).ToString("0,0");
                    //string a3 = string.Format("{0:0,0}", (double.Parse(drr["TotalCustomer"].ToString()) + double.Parse(dr["TotalCustomer"].ToString())));
                    //drr["TotalCustomer"] = a3.Replace(".", ",");

                   drr["Revenue"] = (double.Parse(drr["Revenue"].ToString()) + double.Parse(dr["Revenue"].ToString())).ToString("0,0");
                    //string a4 = string.Format("{0:0,0}", (double.Parse(drr["Revenue"].ToString()) + double.Parse(dr["Revenue"].ToString())));
                    //drr["Revenue"] = a4.Replace(".", ",");

            }

            dt.Rows.Add(drr);
            return dt;
        }

        private void chk_change(object sender, EventArgs e)
        {
            if (chkSanPham.Checked)
            {

                chkNhomSanPham.Checked = false;
                LoadProduct();
            }
            else if (!chkSanPham.Checked) {
                chkNhomSanPham.Checked = true;
                LoadGroupProduct();
            }
        //if(chkNhomSanPham.Checked)
        //    {
        //        chkSanPham.Checked = false;
        //    }
       
        }

        private void chk_changeGroup(object sender, EventArgs e)
        {
            if (chkNhomSanPham.Checked)
            {
                chkSanPham.Checked = false;
                LoadGroupProduct();
            }
            else if (!chkNhomSanPham.Checked) {
                chkSanPham.Checked = true;
                LoadProduct();
            }
            //if (chkSanPham.Checked)
            //    {
            //        chkNhomSanPham.Checked = false;
            //    }
           
            
        }
      
       
        // load product
        private void LoadProduct()
        {

            DataTable dt = receiptBLL.GetProduct();
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
            DataTable dt = receiptBLL.GetProductType();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
      
    }
}
