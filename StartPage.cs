using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
//using PngToIcoLib;

namespace ZigZag
{
    /*
     * Формы начальной страницы
     */
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        /*
         * Событие нажатия кнопки "Открыть проект"
         */
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "ZigZagProjects (*.zag)|*.zag";
                openDialog.Multiselect = false;
                openDialog.Title = "Открытие проекта";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream inStream = File.OpenRead(openDialog.FileName))
                    {
                        // открыть проект
                    }
                }
            }
        }

        /*
         * Событие нажатия кнопки "Создать проект"
         */
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            // Открытие и сохранение в выбранном месте нового проекта
        }

        /*
         * Событие загрузки формы
         */
        private void StartPage_Load(object sender, EventArgs e)
        {
            // TODO: заменить значения на относительные
            ElementLocation.InCenterOfElement(-150, 0, CreateBtn, this);
            ElementLocation.InCenterOfElement(150, 0, OpenBtn, this);
            ElementLocation.InCenterOfElement(0, -175, Header, this);
        }

        /*
         * НЕ ВКЛЮЧЕНО В ПРОЕКТ
         */
        private void CreateApplicationIcon()
        {
            string ResourcesPath = Directory.GetParent(Application.StartupPath).Parent.FullName + "\\Resources\\";
            
            Stopwatch timer = Stopwatch.StartNew();

            timer.Start();

            /*PngToIco.BuildIco(ResourcesPath + "256x256.png", ResourcesPath + "icon16.ico", 1);
            PngToIco.BuildIco(ResourcesPath + "256x256.png", ResourcesPath + "icon16_24.ico", 2);
            PngToIco.BuildIco(ResourcesPath + "256x256.png", ResourcesPath + "icon16_32.ico", 3);
            PngToIco.BuildIco(ResourcesPath + "256x256.png", ResourcesPath + "icon16_48.ico", 4);
            PngToIco.BuildIco(ResourcesPath + "256x256.png", ResourcesPath + "icon16_64.ico", 5);
            PngToIco.BuildIco(ResourcesPath + "256x256.png", ResourcesPath + "icon16_128.ico", 6);*/
           // PngToIco.BuildIco(ResourcesPath + "logotype_var5.png", ResourcesPath + "icon16_256_var5.ico", 7);
            timer.Stop();

            double s = timer.ElapsedTicks / (double)Stopwatch.Frequency;
            Console.WriteLine("Время сборки .ico: {0} с.\n{1} мс.\n{2} мкс.",
                s,
                s * 1E3,
                s * 1E6
            );
        }
    }
}
