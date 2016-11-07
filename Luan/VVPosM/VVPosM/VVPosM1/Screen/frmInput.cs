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
    public partial class frmInput : Form
    {
        private InputBLL inputBLL;
        private ObjectBLL objectBLL;
        private int CurPage;
        private double totalPage;
        private Input inputObj;
        private Input inputObjSea;
        public frmInput()
        {
            InitializeComponent();
        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            inputBLL = new InputBLL();
            objectBLL = new ObjectBLL();
            inputObj = new Input();
            inputObjSea = new Input();
            // Load data for supplier
            LoadSuppliers();

        }

        private void LoadSuppliers()
        {
            DataTable dt = new DataTable();

            dt = objectBLL.GetSupplier();
            if (dt != null && dt.Rows.Count != 0)
            {
                //dr["CommonId"].ToString(), dr["StrValue1"].ToString()
                cbSupplier.DataSource = dt;
                cbSupplier.DisplayMember = "FullName";
                cbSupplier.ValueMember = "ObjectId";
            }
        }

        private void bntSeach_Click(object sender, EventArgs e)
        {
            CurPage = 1;
            totalPage = 1;
            inputObjSea = new Input();
            inputObjSea.InputId = txtInputId.Text;
            inputObjSea.Ballot = txtBollot.Text;
            inputObjSea.BallotDate = dtpBallotDate.Text;
            inputObjSea.ReceiptId = txtReceiptId.Text;
            inputObjSea.ReceiptDate = dtpReceiptDate.Text;
            inputObjSea.SupplierId = cbSupplier.SelectedValue?.ToString();
            inputObjSea.StoreId = "1";
            inputObjSea.Paid = (chbPaid.Checked) ? "1" : "0";
            inputObjSea.InputDiscount = txtDiscount.Text;
            inputObjSea.InputNote = rtbNote.Text;
            inputObjSea.InputVat = txtVat.Text;
            inputObjSea.CreatedBy = Program.Username;

            SearchInputs(1);
        }

        private void SearchInputs(int page)
        {
            CurPage = page;
            int total = 0;
            Input obj = new Input();
            obj.InputId = txtInputId.Text;
            obj.Ballot = txtBollot.Text;
            obj.BallotDate = dtpBallotDate.Text;
            obj.ReceiptId = txtReceiptId.Text;
            obj.ReceiptDate = dtpReceiptDate.Text;
            obj.SupplierId = cbSupplier.SelectedValue?.ToString();
            obj.StoreId = "1";
            obj.Paid = (chbPaid.Checked) ? "1" : "0";
            obj.InputDiscount = txtDiscount.Text;
            obj.InputNote = rtbNote.Text;
            obj.InputVat = txtVat.Text;
            DataTable dt = inputBLL.SearchInputs(obj, page, out total);
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
                    dgv.Rows[i].Cells[1].Value = dr["InputId"].ToString();
                    dgv.Rows[i].Cells[2].Value = dr["Ballot"].ToString();
                    dgv.Rows[i].Cells[3].Value = dr["ReceiptId"].ToString();

                    dgv.Rows[i].Cells[4].Value = dr["Paid"].ToString();
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

        private bool Kiemtra()
        {
            if (txtBollot.Text.Trim() == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng nhập mã chứng từ.",
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtBollot.Focus();
                return false;
            }
            if (txtReceiptId.Text.Trim() == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng nhập mã chứng từ.",
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtReceiptId.Focus();
                return false;
            }
            DateTime ballotDate = new DateTime();
            if (DateTime.TryParse(dtpBallotDate.Text, out ballotDate) && ballotDate > DateTime.Now)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Ngày xuất chứng từ không thể lớn hơn ngày hiện tại.",
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //txtBollot.Focus();
                return false;
            }
            DateTime receiptDate = new DateTime();
            if (DateTime.TryParse(dtpReceiptDate.Text, out receiptDate) && receiptDate > DateTime.Now)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Ngày lập hóa đơn không thể lớn hơn ngày hiện tại.",
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                //txtBollot.Focus();
                return false;
            }
            if (txtDiscount.Text.Trim() != "")
            {
                int parsedValue;
                if (!int.TryParse(txtDiscount.Text, out parsedValue))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng chỉ nhập số.",
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return false;
                }
            }
            if (txtVat.Text.Trim() != "")
            {
                int parsedValue;
                if (!int.TryParse(txtVat.Text, out parsedValue))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng chỉ nhập số.",
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    return false;
                }
            }

            if (cbSupplier.SelectedIndex == -1)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Vui lòng chọn nhà cung cấp.",
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
            string inputId = txtInputId.Text.Trim();
            Input input = new Input();
            input = inputBLL.GetInputWithID(inputId);

            inputObjSea = new Input();

            inputObjSea.InputId = txtInputId.Text;
            inputObjSea.Ballot = txtBollot.Text;
            inputObjSea.BallotDate = dtpBallotDate.Text;
            inputObjSea.ReceiptId = txtReceiptId.Text;
            inputObjSea.ReceiptDate = dtpReceiptDate.Text;
            inputObjSea.SupplierId = cbSupplier.SelectedValue.ToString();
            inputObjSea.StoreId = "1";
            inputObjSea.Paid = (chbPaid.Checked) ? "1" : "0";
            inputObjSea.InputDiscount = txtDiscount.Text;
            inputObjSea.InputNote = rtbNote.Text;
            inputObjSea.InputVat = txtVat.Text;
            inputObjSea.CreatedBy = Program.Username;


            if (input != null)
            {// Cập nhật
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CommonCodeUpdate"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                {
                    int i = inputBLL.Update(inputObjSea);
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
                    inputId = inputBLL.Tao_ProductID();
                    inputObjSea.InputId = inputId;

                    int i = inputBLL.Insert(inputObjSea);
                    if (i == 1)
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("InsertSuccess1");
                        txtInputId.Text = inputId;
                        //proSea.Image = null;
                    }
                    else
                    {
                        lblTB1.Text = Common.clsLanguages.GetResource("InsertNoSuccess1");
                    }
                }
            }


            SearchInputs(1);


        }

        private void LoadDetails(string inputId)
        {
            dgvDetail.Rows.Clear();
            DataTable dt = inputBLL.GetDetails(inputId);

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
                        dgvDetail.Rows[i].Cells[3].Value = dr["IngredientQty"].ToString();
                        dgvDetail.Rows[i].Cells[4].Value = dr["IngredientExpDate"].ToString();
                        dgvDetail.Rows[i].Cells[5].Value = dr["IngredientPrice"].ToString();
                        dgvDetail.Rows[i].Cells[6].Value = dr["IngredientVat"].ToString();
                        dgvDetail.Rows[i].Cells[7].Value = dr["IngredientDiscount"].ToString();
                        i++;
                    }
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string inputId = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                Input ob = inputBLL.GetInputWithID(inputId);
                if (ob != null)
                {
                    txtInputId.Text = ob.InputId;
                    txtBollot.Text = ob.Ballot;
                    dtpBallotDate.Text = ob.BallotDate;
                    txtReceiptId.Text = ob.ReceiptId;
                    dtpReceiptDate.Text = ob.ReceiptDate;
                    cbSupplier.SelectedValue = ob.SupplierId;
                    if (ob.Paid == "True")
                    {
                        chbPaid.Checked = true;
                    }
                    else
                    {
                        chbPaid.Checked = false;
                    }
                    txtDiscount.Text = ob.InputDiscount;
                    txtVat.Text = ob.InputVat;
                    rtbNote.Text = ob.InputNote;
                    LoadDetails(inputId);
                }

                //// Xóa
                if (e.ColumnIndex == 5)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox("Bạn có chắc muốn xóa đơn hàng nhập kho này",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        int Xoa = inputBLL.Delete(inputId);
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
            Final = inputBLL.SearchInputs(inputObjSea, 1, out total);
            double RecordPerPage = 20;
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            for (int i = 2; i <= totalPage; i++) // duyet tat ca cac trang
            {
                DataTable dt = inputBLL.SearchInputs(inputObjSea, i, out total);
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

            epex.ExportFileFromDataTable_Dung(Final, "Input_" + DateTime.Now.ToString("ddMMyy_HHmmss"),
                "List of " + "Input_" + DateTime.Now.ToString("ddMMyy_HHmmss"), prm);
        }

        private void btnAddMeasure_Click(object sender, EventArgs e)
        {
            if (txtInputId.Text != "")
            {
                frmAddInput frm = new frmAddInput();
                frm.inputId = txtInputId.Text;
                frm.ShowDialog();
                LoadDetails(txtInputId.Text);
            }
            
        }
    }
}
