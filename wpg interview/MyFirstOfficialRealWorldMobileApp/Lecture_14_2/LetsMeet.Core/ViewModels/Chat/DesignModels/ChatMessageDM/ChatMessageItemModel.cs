using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMeet.Core
{
   public class ChatMessageItemModel : ChatMessageItemVM
    {
        public static ChatMessageItemModel Instance => new ChatMessageItemModel();
          public ChatMessageItemModel()
         {

            Message = "Hello Navdeep";

        }
    }
}
