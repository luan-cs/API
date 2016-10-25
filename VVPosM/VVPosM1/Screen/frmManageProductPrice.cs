using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using VVPosM1.Entities;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosM1.BusinessLayer;
using System.Configuration;
using VVPosM1.Controls;
using VVPosM1.Common;
namespace VVPosM1.Screen
{
    public partial class frmManageProductPrice : Form
    {
        // bien  toan cuc trong form nay
        private ProductPrice proPrice;
        private ProductPriceBLL proPriceBLL;
        private ProductPrice proPriceSea;
        // bien page
        private Boolean _bAllowInsert = false;
        private int CurPage;
        private double totalPage;

        public frmManageProductPrice()
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
            //lblTitle.Text = Common.clsLanguages.GetResource("ProductPrice");
            lblProduct.Text = Common.clsLanguages.GetResource("InformationOfProduct");
            lblPrice.Text = Common.clsLanguages.GetResource("ProductPrice");

            btnSearch10.Text = Common.clsLanguages.GetResource("Search");
            btnReset10.Text = Common.clsLanguages.GetResource("Reset");
            btnExit10.Text = Common.clsLanguages.GetResource("Exit");
            btnSave10.Text = Common.clsLanguages.GetResource("Save");
            btnExcel10.Text = Common.clsLanguages.GetResource("ExportExcelFile");
            // datagridview
            groupBox1.Text = Common.clsLanguages.GetResource("List");

            this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            this.ProductCode.HeaderText = Common.clsLanguages.GetResource("ProductID");
            this.ProductName.HeaderText = Common.clsLanguages.GetResource("ProductName");
            this.Time.HeaderText = Common.clsLanguages.GetResource("TimeOfUpdate");
            this.Price.HeaderText = Common.clsLanguages.GetResource("ProductPrice");
            this.Creator.HeaderText = Common.clsLanguages.GetResource("CreateBy");
            this.Delete.HeaderText = Common.clsLanguages.GetResource("Delete");

        }

        private void frmManageProductPrice_Load(object sender, EventArgs e)
        {
            proPrice = new ProductPrice();
            proPriceSea = new ProductPrice();
            LoadProduct();
        }
        private void LoadProduct()
        {
            this.txtProduct10.Text = string.Empty;

            // Add some sample auto complete entry items...
            proPriceBLL = new ProductPriceBLL();
            List<Products> lst = proPriceBLL.ReadListFromAutoComplete(this.txtProduct10.Text);
            if (lst != null)
            {
                foreach (Products ob in lst)
                {
                    /*string str = ob.ProductId + "," + ob.Name;
                    this.txtProduct10.Items.Add(new AutoCompleteEntry(str, ob.Name));*/
                }
            }
            this.Validate();
        }

