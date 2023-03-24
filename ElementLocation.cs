using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZigZag
{
    /*
     * Набор методов для размещения элементов управления
     */
    class ElementLocation
    {
        /*
         * Ограничивает положение дочернего окна размерами экрана
         */
        public static Point KeepingInScreenArea(Rectangle bounds, Form parentWindow)
        {
            Rectangle area = Screen.FromControl(parentWindow).WorkingArea;
            Point location = bounds.Location;

            if (bounds.Left + bounds.Width >= area.Width)
            {
                location.X = area.Width - bounds.Width;
            }
            if (bounds.Top + bounds.Height >= area.Height)
            {
                location.Y = area.Height - bounds.Height;
            }

            location.X = Math.Max(location.X, 0);
            location.Y = Math.Max(location.Y, 0);

            return location;
        }

        /*
         * Размещает элемент с указанным смещением относительно центра экрана
         */
        public static void InCenterOfScreen(int x, int y, Control element)
        {
            Rectangle screenBounds = Screen.FromControl(element).Bounds;
            InCenterOf(x, y, element, screenBounds.Width, screenBounds.Height);
        }

        /*
         * Размещает элемент с указанным смещением относительно центра родительского элемента
         */
        public static void InCenterOfElement(int x, int y, Control element, Control parent)
        {
            Size clientSize = parent.ClientSize;
            InCenterOf(x, y, element, clientSize.Width, clientSize.Height);

            // если родительский элемент имеет полосы прокрутки,
            // то добавляем слева и сверху размер поля автоматической прокрутки
            if (parent is ScrollableControl scrollable)
            {
                if (!scrollable.AutoScroll)
                {
                    return;
                }

                if (element.Left <= scrollable.AutoScrollMargin.Width)
                {
                    element.Left = scrollable.AutoScrollMargin.Width;
                }

                if (element.Top <= scrollable.AutoScrollMargin.Height)
                {
                    element.Top = scrollable.AutoScrollMargin.Height;
                }
            }
        }

        /*
         * Размещает элемент с указанным смещением относительно центра заданной прямоугольной области
         */
        private static void InCenterOf(int x, int y, Control element, int parentWidth, int parentHeight)
        {
            int centerX = (parentWidth - element.Width) / 2;
            int centerY = (parentHeight - element.Height) / 2;

            element.Location = new Point(centerX + x, centerY + y);
        }
    }
}
