namespace VVPosM1.Screen
{
    partial class frmManageReceip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageReceip));
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.dgvReceipDetail = new System.Windows.Forms.DataGridView();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoProduct1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBeforTax1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblThongTinKhachHang = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dvgCard = new System.Windows.Forms.DataGridView();
            this.STT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receipt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoCard2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pInput = new System.Windows.Forms.Panel();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.dgvRecept = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.linkNumber = new System.Windows.Forms.LinkLabel();
            this.lblTB = new System.Windows.Forms.Label();
            this.bntNext = new System.Windows.Forms.Button();
            this.bntPre = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RceiptCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBeforeTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipDetail)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCard)).BeginInit();
            this.pInput.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecept)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dgvReceipDetail);
            this.gbInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(387, 15);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(836, 331);
            this.gbInfo.TabIndex = 4;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin chi tiết hóa đơn";
            // 
            // dgvReceipDetail
            // 
            this.dgvReceipDetail.AllowUserToAddRows = false;
            this.dgvReceipDetail.AllowUserToDeleteRows = false;
            this.dgvReceipDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReceipDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvReceipDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceipDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceipDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceipDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.ReceiptId1,
            this.InfoProduct1,
            this.Quantity1,
            this.ProductPrice1,
            this.TotalBeforTax1,
            this.TotalTax,
            this.TotalAmount1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceipDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceipDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceipDetail.EnableHeadersVisualStyles = false;
            this.dgvReceipDetail.Location = new System.Drawing.Point(3, 22);
            this.dgvReceipDetail.Name = "dgvReceipDetail";
            this.dgvReceipDetail.ReadOnly = true;
            this.dgvReceipDetail.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReceipDetail.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceipDetail.Size = new System.Drawing.Size(830, 306);
            this.dgvReceipDetail.TabIndex = 0;
            // 
            // STT1
            // 
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            this.STT1.ReadOnly = true;
            this.STT1.Width = 50;
            // 
            // ReceiptId1
            // 
            this.ReceiptId1.HeaderText = "Mã hóa đơn";
            this.ReceiptId1.Name = "ReceiptId1";
            this.ReceiptId1.ReadOnly = true;
            // 
            // InfoProduct1
            // 
            this.InfoProduct1.HeaderText = "Thông tin sản phẩm";
            this.InfoProduct1.Name = "InfoProduct1";
            this.InfoProduct1.ReadOnly = true;
            this.InfoProduct1.Width = 200;
            // 
            // Quantity1
            // 
            this.Quantity1.HeaderText = "Số lượng";
            this.Quantity1.Name = "Quantity1";
            this.Quantity1.ReadOnly = true;
            this.Quantity1.Width = 80;
            // 
            // ProductPrice1
            // 
            this.ProductPrice1.HeaderText = "Giá sản phẩm";
            this.ProductPrice1.Name = "ProductPrice1";
            this.ProductPrice1.ReadOnly = true;
            // 
            // TotalBeforTax1
            // 
            this.TotalBeforTax1.HeaderText = "Tổng tiền trước thuế";
            this.TotalBeforTax1.Name = "TotalBeforTax1";
            this.TotalBeforTax1.ReadOnly = true;
            // 
            // TotalTax
            // 
            this.TotalTax.HeaderText = "Tổng tiền thuế";
            this.TotalTax.Name = "TotalTax";
            this.TotalTax.ReadOnly = true;
            // 
            // TotalAmount1
            // 
            this.TotalAmount1.HeaderText = "Tổng tiền";
            this.TotalAmount1.Name = "TotalAmount1";
            this.TotalAmount1.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblThongTinKhachHang);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(386, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 304);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // lblThongTinKhachHang
            // 
            this.lblThongTinKhachHang.AutoSize = true;
            this.lblThongTinKhachHang.Location = new System.Drawing.Point(6, 20);
            this.lblThongTinKhachHang.Name = "lblThongTinKhachHang";
            this.lblThongTinKhachHang.Size = new System.Drawing.Size(21, 20);
            this.lblThongTinKhachHang.TabIndex = 0;
            this.lblThongTinKhachHang.Text = "...";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dvgCard);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(637, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 311);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thẻ ATM";
            // 
            // dvgCard
            // 
            this.dvgCard.AllowUserToAddRows = false;
            this.dvgCard.AllowUserToDeleteRows = false;
            this.dvgCard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgCard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dvgCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dvgCard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT2,
            this.Receipt2,
            this.InfoCard2,
            this.Column22});
            this.dvgCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgCard.EnableHeadersVisualStyles = false;
            this.dvgCard.Location = new System.Drawing.Point(3, 22);
            this.dvgCard.Name = "dvgCard";
            this.dvgCard.ReadOnly = true;
            this.dvgCard.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCard.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgCard.Size = new System.Drawing.Size(577, 286);
            this.dvgCard.TabIndex = 1;
            // 
            // STT2
            // 
            this.STT2.HeaderText = "STT";
            this.STT2.Name = "STT2";
            this.STT2.ReadOnly = true;
            this.STT2.Width = 54;
            // 
            // Receipt2
            // 
            this.Receipt2.HeaderText = "Mã hóa đơn";
            this.Receipt2.Name = "Receipt2";
            this.Receipt2.ReadOnly = true;
            this.Receipt2.Width = 143;
            // 
            // InfoCard2
            // 
            this.InfoCard2.HeaderText = "Thông tin thẻ";
            this.InfoCard2.Name = "InfoCard2";
            this.InfoCard2.ReadOnly = true;
            this.InfoCard2.Width = 200;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "Thông tin khởi tạo";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Width = 180;
            // 
            // pInput
            // 
            this.pInput.Controls.Add(this.gbSearch);
            this.pInput.Location = new System.Drawing.Point(2, 15);
            this.pInput.Name = "pInput";
            this.pInput.Size = new System.Drawing.Size(380, 645);
            this.pInput.TabIndex = 7;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.dgvRecept);
            this.gbSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(0, 0);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(384, 645);
            this.gbSearch.TabIndex = 8;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Lọc hóa đơn";
            this.gbSearch.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dgvRecept
            // 
            this.dgvRecept.AllowUserToAddRows = false;
            this.dgvRecept.AllowUserToDeleteRows = false;
            this.dgvRecept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRecept.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvRecept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecept.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecept.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.RceiptCode,
            this.TotalBeforeTax,
            this.Tax,
            this.TotalAmount,
            this.TotalSale,
            this.TotalFinal,
            this.Creator,
            this.CreatedDate,
            this.Print});
            this.dgvRecept.EnableHeadersVisualStyles = false;
            this.dgvRecept.Location = new System.Drawing.Point(4, 252);
            this.dgvRecept.Name = "dgvRecept";
            this.dgvRecept.ReadOnly = true;
            this.dgvRecept.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvRecept.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRecept.Size = new System.Drawing.Size(372, 390);
            this.dgvRecept.TabIndex = 5;
            this.dgvRecept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClickReceipt);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.linkNumber);
            this.panel1.Controls.Add(this.lblTB);
            this.panel1.Controls.Add(this.bntNext);
            this.panel1.Controls.Add(this.bntPre);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtLoc);
            this.panel1.Controls.Add(this.cboLoc);
            this.panel1.Controls.Add(this.lblToDate);
            this.panel1.Controls.Add(this.lblFromDate);
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Location = new System.Drawing.Point(4, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 211);
            this.panel1.TabIndex = 51;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnExit.Location = new System.Drawing.Point(255, 106);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 50);
            this.btnExit.TabIndex = 64;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.Image = global::VVPosM1.Properties.Resources._1404382393_icon_ios7_undo;
            this.btnReset.Location = new System.Drawing.Point(135, 106);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 50);
            this.btnReset.TabIndex = 63;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // linkNumber
            // 
            this.linkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNumber.Location = new System.Drawing.Point(261, 184);
            this.linkNumber.Name = "linkNumber";
            this.linkNumber.Size = new System.Drawing.Size(56, 20);
            this.linkNumber.TabIndex = 62;
            this.linkNumber.TabStop = true;
            this.linkNumber.Text = "1";
            this.linkNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTB
            // 
            this.lblTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB.Location = new System.Drawing.Point(3, 174);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(195, 29);
            this.lblTB.TabIndex = 50;
            this.lblTB.Text = "...";
            this.lblTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bntNext
            // 
            this.bntNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntNext.BackColor = System.Drawing.Color.OrangeRed;
            this.bntNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNext.ForeColor = System.Drawing.Color.Transparent;
            this.bntNext.Location = new System.Drawing.Point(324, 174);
            this.bntNext.Name = "bntNext";
            this.bntNext.Size = new System.Drawing.Size(45, 32);
            this.bntNext.TabIndex = 7;
            this.bntNext.Text = ">";
            this.bntNext.UseVisualStyleBackColor = false;
            this.bntNext.Click += new System.EventHandler(this.bntNext_Click);
            // 
            // bntPre
            // 
            this.bntPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntPre.BackColor = System.Drawing.Color.OrangeRed;
            this.bntPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPre.ForeColor = System.Drawing.Color.Transparent;
            this.bntPre.Location = new System.Drawing.Point(208, 174);
            this.bntPre.Name = "bntPre";
            this.bntPre.Size = new System.Drawing.Size(45, 31);
            this.bntPre.TabIndex = 6;
            this.bntPre.Text = "<";
            this.bntPre.UseVisualStyleBackColor = false;
            this.bntPre.Click += new System.EventHandler(this.bntPre_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.btnSearch.Location = new System.Drawing.Point(23, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 51);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtLoc
            // 
            this.txtLoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoc.Location = new System.Drawing.Point(150, 74);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(218, 25);
            this.txtLoc.TabIndex = 4;
            this.txtLoc.TextChanged += new System.EventHandler(this.txtLoc_TextChanged);
            this.txtLoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoc_KeyPress);
            // 
            // cboLoc
            // 
            this.cboLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Location = new System.Drawing.Point(9, 72);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(135, 28);
            this.cboLoc.TabIndex = 3;
            this.cboLoc.SelectedIndexChanged += new System.EventHandler(this.cboLoc_SelectedIndexChanged);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(63, 46);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(68, 20);
            this.lblToDate.TabIndex = 55;
            this.lblToDate.Text = "Tới ngày";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(66, 15);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(65, 20);
            this.lblFromDate.TabIndex = 54;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(149, 40);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(219, 26);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(149, 9);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(219, 26);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 30;
            // 
            // RceiptCode
            // 
            this.RceiptCode.HeaderText = "Mã hóa đơn";
            this.RceiptCode.Name = "RceiptCode";
            this.RceiptCode.ReadOnly = true;
            this.RceiptCode.Width = 120;
            // 
            // TotalBeforeTax
            // 
            this.TotalBeforeTax.HeaderText = "Tổng tiền trước thuế";
            this.TotalBeforeTax.Name = "TotalBeforeTax";
            this.TotalBeforeTax.ReadOnly = true;
            // 
            // Tax
            // 
            this.Tax.HeaderText = "Tổng tiền thuế";
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Tổng tiền";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // TotalSale
            // 
            this.TotalSale.HeaderText = "Tổng tiền giảm giá";
            this.TotalSale.Name = "TotalSale";
            this.TotalSale.ReadOnly = true;
            // 
            // TotalFinal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFinal.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalFinal.HeaderText = "Tổng tiền cuối";
            this.TotalFinal.Name = "TotalFinal";
            this.TotalFinal.ReadOnly = true;
            this.TotalFinal.Width = 80;
            // 
            // Creator
            // 
            this.Creator.HeaderText = "Người tạo";
            this.Creator.Name = "Creator";
            this.Creator.ReadOnly = true;
            this.Creator.Width = 60;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Ngày tạo";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // Print
            // 
            this.Print.HeaderText = "In hóa đơn";
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Print.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Print.Text = "Print";
            // 
            // frmManageReceip
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1223, 661);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pInput);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageReceip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frmManageReceip_Load);
            this.gbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipDetail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCard)).EndInit();
            this.pInput.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecept)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.DataGridView dgvReceipDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dvgCard;
        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.DataGridView dgvRecept;
        private System.Windows.Forms.Label lblThongTinKhachHang;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.Button bntPre;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.ComboBox cboLoc;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoProduct1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBeforTax1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receipt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoCard2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RceiptCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBeforeTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewButtonColumn Print;
    }
}