using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VVPosS.BusinessLayer;
using VVPosS.Entities;
using VVPosS.Common;

namespace VVPosS.Screen.POS
{
    public partial class frmEditDetailReceipt : Form
    {
        public int ViTriTrongListOrderDetail;
        


        public frmEditDetailReceipt()
        {
            InitializeComponent();
            SettingControl();
            SetUIChanges();          
        }

        public string id = "";
        public string Id
        {
            get { return id; }
        }

        private void SettingControl()
        {
            //setting background for form
            this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;     
            

        }


        public void SetUIChanges()
        {
            this.gDesk.Text = Common.clsLanguages.GetResource("ReceiptDetailEditing");
            this.lblMaSP.Text = Common.clsLanguages.GetResource("ProductID");//
            this.lblTenSP.Text = Common.clsLanguages.GetResource("ProductName");//

            this.label12.Text = Common.clsLanguages.GetResource("ReceiptProQty");//
            this.label15.Text = Common.clsLanguages.GetResource("ReceiptProPrice");//
            this.label14.Text = Common.clsLanguages.GetResource("ReceiptProTotal");//
            this.label6.Text = Common.clsLanguages.GetResource("ReceiptProTax");//
            this.label7.Text = Common.clsLanguages.GetResource("ReceiptProTotalAfterTax");//

            this.btnExit.Text = Common.clsLanguages.GetResource("Exit");//
            this.btnThem.Text = Common.clsLanguages.GetResource("Save");//
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                

        private void ClearDataGridView(DataGridView dtgv)
        {
            dtgv.Rows.Clear();
            dtgv.Refresh();
        }

        private void gDesk_Enter(object sender, EventArgs e)
        {
            if (Program.od_sua != null)
            {
                lblProductId.Text = Program.od_sua.ProductId;
                lblProductName.Text = Program.od_sua.ProductName;
                txtSL.Text = Program.od_sua.Qty;
                txtDG.Text = Program.od_sua.Price;
                txtThue.Text = Program.od_sua.TaxAmmount;
                txtTTT.Text = Program.od_sua.AmmountBeforeTax;
                txtTTS.Text = Program.od_sua.TotalAmount;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Complete();
        }

        private void Complete()
        {
            Program.od_sua.Qty = txtSL.Text;
            Program.od_sua.Price = txtDG.Text;
            Program.od_sua.TaxAmmount = txtThue.Text;
            Program.od_sua.AmmountBeforeTax = txtTTT.Text;
            Program.od_sua.TotalAmount = txtTTS.Text;
            this.Close();
        }

        private void TinhToan()
        {
            double sl = double.Parse(txtSL.Text);
            double dg = double.Parse(txtDG.Text);
            double ttt = sl * dg;
            double thue = double.Parse(txtThue.Text);
            double tts = ttt + thue;

            txtSL.Text = sl.ToString();
            txtDG.Text = dg.ToString("0,0");
            txtTTT.Text = ttt.ToString("0,0");
            txtThue.Text = thue.ToString("0,0");
            txtTTS.Text = tts.ToString("0,0");
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if(sender.Equals(this.txtSL))
            {
                TinhToan();
                txtSL.SelectionStart = txtSL.Text.Length;
            }
        }

        private void txtDG_TextChanged(object sender, EventArgs e)
        {
            if (sender.Equals(this.txtDG))
            {
                TinhToan();
                txtDG.SelectionStart = txtDG.Text.Length;
            }
        }

        private void txtThue_TextChanged(object sender, EventArgs e)
        {
            if (sender.Equals(this.txtThue))
            {
                TinhToan();
                txtThue.SelectionStart = txtThue.Text.Length;
            }
        }


    }
}

