using AssemblyPaymentsDotNet.DTO;

namespace AssemblyPaymentsDotNet.Interfaces
{
    public interface IAddressRepository
    {
        Address GetAddressById(string addressId);
    }
}
