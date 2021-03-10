using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace FdPractice
{
    [ValueConversion(typeof(string),typeof(BitmapImage))]
    public class StringToImage : IValueConverter
    {
        public static StringToImage instance = new StringToImage();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string path = MainWindow.getName((string)value);
            string image = null;
            if (string.IsNullOrEmpty(path))
            {
                image = "/Images/drive.png";

            }
            else if (new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
            {
                image = "/Images/folder-closed.png";
            }
            else
            {
                image = "/Images/file.png";
            }
            return new BitmapImage(new Uri($"pack://application:,,,{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
