using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace FD
{
    [ValueConversion(typeof(string), typeof(BitmapImage))]
    public class StringToImage : IValueConverter
    {
        public static StringToImage Instance = new StringToImage();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string path = (string)value;

            if (path == null)
            {
                return null;
            }

            var name = MainWindow.getFolderName(path);
            string image = null;

            if (string.IsNullOrEmpty(name))
            {
                image = "/Images/drive.png";
            }
            else if (new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
            {
                image ="/Images/folder-closed.png";
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
