using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMeet.Core
{
   public class ChatMessageListModel : ChatMessageListVM
    {
        public static ChatMessageListModel Instance => new ChatMessageListModel();
          public ChatMessageListModel()
         {
            Items = new List<ChatMessageItemVM>
            {
                new ChatMessageItemVM
                {
                     Message = "Hello",
                     SenderName="Subham",
                     Initials="SS",
                     ProfilePictureRGB="3099c5",
                     MessageSentTime=DateTimeOffset.UtcNow,
                     SentByMe=false                                      
                },
                new ChatMessageItemVM
                {
                      Message = "Kaha Hai",
                       SenderName="Subham",
                     Initials="SS",
                     ProfilePictureRGB="3099c5",
                     MessageSentTime=DateTimeOffset.UtcNow,
                     SentByMe=false


                },
                new ChatMessageItemVM
                {
                   Message = "Chal chale",
                    SenderName="Subham",
                     Initials="SS",
                     ProfilePictureRGB="3099c5",
                     MessageSentTime=DateTimeOffset.UtcNow,
                     SentByMe=true

                },
                new ChatMessageItemVM
                {
                     Message = "Agents Jack jana hae k nahi",
                      SenderName="Subham",
                     Initials="SS",
                     ProfilePictureRGB="3099c5",
                     MessageSentTime=DateTimeOffset.UtcNow,
                     SentByMe=false


                },
                new ChatMessageItemVM
                {
                     Message = "Ajj wednesday hae fir hmm ni jaege",
                      SenderName="Subham",
                     Initials="SS",
                     ProfilePictureRGB="3099c5",
                     MessageSentTime=DateTimeOffset.UtcNow,
                     SentByMe=true

                },
                new ChatMessageItemVM
                {
                     Message = "Sardarji food chlte hein",
                      SenderName="Subham",
                     Initials="SS",
                     ProfilePictureRGB="3099c5",
                     MessageSentTime=DateTimeOffset.UtcNow,
                     SentByMe=false

                },
                new ChatMessageItemVM
                {
                       Message = "Bc bol le jldi",
                        SenderName="Subham",
                     Initials="SS",
                     ProfilePictureRGB="3099c5",
                     MessageSentTime=DateTimeOffset.UtcNow,
                     SentByMe=true

                },
                new ChatMessageItemVM
                {
                       Message = "Helloooooooooooooooooooooooooooooooooooooooooooooooo",
                        SenderName="Subham",
                     Initials="SS",
                     ProfilePictureRGB="3099c5",
                     MessageSentTime=DateTimeOffset.UtcNow,
                     SentByMe=false

                },
                new ChatMessageItemVM
                {
                    Message = "Arre bhai",
                    SenderName="Subham",
                     Initials="SS",
                     ProfilePictureRGB="3099c5",
                     MessageSentTime=DateTimeOffset.UtcNow,
                     SentByMe=false
                },
                new ChatMessageItemVM
                {
                  
                    Message = "Sorry Cannot Come",
                    SenderName="Navdeep",
                     Initials="NS",
                     ProfilePictureRGB="3099c5",
                     MessageSentTime=DateTimeOffset.UtcNow,
                     MessageReadTime=DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3)),
                     SentByMe=true

                }


            };

        }
    }
}
