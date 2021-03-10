using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMeet.Core
{
   public class ChatMessageListVM : BaseViewModel
    {
        public List<ChatMessageItemVM> Items { get; set; }
       
    }
}
