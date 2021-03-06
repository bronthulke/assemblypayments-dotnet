using System.Collections.Generic;

namespace AssemblyPaymentsDotNet.Dynamic.Interfaces
{
    public interface ICompanyRepository
    {
        IDictionary<string, object> ListCompanies();

        IDictionary<string, object> GetCompanyById(string companyId);

        IDictionary<string, object> CreateCompany(IDictionary<string, object> company);

        IDictionary<string, object> EditCompany(IDictionary<string, object> company);
    }
}
