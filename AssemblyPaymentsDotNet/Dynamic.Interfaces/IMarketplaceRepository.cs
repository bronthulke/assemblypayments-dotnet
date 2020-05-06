using System.Collections.Generic;

namespace AssemblyPaymentsDotNet.Dynamic.Interfaces
{
    public interface IMarketplaceRepository
    {
        IDictionary<string, object> ShowMarketplace();
    }
}
