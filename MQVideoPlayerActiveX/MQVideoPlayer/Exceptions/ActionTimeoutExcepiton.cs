using System;
using System.Collections.Generic; 
using System.Text;

namespace MQVideoPlayer.Exceptions
{
    public class ActionTimeoutExcepiton :Exception
    {

        public ActionTimeoutExcepiton(string msg):base(msg)
        { 

        }
    }
}
