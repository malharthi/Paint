
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
  public class PointerTool : Tool
  {
    public PointerTool(ToolArgs args)
      : base(args) {
      args.pictureBox.Cursor = Cursors.Arrow;
      args.pictureBox.MouseMove += new MouseEventHandler(OnMouseMove);
    }

    private void OnMouseMove(object sender, MouseEventArgs e) {
      // show cursor location in status bar
      ShowPointInStatusBar(e.Location);
    }

    public override void UnloadTool() {
      // remove event handlers
      args.pictureBox.MouseMove -= new MouseEventHandler(OnMouseMove);
    }
  }
}
