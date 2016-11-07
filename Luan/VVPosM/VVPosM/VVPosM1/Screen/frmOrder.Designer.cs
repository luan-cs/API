namespace VVPosM1.Screen
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDeskNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCreatedDate2 = new System.Windows.Forms.DateTimePicker();
            this.tbCreatedBy = new System.Windows.Forms.TextBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.gbIsrint = new System.Windows.Forms.GroupBox();
            this.rbn0 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.cbIsPrint = new System.Windows.Forms.CheckBox();
            this.lblTB = new System.Windows.Forms.Label();
            this.linkNumber = new System.Windows.Forms.LinkLabel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbTotalMoney = new System.Windows.Forms.TextBox();
            this.tbDisCount = new System.Windows.Forms.TextBox();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.tbTotalAmount = new System.Windows.Forms.TextBox();
            this.lbDisCount = new System.Windows.Forms.Label();
            this.cbCreatedDate = new System.Windows.Forms.CheckBox();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.dtpCreatedDate1 = new System.Windows.Forms.DateTimePicker();
            this.lbDeskId = new System.Windows.Forms.Label();
            this.gbOrderDetail = new System.Windows.Forms.GroupBox();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.STT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsPrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PrintPlace = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PrintKitchen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.gbIsrint.SuspendLayout();
            this.gbOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOrderId
            // 
            this.tbOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderId.Location = new System.Drawing.Point(243, 4);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(310, 29);
            this.tbOrderId.TabIndex = 3;
            // 
            // lbOrderId
            // 
            this.lbOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderId.Location = new System.Drawing.Point(77, 7);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(147, 16);
            this.lbOrderId.TabIndex = 2;
            this.lbOrderId.Text = "Mã hóa đơn";
            this.lbOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbDeskNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpCreatedDate2);
            this.panel1.Controls.Add(this.tbCreatedBy);
            this.panel1.Controls.Add(this.lbCreatedBy);
            this.panel1.Controls.Add(this.gbIsrint);
            this.panel1.Controls.Add(this.cbIsPrint);
            this.panel1.Controls.Add(this.lblTB);
            this.panel1.Controls.Add(this.linkNumber);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPre);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbTotalMoney);
            this.panel1.Controls.Add(this.tbDisCount);
            this.panel1.Controls.Add(this.lbTotalMoney);
            this.panel1.Controls.Add(this.tbTotalAmount);
            this.panel1.Controls.Add(this.lbDisCount);
            this.panel1.Controls.Add(this.cbCreatedDate);
            this.panel1.Controls.Add(this.lbTotalAmount);
            this.panel1.Controls.Add(this.dtpCreatedDate1);
            this.panel1.Controls.Add(this.lbOrderId);
            this.panel1.Controls.Add(this.lbDeskId);
            this.panel1.Controls.Add(this.tbOrderId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 184);
            this.panel1.TabIndex = 4;
            // 
            // cbDeskNo
            // 
            this.cbDeskNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeskNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDeskNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeskNo.FormattingEnabled = true;
            this.cbDeskNo.Location = new System.Drawing.Point(243, 35);
            this.cbDeskNo.Name = "cbDeskNo";
            this.cbDeskNo.Size = new System.Drawing.Size(310, 23);
            this.cbDeskNo.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 87;
            this.label1.Text = "-";
            // 
            // dtpCreatedDate2
            // 
            this.dtpCreatedDate2.CustomFormat = "dd/MM/yyyy";
            this.dtpCreatedDate2.Enabled = false;
            this.dtpCreatedDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreatedDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedDate2.Location = new System.Drawing.Point(415, 89);
            this.dtpCreatedDate2.Name = "dtpCreatedDate2";
            this.dtpCreatedDate2.Size = new System.Drawing.Size(138, 26);
            this.dtpCreatedDate2.TabIndex = 86;
            // 
            // tbCreatedBy
            // 
            this.tbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCreatedBy.Location = new System.Drawing.Point(243, 59);
            this.tbCreatedBy.Name = "tbCreatedBy";
            this.tbCreatedBy.Size = new System.Drawing.Size(310, 29);
            this.tbCreatedBy.TabIndex = 85;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(101, 63);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(123, 16);
            this.lbCreatedBy.TabIndex = 84;
            this.lbCreatedBy.Text = "Tạo bởi";
            this.lbCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbIsrint
            // 
            this.gbIsrint.Controls.Add(this.rbn0);
            this.gbIsrint.Controls.Add(this.rb1);
            this.gbIsrint.Enabled = false;
            this.gbIsrint.Location = new System.Drawing.Point(755, 91);
            this.gbIsrint.Name = "gbIsrint";
            this.gbIsrint.Size = new System.Drawing.Size(315, 39);
            this.gbIsrint.TabIndex = 83;
            this.gbIsrint.TabStop = false;
            // 
            // rbn0
            // 
            this.rbn0.AutoSize = true;
            this.rbn0.Location = new System.Drawing.Point(194, 13);
            this.rbn0.Name = "rbn0";
            this.rbn0.Size = new System.Drawing.Size(61, 17);
            this.rbn0.TabIndex = 1;
            this.rbn0.Text = "Chưa in";
            this.rbn0.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(56, 13);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(50, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Đã in";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // cbIsPrint
            // 
            this.cbIsPrint.AutoSize = true;
            this.cbIsPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsPrint.Location = new System.Drawing.Point(703, 104);
            this.cbIsPrint.Name = "cbIsPrint";
            this.cbIsPrint.Size = new System.Drawing.Size(37, 20);
            this.cbIsPrint.TabIndex = 82;
            this.cbIsPrint.Text = "In";
            this.cbIsPrint.UseVisualStyleBackColor = true;
            this.cbIsPrint.CheckedChanged += new System.EventHandler(this.cbIsPrint_CheckedChanged);
            // 
            // lblTB
            // 
            this.lblTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTB.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB.Location = new System.Drawing.Point(808, 149);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(313, 28);
            this.lblTB.TabIndex = 78;
            this.lblTB.Text = "...";
            this.lblTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkNumber
            // 
            this.linkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNumber.Location = new System.Drawing.Point(507, 143);
            this.linkNumber.Name = "linkNumber";
            this.linkNumber.Size = new System.Drawing.Size(46, 20);
            this.linkNumber.TabIndex = 80;
            this.linkNumber.TabStop = true;
            this.linkNumber.Text = "1";
            this.linkNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(559, 134);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 33);
            this.btnNext.TabIndex = 79;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPre.ForeColor = System.Drawing.Color.Transparent;
            this.btnPre.Location = new System.Drawing.Point(426, 135);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 32);
            this.btnPre.TabIndex = 76;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.Image = global::VVPosM1.Properties.Resources._1404382393_icon_ios7_undo;
            this.btnReset.Location = new System.Drawing.Point(197, 118);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 51);
            this.btnReset.TabIndex = 73;
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
            this.btnExit.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(290, 118);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 51);
            this.btnExit.TabIndex = 74;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(104, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 51);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbTotalMoney
            // 
            this.tbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalMoney.Location = new System.Drawing.Point(755, 64);
            this.tbTotalMoney.Name = "tbTotalMoney";
            this.tbTotalMoney.Size = new System.Drawing.Size(315, 29);
            this.tbTotalMoney.TabIndex = 7;
            this.tbTotalMoney.TextChanged += new System.EventHandler(this.tbTotalMoney_TextChanged);
            this.tbTotalMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotalMoney_KeyPress);
            // 
            // tbDisCount
            // 
            this.tbDisCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisCount.Location = new System.Drawing.Point(755, 34);
            this.tbDisCount.Name = "tbDisCount";
            this.tbDisCount.Size = new System.Drawing.Size(315, 29);
            this.tbDisCount.TabIndex = 7;
            this.tbDisCount.TextChanged += new System.EventHandler(this.tbDisCount_TextChanged);
            this.tbDisCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDisCount_KeyPress);
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.Location = new System.Drawing.Point(560, 68);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(179, 16);
            this.lbTotalMoney.TabIndex = 6;
            this.lbTotalMoney.Text = "Tổng tiền phải trả";
            this.lbTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalAmount.Location = new System.Drawing.Point(755, 4);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.Size = new System.Drawing.Size(315, 29);
            this.tbTotalAmount.TabIndex = 7;
            this.tbTotalAmount.TextChanged += new System.EventHandler(this.tbTotalAmount_TextChanged);
            this.tbTotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotalAmount_KeyPress);
            // 
            // lbDisCount
            // 
            this.lbDisCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisCount.Location = new System.Drawing.Point(609, 38);
            this.lbDisCount.Name = "lbDisCount";
            this.lbDisCount.Size = new System.Drawing.Size(130, 16);
            this.lbDisCount.TabIndex = 6;
            this.lbDisCount.Text = "Giảm giá";
            this.lbDisCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCreatedDate
            // 
            this.cbCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCreatedDate.Location = new System.Drawing.Point(128, 89);
            this.cbCreatedDate.Name = "cbCreatedDate";
            this.cbCreatedDate.Size = new System.Drawing.Size(104, 20);
            this.cbCreatedDate.TabIndex = 6;
            this.cbCreatedDate.Text = "Ngày tạo";
            this.cbCreatedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCreatedDate.UseVisualStyleBackColor = true;
            this.cbCreatedDate.CheckedChanged += new System.EventHandler(this.cbCreatedDate_CheckedChanged);
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.Location = new System.Drawing.Point(607, 7);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(132, 16);
            this.lbTotalAmount.TabIndex = 6;
            this.lbTotalAmount.Text = "Tổng tiền";
            this.lbTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCreatedDate1
            // 
            this.dtpCreatedDate1.CustomFormat = "dd/MM/yyyy";
            this.dtpCreatedDate1.Enabled = false;
            this.dtpCreatedDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreatedDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedDate1.Location = new System.Drawing.Point(243, 89);
            this.dtpCreatedDate1.Name = "dtpCreatedDate1";
            this.dtpCreatedDate1.Size = new System.Drawing.Size(138, 26);
            this.dtpCreatedDate1.TabIndex = 5;
            // 
            // lbDeskId
            // 
            this.lbDeskId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeskId.Location = new System.Drawing.Point(105, 38);
            this.lbDeskId.Name = "lbDeskId";
            this.lbDeskId.Size = new System.Drawing.Size(119, 16);
            this.lbDeskId.TabIndex = 5;
            this.lbDeskId.Text = "Số bàn";
            this.lbDeskId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbOrderDetail
            // 
            this.gbOrderDetail.Controls.Add(this.dgvOrderDetail);
            this.gbOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderDetail.Location = new System.Drawing.Point(678, 193);
            this.gbOrderDetail.Name = "gbOrderDetail";
            this.gbOrderDetail.Size = new System.Drawing.Size(528, 461);
            this.gbOrderDetail.TabIndex = 6;
            this.gbOrderDetail.TabStop = false;
            this.gbOrderDetail.Text = "Chi tiết đơn đặt hàng";
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.AllowUserToDeleteRows = false;
            this.dgvOrderDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrderDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT2,
            this.OrderId2,
            this.NameProduct,
            this.Unit,
            this.Quantity,
            this.Price,
            this.TotalAmount1});
            this.dgvOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetail.EnableHeadersVisualStyles = false;
            this.dgvOrderDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDetail.Size = new System.Drawing.Size(522, 441);
            this.dgvOrderDetail.TabIndex = 0;
            // 
            // STT2
            // 
            this.STT2.HeaderText = "STT";
            this.STT2.Name = "STT2";
            this.STT2.ReadOnly = true;
            this.STT2.Width = 50;
            // 
            // OrderId2
            // 
            this.OrderId2.HeaderText = "OrderID";
            this.OrderId2.Name = "OrderId2";
            this.OrderId2.ReadOnly = true;
            this.OrderId2.Visible = false;
            // 
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Tên sản phẩm";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Đơn vị tính";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 80;
            // 
            // Price
            // 
            this.Price.HeaderText = "Đơn giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TotalAmount1
            // 
            this.TotalAmount1.HeaderText = "Tổng tiền";
            this.TotalAmount1.Name = "TotalAmount1";
            this.TotalAmount1.ReadOnly = true;
            this.TotalAmount1.Width = 150;
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.dgvResult);
            this.gbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrder.Location = new System.Drawing.Point(0, 193);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(675, 461);
            this.gbOrder.TabIndex = 7;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Danh sách đơn đặt hàng";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.OrderId,
            this.DeskNumber,
            this.Note,
            this.InfoCreate,
            this.Status,
            this.colStatus,
            this.TotalAmount,
            this.IsPrint,
            this.colIsPrint,
            this.Cancel,
            this.PrintPlace,
            this.PrintKitchen});
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(3, 17);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResult.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.Size = new System.Drawing.Size(669, 441);
            this.dgvResult.TabIndex = 0;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 40;
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "Mã hóa đơn";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            // 
            // DeskNumber
            // 
            this.DeskNumber.HeaderText = "Số bàn";
            this.DeskNumber.Name = "DeskNumber";
            this.DeskNumber.ReadOnly = true;
            this.DeskNumber.Width = 50;
            // 
            // Note
            // 
            this.Note.HeaderText = "Chú thích";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // InfoCreate
            // 
            this.InfoCreate.HeaderText = "Thông tin khởi tạo";
            this.InfoCreate.Name = "InfoCreate";
            this.InfoCreate.ReadOnly = true;
            this.InfoCreate.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Visible = false;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Tổng tiền";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 150;
            // 
            // IsPrint
            // 
            this.IsPrint.HeaderText = "Đã in";
            this.IsPrint.Name = "IsPrint";
            this.IsPrint.ReadOnly = true;
            // 
            // colIsPrint
            // 
            this.colIsPrint.HeaderText = "col Trạng thái in";
            this.colIsPrint.Name = "colIsPrint";
            this.colIsPrint.ReadOnly = true;
            this.colIsPrint.Visible = false;
            this.colIsPrint.Width = 50;
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "Hủy";
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Width = 50;
            // 
            // PrintPlace
            // 
            this.PrintPlace.HeaderText = "In phiếu tại chỗ";
            this.PrintPlace.Name = "PrintPlace";
            this.PrintPlace.ReadOnly = true;
            this.PrintPlace.Visible = false;
            this.PrintPlace.Width = 50;
            // 
            // PrintKitchen
            // 
            this.PrintKitchen.HeaderText = "In phiếu tại bếp";
            this.PrintKitchen.Name = "PrintKitchen";
            this.PrintKitchen.ReadOnly = true;
            this.PrintKitchen.Visible = false;
            this.PrintKitchen.Width = 50;
            // 
            // frmOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.ControlBox = false;
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.gbOrderDetail);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn đặt hàng";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbIsrint.ResumeLayout(false);
            this.gbIsrint.PerformLayout();
            this.gbOrderDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.gbOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate1;
        private System.Windows.Forms.Label lbDeskId;
        private System.Windows.Forms.TextBox tbTotalMoney;
        private System.Windows.Forms.TextBox tbDisCount;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.TextBox tbTotalAmount;
        private System.Windows.Forms.Label lbDisCount;
        private System.Windows.Forms.CheckBox cbCreatedDate;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.GroupBox gbOrderDetail;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox cbIsPrint;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.GroupBox gbIsrint;
        private System.Windows.Forms.RadioButton rbn0;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.TextBox tbCreatedBy;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate2;
        private System.Windows.Forms.ComboBox cbDeskNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsPrint;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.DataGridViewButtonColumn PrintPlace;
        private System.Windows.Forms.DataGridViewButtonColumn PrintKitchen;
    }
}