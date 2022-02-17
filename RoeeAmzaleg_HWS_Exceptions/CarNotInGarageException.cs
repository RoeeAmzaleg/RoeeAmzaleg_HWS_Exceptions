using System;
using System.Runtime.Serialization;

namespace RoeeAmzaleg_HWS_Exceptions
{
    [Serializable]
    internal class CarNotInGarageException : Exception
    {
        public CarNotInGarageException()
        {
        }

        public CarNotInGarageException(string message) : base(message)
        {
        }

        public CarNotInGarageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarNotInGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}