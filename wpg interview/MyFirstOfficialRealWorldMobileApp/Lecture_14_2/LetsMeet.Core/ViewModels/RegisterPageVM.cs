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
    public class RegisterPageVM : BaseViewModel
    {


        public ICommand LoginCommand { get; set; }


        public RegisterPageVM()
        {
            LoginCommand = new RelayCommand(async () => await Register());
        }

        public async Task Register()
        {
            var vm = IoCContainer.Get<ApplicationVM>() as ApplicationVM;
            //vm.SideMenuVisible ^= true;
            ////GOTO Register Page

            vm.GoToPage(ApplicationType.LoginPage);
        }
    }
}