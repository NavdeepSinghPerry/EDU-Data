using LetsMeet.Core.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LetsMeet.Core
{
   public class LoginPageVM: BaseViewModel
    {
        

        public ICommand RegisterCommand { get; set; }


        public LoginPageVM()
        {
            RegisterCommand = new RelayCommand(async () => await Register());
        }

        public async Task Register()
        {
            //GOTO Register Page

            var viewModel = IoCContainer.Get<ApplicationVM>();
            if (viewModel is ApplicationVM vm)
            {
                vm.CurrentPage = ApplicationType.RegisterPage;
            }
                //ApplicationVM.instance.CurrentPage = ApplicationType.RegisterPage;
                //await Task.Delay(1000);
            }
    }
}
