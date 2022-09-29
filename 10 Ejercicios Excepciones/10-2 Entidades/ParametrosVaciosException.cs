using System;
using System.Runtime.Serialization;

namespace _10_2_Entidades
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException()
        {
        }

        public ParametrosVaciosException(string message) : base(message)
        {
        }

        public ParametrosVaciosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParametrosVaciosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public override string Message 
        {
            get
            {
                return "No se ingresaron datos";
            }
        }

    }
}
