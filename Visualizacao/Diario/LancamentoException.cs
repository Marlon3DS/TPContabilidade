using System;
using System.Runtime.Serialization;

namespace Diario
{
    [Serializable]
    internal class LancamentoException : Exception
    {
        public LancamentoException()
        {
        }

        public LancamentoException(string message) : base(message)
        {
        }

        public LancamentoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LancamentoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}