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

namespace VVPosM1.Screen
{
    public partial class frmRpt_ABC : Form
    {


        private Boolean soAm = true;
        private Boolean thapPhan = true;
        private double a, b, c;
        rptABCBLL abcBLL;
        public frmRpt_ABC()
        {
            InitializeComponent();
            abcBLL = new rptABCBLL();
            txtA1.Text = "";
            SetUIChanges();
        }

        public void SetUIChanges()
        {
            this.Text = Common.clsLanguages.GetResource("ABCAnalysisReport");
            gb_infomation.Text = Common.clsLanguages.GetResource("SelectInformation");
            lb_tylechidinh.Text = Common.clsLanguages.GetResource("RateSpecified");
            lb_fromDate.Text = Common.clsLanguages.GetResource("FromDate");
            lb_toDate.Text = Common.clsLanguages.GetResource("ToDate");
            btn_ViewReport.Text = Common.clsLanguages.GetResource("ViewReport");
            btnReset.Text = Common.clsLanguages.GetResource("Reset");
            btnThoat.Text = Common.clsLanguages.GetResource("Exit");        
            gb_ReportDetail.Text =Common.clsLanguages.GetResource("ReportDetail");
             

            //bntLuu.Text = Common.clsLanguages.GetResource("Save");
            //bntSeach.Text = Common.clsLanguages.GetResource("Search");
            //bntReset.Text = Common.clsLanguages.GetResource("Reset");
            //lbTilte.Text = Common.clsLanguages.GetResource("ManageDesk");
            //lbDesk.Text = Common.clsLanguages.GetResource("Name");
            //lbLocation.Text = Common.clsLanguages.GetResource("Location");
            //lbStatus.Text = Common.clsLanguages.GetResource("Status");
            //lbDescription.Text = Common.clsLanguages.GetResource("Description");
            //lbSeat.Text = Common.clsLanguages.GetResource("NoOfSeat");
            //gShowDesk.Text = Common.clsLanguages.GetResource("DeskList");
            //this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            //this.Status.HeaderText = Common.clsLanguages.GetResource("Status");
            //this.DeskNo.HeaderText = Common.clsLanguages.GetResource("Name");
            //this.Description.HeaderText = Common.clsLanguages.GetResource("Description");
            //this.DeskLocation.HeaderText = Common.clsLanguages.GetResource("Location");
        }

        private void frmRpt_ABC_Load(object sender, EventArgs e)
        {

            this.rptABC.RefreshReport();
           // load_dateTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                //string No = Common.clsLanguages.GetResource("No");
                //string InformationOfProduct = Common.clsLanguages.GetResource("InformationOfProduct");
                //string AvergeUnitPrice = Common.clsLanguages.GetResource("AvergeUnitPrice");
                //string Qty = Common.clsLanguages.GetResource("Qty");
                //string TotalAmount1 = Common.clsLanguages.GetResource("TotalAmount1");
                //string RateAmount = Common.clsLanguages.GetResource("RateAmount");
                //string TotalAccu = Common.clsLanguages.GetResource("TotalAccu");
                //string RateAccu = Common.clsLanguages.GetResource("RateAccu");
                //string Classified = Common.clsLanguages.GetResource("Classified");        

                a = double.Parse(string.IsNullOrEmpty(txtA1.Text) ? "0" : txtA1.Text);
                b = double.Parse(string.IsNullOrEmpty(txtB1.Text) ? "0" : txtB1.Text);
                //a = double.Parse(txtA1.Text);
                //b = double.Parse(txtB1.Text);
                DataTable dt = abcBLL.GetReportSTT(dptTuNgay.Value, dptDenNgay.Value,a, b);
            if(dt!=null){


                //// vị trí report và page nằm ngang
                //System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
                //pg.Landscape = true;
                //rptABC.SetPageSettings(pg);
              //  rptABC.SetDisplayMode(DisplayMode.PrintLayout);
                rptABC.ZoomMode = ZoomMode.PageWidth;
                
                rptABC.LocalReport.DataSources.Clear();             
                rptABC.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.rptABC.rdlc";                
                Microsoft.Reporting.WinForms.ReportDataSource ds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
                rptABC.LocalReport.DataSources.Add(ds);

                //test
               // rptABC.ZoomMode = ZoomMode.FullPage;

                ds.Value = dt;
                //logo
                string templateImage = Common.Utility.GetUrlFromService("ShopImg", "logoprint.png");
                // gán parameters
                ReportParameter[] lstParams = new ReportParameter[16];
                lstParams[0] = new ReportParameter("TCTy", Common.clsLanguages.GetResource("MerchantName"));
                lstParams[1] = new ReportParameter("DCCTy", Common.clsLanguages.GetResource("MerchantAddress"));
                lstParams[2] = new ReportParameter("TieuDe", Common.clsLanguages.GetResource("ABCAnalysisReport"));
                lstParams[3] = new ReportParameter("TimeNow",  Common.clsLanguages.GetResource("GetDateReport")+" "+DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                lstParams[4] = new ReportParameter("TimeTo", Common.clsLanguages.GetResource("FromDate")+" " + dptTuNgay.Value.ToString("dd - MM - yyyy") +" "+ Common.clsLanguages.GetResource("ToDate")+" " + dptDenNgay.Value.ToString("dd - MM - yyyy"));
                lstParams[5] = new ReportParameter("ParamABC",  Common.clsLanguages.GetResource("RateSpecified") +" A= "+txtA1.Text+"%, B= "+txtB1.Text+"%, C= "+(100-a-b)+"%");
                lstParams[6] = new ReportParameter("ImageName", templateImage);

                lstParams[7] = new ReportParameter("No", Common.clsLanguages.GetResource("No"));
                lstParams[8] = new ReportParameter("InformationOfProduct", Common.clsLanguages.GetResource("InformationOfProduct"));
                lstParams[9] = new ReportParameter("AvergeUnitPrice", Common.clsLanguages.GetResource("AvergeUnitPrice"));
                lstParams[10] = new ReportParameter("Qty", Common.clsLanguages.GetResource("Qty"));
                lstParams[11] = new ReportParameter("TotalAmount", Common.clsLanguages.GetResource("TotalAmount1"));
                lstParams[12] = new ReportParameter("RateAmount", Common.clsLanguages.GetResource("RateAmount"));
                lstParams[13] = new ReportParameter("TotalAccu", Common.clsLanguages.GetResource("TotalAccu"));
                lstParams[14] = new ReportParameter("RateAccu", Common.clsLanguages.GetResource("RateAccu"));
                lstParams[15] = new ReportParameter("Classified", Common.clsLanguages.GetResource("Classified"));
              
                rptABC.LocalReport.EnableExternalImages = true;
                this.rptABC.LocalReport.SetParameters(lstParams);
                rptABC.LocalReport.Refresh();
                rptABC.RefreshReport();

            }
            }

            catch(Exception ex){
            
            }
        }

