using System;

namespace Exceptions
{
    public abstract class FaturamentoException : Exception
    {
        protected FaturamentoException(string message) : base(message) { }
        protected FaturamentoException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class FalhaComunicacaoSefazException : FaturamentoException
    {
        public FalhaComunicacaoSefazException(string message) : base(message) { }
    }

    public class NotaFiscalInvalidaException : FaturamentoException
    {
        public NotaFiscalInvalidaException(string message) : base(message) { }
    }
}