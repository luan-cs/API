namespace VVPosM1.Screen
{
    partial class frmAddMeasure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMeasure));
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblIngridient = new System.Windows.Forms.Label();
            this.cbbIngredient = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(52, 21);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(78, 13);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Tên Sản Phẩm";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(158, 18);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.ReadOnly = true;
            this.txtProduct.Size = new System.Drawing.Size(240, 20);
            this.txtProduct.TabIndex = 1;
            // 
            // lblIngridient
            // 
            this.lblIngridient.AutoSize = true;
            this.lblIngridient.Location = new System.Drawing.Point(41, 64);
            this.lblIngridient.Name = "lblIngridient";
            this.lblIngridient.Size = new System.Drawing.Size(89, 13);
            this.lblIngridient.TabIndex = 2;
            this.lblIngridient.Text = "Tên Nguyên Liệu";
            // 
            // cbbIngredient
            // 
            this.cbbIngredient.FormattingEnabled = true;
            this.cbbIngredient.Location = new System.Drawing.Point(158, 61);
            this.cbbIngredient.Name = "cbbIngredient";
            this.cbbIngredient.Size = new System.Drawing.Size(240, 21);
            this.cbbIngredient.TabIndex = 3;
            this.cbbIngredient.SelectedIndexChanged += new System.EventHandler(this.cbbIngredient_SelectedIndexChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(158, 106);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(240, 20);
            this.txtQty.TabIndex = 5;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(77, 109);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(53, 13);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "Số Lượng";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(91, 154);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(39, 13);
            this.lblUnit.TabIndex = 6;
            this.lblUnit.Text = "Đơn Vị";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(158, 151);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(240, 20);
            this.txtUnit.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::VVPosM1.Properties.Resources._1404381785_save;
            this.btnSave.Location = new System.Drawing.Point(284, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnCancel.Location = new System.Drawing.Point(158, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 42);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(483, 277);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.cbbIngredient);
            this.Controls.Add(this.lblIngridient);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddMeasure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Định Lượng";
            this.Load += new System.EventHandler(this.frmAddMeasure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblIngridient;
        private System.Windows.Forms.ComboBox cbbIngredient;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}