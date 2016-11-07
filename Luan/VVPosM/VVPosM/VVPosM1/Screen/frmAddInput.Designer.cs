namespace VVPosM1.Screen
{
    partial class frmAddInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddInput));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.cbbIngredient = new System.Windows.Forms.ComboBox();
            this.lblIngridient = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblInputId = new System.Windows.Forms.Label();
            this.lblExDate = new System.Windows.Forms.Label();
            this.dtbExDate = new System.Windows.Forms.DateTimePicker();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnCancel.Location = new System.Drawing.Point(178, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 42);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::VVPosM1.Properties.Resources._1404381785_save;
            this.btnSave.Location = new System.Drawing.Point(343, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(178, 226);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(279, 21);
            this.txtPrice.TabIndex = 17;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(131, 229);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(26, 15);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Giá";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(178, 174);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(279, 21);
            this.txtQty.TabIndex = 15;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(97, 177);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(60, 15);
            this.lblQty.TabIndex = 14;
            this.lblQty.Text = "Số Lượng";
            // 
            // cbbIngredient
            // 
            this.cbbIngredient.FormattingEnabled = true;
            this.cbbIngredient.Location = new System.Drawing.Point(178, 78);
            this.cbbIngredient.Name = "cbbIngredient";
            this.cbbIngredient.Size = new System.Drawing.Size(279, 23);
            this.cbbIngredient.TabIndex = 13;
            // 
            // lblIngridient
            // 
            this.lblIngridient.AutoSize = true;
            this.lblIngridient.Location = new System.Drawing.Point(57, 81);
            this.lblIngridient.Name = "lblIngridient";
            this.lblIngridient.Size = new System.Drawing.Size(100, 15);
            this.lblIngridient.TabIndex = 12;
            this.lblIngridient.Text = "Tên Nguyên Liệu";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(178, 28);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.ReadOnly = true;
            this.txtProduct.Size = new System.Drawing.Size(279, 21);
            this.txtProduct.TabIndex = 11;
            // 
            // lblInputId
            // 
            this.lblInputId.AutoSize = true;
            this.lblInputId.Location = new System.Drawing.Point(101, 32);
            this.lblInputId.Name = "lblInputId";
            this.lblInputId.Size = new System.Drawing.Size(56, 15);
            this.lblInputId.TabIndex = 10;
            this.lblInputId.Text = "Mã nhập";
            // 
            // lblExDate
            // 
            this.lblExDate.AutoSize = true;
            this.lblExDate.Location = new System.Drawing.Point(78, 125);
            this.lblExDate.Name = "lblExDate";
            this.lblExDate.Size = new System.Drawing.Size(79, 15);
            this.lblExDate.TabIndex = 20;
            this.lblExDate.Text = "Ngày hết hạn";
            // 
            // dtbExDate
            // 
            this.dtbExDate.CustomFormat = "yyyy-MM-dd";
            this.dtbExDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbExDate.Location = new System.Drawing.Point(178, 120);
            this.dtbExDate.Name = "dtbExDate";
            this.dtbExDate.Size = new System.Drawing.Size(279, 21);
            this.dtbExDate.TabIndex = 21;
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(178, 271);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(279, 21);
            this.txtVAT.TabIndex = 23;
            this.txtVAT.TextChanged += new System.EventHandler(this.txtVAT_TextChanged);
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(129, 274);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(28, 15);
            this.lblVat.TabIndex = 22;
            this.lblVat.Text = "VAT";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(178, 313);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(279, 21);
            this.txtDiscount.TabIndex = 25;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(100, 316);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(57, 15);
            this.lblDiscount.TabIndex = 24;
            this.lblDiscount.Text = "Giảm giá";
            // 
            // frmAddInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(530, 434);
            this.ControlBox = false;
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.dtbExDate);
            this.Controls.Add(this.lblExDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.cbbIngredient);
            this.Controls.Add(this.lblIngridient);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblInputId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nguyên Liệu Vào Kho";
            this.Load += new System.EventHandler(this.frmAddInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.ComboBox cbbIngredient;
        private System.Windows.Forms.Label lblIngridient;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblInputId;
        private System.Windows.Forms.Label lblExDate;
        private System.Windows.Forms.DateTimePicker dtbExDate;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
    }
}