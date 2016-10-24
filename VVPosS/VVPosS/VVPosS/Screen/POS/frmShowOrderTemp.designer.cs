namespace VVPosS.Screen.POS
{
    partial class frmShowOrderTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowOrderTemp));
            this.data_grid_order = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMonney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Chon = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChitiet = new System.Windows.Forms.Label();
            this.data_grid_orderdt = new System.Windows.Forms.DataGridView();
            this.colStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsBuffet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountBeforeTax1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDesk = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.lbTongtienBan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_order)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_orderdt)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_order
            // 
            this.data_grid_order.AllowUserToAddRows = false;
            this.data_grid_order.AllowUserToDeleteRows = false;
            this.data_grid_order.AllowUserToResizeColumns = false;
            this.data_grid_order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_grid_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_grid_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.DeskId,
            this.Desk,
            this.Time,
            this.TotalMonney,
            this.Delete,
            this.Chon});
            this.data_grid_order.EnableHeadersVisualStyles = false;
            this.data_grid_order.Location = new System.Drawing.Point(1, 83);
            this.data_grid_order.Margin = new System.Windows.Forms.Padding(0);
            this.data_grid_order.Name = "data_grid_order";
            this.data_grid_order.ReadOnly = true;
            this.data_grid_order.RowHeadersVisible = false;
            this.data_grid_order.Size = new System.Drawing.Size(833, 251);
            this.data_grid_order.TabIndex = 1;
            this.data_grid_order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_order_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STT.Width = 60;
            // 
            // DeskId
            // 
            this.DeskId.HeaderText = "DeskId";
            this.DeskId.Name = "DeskId";
            this.DeskId.ReadOnly = true;
            this.DeskId.Visible = false;
            // 
            // Desk
            // 
            this.Desk.HeaderText = "Desk";
            this.Desk.Name = "Desk";
            this.Desk.ReadOnly = true;
            this.Desk.Width = 120;
            // 
            // Time
            // 
            this.Time.HeaderText = "Thời gian";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 170;
            // 
            // TotalMonney
            // 
            this.TotalMonney.HeaderText = "Tổng tiền";
            this.TotalMonney.Name = "TotalMonney";
            this.TotalMonney.ReadOnly = true;
            this.TotalMonney.Width = 321;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::VVPosS.Properties.Resources.delete_icon;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 80;
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.Image = global::VVPosS.Properties.Resources.check_icon;
            this.Chon.Name = "Chon";
            this.Chon.ReadOnly = true;
            this.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Chon.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lbChitiet);
            this.panel1.Location = new System.Drawing.Point(1, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 40);
            this.panel1.TabIndex = 2;
            // 
            // lbChitiet
            // 
            this.lbChitiet.AutoSize = true;
            this.lbChitiet.BackColor = System.Drawing.Color.Transparent;
            this.lbChitiet.ForeColor = System.Drawing.Color.Black;
            this.lbChitiet.Location = new System.Drawing.Point(12, 10);
            this.lbChitiet.Name = "lbChitiet";
            this.lbChitiet.Size = new System.Drawing.Size(92, 20);
            this.lbChitiet.TabIndex = 2;
            this.lbChitiet.Text = "Chi tiết Order ";
            // 
            // data_grid_orderdt
            // 
            this.data_grid_orderdt.AllowUserToAddRows = false;
            this.data_grid_orderdt.AllowUserToDeleteRows = false;
            this.data_grid_orderdt.AllowUserToResizeColumns = false;
            this.data_grid_orderdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_grid_orderdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_orderdt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStt,
            this.ColNotes,
            this.ColIsBuffet,
            this.ProductName,
            this.Qty,
            this.Price,
            this.Total,
            this.OrderId,
            this.ProductId,
            this.VAT,
            this.AmountBeforeTax1});
            this.data_grid_orderdt.EnableHeadersVisualStyles = false;
            this.data_grid_orderdt.Location = new System.Drawing.Point(1, 374);
            this.data_grid_orderdt.Margin = new System.Windows.Forms.Padding(0);
            this.data_grid_orderdt.Name = "data_grid_orderdt";
            this.data_grid_orderdt.ReadOnly = true;
            this.data_grid_orderdt.RowHeadersVisible = false;
            this.data_grid_orderdt.Size = new System.Drawing.Size(833, 176);
            this.data_grid_orderdt.TabIndex = 3;
            // 
            // colStt
            // 
            this.colStt.HeaderText = "STT";
            this.colStt.Name = "colStt";
            this.colStt.ReadOnly = true;
            // 
            // ColNotes
            // 
            this.ColNotes.HeaderText = "ColNotes";
            this.ColNotes.Name = "ColNotes";
            this.ColNotes.ReadOnly = true;
            this.ColNotes.Visible = false;
            // 
            // ColIsBuffet
            // 
            this.ColIsBuffet.HeaderText = "ColIsBuffet";
            this.ColIsBuffet.Name = "ColIsBuffet";
            this.ColIsBuffet.ReadOnly = true;
            this.ColIsBuffet.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 292;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 190;
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "OrderId";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Visible = false;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // VAT
            // 
            this.VAT.HeaderText = "VAT";
            this.VAT.Name = "VAT";
            this.VAT.ReadOnly = true;
            this.VAT.Visible = false;
            // 
            // AmountBeforeTax1
            // 
            this.AmountBeforeTax1.HeaderText = "AmountBeforeTax1";
            this.AmountBeforeTax1.Name = "AmountBeforeTax1";
            this.AmountBeforeTax1.ReadOnly = true;
            this.AmountBeforeTax1.Visible = false;
            // 
            // lbDesk
            // 
            this.lbDesk.AutoSize = true;
            this.lbDesk.BackColor = System.Drawing.Color.Transparent;
            this.lbDesk.ForeColor = System.Drawing.Color.Black;
            this.lbDesk.Location = new System.Drawing.Point(12, 53);
            this.lbDesk.Name = "lbDesk";
            this.lbDesk.Size = new System.Drawing.Size(92, 20);
            this.lbDesk.TabIndex = 3;
            this.lbDesk.Text = "Chi tiết Order ";
            // 
            // lbTittle
            // 
            this.lbTittle.BackColor = System.Drawing.Color.Transparent;
            this.lbTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTittle.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Black;
            this.lbTittle.Location = new System.Drawing.Point(0, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(835, 39);
            this.lbTittle.TabIndex = 31;
            this.lbTittle.Text = "Chi tiết Order ";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(729, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 44);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnComplete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComplete.BackgroundImage")));
            this.btnComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnComplete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnComplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Image = global::VVPosS.Properties.Resources.thanhtoan_icon;
            this.btnComplete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComplete.Location = new System.Drawing.Point(723, 567);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(100, 61);
            this.btnComplete.TabIndex = 60;
            this.btnComplete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Visible = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.BackColor = System.Drawing.Color.Transparent;
            this.lbTongtien.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.ForeColor = System.Drawing.Color.Red;
            this.lbTongtien.Location = new System.Drawing.Point(298, 567);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(43, 22);
            this.lbTongtien.TabIndex = 61;
            this.lbTongtien.Text = "123";
            this.lbTongtien.Visible = false;
            // 
            // lbTongtienBan
            // 
            this.lbTongtienBan.AutoSize = true;
            this.lbTongtienBan.BackColor = System.Drawing.Color.Transparent;
            this.lbTongtienBan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtienBan.ForeColor = System.Drawing.Color.Red;
            this.lbTongtienBan.Location = new System.Drawing.Point(298, 602);
            this.lbTongtienBan.Name = "lbTongtienBan";
            this.lbTongtienBan.Size = new System.Drawing.Size(43, 22);
            this.lbTongtienBan.TabIndex = 62;
            this.lbTongtienBan.Text = "123";
            this.lbTongtienBan.Visible = false;
            // 
            // frmShowOrderTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::VVPosS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 649);
            this.ControlBox = false;
            this.Controls.Add(this.lbTongtienBan);
            this.Controls.Add(this.lbTongtien);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.lbDesk);
            this.Controls.Add(this.data_grid_orderdt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data_grid_order);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowOrderTemp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmShowOrderTemp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_order)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_orderdt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_order;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView data_grid_orderdt;
        private System.Windows.Forms.Label lbChitiet;
        private System.Windows.Forms.Label lbDesk;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMonney;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIsBuffet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountBeforeTax1;
        private System.Windows.Forms.Label lbTongtienBan;

        //private System.Windows.Forms.CheckedListBox lstMemberType;
    }
}