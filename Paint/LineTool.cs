
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
  public class LineTool : Tool
  {
    private bool drawing;
    private Point sPoint;
    private TextureBrush delBrush;
    private Pen pen;
    private Rectangle delRect;

    public LineTool(ToolArgs args)
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
      if (drawing)
      {
        drawing = false;

        args.pictureBox.Invalidate();

        // free resources
        pen.Dispose();
        delBrush.Dispose();
        g.Dispose();
      }
    }

    private void OnMouseMove(object sender, MouseEventArgs e)
    {
      if (drawing)
      {
        // delete old line !!
        int w = args.settings.Width;
        delRect.Inflate(w, w);
        g.FillRectangle(delBrush, delRect);
        //g.DrawRectangle(Pens.Black, delRect);

        //draw the new line
        g.DrawLine(pen, sPoint, e.Location);
        args.pictureBox.Invalidate();

        delRect = GetRectangleFromPoints(sPoint, e.Location);
        // show points info in status bar
        ShowPointInStatusBar(sPoint, e.Location);
      }
      else
      {
        ShowPointInStatusBar(e.Location);
      }
    }

    private void OnMouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        drawing = true;
        sPoint = e.Location;

        g = Graphics.FromImage(args.bitmap);

        pen = new Pen(GetBrush(false), args.settings.Width);
        pen.DashStyle = args.settings.LineStyle;

        // delete brush
        delBrush = new TextureBrush(args.bitmap);
      }
    }

    public override void UnloadTool()
    {
      args.pictureBox.Cursor = Cursors.Default;
      args.pictureBox.MouseDown -= new MouseEventHandler(OnMouseDown);
      args.pictureBox.MouseMove -= new MouseEventHandler(OnMouseMove);
      args.pictureBox.MouseUp -= new MouseEventHandler(OnMouseUp);
    }
  }
}
