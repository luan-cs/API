namespace VVPosM1.Screen
{
    partial class frmInput
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ballot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngredientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pInput = new System.Windows.Forms.Panel();
            this.txtInputId = new System.Windows.Forms.TextBox();
            this.lblInputId = new System.Windows.Forms.Label();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.chbPaid = new System.Windows.Forms.CheckBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.txtReceiptId = new System.Windows.Forms.TextBox();
            this.lblReceiptDate = new System.Windows.Forms.Label();
            this.lblReceiptId = new System.Windows.Forms.Label();
            this.dtpBallotDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddMeasure = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblTB1 = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.bntReset = new System.Windows.Forms.Button();
            this.linkNumber = new System.Windows.Forms.LinkLabel();
            this.bntNext = new System.Windows.Forms.Button();
            this.bntPre = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntSeach = new System.Windows.Forms.Button();
            this.txtBollot = new System.Windows.Forms.TextBox();
            this.lblBallotDate = new System.Windows.Forms.Label();
            this.lblBollot = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.pInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.inputID,
            this.ballot,
            this.receiptId,
            this.paid,
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
            this.dgv.Size = new System.Drawing.Size(1209, 299);
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
            // inputID
            // 
            this.inputID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inputID.HeaderText = "Mã nhâp";
            this.inputID.Name = "inputID";
            this.inputID.ReadOnly = true;
            // 
            // ballot
            // 
            this.ballot.HeaderText = "Mã chứng từ";
            this.ballot.Name = "ballot";
            this.ballot.ReadOnly = true;
            this.ballot.Width = 200;
            // 
            // receiptId
            // 
            this.receiptId.HeaderText = "Mã hóa đơn";
            this.receiptId.Name = "receiptId";
            this.receiptId.ReadOnly = true;
            this.receiptId.Width = 200;
            // 
            // paid
            // 
            this.paid.HeaderText = "Trạng thái";
            this.paid.Name = "paid";
            this.paid.ReadOnly = true;
            this.paid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.paid.Width = 150;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetail);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(633, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 260);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết nhập";
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
            this.exDate,
            this.colPrice,
            this.colVat,
            this.colDiscount,
            this.colDelete});
            this.dgvDetail.Location = new System.Drawing.Point(6, 21);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.Size = new System.Drawing.Size(553, 233);
            this.dgvDetail.TabIndex = 0;
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
            this.colIngredientName.HeaderText = "Tên Nguyên Liệu";
            this.colIngredientName.Name = "colIngredientName";
            this.colIngredientName.ReadOnly = true;
            this.colIngredientName.Width = 200;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Số Lượng";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // exDate
            // 
            this.exDate.HeaderText = "Ngày hết hạn";
            this.exDate.Name = "exDate";
            this.exDate.ReadOnly = true;
            this.exDate.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colVat
            // 
            this.colVat.HeaderText = "Thuế";
            this.colVat.Name = "colVat";
            this.colVat.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Giảm giá";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
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
            // pInput
            // 
            this.pInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pInput.Controls.Add(this.txtInputId);
            this.pInput.Controls.Add(this.lblInputId);
            this.pInput.Controls.Add(this.rtbNote);
            this.pInput.Controls.Add(this.lblNote);
            this.pInput.Controls.Add(this.txtVat);
            this.pInput.Controls.Add(this.lblVat);
            this.pInput.Controls.Add(this.txtDiscount);
            this.pInput.Controls.Add(this.lblDiscount);
            this.pInput.Controls.Add(this.chbPaid);
            this.pInput.Controls.Add(this.lblPaid);
            this.pInput.Controls.Add(this.cbSupplier);
            this.pInput.Controls.Add(this.lblSupplier);
            this.pInput.Controls.Add(this.dtpReceiptDate);
            this.pInput.Controls.Add(this.txtReceiptId);
            this.pInput.Controls.Add(this.lblReceiptDate);
            this.pInput.Controls.Add(this.lblReceiptId);
            this.pInput.Controls.Add(this.dtpBallotDate);
            this.pInput.Controls.Add(this.btnAddMeasure);
            this.pInput.Controls.Add(this.groupBox2);
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
            this.pInput.Controls.Add(this.txtBollot);
            this.pInput.Controls.Add(this.lblBallotDate);
            this.pInput.Controls.Add(this.lblBollot);
            this.pInput.Location = new System.Drawing.Point(7, 0);
            this.pInput.Name = "pInput";
            this.pInput.Size = new System.Drawing.Size(1205, 399);
            this.pInput.TabIndex = 30;
            // 
            // txtInputId
            // 
            this.txtInputId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputId.Location = new System.Drawing.Point(777, 19);
            this.txtInputId.Name = "txtInputId";
            this.txtInputId.ReadOnly = true;
            this.txtInputId.Size = new System.Drawing.Size(336, 29);
            this.txtInputId.TabIndex = 84;
            // 
            // lblInputId
            // 
            this.lblInputId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputId.Location = new System.Drawing.Point(641, 22);
            this.lblInputId.Name = "lblInputId";
            this.lblInputId.Size = new System.Drawing.Size(122, 16);
            this.lblInputId.TabIndex = 85;
            this.lblInputId.Text = "Mã Nhập";
            this.lblInputId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(149, 167);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(442, 96);
            this.rtbNote.TabIndex = 83;
            this.rtbNote.Text = "";
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(46, 179);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(89, 22);
            this.lblNote.TabIndex = 82;
            this.lblNote.Text = "Ghi chú";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(453, 132);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(138, 29);
            this.txtVat.TabIndex = 81;
            this.txtVat.Text = "10";
            // 
            // lblVat
            // 
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(350, 138);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(89, 22);
            this.lblVat.TabIndex = 80;
            this.lblVat.Text = "Thuế";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(149, 132);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(138, 29);
            this.txtDiscount.TabIndex = 79;
            this.txtDiscount.Text = "0";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(46, 138);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(89, 22);
            this.lblDiscount.TabIndex = 78;
            this.lblDiscount.Text = "Giảm giá";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbPaid
            // 
            this.chbPaid.AutoSize = true;
            this.chbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPaid.Location = new System.Drawing.Point(458, 103);
            this.chbPaid.Name = "chbPaid";
            this.chbPaid.Size = new System.Drawing.Size(103, 19);
            this.chbPaid.TabIndex = 77;
            this.chbPaid.Text = "Đã thanh toán";
            this.chbPaid.UseVisualStyleBackColor = true;
            // 
            // lblPaid
            // 
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(350, 103);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(89, 22);
            this.lblPaid.TabIndex = 76;
            this.lblPaid.Text = "Trạng thái thanh toán";
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSupplier
            // 
            this.cbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(149, 99);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(138, 23);
            this.cbSupplier.TabIndex = 75;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(46, 101);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(89, 22);
            this.lblSupplier.TabIndex = 74;
            this.lblSupplier.Text = "Nhà cung cấp";
            this.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.CustomFormat = "yyyy-MM-dd";
            this.dtpReceiptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceiptDate.Location = new System.Drawing.Point(453, 60);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(138, 21);
            this.dtpReceiptDate.TabIndex = 73;
            // 
            // txtReceiptId
            // 
            this.txtReceiptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptId.Location = new System.Drawing.Point(453, 13);
            this.txtReceiptId.Name = "txtReceiptId";
            this.txtReceiptId.Size = new System.Drawing.Size(138, 29);
            this.txtReceiptId.TabIndex = 70;
            // 
            // lblReceiptDate
            // 
            this.lblReceiptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptDate.Location = new System.Drawing.Point(306, 65);
            this.lblReceiptDate.Name = "lblReceiptDate";
            this.lblReceiptDate.Size = new System.Drawing.Size(133, 16);
            this.lblReceiptDate.TabIndex = 72;
            this.lblReceiptDate.Text = "Ngày xuất hóa đơn";
            this.lblReceiptDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReceiptId
            // 
            this.lblReceiptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptId.Location = new System.Drawing.Point(337, 19);
            this.lblReceiptId.Name = "lblReceiptId";
            this.lblReceiptId.Size = new System.Drawing.Size(102, 22);
            this.lblReceiptId.TabIndex = 71;
            this.lblReceiptId.Text = "Mã hóa đơn (*)";
            this.lblReceiptId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpBallotDate
            // 
            this.dtpBallotDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBallotDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBallotDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBallotDate.Location = new System.Drawing.Point(149, 60);
            this.dtpBallotDate.Name = "dtpBallotDate";
            this.dtpBallotDate.Size = new System.Drawing.Size(138, 21);
            this.dtpBallotDate.TabIndex = 69;
            // 
            // btnAddMeasure
            // 
            this.btnAddMeasure.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAddMeasure.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddMeasure.Image = global::VVPosM1.Properties.Resources.add;
            this.btnAddMeasure.Location = new System.Drawing.Point(750, 333);
            this.btnAddMeasure.Name = "btnAddMeasure";
            this.btnAddMeasure.Size = new System.Drawing.Size(165, 51);
            this.btnAddMeasure.TabIndex = 68;
            this.btnAddMeasure.Text = "Thêm Nguyên Liệu";
            this.btnAddMeasure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMeasure.UseVisualStyleBackColor = false;
            this.btnAddMeasure.Click += new System.EventHandler(this.btnAddMeasure_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExcel.Image = global::VVPosM1.Properties.Resources._1409729156_excel;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(359, 269);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(91, 51);
            this.btnExcel.TabIndex = 11;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblTB1
            // 
            this.lblTB1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB1.Location = new System.Drawing.Point(121, 323);
            this.lblTB1.Name = "lblTB1";
            this.lblTB1.Size = new System.Drawing.Size(274, 37);
            this.lblTB1.TabIndex = 62;
            this.lblTB1.Text = "...";
            // 
            // lblTB
            // 
            this.lblTB.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB.Location = new System.Drawing.Point(121, 360);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(440, 21);
            this.lblTB.TabIndex = 61;
            this.lblTB.Text = "...";
            this.lblTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bntReset
            // 
            this.bntReset.BackColor = System.Drawing.Color.ForestGreen;
            this.bntReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntReset.Image = global::VVPosM1.Properties.Resources._1404382393_icon_ios7_undo;
            this.bntReset.Location = new System.Drawing.Point(266, 269);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(91, 51);
            this.bntReset.TabIndex = 9;
            this.bntReset.Text = "Reset";
            this.bntReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntReset.UseVisualStyleBackColor = false;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // linkNumber
            // 
            this.linkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNumber.Location = new System.Drawing.Point(1038, 362);
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
            this.bntNext.Location = new System.Drawing.Point(1090, 348);
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
            this.bntPre.Location = new System.Drawing.Point(957, 349);
            this.bntPre.Name = "bntPre";
            this.bntPre.Size = new System.Drawing.Size(75, 32);
            this.bntPre.TabIndex = 58;
            this.bntPre.Text = "<";
            this.bntPre.UseVisualStyleBackColor = false;
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.DarkRed;
            this.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntExit.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.bntExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntExit.Location = new System.Drawing.Point(453, 269);
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
            this.bntLuu.Location = new System.Drawing.Point(173, 269);
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
            this.bntSeach.Location = new System.Drawing.Point(80, 269);
            this.bntSeach.Name = "bntSeach";
            this.bntSeach.Size = new System.Drawing.Size(91, 51);
            this.bntSeach.TabIndex = 7;
            this.bntSeach.Text = "Tìm kiếm";
            this.bntSeach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntSeach.UseVisualStyleBackColor = false;
            this.bntSeach.Click += new System.EventHandler(this.bntSeach_Click);
            // 
            // txtBollot
            // 
            this.txtBollot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBollot.Location = new System.Drawing.Point(149, 13);
            this.txtBollot.Name = "txtBollot";
            this.txtBollot.Size = new System.Drawing.Size(138, 29);
            this.txtBollot.TabIndex = 0;
            // 
            // lblBallotDate
            // 
            this.lblBallotDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBallotDate.Location = new System.Drawing.Point(2, 65);
            this.lblBallotDate.Name = "lblBallotDate";
            this.lblBallotDate.Size = new System.Drawing.Size(133, 16);
            this.lblBallotDate.TabIndex = 13;
            this.lblBallotDate.Text = "Ngày xuất chứng từ ";
            this.lblBallotDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBollot
            // 
            this.lblBollot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBollot.Location = new System.Drawing.Point(13, 16);
            this.lblBollot.Name = "lblBollot";
            this.lblBollot.Size = new System.Drawing.Size(122, 16);
            this.lblBollot.TabIndex = 12;
            this.lblBollot.Text = "Mã chứng từ (*)";
            this.lblBollot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1215, 324);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhập kho";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::VVPosM1.Properties.Resources._1404478970_f_cross;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Xóa";
            this.dataGridViewImageColumn2.Image = global::VVPosM1.Properties.Resources._1404478970_f_cross;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // frmInput
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1215, 729);
            this.Controls.Add(this.pInput);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInput";
            this.Text = "Nhập Kho";
            this.Load += new System.EventHandler(this.frmInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.pInput.ResumeLayout(false);
            this.pInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntSeach;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnAddMeasure;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.Label lblTB1;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.Button bntPre;
        private System.Windows.Forms.TextBox txtBollot;
        private System.Windows.Forms.Label lblBallotDate;
        private System.Windows.Forms.Label lblBollot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private System.Windows.Forms.TextBox txtReceiptId;
        private System.Windows.Forms.Label lblReceiptDate;
        private System.Windows.Forms.Label lblReceiptId;
        private System.Windows.Forms.DateTimePicker dtpBallotDate;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.CheckBox chbPaid;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtInputId;
        private System.Windows.Forms.Label lblInputId;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ballot;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paid;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngredientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn exDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}