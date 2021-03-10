using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
namespace Mvvm.Models
{
   [AddINotifyPropertyChangedInterface]
  public class Customer : INotifyPropertyChanged
    {
        private string UserName;

        public string uservalue
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
                
            }
        }
        

        public Customer(string value)
        {
            uservalue = value;
        }
        
        public event PropertyChangedEventHandler PropertyChanged=(sender,e)=> { };

        public void onPropertyChanged(string property)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
