namespace VVPosM1.Screen
{
    partial class frmManageProductPrice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageProductPrice));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTB2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pInput10 = new System.Windows.Forms.Panel();
            this.txtPrice10 = new System.Windows.Forms.TextBox();
            this.txtProduct10 = new VVPosM1.Controls.CoolTextBox();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.btnNext10 = new System.Windows.Forms.Button();
            this.btnPre10 = new System.Windows.Forms.Button();
            this.btnExcel10 = new System.Windows.Forms.Button();
            this.btnReset10 = new System.Windows.Forms.Button();
            this.btnExit10 = new System.Windows.Forms.Button();
            this.btnSave10 = new System.Windows.Forms.Button();
            this.btnSearch10 = new System.Windows.Forms.Button();
            this.lblUpdate10 = new System.Windows.Forms.Label();
            this.lblTB10 = new System.Windows.Forms.Label();
            this.lblMaProduct10 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pInput10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1206, 440);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giá sản phẩm";
            // 
            // dgv
            // 
            this.dgv.AllowDrop = true;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ProductCode,
            this.ProductName,
            this.Time,
            this.Price,
            this.Creator,
            this.Delete});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(3, 22);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Size = new System.Drawing.Size(1200, 415);
            this.dgv.TabIndex = 25;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // STT
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle1;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 60;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Mã sản phẩm";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 200;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 280;
            // 
            // Time
            // 
            this.Time.HeaderText = "Thời gian cập nhật";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 230;
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá SP";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 200;
            // 
            // Creator
            // 
            this.Creator.HeaderText = "Người tạo";
            this.Creator.Name = "Creator";
            this.Creator.ReadOnly = true;
            this.Creator.Width = 230;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::VVPosM1.Properties.Resources._1404478970_f_cross;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Visible = false;
            // 
            // lblTB2
            // 
            this.lblTB2.AutoSize = true;
            this.lblTB2.Location = new System.Drawing.Point(396, 196);
            this.lblTB2.Name = "lblTB2";
            this.lblTB2.Size = new System.Drawing.Size(16, 13);
            this.lblTB2.TabIndex = 76;
            this.lblTB2.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "label3";
            // 
            // pInput10
            // 
            this.pInput10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pInput10.AutoSize = true;
            this.pInput10.Controls.Add(this.txtPrice10);
            this.pInput10.Controls.Add(this.txtProduct10);
            this.pInput10.Controls.Add(this.linkLabel10);
            this.pInput10.Controls.Add(this.btnNext10);
            this.pInput10.Controls.Add(this.btnPre10);
            this.pInput10.Controls.Add(this.btnExcel10);
            this.pInput10.Controls.Add(this.btnReset10);
            this.pInput10.Controls.Add(this.btnExit10);
            this.pInput10.Controls.Add(this.btnSave10);
            this.pInput10.Controls.Add(this.btnSearch10);
            this.pInput10.Controls.Add(this.lblUpdate10);
            this.pInput10.Controls.Add(this.lblTB10);
            this.pInput10.Controls.Add(this.lblMaProduct10);
            this.pInput10.Controls.Add(this.lblPrice);
            this.pInput10.Controls.Add(this.lblProduct);
            this.pInput10.Location = new System.Drawing.Point(2, 1);
            this.pInput10.Name = "pInput10";
            this.pInput10.Size = new System.Drawing.Size(1201, 213);
            this.pInput10.TabIndex = 75;
            // 
            // txtPrice10
            // 
            this.txtPrice10.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice10.Location = new System.Drawing.Point(743, 12);
            this.txtPrice10.Name = "txtPrice10";
            this.txtPrice10.Size = new System.Drawing.Size(412, 29);
            this.txtPrice10.TabIndex = 1;
            this.txtPrice10.TextChanged += new System.EventHandler(this.txtPrice10_TextChanged);
            this.txtPrice10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice10_KeyPress);
            // 
            // txtProduct10
            // 
            this.txtProduct10.AutoScroll = true;
            this.txtProduct10.BackColor = System.Drawing.SystemColors.Window;
            this.txtProduct10.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtProduct10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtProduct10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct10.Location = new System.Drawing.Point(160, 15);
            this.txtProduct10.Name = "txtProduct10";
            this.txtProduct10.Padding = new System.Windows.Forms.Padding(4);
            this.txtProduct10.PopupWidth = 300;
            this.txtProduct10.SelectedItemBackColor = System.Drawing.SystemColors.Highlight;
            this.txtProduct10.SelectedItemForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtProduct10.Size = new System.Drawing.Size(426, 27);
            this.txtProduct10.TabIndex = 0;
            this.txtProduct10.Validated += new System.EventHandler(this.txtProduct_Validated);
            // 
            // linkLabel10
            // 
            this.linkLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel10.Location = new System.Drawing.Point(1059, 176);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(46, 20);
            this.linkLabel10.TabIndex = 101;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "1";
            this.linkLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext10
            // 
            this.btnNext10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext10.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNext10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNext10.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext10.Location = new System.Drawing.Point(1114, 168);
            this.btnNext10.Name = "btnNext10";
            this.btnNext10.Size = new System.Drawing.Size(75, 33);
            this.btnNext10.TabIndex = 8;
            this.btnNext10.Text = ">";
            this.btnNext10.UseVisualStyleBackColor = false;
            this.btnNext10.Click += new System.EventHandler(this.btnNext10_Click);
            // 
            // btnPre10
            // 
            this.btnPre10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPre10.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPre10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPre10.ForeColor = System.Drawing.Color.Transparent;
            this.btnPre10.Location = new System.Drawing.Point(974, 168);
            this.btnPre10.Name = "btnPre10";
            this.btnPre10.Size = new System.Drawing.Size(75, 32);
            this.btnPre10.TabIndex = 7;
            this.btnPre10.Text = "<";
            this.btnPre10.UseVisualStyleBackColor = false;
            this.btnPre10.Click += new System.EventHandler(this.btnPre10_Click);
            // 
            // btnExcel10
            // 
            this.btnExcel10.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExcel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExcel10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExcel10.Image = global::VVPosM1.Properties.Resources._1409729156_excel;
            this.btnExcel10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel10.Location = new System.Drawing.Point(641, 70);
            this.btnExcel10.Name = "btnExcel10";
            this.btnExcel10.Size = new System.Drawing.Size(91, 51);
            this.btnExcel10.TabIndex = 6;
            this.btnExcel10.Text = "Xuất Excel";
            this.btnExcel10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel10.UseVisualStyleBackColor = false;
            this.btnExcel10.Click += new System.EventHandler(this.btnExcel10_Click);
            // 
            // btnReset10
            // 
            this.btnReset10.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReset10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReset10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset10.Image = global::VVPosM1.Properties.Resources._1404382393_icon_ios7_undo;
            this.btnReset10.Location = new System.Drawing.Point(547, 70);
            this.btnReset10.Name = "btnReset10";
            this.btnReset10.Size = new System.Drawing.Size(91, 51);
            this.btnReset10.TabIndex = 4;
            this.btnReset10.Text = "Reset";
            this.btnReset10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset10.UseVisualStyleBackColor = false;
            this.btnReset10.Click += new System.EventHandler(this.btnReset10_Click);
            // 
            // btnExit10
            // 
            this.btnExit10.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit10.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnExit10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit10.Location = new System.Drawing.Point(735, 70);
            this.btnExit10.Name = "btnExit10";
            this.btnExit10.Size = new System.Drawing.Size(91, 51);
            this.btnExit10.TabIndex = 5;
            this.btnExit10.Text = "Thoát";
            this.btnExit10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit10.UseVisualStyleBackColor = false;
            this.btnExit10.Click += new System.EventHandler(this.btnExit10_Click);
            // 
            // btnSave10
            // 
            this.btnSave10.BackColor = System.Drawing.Color.Red;
            this.btnSave10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave10.Image = global::VVPosM1.Properties.Resources._1404381785_save;
            this.btnSave10.Location = new System.Drawing.Point(454, 70);
            this.btnSave10.Name = "btnSave10";
            this.btnSave10.Size = new System.Drawing.Size(91, 51);
            this.btnSave10.TabIndex = 3;
            this.btnSave10.Text = "Lưu";
            this.btnSave10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave10.UseVisualStyleBackColor = false;
            this.btnSave10.Click += new System.EventHandler(this.btnSave10_Click);
            // 
            // btnSearch10
            // 
            this.btnSearch10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch10.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.btnSearch10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch10.Location = new System.Drawing.Point(361, 70);
            this.btnSearch10.Name = "btnSearch10";
            this.btnSearch10.Size = new System.Drawing.Size(91, 51);
            this.btnSearch10.TabIndex = 2;
            this.btnSearch10.Text = "Tìm kiếm";
            this.btnSearch10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch10.UseVisualStyleBackColor = false;
            this.btnSearch10.Click += new System.EventHandler(this.btnSearch10_Click);
            // 
            // lblUpdate10
            // 
            this.lblUpdate10.AutoSize = true;
            this.lblUpdate10.Location = new System.Drawing.Point(402, 138);
            this.lblUpdate10.Name = "lblUpdate10";
            this.lblUpdate10.Size = new System.Drawing.Size(16, 13);
            this.lblUpdate10.TabIndex = 94;
            this.lblUpdate10.Text = "...";
            // 
            // lblTB10
            // 
            this.lblTB10.AutoSize = true;
            this.lblTB10.Location = new System.Drawing.Point(402, 168);
            this.lblTB10.Name = "lblTB10";
            this.lblTB10.Size = new System.Drawing.Size(16, 13);
            this.lblTB10.TabIndex = 93;
            this.lblTB10.Text = "...";
            // 
            // lblMaProduct10
            // 
            this.lblMaProduct10.AutoSize = true;
            this.lblMaProduct10.Location = new System.Drawing.Point(157, 45);
            this.lblMaProduct10.Name = "lblMaProduct10";
            this.lblMaProduct10.Size = new System.Drawing.Size(0, 13);
            this.lblMaProduct10.TabIndex = 92;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(610, 15);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(109, 20);
            this.lblPrice.TabIndex = 91;
            this.lblPrice.Text = "Giá SP";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProduct
            // 
            this.lblProduct.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(11, 18);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(129, 20);
            this.lblProduct.TabIndex = 90;
            this.lblProduct.Text = "Thông tin sản phẩm";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmManageProductPrice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.ControlBox = false;
            this.Controls.Add(this.pInput10);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageProductPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý giá sản phẩm";
            this.Load += new System.EventHandler(this.frmManageProductPrice_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pInput10.ResumeLayout(false);
            this.pInput10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.Button bntPre;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntSeach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblMaDT;
        private Controls.CoolTextBox txtProduct;
        private System.Windows.Forms.Label lblObjectId;
        private System.Windows.Forms.Label lblTB2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pInput10;
        private System.Windows.Forms.TextBox txtPrice10;
        private Controls.CoolTextBox txtProduct10;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.Button btnNext10;
        private System.Windows.Forms.Button btnPre10;
        private System.Windows.Forms.Button btnExcel10;
        private System.Windows.Forms.Button btnReset10;
        private System.Windows.Forms.Button btnExit10;
        private System.Windows.Forms.Button btnSearch10;
        private System.Windows.Forms.Label lblUpdate10;
        private System.Windows.Forms.Label lblTB10;
        private System.Windows.Forms.Label lblMaProduct10;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Button btnSave10;
    }
}