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
    public partial class frmManageIngreadient : Form
    {
        // bien  toan cuc trong form nay
        private IngredientBLL supBLL;
        private Ingreadient supSea, sup;
        // 
        private int CurPage;
        private double totalPage;

        public frmManageIngreadient()
        {
            InitializeComponent();
            sup = new Ingreadient();
            supSea = new Ingreadient();
            SettingControl();
            SetUIChanges();
        }

        private void SettingControl()
        {
            //this.BackgroundImage = Utility.GetImageFromService("ShopImg", "bg12.png");
        }

        public void SetUIChanges()
        {
            
            this.Text = "Quản lý Nguyên Liêu";
            ////lblSupplierId.Text = "Mã";
            ////lblName.Text = Common.clsLanguages.GetResource("ProductName1");
            ////lblAddress.Text = Common.clsLanguages.GetResource("Address");
            //lblExchange.Text = Common.clsLanguages.GetResource("Email");
            //lbMeasure.Text = Common.clsLanguages.GetResource("Phone");
            //lblUnit.Text = Common.clsLanguages.GetResource("Website");

            //bntSeach.Text = Common.clsLanguages.GetResource("Search");
            //bntLuu.Text = Common.clsLanguages.GetResource("Save");
            //bntReset.Text = Common.clsLanguages.GetResource("Reset");
            //btnExcel.Text = Common.clsLanguages.GetResource("ExportExcelFile");
            //bntExit.Text = Common.clsLanguages.GetResource("Exit");
            //// datagridview
            //groupBox1.Text = Common.clsLanguages.GetResource("List");

            //this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            ////this.SupplierId.HeaderText = Common.clsLanguages.GetResource("ProductID");
            ////this.SupplierName.HeaderText = Common.clsLanguages.GetResource("ProductName");
            //this.Address.HeaderText = Common.clsLanguages.GetResource("Address");
            //this.Phone.HeaderText = Common.clsLanguages.GetResource("Phone");
            //this.Email.HeaderText = Common.clsLanguages.GetResource("Email");
            //this.Website.HeaderText = Common.clsLanguages.GetResource("Website");
            //this.Delete.HeaderText = Common.clsLanguages.GetResource("Delete");

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
            Final = supBLL.SearchIngredient(supSea, 1, out total);
            double RecordPerPage = 20;
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            for (int i = 2; i <= totalPage; i++) // duyet tat ca cac trang
            {
                DataTable dt = supBLL.SearchIngredient(supSea, i, out total);
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

            epex.ExportFileFromDataTable_Dung(Final, "Ingreadient_" + DateTime.Now.ToString("ddMMyy_HHmmss"),
                "List of " + "Suppliers_" + DateTime.Now.ToString("ddMMyy_HHmmss"), prm);
        }

        private void frmManageProduct_Load(object sender, EventArgs e)
        {
            // khởi tạo các đối tượng 
            supBLL = new IngredientBLL();

        }

        private void bntSeach_Click(object sender, EventArgs e)
        {
            CurPage = 1;
            totalPage = 1;
            supSea = new Ingreadient();
            supSea.IngredientId = txtlIngredientd.Text;
            supSea.IngredientName = txtName.Text;
            //supSea.SupplierAddress = txtAddress.Text;
            supSea.IngredientMeasure = txtMeasure.Text;
            supSea.IngredientExchange = txtExchange.Text;
            supSea.IngredientUnit = txtUnit.Text;
            
            SearchProducts(1);
        }

        private void SearchProducts(int page)
        {
            CurPage = page;

            int total = 0;
            DataTable dt = supBLL.SearchIngredient(supSea, page, out total);
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
                    dgv.Rows[i].Cells[1].Value = dr["IngredientId"].ToString();
                    dgv.Rows[i].Cells[2].Value = dr["IngredientName"].ToString();
                    dgv.Rows[i].Cells[3].Value = string.Format("{0} ({1})", dr["IngredientMeasure"].ToString(), dr["IntakeUnit"].ToString());

                    dgv.Rows[i].Cells[4].Value = string.Format("{0} ({1})", dr["IngredientExchange"].ToString(), dr["IngredientUnit"].ToString());
                    dgv.Rows[i].Cells[5].Value = dr["IngredientUnit"].ToString();
                    dgv.Rows[i].Cells[6].Value = dr["IntakeUnit"].ToString();

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
            if (txtMeasure.Text == "0" || txtMeasure.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng nhập số lượng",
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtMeasure.Focus();
                txtMeasure.Text = "0";
                return false;
            }
            else {
                int parsedValue;
                if (!int.TryParse(txtMeasure.Text, out parsedValue))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui Lòng chỉ nhập số",
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    txtMeasure.Focus();
                    txtMeasure.Text = "0";
                    return false;
                }
            }
            if (txtExchange.Text == "0" || txtExchange.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng nhập số lượng quy đổi",
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtExchange.Focus();
                txtExchange.Text = "0";
                return false;
            }
            else {
                int parsedValue;
                if (!int.TryParse(txtExchange.Text, out parsedValue))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui Lòng chỉ nhập số",
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    txtExchange.Focus();
                    txtExchange.Text = "0";
                    return false;
                }
            }
            if (txtUnit.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NameNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtUnit.Focus();
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
            string SupplierID = txtlIngredientd.Text.Trim();
            Ingreadient pro = new Ingreadient();
            pro = supBLL.GetIngredientWithID(SupplierID);

            supSea = new Ingreadient();

            supSea.IngredientName = txtName.Text;
            //supSea.SupplierAddress = txtAddress.Text;
            supSea.IngredientMeasure = txtMeasure.Text;
            supSea.IngredientExchange = txtExchange.Text;
            supSea.IngredientUnit = txtUnit.Text;
            supSea.IntakeUnit = txtDonviGoc.Text;


            if (pro != null)
            {// Cập nhật
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CommonCodeUpdate"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                {
                    supSea.IngredientId = SupplierID;
                    int i = supBLL.UpdateIngredient(supSea);
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
                    supSea.IngredientId = SupplierID;

                    int i = supBLL.InsertIngredient(supSea);
                    if (i == 1)
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("InsertSuccess1"); 
                        txtlIngredientd.Text = SupplierID;
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
                Ingreadient ob = supBLL.GetIngredientWithID(productID);
                if (ob != null)
                {
                    txtlIngredientd.Text = ob.IngredientId;
                    txtName.Text = ob.IngredientName;
                    txtExchange.Text = ob.IngredientExchange;
                    //txtAddress.Text = ob.SupplierAddress;
                    txtUnit.Text = ob.IngredientUnit;
                    txtMeasure.Text = ob.IngredientMeasure;
                    txtDonviGoc.Text = ob.IntakeUnit;
                }

                //// Xóa
                if (e.ColumnIndex == 6)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("KhoaNv"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        int Xoa = supBLL.DeleteIngredient(productID);
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
            //Common.Utility.TextLengthValid(txtAddress, 128);
        }

        #endregion

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtMeasure, 26);
            Common.Utility.TextFormatNumber(txtMeasure, ConfigurationManager.AppSettings["TextFormatNum"]);
        }
    }
}
