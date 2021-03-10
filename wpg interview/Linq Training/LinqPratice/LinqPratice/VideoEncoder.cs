using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinqPratice.VideoEncoder;

namespace LinqPratice
{
   public class VideoEncoder
    {
        //Create a delegate
        //Create an event based on the above delegate
        //Raise an event

        //public delegate void VideoEncodedEventHandler(object sender, EventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;


        public Action<object, EventArgs> VideoEncoded;

        public void Encoded(Video video)
        {
            // Video Encoded

            //MailServer.Send(new Mail());

            onEncoded();

        }

        protected virtual void onEncoded()
        {
            VideoEncoded(this, EventArgs.Empty);
        }




    }
}
