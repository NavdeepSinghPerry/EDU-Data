using Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Mvvm.ViewModels
{
   public class MainWindowVM
    {
        public Customer customer { get; set; }

        public ICommand myCommand { get; set; }

        public bool CanExecute()
        {
            return (!string.IsNullOrEmpty(customer.uservalue
                )?true:false);
        }

        public MainWindowVM()
        {
            customer = new Customer("Navdeep");
            myCommand = new RelayCommand(this);           
        }

        public void showData()
        {
            customer.uservalue = "Subham";
        }

    }
}
