using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BasicBackgrounf
{
   public class LoginPageVM: BaseViewModel
    {
        public ICommand LoginCommand { get; set; }

        public LoginPageVM()
        {
            this.LoginCommand = new RelayCommand(async () => await Login());
        }

        private async Task Login()
        {

           var window = ((MainWindowVM)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationType.RegisterPage ;                  
        }
    }
}
