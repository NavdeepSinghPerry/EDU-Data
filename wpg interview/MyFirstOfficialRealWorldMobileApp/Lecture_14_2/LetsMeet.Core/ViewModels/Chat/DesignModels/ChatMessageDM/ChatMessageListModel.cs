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
                     Time="10:01 pm"

                },
                new ChatMessageItemVM
                {
                      Message = "Kaha Hai",
                       Time="10:01 pm"
                },
                new ChatMessageItemVM
                {
                   Message = "Chal chale",
                    Time="10:01 pm"
                },
                new ChatMessageItemVM
                {
                     Message = "Agents Jack jana hae k nahi",
                     Time="10:02 pm"

                },
                new ChatMessageItemVM
                {
                     Message = "Ajj wednesday hae fir hmm ni jaege",
                      Time="10:02 pm"
                },
                new ChatMessageItemVM
                {
                     Message = "Sardarji food chlte hein", 
                    Time="10:25 pm"
                },
                new ChatMessageItemVM
                {
                       Message = "Bc bol le jldi",
                    Time="10:25 pm"
                },
                new ChatMessageItemVM
                {
                       Message = "Helloooooooooooooooooooooooooooooooooooooooooooooooo",
                    Time="10:30 pm"
                },
                new ChatMessageItemVM
                {
                    Message = "Arre bhai",
                    Time="10:40 pm"
                },
                new ChatMessageItemVM
                {
                  
                    Message = "I am blocking you", 
                    Time="11:00 pm"

                }


            };

        }
    }
}
