using System.Collections.Generic;

namespace AssemblyPaymentsDotNet.Dynamic.Interfaces
{
    public interface IAddressRepository
    {
        IDictionary<string,object> GetAddressById(string addressId);
    }
}
