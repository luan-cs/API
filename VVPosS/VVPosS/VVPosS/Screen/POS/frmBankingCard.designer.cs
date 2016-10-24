namespace VVPosS.Screen.POS
{
    partial class frmBankingCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankingCard));
            this.lbTittle1 = new System.Windows.Forms.Label();
            this.lbDesk = new System.Windows.Forms.Label();
            this.txtMerchantID = new System.Windows.Forms.TextBox();
            this.lbl_MerchantID = new System.Windows.Forms.Label();
            this.txtTransType = new System.Windows.Forms.TextBox();
            this.lbl_TransactionType = new System.Windows.Forms.Label();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.lbl_BatchNo = new System.Windows.Forms.Label();
            this.txtAppCode = new System.Windows.Forms.TextBox();
            this.lbl_AppCode = new System.Windows.Forms.Label();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.lbl_RefNo = new System.Windows.Forms.Label();
            this.cbbBank = new System.Windows.Forms.ComboBox();
            this.lbl_NganHang = new System.Windows.Forms.Label();
            this.txtTraceNo = new System.Windows.Forms.TextBox();
            this.lbl_TraceNo = new System.Windows.Forms.Label();
            this.txtTerminalId = new System.Windows.Forms.TextBox();
            this.lbl_SoMayPOS = new System.Windows.Forms.Label();
            this.cbbCardType = new System.Windows.Forms.ComboBox();
            this.txtExpiredDate = new System.Windows.Forms.TextBox();
            this.lbl_NgayHetHan = new System.Windows.Forms.Label();
            this.txtCardHolderName = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lbl_SoTienThanhToan = new System.Windows.Forms.Label();
            this.lbl_LoaiThe = new System.Windows.Forms.Label();
            this.lbl_TenChuThe = new System.Windows.Forms.Label();
            this.lbl_SoThe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lblTongTienPX = new System.Windows.Forms.Label();
            this.lblDaThanhToan = new System.Windows.Forms.Label();
            this.lbl_DaThanhToan = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dtg_BankCard_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_BankCard_Infomartion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_BankCard_Transation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_BankCard_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_BankCard_Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSoTienTT = new VVPosS.Controls.NumericTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTittle1
            // 
            this.lbTittle1.BackColor = System.Drawing.Color.Transparent;
            this.lbTittle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTittle1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle1.ForeColor = System.Drawing.Color.Black;
            this.lbTittle1.Location = new System.Drawing.Point(0, 0);
            this.lbTittle1.Name = "lbTittle1";
            this.lbTittle1.Size = new System.Drawing.Size(833, 39);
            this.lbTittle1.TabIndex = 32;
            this.lbTittle1.Text = "Chi tiết Order ";
            this.lbTittle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDesk
            // 
            this.lbDesk.AutoSize = true;
            this.lbDesk.BackColor = System.Drawing.Color.Transparent;
            this.lbDesk.ForeColor = System.Drawing.Color.Black;
            this.lbDesk.Location = new System.Drawing.Point(24, 65);
            this.lbDesk.Name = "lbDesk";
            this.lbDesk.Size = new System.Drawing.Size(106, 20);
            this.lbDesk.TabIndex = 33;
            this.lbDesk.Text = "Chi tiết Order ";
            // 
            // txtMerchantID
            // 
            this.txtMerchantID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMerchantID.Location = new System.Drawing.Point(578, 202);
            this.txtMerchantID.Name = "txtMerchantID";
            this.txtMerchantID.Size = new System.Drawing.Size(227, 26);
            this.txtMerchantID.TabIndex = 61;
            // 
            // lbl_MerchantID
            // 
            this.lbl_MerchantID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MerchantID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_MerchantID.Location = new System.Drawing.Point(425, 205);
            this.lbl_MerchantID.Name = "lbl_MerchantID";
            this.lbl_MerchantID.Size = new System.Drawing.Size(143, 20);
            this.lbl_MerchantID.TabIndex = 78;
            this.lbl_MerchantID.Text = "Merchant ID";
            this.lbl_MerchantID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTransType
            // 
            this.txtTransType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransType.Location = new System.Drawing.Point(578, 170);
            this.txtTransType.Name = "txtTransType";
            this.txtTransType.Size = new System.Drawing.Size(227, 26);
            this.txtTransType.TabIndex = 60;
            // 
            // lbl_TransactionType
            // 
            this.lbl_TransactionType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TransactionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_TransactionType.Location = new System.Drawing.Point(416, 173);
            this.lbl_TransactionType.Name = "lbl_TransactionType";
            this.lbl_TransactionType.Size = new System.Drawing.Size(152, 20);
            this.lbl_TransactionType.TabIndex = 77;
            this.lbl_TransactionType.Text = "Transaction Type";
            this.lbl_TransactionType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatchNo.Location = new System.Drawing.Point(578, 139);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(227, 26);
            this.txtBatchNo.TabIndex = 59;
            // 
            // lbl_BatchNo
            // 
            this.lbl_BatchNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BatchNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_BatchNo.Location = new System.Drawing.Point(443, 142);
            this.lbl_BatchNo.Name = "lbl_BatchNo";
            this.lbl_BatchNo.Size = new System.Drawing.Size(125, 20);
            this.lbl_BatchNo.TabIndex = 76;
            this.lbl_BatchNo.Text = "Batch No.";
            this.lbl_BatchNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAppCode
            // 
            this.txtAppCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppCode.Location = new System.Drawing.Point(578, 108);
            this.txtAppCode.Name = "txtAppCode";
            this.txtAppCode.Size = new System.Drawing.Size(227, 26);
            this.txtAppCode.TabIndex = 58;
            // 
            // lbl_AppCode
            // 
            this.lbl_AppCode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AppCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_AppCode.Location = new System.Drawing.Point(442, 109);
            this.lbl_AppCode.Name = "lbl_AppCode";
            this.lbl_AppCode.Size = new System.Drawing.Size(126, 20);
            this.lbl_AppCode.TabIndex = 75;
            this.lbl_AppCode.Text = "App Code";
            this.lbl_AppCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRefNo
            // 
            this.txtRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefNo.Location = new System.Drawing.Point(578, 298);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(227, 26);
            this.txtRefNo.TabIndex = 64;
            // 
            // lbl_RefNo
            // 
            this.lbl_RefNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RefNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_RefNo.Location = new System.Drawing.Point(429, 299);
            this.lbl_RefNo.Name = "lbl_RefNo";
            this.lbl_RefNo.Size = new System.Drawing.Size(139, 20);
            this.lbl_RefNo.TabIndex = 74;
            this.lbl_RefNo.Text = "Số Ref";
            this.lbl_RefNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbBank
            // 
            this.cbbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbBank.FormattingEnabled = true;
            this.cbbBank.Location = new System.Drawing.Point(176, 105);
            this.cbbBank.Name = "cbbBank";
            this.cbbBank.Size = new System.Drawing.Size(227, 28);
            this.cbbBank.TabIndex = 53;
            this.cbbBank.SelectedIndexChanged += new System.EventHandler(this.cbbBank_SelectedIndexChanged);
            // 
            // lbl_NganHang
            // 
            this.lbl_NganHang.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NganHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_NganHang.Location = new System.Drawing.Point(27, 109);
            this.lbl_NganHang.Name = "lbl_NganHang";
            this.lbl_NganHang.Size = new System.Drawing.Size(140, 20);
            this.lbl_NganHang.TabIndex = 73;
            this.lbl_NganHang.Text = "Ngân hàng";
            this.lbl_NganHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTraceNo
            // 
            this.txtTraceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTraceNo.Location = new System.Drawing.Point(578, 266);
            this.txtTraceNo.Name = "txtTraceNo";
            this.txtTraceNo.Size = new System.Drawing.Size(227, 26);
            this.txtTraceNo.TabIndex = 63;
            // 
            // lbl_TraceNo
            // 
            this.lbl_TraceNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TraceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_TraceNo.Location = new System.Drawing.Point(417, 269);
            this.lbl_TraceNo.Name = "lbl_TraceNo";
            this.lbl_TraceNo.Size = new System.Drawing.Size(151, 20);
            this.lbl_TraceNo.TabIndex = 72;
            this.lbl_TraceNo.Text = "Số Bill / Trace No";
            this.lbl_TraceNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTerminalId
            // 
            this.txtTerminalId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTerminalId.Location = new System.Drawing.Point(578, 233);
            this.txtTerminalId.Name = "txtTerminalId";
            this.txtTerminalId.Size = new System.Drawing.Size(227, 26);
            this.txtTerminalId.TabIndex = 62;
            // 
            // lbl_SoMayPOS
            // 
            this.lbl_SoMayPOS.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SoMayPOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_SoMayPOS.Location = new System.Drawing.Point(429, 236);
            this.lbl_SoMayPOS.Name = "lbl_SoMayPOS";
            this.lbl_SoMayPOS.Size = new System.Drawing.Size(139, 20);
            this.lbl_SoMayPOS.TabIndex = 71;
            this.lbl_SoMayPOS.Text = "Số máy Pos";
            this.lbl_SoMayPOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbCardType
            // 
            this.cbbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCardType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCardType.FormattingEnabled = true;
            this.cbbCardType.Location = new System.Drawing.Point(176, 233);
            this.cbbCardType.Name = "cbbCardType";
            this.cbbCardType.Size = new System.Drawing.Size(227, 28);
            this.cbbCardType.TabIndex = 57;
            // 
            // txtExpiredDate
            // 
            this.txtExpiredDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpiredDate.Location = new System.Drawing.Point(176, 202);
            this.txtExpiredDate.Name = "txtExpiredDate";
            this.txtExpiredDate.Size = new System.Drawing.Size(119, 26);
            this.txtExpiredDate.TabIndex = 56;
            // 
            // lbl_NgayHetHan
            // 
            this.lbl_NgayHetHan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NgayHetHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_NgayHetHan.Location = new System.Drawing.Point(27, 205);
            this.lbl_NgayHetHan.Name = "lbl_NgayHetHan";
            this.lbl_NgayHetHan.Size = new System.Drawing.Size(140, 20);
            this.lbl_NgayHetHan.TabIndex = 70;
            this.lbl_NgayHetHan.Text = "Ngày hết hạn";
            this.lbl_NgayHetHan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCardHolderName
            // 
            this.txtCardHolderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardHolderName.Location = new System.Drawing.Point(176, 170);
            this.txtCardHolderName.Name = "txtCardHolderName";
            this.txtCardHolderName.Size = new System.Drawing.Size(227, 26);
            this.txtCardHolderName.TabIndex = 55;
            // 
            // txtCardNo
            // 
            this.txtCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardNo.Location = new System.Drawing.Point(176, 139);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(206, 26);
            this.txtCardNo.TabIndex = 54;
            // 
            // lbl_SoTienThanhToan
            // 
            this.lbl_SoTienThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SoTienThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_SoTienThanhToan.Location = new System.Drawing.Point(27, 304);
            this.lbl_SoTienThanhToan.Name = "lbl_SoTienThanhToan";
            this.lbl_SoTienThanhToan.Size = new System.Drawing.Size(140, 20);
            this.lbl_SoTienThanhToan.TabIndex = 68;
            this.lbl_SoTienThanhToan.Text = "Số tiền thanh toán";
            this.lbl_SoTienThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_LoaiThe
            // 
            this.lbl_LoaiThe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LoaiThe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_LoaiThe.Location = new System.Drawing.Point(27, 236);
            this.lbl_LoaiThe.Name = "lbl_LoaiThe";
            this.lbl_LoaiThe.Size = new System.Drawing.Size(140, 20);
            this.lbl_LoaiThe.TabIndex = 67;
            this.lbl_LoaiThe.Text = "Loại thẻ";
            this.lbl_LoaiThe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TenChuThe
            // 
            this.lbl_TenChuThe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TenChuThe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_TenChuThe.Location = new System.Drawing.Point(27, 173);
            this.lbl_TenChuThe.Name = "lbl_TenChuThe";
            this.lbl_TenChuThe.Size = new System.Drawing.Size(140, 20);
            this.lbl_TenChuThe.TabIndex = 66;
            this.lbl_TenChuThe.Text = "Tên chủ thẻ";
            this.lbl_TenChuThe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SoThe
            // 
            this.lbl_SoThe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SoThe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbl_SoThe.Location = new System.Drawing.Point(27, 142);
            this.lbl_SoThe.Name = "lbl_SoThe";
            this.lbl_SoThe.Size = new System.Drawing.Size(140, 20);
            this.lbl_SoThe.TabIndex = 65;
            this.lbl_SoThe.Text = "Số thẻ";
            this.lbl_SoThe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::VVPosS.Properties.Resources.backgroud;
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.lbl_TongTien);
            this.panel2.Controls.Add(this.lblTongTienPX);
            this.panel2.Controls.Add(this.lblDaThanhToan);
            this.panel2.Controls.Add(this.lbl_DaThanhToan);
            this.panel2.Location = new System.Drawing.Point(2, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 82);
            this.panel2.TabIndex = 79;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImage = global::VVPosS.Properties.Resources.save_delete_cancel_button;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Image = global::VVPosS.Properties.Resources.them_icon;
            this.btnThem.Location = new System.Drawing.Point(26, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 48);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.lbl_TongTien.Location = new System.Drawing.Point(509, 12);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(148, 25);
            this.lbl_TongTien.TabIndex = 42;
            this.lbl_TongTien.Text = "Tổng tiền : ";
            this.lbl_TongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTienPX
            // 
            this.lblTongTienPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienPX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.lblTongTienPX.Location = new System.Drawing.Point(654, 12);
            this.lblTongTienPX.Name = "lblTongTienPX";
            this.lblTongTienPX.Size = new System.Drawing.Size(142, 25);
            this.lblTongTienPX.TabIndex = 41;
            this.lblTongTienPX.Text = "100.000";
            this.lblTongTienPX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDaThanhToan
            // 
            this.lblDaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.lblDaThanhToan.Location = new System.Drawing.Point(654, 45);
            this.lblDaThanhToan.Name = "lblDaThanhToan";
            this.lblDaThanhToan.Size = new System.Drawing.Size(142, 25);
            this.lblDaThanhToan.TabIndex = 43;
            this.lblDaThanhToan.Text = "00.00";
            this.lblDaThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_DaThanhToan
            // 
            this.lbl_DaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DaThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.lbl_DaThanhToan.Location = new System.Drawing.Point(464, 45);
            this.lbl_DaThanhToan.Name = "lbl_DaThanhToan";
            this.lbl_DaThanhToan.Size = new System.Drawing.Size(193, 25);
            this.lbl_DaThanhToan.TabIndex = 44;
            this.lbl_DaThanhToan.Text = "Đã thanh toán: ";
            this.lbl_DaThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = global::VVPosS.Properties.Resources.thoat_icon;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(697, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 48);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtg_BankCard_No,
            this.Column1,
            this.dtg_BankCard_Infomartion,
            this.dtg_BankCard_Transation,
            this.dtg_BankCard_Total,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.dtg_BankCard_Delete});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(3, 435);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Size = new System.Drawing.Size(827, 210);
            this.dataGridView.TabIndex = 80;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // dtg_BankCard_No
            // 
            this.dtg_BankCard_No.HeaderText = "STT";
            this.dtg_BankCard_No.Name = "dtg_BankCard_No";
            this.dtg_BankCard_No.ReadOnly = true;
            this.dtg_BankCard_No.Width = 45;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // dtg_BankCard_Infomartion
            // 
            this.dtg_BankCard_Infomartion.HeaderText = "Thông tin thẻ";
            this.dtg_BankCard_Infomartion.Name = "dtg_BankCard_Infomartion";
            this.dtg_BankCard_Infomartion.ReadOnly = true;
            this.dtg_BankCard_Infomartion.Width = 286;
            // 
            // dtg_BankCard_Transation
            // 
            this.dtg_BankCard_Transation.HeaderText = "Thông tin Transaction";
            this.dtg_BankCard_Transation.Name = "dtg_BankCard_Transation";
            this.dtg_BankCard_Transation.ReadOnly = true;
            this.dtg_BankCard_Transation.Width = 286;
            // 
            // dtg_BankCard_Total
            // 
            this.dtg_BankCard_Total.HeaderText = "Số tiền TT";
            this.dtg_BankCard_Total.Name = "dtg_BankCard_Total";
            this.dtg_BankCard_Total.ReadOnly = true;
            this.dtg_BankCard_Total.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CardNo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CardHolderName";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ExpiredDate";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CardType";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Bank";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "TerminalId";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "MerchantId";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "TransType";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "BatchNo";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "TraceNo";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "RefNo";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "AppCode";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Visible = false;
            // 
            // dtg_BankCard_Delete
            // 
            this.dtg_BankCard_Delete.HeaderText = "Xóa";
            this.dtg_BankCard_Delete.Image = global::VVPosS.Properties.Resources.delete_icon;
            this.dtg_BankCard_Delete.Name = "dtg_BankCard_Delete";
            this.dtg_BankCard_Delete.ReadOnly = true;
            this.dtg_BankCard_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_BankCard_Delete.Width = 88;
            // 
            // txtSoTienTT
            // 
            this.txtSoTienTT.AllowNegative = false;
            this.txtSoTienTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTienTT.Location = new System.Drawing.Point(176, 298);
            this.txtSoTienTT.Name = "txtSoTienTT";
            this.txtSoTienTT.NumericPrecision = 15;
            this.txtSoTienTT.NumericScaleOnFocus = 0;
            this.txtSoTienTT.NumericScaleOnLostFocus = 0;
            this.txtSoTienTT.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoTienTT.Size = new System.Drawing.Size(227, 26);
            this.txtSoTienTT.TabIndex = 81;
            this.txtSoTienTT.Text = "0";
            this.txtSoTienTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoTienTT.ZeroIsValid = false;
            // 
            // frmBankingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(160)))));
            this.BackgroundImage = global::VVPosS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 647);
            this.ControlBox = false;
            this.Controls.Add(this.txtSoTienTT);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtMerchantID);
            this.Controls.Add(this.lbl_MerchantID);
            this.Controls.Add(this.txtTransType);
            this.Controls.Add(this.lbl_TransactionType);
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(this.lbl_BatchNo);
            this.Controls.Add(this.txtAppCode);
            this.Controls.Add(this.lbl_AppCode);
            this.Controls.Add(this.txtRefNo);
            this.Controls.Add(this.lbl_RefNo);
            this.Controls.Add(this.cbbBank);
            this.Controls.Add(this.lbl_NganHang);
            this.Controls.Add(this.txtTraceNo);
            this.Controls.Add(this.lbl_TraceNo);
            this.Controls.Add(this.txtTerminalId);
            this.Controls.Add(this.lbl_SoMayPOS);
            this.Controls.Add(this.cbbCardType);
            this.Controls.Add(this.txtExpiredDate);
            this.Controls.Add(this.lbl_NgayHetHan);
            this.Controls.Add(this.txtCardHolderName);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.lbl_SoTienThanhToan);
            this.Controls.Add(this.lbl_LoaiThe);
            this.Controls.Add(this.lbl_TenChuThe);
            this.Controls.Add(this.lbl_SoThe);
            this.Controls.Add(this.lbDesk);
            this.Controls.Add(this.lbTittle1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankingCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBankingCard_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTittle1;
        private System.Windows.Forms.Label lbDesk;
        private System.Windows.Forms.TextBox txtMerchantID;
        private System.Windows.Forms.Label lbl_MerchantID;
        private System.Windows.Forms.TextBox txtTransType;
        private System.Windows.Forms.Label lbl_TransactionType;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Label lbl_BatchNo;
        private System.Windows.Forms.TextBox txtAppCode;
        private System.Windows.Forms.Label lbl_AppCode;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label lbl_RefNo;
        private System.Windows.Forms.ComboBox cbbBank;
        private System.Windows.Forms.Label lbl_NganHang;
        private System.Windows.Forms.TextBox txtTraceNo;
        private System.Windows.Forms.Label lbl_TraceNo;
        private System.Windows.Forms.TextBox txtTerminalId;
        private System.Windows.Forms.Label lbl_SoMayPOS;
        private System.Windows.Forms.ComboBox cbbCardType;
        private System.Windows.Forms.TextBox txtExpiredDate;
        private System.Windows.Forms.Label lbl_NgayHetHan;
        private System.Windows.Forms.TextBox txtCardHolderName;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lbl_SoTienThanhToan;
        private System.Windows.Forms.Label lbl_LoaiThe;
        private System.Windows.Forms.Label lbl_TenChuThe;
        private System.Windows.Forms.Label lbl_SoThe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label lblTongTienPX;
        private System.Windows.Forms.Label lblDaThanhToan;
        private System.Windows.Forms.Label lbl_DaThanhToan;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_BankCard_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_BankCard_Infomartion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_BankCard_Transation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_BankCard_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewImageColumn dtg_BankCard_Delete;
        private Controls.NumericTextBox txtSoTienTT;

        //private System.Windows.Forms.CheckedListBox lstMemberType;
        //private System.Windows.Forms.TextBox txtSoTienTT;
    }
}