﻿using System;
using System.Runtime.Serialization;

namespace RoeeAmzaleg_HWS_Exceptions
{
    [Serializable]
    internal class RepairMismatchException : Exception
    {
        public RepairMismatchException()
        {
        }

        public RepairMismatchException(string message) : base(message)
        {
        }

        public RepairMismatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepairMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}