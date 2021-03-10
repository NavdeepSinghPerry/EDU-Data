using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMeet.Core
{
   public class ChatListVM : BaseViewModel
    {
        public List<ChatListItemVM> Items { get; set; }
       
    }
}
