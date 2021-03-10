using Ninject;
using LetsMeet;
using LetsMeet.Core;
using LetsMeet.Core.IoC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LetsMeet
{
    public class IoCValueConverter : BaseValueConverter<IoCValueConverter>
    {

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((string)value)
            {
                case nameof(ApplicationVM):
                    return IoCContainer.Get<ApplicationVM>();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
