using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMeet.Core
{
   public class ChatListItemDesignModel : ChatListItemVM
    {
        public static ChatListItemDesignModel Instance { get { return new ChatListItemDesignModel(); } }
          public ChatListItemDesignModel()
         {
           Name = "Duke";
           Message= "This new chat app is awesome. I bet you will forget whatsapp";
           InitialProfileText = "DA";
           ProfilePictureRGB = "ff0000";
         }
    }
}