        private void txtA1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(string.IsNullOrEmpty(txtA1.Text) ? "0" : txtA1.Text);
                b = double.Parse(string.IsNullOrEmpty(txtB1.Text) ? "0" : txtB1.Text);
                //if(a+b>100)
                //{
                //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ABC100"),
                //                            Common.clsLanguages.GetResource("Information"),
                //                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //    txtA1.Focus();
                //}
                c = 100 - a - b;
                txtC1.Text = c.ToString();
            }
            catch(Exception ex)
            {

                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ABCNumberA"),
                                          Common.clsLanguages.GetResource("Information"),
                                          Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                          Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtA1.Focus();
            }
        }

        private void txtB1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                double a, b, c;
                a = double.Parse(string.IsNullOrEmpty(txtA1.Text) ? "0" : txtA1.Text);
                b = double.Parse(string.IsNullOrEmpty(txtB1.Text) ? "0" : txtB1.Text);
                //if (a + b > 100)
                //{
                //    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ABC100"),
                //                            Common.clsLanguages.GetResource("Information"),
                //                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //    txtB1.Focus();
                //}
                c = 100 - a - b;
                txtC1.Text = c.ToString();
            }
            catch(Exception ex)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ABCNumberB"),
                                              Common.clsLanguages.GetResource("Information"),
                                              Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                              Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtB1.Focus();
            }
        }

        private void txtA1_KeyDown(object sender, KeyEventArgs e)
        {
            //Common.Utility.MaskDigit_keyDown(e);
        }

        private void txtA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Utility.MaskDecimal(e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Utility.MaskDecimal(e);
        }

        private void txtA1_Validated(object sender, EventArgs e)
        {
            double d;
            if (txtA1.Text == "") {
                txtA1.Text = "0";
            }
                      
            bool isNum = double.TryParse(txtA1.Text, out d);
            if (!isNum)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ABCNumberA"),
                                             Common.clsLanguages.GetResource("Information"),
                                             Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                             Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtA1.Focus();
            }
            else {
                a = double.Parse(string.IsNullOrEmpty(txtA1.Text) ? "0" : txtA1.Text);
                b = double.Parse(string.IsNullOrEmpty(txtB1.Text) ? "0" : txtB1.Text);
                if (a + b > 100)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ABC100"),
                                            Common.clsLanguages.GetResource("Information"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    txtA1.Focus();
                }

                c = 100 - a - b;
                txtC1.Text = c.ToString("0,0.00");
            }

            
        }
    
      
    private void txtB1_Validated(object sender, EventArgs e)
        {
            double d;
            if (txtB1.Text == "")
            {
                txtB1.Text = "0";
            }
            bool isNum = double.TryParse(txtB1.Text, out d);
            if (!isNum)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ABCNumberB"),
                                             Common.clsLanguages.GetResource("Information"),
                                             Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                             Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtB1.Focus();
            }
            else {

                a = double.Parse(string.IsNullOrEmpty(txtA1.Text) ? "0" : txtA1.Text);
                b = double.Parse(string.IsNullOrEmpty(txtB1.Text) ? "0" : txtB1.Text);

                if (a + b > 100)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ABC100"),
                                            Common.clsLanguages.GetResource("Information"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    txtB1.Focus();
                }

                c = 100 - a - b;
                txtC1.Text = c.ToString("0,0.00");
            }
           
        }

    private void btnReset_Click(object sender, EventArgs e)
    {
        txtA1.Text = "";
        txtB1.Text = "";
        txtC1.Text = "";
       // rptABC.RefreshReport();
    }

       

        // load thời gian theo tháng hiện tại
        //private void load_dateTime()
        //{
        //   string month= DateTime.Now.Month.ToString();
        //   dptTuNgay.Value.ToString("01/" + month+ "/"+DateTime.Now.Year.ToString());
        //}



        

    }
}
