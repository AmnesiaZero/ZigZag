using System;
using System.Collections.Generic;
using System.Text;

namespace ZigZag
{
    /*
     * Формат файлов
     */
    class Format
    {
        /*
         * Возвращает расширения файлов для формата
         */
        public string[] Names { get; }
        /*
         * Возвращает название и/или описание формата
         */
        public string Description { get; }

        public Format(string Description, params string[] Names)
        {
            this.Description = Description;
            this.Names = Names;
        }

        /*
         * Собирает массив форматов в строку-фильтр
         */
        public static string GetFileFilter(Format[] validFormats)
        {
            StringBuilder filter = new StringBuilder();

            if (validFormats == null || validFormats.Length == 0)
            {
                return "All files|*.*";
            }

            // получаем список всех форматов
            filter.Append("Все форматы ");

            List<string> allFormats = new List<string>();
            foreach (Format elem in validFormats)
            {
                foreach (string name in elem.Names)
                {
                    allFormats.Add(name);
                }
            }
            AddFormats(filter, String.Join("; *.", allFormats));


            // получаем список отдельно для каждого формата
            foreach (Format elem in validFormats)
            {
                filter.Append(elem.Description);
                filter.Append(' ');
                AddFormats(filter, String.Join("; *.", elem.Names));
            }

            filter.Remove(filter.Length - 1, 1);
            return filter.ToString();
        }

        /*
         * Добавляет фильтр для формата в общую строку-фильтр
         */
        private static void AddFormats(StringBuilder filter, string names)
        {
            if (names == "")
            {
                names = "*";
            }

            filter.Append("(*.");
            filter.Append(names);
            filter.Append(")|*.");
            filter.Append(names);
            filter.Append('|');
        }
    }
}
