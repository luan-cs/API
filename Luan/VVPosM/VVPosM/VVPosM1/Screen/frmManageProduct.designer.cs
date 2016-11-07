namespace VVPosM1.Screen
{
    partial class frmManageProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageProduct));
            this.cboProductType = new System.Windows.Forms.ComboBox();
            this.lblTB1 = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.linkNumber = new System.Windows.Forms.LinkLabel();
            this.bntNext = new System.Windows.Forms.Button();
            this.bntPre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.pInput = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbImgProduct = new System.Windows.Forms.PictureBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntSeach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProductType
            // 
            this.cboProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.Location = new System.Drawing.Point(617, 79);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(361, 28);
            this.cboProductType.TabIndex = 4;
            // 
            // lblTB1
            // 
            this.lblTB1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB1.Location = new System.Drawing.Point(469, 283);
            this.lblTB1.Name = "lblTB1";
            this.lblTB1.Size = new System.Drawing.Size(274, 37);
            this.lblTB1.TabIndex = 62;
            this.lblTB1.Text = "...";
            // 
            // lblTB
            // 
            this.lblTB.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB.Location = new System.Drawing.Point(468, 320);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(440, 21);
            this.lblTB.TabIndex = 61;
            this.lblTB.Text = "...";
            this.lblTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkNumber
            // 
            this.linkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNumber.Location = new System.Drawing.Point(995, 322);
            this.linkNumber.Name = "linkNumber";
            this.linkNumber.Size = new System.Drawing.Size(72, 20);
            this.linkNumber.TabIndex = 59;
            this.linkNumber.TabStop = true;
            this.linkNumber.Text = "1";
            this.linkNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntNext
            // 
            this.bntNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntNext.BackColor = System.Drawing.Color.OrangeRed;
            this.bntNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntNext.ForeColor = System.Drawing.Color.Transparent;
            this.bntNext.Location = new System.Drawing.Point(1073, 308);
            this.bntNext.Name = "bntNext";
            this.bntNext.Size = new System.Drawing.Size(75, 33);
            this.bntNext.TabIndex = 60;
            this.bntNext.Text = ">";
            this.bntNext.UseVisualStyleBackColor = false;
            this.bntNext.Click += new System.EventHandler(this.bntNext_Click);
            // 
            // bntPre
            // 
            this.bntPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntPre.BackColor = System.Drawing.Color.OrangeRed;
            this.bntPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntPre.ForeColor = System.Drawing.Color.Transparent;
            this.bntPre.Location = new System.Drawing.Point(914, 309);
            this.bntPre.Name = "bntPre";
            this.bntPre.Size = new System.Drawing.Size(75, 32);
            this.bntPre.TabIndex = 58;
            this.bntPre.Text = "<";
            this.bntPre.UseVisualStyleBackColor = false;
            this.bntPre.Click += new System.EventHandler(this.bntPre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1206, 299);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ProductId,
            this.ProductName,
            this.colPrice,
            this.Unit,
            this.ProductType,
            this.Notes,
            this.Info,
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
            this.dgv.Size = new System.Drawing.Size(1200, 274);
            this.dgv.TabIndex = 24;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Mã Sản phẩm";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 180;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá SP";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Đơn vị";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 110;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "Loại sản phẩm";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            this.ProductType.Width = 180;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Mô tả";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Width = 200;
            // 
            // Info
            // 
            this.Info.HeaderText = "TT Khởi tạo";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Width = 200;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Cyan;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(864, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 27);
            this.button7.TabIndex = 3;
            this.button7.Text = "Chọn hình";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNotes.Location = new System.Drawing.Point(16, 117);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(119, 16);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Mô tả";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtxtDescription.Location = new System.Drawing.Point(149, 114);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(829, 101);
            this.rtxtDescription.TabIndex = 5;
            this.rtxtDescription.Text = "";
            // 
            // txtImage
            // 
            this.txtImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.Location = new System.Drawing.Point(617, 45);
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Size = new System.Drawing.Size(241, 29);
            this.txtImage.TabIndex = 44;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(150, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 29);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(149, 13);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(335, 29);
            this.txtProductId.TabIndex = 0;
            // 
            // lblProductType
            // 
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(508, 86);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(96, 16);
            this.lblProductType.TabIndex = 17;
            this.lblProductType.Text = "Loại sản phẩm";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImage
            // 
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(511, 49);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(93, 16);
            this.lblImage.TabIndex = 15;
            this.lblImage.Text = "Hình ảnh";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit
            // 
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(57, 84);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(78, 16);
            this.lblUnit.TabIndex = 14;
            this.lblUnit.Text = "Đơn vị";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(2, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 16);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Tên sản phẩm *";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductId
            // 
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(13, 16);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(122, 16);
            this.lblProductId.TabIndex = 12;
            this.lblProductId.Text = "Mã sản phẩm";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pInput
            // 
            this.pInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pInput.Controls.Add(this.txtPrice);
            this.pInput.Controls.Add(this.lbPrice);
            this.pInput.Controls.Add(this.txtUnit);
            this.pInput.Controls.Add(this.cboProductType);
            this.pInput.Controls.Add(this.pbImgProduct);
            this.pInput.Controls.Add(this.btnExcel);
            this.pInput.Controls.Add(this.lblTB1);
            this.pInput.Controls.Add(this.lblTB);
            this.pInput.Controls.Add(this.bntReset);
            this.pInput.Controls.Add(this.linkNumber);
            this.pInput.Controls.Add(this.bntNext);
            this.pInput.Controls.Add(this.bntPre);
            this.pInput.Controls.Add(this.bntExit);
            this.pInput.Controls.Add(this.bntLuu);
            this.pInput.Controls.Add(this.bntSeach);
            this.pInput.Controls.Add(this.button7);
            this.pInput.Controls.Add(this.lblNotes);
            this.pInput.Controls.Add(this.rtxtDescription);
            this.pInput.Controls.Add(this.txtImage);
            this.pInput.Controls.Add(this.txtName);
            this.pInput.Controls.Add(this.txtProductId);
            this.pInput.Controls.Add(this.lblProductType);
            this.pInput.Controls.Add(this.lblImage);
            this.pInput.Controls.Add(this.lblUnit);
            this.pInput.Controls.Add(this.lblName);
            this.pInput.Controls.Add(this.lblProductId);
            this.pInput.Location = new System.Drawing.Point(1, 1);
            this.pInput.Name = "pInput";
            this.pInput.Size = new System.Drawing.Size(1205, 352);
            this.pInput.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(617, 12);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(241, 29);
            this.txtPrice.TabIndex = 66;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(511, 15);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(93, 16);
            this.lbPrice.TabIndex = 65;
            this.lbPrice.Text = "Giá SP";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(149, 78);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(335, 29);
            this.txtUnit.TabIndex = 2;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::VVPosM1.Properties.Resources._1404478970_f_cross;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::VVPosM1.Properties.Resources._1404478970_f_cross;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pbImgProduct
            // 
            this.pbImgProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgProduct.Location = new System.Drawing.Point(995, 9);
            this.pbImgProduct.Name = "pbImgProduct";
            this.pbImgProduct.Size = new System.Drawing.Size(181, 206);
            this.pbImgProduct.TabIndex = 64;
            this.pbImgProduct.TabStop = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExcel.Image = global::VVPosM1.Properties.Resources._1409729156_excel;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(429, 221);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(91, 51);
            this.btnExcel.TabIndex = 11;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // bntReset
            // 
            this.bntReset.BackColor = System.Drawing.Color.ForestGreen;
            this.bntReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntReset.Image = global::VVPosM1.Properties.Resources._1404382393_icon_ios7_undo;
            this.bntReset.Location = new System.Drawing.Point(336, 221);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(91, 51);
            this.bntReset.TabIndex = 9;
            this.bntReset.Text = "Reset";
            this.bntReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntReset.UseVisualStyleBackColor = false;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.DarkRed;
            this.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntExit.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.bntExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntExit.Location = new System.Drawing.Point(523, 221);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(91, 51);
            this.bntExit.TabIndex = 10;
            this.bntExit.Text = "Thoát";
            this.bntExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // bntLuu
            // 
            this.bntLuu.BackColor = System.Drawing.Color.Red;
            this.bntLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntLuu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntLuu.Image = global::VVPosM1.Properties.Resources._1404381785_save;
            this.bntLuu.Location = new System.Drawing.Point(243, 221);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(91, 51);
            this.bntLuu.TabIndex = 8;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntLuu.UseVisualStyleBackColor = false;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // bntSeach
            // 
            this.bntSeach.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bntSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntSeach.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntSeach.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.bntSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSeach.Location = new System.Drawing.Point(150, 221);
            this.bntSeach.Name = "bntSeach";
            this.bntSeach.Size = new System.Drawing.Size(91, 51);
            this.bntSeach.TabIndex = 7;
            this.bntSeach.Text = "Tìm kiếm";
            this.bntSeach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntSeach.UseVisualStyleBackColor = false;
            this.bntSeach.Click += new System.EventHandler(this.bntSeach_Click);
            // 
            // frmManageProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmManageProduct_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pInput.ResumeLayout(false);
            this.pInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProductType;
        private System.Windows.Forms.PictureBox pbImgProduct;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblTB1;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.Button bntPre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntSeach;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}