
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
  public class BrushTool : Tool
  {
    private bool drawing;
    private BrushToolType toolType;
    private Graphics bmpGraphics;
    private Point prevPoint;
    private Pen pen;

    public BrushTool(ToolArgs args, BrushToolType type)
      : base(args) {
      toolType = type;
      drawing = false;

      args.pictureBox.Cursor = Cursors.Cross;
      args.pictureBox.MouseDown += new MouseEventHandler(OnMouseDown);
      args.pictureBox.MouseMove += new MouseEventHandler(OnMouseMove);
      args.pictureBox.MouseUp += new MouseEventHandler(OnMouseUp);
    }

    private void OnMouseUp(object sender, MouseEventArgs e) {
      drawing = false;
      args.pictureBox.Invalidate();

      pen.Dispose();
      bmpGraphics.Dispose();
      g.Dispose();
    }

    private void OnMouseMove(object sender, MouseEventArgs e) {
      Point curPoint = e.Location;
      if (drawing) {
        g.DrawLine(pen, prevPoint, curPoint);
        bmpGraphics.DrawLine(pen, prevPoint, curPoint);
        prevPoint = curPoint;
      }

      ShowPointInStatusBar(curPoint);
    }

    private void OnMouseDown(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Left) {
        drawing = true;
        prevPoint = e.Location;

        if (toolType == BrushToolType.FreeBrush)
          pen = new Pen(GetBrush(false), args.settings.Width);
        else
          pen = new Pen(args.settings.SecondaryColor, args.settings.Width);

        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        g = args.pictureBox.CreateGraphics();
        bmpGraphics = Graphics.FromImage(args.bitmap);
      }
    }

    public override void UnloadTool() {
      args.pictureBox.Cursor = Cursors.Default;
      args.pictureBox.MouseDown -= new MouseEventHandler(OnMouseDown);
      args.pictureBox.MouseMove -= new MouseEventHandler(OnMouseMove);
      args.pictureBox.MouseUp -= new MouseEventHandler(OnMouseUp);
    }
  }
}
