using System;
using System.Runtime.Serialization;

namespace TfsClientAbstraction
{
    public class TfsException : Exception
    {
        public TfsException() { }

        public TfsException(string message) : base(message) { }

        public TfsException(string message, Exception innerException) : base(message, innerException) { }

        protected TfsException(SerializationInfo info, StreamingContext context) { }
    }
}