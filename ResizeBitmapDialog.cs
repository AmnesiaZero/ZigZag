using System;
using System.Windows.Forms;

namespace ZigZag
{
    /*
     * Окно создания нового изображения
     */
    public partial class ResizeBitmapDialog : Form
    {
        private float Ratio;
        /*
         * Возвращает элемент управления "редактор изображения"
         */
        public BitmapEditor Picture { get; }
        

        public ResizeBitmapDialog()
        {
            InitializeComponent();
        }

        public ResizeBitmapDialog(BitmapEditor editor) : this()
        {
            Picture = editor;
        }

        /*
         * Событие нажатия кнопки "Ок"
         */
        private void OkBtn_Click(object sender, EventArgs e)
        {
            Picture.SetSize((int)WidthValue.Value, (int)HeightValue.Value);
            Close();
        }

        /*
         * Событие изменения значения поля ширины
         */
        private void WidthValue_ValueChanged(object sender, EventArgs e)
        {
            if (!KeepRatio_CB.Checked)
            {
                return;
            }

            if (WidthValue.Focused)
            {
                HeightValue.Value = (int)Math.Round((int)WidthValue.Value / Ratio);
            }
        }

        /*
         * Событие изменения значения поля высоты
         */
        private void HeightValue_ValueChanged(object sender, EventArgs e)
        {
            if (!KeepRatio_CB.Checked)
            {
                return;
            }

            if (HeightValue.Focused)
            {
                WidthValue.Value = (int)Math.Round((int)HeightValue.Value * Ratio);
            }
        }

        /*
         * Событие загрузки окна
         */
        private void CreateBitmapDialog_Load(object sender, EventArgs e)
        {
            WidthValue.Value = Picture.Width;
            HeightValue.Value = Picture.Height;

            WidthValue.GotFocus += (send, args) =>
            {
                WidthValue.Select(0, WidthValue.Text.Length);
            };

            HeightValue.GotFocus += (send, args) =>
            {
                HeightValue.Select(0, HeightValue.Text.Length);
            };
        }

        /*
         * Событие изменения состояния элемента "сохранить пропорции"
         */
        private void KeepRatio_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (KeepRatio_CB.Checked)
            {
                Ratio = (float)Math.Round((int)WidthValue.Value / (float)HeightValue.Value, 3);
            }
        }
    }
}
