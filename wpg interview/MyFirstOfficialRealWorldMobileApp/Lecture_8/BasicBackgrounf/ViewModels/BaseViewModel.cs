using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBackgrounf
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged=(sender,e)=> { };

        public void OnPropertyChanged(string Property)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(Property));
        }
    }
}
