﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPratice
{
   public class Mail
    {
        public void onEncoded(object sender, EventArgs args)
        {
            MailServer.Send(this);
        }
    }
}
