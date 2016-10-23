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
    public partial class frmRpt_ProductPrice : Form
    {
        rptProductPriceBLL objBLL;

        public frmRpt_ProductPrice()
        {
            InitializeComponent();
            SetUIChanges();
            objBLL = new rptProductPriceBLL();
        }

        private void frmRpt_ProductPrice_Load(object sender, EventArgs e)
        {
            LoadProductPrice();
            this.rptViewer.RefreshReport();
            
        }

        public void SetUIChanges()
        {
            this.Text = Common.clsLanguages.GetResource("TitleReportRevennueOfEmployee");
            lb_ReportPrice.Text = Common.clsLanguages.GetResource("ReportOfProduct");
            btn_ReportView.Text = Common.clsLanguages.GetResource("ViewReport");
            btnThoat.Text = Common.clsLanguages.GetResource("Exit");
          
        }


        public void LoadProductPrice()
        {
            DataTable dt = objBLL.GetProduct();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", "Chọn tất cả");
            foreach (DataRow dr in dt.Rows)
            {
                test.Add(dr["ProductId"].ToString(), dr["Name"].ToString());
            }
            cboProduct.DataSource = new BindingSource(test, null);
            cboProduct.DisplayMember = "Value";
            cboProduct.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strID = cboProduct.SelectedValue.ToString();
                //if(!string.IsNullOrEmpty(strID))
                //{
                    DataTable dt = objBLL.GetReportSTT(strID);
                    if ( dt.Rows.Count > 0)
                    {
                        rptViewer.LocalReport.DataSources.Clear();
                        rptViewer.ZoomMode = ZoomMode.PageWidth;
                        rptViewer.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.rptProductPrice.rdlc";
                        
                        Microsoft.Reporting.WinForms.ReportDataSource ds = new Microsoft.Reporting.WinForms.ReportDataSource("rptProductPrice", dt);

                        rptViewer.LocalReport.DataSources.Add(ds);

                        ds.Value = dt;

                        //logo
                        string templateImage = Common.Utility.GetUrlFromService("ShopImg", "logoprint.png");
                        // gán parameters
                        ReportParameter[] lstParams = new ReportParameter[12];
                        lstParams[0] = new ReportParameter("TenCty", Common.clsLanguages.GetResource("MerchantName"));
                        lstParams[1] = new ReportParameter("DCCty", Common.clsLanguages.GetResource("MerchantAddress"));
                        lstParams[2] = new ReportParameter("TieuDe", Common.clsLanguages.GetResource("TitleReportRevennueOfEmployee"));
                        lstParams[3] = new ReportParameter("Time", Common.clsLanguages.GetResource("GetDateReport") + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                        lstParams[4] = new ReportParameter("ImageName", templateImage);
                        lstParams[5] = new ReportParameter("No", Common.clsLanguages.GetResource("No"));
                        lstParams[6] = new ReportParameter("ProductId", Common.clsLanguages.GetResource("ProductID"));
                        lstParams[7] = new ReportParameter("ProductName", Common.clsLanguages.GetResource("ProductName"));
                        lstParams[8] = new ReportParameter("Unit", Common.clsLanguages.GetResource("Unit"));
                        lstParams[9] = new ReportParameter("Price", Common.clsLanguages.GetResource("Price"));
                        lstParams[10] = new ReportParameter("TimeOfUpdate", Common.clsLanguages.GetResource("TimeOfUpdate"));
                        lstParams[11] = new ReportParameter("CreatedBy", Common.clsLanguages.GetResource("CreateBy"));
                      
                     
                        rptViewer.LocalReport.EnableExternalImages = true;
                        this.rptViewer.LocalReport.SetParameters(lstParams);
                        rptViewer.LocalReport.Refresh();
                        rptViewer.RefreshReport();
                    }
                    else {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("GiaSP_01"),
                              Common.clsLanguages.GetResource("Information"),
                              Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                              Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        //if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("MerchantName"),
                        //      Common.clsLanguages.GetResource("Information"),
                        //      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                        //      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                        //{
                        //    //xu ly o day
                        //}
                        //else return;
                    }
                }
            //}
            catch (Exception ex)
            {

            }
        }

        private void frmRpt_ProductPrice_Resize(object sender, EventArgs e)
        {
            this.rptViewer.Height = this.Height - 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
