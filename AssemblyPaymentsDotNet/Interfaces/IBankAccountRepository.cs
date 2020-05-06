using AssemblyPaymentsDotNet.DTO;

namespace AssemblyPaymentsDotNet.Interfaces
{
    public interface IBankAccountRepository
    {
        BankAccount GetBankAccountById(string bankAccountId);

        BankAccount CreateBankAccount(BankAccount bankAccount);

        bool DeleteBankAccount(string bankAccountId);

        User GetUserForBankAccount(string bankAccountId);
    }
}
