using BasicBackgrounf;
using BasicBackgrounf.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace BasicBackgrounf
{
    public class StringToColorValueConverter : BaseValueConverter<StringToColorValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            return (SolidColorBrush)(new BrushConverter().ConvertFrom($"#{value}"));
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    
    }
}
