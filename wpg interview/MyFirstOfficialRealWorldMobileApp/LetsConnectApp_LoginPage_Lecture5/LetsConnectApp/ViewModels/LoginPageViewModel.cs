using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LetsConnectApp
{
   public class LoginPageViewModel: BaseViewModel
    {
        #region Private Members
        private int cornerRadius { get; set; } = 10;


        #endregion

        #region Public Members
        public CornerRadius CornerRadius
        {
            get { return new CornerRadius(cornerRadius); }
        }

        #endregion


        public LoginPageViewModel()
        {

        }


    }
}
