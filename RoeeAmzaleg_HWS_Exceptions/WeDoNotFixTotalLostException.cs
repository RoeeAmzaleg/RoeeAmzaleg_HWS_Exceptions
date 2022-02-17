﻿using System;
using System.Runtime.Serialization;

namespace RoeeAmzaleg_HWS_Exceptions
{
    [Serializable]
    internal class WeDoNotFixTotalLostException : Exception
    {
        public WeDoNotFixTotalLostException()
        {
        }

        public WeDoNotFixTotalLostException(string message) : base(message)
        {
        }

        public WeDoNotFixTotalLostException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeDoNotFixTotalLostException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}