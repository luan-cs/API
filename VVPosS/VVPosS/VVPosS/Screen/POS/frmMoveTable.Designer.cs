namespace VVPosS.Screen.POS
{
    partial class frmMoveTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoveTable));
            this.gFromTable = new System.Windows.Forms.GroupBox();
            this.dgvOrderDt = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFromTable = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gToTable = new System.Windows.Forms.GroupBox();
            this.tabToTable = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.gFromTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDt)).BeginInit();
            this.tabFromTable.SuspendLayout();
            this.gToTable.SuspendLayout();
            this.tabToTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // gFromTable
            // 
            this.gFromTable.BackColor = System.Drawing.Color.LightGray;
            this.gFromTable.Controls.Add(this.dgvOrderDt);
            this.gFromTable.Controls.Add(this.tabFromTable);
            this.gFromTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gFromTable.Location = new System.Drawing.Point(0, 73);
            this.gFromTable.Name = "gFromTable";
            this.gFromTable.Size = new System.Drawing.Size(505, 695);
            this.gFromTable.TabIndex = 0;
            this.gFromTable.TabStop = false;
            this.gFromTable.Text = "Danh sách bàn đang được sử dụng";
            this.gFromTable.Paint += new System.Windows.Forms.PaintEventHandler(this.gFromTable_Paint);
            // 
            // dgvOrderDt
            // 
            this.dgvOrderDt.AllowUserToAddRows = false;
            this.dgvOrderDt.AllowUserToDeleteRows = false;
            this.dgvOrderDt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderDt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colProductName,
            this.colQty,
            this.colPrice,
            this.colAmount});
            this.dgvOrderDt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOrderDt.EnableHeadersVisualStyles = false;
            this.dgvOrderDt.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvOrderDt.Location = new System.Drawing.Point(3, 398);
            this.dgvOrderDt.Margin = new System.Windows.Forms.Padding(0);
            this.dgvOrderDt.Name = "dgvOrderDt";
            this.dgvOrderDt.ReadOnly = true;
            this.dgvOrderDt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDt.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDt.RowHeadersVisible = false;
            this.dgvOrderDt.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrderDt.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrderDt.Size = new System.Drawing.Size(499, 294);
            this.dgvOrderDt.TabIndex = 1;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 50;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 170;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 50;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 110;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 119;
            // 
            // tabFromTable
            // 
            this.tabFromTable.AllowDrop = true;
            this.tabFromTable.Controls.Add(this.tabPage1);
            this.tabFromTable.Controls.Add(this.tabPage2);
            this.tabFromTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabFromTable.Location = new System.Drawing.Point(3, 19);
            this.tabFromTable.Margin = new System.Windows.Forms.Padding(0);
            this.tabFromTable.Multiline = true;
            this.tabFromTable.Name = "tabFromTable";
            this.tabFromTable.Padding = new System.Drawing.Point(0, 0);
            this.tabFromTable.SelectedIndex = 0;
            this.tabFromTable.Size = new System.Drawing.Size(499, 453);
            this.tabFromTable.TabIndex = 0;
            this.tabFromTable.Click += new System.EventHandler(this.tabFromTable_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(491, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gToTable
            // 
            this.gToTable.BackColor = System.Drawing.Color.LightGray;
            this.gToTable.Controls.Add(this.tabToTable);
            this.gToTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gToTable.Location = new System.Drawing.Point(511, 73);
            this.gToTable.Name = "gToTable";
            this.gToTable.Size = new System.Drawing.Size(512, 695);
            this.gToTable.TabIndex = 1;
            this.gToTable.TabStop = false;
            this.gToTable.Text = "Danh sách bàn ";
            this.gToTable.Paint += new System.Windows.Forms.PaintEventHandler(this.gToTable_Paint);
            // 
            // tabToTable
            // 
            this.tabToTable.AllowDrop = true;
            this.tabToTable.Controls.Add(this.tabPage3);
            this.tabToTable.Controls.Add(this.tabPage4);
            this.tabToTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabToTable.Location = new System.Drawing.Point(3, 19);
            this.tabToTable.Margin = new System.Windows.Forms.Padding(0);
            this.tabToTable.Multiline = true;
            this.tabToTable.Name = "tabToTable";
            this.tabToTable.Padding = new System.Drawing.Point(0, 0);
            this.tabToTable.SelectedIndex = 0;
            this.tabToTable.Size = new System.Drawing.Size(506, 673);
            this.tabToTable.TabIndex = 0;
            this.tabToTable.Click += new System.EventHandler(this.tabToTable_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(498, 644);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(498, 644);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::VVPosS.Properties.Resources.thoat_icon;
            this.btnExit.Location = new System.Drawing.Point(876, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 61);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::VVPosS.Properties.Resources.reser_icon;
            this.btnRefresh.Location = new System.Drawing.Point(657, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 61);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Transparent;
            this.btnMove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMove.BackgroundImage")));
            this.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMove.FlatAppearance.BorderSize = 0;
            this.btnMove.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.Color.Black;
            this.btnMove.Image = global::VVPosS.Properties.Resources.chuyenban_icon_black;
            this.btnMove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMove.Location = new System.Drawing.Point(515, 5);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(136, 61);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // frmMoveTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.gToTable);
            this.Controls.Add(this.gFromTable);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMoveTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMoveTable_Load);
            this.gFromTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDt)).EndInit();
            this.tabFromTable.ResumeLayout(false);
            this.gToTable.ResumeLayout(false);
            this.tabToTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gFromTable;
        private System.Windows.Forms.GroupBox gToTable;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvOrderDt;
        private System.Windows.Forms.TabControl tabFromTable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabToTable;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.ImageList imgListFrom;
        private System.Windows.Forms.ImageList imgListTo;
    }
}