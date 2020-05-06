using System.Collections.Generic;

namespace AssemblyPaymentsDotNet.Dynamic.Interfaces
{
    public interface IToolRepository
    {
        IDictionary<string, object> HealthCheck();
    }
}
