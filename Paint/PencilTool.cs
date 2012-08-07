
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class PencilTool : Tool
    {
        private bool drawing;
        private Graphics bmpGraphics;
        private Point prevPoint;
        private Pen pen;

        public PencilTool(ToolArgs args)
            : base(args)
        {
            drawing = false;
            args.pictureBox.Cursor = Cursors.Cross;
            args.pictureBox.MouseDown += new MouseEventHandler(OnMouseDown);
            args.pictureBox.MouseMove += new MouseEventHandler(OnMouseMove);
            args.pictureBox.MouseUp += new MouseEventHandler(OnMouseUp);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            Point curPoint = e.Location;
            if (drawing)
            {
                g.DrawLine(pen, prevPoint, curPoint);
                bmpGraphics.DrawLine(pen, prevPoint, curPoint);
                prevPoint = curPoint;
            }
            ShowPointInStatusBar(curPoint);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                prevPoint = e.Location;
                pen = new Pen(args.settings.PrimaryColor, 1);
                g = args.pictureBox.CreateGraphics();
                bmpGraphics = Graphics.FromImage(args.bitmap);
            }
        }

        public override void UnloadTool()
        {
            args.pictureBox.Cursor = Cursors.Arrow;
            args.pictureBox.MouseDown -= new MouseEventHandler(OnMouseDown);
            args.pictureBox.MouseMove -= new MouseEventHandler(OnMouseMove);
        }
    }
}
