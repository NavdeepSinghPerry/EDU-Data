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

            Message = "Hello Navdeep, How are you?";
            SenderName = "Navdeep";
            Initials = "NS";
            ProfilePictureRGB = "3099c5";
            MessageSentTime = DateTimeOffset.UtcNow;
            MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3));
            SentByMe = true;

        }
    }
}
