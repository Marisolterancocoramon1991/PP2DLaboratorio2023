using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BibliotecaDeClases
{
    [Serializable]
    public class ContieneArrobaException : Exception
    {
        public ContieneArrobaException()
        {
        }

        public ContieneArrobaException(string? message) : base(message)
        {
        }

        public ContieneArrobaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ContieneArrobaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
