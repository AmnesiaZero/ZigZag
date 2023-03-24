using System.Drawing;
using System.Windows.Forms;

namespace ZigZag
{
    /*
     * Графические инструменты "кисть", "карандаш"
     */
    public class GraphicToolPen : GraphicTool
    {
        private GraphicPoints Points;
        private bool IsLeftMouse;

        public GraphicToolPen(Pen Base)
        {
            this.Base = Base;
        }

        public override void Initialize(object Parent)
        {
            Points = new GraphicPoints();
        }

        public override void SetProperty(Tools.Property property, object value)
        {
            base.SetProperty(property, value);

            switch (property)
            {
                case Tools.Property.TOOL_COLOR:
                    ((Pen)Base).Color = (Color)value;
                    break;
                case Tools.Property.TOOL_WIDTH:
                    ((Pen)Base).Width = (float)value;
                    break;
                default:
                    break;
            }
        }

        public override void MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsLeftMouse = true;
            }
        }

        public override void MouseUp(MouseEventArgs e)
        {
            if (IsLeftMouse && e.Button == MouseButtons.Left)
            {
                Points.Reset();
                IsLeftMouse = false;
            }
        }

        public override bool MouseMove(Graphics graphics, MouseEventArgs e)
        {
            if (!IsLeftMouse)
            {
                return false;
            }

            Points.AddPoint(e.X, e.Y);

            if (Points.Full)
            {
                graphics.DrawLines((Pen)Base, Points.Array);
                Points.AddPoint(e.X, e.Y);
                return true;
            }

            return false;
        }
    }
}
