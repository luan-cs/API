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
using VVPosM1.Entities;
using VVPosM1.Common;
using System.Configuration;

namespace VVPosM1.Screen
{
    public partial class frmManageProduct : Form
    {
        // bien  toan cuc trong form nay
        private Products pro;
        private ProductsBLL proBLL;
        private Products proSea;
        // 
        private int CurPage;
        private double totalPage;

        public frmManageProduct()
        {
            InitializeComponent();
            pro = new Products();
            proSea = new Products();
            SettingControl();
            SetUIChanges();
        }

        private void SettingControl()
        {
            //this.BackgroundImage = Utility.GetImageFromService("ShopImg", "bg12.png");
        }

        public void SetUIChanges()
        {
           // lblTitle.Text = Common.clsLanguages.GetResource("Product");
            lblProductId.Text = Common.clsLanguages.GetResource("ProductId");
            lblName.Text = Common.clsLanguages.GetResource("ProductName1");
            //lblUnit.Text = Common.clsLanguages.GetResource("Units");
            //lblImage.Text = Common.clsLanguages.GetResource("Image");
            lbPrice.Text = Common.clsLanguages.GetResource("Price");
            //lblNotes.Text = Common.clsLanguages.GetResource("Description2");
            lblProductType.Text = Common.clsLanguages.GetResource("ProductType");

            //button7.Text = Common.clsLanguages.GetResource("SelectImage");
            bntSeach.Text = Common.clsLanguages.GetResource("Search");
            bntLuu.Text = Common.clsLanguages.GetResource("Save");
            bntReset.Text = Common.clsLanguages.GetResource("Reset");
            btnExcel.Text = Common.clsLanguages.GetResource("ExportExcelFile");
            bntExit.Text = Common.clsLanguages.GetResource("Exit");
            // datagridview
            groupBox1.Text = Common.clsLanguages.GetResource("List");

            this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            this.ProductId.HeaderText = Common.clsLanguages.GetResource("ProductID");
            this.ProductName.HeaderText = Common.clsLanguages.GetResource("ProductName");
            //this.Notes.HeaderText = Common.clsLanguages.GetResource("Notes");
            //this.Unit.HeaderText = Common.clsLanguages.GetResource("Units");
            this.colPrice.HeaderText = Common.clsLanguages.GetResource("Price");
            this.ProductType.HeaderText = Common.clsLanguages.GetResource("ProductType");
            //this.Info.HeaderText = Common.clsLanguages.GetResource("InfoInitiated");
            this.Delete.HeaderText = Common.clsLanguages.GetResource("Delete");

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            foreach (Control c in this.pInput.Controls)
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
                dgv.Rows.Clear();
                lblTB1.Text = "...";
                lblTB.Text = "...";

            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            XuatExcel();
        }

