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
    public class LoginPageVM : BaseViewModel
    {


        public ICommand RegisterCommand { get; set; }

        public ICommand LoginCommand { get; set; }

        public bool LoginIsRunning { get; set; }

        public LoginPageVM()
        {
            LoginCommand = new RelayCommand(async () => { await Login(); });
            RegisterCommand = new RelayCommand(async () => await Register());
        }

        public async Task Login()
        {
            await RunCommandAsync(() => LoginIsRunning, async () =>
            {

                var vm = IoCContainer.Get<ApplicationVM>() as ApplicationVM;
                vm.GoToPage(ApplicationType.ChatPage);
         
                await Task.Delay(5000);
            
            });
        }

        public async Task Register()
        {
            var vm = IoCContainer.Get<ApplicationVM>() as ApplicationVM;
            //vm.SideMenuVisible ^= true;
            //GOTO Register Page

            vm.CurrentPage = ApplicationType.RegisterPage;
        }
    }
}