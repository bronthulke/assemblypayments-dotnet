using AssemblyPaymentsDotNet.DTO;
using System.Collections.Generic;

namespace AssemblyPaymentsDotNet.Interfaces
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> ListCompanies();

        Company GetCompanyById(string companyId);

        Company CreateCompany(Company company, string userId);

        Company EditCompany(Company company);
    }
}
