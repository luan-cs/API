namespace VVPosS.Screen.POS
{
    partial class frmManageDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDesk));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTilte = new System.Windows.Forms.Label();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtDeskSeat = new System.Windows.Forms.TextBox();
            this.txtDeskNo = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbSeat = new System.Windows.Forms.Label();
            this.lbDesk = new System.Windows.Forms.Label();
            this.pButton = new System.Windows.Forms.Panel();
            this.bntReset = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntSeach = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.linkNumber = new System.Windows.Forms.LinkLabel();
            this.bntNext = new System.Windows.Forms.Button();
            this.bntPre = new System.Windows.Forms.Button();
            this.data_Desk = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskLocationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfSeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.IsUsing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Desk)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTilte
            // 
            this.lbTilte.BackColor = System.Drawing.Color.Transparent;
            this.lbTilte.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTilte.Location = new System.Drawing.Point(0, 0);
            this.lbTilte.Name = "lbTilte";
            this.lbTilte.Size = new System.Drawing.Size(835, 40);
            this.lbTilte.TabIndex = 30;
            this.lbTilte.Text = "Quản Lý Bàn";
            this.lbTilte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboLocation
            // 
            this.cboLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Items.AddRange(new object[] {
            "Được sử dụng",
            "Đang sửa"});
            this.cboLocation.Location = new System.Drawing.Point(508, 58);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(233, 24);
            this.cboLocation.TabIndex = 41;
            // 
            // cboStatus
            // 
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Được sử dụng",
            "Đang sửa"});
            this.cboStatus.Location = new System.Drawing.Point(508, 102);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(233, 24);
            this.cboStatus.TabIndex = 40;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescription.Location = new System.Drawing.Point(178, 152);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(563, 60);
            this.rtxtDescription.TabIndex = 39;
            this.rtxtDescription.Text = "";
            this.rtxtDescription.TextChanged += new System.EventHandler(this.rtxtDescription_TextChanged);
            // 
            // txtDeskSeat
            // 
            this.txtDeskSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeskSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeskSeat.Location = new System.Drawing.Point(178, 102);
            this.txtDeskSeat.Name = "txtDeskSeat";
            this.txtDeskSeat.Size = new System.Drawing.Size(100, 23);
            this.txtDeskSeat.TabIndex = 38;
            this.txtDeskSeat.TextChanged += new System.EventHandler(this.txtDeskSeat_TextChanged);
            this.txtDeskSeat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeskSeat_KeyDown);
            this.txtDeskSeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeskSeat_KeyPress);
            // 
            // txtDeskNo
            // 
            this.txtDeskNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeskNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeskNo.Location = new System.Drawing.Point(178, 59);
            this.txtDeskNo.Name = "txtDeskNo";
            this.txtDeskNo.Size = new System.Drawing.Size(166, 23);
            this.txtDeskNo.TabIndex = 37;
            this.txtDeskNo.TextChanged += new System.EventHandler(this.txtDeskNo_TextChanged);
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDescription.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbDescription.Location = new System.Drawing.Point(94, 155);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(47, 17);
            this.lbDescription.TabIndex = 36;
            this.lbDescription.Text = "Mô tả:";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbLocation.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbLocation.Location = new System.Drawing.Point(414, 59);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(68, 17);
            this.lbLocation.TabIndex = 35;
            this.lbLocation.Text = "Vị trí bàn:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbStatus.Location = new System.Drawing.Point(414, 102);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(77, 17);
            this.lbStatus.TabIndex = 34;
            this.lbStatus.Text = "Trạng thái:";
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.BackColor = System.Drawing.Color.Transparent;
            this.lbSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbSeat.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbSeat.Location = new System.Drawing.Point(94, 102);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(60, 17);
            this.lbSeat.TabIndex = 33;
            this.lbSeat.Text = "Số Ghế:";
            // 
            // lbDesk
            // 
            this.lbDesk.AutoSize = true;
            this.lbDesk.BackColor = System.Drawing.Color.Transparent;
            this.lbDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDesk.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbDesk.Location = new System.Drawing.Point(94, 59);
            this.lbDesk.Name = "lbDesk";
            this.lbDesk.Size = new System.Drawing.Size(66, 17);
            this.lbDesk.TabIndex = 32;
            this.lbDesk.Text = "Tên Bàn:";
            // 
            // pButton
            // 
            this.pButton.BackColor = System.Drawing.Color.Transparent;
            this.pButton.BackgroundImage = global::VVPosS.Properties.Resources.backgroud;
            this.pButton.Controls.Add(this.bntReset);
            this.pButton.Controls.Add(this.bntLuu);
            this.pButton.Controls.Add(this.bntSeach);
            this.pButton.Location = new System.Drawing.Point(1, 233);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(834, 82);
            this.pButton.TabIndex = 80;
            // 
            // bntReset
            // 
            this.bntReset.BackColor = System.Drawing.Color.Transparent;
            this.bntReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntReset.BackgroundImage")));
            this.bntReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntReset.FlatAppearance.BorderSize = 0;
            this.bntReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntReset.ForeColor = System.Drawing.Color.Black;
            this.bntReset.Image = global::VVPosS.Properties.Resources.naplai_icon;
            this.bntReset.Location = new System.Drawing.Point(539, 11);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(100, 61);
            this.bntReset.TabIndex = 34;
            this.bntReset.Text = "Bỏ qua";
            this.bntReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntReset.UseVisualStyleBackColor = false;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // bntLuu
            // 
            this.bntLuu.BackColor = System.Drawing.Color.Transparent;
            this.bntLuu.BackgroundImage = global::VVPosS.Properties.Resources.save_button;
            this.bntLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLuu.FlatAppearance.BorderSize = 0;
            this.bntLuu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntLuu.ForeColor = System.Drawing.Color.Black;
            this.bntLuu.Image = global::VVPosS.Properties.Resources.save_icon;
            this.bntLuu.Location = new System.Drawing.Point(437, 11);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(100, 61);
            this.bntLuu.TabIndex = 32;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntLuu.UseVisualStyleBackColor = false;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // bntSeach
            // 
            this.bntSeach.BackColor = System.Drawing.Color.Transparent;
            this.bntSeach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntSeach.BackgroundImage")));
            this.bntSeach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSeach.FlatAppearance.BorderSize = 0;
            this.bntSeach.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntSeach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntSeach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntSeach.ForeColor = System.Drawing.Color.Black;
            this.bntSeach.Image = global::VVPosS.Properties.Resources.tinkiem_icon;
            this.bntSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSeach.Location = new System.Drawing.Point(335, 11);
            this.bntSeach.Name = "bntSeach";
            this.bntSeach.Size = new System.Drawing.Size(100, 61);
            this.bntSeach.TabIndex = 31;
            this.bntSeach.Text = "Tìm kiếm";
            this.bntSeach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntSeach.UseVisualStyleBackColor = false;
            this.bntSeach.Click += new System.EventHandler(this.bntSeach_Click);
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.Transparent;
            this.bntExit.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;
            this.bntExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntExit.FlatAppearance.BorderSize = 0;
            this.bntExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntExit.ForeColor = System.Drawing.Color.Black;
            this.bntExit.Image = global::VVPosS.Properties.Resources.thoat_icon;
            this.bntExit.Location = new System.Drawing.Point(691, 2);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(132, 50);
            this.bntExit.TabIndex = 33;
            this.bntExit.Text = "Thoát";
            this.bntExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // linkNumber
            // 
            this.linkNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.linkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNumber.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.linkNumber.Location = new System.Drawing.Point(594, 322);
            this.linkNumber.Name = "linkNumber";
            this.linkNumber.Size = new System.Drawing.Size(51, 38);
            this.linkNumber.TabIndex = 83;
            this.linkNumber.TabStop = true;
            this.linkNumber.Text = "1";
            this.linkNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntNext
            // 
            this.bntNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntNext.BackColor = System.Drawing.Color.Transparent;
            this.bntNext.BackgroundImage = global::VVPosS.Properties.Resources.next_button;
            this.bntNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntNext.FlatAppearance.BorderSize = 0;
            this.bntNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNext.ForeColor = System.Drawing.Color.Transparent;
            this.bntNext.Image = global::VVPosS.Properties.Resources.next_icon;
            this.bntNext.Location = new System.Drawing.Point(657, 321);
            this.bntNext.Name = "bntNext";
            this.bntNext.Size = new System.Drawing.Size(53, 40);
            this.bntNext.TabIndex = 82;
            this.bntNext.UseVisualStyleBackColor = false;
            this.bntNext.Click += new System.EventHandler(this.bntNext_Click);
            // 
            // bntPre
            // 
            this.bntPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntPre.BackColor = System.Drawing.Color.Transparent;
            this.bntPre.BackgroundImage = global::VVPosS.Properties.Resources.next_button;
            this.bntPre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntPre.FlatAppearance.BorderSize = 0;
            this.bntPre.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntPre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntPre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPre.ForeColor = System.Drawing.Color.Transparent;
            this.bntPre.Image = global::VVPosS.Properties.Resources.previous_icon;
            this.bntPre.Location = new System.Drawing.Point(527, 321);
            this.bntPre.Name = "bntPre";
            this.bntPre.Size = new System.Drawing.Size(53, 40);
            this.bntPre.TabIndex = 81;
            this.bntPre.UseVisualStyleBackColor = false;
            this.bntPre.Click += new System.EventHandler(this.bntPre_Click);
            // 
            // data_Desk
            // 
            this.data_Desk.AllowUserToAddRows = false;
            this.data_Desk.AllowUserToDeleteRows = false;
            this.data_Desk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_Desk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Desk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_Desk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Desk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.StatusId,
            this.DeskLocationId,
            this.DeskId,
            this.DeskNo,
            this.Description,
            this.NoOfSeat,
            this.DeskLocation,
            this.Status,
            this.Delete,
            this.IsUsing});
            this.data_Desk.EnableHeadersVisualStyles = false;
            this.data_Desk.Location = new System.Drawing.Point(1, 374);
            this.data_Desk.Name = "data_Desk";
            this.data_Desk.ReadOnly = true;
            this.data_Desk.RowHeadersVisible = false;
            this.data_Desk.Size = new System.Drawing.Size(833, 274);
            this.data_Desk.TabIndex = 84;
            this.data_Desk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Desk_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 60;
            // 
            // StatusId
            // 
            this.StatusId.HeaderText = "StatusId";
            this.StatusId.Name = "StatusId";
            this.StatusId.ReadOnly = true;
            this.StatusId.Visible = false;
            // 
            // DeskLocationId
            // 
            this.DeskLocationId.HeaderText = "DeskLocationId";
            this.DeskLocationId.Name = "DeskLocationId";
            this.DeskLocationId.ReadOnly = true;
            this.DeskLocationId.Visible = false;
            // 
            // DeskId
            // 
            this.DeskId.HeaderText = "DeskId";
            this.DeskId.Name = "DeskId";
            this.DeskId.ReadOnly = true;
            this.DeskId.Visible = false;
            // 
            // DeskNo
            // 
            this.DeskNo.HeaderText = "DeskNo";
            this.DeskNo.Name = "DeskNo";
            this.DeskNo.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Mô tả";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // NoOfSeat
            // 
            this.NoOfSeat.HeaderText = "Số ghế";
            this.NoOfSeat.Name = "NoOfSeat";
            this.NoOfSeat.ReadOnly = true;
            this.NoOfSeat.Width = 70;
            // 
            // DeskLocation
            // 
            this.DeskLocation.HeaderText = "Vị trí";
            this.DeskLocation.Name = "DeskLocation";
            this.DeskLocation.ReadOnly = true;
            this.DeskLocation.Width = 140;
            // 
            // Status
            // 
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.Width = 140;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::VVPosS.Properties.Resources.delete_icon;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 120;
            // 
            // IsUsing
            // 
            this.IsUsing.HeaderText = "IsUsing";
            this.IsUsing.Name = "IsUsing";
            this.IsUsing.ReadOnly = true;
            this.IsUsing.Visible = false;
            // 
            // frmManageDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VVPosS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 649);
            this.ControlBox = false;
            this.Controls.Add(this.data_Desk);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.linkNumber);
            this.Controls.Add(this.bntNext);
            this.Controls.Add(this.bntPre);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.cboLocation);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtDeskSeat);
            this.Controls.Add(this.txtDeskNo);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbSeat);
            this.Controls.Add(this.lbDesk);
            this.Controls.Add(this.lbTilte);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageDesk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmManageDesk_Load);
            this.pButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_Desk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTilte;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtDeskSeat;
        private System.Windows.Forms.TextBox txtDeskNo;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.Label lbDesk;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntSeach;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.Button bntPre;
        private System.Windows.Forms.DataGridView data_Desk;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskLocationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfSeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsUsing;

    }
}