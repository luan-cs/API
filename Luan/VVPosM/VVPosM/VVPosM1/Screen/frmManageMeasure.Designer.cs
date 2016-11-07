namespace VVPosM1.Screen
{
    partial class frmManageMeasure
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbNote = new System.Windows.Forms.Label();
            this.pInput = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngredientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.lblTB1 = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.linkNumber = new System.Windows.Forms.LinkLabel();
            this.bntNext = new System.Windows.Forms.Button();
            this.bntPre = new System.Windows.Forms.Button();
            this.txtMeasureId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMeasureId = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddMeasure = new System.Windows.Forms.Button();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntSeach = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pInput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNote
            // 
            this.lbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(42, 113);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(93, 16);
            this.lbNote.TabIndex = 65;
            this.lbNote.Text = "Ghi chú";
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pInput
            // 
            this.pInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pInput.Controls.Add(this.btnAddMeasure);
            this.pInput.Controls.Add(this.groupBox2);
            this.pInput.Controls.Add(this.rtbNote);
            this.pInput.Controls.Add(this.lbNote);
            this.pInput.Controls.Add(this.cboProduct);
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
            this.pInput.Controls.Add(this.txtMeasureId);
            this.pInput.Controls.Add(this.lblName);
            this.pInput.Controls.Add(this.lblMeasureId);
            this.pInput.Location = new System.Drawing.Point(5, 0);
            this.pInput.Name = "pInput";
            this.pInput.Size = new System.Drawing.Size(1205, 331);
            this.pInput.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetail);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(633, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 249);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Định Lượng";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeColumns = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colIngredientId,
            this.colIngredientName,
            this.colQty,
            this.colUnit,
            this.colDelete});
            this.dgvDetail.Location = new System.Drawing.Point(6, 21);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.Size = new System.Drawing.Size(553, 222);
            this.dgvDetail.TabIndex = 0;
            this.dgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellClick);
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colIngredientId
            // 
            this.colIngredientId.HeaderText = "IngredientId";
            this.colIngredientId.Name = "colIngredientId";
            this.colIngredientId.ReadOnly = true;
            this.colIngredientId.Visible = false;
            // 
            // colIngredientName
            // 
            this.colIngredientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIngredientName.HeaderText = "Tên Nguyên Liệu";
            this.colIngredientName.Name = "colIngredientName";
            this.colIngredientName.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Số Lượng";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Đơn Vị";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(149, 112);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(439, 65);
            this.rtbNote.TabIndex = 66;
            this.rtbNote.Text = "";
            // 
            // cboProduct
            // 
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(149, 59);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(439, 28);
            this.cboProduct.TabIndex = 4;
            // 
            // lblTB1
            // 
            this.lblTB1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB1.Location = new System.Drawing.Point(121, 250);
            this.lblTB1.Name = "lblTB1";
            this.lblTB1.Size = new System.Drawing.Size(274, 37);
            this.lblTB1.TabIndex = 62;
            this.lblTB1.Text = "...";
            // 
            // lblTB
            // 
            this.lblTB.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB.Location = new System.Drawing.Point(121, 287);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(440, 21);
            this.lblTB.TabIndex = 61;
            this.lblTB.Text = "...";
            this.lblTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkNumber
            // 
            this.linkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNumber.Location = new System.Drawing.Point(1034, 301);
            this.linkNumber.Name = "linkNumber";
            this.linkNumber.Size = new System.Drawing.Size(46, 20);
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
            this.bntNext.Location = new System.Drawing.Point(1086, 287);
            this.bntNext.Name = "bntNext";
            this.bntNext.Size = new System.Drawing.Size(75, 33);
            this.bntNext.TabIndex = 60;
            this.bntNext.Text = ">";
            this.bntNext.UseVisualStyleBackColor = false;
            // 
            // bntPre
            // 
            this.bntPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntPre.BackColor = System.Drawing.Color.OrangeRed;
            this.bntPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntPre.ForeColor = System.Drawing.Color.Transparent;
            this.bntPre.Location = new System.Drawing.Point(953, 288);
            this.bntPre.Name = "bntPre";
            this.bntPre.Size = new System.Drawing.Size(75, 32);
            this.bntPre.TabIndex = 58;
            this.bntPre.Text = "<";
            this.bntPre.UseVisualStyleBackColor = false;
            // 
            // txtMeasureId
            // 
            this.txtMeasureId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasureId.Location = new System.Drawing.Point(149, 13);
            this.txtMeasureId.Name = "txtMeasureId";
            this.txtMeasureId.ReadOnly = true;
            this.txtMeasureId.Size = new System.Drawing.Size(439, 29);
            this.txtMeasureId.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(2, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 16);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Tên sản phẩm *";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMeasureId
            // 
            this.lblMeasureId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasureId.Location = new System.Drawing.Point(13, 16);
            this.lblMeasureId.Name = "lblMeasureId";
            this.lblMeasureId.Size = new System.Drawing.Size(122, 16);
            this.lblMeasureId.TabIndex = 12;
            this.lblMeasureId.Text = "Mã Định Lượng";
            this.lblMeasureId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MeasureId,
            this.ProductName,
            this.colCreatedDate,
            this.Delete});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(3, 22);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.Size = new System.Drawing.Size(1209, 357);
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
            // MeasureId
            // 
            this.MeasureId.HeaderText = "Mã Định Lượng";
            this.MeasureId.Name = "MeasureId";
            this.MeasureId.ReadOnly = true;
            this.MeasureId.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.HeaderText = "Ngày Tạo";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.ReadOnly = true;
            this.colCreatedDate.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1215, 382);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
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
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Xóa";
            this.dataGridViewImageColumn2.Image = global::VVPosM1.Properties.Resources._1404478970_f_cross;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // btnAddMeasure
            // 
            this.btnAddMeasure.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAddMeasure.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddMeasure.Image = global::VVPosM1.Properties.Resources.add;
            this.btnAddMeasure.Location = new System.Drawing.Point(746, 272);
            this.btnAddMeasure.Name = "btnAddMeasure";
            this.btnAddMeasure.Size = new System.Drawing.Size(165, 51);
            this.btnAddMeasure.TabIndex = 68;
            this.btnAddMeasure.Text = "Thêm Nguyên Liệu";
            this.btnAddMeasure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMeasure.UseVisualStyleBackColor = false;
            this.btnAddMeasure.Click += new System.EventHandler(this.btnAddMeasure_Click);
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Xóa";
            this.colDelete.Image = global::VVPosM1.Properties.Resources._1404478970_f_cross;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.Width = 50;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExcel.Image = global::VVPosM1.Properties.Resources._1409729156_excel;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(359, 196);
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
            this.bntReset.Location = new System.Drawing.Point(266, 196);
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
            this.bntExit.Location = new System.Drawing.Point(453, 196);
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
            this.bntLuu.Location = new System.Drawing.Point(173, 196);
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
            this.bntSeach.Location = new System.Drawing.Point(80, 196);
            this.bntSeach.Name = "bntSeach";
            this.bntSeach.Size = new System.Drawing.Size(91, 51);
            this.bntSeach.TabIndex = 7;
            this.bntSeach.Text = "Tìm kiếm";
            this.bntSeach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntSeach.UseVisualStyleBackColor = false;
            this.bntSeach.Click += new System.EventHandler(this.bntSeach_Click);
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
            // frmManageMeasure
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1215, 729);
            this.Controls.Add(this.pInput);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManageMeasure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Định Lượng";
            this.Load += new System.EventHandler(this.frmManageMeasure_Load);
            this.pInput.ResumeLayout(false);
            this.pInput.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.Button btnAddMeasure;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngredientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblTB1;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.Button bntPre;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntSeach;
        private System.Windows.Forms.TextBox txtMeasureId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMeasureId;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}