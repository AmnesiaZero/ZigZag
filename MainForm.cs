using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ZigZag
{
    /*
     * Главное окно
     */
    public partial class MainForm : Form
    {
        /*
         * Набор цветов для отображения таблицы цветов
         */

        private readonly List<Color> ColorsInTable = new List<Color>()
        {
            Color.Yellow, Color.Red, Color.Blue,
            Color.Orange, Color.Purple, Color.Green,
            Color.FromArgb(255, 185, 2), Color.FromArgb(255, 76, 2), Color.FromArgb(233, 1, 130),
            Color.FromArgb(3, 78, 162), Color.FromArgb(0, 155, 169), Color.FromArgb(133, 193, 4),
            Color.Black, Color.White
        };

        public MainForm()
        {
            InitializeComponent();
        }

        /*
         * Устанавливает заданный графический инструмент текущим
         */
        private T SetGraphicTool<T>(T value) where T: GraphicTool
        {
            // отписываемся от предыдущего события
            if (PictureEditZone.CurrentTool != null)
            {
                PictureEditZone.CurrentTool.PropertyChanged -= GraphicTool_PropertyChanged;
            }

            PictureEditZone.CurrentTool = value;

            // подписываемся к событию
            PictureEditZone.CurrentTool.PropertyChanged += GraphicTool_PropertyChanged;

            return (T)PictureEditZone.CurrentTool;
        }

        /*
         * Создает таблицу цветов
         */
        private void FillColorTable()
        {
            for (int i = 0; i < ColorTable.RowCount; i++)
            {
                for (int j = 0; j < ColorTable.ColumnCount; j++)
                {
                    int ij = i * ColorTable.ColumnCount + j;

                    if (ij >= ColorsInTable.Count)
                    {
                        return;
                    }

                    ColorTableCell cell = new ColorTableCell(ColorsInTable[ij]);

                    cell.MouseClick += (o, e) =>
                    {
                        if (e.Button != MouseButtons.Left)
                        {
                            return;
                        }

                        var pos = ColorTable.GetCellPosition((Control)o);

                        PictureEditZone.CurrentTool.SetProperty(Tools.Property.TOOL_COLOR, ColorsInTable[pos.Row * ColorTable.ColumnCount + pos.Column]);
                    };

                    ColorTable.Controls.Add(cell, j, i);
                }
            }
        }

        /*
         * Событие загрузки окна
         */
        private void MainForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon16_256;
            
            FillColorTable();
            PictureEditZone.Create(PictureEditZone.Width, PictureEditZone.Height);
            GraphicToolPen tool = SetGraphicTool(Tools.Pen);
            tool.SetProperty(Tools.Property.TOOL_WIDTH, (float)ToolWidthBar.Value);
        }

        /*
         * Событие нажатия на элемент меню "открыть"
         */
        private void Open_TS_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                Format[] validFileFormats = new Format[] {
                    new Format("PNG", "png"),
                    new Format("JPG", "jpg", "jpeg", "jpe", "jfif", "exif"),
                    new Format("BMP", "bmp", "dib", "rle")
                };

                dialog.Filter = Format.GetFileFilter(validFileFormats);
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = dialog.OpenFile())
                    {
                        PictureEditZone.Load(stream);
                        TabPage.Text = dialog.FileName.Substring(dialog.FileName.LastIndexOf('\\') + 1);
                        TabPage.ToolTipText = dialog.FileName;
                    }
                }
            }
        }

        /*
         * Событие нажатия на элемент меню "сохранить"
         */
        private void Save_TS_Click(object sender, EventArgs e)
        {

        }

        /*
         * Событие нажатия на элемент меню "сохранить как"
         */
        private void SaveAs_TS_Click(object sender, EventArgs e)
        {

        }

        /*
         * Событие нажатия на элемент меню "создать"
         */
        private void Create_TS_Click(object sender, EventArgs e)
        {
            // открываем окно создания изображения
            CreateBitmapDialog createWindow = new CreateBitmapDialog(PictureEditZone)
            {
                ShowInTaskbar = false
            };

            ElementLocation.InCenterOfElement(Left, Top, createWindow, this);

            // ограничения, чтобы окно не могло выйти за границы экрана
            createWindow.Location = ElementLocation.KeepingInScreenArea(createWindow.Bounds, this);

            createWindow.ShowDialog();
        }

        /*
         * Событие изменения значения полосы прокрутки "толщина инструмента"
         */
        private void WidthPropBar_Scroll(object sender, EventArgs e)
        {
            PictureEditZone.CurrentTool.SetProperty(Tools.Property.TOOL_WIDTH, (float)ToolWidthBar.Value);
        }

        /*
         * Событие подтверждения выбора цвета из палитры цветов
         */
        private void ColorDialogBtn_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }

        /*
         * Событие нажатия кнопки "цвет по умолчанию"
         */
        private void DefaultColorBtn_Click(object sender, EventArgs e)
        {

        }

        /*
         * Событие изменения позиции дочерних элементов управления (для элемента управления LoadedFileTabPage)
         */
        private void LoadedFileTabPage_Layout(object sender, LayoutEventArgs e)
        {
            ElementLocation.InCenterOfElement(0, 0, PictureEditZone, (Control)sender);
        }

        /*
         * Событие выбора "карандаш" как текущего граф. инстр.
         */
        private void PenTool_Click(object sender, EventArgs e)
        {
            GraphicToolPen obj = SetGraphicTool(Tools.Pen);
            obj.SetProperty(Tools.Property.TOOL_WIDTH, 1F);
        }

        /*
         * Событие выбора "кисть" как текущего граф. инстр.
         */
        private void BrushTool_Click(object sender, EventArgs e)
        {
            GraphicToolPen obj = SetGraphicTool(Tools.Pen);
            obj.SetProperty(Tools.Property.TOOL_WIDTH, (float)ToolWidthBar.Value);
        }

        /*
         * Событие выбора "ластик" как текущего граф. инстр.
         */
        private void EraserTool_Click(object sender, EventArgs e)
        {
            GraphicToolEraser obj = SetGraphicTool(Tools.Eraser);
            obj.SetProperty(Tools.Property.TOOL_WIDTH, (float)ToolWidthBar.Value);
        }

        /*
         * Событие выбора "заливка" как текущего граф. инстр.
         */
        private void FillTool_Click(object sender, EventArgs e)
        {
            GraphicToolFill obj = SetGraphicTool(Tools.Fill);
        }

        /*
         * Событие выбора "выделение области" как текущего граф. инстр.
         */
        private void SelectTool_Click(object sender, EventArgs e)
        {
            GraphicToolSelect obj = SetGraphicTool(Tools.Select);
        }

        private void GraphicTool_PropertyChanged(object sender, GraphicToolPropertyEventArgs e)
        {
            Console.WriteLine("fired event from tool {0} and args {1} {2}", sender, e.Property, e.NewValue);

            if (e.Property == Tools.Property.TOOL_COLOR)
            {
                if (CurrentColorBtn.BackColor != (Color)e.NewValue)
                {
                    CurrentColorBtn.BackColor = (Color)e.NewValue;
                }
            }
        }

        /*
         * Событие нажатия кнопки "изменить размер" применяется к текущему изображению
         */
        private void Resize_TS_Click(object sender, EventArgs e)
        {
            ResizeBitmapDialog resizeWindow = new ResizeBitmapDialog(PictureEditZone)
            {
                ShowInTaskbar = false
            };

            ElementLocation.InCenterOfElement(Left, Top, resizeWindow, this);

            // ограничения, чтобы окно не могло выйти за границы экрана
            resizeWindow.Location = ElementLocation.KeepingInScreenArea(resizeWindow.Bounds, this);

            resizeWindow.ShowDialog();
        }
    }
}
