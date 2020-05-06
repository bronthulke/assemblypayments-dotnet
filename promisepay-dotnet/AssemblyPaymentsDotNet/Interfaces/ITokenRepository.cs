using AssemblyPaymentsDotNet.DTO;
using System.Collections.Generic;

namespace AssemblyPaymentsDotNet.Interfaces
{
    public interface ITokenRepository
    {
        string RequestToken();

        IDictionary<string, object> RequestSessionToken(Token token);

        Widget GetWidget(string sessionToken);
    }
}
