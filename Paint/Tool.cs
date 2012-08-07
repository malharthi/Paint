

using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint
{
    public abstract class Tool
    {
        protected ToolArgs args;
        protected Graphics g;

        public Tool(ToolArgs args)
        {
            this.args = args;
        }

        protected void ShowPointInStatusBar(Point pt)
        {
            args.panel1.Text = pt.ToString();
            args.panel2.Text = "";
        }

        protected void ShowPointInStatusBar(Point pt1, Point pt2)
        {
            args.panel1.Text = pt1.ToString();
            args.panel2.Text = pt2.ToString();
        }

        protected Rectangle GetRectangleFromPoints(Point p1, Point p2)
        {
            Point oPoint;
            Rectangle rect;

            if ((p2.X > p1.X) && (p2.Y > p1.Y))
            {
                rect = new Rectangle(p1, new Size(p2.X - p1.X, p2.Y - p1.Y));
            }
            else if ((p2.X < p1.X) && (p2.Y < p1.Y))
            {
                rect = new Rectangle(p2, new Size(p1.X - p2.X, p1.Y - p2.Y));
            }
            else if ((p2.X > p1.X) && (p2.Y < p1.Y))
            {
                oPoint = new Point(p1.X, p2.Y);
                rect = new Rectangle(oPoint, new Size(p2.X - p1.X, p1.Y - oPoint.Y));
            }
            else
            {
                oPoint = new Point(p2.X, p1.Y);
                rect = new Rectangle(oPoint, new Size(p1.X - p2.X, p2.Y - p1.Y));
            }
            return rect;
        }

        protected Brush GetBrush(bool inverseColors)
        {
            Brush brush = null;
            Color c1, c2;

            if (inverseColors)
            {
                c1 = args.settings.SecondaryColor;
                c2 = args.settings.PrimaryColor;
            }
            else
            {
                c1 = args.settings.PrimaryColor;
                c2 = args.settings.SecondaryColor;
            }

            switch (args.settings.BrushType)
            {
                case BrushType.SolidBrush:
                    brush = new SolidBrush(c1);
                    break;

                case BrushType.TextureBrush:
                    brush = new TextureBrush(args.settings.TextureBrushImage);
                    break;

                case BrushType.GradiantBrush:
                    int w = args.settings.Width;
                    Rectangle tempRect = new Rectangle(0, 0, args.bitmap.Width, args.bitmap.Height);
                    brush = new LinearGradientBrush(tempRect,
                        c1, c2, args.settings.GradiantStyle);
                    break;

                case BrushType.HatchBrush:
                    brush = new HatchBrush(args.settings.HatchStyle, c1, c2);
                    break;
            }

            return brush;
        }

        public abstract void UnloadTool();

    }
}
