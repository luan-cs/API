#region (c) 2014 Viet Vang - All rights reserved
/*             			COPYRIGHT NOTICE
 *-----------------------------------------------------------------------
 * All materials (including but not limited to source code, compiled
 * assemblies, images, resources, etc.) are copyrighted to Viet Vang.
 * No usage is allowed unless permitted by written consent.
 * You may not use, reverse-engineer these materials under any 
 * circumstances.
 * 
 *
 *				PROJECT DESCRIPTION
 *-----------------------------------------------------------------------
 * Project		: VVPosS
 * Class		: frmMoveTable
 * Developer    : Huỳnh Thị Ngọc Dung
 */
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosS.Entities;
using VVPosS.BusinessLayer;

namespace VVPosS.Screen.POS
{
    public partial class frmMoveTable : Form
    {
        //BLLs
        private CommonCodeBLL commonCodeBLL;
        private DeskBLL deskBLL;
        private OrderBLL orderBLL;

        //Controls
        private TabPage tabPagesFromTable, tabPagesToTable;
        private ListView lstFromMove, lstToMove;

        //Variables 
        private DataTable dtFromTable, dtToTable;
        private string[] prmOrderId;
        private string sDeskLocation, sDeskIdFrom, sDeskIdTo, sDeskNoFrom, sDeskNoTo;
        private int iIndexFromTable, iIndexToTable, iSelectedFromTable = 0, iSelectedToTable = 0;

        public frmMoveTable()
        {
            InitializeComponent();
            SettingControl();
            
        }

        private void frmMoveTable_Load(object sender, EventArgs e)
        {
            SetUIChanges();
            ToUpper();
            //
            commonCodeBLL = new CommonCodeBLL();
            deskBLL = new DeskBLL();
            sDeskLocation = "DeskLocation";
            tabToTable.TabPages.Clear();
            LoadTabFromTable();
        }

        #region Functions

        private void SettingControl()
        {
            this.Size = new Size(1024, 768);
            this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            this.gFromTable.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
            this.gToTable.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);

            //this.lbUserText.ForeColor = this.ckbIsPrint.ForeColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.TITLEGROUPBOXCOLOR);
        }

        private void SetUIChanges() { 
            //button
            this.btnExit.Text = Common.clsLanguages.GetResource("MainScreen");
            this.btnMove.Text = Common.clsLanguages.GetResource("MoveTable1");
            
            //groupbox
            this.gFromTable.Text = Common.clsLanguages.GetResource("ListTableIsUsing");
            this.gToTable.Text = Common.clsLanguages.GetResource("DeskList");

            //datagridview
            this.colNo.HeaderText = Common.clsLanguages.GetResource("No");
            this.colProductName.HeaderText = Common.clsLanguages.GetResource("ProductName");
            this.colPrice.HeaderText = Common.clsLanguages.GetResource("ReceiptProPrice");
            this.colQty.HeaderText = Common.clsLanguages.GetResource("ReceiptProQty");
            this.colAmount.HeaderText = Common.clsLanguages.GetResource("ReceiptProTotalAfterTax");
        }

        private void ToUpper()
        {
            foreach (Control c in this.Controls)
            {
                Button btn = c as Button;
                if (btn != null)
                    btn.Text = btn.Text.ToUpper();
            }
        }

        private void Reset() {
            LoadTabFromTable();
            tabToTable.TabPages.Clear();
            //dgvOrderDt.Rows.Clear();
            sDeskNoTo = sDeskNoFrom = sDeskIdFrom = sDeskIdTo = null;
        }

        private void LoadTabFromTable() {
            dtFromTable = commonCodeBLL.GetCommonCodeByCommonTypeID(sDeskLocation);
            if (dtFromTable != null) { 
                //Clear all Tab current.
                tabFromTable.TabPages.Clear();
                //Foreach each record datatable and set TabPages.
                foreach (DataRow r in dtFromTable.Rows) {
                    iIndexFromTable = 0;

                    tabPagesFromTable = new TabPage();
                    tabPagesFromTable.AutoScroll = true;

                    tabPagesFromTable.Name = r["CommonId"].ToString();
                    tabPagesFromTable.Text = r["StrValue1"].ToString();
                    tabPagesFromTable.Tag = iIndexFromTable;

                    //
                    LoadTableByTabPages();

                    tabFromTable.TabPages.Add(tabPagesFromTable);
                    iIndexFromTable++;
                }
                tabFromTable.SelectedTab = tabFromTable.TabPages[iSelectedFromTable];
            }
        }

