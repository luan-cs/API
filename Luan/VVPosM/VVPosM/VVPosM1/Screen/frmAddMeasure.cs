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
    public partial class frmAddMeasure : Form
    {
        private IngredientBLL ingredientBLL;
        public string measureId;
        public string productId;
        public string productName;
        private DataTable dt;
        private DataRow[] filteredRows;
        public frmAddMeasure()
        {
            InitializeComponent();
        }

        private void frmAddMeasure_Load(object sender, EventArgs e)
        {
            ingredientBLL = new IngredientBLL();
            dt = new DataTable();
            LoadIngredients();
            txtProduct.Text = this.productName;

        }

        private void LoadIngredients()
        {
            dt = ingredientBLL.GetIngredients();
            cbbIngredient.DisplayMember = "IngredientName";
            cbbIngredient.ValueMember = "IngredientId";
            cbbIngredient.DataSource = dt;
        }

        private void cbbIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt != null && dt.Rows.Count != 0)
            {
                filteredRows = dt.Select("IngredientId = '" + cbbIngredient.SelectedValue.ToString() + "'");
                txtUnit.Text = filteredRows[0].ItemArray[4].ToString();
            }
            
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text != "")
            {
                int parsedValue;
                if (!int.TryParse(txtQty.Text, out parsedValue))
                {
                    MessageBox.Show("Vui Lòng chỉ nhập số");
                    return;
                }
                //if (parsedValue > int.Parse(filteredRows[0].ItemArray[3].ToString()))
                //{
                //    MessageBox.Show(string.Format("Số lượng tồn kho không đủ. Vui lòng nhập nhỏ hơn {0}", filteredRows[0].ItemArray[3].ToString()));
                //    return;
                //}
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtCheck = ingredientBLL.GetMeasureDetailById(this.measureId, cbbIngredient.SelectedValue.ToString());
            MeasureDetail obj = new MeasureDetail();
            obj.MeasureId = this.measureId;
            obj.IngredientId = cbbIngredient.SelectedValue.ToString();
            obj.MeasureQty = txtQty.Text;
            if (dtCheck != null)
            {
                if (dtCheck.Rows.Count != 0)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox("Bạn có muốn cập nhật nguyên liệu này cho sản phẩm?",
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        // Update
                        int i = ingredientBLL.Update(obj);
                        if (i == 1)
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox("Cập nhật nguyên liệu thành công",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                        else
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox("Cập nhật nguyên liệu thất bại",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                    }
                }
                else
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox("Bạn có muốn thêm nguyên liệu mới cho sản phẩm?",
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        // Insert
                        int i = ingredientBLL.Insert(obj);
                        if (i == 1)
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox("Thêm mới nguyên liệu thành công",
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        }
                        else
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox("Thêm mới nguyên liệu thất bại",
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