        private void XuatExcel()
        {
            DataTable Final = new DataTable();
            int total = 0;
            Final = proBLL.SearchProducts(proSea, 1, out total);
            double RecordPerPage = 20;
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            for (int i = 2; i <= totalPage; i++) // duyet tat ca cac trang
            {
                DataTable dt = proBLL.SearchProducts(proSea, i, out total);
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

            //ExportExcelAlgorithms epex = new ExportExcelAlgorithms();

            //epex.ExportFileFromDataTable(Final, "Products_" + proBLL.GetDMY() + "_" + proBLL.GetHMS());

            string[] prm = { "3" };
            ExportExcelAlgorithms epex = new ExportExcelAlgorithms();

            epex.ExportFileFromDataTable_Dung(Final, "Products_" + DateTime.Now.ToString("ddMMyy_HHmmss"),
                "List of " + "Products_" + DateTime.Now.ToString("ddMMyy_HHmmss"), prm);
        }

        private void frmManageProduct_Load(object sender, EventArgs e)
        {
            // khởi tạo các đối tượng 
            proBLL = new ProductsBLL();

            // load tat ca cac bien tham so lua chon..
            LoadProductType();

        }
        private void LoadProductType()
        {

            DataTable dt = proBLL.GetProductType();
            cboProductType.DataSource =dt;
            cboProductType.DisplayMember = "ProductGroupName";
            cboProductType.ValueMember = "ProductGroupId";

        }

        private void bntSeach_Click(object sender, EventArgs e)
        {
            CurPage = 1;
            totalPage = 1;
            proSea = new Products();
            proSea.ProductId = txtProductId.Text;
            proSea.ProductName = txtName.Text;
            //proSea.Unit = txtUnit.Text;
            //proSea.Notes = rtxtDescription.Text;
            proSea.ProductGroupId = cboProductType.SelectedValue.ToString();
            
            SearchProducts(1);
        }

        private void SearchProducts(int page)
        {
            CurPage = page;
           
            

            int total = 0;
            DataTable dt = proBLL.SearchProducts(proSea, page, out total);
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
                    dgv.Rows[i].Cells[2].Value = dr["ProductName"].ToString();
                    dgv.Rows[i].Cells[3].Value = string.Format("{0:0,0}", dr["Price"]);
                    
                    
                    string str = "";
                    DataTable dtP1 = proBLL.GetProductTypeId(dr["ProductGroupId"].ToString());
                    if (dtP1 != null && dtP1.Rows.Count > 0)
                    {

                        str =  dtP1.Rows[0]["ProductGroupName"].ToString() + "\n";
                        dgv.Rows[i].Cells[4].Value = str;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[4].Value = "";
                    }

                    i++;
                    stt++;
                }
            }
            linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
            lblTB.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
        }
        private bool Kiemtra()
        {
            if (txtName.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NameNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtName.Focus();
                return false;
            }
            if (cboProductType.SelectedIndex == -1)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ProductTypeNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtName.Focus();
                return false;
            }
            return true;
        }
        private void bntLuu_Click(object sender, EventArgs e)
        {
            if (!Kiemtra()) return;
            SaveData();
        }
        private void SaveData()
        {
            // check xem có trong db chưa?
            string ProductID = txtProductId.Text.Trim();
            Products pro = new Products();
            pro = proBLL.GetProductWithID(ProductID);

             proSea = new Products();

            proSea.ProductName = txtName.Text;
            proSea.Price = txtPrice.Text;
            //proSea.Notes = rtxtDescription.Text;
            proSea.ProductGroupId = cboProductType.SelectedValue.ToString();


            if (pro != null)
            {// Cập nhật
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CommonCodeUpdate"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                {
                    proSea.ProductId = ProductID;
                    int i = proBLL.Update(proSea);
                    if (i == 1)
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("UpdateSuccess1");
                        //proSea.Image = pro.Image;
                    }
                    else
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("UpdateNoSuccess1");
                    }
                }
            }
            else
            {// Thêm mới
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CommonCodeCreate"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                {
                    ProductID = proBLL.Tao_ProductID();
                    proSea.ProductId = ProductID;

                    int i = proBLL.Insert(proSea);
                    if (i == 1)
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("InsertSuccess1"); 
                        txtProductId.Text = ProductID;
                        //proSea.Image = null;
                    }
                    else
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("InsertNoSuccess1");
                    }
                }
            }


            SearchProducts(1);


        }
       

        private void bntPre_Click(object sender, EventArgs e)
        {

            if (CurPage > 1)
            {
                SearchProducts(CurPage - 1);
            }
        }

        private void bntNext_Click(object sender, EventArgs e)
        {
            if (CurPage < totalPage)
            {
                SearchProducts(CurPage + 1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string safeFilePath = ofd.SafeFileName;
                //txtImage.Text = filePath;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string productID = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                Products ob = proBLL.GetProductWithID(productID);
                if (ob != null)
                {
                    txtProductId.Text = ob.ProductId;
                    txtName.Text = ob.ProductName;
                    //txtImage.Text = ob.Image;
                    //txtUnit.Text = ob.Unit;
                    //rtxtDescription.Text = ob.Notes;
                    txtPrice.Text = ob.Price == "" ? "" : double.Parse(ob.Price).ToString("0,0");
                    
                    /*if (!string.IsNullOrEmpty(ob.ProductType))
                    {
                        //check trong cbo                        
                        //cboProductType.SelectedIndex = 0; ? làm động tác này để làm gì? Vãi các thần !!!!!
                        foreach (var item in cboProductType.Items)
                        {
                            KeyValuePair<string, string> itm = (KeyValuePair<string, string>)item;
                            if (itm.Key == ob.ProductType)
                            {
                                cboProductType.SelectedValue = ob.ProductType;
                                break;
                            }
                        }
                    }*/
                   
                
                    // load hinh tu web
                    //pbImgProduct.SizeMode = PictureBoxSizeMode.Zoom;
                    //bImgProduct.Image = VVPosM1.Common.Utility.GetImageFromService("Products", ob.Image);

                }

                //// Xóa
                if (e.ColumnIndex == 5)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("KhoaNv"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        int Xoa = proBLL.Delete(productID);
                        if (Xoa == 1) // xóa thành côg
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("KhoaTCong"),
                                            Common.clsLanguages.GetResource("Information"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                            dgv.Rows.RemoveAt(e.RowIndex);
                            foreach (Control c in this.pInput.Controls)
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
                                lblTB1.Text = "...";
                                lblTB.Text = "...";

                            }
                            DanhLaiSTT();
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

        #region TextBox Events

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtName, 512);
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            //Common.Utility.TextLengthValid(txtUnit, 128);
        }

        #endregion
    }
}
