using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VVPosM1.BusinessLayer;
using Microsoft.Reporting.WinForms;
using VVPosM1.Entities;


namespace VVPosM1.Screen
{
    public partial class frmRpt_TotalCustomerProductMoth : Form
    {
        private Products pro;
        private ReceiptsBLL receiptBLL;
        public frmRpt_TotalCustomerProductMoth()
        {
            InitializeComponent();
            SetUIChanges();
            receiptBLL = new ReceiptsBLL();
        }

        private void frmRpt_TotalCustomerProductMoth_Load(object sender, EventArgs e)
        {

            this.rptViewTotalCustomer.RefreshReport();
            LoadProduct();
        }

        public void SetUIChanges()
        {
            this.Text = Common.clsLanguages.GetResource("ReportByMonth");
            gb_SelectInformation.Text = Common.clsLanguages.GetResource("SelectInformation");
            btnXemBC.Text = Common.clsLanguages.GetResource("ViewReport");
            btnThoat.Text = Common.clsLanguages.GetResource("Exit");
            gb_ReportDetail.Text = Common.clsLanguages.GetResource("ReportDetail");
            lb_MonthYear.Text = Common.clsLanguages.GetResource("MonthYear");
            chkSanPham.Text = Common.clsLanguages.GetResource("chkProduct");
            chkNhomSanPham.Text = Common.clsLanguages.GetResource("chkProductGroup");
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            try
            {
                pro = new Products();
                string sMon = dptThangNam.Value.Month.ToString();
                string sYea = dptThangNam.Value.Year.ToString();
                string pBeginWorkingDate = dptThangNam.Value.ToString("yyyy-MM-dd");
                string pTuNgayDenNgay = sMon + " - " + sYea;
                // nếu chọn chkbox sản phẩm
                if (chkSanPham.Checked)
                {
                    receiptBLL = new ReceiptsBLL();

                    DataTable dt = receiptBLL.GetProductNoOfCustomersMonthAll(sMon, sYea, cboLoad.SelectedValue.ToString());

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        // vị trí report và page nằm ngang
                        //System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
                        //pg.Landscape = true;                       

                        // rptViewTotalCustomer.ZoomMode = ZoomMode.PageWidth;

                        rptViewTotalCustomer.LocalReport.DataSources.Clear(); //clear report
                        rptViewTotalCustomer.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.rptTotalCustomerProductMoth.rdlc"; // bind reportviewer with .rdlc

                        Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("TotalCustomerMoth", dt); // set the datasource
                        rptViewTotalCustomer.LocalReport.DataSources.Add(dataset);
                        dataset.Value = dt;
                        //logo
                        string templateImage = Common.Utility.GetUrlFromService("ShopImg", "logoprint.png");
                        ReportParameter[] lstParams = new ReportParameter[13];
                        lstParams[0] = new ReportParameter("TCTy", Common.clsLanguages.GetResource("MerchantName"));
                        lstParams[1] = new ReportParameter("DCCTy", Common.clsLanguages.GetResource("MerchantAddress"));
                        lstParams[2] = new ReportParameter("TieuDe", Common.clsLanguages.GetResource("ReportByMonth"));
                        lstParams[3] = new ReportParameter("TimeS", Common.clsLanguages.GetResource("GetDateReport") + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                        lstParams[4] = new ReportParameter("Time", dptThangNam.Value.Month.ToString() + "-" + dptThangNam.Value.Year.ToString());
                        lstParams[5] = new ReportParameter("ImageName", templateImage);
                        lstParams[6] = new ReportParameter("No", Common.clsLanguages.GetResource("No"));
                        lstParams[7] = new ReportParameter("InformationProduct", Common.clsLanguages.GetResource("Information"));
                        lstParams[8] = new ReportParameter("Note", Common.clsLanguages.GetResource("Notes"));
                        lstParams[9] = new ReportParameter("Revennue", Common.clsLanguages.GetResource("Revennue"));
                        lstParams[10] = new ReportParameter("Quantity", Common.clsLanguages.GetResource("TotalCustomer"));
                        lstParams[11] = new ReportParameter("Total", Common.clsLanguages.GetResource("TotalAll"));
                        lstParams[12] = new ReportParameter("Title", Common.clsLanguages.GetResource("Title1"));
                        rptViewTotalCustomer.LocalReport.EnableExternalImages = true;

                        this.rptViewTotalCustomer.LocalReport.SetParameters(lstParams);
                        rptViewTotalCustomer.LocalReport.Refresh();
                        rptViewTotalCustomer.RefreshReport(); // refresh report
                    }
                    else
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DataNull"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    }
                }

                // nếu check nhóm sản phẩm
                if (chkNhomSanPham.Checked)
                {
                    receiptBLL = new ReceiptsBLL();

                    DataTable dt = receiptBLL.GetProductGroupNoOfCustomersMonthAll(sMon, sYea, cboLoad.SelectedValue.ToString());

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        // vị trí report và page nằm ngang
                        //System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
                        //pg.Landscape = true;                       

                        // rptViewTotalCustomer.ZoomMode = ZoomMode.PageWidth;

                        rptViewTotalCustomer.LocalReport.DataSources.Clear(); //clear report
                        rptViewTotalCustomer.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.rptTotalCustomerProductMoth.rdlc"; // bind reportviewer with .rdlc

                        Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("TotalCustomerMoth", dt); // set the datasource
                        rptViewTotalCustomer.LocalReport.DataSources.Add(dataset);
                        dataset.Value = dt;
                        //logo
                        string templateImage = Common.Utility.GetUrlFromService("ShopImg", "logoprint.png");
                        ReportParameter[] lstParams = new ReportParameter[13];
                        lstParams[0] = new ReportParameter("TCTy", Common.clsLanguages.GetResource("MerchantName"));
                        lstParams[1] = new ReportParameter("DCCTy", Common.clsLanguages.GetResource("MerchantAddress"));
                        lstParams[2] = new ReportParameter("TieuDe", Common.clsLanguages.GetResource("ReportByMonth"));
                        lstParams[3] = new ReportParameter("TimeS", Common.clsLanguages.GetResource("GetDateReport") + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                        lstParams[4] = new ReportParameter("Time", dptThangNam.Value.Month.ToString() + "-" + dptThangNam.Value.Year.ToString());
                        lstParams[5] = new ReportParameter("ImageName", templateImage);
                        lstParams[6] = new ReportParameter("No", Common.clsLanguages.GetResource("No"));
                        lstParams[7] = new ReportParameter("InformationProduct", Common.clsLanguages.GetResource("Information"));
                        lstParams[8] = new ReportParameter("Note", Common.clsLanguages.GetResource("Notes"));
                        lstParams[9] = new ReportParameter("Revennue", Common.clsLanguages.GetResource("Revennue"));
                        lstParams[10] = new ReportParameter("Quantity", Common.clsLanguages.GetResource("TotalCustomer"));
                        lstParams[11] = new ReportParameter("Total", Common.clsLanguages.GetResource("TotalAll"));
                        lstParams[12] = new ReportParameter("Title", Common.clsLanguages.GetResource("Title1"));
                        rptViewTotalCustomer.LocalReport.EnableExternalImages = true;

                        this.rptViewTotalCustomer.LocalReport.SetParameters(lstParams);
                        rptViewTotalCustomer.LocalReport.Refresh();
                        rptViewTotalCustomer.RefreshReport(); // refresh report
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

            catch (Exception)
            {

            }
        }

        private DataTable AddTotalRecord(DataTable dt)
        {
            DataRow drr = dt.NewRow();


            drr["ProductId"] = Common.clsLanguages.GetResource("TotalAll");
            drr["TotalCustomer"] = "0";
            drr["Revenue"] = "0";
            for (int i = 1; i <= 31; i++)
            {
                string stt = i.ToString();
                if (stt.Length == 1)
                {
                    stt = "0" + stt;
                }
                drr["DD" + stt + ""] = "0";
                drr["RR" + stt + ""] = "0";
            }

            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 1; i <= 31; i++)
                {
                    string stt = i.ToString();
                    if (stt.Length == 1)
                    {
                        stt = "0" + stt;
                    }
                    if (!string.IsNullOrEmpty(dr["DD" + stt + ""].ToString()))
                    {
                        drr["DD" + stt + ""] = (double.Parse(drr["DD" + stt + ""].ToString()) + double.Parse(dr["DD" + stt + ""].ToString())).ToString("0,0");
                      
                    }
                    if (!string.IsNullOrEmpty(dr["RR" + stt + ""].ToString()))
                    {
                        drr["RR" + stt + ""] = (double.Parse(drr["RR" + stt + ""].ToString()) + double.Parse(dr["RR" + stt + ""].ToString())).ToString("0,0");
                    }
                }
                drr["TotalCustomer"] = (double.Parse(drr["TotalCustomer"].ToString()) + double.Parse(dr["TotalCustomer"].ToString())).ToString("0,0");
                drr["Revenue"] = (double.Parse(drr["Revenue"].ToString()) + double.Parse(dr["Revenue"].ToString())).ToString("0,0");
            }

            dt.Rows.Add(drr);
            return dt;
        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {
            //this.gb_ReportDetail.Height = this.Height - 180;
        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_change(object sender, EventArgs e)
        {
            if (chkSanPham.Checked)
            {

                chkNhomSanPham.Checked = false;
                LoadProduct();
            }
            else if (!chkSanPham.Checked)
            {
                chkNhomSanPham.Checked = true;
                LoadGroupProduct();
            }
       
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

        private void chk_changeGroup(object sender, EventArgs e)
        {
            if (chkNhomSanPham.Checked)
            {
                chkSanPham.Checked = false;
                LoadGroupProduct();
            }
            else if (!chkNhomSanPham.Checked)
            {
                chkSanPham.Checked = true;
                LoadProduct();
            }
           
        }
    }
}
