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
    public partial class frmAddInput : Form
    {
        public string inputId;
        private IngredientBLL ingredientBLL;
        private InputDetailBLL inputDetailBLL;
        private DataTable dt;
        private DataRow[] filteredRows;
        public frmAddInput()
        {
            InitializeComponent();
        }

        private void frmAddInput_Load(object sender, EventArgs e)
        {
            ingredientBLL = new IngredientBLL();
            inputDetailBLL = new InputDetailBLL();
            dt = new DataTable();
            LoadIngredients();
            txtProduct.Text = this.inputId;
        }

        private void LoadIngredients()
        {
            dt = ingredientBLL.GetIngredients();
            cbbIngredient.DisplayMember = "IngredientName";
            cbbIngredient.ValueMember = "IngredientId";
            cbbIngredient.DataSource = dt;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtQty.Text, out parsedValue))
            {
                MessageBox.Show("Vui Lòng chỉ nhập số");
                return;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtPrice.Text, out parsedValue))
            {
                MessageBox.Show("Vui Lòng chỉ nhập số");
                return;
            }
        }

        private void txtVAT_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtVAT.Text, out parsedValue))
            {
                MessageBox.Show("Vui Lòng chỉ nhập số");
                return;
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtDiscount.Text, out parsedValue))
            {
                MessageBox.Show("Vui Lòng chỉ nhập số");
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtCheck = inputDetailBLL.GetInputDetailById(this.inputId, cbbIngredient.SelectedValue.ToString());
            InputDetail obj = new InputDetail();
            obj.InputId = this.inputId;
            obj.IngredientId = cbbIngredient.SelectedValue.ToString();
            obj.IngredientExpDate = dtbExDate.Text;
            obj.IngredientQty = txtQty.Text;
            obj.IngredientPrice = txtPrice.Text;
            obj.IngredientVat = txtVAT.Text;
            obj.IngredientDiscount = txtDiscount.Text;
            if (dtCheck != null)
            {
                if (dtCheck.Rows.Count != 0)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox("Bạn có muốn cập nhật thông tin nhập này không?",
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        // Update
                        int i = inputDetailBLL.Update(obj);
                        if (i == 1)
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox("Cập nhật thành công",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                        else
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox("Cập nhật thất bại",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                    }
                }
                else
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox("Bạn có muốn thêm thông tin nhập này không?",
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        // Insert
                        int i = inputDetailBLL.Insert(obj);
                        if (i == 1)
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox("Thêm mới thành công",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                        else
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox("Thêm mới thất bại",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
