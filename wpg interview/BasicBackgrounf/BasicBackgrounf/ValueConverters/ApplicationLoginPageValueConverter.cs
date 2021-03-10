using LetsApp;
using LetsApp.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LetsApp
{
    public class ApplicationLoginPageValueConverter: IValueConverter
    {
        public static ApplicationLoginPageValueConverter instance = new ApplicationLoginPageValueConverter();
        public  object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationType)value)
            {
                case ApplicationType.LoginPage:
                    return new LoginPage();
                                   
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
