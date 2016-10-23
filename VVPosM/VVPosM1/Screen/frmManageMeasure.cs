using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosM1.BusinessLayer;
using VVPosM1.Entities;

namespace VVPosM1.Screen
{
    public partial class frmManageMeasure : Form
    {
        private MeasureBLL measureBLL;
        private int CurPage;
        private double totalPage;
        private Measure measure;
        private Measure measureSea;
        public frmManageMeasure()
        {
            InitializeComponent();
        }

        private void frmManageMeasure_Load(object sender, EventArgs e)
        {
            measureBLL = new MeasureBLL();
            measure = new Measure();
            measureSea = new Measure();
            // Load products
            LoadProducts();
        }

        public void LoadProducts()
        {
            DataTable dt = new DataTable();
            dt = measureBLL.getProducts();
            if (dt != null)
            {
                cboProduct.DisplayMember = "ProductName";
                cboProduct.ValueMember = "ProductId";
                cboProduct.DataSource = dt;
            }
        }

        private void bntSeach_Click(object sender, EventArgs e)
        {
            CurPage = 1;
            totalPage = 1;
            measureSea = new Measure();
            measureSea.MeasureId = txtMeasureId.Text;
            measureSea.ProductId = cboProduct.SelectedValue.ToString();
            measureSea.MeasureNote = rtbNote.Text;
            SearchMeasures(1);
        }

        private void SearchMeasures(int page)
        {
            CurPage = page;
            int total = 0;
            Measure obj = new Measure();
            obj.ProductId = cboProduct.SelectedValue.ToString();
            obj.MeasureId = txtMeasureId.Text;
            obj.MeasureNote = rtbNote.Text;
            DataTable dt = measureBLL.SearchProducts(obj, page, out total);
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
                    dgv.Rows[i].Cells[1].Value = dr["MeasureId"].ToString();
                    dgv.Rows[i].Cells[2].Value = dr["ProductName"].ToString();
                    dgv.Rows[i].Cells[3].Value = dr["CreatedDate"].ToString();
                    i++;
                    stt++;
                }
            }
            linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
            lblTB.Text = Common.clsLanguages.GetResource("Found") + " " + total.ToString() + " " + Common.clsLanguages.GetResource("Records");
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDetails(string measureId)
        {
            dgvDetail.Rows.Clear();
            DataTable dt = measureBLL.GetDetails(measureId);

            if (dt != null && dt.Rows.Count != 0)
            {
                dgvDetail.Rows.Clear();
                if (dt != null && dt.Rows.Count > 0)
                {
                    int i = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvDetail.Rows.Add();
                        dgvDetail.Rows[i].Cells[0].Value = (i + 1).ToString();
                        dgvDetail.Rows[i].Cells[1].Value = dr["IngredientId"].ToString();
                        dgvDetail.Rows[i].Cells[2].Value = dr["IngredientName"].ToString();
                        dgvDetail.Rows[i].Cells[3].Value = dr["MeasureQty"].ToString();
                        dgvDetail.Rows[i].Cells[4].Value = dr["IngredientUnit"].ToString();
                        i++;
                    }
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string measureId = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                Measure ob = measureBLL.GetMeasureWithID(measureId);
                if (ob != null)
                {
                    txtMeasureId.Text = ob.MeasureId;
                    rtbNote.Text = ob.MeasureNote;
                    cboProduct.SelectedValue = ob.ProductId;
                    // get detail
                    LoadDetails(measureId);
                }

                //// Xóa
                if (e.ColumnIndex == 4)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox("Bạn có chắc muốn xóa định lượng này",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        int Xoa = measureBLL.Delete(measureId);
                        if (Xoa == 1) // xóa thành côg
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox("Xóa Thành Công",
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
        private bool Kiemtra()
        {
            if (cboProduct.SelectedIndex == -1)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng chọn sản phẩm để định lượng.",
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //txtName.Focus();
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
            string measureId = txtMeasureId.Text.Trim();
            Measure measure = new Measure();
            measure = measureBLL.GetMeasureWithID(measureId);

            measureSea = new Measure();

            measureSea.MeasureId = txtMeasureId.Text;
            measureSea.ProductId = cboProduct.SelectedValue.ToString();
            measureSea.MeasureNote = rtbNote.Text;


            if (measure != null)
            {// Cập nhật
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CommonCodeUpdate"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                {
                    int i = measureBLL.Update(measureSea);
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
                    measureId = measureBLL.Tao_ProductID();
                    measureSea.MeasureId = measureId;

                    int i = measureBLL.Insert(measureSea);
                    if (i == 1)
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("InsertSuccess1");
                        txtMeasureId.Text = measureId;
                        //proSea.Image = null;
                    }
                    else
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("InsertNoSuccess1");
                    }
                }
            }


            SearchMeasures(1);


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
            Final = measureBLL.SearchProducts(measureSea, 1, out total);
            double RecordPerPage = 20;
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            for (int i = 2; i <= totalPage; i++) // duyet tat ca cac trang
            {
                DataTable dt = measureBLL.SearchProducts(measureSea, i, out total);
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
            Common.ExportExcelAlgorithms epex = new Common.ExportExcelAlgorithms();

            epex.ExportFileFromDataTable_Dung(Final, "Measures_" + DateTime.Now.ToString("ddMMyy_HHmmss"),
                "List of " + "Measures_" + DateTime.Now.ToString("ddMMyy_HHmmss"), prm);
        }

        private void btnAddMeasure_Click(object sender, EventArgs e)
        {
            frmAddMeasure frm = new frmAddMeasure();
            frm.measureId = txtMeasureId.Text;
            frm.productName = cboProduct.Text;
            frm.productId = cboProduct.SelectedValue.ToString();
            frm.ShowDialog();
            LoadDetails(txtMeasureId.Text);
        }
    }
}
