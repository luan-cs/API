#region Using directives

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using ImageAlignOption = VVPosS.ImageAlignOption;

#endregion

namespace VVPosS
{

    /// <summary>
    /// Form used to enter an Html Image attribute
    /// Consists of Href, Text and Image Alignment
    /// </summary>
    internal partial class EnterImageForm : Form
    {

        /// <summary>
        /// Public form constructor
        /// </summary>
        public EnterImageForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // define the text for the alignment
            this.listAlign.Items.AddRange(Enum.GetNames(typeof(ImageAlignOption)));

            // ensure default value set for target
            this.listAlign.SelectedIndex = 4;

        } //EnterHrefForm


        /// <summary>
        /// Property for the text to display
        /// </summary>
        public string ImageText
        {
            get
            {
                return this.hrefText.Text;
            }
            set
            {
                this.hrefText.Text = value;
            }

        } //ImageText

        /// <summary>
        /// Property for the href for the image
        /// </summary>
        public string ImageLink
        {
            get
            {
                return this.hrefLink.Text.Trim();
            }
            set
            {
                this.hrefLink.Text = value.Trim();
            }

        } //ImageLink

        /// <summary>
        /// Property for the image align
        /// </summary>
        public ImageAlignOption ImageAlign
        {
            get
            {
                return (ImageAlignOption)this.listAlign.SelectedIndex;
            }
            set
            {
                this.listAlign.SelectedIndex = (int)value;
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfile = new OpenFileDialog();
            opfile.Filter = "Image Files(*.JPG; *.PNG; *.GIF)| *.JPG; *PNG; *.GIF" + "|All files(*.*)|*.*";
            opfile.CheckFileExists = true;
            opfile.Title = "Chọn hình ảnh";

            if (opfile.ShowDialog() == DialogResult.OK)
            {
                this.hrefLink.Text = System.IO.Path.GetDirectoryName(opfile.FileName);
                this.hrefLink.Text= opfile.FileName;
            }
           
        }

        private void bInsert_Click(object sender, EventArgs e)
        {

        }

      

    }
}
