using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BasicBackgrounf
{
   public class LoginPageVM: BaseViewModel
    {
        public CornerRadius CornerRadius { get { return new CornerRadius(20); } }

        public LoginPageVM()
        {

        }
    }
}
