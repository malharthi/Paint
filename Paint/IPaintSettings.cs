
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    public interface IPaintSettings
    {
        DrawMode DrawMode
        {
            get;
        }

        int Width
        {
            get;
        }

        LinearGradientMode GradiantStyle
        {
            get;
        }

        Color PrimaryColor
        {
            get;
        }

        Color SecondaryColor
        {
            get;
        }

        BrushType BrushType
        {
            get;
        }

        HatchStyle HatchStyle
        {
            get;
        }

        DashStyle LineStyle
        {
            get;
        }

        Image TextureBrushImage
        {
            get;
        }
    }
}