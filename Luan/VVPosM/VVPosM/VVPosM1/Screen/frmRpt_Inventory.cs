using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosM1.BusinessLayer;

namespace VVPosM1.Screen
{
    public partial class frmRpt_Inventory : Form
    {
        private IngredientBLL ingredientBLL;
        private InventoryBLL inventoryResource;
        public frmRpt_Inventory()
        {
            InitializeComponent();

            //Load nguyen lieu
            ingredientBLL = new IngredientBLL();
            DataTable dt = ingredientBLL.GetIngredients();
            //Thêm option chọn tất cả
            DataRow allIgre = dt.NewRow();
            allIgre["IngredientName"] = "Tất cả";
            allIgre["IngredientId"] = "0";
            dt.Rows.Add(allIgre);

            cbNguyenLieu.DisplayMember = "IngredientName";
            cbNguyenLieu.ValueMember = "IngredientId";
            cbNguyenLieu.DataSource = dt;
            cbNguyenLieu.SelectedIndex = cbNguyenLieu.Items.Count - 1;

            inventoryResource = new InventoryBLL();
        }

        private void frmRpt_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void btn_ViewReport_Click(object sender, EventArgs e)
        {
            DataTable resource;
            if (cbNguyenLieu.SelectedValue.Equals("0"))
            {
                resource = inventoryResource.GetAll();
            }
            else
            {
                resource = inventoryResource.GetById(cbNguyenLieu.SelectedValue.ToString());
            }
            if (resource.Rows.Count > 0)
            {
                try
                {
                    rptViewInventory.LocalReport.DataSources.Clear();
                    rptViewInventory.ZoomMode = ZoomMode.PageWidth;
                    rptViewInventory.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.rptInventory.rdlc";

                    Microsoft.Reporting.WinForms.ReportDataSource ds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", resource);

                    rptViewInventory.LocalReport.DataSources.Add(ds);

                    ds.Value = resource;

                    string templateImage = Common.Utility.GetUrlFromService("ShopImg", "logoprint.png");
                    ReportParameter[] lstParams = new ReportParameter[2];
                    lstParams[0] = new ReportParameter("TieuDe", Common.clsLanguages.GetResource("MerchantName"));
                    lstParams[1] = new ReportParameter("ImageName", templateImage);

                    rptViewInventory.LocalReport.EnableExternalImages = true;
                    this.rptViewInventory.LocalReport.SetParameters(lstParams);
                    rptViewInventory.LocalReport.Refresh();
                    rptViewInventory.RefreshReport();
                }
                catch
                {

                }
            }
            else
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("DataNull"),
                              Common.clsLanguages.GetResource("Information"),
                              Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                              Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
