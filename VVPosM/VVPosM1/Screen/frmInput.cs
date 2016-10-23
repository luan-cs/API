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

namespace VVPosM1.Screen
{
    public partial class frmInput : Form
    {
        private InputBLL inputBLL;
        private SupplierBLL supplierBLL;
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
            supplierBLL = new SupplierBLL();
            inputObj = new Input();
            inputObjSea = new Input();
            // Load data for supplier
            LoadSuppliers();

        }

        private void LoadSuppliers()
        {
            DataTable dt = new DataTable();
            dt = supplierBLL.GetSuppliers();
            if (dt != null && dt.Rows.Count != 0)
            {
                cbSupplier.DisplayMember = "SupplierName";
                cbSupplier.ValueMember = "SupplierId";
                cbSupplier.DataSource = dt;
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
            inputObjSea.SupplierId = cbSupplier.SelectedValue.ToString();
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
            obj.SupplierId = cbSupplier.SelectedValue.ToString();
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
    }
}
