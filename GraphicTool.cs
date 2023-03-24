using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZigZag
{
    /*
     * Аргументы для события изменения свойства графического инструмента
     */
    public class GraphicToolPropertyEventArgs : EventArgs
    {
        public Tools.Property Property { get; }
        public object NewValue { get; }

        public GraphicToolPropertyEventArgs(Tools.Property property, object newValue)
        {
            Property = property;
            NewValue = newValue;
        }
    }

    /*
     * Абстрактный класс графического инструмента
     */
    public abstract class GraphicTool
    {
        /*
         * Задает или возвращает базовый объект графического инструмента
         */
        public object Base { protected set; get; }

        /*
         * Событие изменения свойства графического инструмента
         */
        public delegate void GraphicToolPropertyChangedHandler(object sender, GraphicToolPropertyEventArgs e);
        public event GraphicToolPropertyChangedHandler PropertyChanged;

        /*
         * Инициализирует объект
         */
        public abstract void Initialize(object TabPage);

        /*
         * Задает значение выбранному свойству инструмента
         */
        public virtual void SetProperty(Tools.Property property, object value)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new GraphicToolPropertyEventArgs(property, value));
            }
        }

        /*
         * Событие нажатия кнопки мыши
         */
        public abstract void MouseDown(MouseEventArgs e);

        /*
         * Событие отжатия кнопки мыши
         */
        public abstract void MouseUp(MouseEventArgs e);

        /*
         * Событие движения мыши
         */
        public abstract bool MouseMove(Graphics graphics, MouseEventArgs e);
    }
}
