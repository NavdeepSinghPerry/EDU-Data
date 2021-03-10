using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mvvm.ViewModels
{
    public class RelayCommand : ICommand
    {
        private MainWindowVM vm = null;

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public RelayCommand(MainWindowVM action)
        {
            vm = action;
        }

        public bool CanExecute(object parameter)
        {
            if (vm.CanExecute())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            vm.showData();
        }
    }
}
