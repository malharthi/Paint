
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class NewDialog : Form
    {
        public NewDialog()
        {
            InitializeComponent();
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.FullOpen = true;

            colorDlg.Color = colorBox.BackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                colorBox.BackColor = colorDlg.Color;
            }
        }

        public Size ImageSize
        {
            get { return new Size((int)widthBox.Value, (int)heightBox.Value); }
        }

        public Color imageBackColor
        {
            get { return colorBox.BackColor; }
        }
    }
}