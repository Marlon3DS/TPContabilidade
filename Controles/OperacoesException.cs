using System;

namespace Controles
{
    public class OperacoesException : Exception
    {
        public OperacoesException(string mensagem) : base(mensagem) { }
    }
}
