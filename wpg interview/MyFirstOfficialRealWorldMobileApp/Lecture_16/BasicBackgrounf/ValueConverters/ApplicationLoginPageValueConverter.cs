using LetsMeet;
using LetsMeet.Core;
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
    public class ApplicationLoginPageValueConverter: BaseValueConverter<ApplicationLoginPageValueConverter>
    {

        public override object Convert(object value, Type targetType=null, object parameter=null, CultureInfo culture=null)
        {
            switch ((ApplicationType)value)
            {
                case ApplicationType.LoginPage:
                    return new LoginPage();

                case ApplicationType.RegisterPage:
                    return new RegisterPage();

                case ApplicationType.ChatPage:
                    return new ChatPage();

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
