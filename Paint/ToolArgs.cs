
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class ToolArgs
    {
        public Bitmap bitmap;
        public PictureBox pictureBox;
        public StatusBarPanel panel1;
        public StatusBarPanel panel2;
        public IPaintSettings settings;

        public ToolArgs(Bitmap bmp, PictureBox picBox, StatusBarPanel p1, StatusBarPanel p2, IPaintSettings settings)
        {
            bitmap = bmp;
            pictureBox = picBox;
            panel1 = p1;
            panel2 = p2;
            this.settings = settings;
        }
    }
}
