namespace VVPosS.Screen.POS
{
    partial class frmManageBankCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageBankCard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbBank = new System.Windows.Forms.ComboBox();
            this.lbl_NganHang = new System.Windows.Forms.Label();
            this.cbbCardType = new System.Windows.Forms.ComboBox();
            this.txtExpiredDate = new System.Windows.Forms.TextBox();
            this.lbl_NgayHetHan = new System.Windows.Forms.Label();
            this.txtCardHolderName = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lbl_LoaiThe = new System.Windows.Forms.Label();
            this.lbl_TenChuThe = new System.Windows.Forms.Label();
            this.lbl_SoThe = new System.Windows.Forms.Label();
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
            this.txtTraceNo = new System.Windows.Forms.TextBox();
            this.lbl_TraceNo = new System.Windows.Forms.Label();
            this.txtTerminalId = new System.Windows.Forms.TextBox();
            this.lbl_SoMayPOS = new System.Windows.Forms.Label();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.lbCreaDate = new System.Windows.Forms.Label();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.linkNumber = new System.Windows.Forms.LinkLabel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.lblTB = new System.Windows.Forms.Label();
            this.lblTB1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_receiptId = new System.Windows.Forms.Label();
            this.txtReceiptId = new System.Windows.Forms.TextBox();
            this.pButton = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoTran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbBank
            // 
            this.cbbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBank.FormattingEnabled = true;
            this.cbbBank.Location = new System.Drawing.Point(177, 77);
            this.cbbBank.Name = "cbbBank";
            this.cbbBank.Size = new System.Drawing.Size(211, 24);
            this.cbbBank.TabIndex = 37;
            this.cbbBank.SelectedIndexChanged += new System.EventHandler(this.cbbBank_SelectedIndexChanged);
            // 
            // lbl_NganHang
            // 
            this.lbl_NganHang.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NganHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NganHang.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_NganHang.Location = new System.Drawing.Point(24, 84);
            this.lbl_NganHang.Name = "lbl_NganHang";
            this.lbl_NganHang.Size = new System.Drawing.Size(140, 20);
            this.lbl_NganHang.TabIndex = 46;
            this.lbl_NganHang.Text = "Ngân hàng";
            this.lbl_NganHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbCardType
            // 
            this.cbbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCardType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCardType.FormattingEnabled = true;
            this.cbbCardType.Location = new System.Drawing.Point(177, 207);
            this.cbbCardType.Name = "cbbCardType";
            this.cbbCardType.Size = new System.Drawing.Size(211, 24);
            this.cbbCardType.TabIndex = 41;
            // 
            // txtExpiredDate
            // 
            this.txtExpiredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiredDate.Location = new System.Drawing.Point(177, 175);
            this.txtExpiredDate.Name = "txtExpiredDate";
            this.txtExpiredDate.Size = new System.Drawing.Size(211, 22);
            this.txtExpiredDate.TabIndex = 40;
            // 
            // lbl_NgayHetHan
            // 
            this.lbl_NgayHetHan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayHetHan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_NgayHetHan.Location = new System.Drawing.Point(24, 176);
            this.lbl_NgayHetHan.Name = "lbl_NgayHetHan";
            this.lbl_NgayHetHan.Size = new System.Drawing.Size(140, 20);
            this.lbl_NgayHetHan.TabIndex = 45;
            this.lbl_NgayHetHan.Text = "Ngày hết hạn";
            this.lbl_NgayHetHan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCardHolderName
            // 
            this.txtCardHolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardHolderName.Location = new System.Drawing.Point(177, 141);
            this.txtCardHolderName.Name = "txtCardHolderName";
            this.txtCardHolderName.Size = new System.Drawing.Size(211, 22);
            this.txtCardHolderName.TabIndex = 39;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNo.Location = new System.Drawing.Point(177, 109);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(211, 22);
            this.txtCardNo.TabIndex = 38;
            // 
            // lbl_LoaiThe
            // 
            this.lbl_LoaiThe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LoaiThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoaiThe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_LoaiThe.Location = new System.Drawing.Point(24, 210);
            this.lbl_LoaiThe.Name = "lbl_LoaiThe";
            this.lbl_LoaiThe.Size = new System.Drawing.Size(140, 20);
            this.lbl_LoaiThe.TabIndex = 44;
            this.lbl_LoaiThe.Text = "Loại thẻ";
            this.lbl_LoaiThe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TenChuThe
            // 
            this.lbl_TenChuThe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TenChuThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenChuThe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TenChuThe.Location = new System.Drawing.Point(24, 144);
            this.lbl_TenChuThe.Name = "lbl_TenChuThe";
            this.lbl_TenChuThe.Size = new System.Drawing.Size(140, 20);
            this.lbl_TenChuThe.TabIndex = 43;
            this.lbl_TenChuThe.Text = "Tên chủ thẻ";
            this.lbl_TenChuThe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SoThe
            // 
            this.lbl_SoThe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SoThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoThe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_SoThe.Location = new System.Drawing.Point(24, 114);
            this.lbl_SoThe.Name = "lbl_SoThe";
            this.lbl_SoThe.Size = new System.Drawing.Size(140, 20);
            this.lbl_SoThe.TabIndex = 42;
            this.lbl_SoThe.Text = "Số thẻ";
            this.lbl_SoThe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMerchantID
            // 
            this.txtMerchantID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerchantID.Location = new System.Drawing.Point(582, 141);
            this.txtMerchantID.Name = "txtMerchantID";
            this.txtMerchantID.Size = new System.Drawing.Size(211, 22);
            this.txtMerchantID.TabIndex = 56;
            // 
            // lbl_MerchantID
            // 
            this.lbl_MerchantID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MerchantID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MerchantID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_MerchantID.Location = new System.Drawing.Point(445, 144);
            this.lbl_MerchantID.Name = "lbl_MerchantID";
            this.lbl_MerchantID.Size = new System.Drawing.Size(125, 16);
            this.lbl_MerchantID.TabIndex = 66;
            this.lbl_MerchantID.Text = "Merchant ID";
            this.lbl_MerchantID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTransType
            // 
            this.txtTransType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransType.Location = new System.Drawing.Point(582, 109);
            this.txtTransType.Name = "txtTransType";
            this.txtTransType.Size = new System.Drawing.Size(211, 22);
            this.txtTransType.TabIndex = 55;
            // 
            // lbl_TransactionType
            // 
            this.lbl_TransactionType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransactionType.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TransactionType.Location = new System.Drawing.Point(410, 114);
            this.lbl_TransactionType.Name = "lbl_TransactionType";
            this.lbl_TransactionType.Size = new System.Drawing.Size(160, 16);
            this.lbl_TransactionType.TabIndex = 65;
            this.lbl_TransactionType.Text = "Transaction Type";
            this.lbl_TransactionType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNo.Location = new System.Drawing.Point(582, 77);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(211, 22);
            this.txtBatchNo.TabIndex = 54;
            // 
            // lbl_BatchNo
            // 
            this.lbl_BatchNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BatchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BatchNo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_BatchNo.Location = new System.Drawing.Point(458, 84);
            this.lbl_BatchNo.Name = "lbl_BatchNo";
            this.lbl_BatchNo.Size = new System.Drawing.Size(112, 16);
            this.lbl_BatchNo.TabIndex = 64;
            this.lbl_BatchNo.Text = "Batch No.";
            this.lbl_BatchNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAppCode
            // 
            this.txtAppCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppCode.Location = new System.Drawing.Point(582, 47);
            this.txtAppCode.Name = "txtAppCode";
            this.txtAppCode.Size = new System.Drawing.Size(211, 22);
            this.txtAppCode.TabIndex = 53;
            // 
            // lbl_AppCode
            // 
            this.lbl_AppCode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AppCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AppCode.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_AppCode.Location = new System.Drawing.Point(455, 55);
            this.lbl_AppCode.Name = "lbl_AppCode";
            this.lbl_AppCode.Size = new System.Drawing.Size(115, 16);
            this.lbl_AppCode.TabIndex = 63;
            this.lbl_AppCode.Text = "App Code";
            this.lbl_AppCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRefNo
            // 
            this.txtRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNo.Location = new System.Drawing.Point(581, 239);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(211, 22);
            this.txtRefNo.TabIndex = 59;
            // 
            // lbl_RefNo
            // 
            this.lbl_RefNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RefNo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_RefNo.Location = new System.Drawing.Point(475, 240);
            this.lbl_RefNo.Name = "lbl_RefNo";
            this.lbl_RefNo.Size = new System.Drawing.Size(95, 16);
            this.lbl_RefNo.TabIndex = 62;
            this.lbl_RefNo.Text = "Số Ref";
            this.lbl_RefNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTraceNo
            // 
            this.txtTraceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraceNo.Location = new System.Drawing.Point(582, 207);
            this.txtTraceNo.Name = "txtTraceNo";
            this.txtTraceNo.Size = new System.Drawing.Size(211, 22);
            this.txtTraceNo.TabIndex = 58;
            // 
            // lbl_TraceNo
            // 
            this.lbl_TraceNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TraceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TraceNo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TraceNo.Location = new System.Drawing.Point(411, 210);
            this.lbl_TraceNo.Name = "lbl_TraceNo";
            this.lbl_TraceNo.Size = new System.Drawing.Size(159, 16);
            this.lbl_TraceNo.TabIndex = 61;
            this.lbl_TraceNo.Text = "Số Bill / Trace No";
            this.lbl_TraceNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTerminalId
            // 
            this.txtTerminalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminalId.Location = new System.Drawing.Point(582, 175);
            this.txtTerminalId.Name = "txtTerminalId";
            this.txtTerminalId.Size = new System.Drawing.Size(211, 22);
            this.txtTerminalId.TabIndex = 57;
            // 
            // lbl_SoMayPOS
            // 
            this.lbl_SoMayPOS.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SoMayPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoMayPOS.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_SoMayPOS.Location = new System.Drawing.Point(443, 176);
            this.lbl_SoMayPOS.Name = "lbl_SoMayPOS";
            this.lbl_SoMayPOS.Size = new System.Drawing.Size(127, 16);
            this.lbl_SoMayPOS.TabIndex = 60;
            this.lbl_SoMayPOS.Text = "Số máy Pos";
            this.lbl_SoMayPOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCreateDate.Enabled = false;
            this.dtpCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreateDate.Location = new System.Drawing.Point(177, 239);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(211, 22);
            this.dtpCreateDate.TabIndex = 67;
            // 
            // lbCreaDate
            // 
            this.lbCreaDate.BackColor = System.Drawing.Color.Transparent;
            this.lbCreaDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreaDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbCreaDate.Location = new System.Drawing.Point(73, 240);
            this.lbCreaDate.Name = "lbCreaDate";
            this.lbCreaDate.Size = new System.Drawing.Size(88, 16);
            this.lbCreaDate.TabIndex = 68;
            this.lbCreaDate.Text = "Ngày tạo";
            this.lbCreaDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDate.Location = new System.Drawing.Point(42, 242);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(15, 14);
            this.chkDate.TabIndex = 74;
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // linkNumber
            // 
            this.linkNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.linkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNumber.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.linkNumber.Location = new System.Drawing.Point(676, 368);
            this.linkNumber.Name = "linkNumber";
            this.linkNumber.Size = new System.Drawing.Size(51, 38);
            this.linkNumber.TabIndex = 77;
            this.linkNumber.TabStop = true;
            this.linkNumber.Text = "0";
            this.linkNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(76)))));
            this.btnNext.Image = global::VVPosS.Properties.Resources.next_icon;
            this.btnNext.Location = new System.Drawing.Point(738, 367);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 40);
            this.btnNext.TabIndex = 76;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPre.BackgroundImage")));
            this.btnPre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPre.FlatAppearance.BorderSize = 0;
            this.btnPre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(76)))));
            this.btnPre.Image = global::VVPosS.Properties.Resources.previous_icon;
            this.btnPre.Location = new System.Drawing.Point(610, 367);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(53, 40);
            this.btnPre.TabIndex = 75;
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // lblTB
            // 
            this.lblTB.BackColor = System.Drawing.Color.Transparent;
            this.lblTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTB.Location = new System.Drawing.Point(204, 392);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(308, 28);
            this.lblTB.TabIndex = 79;
            this.lblTB.Text = "...";
            // 
            // lblTB1
            // 
            this.lblTB1.BackColor = System.Drawing.Color.Transparent;
            this.lblTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTB1.Location = new System.Drawing.Point(204, 355);
            this.lblTB1.Name = "lblTB1";
            this.lblTB1.Size = new System.Drawing.Size(308, 28);
            this.lblTB1.TabIndex = 78;
            this.lblTB1.Text = "...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 42);
            this.panel1.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(834, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản lý thẻ ngân hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_receiptId
            // 
            this.lbl_receiptId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_receiptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receiptId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_receiptId.Location = new System.Drawing.Point(39, 55);
            this.lbl_receiptId.Name = "lbl_receiptId";
            this.lbl_receiptId.Size = new System.Drawing.Size(125, 22);
            this.lbl_receiptId.TabIndex = 81;
            this.lbl_receiptId.Text = "ReceiptId";
            this.lbl_receiptId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReceiptId
            // 
            this.txtReceiptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptId.Location = new System.Drawing.Point(177, 47);
            this.txtReceiptId.Name = "txtReceiptId";
            this.txtReceiptId.Size = new System.Drawing.Size(211, 22);
            this.txtReceiptId.TabIndex = 82;
            // 
            // pButton
            // 
            this.pButton.BackgroundImage = global::VVPosS.Properties.Resources.backgroud;
            this.pButton.Controls.Add(this.btnExit);
            this.pButton.Controls.Add(this.btnReset);
            this.pButton.Controls.Add(this.btnUpdate);
            this.pButton.Controls.Add(this.btnSearch);
            this.pButton.Location = new System.Drawing.Point(0, 270);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(834, 82);
            this.pButton.TabIndex = 85;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = global::VVPosS.Properties.Resources.thoat_icon;
            this.btnExit.Location = new System.Drawing.Point(671, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 61);
            this.btnExit.TabIndex = 80;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Image = global::VVPosS.Properties.Resources.naplai_icon;
            this.btnReset.Location = new System.Drawing.Point(569, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 61);
            this.btnReset.TabIndex = 79;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = global::VVPosS.Properties.Resources.save_button;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = global::VVPosS.Properties.Resources.save_icon;
            this.btnUpdate.Location = new System.Drawing.Point(467, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 61);
            this.btnUpdate.TabIndex = 78;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::VVPosS.Properties.Resources.tinkiem_icon;
            this.btnSearch.Location = new System.Drawing.Point(365, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 61);
            this.btnSearch.TabIndex = 77;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Id,
            this.ReceiptId,
            this.InfoCard,
            this.InfoTran,
            this.TotalAmount,
            this.InfoCreate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(0, 439);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgv.Size = new System.Drawing.Size(833, 208);
            this.dgv.TabIndex = 86;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ReceiptId
            // 
            this.ReceiptId.HeaderText = "ReceiptId";
            this.ReceiptId.Name = "ReceiptId";
            this.ReceiptId.ReadOnly = true;
            this.ReceiptId.Width = 150;
            // 
            // InfoCard
            // 
            this.InfoCard.HeaderText = "Thông tin thẻ";
            this.InfoCard.Name = "InfoCard";
            this.InfoCard.ReadOnly = true;
            this.InfoCard.Width = 180;
            // 
            // InfoTran
            // 
            this.InfoTran.HeaderText = "Thông tin giao dịch";
            this.InfoTran.Name = "InfoTran";
            this.InfoTran.ReadOnly = true;
            this.InfoTran.Width = 180;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 120;
            // 
            // InfoCreate
            // 
            this.InfoCreate.HeaderText = "InfoCreate";
            this.InfoCreate.Name = "InfoCreate";
            this.InfoCreate.ReadOnly = true;
            this.InfoCreate.Width = 150;
            // 
            // frmManageBankCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::VVPosS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 647);
            this.ControlBox = false;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.txtReceiptId);
            this.Controls.Add(this.lbl_receiptId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.lblTB1);
            this.Controls.Add(this.linkNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.chkDate);
            this.Controls.Add(this.lbCreaDate);
            this.Controls.Add(this.dtpCreateDate);
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
            this.Controls.Add(this.txtTraceNo);
            this.Controls.Add(this.lbl_TraceNo);
            this.Controls.Add(this.txtTerminalId);
            this.Controls.Add(this.lbl_SoMayPOS);
            this.Controls.Add(this.cbbBank);
            this.Controls.Add(this.lbl_NganHang);
            this.Controls.Add(this.cbbCardType);
            this.Controls.Add(this.txtExpiredDate);
            this.Controls.Add(this.lbl_NgayHetHan);
            this.Controls.Add(this.txtCardHolderName);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.lbl_LoaiThe);
            this.Controls.Add(this.lbl_TenChuThe);
            this.Controls.Add(this.lbl_SoThe);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageBankCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmManageBankCard_Load);
            this.panel1.ResumeLayout(false);
            this.pButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbBank;
        private System.Windows.Forms.Label lbl_NganHang;
        private System.Windows.Forms.ComboBox cbbCardType;
        private System.Windows.Forms.TextBox txtExpiredDate;
        private System.Windows.Forms.Label lbl_NgayHetHan;
        private System.Windows.Forms.TextBox txtCardHolderName;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lbl_LoaiThe;
        private System.Windows.Forms.Label lbl_TenChuThe;
        private System.Windows.Forms.Label lbl_SoThe;
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
        private System.Windows.Forms.TextBox txtTraceNo;
        private System.Windows.Forms.Label lbl_TraceNo;
        private System.Windows.Forms.TextBox txtTerminalId;
        private System.Windows.Forms.Label lbl_SoMayPOS;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.Label lbCreaDate;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Label lblTB1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_receiptId;
        private System.Windows.Forms.TextBox txtReceiptId;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoTran;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoCreate;
    }
}