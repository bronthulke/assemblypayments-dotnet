using AssemblyPaymentsDotNet.DTO;

namespace AssemblyPaymentsDotNet.Interfaces
{
    public interface IPayPalAccountRepository
    {

        PayPalAccount GetPayPalAccountById(string paypalAccountId);

        PayPalAccount CreatePayPalAccount(PayPalAccount paypalAccount);

        bool DeletePayPalAccount(string paypalAccountId);

        User GetUserForPayPalAccount(string paypalAccountId);

    }
}
