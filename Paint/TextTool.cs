
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class TextTool : Tool
    {
        public TextTool(ToolArgs args)
            : base(args)
        {
            args.pictureBox.Cursor = Cursors.Cross;
            args.pictureBox.MouseUp += new MouseEventHandler(OnMouseUp);
            args.pictureBox.MouseMove += new MouseEventHandler(OnMouseMove);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            args.panel1.Text = e.Location.ToString();
            args.panel2.Text = "";
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            TextDialog textDlg = new TextDialog();
            if (textDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Graphics g = Graphics.FromImage(args.bitmap);
                g.DrawString(textDlg.ReturnText, textDlg.TextFont, GetBrush(false), e.Location);
                args.pictureBox.Invalidate();
            }
        }

        public override void UnloadTool()
        {
            args.pictureBox.Cursor = Cursors.Default;
            args.pictureBox.MouseUp -= new MouseEventHandler(OnMouseUp);
            args.pictureBox.MouseMove -= new MouseEventHandler(OnMouseMove);
        }
    }
}
