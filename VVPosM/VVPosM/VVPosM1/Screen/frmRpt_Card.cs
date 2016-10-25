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
    public partial class frmRpt_Card : Form
    {
        private string month_, year_, fromday, today, title, ReportName, msg, _sUser = "";
        
        private ReceiptsBLL receiptBLL;
        public frmRpt_Card()
        {
            InitializeComponent();
            //Setting control
            SettingControl();
            //Set UI
            SetUIChanges();
            //To Upper
            //
            txtThang.Value = decimal.Parse(DateTime.Now.Month.ToString());
            txtNam.Value = decimal.Parse(DateTime.Now.Year.ToString());

        }


        private void frmRpt_Card_Load(object sender, EventArgs e)
        {

            this.rpt.RefreshReport();
        }
        private void SettingControl()
        {

        }

        public void SetUIChanges()
        {
            this.rdThang.Text = Common.clsLanguages.GetResource("Month");
            this.rdNgay.Text = Common.clsLanguages.GetResource("FromDate");
            this.lbTodate.Text = Common.clsLanguages.GetResource("ToDate");
            this.btnBaoCao.Text = Common.clsLanguages.GetResource("ViewReport");
            this.btnThoat.Text = Common.clsLanguages.GetResource("Exit");
            this.lbSoHoaDon.Text = Common.clsLanguages.GetResource("VisaCardId");
        }


        private void btnBaoCao_Click(object sender, EventArgs e)
        {
              
            /*
             * -------------------------------Get date-----------------------------------*
             */
            if (rdThang.Checked)
            {
                month_ = txtThang.Value.ToString();
                year_ = txtNam.Value.ToString();
                fromday = "";
                today = "";
                if(Common.clsLanguages.StrCulture == "ja-JP")
                    title = "(" + txtThang.Value.ToString().PadLeft(2, '0') + " " + Common.clsLanguages.GetResource("Month") + " " + txtNam.Value.ToString() + " " + Common.clsLanguages.GetResource("Year") + ")";
                else title = "(" + Common.clsLanguages.GetResource("Month") + " " + txtThang.Value.ToString().PadLeft(2, '0') + " " + Common.clsLanguages.GetResource("Year") + " " + txtNam.Value.ToString() + ")";
            }
            else
            {
                month_ = "";
                year_ = "";
                fromday = txtTungay.Value.ToString("yyyy-MM-dd");
                today = txtDenngay.Value.ToString("yyyy-MM-dd");
                //if (Common.clsLanguages.StrCulture == "ja-JP")
                //    title = (txtTungay.Value == txtDenngay.Value) ? txtTungay.Text.Substring(0, 10) + Common.clsLanguages.GetResource("Day") : "(" + Common.clsLanguages.GetResource("FromDate") + " " + txtTungay.Text.Substring(0, 10) + " " + Common.clsLanguages.GetResource("ToDate") + " " + txtDenngay.Text.Substring(0, 10) + ")";
                title = (fromday == today) ? Common.clsLanguages.GetResource("Day") + ": " + txtTungay.Text.Substring(0, 10) : "(" + Common.clsLanguages.GetResource("FromDate") + " " + txtTungay.Text.Substring(0, 10) + " " + Common.clsLanguages.GetResource("ToDate") + " " + txtDenngay.Text.Substring(0, 10) + ")";
            }
            List<Receipts> lst_rc = new List<Receipts>();
            receiptBLL = new ReceiptsBLL();
            lst_rc = receiptBLL.GetQtyCardBank(fromday, today, month_, year_, txtSoHoaDon.Text);
            if (lst_rc == null)
            {
                //NothingDate
                //CustomMessageBox.MessageBox.ShowCustomMessageBox("Không có số liệu !",
                //Common.clsLanguages.GetResource("Information"),
                //Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NothingDate"),
                                         Common.clsLanguages.GetResource("Information"),
                                         Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                         Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
            else
            {
                try
                {
                    rpt.LocalReport.DataSources.Clear();
                    rpt.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.dsQtyCardBank.rdlc";

                    Microsoft.Reporting.WinForms.ReportDataSource ds = new Microsoft.Reporting.WinForms.ReportDataSource("dsQtyCardBank", lst_rc);
                        ds.Value = lst_rc;
                    rpt.LocalReport.DataSources.Add(ds);
                    string templateImage = Common.Utility.GetUrlFromService("ShopImg", "logoprint.png"); //"http://localhost:7979/Image/ShopImg/logoprint.png";


                    // gán parameters
                    //ReportParameter[] lstParams = new ReportParameter[13];
                    ReportParameter[] lstParams;

                    lstParams = new ReportParameter[16];
                    lstParams[0] = new ReportParameter("TenCTy", Common.clsLanguages.GetResource("MerchantName"));
                    lstParams[1] = new ReportParameter("DCCty", Common.clsLanguages.GetResource("MerchantAddress"));
                    lstParams[2] = new ReportParameter("TieuDe", Common.clsLanguages.GetResource("TracsitionReport"));//TracsitionReport

                    lstParams[3] = new ReportParameter("Time1", title);
                    string s = Common.clsLanguages.GetResource("ReportDate") + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                    lstParams[4] = new ReportParameter("Time", s);

                    lstParams[5] = new ReportParameter("ReceiptId", Common.clsLanguages.GetResource("OrderCode"));
                    lstParams[6] = new ReportParameter("CardNo", Common.clsLanguages.GetResource("CardId"));//CardId
                    lstParams[7] = new ReportParameter("CardType", Common.clsLanguages.GetResource("CardType"));
                    lstParams[8] = new ReportParameter("Bank", Common.clsLanguages.GetResource("Banks"));//Banks
                    lstParams[9] = new ReportParameter("TotalAmount", Common.clsLanguages.GetResource("TotalAmount"));

                    lstParams[10] = new ReportParameter("Total", Common.clsLanguages.GetResource("TotalAll"));

                    lstParams[11] = new ReportParameter("ImageName", templateImage);

                    lstParams[12] = new ReportParameter("CreatedDate", Common.clsLanguages.GetResource("CreateDate"));
                    lstParams[13] = new ReportParameter("CreatedBy", Common.clsLanguages.GetResource("CreateBy"));
                    lstParams[14] = new ReportParameter("NO", Common.clsLanguages.GetResource("No"));//Quantity
                    lstParams[15] = new ReportParameter("Qty", Common.clsLanguages.GetResource("Quantity"));

                    rpt.LocalReport.EnableExternalImages = true;
                    this.rpt.LocalReport.SetParameters(lstParams);
                    this.rpt.RefreshReport();
                    rpt.LocalReport.Refresh();
                    rpt.Refresh();

                    this.WindowState = FormWindowState.Normal;
                    this.StartPosition = FormStartPosition.CenterScreen;
                    this.TopMost = true;
                   // this.ShowDialog(this.Parent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
