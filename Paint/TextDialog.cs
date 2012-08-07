
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class TextDialog : Form
    {
        public TextDialog()
        {
            InitializeComponent();
        }

        private void fontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.Font = textBox.Font;

            if (fontDlg.ShowDialog() == DialogResult.OK)
                textBox.Font = fontDlg.Font;
        }

        public Font TextFont
        {
            get { return textBox.Font; }
        }

        public string ReturnText
        {
            get { return textBox.Text; }
        }
    }
}