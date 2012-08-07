
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Paint
{
  public class FillTool : Tool
  {
    private int pixelSize;
    private BitmapData bData;

    public FillTool(ToolArgs args)
      : base(args) {
      args.pictureBox.Cursor = Cursors.Cross;
      args.pictureBox.MouseClick += new MouseEventHandler(OnMouseClick);
      args.pictureBox.MouseMove += new MouseEventHandler(OnMouseMove);

      Rectangle bRect = new Rectangle(new Point(0, 0), args.bitmap.Size);
      bData = args.bitmap.LockBits(bRect, ImageLockMode.ReadWrite, args.bitmap.PixelFormat);
      // pixel size in bits = image width in bytes / image width in pixels
      pixelSize = bData.Stride / bData.Width;
    }

    private unsafe Color GetPixel(int x, int y) {
      byte* pixelBaseAddress = (byte*)bData.Scan0 + (y * bData.Stride) + (x * pixelSize);

      if (pixelSize == 4) {
        byte b = *pixelBaseAddress++;
        byte g = *pixelBaseAddress++;
        byte r = *pixelBaseAddress++;
        byte a = *pixelBaseAddress;

        return Color.FromArgb(a, r, g, b);
      } else if (pixelSize == 3) {
        byte b = *pixelBaseAddress++;
        byte g = *pixelBaseAddress++;
        byte r = *pixelBaseAddress;

        return Color.FromArgb(r, g, b);
      }
      return Color.Empty;
    }

    private unsafe void SetPixel(int x, int y, Color color) {
      byte* pixelBaseAddress = (byte*)bData.Scan0 + (y * bData.Stride) + (x * pixelSize);

      if (pixelSize == 4) {
        *pixelBaseAddress++ = color.B;
        *pixelBaseAddress++ = color.G;
        *pixelBaseAddress++ = color.R;
        *pixelBaseAddress = color.A;
      } else if (pixelSize == 3) {
        *pixelBaseAddress++ = color.B;
        *pixelBaseAddress++ = color.G;
        *pixelBaseAddress = color.R;
      }
    }

    private void OnMouseMove(object sender, MouseEventArgs e) {
      ShowPointInStatusBar(e.Location);
    }

    private void OnMouseClick(object sender, MouseEventArgs e) {
      Rectangle bRect = new Rectangle(new Point(0, 0), args.bitmap.Size);
      if (bRect.Contains(e.Location)) {
        args.pictureBox.Cursor = Cursors.WaitCursor;

        Color oldColor = GetPixel(e.X, e.Y);
        try {
          FloodFillScanlineStack(e.X, e.Y, args.settings.PrimaryColor, oldColor);
        } catch (Exception ex) {
          MessageBox.Show(ex.Message);
        }

        args.pictureBox.Invalidate();
        args.pictureBox.Cursor = Cursors.Cross;
      }
    }

    public override void UnloadTool() {
      args.bitmap.UnlockBits(bData);
      args.pictureBox.Cursor = Cursors.Default;
      args.pictureBox.MouseClick -= new MouseEventHandler(OnMouseClick);
      args.pictureBox.MouseMove -= new MouseEventHandler(OnMouseMove);
    }

    private void FloodFillScanlineStack(int x, int y, Color newColor, Color oldColor) {
      if (oldColor.ToArgb() == newColor.ToArgb())
        return;

      int w = args.bitmap.Width;
      int h = args.bitmap.Height;
      PixelStack stack = new PixelStack(w, h);

      int y1;
      bool spanLeft, spanRight;

      if (!stack.Push(x, y))
        return;

      while (stack.Pop(ref x, ref y)) {
        y1 = y;
        while (y1 >= 0 && GetPixel(x, y1) == oldColor) {
          y1--;
        }
        y1++;
        spanLeft = spanRight = false;
        while (y1 < h && GetPixel(x, y1) == oldColor) {
          SetPixel(x, y1, newColor);
          if (!spanLeft && x > 0 && GetPixel(x - 1, y1) == oldColor) {
            if (!stack.Push(x - 1, y1)) return;
            spanLeft = true; ;
          } else if (spanLeft && x > 0 && GetPixel(x - 1, y1) != oldColor) {
            spanLeft = false;
          }
          if (!spanRight && x < w - 1 && GetPixel(x + 1, y1) == oldColor) {
            if (!stack.Push(x + 1, y1)) return;
            spanRight = true;
          } else if (spanRight && x < w - 1 && x < w && GetPixel(x + 1, y1) != oldColor) {
            spanRight = false;
          }
          y1++;
        }
      }
    }

    private class PixelStack
    {
      private int w;
      private int h;
      private int[] stack;
      private int stackSize;
      private int stackPointer;

      public PixelStack(int width, int height) {
        w = width;
        h = height;
        stackSize = w * h;
        stack = new int[stackSize];
      }

      public bool Pop(ref int x, ref int y) {
        if (stackPointer > 0) {
          int p = stack[stackPointer];
          x = p / h;
          y = p % h;
          stackPointer--;
          return true;
        } else {
          return false;
        }
      }

      public bool Push(int x, int y) {
        if (stackPointer < stackSize - 1) {
          stackPointer++;
          stack[stackPointer] = h * x + y;
          return true;
        } else {
          return false;
        }
      }
    }
  }
}
