namespace VVPosM1.Screen.CRM.Types
{
    partial class frmEmployeeType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeType));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.dgvEmployeeType = new System.Windows.Forms.DataGridView();
            this.EmployeeTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTypeName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTypeName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInformationSearh = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmployeeTypeName3 = new System.Windows.Forms.TextBox();
            this.txtEmployeeTypeName2 = new System.Windows.Forms.TextBox();
            this.txtEmployeeTypeName1 = new System.Windows.Forms.TextBox();
            this.lblEmployeeTypeName3 = new System.Windows.Forms.Label();
            this.lblEmployeeTypeName2 = new System.Windows.Forms.Label();
            this.lblEmployeeTypeName1 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeType)).BeginInit();
            this.gbInformationSearh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gbInformationSearh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 470);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.gbInformation);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 470);
            this.panel3.TabIndex = 8;
            // 
            // gbInformation
            // 
            this.gbInformation.BackColor = System.Drawing.Color.Transparent;
            this.gbInformation.Controls.Add(this.dgvEmployeeType);
            this.gbInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformation.Location = new System.Drawing.Point(0, 0);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(661, 470);
            this.gbInformation.TabIndex = 3;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Danh sách loại thành viên";
            // 
            // dgvEmployeeType
            // 
            this.dgvEmployeeType.AllowUserToAddRows = false;
            this.dgvEmployeeType.AllowUserToDeleteRows = false;
            this.dgvEmployeeType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvEmployeeType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeTypeID,
            this.EmployeeTypeName,
            this.EmployeeTypeName2,
            this.EmployeeTypeName3});
            this.dgvEmployeeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeType.Location = new System.Drawing.Point(3, 25);
            this.dgvEmployeeType.Name = "dgvEmployeeType";
            this.dgvEmployeeType.ReadOnly = true;
            this.dgvEmployeeType.RowHeadersVisible = false;
            this.dgvEmployeeType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeType.Size = new System.Drawing.Size(655, 442);
            this.dgvEmployeeType.TabIndex = 9;
            this.dgvEmployeeType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeType_CellClick);
            // 
            // EmployeeTypeID
            // 
            this.EmployeeTypeID.DataPropertyName = "EmployeeTypeID";
            this.EmployeeTypeID.FillWeight = 476.9543F;
            this.EmployeeTypeID.HeaderText = "Mã số";
            this.EmployeeTypeID.Name = "EmployeeTypeID";
            this.EmployeeTypeID.ReadOnly = true;
            this.EmployeeTypeID.Visible = false;
            // 
            // EmployeeTypeName
            // 
            this.EmployeeTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeTypeName.DataPropertyName = "EmployeeTypeName";
            this.EmployeeTypeName.FillWeight = 1F;
            this.EmployeeTypeName.HeaderText = "Tên tiếng Việt";
            this.EmployeeTypeName.Name = "EmployeeTypeName";
            this.EmployeeTypeName.ReadOnly = true;
            // 
            // EmployeeTypeName2
            // 
            this.EmployeeTypeName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeTypeName2.DataPropertyName = "EmployeeTypeName2";
            this.EmployeeTypeName2.FillWeight = 1F;
            this.EmployeeTypeName2.HeaderText = "Tiêng tiếng Nhật";
            this.EmployeeTypeName2.Name = "EmployeeTypeName2";
            this.EmployeeTypeName2.ReadOnly = true;
            // 
            // EmployeeTypeName3
            // 
            this.EmployeeTypeName3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeTypeName3.DataPropertyName = "EmployeeTypeName3";
            this.EmployeeTypeName3.FillWeight = 1F;
            this.EmployeeTypeName3.HeaderText = "Tên tiếng Anh";
            this.EmployeeTypeName3.Name = "EmployeeTypeName3";
            this.EmployeeTypeName3.ReadOnly = true;
            // 
            // gbInformationSearh
            // 
            this.gbInformationSearh.Controls.Add(this.btnDelete);
            this.gbInformationSearh.Controls.Add(this.btnAddNew);
            this.gbInformationSearh.Controls.Add(this.btnSave);
            this.gbInformationSearh.Controls.Add(this.txtEmployeeTypeName3);
            this.gbInformationSearh.Controls.Add(this.txtEmployeeTypeName2);
            this.gbInformationSearh.Controls.Add(this.txtEmployeeTypeName1);
            this.gbInformationSearh.Controls.Add(this.lblEmployeeTypeName3);
            this.gbInformationSearh.Controls.Add(this.lblEmployeeTypeName2);
            this.gbInformationSearh.Controls.Add(this.lblEmployeeTypeName1);
            this.gbInformationSearh.Controls.Add(this.listBox3);
            this.gbInformationSearh.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbInformationSearh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationSearh.Location = new System.Drawing.Point(661, 0);
            this.gbInformationSearh.Name = "gbInformationSearh";
            this.gbInformationSearh.Size = new System.Drawing.Size(350, 470);
            this.gbInformationSearh.TabIndex = 16;
            this.gbInformationSearh.TabStop = false;
            this.gbInformationSearh.Text = "Thông tin chi tiết";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(98)))), ((int)(((byte)(114)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::VVPosM1.Properties.Resources.cancel103;
            this.btnDelete.Location = new System.Drawing.Point(209, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 44);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Image = global::VVPosM1.Properties.Resources.reload8;
            this.btnAddNew.Location = new System.Drawing.Point(73, 222);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(130, 44);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.Text = "Làm mới";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::VVPosM1.Properties.Resources.floppy13;
            this.btnSave.Location = new System.Drawing.Point(208, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 44);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmployeeTypeName3
            // 
            this.txtEmployeeTypeName3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeTypeName3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmployeeTypeName3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeTypeName3.Location = new System.Drawing.Point(159, 180);
            this.txtEmployeeTypeName3.Name = "txtEmployeeTypeName3";
            this.txtEmployeeTypeName3.Size = new System.Drawing.Size(180, 29);
            this.txtEmployeeTypeName3.TabIndex = 4;
            // 
            // txtEmployeeTypeName2
            // 
            this.txtEmployeeTypeName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeTypeName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmployeeTypeName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeTypeName2.Location = new System.Drawing.Point(159, 139);
            this.txtEmployeeTypeName2.Name = "txtEmployeeTypeName2";
            this.txtEmployeeTypeName2.Size = new System.Drawing.Size(180, 29);
            this.txtEmployeeTypeName2.TabIndex = 3;
            // 
            // txtEmployeeTypeName1
            // 
            this.txtEmployeeTypeName1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeTypeName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmployeeTypeName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeTypeName1.Location = new System.Drawing.Point(159, 97);
            this.txtEmployeeTypeName1.Name = "txtEmployeeTypeName1";
            this.txtEmployeeTypeName1.Size = new System.Drawing.Size(180, 29);
            this.txtEmployeeTypeName1.TabIndex = 2;
            // 
            // lblEmployeeTypeName3
            // 
            this.lblEmployeeTypeName3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeTypeName3.AutoSize = true;
            this.lblEmployeeTypeName3.Location = new System.Drawing.Point(19, 184);
            this.lblEmployeeTypeName3.Name = "lblEmployeeTypeName3";
            this.lblEmployeeTypeName3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmployeeTypeName3.Size = new System.Drawing.Size(90, 21);
            this.lblEmployeeTypeName3.TabIndex = 13;
            this.lblEmployeeTypeName3.Text = "グループ名";
            // 
            // lblEmployeeTypeName2
            // 
            this.lblEmployeeTypeName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeTypeName2.AutoSize = true;
            this.lblEmployeeTypeName2.Location = new System.Drawing.Point(19, 143);
            this.lblEmployeeTypeName2.Name = "lblEmployeeTypeName2";
            this.lblEmployeeTypeName2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmployeeTypeName2.Size = new System.Drawing.Size(97, 21);
            this.lblEmployeeTypeName2.TabIndex = 13;
            this.lblEmployeeTypeName2.Text = "Group name";
            // 
            // lblEmployeeTypeName1
            // 
            this.lblEmployeeTypeName1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeTypeName1.AutoSize = true;
            this.lblEmployeeTypeName1.Location = new System.Drawing.Point(19, 101);
            this.lblEmployeeTypeName1.Name = "lblEmployeeTypeName1";
            this.lblEmployeeTypeName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmployeeTypeName1.Size = new System.Drawing.Size(80, 21);
            this.lblEmployeeTypeName1.TabIndex = 13;
            this.lblEmployeeTypeName1.Text = "Tên nhóm";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 21;
            this.listBox3.Location = new System.Drawing.Point(1142, 32);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(291, 67);
            this.listBox3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 41);
            this.panel2.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblTitle.Location = new System.Drawing.Point(317, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 32);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Quản lý loại thành viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MemberTypeID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.FillWeight = 215.736F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MemberTypeCode";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.FillWeight = 71.06599F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã loại thành viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MemberTypeName";
            this.dataGridViewTextBoxColumn3.FillWeight = 71.06599F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên loại thành viên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MemberTypeName2";
            this.dataGridViewTextBoxColumn4.FillWeight = 71.06599F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tiêng tiếng Nhật";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MemberTypeName3";
            this.dataGridViewTextBoxColumn5.FillWeight = 71.06599F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên tiếng Anh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 207;
            // 
            // frmEmployeeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmCustommerType_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeType)).EndInit();
            this.gbInformationSearh.ResumeLayout(false);
            this.gbInformationSearh.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.DataGridView dgvEmployeeType;
        private System.Windows.Forms.GroupBox gbInformationSearh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmployeeTypeName1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox txtEmployeeTypeName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtEmployeeTypeName3;
        private System.Windows.Forms.TextBox txtEmployeeTypeName2;
        private System.Windows.Forms.Label lblEmployeeTypeName3;
        private System.Windows.Forms.Label lblEmployeeTypeName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeTypeName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeTypeName3;
    }
}