         //private void btnExcel_Click(object sender, EventArgs e)
         //{
         //    XuatExcel();
         //}
         private void XuatExcel()
         {
             DataTable Final = new DataTable();
             int total = 0;
             Final = proPriceBLL.SearchProductPrice(proPriceSea, 1, out total);
             double RecordPerPage = 20;
             double tem = (total / RecordPerPage);
             totalPage = Math.Ceiling(tem);

             for (int i = 2; i <= totalPage; i++) // duyet tat ca cac trang
             {
                 DataTable dt = proPriceBLL.SearchProductPrice(proPriceSea, i, out total);
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

             string[] prm = { "3" };
             ExportExcelAlgorithms epex = new ExportExcelAlgorithms();

             epex.ExportFileFromDataTable_Dung(Final, "Product Price_" + DateTime.Now.ToString("ddMMyy_HHmmss"),
                 "List of " + "Product Price_" + DateTime.Now.ToString("ddMMyy_HHmmss"), prm);
         }

         //private void bntExit_Click(object sender, EventArgs e)
         //{
         //    this.Close();
         //}

         //private void bntReset_Click(object sender, EventArgs e)
         //{
         //    Reset();
         //}
         private void Reset()
         {
             foreach (Control c in this.pInput10.Controls)
             {
                 if (c is TextBox)
                 {
                     ((TextBox)c).Text = String.Empty;
                 }
                 if (c is RichTextBox)
                 {
                     ((RichTextBox)c).Text = String.Empty;
                 }
                 if (c is ComboBox)
                 {
                     ((ComboBox)c).SelectedIndex = 0;
                 }
                 if (c is CheckBox)
                 {
                     ((CheckBox)c).Checked = false;
                 }
                 lblMaProduct10.Text = "";
                 txtProduct10.Text = "";
                 lblTB10.Text = "...";
                 lblUpdate10.Text = "...";
                 dgv.Rows.Clear();

             }


         }

         //private void bntSeach_Click(object sender, EventArgs e)
         //{
         //    CurPage = 1;
         //    totalPage = 1;
         //    SearchProductPrice(1);
         //}
         private void SearchProductPrice(int page)
         {
             CurPage = page;
             int total = 0;
             DataTable dt = proPriceBLL.SearchProductPrice(proPriceSea, page, out total);

             double RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
             int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
             double tem = (total / RecordPerPage);
             totalPage = Math.Ceiling(tem);

             dgv.Rows.Clear();
             if (dt != null && dt.Rows.Count > 0)
             {
                 int i = 0;
                 int stt = (page - 1) * RecPerPage;
                 foreach (DataRow dr in dt.Rows)
                 {
                    
                     dgv.Rows.Add();
                     dgv.Rows[i].Cells[0].Value = (stt + 1).ToString();
                     dgv.Rows[i].Cells[1].Value = dr["ProductId"].ToString();
                     DataTable dtP = proPriceBLL.GetNameTheoProductID(dr["ProductId"].ToString());
                     if (dtP != null && dtP.Rows.Count > 0)
                     {
                         dgv.Rows[i].Cells[2].Value = dtP.Rows[0]["Name"].ToString();
                     }
                     else
                     {
                         dgv.Rows[i].Cells[2].Value = "";
                     }
                     DateTime dt1 = DateTime.Parse(dr["ModifiedDate"].ToString());
                     dgv.Rows[i].Cells[3].Value = dt1.ToString("yyyy-MM-dd HH:mm:ss");
                     dgv.Rows[i].Cells[4].Value = string.Format("{0:###,###,###.##}", dr["Price"]);

                     dgv.Rows[i].Cells[5].Value = dr["ModifiedBy"].ToString();

                     i++;
                     stt++;

                 }
             }
             linkLabel10.Text = CurPage.ToString() + "/" + totalPage.ToString();
             lblTB10.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
         }


         public Employees employSea { get; set; }

         //private void bntLuu_Click(object sender, EventArgs e)
         //{
         //    SaveData();

         //   proPriceSea.ProductId = lblMaDT.Text;
         //   proPriceSea.Price = txtPrice.Text;
         //    int total = 0;
         //    proPriceBLL.SearchProductPrice(proPriceSea, 1, out total);
         //}
         private void SaveData()
         {
             txtProduct_Validated1();
            if (!_bAllowInsert)
            {              
                txtProduct10.Focus();
                return;
            }

             proPriceSea.ProductId = lblMaProduct10.Text;
             proPriceSea.Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
             proPriceSea.Price = txtPrice10.Text;
            

            int i = proPriceBLL.Insert(proPriceSea);
            if (i == 1)
            {
                lblUpdate10.Text = Common.clsLanguages.GetResource("InsertSuccess1");
                lblMaProduct10.Text = proPriceSea.ProductId;
                proPriceBLL.UpdatePriceInProduct(proPriceSea);
            }
            else
            {
                lblUpdate10.Text = Common.clsLanguages.GetResource("InsertNoSuccess1");
            }

             SearchProductPrice(1);
         }

         private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
         {
              if (e.RowIndex >= 0)
            {
                string productID = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                string time =dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                ProductPrice proPrice = proPriceBLL.GetProPriceWithID(productID);
                if (proPrice != null)
                {
                    txtProduct10.Text = proPrice.ProductId + "," + proPrice.ProductName;
                   // txtPrice10.Text = string.Format("{0:0,0}", proPrice.Price);                  
                    lblMaProduct10.Text = proPrice.ProductId;                  

                //// Xóa
                if (e.ColumnIndex == 6)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("KhoaNv"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        int Xoa = proPriceBLL.DeleteNV(productID,time);
                        if (Xoa == 1) // xóa thành côg
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("KhoaTCong"),
                                           Common.clsLanguages.GetResource("Information"),
                                           Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                           Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                            dgv.Rows.RemoveAt(e.RowIndex);
                            foreach (Control c in this.pInput10.Controls)
                            {
                                if (c is TextBox)
                                {
                                    ((TextBox)c).Text = String.Empty;
                                }
                                if (c is RichTextBox)
                                {
                                    ((RichTextBox)c).Text = String.Empty;
                                }
                                if (c is ComboBox)
                                {
                                    ((ComboBox)c).SelectedIndex = 0;
                                }
                                if (c is CheckBox)
                                {
                                    ((CheckBox)c).Checked = false;
                                }
                                lblMaProduct10.Text = "";
                                txtProduct10.Text = "";
                                lblTB10.Text = "...";
                                lblUpdate10.Text = "...";
                            }
                            DanhLaiSTT();
                        }
                    }
                  }
                 }
              }
         }
         private void DanhLaiSTT()
         {
             for (int i = 0; i < dgv.Rows.Count; i++)
             {
                 dgv.Rows[i].Cells[0].Value = (i + 1).ToString();
             }
         }

         private void btnSearch10_Click(object sender, EventArgs e)
         {
             CurPage = 1;
             totalPage = 1;
             proPriceSea = new ProductPrice();

             //if (!string.IsNullOrEmpty(lblMaProduct10.Text))
             //{
             proPriceSea.ProductId = lblMaProduct10.Text;
             //}

             proPriceSea.Price = txtPrice10.Text;
             SearchProductPrice(1);
         }

         private bool Kiemtra()
         {
             if (txtProduct10.Text == "")
             {
                 CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("TTProductEmpty"),
                                      Common.clsLanguages.GetResource("Information"),
                                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                 txtProduct10.Focus();
                 return false;
             }
             if (txtPrice10.Text == "")
             {
                 CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("EmptyPrice"),
                                      Common.clsLanguages.GetResource("Information"),
                                      Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                      Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                 txtProduct10.Focus();
                 return false;
             }
             return true;
         }
         private void btnSave10_Click(object sender, EventArgs e)
         {
             if (!Kiemtra()) return;
             if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CommonCodeCreate"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
             {
                 SaveData();

                 proPriceSea.ProductId = lblMaProduct10.Text;
                 proPriceSea.Price = txtPrice10.Text.Replace(".","");
                 int total = 0;
                 proPriceBLL.SearchProductPrice(proPriceSea, 1, out total);
             }
         }

         private void btnReset10_Click(object sender, EventArgs e)
         {
             Reset();
         }

         private void btnExit10_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void btnExcel10_Click(object sender, EventArgs e)
         {
             XuatExcel();
         }

         private void btnPre10_Click(object sender, EventArgs e)
         {
             if (CurPage > 1)
             {
                 SearchProductPrice(CurPage - 1);
             }
         }

         private void btnNext10_Click(object sender, EventArgs e)
         {
             if (CurPage < totalPage)
             {
                 SearchProductPrice(CurPage + 1);
             }
         }

         private void txtProduct_Validated(object sender, EventArgs e)
         {

             string str = txtProduct10.Text;
             if (string.IsNullOrEmpty(str))
                 return;
             if (!string.IsNullOrEmpty(str) && str.Length >= 12)
             {
                 int i = str.IndexOf(",");
                 if (i < 0)
                 {
                     i = 12;
                 }
                 lblMaProduct10.Text = str.Substring(0, i);
                 //List<Products> lst = proPriceBLL.ReadListFromAutoComplete(str.Substring(0, i));
                 //if (lst == null)
                 //{
                 //    MessageBox.Show("Nhập lại thông tin sản phẩm!");
                 //    txtProduct10.Focus();
                 //    _bAllowInsert = false;
                 //    return;
                 //}
                 //else
                 //    _bAllowInsert = true;
             }
             else
             {
                 MessageBox.Show(Common.clsLanguages.GetResource("ObjectInfoIncorrect"));
                 txtProduct10.Focus();
                 _bAllowInsert = false;
                 return;
             }
         }

         private void txtProduct_Validated1()
         {
             string str = txtProduct10.Text;
             if (!string.IsNullOrEmpty(str) && str.Length >= 12)
             {
                 int i = str.IndexOf(",");
                 if (i < 0)
                 {
                     i = 12;
                 }
                 lblMaProduct10.Text = str.Substring(0, i);
                 List<Products> lst = proPriceBLL.ReadListFromAutoComplete(str.Substring(0, i));
                 
                 if (lst == null)
                 {
                     MessageBox.Show(Common.clsLanguages.GetResource("ObjectInfoIncorrect"));
                     txtProduct10.Focus();
                     _bAllowInsert = false;
                     return;
                 }
                 else
                     _bAllowInsert = true;
             }
             else
             {
                 MessageBox.Show(Common.clsLanguages.GetResource("ObjectInfoIncorrect"));
                 txtProduct10.Focus();
                 _bAllowInsert = false;
                 return;
             }
         }

         private void txtPrice10_KeyPress(object sender, KeyPressEventArgs e)
         {
             Common.Utility.MaskDecimal1(e);
         }

         private void txtPrice10_TextChanged(object sender, EventArgs e)
         {
             if (txtPrice10.Text != "")
             {
                 if (txtPrice10.Text.Length < int.Parse(ConfigurationManager.AppSettings["MaxPrice"]))
                 {

                     double _dblprice = double.Parse(txtPrice10.Text);
                     txtPrice10.Text = _dblprice.ToString("###,###,##0");
                     txtPrice10.SelectionStart = txtPrice10.Text.Length;
                 }
                 else {
                     CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("TheValueOfTheUnitPriceIsTooBig"),
                                        Common.clsLanguages.GetResource("Error"),
                                        Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                        Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                     txtPrice10.Text = txtPrice10.Text.Substring(0, txtPrice10.Text.Length - 1);
                     txtPrice10.SelectionStart = txtPrice10.Text.Length;
                 }
             }
         }

         

    }
}
