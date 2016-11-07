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
    public partial class frmManageSupplier : Form
    {
        // bien  toan cuc trong form nay
        private SupplierBLL supBLL;
        private Supplier supSea, sup;
        // 
        private int CurPage;
        private double totalPage;

        public frmManageSupplier()
        {
            InitializeComponent();
            sup = new Supplier();
            supSea = new Supplier();
            SettingControl();
            SetUIChanges();
        }

        private void SettingControl()
        {
            //this.BackgroundImage = Utility.GetImageFromService("ShopImg", "bg12.png");
        }

        public void SetUIChanges()
        {
            
            this.Text = "Quản lý nhà cung cấp";
            //lblSupplierId.Text = "Mã";
            //lblName.Text = Common.clsLanguages.GetResource("ProductName1");
            lblAddress.Text = Common.clsLanguages.GetResource("Address");
            lblEmail.Text = Common.clsLanguages.GetResource("Email");
            lbPhone.Text = Common.clsLanguages.GetResource("Phone");
            lblWWebsite.Text = Common.clsLanguages.GetResource("Website");

            bntSeach.Text = Common.clsLanguages.GetResource("Search");
            bntLuu.Text = Common.clsLanguages.GetResource("Save");
            bntReset.Text = Common.clsLanguages.GetResource("Reset");
            btnExcel.Text = Common.clsLanguages.GetResource("ExportExcelFile");
            bntExit.Text = Common.clsLanguages.GetResource("Exit");
            // datagridview
            groupBox1.Text = Common.clsLanguages.GetResource("List");

            this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            //this.SupplierId.HeaderText = Common.clsLanguages.GetResource("ProductID");
            //this.SupplierName.HeaderText = Common.clsLanguages.GetResource("ProductName");
            this.Address.HeaderText = Common.clsLanguages.GetResource("Address");
            this.Phone.HeaderText = Common.clsLanguages.GetResource("Phone");
            this.Email.HeaderText = Common.clsLanguages.GetResource("Email");
            this.Website.HeaderText = Common.clsLanguages.GetResource("Website");
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
            if (dgv.Rows.Count > 0)
            {
                XuatExcel();
            }
        }

        private void XuatExcel()
        {
            DataTable Final = new DataTable();
            int total = 0;
            Final = supBLL.SearchSupplier(supSea, 1, out total);
            double RecordPerPage = 20;
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            for (int i = 2; i <= totalPage; i++) // duyet tat ca cac trang
            {
                DataTable dt = supBLL.SearchSupplier(supSea, i, out total);
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

            //epex.ExportFileFromDataTable(Final, "Products_" + supBLL.GetDMY() + "_" + supBLL.GetHMS());

            string[] prm = { "3" };
            ExportExcelAlgorithms epex = new ExportExcelAlgorithms();

            epex.ExportFileFromDataTable_Dung(Final, "Suppliers_" + DateTime.Now.ToString("ddMMyy_HHmmss"),
                "List of " + "Suppliers_" + DateTime.Now.ToString("ddMMyy_HHmmss"), prm);
        }

        private void frmManageProduct_Load(object sender, EventArgs e)
        {
            // khởi tạo các đối tượng 
            supBLL = new SupplierBLL();

        }

        private void bntSeach_Click(object sender, EventArgs e)
        {
            CurPage = 1;
            totalPage = 1;
            supSea = new Supplier();
            supSea.SupplierId = txtSupplierId.Text;
            supSea.SupplierName = txtName.Text;
            supSea.SupplierAddress = txtAddress.Text;
            supSea.SupplierPhone = txtPhone.Text;
            supSea.SupplierWebsite = txtSite.Text;
            
            SearchProducts(1);
        }

        private void SearchProducts(int page)
        {
            CurPage = page;

            int total = 0;
            DataTable dt = supBLL.SearchSupplier(supSea, page, out total);
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
                    dgv.Rows[i].Cells[1].Value = dr["SupplierId"].ToString();
                    dgv.Rows[i].Cells[2].Value = dr["SupplierName"].ToString();
                    dgv.Rows[i].Cells[3].Value = dr["SupplierAddress"].ToString();
                    
                    dgv.Rows[i].Cells[4].Value = dr["SupplierPhone"].ToString();
                    dgv.Rows[i].Cells[5].Value = dr["SupplierEmail"].ToString();

                    dgv.Rows[i].Cells[6].Value = dr["SupplierWebsite"].ToString();

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
            string SupplierID = txtSupplierId.Text.Trim();
            Supplier pro = new Supplier();
            pro = supBLL.GetSupplierWithID(SupplierID);

            supSea = new Supplier();

            supSea.SupplierName = txtName.Text;
            supSea.SupplierAddress = txtAddress.Text;
            supSea.SupplierPhone = txtPhone.Text;
            supSea.SupplierEmail = txtEmail.Text;
            supSea.SupplierWebsite = txtSite.Text;


            if (pro != null)
            {// Cập nhật
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CommonCodeUpdate"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                {
                    supSea.SupplierId = SupplierID;
                    int i = supBLL.Update(supSea);
                    if (i == 1)
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("UpdateSuccess1");
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
                    SupplierID = supBLL.CreateSupplierId();
                    supSea.SupplierId = SupplierID;

                    int i = supBLL.Insert(supSea);
                    if (i == 1)
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("InsertSuccess1"); 
                        txtSupplierId.Text = SupplierID;
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string productID = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                Supplier ob = supBLL.GetSupplierWithID(productID);
                if (ob != null)
                {
                    txtSupplierId.Text = ob.SupplierId;
                    txtName.Text = ob.SupplierName;
                    txtEmail.Text = ob.SupplierEmail;
                    txtAddress.Text = ob.SupplierAddress;
                    txtSite.Text = ob.SupplierWebsite;
                    txtPhone.Text = ob.SupplierPhone;
                    
                }

                //// Xóa
                if (e.ColumnIndex == 7)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("KhoaNv"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        int Xoa = supBLL.Delete(productID);
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
            Common.Utility.TextLengthValid(txtAddress, 128);
        }

        #endregion

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtPhone, 26);
            Common.Utility.TextFormatNumber(txtPhone, ConfigurationManager.AppSettings["TextFormatNum"]);
        }
    }
}
