
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    public class RectangleTool : RectangleToolBase
    {
        protected Pen outlinePen;
        protected Brush fillBrush;
        protected Rectangle rect;

        private Pen delPen;
        private TextureBrush delBrush;
        private Rectangle prevRect;

        public RectangleTool(ToolArgs args)
            : base(args)
        {
        }

        protected override void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                args.pictureBox.Invalidate();

                drawing = false;

                // free resources
                if (fillBrush != null)
                    fillBrush.Dispose();

                if (outlinePen != null)
                    outlinePen.Dispose();

                delBrush.Dispose();
                g.Dispose();
            }
        }

        protected override void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                // delete old rectangle
                DrawRectangle(delPen, delBrush);
                // draw the rectangle
                rect = GetRectangleFromPoints(sPoint, e.Location);

                DrawRectangle(outlinePen, fillBrush);
                args.pictureBox.Invalidate();

                prevRect = rect;

                ShowPointInStatusBar(sPoint, e.Location);
            }
            else
            {
                ShowPointInStatusBar(e.Location);
            }
        }

        protected override void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (args.settings.DrawMode)
                {
                    case DrawMode.Outline:
                        outlinePen = new Pen(GetBrush(false), args.settings.Width);
                        outlinePen.DashStyle = args.settings.LineStyle;
                        break;

                    case DrawMode.Filled:
                        fillBrush = GetBrush(false);
                        break;

                    case DrawMode.Mixed:
                        fillBrush = GetBrush(false);
                        outlinePen = new Pen(GetBrush(true), args.settings.Width);
                        outlinePen.DashStyle = args.settings.LineStyle;
                        break;

                    case DrawMode.MixedWithSolidOutline:
                        fillBrush = GetBrush(false);
                        outlinePen = new Pen(args.settings.SecondaryColor, args.settings.Width);
                        outlinePen.DashStyle = args.settings.LineStyle;
                        break;
                }

                g = Graphics.FromImage(args.bitmap);
                drawing = true;
                sPoint = e.Location;

                delBrush = new TextureBrush(args.bitmap);
                delPen = new Pen(delBrush, args.settings.Width + 1);
                //delPen.DashStyle = args.settings.LineStyle;
            }
        }

        protected virtual void DrawRectangle(Pen outlinePen, Brush fillBrush)
        {
            if (fillBrush is LinearGradientBrush)
            {
                if ((rect.Width > 0) && (rect.Height > 0))
                {
                    fillBrush = new LinearGradientBrush(rect,
                          args.settings.PrimaryColor,
                          args.settings.SecondaryColor,
                          args.settings.GradiantStyle);
                    //outlinePen = new Pen(fillBrush, args.settings.Width);
                }
            }

            switch (args.settings.DrawMode)
            {
                case DrawMode.Outline:
                    g.DrawRectangle(outlinePen, rect);
                    break;

                case DrawMode.Filled:
                    g.FillRectangle(fillBrush, rect);
                    break;

                case DrawMode.Mixed:
                    g.FillRectangle(fillBrush, rect);
                    g.DrawRectangle(outlinePen, rect);
                    break;

                case DrawMode.MixedWithSolidOutline:
                    g.FillRectangle(fillBrush, rect);
                    g.DrawRectangle(outlinePen, rect);
                    break;
            }
        }
    }
}
