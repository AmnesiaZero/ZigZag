using System.Drawing;
using System.Windows.Forms;

namespace ZigZag
{
    /*
     * Графический инструмент "выделение области"
     */
    public class GraphicToolSelect : GraphicTool
    {
        private bool IsLeftMouse;
        private readonly SolidBrush SelectBrush = new SolidBrush(Color.FromArgb(32, 0, 0, 220));
        private Rectangle selectRegion;
        private Size selectSize;
        private Control Parent;
        private int x, y, width, height;

        public override void Initialize(object parent)
        {
            Parent = (Control)parent;
            selectRegion = Rectangle.Empty;
            selectSize = selectRegion.Size;

            Parent.Paint += new PaintEventHandler(Paint);
        }

        public override void MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectRegion.Location = e.Location;
                IsLeftMouse = true;
            }
        }

        public override void MouseUp(MouseEventArgs e)
        {
            if (IsLeftMouse && e.Button == MouseButtons.Left && selectSize != Size.Empty)
            {
                Parent.Invalidate(selectRegion);
                selectRegion.Size = Size.Empty;
                IsLeftMouse = false;
            }
        }

        public override bool MouseMove(Graphics graphics, MouseEventArgs e)
        {
            if (!IsLeftMouse)
            {
                return false;
            }

            selectSize.Width = e.X - selectRegion.Left;
            selectSize.Height = e.Y - selectRegion.Top;

            if (selectSize != Size.Empty)
            {
                Parent.Invalidate(selectRegion);
                selectRegion.Size = selectSize;
            }

            return false;
        }

        /*
         * Событие отрисовки
         */
        public void Paint(object sender, PaintEventArgs e)
        {
            if (selectSize != Size.Empty)
            {
                x = selectRegion.Left;
                y = selectRegion.Top;
                width = selectRegion.Width;
                height = selectRegion.Height;

                if (width < 0)
                {
                    x += width;
                    width = -width;
                }
                if (height < 0)
                {
                    y += height;
                    height = -height;
                }

                e.Graphics.FillRectangle(SelectBrush, x, y, width, height);
            }
        }
    }
}
