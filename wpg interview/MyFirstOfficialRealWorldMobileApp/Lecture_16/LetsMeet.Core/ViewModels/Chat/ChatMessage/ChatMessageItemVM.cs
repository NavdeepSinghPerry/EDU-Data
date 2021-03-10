using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMeet.Core
{
   public class ChatMessageItemVM : BaseViewModel
    {
      
        public string SenderName { get; set; }

        public string Message { get; set; }

        public string Initials { get; set; }

        public string ProfilePictureRGB { get; set; }

        public bool IsSelected { get; set; }

        public bool SentByMe { get; set; }

        //by default it is DateTimeOffset.MinValue
        public DateTimeOffset MessageReadTime { get; set; }

        public DateTimeOffset MessageSentTime { get; set; }

        //public bool MessageRead
        //{
        //    //get
        //    //{
        //    //    if(MessageReadTime > DateTimeOffset.MinValue)
        //    //    {
        //    //        return true;
        //    //    }
        //    //    else
        //    //    {
        //    //        return false;
        //    //    }
        //    //}  
        //}

        //Short Hand for the above commented property
        public bool MessageRead => MessageReadTime > DateTimeOffset.MinValue;

       
    }
}
