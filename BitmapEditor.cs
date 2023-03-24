using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace ZigZag
{
    /*
     * Элемент управления "редактор изображения"
     */
    public class BitmapEditor : PictureBox
    {
        private Bitmap Picture;
        private Graphics PictureGraphics;
        private GraphicTool CurrentToolField;

        /*
         * Задает или возвращает текущий графический инструмент
         */
        [Browsable(false)]
        public GraphicTool CurrentTool
        {
            set
            {
                if (value != null)
                {
                    value.Initialize(this);
                    CurrentToolField = value;
                }
            }
            get
            {
                return CurrentToolField;
            }
        }

        public BitmapEditor() : base()
        {

        }

        /*
         * Событие изменения свойства Enabled
         */
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            BackColor = Enabled ? Color.Gainsboro : Color.DarkGray;
        }

        /*
         * Загружает изображение из потока данных
         */
        public void Load(Stream stream)
        {
            Load((Bitmap)Image.FromStream(stream));
        }

        /*
         * Загружает изображение из Bitmap объекта
         */
        public void Load(Bitmap bitmap)
        {
            Width = bitmap.Width;
            Height = bitmap.Height;
            Picture = bitmap;
            Image = bitmap;
            PictureGraphics = Graphics.FromImage(bitmap);
        }

        /*
         * Загружает пустое изображение с заданными размерами
         */
        public void Create(int width, int height)
        {
            Load(new Bitmap(width, height));
        }

        /*
         * Задает размер элементу
         */
        public void SetSize(int width, int height)
        {
            if (Picture == null)
            {
                throw new Exception("Изображение еще не создано!");
            }

            Width = width;
            Height = height;
        }

        /*
         * Событие нажатия клавиши мыши
         */
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (CurrentTool != null)
            {
                CurrentTool.MouseDown(e);
            }
        }

        /*
         * Событие отжатия клавиши мыши
         */
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (CurrentTool != null)
            {
                CurrentTool.MouseUp(e);
            }
        }

        /*
         * Событие движения мыши
         */
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (CurrentTool != null && CurrentTool.MouseMove(PictureGraphics, e))
            {
                Refresh();
            }
        }
    }
}
