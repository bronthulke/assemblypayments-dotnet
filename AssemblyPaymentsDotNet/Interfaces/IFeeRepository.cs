using AssemblyPaymentsDotNet.DTO;
using System.Collections.Generic;

namespace AssemblyPaymentsDotNet.Interfaces
{
    public interface IFeeRepository
    {

        IEnumerable<Fee> ListFees();

        Fee GetFeeById(string feeId);

        Fee CreateFee(Fee fee);

    }
}
