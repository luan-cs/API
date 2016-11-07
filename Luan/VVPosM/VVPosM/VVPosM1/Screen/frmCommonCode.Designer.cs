namespace VVPosM1.Screen
{
    partial class frmCommonCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommonCode));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnInput = new System.Windows.Forms.Panel();
            this.cbParent = new System.Windows.Forms.ComboBox();
            this.lbParent = new System.Windows.Forms.Label();
            this.tbNumValue2 = new System.Windows.Forms.TextBox();
            this.tbNumValue1 = new System.Windows.Forms.TextBox();
            this.lblTB1 = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.linkNumber = new System.Windows.Forms.LinkLabel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbNumValue2 = new System.Windows.Forms.Label();
            this.lbNumValue1 = new System.Windows.Forms.Label();
            this.tbStrValue2 = new System.Windows.Forms.TextBox();
            this.lbStrValue2 = new System.Windows.Forms.Label();
            this.tbStrValue1 = new System.Windows.Forms.TextBox();
            this.cbCommonTypeId = new System.Windows.Forms.ComboBox();
            this.lbStrValue1 = new System.Windows.Forms.Label();
            this.tbCommonId = new System.Windows.Forms.TextBox();
            this.lbCommonTypeId = new System.Windows.Forms.Label();
            this.lbCommonId = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnInput.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pnInput
            // 
            this.pnInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnInput.Controls.Add(this.cbParent);
            this.pnInput.Controls.Add(this.lbParent);
            this.pnInput.Controls.Add(this.tbNumValue2);
            this.pnInput.Controls.Add(this.tbNumValue1);
            this.pnInput.Controls.Add(this.lblTB1);
            this.pnInput.Controls.Add(this.lblTB);
            this.pnInput.Controls.Add(this.linkNumber);
            this.pnInput.Controls.Add(this.btnNext);
            this.pnInput.Controls.Add(this.btnPre);
            this.pnInput.Controls.Add(this.btnExcel);
            this.pnInput.Controls.Add(this.btnReset);
            this.pnInput.Controls.Add(this.btnExit);
            this.pnInput.Controls.Add(this.btnSave);
            this.pnInput.Controls.Add(this.btnSearch);
            this.pnInput.Controls.Add(this.lbNumValue2);
            this.pnInput.Controls.Add(this.lbNumValue1);
            this.pnInput.Controls.Add(this.tbStrValue2);
            this.pnInput.Controls.Add(this.lbStrValue2);
            this.pnInput.Controls.Add(this.tbStrValue1);
            this.pnInput.Controls.Add(this.cbCommonTypeId);
            this.pnInput.Controls.Add(this.lbStrValue1);
            this.pnInput.Controls.Add(this.tbCommonId);
            this.pnInput.Controls.Add(this.lbCommonTypeId);
            this.pnInput.Controls.Add(this.lbCommonId);
            this.pnInput.Location = new System.Drawing.Point(88, 2);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(1025, 243);
            this.pnInput.TabIndex = 2;
            // 
            // cbParent
            // 
            this.cbParent.FormattingEnabled = true;
            this.cbParent.Location = new System.Drawing.Point(134, 69);
            this.cbParent.Name = "cbParent";
            this.cbParent.Size = new System.Drawing.Size(345, 21);
            this.cbParent.TabIndex = 77;
            // 
            // lbParent
            // 
            this.lbParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParent.Location = new System.Drawing.Point(3, 73);
            this.lbParent.Name = "lbParent";
            this.lbParent.Size = new System.Drawing.Size(114, 16);
            this.lbParent.TabIndex = 76;
            this.lbParent.Text = "Parent";
            this.lbParent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNumValue2
            // 
            this.tbNumValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumValue2.Location = new System.Drawing.Point(660, 134);
            this.tbNumValue2.Name = "tbNumValue2";
            this.tbNumValue2.Size = new System.Drawing.Size(355, 29);
            this.tbNumValue2.TabIndex = 75;
            this.tbNumValue2.TextChanged += new System.EventHandler(this.tbNumValue2_TextChanged);
            this.tbNumValue2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumValue2_KeyPress);
            // 
            // tbNumValue1
            // 
            this.tbNumValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumValue1.Location = new System.Drawing.Point(660, 99);
            this.tbNumValue1.Name = "tbNumValue1";
            this.tbNumValue1.Size = new System.Drawing.Size(355, 29);
            this.tbNumValue1.TabIndex = 74;
            this.tbNumValue1.TextChanged += new System.EventHandler(this.tbNumValue1_TextChanged);
            this.tbNumValue1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumValue1_KeyPress);
            // 
            // lblTB1
            // 
            this.lblTB1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB1.Location = new System.Drawing.Point(475, 171);
            this.lblTB1.Name = "lblTB1";
            this.lblTB1.Size = new System.Drawing.Size(236, 37);
            this.lblTB1.TabIndex = 68;
            this.lblTB1.Text = "...";
            // 
            // lblTB
            // 
            this.lblTB.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB.Location = new System.Drawing.Point(475, 208);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(305, 21);
            this.lblTB.TabIndex = 69;
            this.lblTB.Text = "...";
            this.lblTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkNumber
            // 
            this.linkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNumber.Location = new System.Drawing.Point(893, 198);
            this.linkNumber.Name = "linkNumber";
            this.linkNumber.Size = new System.Drawing.Size(46, 20);
            this.linkNumber.TabIndex = 71;
            this.linkNumber.TabStop = true;
            this.linkNumber.Text = "0";
            this.linkNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(945, 185);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 33);
            this.btnNext.TabIndex = 70;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPre.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPre.ForeColor = System.Drawing.Color.Transparent;
            this.btnPre.Location = new System.Drawing.Point(805, 185);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 32);
            this.btnPre.TabIndex = 67;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(285, 185);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(91, 51);
            this.btnExcel.TabIndex = 66;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(192, 185);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 51);
            this.btnReset.TabIndex = 64;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(378, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 51);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(99, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 51);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(6, 185);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 51);
            this.btnSearch.TabIndex = 62;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbNumValue2
            // 
            this.lbNumValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumValue2.Location = new System.Drawing.Point(516, 137);
            this.lbNumValue2.Name = "lbNumValue2";
            this.lbNumValue2.Size = new System.Drawing.Size(129, 16);
            this.lbNumValue2.TabIndex = 10;
            this.lbNumValue2.Text = "Giá trị kiểu số 2";
            this.lbNumValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNumValue1
            // 
            this.lbNumValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumValue1.Location = new System.Drawing.Point(516, 102);
            this.lbNumValue1.Name = "lbNumValue1";
            this.lbNumValue1.Size = new System.Drawing.Size(129, 16);
            this.lbNumValue1.TabIndex = 8;
            this.lbNumValue1.Text = "Giá trị kiểu số 1";
            this.lbNumValue1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbStrValue2
            // 
            this.tbStrValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStrValue2.Location = new System.Drawing.Point(660, 60);
            this.tbStrValue2.Name = "tbStrValue2";
            this.tbStrValue2.Size = new System.Drawing.Size(355, 29);
            this.tbStrValue2.TabIndex = 7;
            this.tbStrValue2.TextChanged += new System.EventHandler(this.tbStrValue2_TextChanged);
            // 
            // lbStrValue2
            // 
            this.lbStrValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStrValue2.Location = new System.Drawing.Point(499, 63);
            this.lbStrValue2.Name = "lbStrValue2";
            this.lbStrValue2.Size = new System.Drawing.Size(146, 16);
            this.lbStrValue2.TabIndex = 6;
            this.lbStrValue2.Text = "Giá trị kiểu chuỗi 2";
            this.lbStrValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbStrValue1
            // 
            this.tbStrValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStrValue1.Location = new System.Drawing.Point(660, 21);
            this.tbStrValue1.Name = "tbStrValue1";
            this.tbStrValue1.Size = new System.Drawing.Size(355, 29);
            this.tbStrValue1.TabIndex = 5;
            this.tbStrValue1.TextChanged += new System.EventHandler(this.tbStrValue1_TextChanged);
            // 
            // cbCommonTypeId
            // 
            this.cbCommonTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCommonTypeId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCommonTypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCommonTypeId.FormattingEnabled = true;
            this.cbCommonTypeId.Location = new System.Drawing.Point(134, 21);
            this.cbCommonTypeId.Name = "cbCommonTypeId";
            this.cbCommonTypeId.Size = new System.Drawing.Size(345, 28);
            this.cbCommonTypeId.TabIndex = 5;
            this.cbCommonTypeId.SelectedIndexChanged += new System.EventHandler(this.cbCommonTypeId_SelectedIndexChanged);
            // 
            // lbStrValue1
            // 
            this.lbStrValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStrValue1.Location = new System.Drawing.Point(499, 24);
            this.lbStrValue1.Name = "lbStrValue1";
            this.lbStrValue1.Size = new System.Drawing.Size(146, 16);
            this.lbStrValue1.TabIndex = 4;
            this.lbStrValue1.Text = "Giá trị kiểu chuỗi 1 *";
            this.lbStrValue1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCommonId
            // 
            this.tbCommonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCommonId.Location = new System.Drawing.Point(134, 128);
            this.tbCommonId.Name = "tbCommonId";
            this.tbCommonId.Size = new System.Drawing.Size(345, 29);
            this.tbCommonId.TabIndex = 4;
            this.tbCommonId.TextChanged += new System.EventHandler(this.tbCommonId_TextChanged);
            // 
            // lbCommonTypeId
            // 
            this.lbCommonTypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommonTypeId.Location = new System.Drawing.Point(6, 24);
            this.lbCommonTypeId.Name = "lbCommonTypeId";
            this.lbCommonTypeId.Size = new System.Drawing.Size(114, 16);
            this.lbCommonTypeId.TabIndex = 4;
            this.lbCommonTypeId.Text = "Tên loại";
            this.lbCommonTypeId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCommonId
            // 
            this.lbCommonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommonId.Location = new System.Drawing.Point(6, 131);
            this.lbCommonId.Name = "lbCommonId";
            this.lbCommonId.Size = new System.Drawing.Size(114, 26);
            this.lbCommonId.TabIndex = 3;
            this.lbCommonId.Text = "Mã common *";
            this.lbCommonId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbResult.Controls.Add(this.dgvResult);
            this.gbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(88, 251);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(1025, 381);
            this.gbResult.TabIndex = 3;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Kết quả";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.CommonId,
            this.Value,
            this.ParentId,
            this.CreateInfo,
            this.Delete});
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(3, 17);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.Size = new System.Drawing.Size(1019, 361);
            this.dgvResult.TabIndex = 0;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã loại";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // CommonId
            // 
            this.CommonId.HeaderText = "Mã common";
            this.CommonId.Name = "CommonId";
            this.CommonId.ReadOnly = true;
            this.CommonId.Width = 165;
            // 
            // Value
            // 
            this.Value.HeaderText = "Giá trị";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 250;
            // 
            // ParentId
            // 
            this.ParentId.HeaderText = "ParentId";
            this.ParentId.Name = "ParentId";
            this.ParentId.ReadOnly = true;
            // 
            // CreateInfo
            // 
            this.CreateInfo.HeaderText = "Thông tin khởi tạo";
            this.CreateInfo.Name = "CreateInfo";
            this.CreateInfo.ReadOnly = true;
            this.CreateInfo.Width = 230;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 70;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Xóa";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 80;
            // 
            // frmCommonCode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1204, 661);
            this.ControlBox = false;
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.pnInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCommonCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Common Code";
            this.Load += new System.EventHandler(this.frmCommonCode_Load);
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnInput;
        private System.Windows.Forms.Label lbNumValue2;
        private System.Windows.Forms.Label lbNumValue1;
        private System.Windows.Forms.TextBox tbStrValue2;
        private System.Windows.Forms.Label lbStrValue2;
        private System.Windows.Forms.TextBox tbStrValue1;
        private System.Windows.Forms.ComboBox cbCommonTypeId;
        private System.Windows.Forms.Label lbStrValue1;
        private System.Windows.Forms.TextBox tbCommonId;
        private System.Windows.Forms.Label lbCommonTypeId;
        private System.Windows.Forms.Label lbCommonId;
        private System.Windows.Forms.Label lblTB1;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.TextBox tbNumValue1;
        private System.Windows.Forms.TextBox tbNumValue2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ComboBox cbParent;
        private System.Windows.Forms.Label lbParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateInfo;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}