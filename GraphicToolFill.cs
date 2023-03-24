using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZigZag
{
    /*
     * Графический инструмент "заливка"
     */
    public class GraphicToolFill : GraphicTool
    {
        public GraphicToolFill(SolidBrush Base)
        {
            this.Base = Base;
        }

        public override void Initialize(object Parent)
        {
            Console.WriteLine("Fill initialize with parent " + Parent);
        }

        public override void SetProperty(Tools.Property property, object value)
        {
            base.SetProperty(property, value);

            switch (property)
            {
                case Tools.Property.TOOL_COLOR:
                    ((SolidBrush)Base).Color = (Color)value;
                    break;
                default:
                    break;
            }
        }

        public override void MouseDown(MouseEventArgs e)
        {
            Console.WriteLine("Fill mouse down");
        }

        public override void MouseUp(MouseEventArgs e)
        {
            Console.WriteLine("Fill mouse up");
        }

        public override bool MouseMove(Graphics graphics, MouseEventArgs e)
        {
            Console.WriteLine("Fill mouse move with graphics " + graphics);

            return false;
        }
    }
}
