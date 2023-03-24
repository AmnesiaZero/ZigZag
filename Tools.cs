using System.Drawing;
using System.Drawing.Drawing2D;

namespace ZigZag
{
    /*
     * Графические инструменты
     */
    public class Tools
    {
        /*
         * Список свойств графических инструментов
         */
        public enum Property
        {
            // Цвет
            TOOL_COLOR,
            // Толщина
            TOOL_WIDTH
        }

        // "карандаш", "кисть"
        public static GraphicToolPen Pen = new GraphicToolPen(new Pen(Color.Black, 1.0F) { StartCap = LineCap.Round, EndCap = LineCap.Round });

        // "ластик"
        public static GraphicToolEraser Eraser = new GraphicToolEraser(new Pen(Color.White, 1.0F) { StartCap = LineCap.Round, EndCap = LineCap.Round });

        // "заливка"
        public static GraphicToolFill Fill = new GraphicToolFill(new SolidBrush(Color.Black));

        // "выделение области"
        public static GraphicToolSelect Select = new GraphicToolSelect();
    }
}
