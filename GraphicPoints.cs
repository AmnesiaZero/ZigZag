using System.Drawing;

namespace ZigZag
{
    /*
     * Временный буфер точек координат для отрисовки
     */
    class GraphicPoints
    {
        /*
         * Возвращает буфер точек координат
         */
        public Point[] Array { private set; get; }

        /*
         * Возвращает текущую позицию в буфере
         */
        public int Index { private set; get; }

        /*
         * Возвращает true, если буфер заполнен, иначе - false
         */
        public bool Full
        {
            get
            {
                return Index >= Array.Length;
            }
        }
        
        public GraphicPoints() : this(2)
        {
            
        }

        /*
         * Создает буфер с заданным размером
         */
        public GraphicPoints(int size)
        {
            Index = 0;
            Array = new Point[size];
        }

        /*
         * Добавляет точку по заданным координатам в буфер
         */
        public void AddPoint(int x, int y)
        {
            if (Full)
            {
                Reset();
            }

            Array[Index] = new Point(x, y);
            Index++;
        }

        /*
         * Устанавливает начальную позицию буфера
         */
        public void Reset()
        {
            Index = 0;
        }
    }
}
