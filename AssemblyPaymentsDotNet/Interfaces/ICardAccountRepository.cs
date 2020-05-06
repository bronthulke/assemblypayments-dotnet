using AssemblyPaymentsDotNet.DTO;

namespace AssemblyPaymentsDotNet.Interfaces
{
    public interface ICardAccountRepository
    {

        CardAccount GetCardAccountById(string cardAccountId);

        CardAccount CreateCardAccount(CardAccount cardAccount);

        bool DeleteCardAccount(string cardAccountId);

        User GetUserForCardAccount(string cardAccountId);

    }
}
