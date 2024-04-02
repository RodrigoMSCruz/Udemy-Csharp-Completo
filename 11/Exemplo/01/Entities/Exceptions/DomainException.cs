using System;

namespace 11.Exemplo.01.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}