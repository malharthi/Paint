
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
  public class EllipseTool : RectangleTool
  {
    public EllipseTool(ToolArgs args)
      : base(args) {
    }

    protected override void DrawRectangle(Pen outlinePen, Brush fillBrush) {
      if (fillBrush is LinearGradientBrush) {
        if ((rect.Width > 0) && (rect.Height > 0)) {
          fillBrush = new LinearGradientBrush(rect,
                              args.settings.PrimaryColor,
                              args.settings.SecondaryColor,
                              args.settings.GradiantStyle);
          //outlinePen = new Pen(fillBrush, args.settings.Width);
        }
      }

      switch (args.settings.DrawMode) {
        case DrawMode.Outline:
          g.DrawEllipse(outlinePen, rect);
          break;
        case DrawMode.Filled:
          g.FillEllipse(fillBrush, rect);
          break;
        case DrawMode.Mixed:
          g.FillEllipse(fillBrush, rect);
          g.DrawEllipse(outlinePen, rect);
          break;
        case DrawMode.MixedWithSolidOutline:
          g.FillEllipse(fillBrush, rect);
          g.DrawEllipse(outlinePen, rect);
          break;
      }
    }
  }
}
