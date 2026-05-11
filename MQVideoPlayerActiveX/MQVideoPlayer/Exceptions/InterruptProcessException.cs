using System;
using System.Collections.Generic; 
using System.Text;

namespace MQVideoPlayer.Exceptions
{
    public class InterruptProcessException : Exception
    {
        public InterruptProcessException(string msg)
            : base(msg)
        {
        }
    }
}