        private void LoadTabToTable()
        {
            dtToTable = commonCodeBLL.GetCommonCodeByCommonTypeID(sDeskLocation);
            if (dtToTable != null)
            {
                //Clear all Tab current.
                tabToTable.TabPages.Clear();
                //Foreach each record datatable and set TabPages.
                foreach (DataRow r in dtToTable.Rows)
                {
                    iIndexToTable = 0;

                    tabPagesToTable = new TabPage();
                    tabPagesToTable.AutoScroll = true;

                    tabPagesToTable.Name = r["CommonId"].ToString();
                    tabPagesToTable.Text = r["StrValue1"].ToString();
                    tabPagesToTable.Tag = iIndexFromTable;

                    LoadAllTableByTabPages();

                    tabToTable.TabPages.Add(tabPagesToTable);
                    iIndexToTable++;
                }
                tabToTable.SelectedTab = tabToTable.TabPages[iSelectedToTable];
            }
        }

        private void LoadTableByTabPages()
        {
            List<Desk> lst = new List<Desk>();
            lst = deskBLL.GetListByDeskLocation(tabPagesFromTable.Name.ToString(), "1");
            if (lst != null) {
                lstFromMove = new ListView();
                lstFromMove.Dock = DockStyle.Fill;
                lstFromMove.BorderStyle = BorderStyle.None;
                lstFromMove.Click += new System.EventHandler(this.lstFromMove_Click);

                tabPagesFromTable.Controls.Add(lstFromMove);
                lstFromMove.BeginUpdate();

                lstFromMove.View = View.LargeIcon;
                imgListFrom = new ImageList();
                this.imgListFrom.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
                this.imgListFrom.ImageSize = new System.Drawing.Size(16, 16);
                this.imgListFrom.TransparentColor = System.Drawing.Color.Transparent;

                imgListFrom.ImageSize = new Size(70, 50);
                imgListFrom.ColorDepth = ColorDepth.Depth16Bit;
                lstFromMove.LargeImageList = imgListFrom;

                //Add data to List
                int i = 0;
                foreach (Desk dk in lst) {
                    //Add Image to ImageList
                    Image img = global::VVPosS.Properties.Resources.table_full;
                    imgListFrom.Images.Add(img);

                    //Add Text
                    ListViewItem listItem = new ListViewItem();
                    listItem = new ListViewItem(dk.DeskNo.ToUpper());

                    listItem.ImageIndex = i;

                    // Add sub-items for Details view.
                    listItem.SubItems.Add(dk.DeskId);
                    listItem.SubItems.Add(dk.DeskNo);

                    lstFromMove.Items.Add(listItem);
                    i++;
                }
            }
        }

        private void LoadAllTableByTabPages()
        {
            List<Desk> lstTo = new List<Desk>();
            lstTo = deskBLL.GetListByDeskLocation(tabPagesToTable.Name.ToString(), null);
            if (lstTo != null)
            {
                lstToMove = new ListView();
                lstToMove.Dock = DockStyle.Fill;
                lstToMove.BorderStyle = BorderStyle.None;
                lstToMove.Click += new System.EventHandler(this.lstToMove_Click);

                tabPagesToTable.Controls.Add(lstToMove);
                lstToMove.BeginUpdate();

                lstToMove.View = View.LargeIcon;

                imgListTo = new ImageList();
                this.imgListTo.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
                this.imgListTo.ImageSize = new System.Drawing.Size(16, 16);
                this.imgListTo.TransparentColor = System.Drawing.Color.Transparent;

                imgListTo.ImageSize = new Size(70, 50);
                imgListTo.ColorDepth = ColorDepth.Depth16Bit;
                lstToMove.LargeImageList = imgListTo;

                //Add data to List
                Image img;
                int i = 0;
                foreach (Desk dk in lstTo)
                {
                    if(dk.DeskId != sDeskIdFrom){
                        //Add Image to ImageList
                        if(dk.IsUsing == "1")
                            img = global::VVPosS.Properties.Resources.table_full;
                        else img = global::VVPosS.Properties.Resources.table_empty;
                        imgListTo.Images.Add(img);

                        //Add Text
                        ListViewItem listItem = new ListViewItem();
                        listItem = new ListViewItem(dk.DeskNo.ToUpper());

                        listItem.ImageIndex = i;

                        // Add sub-items for Details view.
                        listItem.SubItems.Add(dk.DeskId);
                        listItem.SubItems.Add(dk.DeskNo);

                        lstToMove.Items.Add(listItem);
                        i++;
                    }
                }
            }
        }

