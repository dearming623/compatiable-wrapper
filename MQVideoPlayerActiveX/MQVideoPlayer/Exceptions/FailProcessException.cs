using System;
using System.Collections.Generic; 
using System.Text;

namespace MQVideoPlayer.Exceptions
{
    public class FailProcessException : Exception
    {
        public FailProcessException(string msg)
            : base(msg)
        {
        }
    }
}
