using FD.Model;
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
    [ValueConversion(typeof(DirectoryItemType), typeof(BitmapImage))]
    public class StringToImage : IValueConverter
    {
        public static StringToImage Instance = new StringToImage();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string image = null;
            switch ((DirectoryItemType)value)
            {
                case DirectoryItemType.Drive:
                    image = "/Images/drive.png";
                    break;
                case DirectoryItemType.File:
                    image = "/Images/file.png";
                    break;
                case DirectoryItemType.Folder:
                    image = "/Images/folder-closed.png";
                    break;

            }
          
            return new BitmapImage(new Uri($"pack://application:,,,{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
