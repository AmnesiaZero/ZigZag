using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZigZag
{
    /*
     * Ячейка таблицы цветов
     */
    class ColorTableCell : Panel
    {
        public ColorTableCell(Color color)
        {
            Margin = Padding.Empty;
            Dock = DockStyle.Fill;
            BackColor = color;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // отрисовка рамки вокруг ячейки, если на нее наведена мышь
            int border = 1;
            Color color = Color.Black;
            ButtonBorderStyle style = ButtonBorderStyle.Solid;

            using (var graphics = CreateGraphics())
            {
                Rectangle bounds = ClientRectangle;
                ControlPaint.DrawBorder(graphics, bounds, color, style);
                color = Color.White;
                bounds.Size = new Size(bounds.Width - 2 * border, bounds.Height - 2 * border);
                bounds.X = border;
                bounds.Y = border;
                ControlPaint.DrawBorder(graphics, bounds, color, style);
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            Refresh();
        }
    }
}
