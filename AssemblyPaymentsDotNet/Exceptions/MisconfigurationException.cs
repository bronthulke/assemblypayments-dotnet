using System;

namespace AssemblyPaymentsDotNet.Exceptions
{
    public class MisconfigurationException : Exception
    {
        public MisconfigurationException(string message) : base(message)
        {
        }
    }
}
