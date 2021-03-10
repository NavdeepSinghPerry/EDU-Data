using BasicBackgrounf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BasicBackgrounf
{
    public class ApplicationLoginPageValueConverter:IValueConverter
    {
        public static ApplicationLoginPageValueConverter instance = new ApplicationLoginPageValueConverter();
        public  object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationType)value)
            {
                case ApplicationType.LoginPage:
                    return new LoginPage();

                case ApplicationType.RegisterPage:
                    return new RegisterPage();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public  object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
