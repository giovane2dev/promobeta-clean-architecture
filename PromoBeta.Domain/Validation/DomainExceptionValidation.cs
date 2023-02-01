using System;

namespace PromoBeta.Domain.Validation
{
    public class DomainExceptionValidation: Exception
    {
        public DomainExceptionValidation(string error) : base(error)
        {

        }

        public static void Check(bool hasError, string error)
        {
            if (hasError)
                throw new DomainExceptionValidation(error);
        }
    }
}