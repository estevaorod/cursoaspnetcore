using System;

namespace StoreOfBuild.Domain
{
    public class DomainException : Exception
    {
        public DomainException(string erro) : base (erro)
        {

        }

        public static void When(bool hasError, string erro)
        {
            if(hasError)
                throw new DomainException(erro);
        }
    }
}