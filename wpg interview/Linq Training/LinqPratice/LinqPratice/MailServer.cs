using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPratice
{
    public class MailServer
    {
        public static void Send(object sender)
        {
            if (sender is Mail mail)
            {
                Console.WriteLine("Video sent by mail");
            }
            else if (sender is Fax fax)
            {
                Console.WriteLine("Video sent by Fax");
            }
        }
    }
}
