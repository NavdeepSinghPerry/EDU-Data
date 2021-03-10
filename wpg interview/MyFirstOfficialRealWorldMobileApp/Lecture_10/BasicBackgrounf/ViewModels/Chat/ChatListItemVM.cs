using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBackgrounf
{
   public class ChatListItemVM: BaseViewModel
    {
        public bool IsNewMessage { get; set; }

        public string Name { get; set; } 

        public string Message { get; set; }

        public string InitialProfileText { get; set; }

        public string ProfilePictureRGB { get; set; }

        public bool IsSelected { get; set; }


    }
}
