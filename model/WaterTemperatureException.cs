using System;
using System.Runtime.Serialization;

namespace oop.Model
{
    [Serializable]
    internal class WaterTemperatureException : Exception
    {
        public WaterTemperatureException()
        {
        }

        public WaterTemperatureException(string message) : base(message)
        {
        }

        public WaterTemperatureException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WaterTemperatureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}