        private void LoadOrderByTable(string DeskId)
        {
            dgvOrderDt.Rows.Clear();
            orderBLL = new OrderBLL();
            DataTable dt = orderBLL.GetOrderDetailByDeskId(DeskId);
            if (dt != null) {
                int i = 0;
                prmOrderId = new string[dt.Rows.Count];
                foreach (DataRow r in dt.Rows) {
                    dgvOrderDt.Rows.Add();
                    dgvOrderDt.Rows[i].Cells["colNo"].Value = (i + 1).ToString();
                    dgvOrderDt.Rows[i].Cells["colProductName"].Value = r["ProductName"].ToString();
                    dgvOrderDt.Rows[i].Cells["colQty"].Value = r["Qty"].ToString();
                    dgvOrderDt.Rows[i].Cells["colPrice"].Value = r["Price"].ToString();
                    dgvOrderDt.Rows[i].Cells["colAmount"].Value = r["TotalAmmount"].ToString();

                    DataGridViewRow row = dgvOrderDt.Rows[i];
                    row.Height = 40;

                    prmOrderId[i] = r["OrderId"].ToString();

                    i++;
                }
            }
        }

        #endregion

        #region ListView Events

        private void lstFromMove_Click(object sender, EventArgs e)
        {
            ListView lstFromMove = (ListView)sender;
            ListViewItem item = lstFromMove.SelectedItems[0];
            sDeskIdFrom = item.SubItems[1].Text;
            sDeskNoFrom = item.SubItems[2].Text;
            LoadOrderByTable(sDeskIdFrom);
        }

        private void lstToMove_Click(object sender, EventArgs e) {
            ListView lstToMove = (ListView)sender;
            ListViewItem item = lstToMove.SelectedItems[0];
            sDeskIdTo = item.SubItems[1].Text;
            sDeskNoTo = item.SubItems[2].Text;
            if (sDeskIdFrom == null) {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseSelectTableToMove"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
            if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("AreReallyWantTranInformationTable") + " " + sDeskNoFrom + " " +
                Common.clsLanguages.GetResource("ToTable") + " " + sDeskNoTo + "?",
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
            {
                //Update DeskId for Order.
                orderBLL = new OrderBLL();
                if (!orderBLL.UpdateDeskIdForOrder(prmOrderId, sDeskIdTo, sDeskIdFrom))
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("MoveTable") + " " + sDeskNoFrom + " " +
                        Common.clsLanguages.GetResource("ToTable") + " " + sDeskNoTo + " " + Common.clsLanguages.GetResource("TableMoveFailure"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    tabToTable.TabPages.Clear();
                    sDeskNoTo = sDeskNoFrom = sDeskIdFrom = sDeskIdTo = null;
                }
                else {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("MoveTable") + " " + sDeskNoFrom + " " +
                        Common.clsLanguages.GetResource("ToTable") + " " + sDeskNoTo + " " + Common.clsLanguages.GetResource("TableMoveSuccsess"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    Reset();
                }
            }
        }

        #endregion

        #region TabControl Events

        private void tabFromTable_Click(object sender, EventArgs e)
        {
            if (dtFromTable != null) {
                iSelectedFromTable = (sender as TabControl).SelectedIndex;
                tabFromTable.SelectedTab = tabFromTable.TabPages[iSelectedFromTable];

                LoadTableByTabPages();
            }
        }

        private void tabToTable_Click(object sender, EventArgs e)
        {
            if (dtToTable != null)
            {
                iSelectedToTable = (sender as TabControl).SelectedIndex;
                tabToTable.SelectedTab = tabToTable.TabPages[iSelectedToTable];

                LoadAllTableByTabPages();
            }
        }

        #endregion

        #region Button Events

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain f = new frmMain();
            f.Visible = true;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (sDeskIdFrom != null) {
                LoadTabToTable();
            }
            else {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseSelectTableToMove"),
                                Common.clsLanguages.GetResource("Information"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reset();
            dgvOrderDt.Rows.Clear();
        }

        #endregion

        private void gFromTable_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Common.Utility.DrawGroupBoxNonBorder(box, e.Graphics, System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR), this.gFromTable);
        }

        private void gToTable_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Common.Utility.DrawGroupBoxNonBorder(box, e.Graphics, System.Drawing.ColorTranslator.FromHtml(Common.Config.LABELCOLOR), this.gToTable);
        }

    }
}
