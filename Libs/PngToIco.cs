using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace PngToIcoLib
{

    /* .Png to .Ico format converter
     * A simple class that converts a image to a icon in c# without losing image color data,
     * unlike System.Drawing.Icon; ico with png data requires Windows Vista or above
     * 
     * Author: darkfall
     * Link: gist.github.com/darkfall/1656050
     * 
     * Modified: 7 march 2023
     * Author: gug2
     */
    public static class PngToIco
    {
        /* input image with width = height is suggested to get the best result */
        /* png support in icon was introduced in Windows Vista */
        public static bool Convert(Stream input_stream, Stream output_stream, int size, bool keep_aspect_ratio = false)
        {
            Bitmap input_bit = (Bitmap)Image.FromStream(input_stream);
            if (input_bit != null)
            {
                int width, height;
                if (keep_aspect_ratio)
                {
                    width = size;
                    height = input_bit.Height / input_bit.Width * size;
                }
                else
                {
                    width = height = size;
                }

                //System.Drawing.Bitmap new_bit = new System.Drawing.Bitmap(input_bit, new System.Drawing.Size(width, height));
                // замена, для копирования из исходного изображения формата кодирования пикселей
                Bitmap new_bit = input_bit.Clone(new Rectangle(0, 0, width, height), input_bit.PixelFormat);

                if (new_bit != null)
                {
                    // save the resized png into a memory stream for future use
                    MemoryStream mem_data = new MemoryStream();
                    new_bit.Save(mem_data, ImageFormat.Png);

                    BinaryWriter icon_writer = new BinaryWriter(output_stream);
                    if (output_stream != null && icon_writer != null)
                    {
                        // 0-1 reserved, 0
                        icon_writer.Write((byte)0);
                        icon_writer.Write((byte)0);

                        // 2-3 image type, 1 = icon, 2 = cursor
                        icon_writer.Write((short)1);

                        // 4-5 number of images
                        icon_writer.Write((short)1);

                        // image entry 1
                        // 0 image width
                        icon_writer.Write((byte)width);
                        // 1 image height
                        icon_writer.Write((byte)height);

                        // 2 number of colors
                        icon_writer.Write((byte)0);

                        // 3 reserved
                        icon_writer.Write((byte)0);

                        // 4-5 color planes
                        icon_writer.Write((short)0);

                        // 6-7 bits per pixel
                        mem_data.Seek(24, SeekOrigin.Begin);
                        int bpp = mem_data.ReadByte();
                        int colorType = mem_data.ReadByte();

                        if (colorType == 0)
                        {
                            // grayscale sample
                        }
                        else if (colorType == 2)
                        {
                            bpp *= 3; // triple of channels - R, G, B
                        }
                        else if (colorType == 3)
                        {
                            // pallete index
                        }
                        else if (colorType == 4)
                        {
                            // grayscale sample + alpha
                            bpp *= 2;
                        }
                        else if (colorType == 6)
                        {
                            // R, G, B, + alpha
                            bpp *= 4;
                        }

                        icon_writer.Write((short)bpp);

                        // 8-11 size of image data
                        icon_writer.Write((int)mem_data.Length);

                        // 12-15 offset of image datas

                        icon_writer.Write((uint)(6 + 16));

                        // write image data
                        // png data must contain the whole png data file
                        icon_writer.Write(mem_data.ToArray());

                        icon_writer.Flush();

                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public static bool Convert(string input_image, string output_icon, int size, bool keep_aspect_ratio = false)
        {
            FileStream input_stream = new FileStream(input_image, FileMode.Open);
            FileStream output_stream = new FileStream(output_icon, FileMode.OpenOrCreate);

            bool result = Convert(input_stream, output_stream, size, keep_aspect_ratio);

            input_stream.Close();
            output_stream.Close();

            return result;
        }

        /*
         * Метод для сборки .ico файла из исходного .png изображения
         */
        public static bool BuildIco(string input_image, string output_icon, short count)
        {
            if (!File.Exists(input_image))
            {
                return false;
            }

            bool result;

            using (FileStream input = File.OpenRead(input_image))
            {
                using (FileStream output = File.OpenWrite(output_icon))
                {
                    result = BuildIco(input, output, count);
                }
            }

            return result;
        }

        /*
         * Метод для сборки .ico файла из исходного .png изображения
         */
        private static bool BuildIco(Stream input_stream, Stream output_stream, short iconCount)
        {
            if (output_stream == null || input_stream == null || iconCount < 1)
            {
                return false;
            }

            Bitmap input_image = (Bitmap)Image.FromStream(input_stream);

            // подготавливаем изображения
            int[] iconBounds = new int[] { 16, 24, 32, 48, 64, 128, 256 };
            MemoryStream[] preparedIcons = new MemoryStream[iconCount];
            for (int i = 0; i < preparedIcons.Length; i++)
            {
                preparedIcons[i] = new MemoryStream();
                Bitmap current = new Bitmap(input_image, new Size(iconBounds[i], iconBounds[i]));
                current.Save(preparedIcons[i], ImageFormat.Png);
            }

            using (BinaryWriter icon_writer = new BinaryWriter(output_stream))
            {
                int[] imagePointers = new int[iconCount];

                // запись заголовка
                if (icon_writer != null)
                {
                    icon_writer.Write((short)0);
                    icon_writer.Write((short)1);
                    icon_writer.Write(iconCount);
                }

                icon_writer.Seek(16 * iconCount, SeekOrigin.Current);

                // запись изображений
                for (int i = 0; i < preparedIcons.Length; i++)
                {
                    // записываем полную информацию о png файле (вместе с заголовками)
                    // сохраняем указатель на начало блока с данными
                    imagePointers[i] = (int)icon_writer.BaseStream.Position;
                    icon_writer.Write(preparedIcons[i].ToArray());
                }

                icon_writer.Seek(6, SeekOrigin.Begin);

                // запись каталога изображений
                for (int i = 0; i < preparedIcons.Length; i++)
                {
                    // 0 image width
                    icon_writer.Write((byte)iconBounds[i]);
                    // 1 image height
                    icon_writer.Write((byte)iconBounds[i]);
                    // 2 number of colors
                    icon_writer.Write((byte)0);
                    // 3 reserved
                    icon_writer.Write((byte)0);
                    // 4-5 color planes
                    icon_writer.Write((short)0);

                    // 6-7 bits per pixel
                    preparedIcons[i].Seek(24, SeekOrigin.Begin);
                    byte colorDepth = (byte)preparedIcons[i].ReadByte();
                    byte colorType = (byte)preparedIcons[i].ReadByte();

                    if (colorType == 0)
                    {
                        // grayscale sample
                    }
                    else if (colorType == 2)
                    {
                        colorDepth *= 3; // triple of channels - R, G, B
                    }
                    else if (colorType == 3)
                    {
                        // pallete index
                    }
                    else if (colorType == 4)
                    {
                        // grayscale sample + alpha
                        colorDepth *= 2;
                    }
                    else if (colorType == 6)
                    {
                        // R, G, B + alpha
                        colorDepth *= 4;
                    }

                    icon_writer.Write((short)colorDepth);

                    // 8-11 size of image data
                    icon_writer.Write((int)preparedIcons[i].Length);
                    // 12-15 offset of image datas

                    icon_writer.Write(imagePointers[i]);
                    preparedIcons[i].Close();
                    preparedIcons[i].Dispose();
                }
            }

            return true;
        }
    }
}