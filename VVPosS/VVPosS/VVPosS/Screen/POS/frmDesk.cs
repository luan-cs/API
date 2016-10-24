using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VVPosS.BusinessLayer;
using VVPosS.Entities;

namespace VVPosS.Screen.POS
{
    public partial class frmDesk : Form
    {
        //BLLs
        private CommonCodeBLL commonCodeBLL;
        private DeskBLL deskBLL;

        //Controls
        private TabPage tabPagesFromTable;
        private ListView lstFromMove;
        private ImageList imgListFrom;

        //Variables 
        private DataTable dtFromTable;
        private int _iDeskId = 0, iIndexFromTable, iSelectedFromTable = 0;
        private string _sDeskNo = "", sDeskLocation;

        public frmDesk()
        {
            InitializeComponent();
            SettingControl();
           
        }

        private void frmDesk_Load(object sender, EventArgs e)
        {
            SetUIChanges();

            commonCodeBLL = new CommonCodeBLL();
            deskBLL = new DeskBLL();
            sDeskLocation = "DeskLocation";
            LoadTabFromTable();
        }


        private void SettingControl()
        {
            //pic status
            this.pxEmpty.Image = Common.Utility.GetImageFromService("Desks", "table_empty.png");
            this.pxFull.Image = Common.Utility.GetImageFromService("Desks", "table_full.png");

        }

        /// <summary>
        /// Set text for control
        /// </summary>
        public void SetUIChanges()
        {
            btnExit.Text = Common.clsLanguages.GetResource("Exit");
            lbTilte.Text = Common.clsLanguages.GetResource("DeskList");
            lbEmpty.Text = Common.clsLanguages.GetResource("TableEmpty");
            lbFull.Text = Common.clsLanguages.GetResource("TableFull"); 
        }

        public int DeskId {
            get { return _iDeskId; }
        }

        public string DeskNo {
            get { return _sDeskNo; }
        }

        #region Functions
        private void LoadTabFromTable()
        {
            dtFromTable = commonCodeBLL.GetCommonCodeByCommonTypeID(sDeskLocation);
            if (dtFromTable != null)
            {
                //Clear all Tab current.
                tabFromTable.TabPages.Clear();
                //Foreach each record datatable and set TabPages.
                foreach (DataRow r in dtFromTable.Rows)
                {
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

        private void LoadTableByTabPages()
        {
            List<Desk> lst = new List<Desk>();
            lst = deskBLL.GetListByDeskLocation(tabPagesFromTable.Name.ToString(), null);
            
            if (lst != null)
            {
                //imgListFrom.Images.Clear();

                lstFromMove = new ListView();
                lstFromMove.Dock = DockStyle.Fill;
                lstFromMove.BorderStyle = BorderStyle.None;
                lstFromMove.BackgroundImage = global::VVPosS.Properties.Resources.bg_chonban;
                lstFromMove.BackgroundImageTiled = false;
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
                Image img;
                int i = 0;
                foreach (Desk dk in lst)
                {
                    //Add Image to ImageList
                    if (dk.IsUsing == "1")
                        img = global::VVPosS.Properties.Resources.table_full;
                    else img = global::VVPosS.Properties.Resources.table_empty;
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
                lstFromMove.EndUpdate();
            }
        }
        #endregion

        #region ListView Events

        private void lstFromMove_Click(object sender, EventArgs e)
        {
            ListView lstFromMove = (ListView)sender;
            if (lstFromMove.Items.Count > 0)
            {
                ListViewItem item = lstFromMove.SelectedItems[0];
                _iDeskId = int.Parse(item.SubItems[1].Text);
                _sDeskNo = item.SubItems[2].Text;
                this.Close();
            }
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_iDeskId != 0)
            {
                this.Close();
            }
            else {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PleaseSelectADeskBeforeSave"),
                                Common.clsLanguages.GetResource("Error"),
                                Common.Config.CUSTOM_MESSAGEBOX_ICON.Error,
                                Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
