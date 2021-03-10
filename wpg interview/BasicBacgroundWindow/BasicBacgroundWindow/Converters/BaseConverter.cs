using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace BasicBacgroundWindow
{
    public abstract class BaseConverter<T> : MarkupExtension, IValueConverter
        where T: ApplicationTypeConverter, new()
    {
        public T instance = null;

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
           return  instance ?? new T();
        }

        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);


        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
      
    }
}
