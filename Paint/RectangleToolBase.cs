
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    public abstract class RectangleToolBase : Tool
    {
        protected bool drawing;
        protected Point sPoint;

        public RectangleToolBase(ToolArgs args)
            : base(args)
        {
            drawing = false;
            args.pictureBox.Cursor = Cursors.Cross;
            args.pictureBox.MouseDown += new MouseEventHandler(OnMouseDown);
            args.pictureBox.MouseMove += new MouseEventHandler(OnMouseMove);
            args.pictureBox.MouseUp += new MouseEventHandler(OnMouseUp);
        }

        protected abstract void OnMouseUp(object sender, MouseEventArgs e);
        protected abstract void OnMouseDown(object sender, MouseEventArgs e);
        protected abstract void OnMouseMove(object sender, MouseEventArgs e);

        public override void UnloadTool()
        {
            args.pictureBox.Cursor = Cursors.Arrow;
            args.pictureBox.MouseDown -= new MouseEventHandler(OnMouseDown);
            args.pictureBox.MouseMove -= new MouseEventHandler(OnMouseMove);
            args.pictureBox.MouseUp -= new MouseEventHandler(OnMouseUp);
        }
    }
}
