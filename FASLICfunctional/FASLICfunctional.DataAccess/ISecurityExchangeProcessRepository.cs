using System;
using System.Threading.Tasks;
using FASLIC.Functional.DTO;

namespace FASLIC.Functional
{
    public interface ISecurityExchangeProcessService : ISecurityExchangeProcessRepository
    {
        Task<SecurityExchangeProcessModel> GetSecurityExchangeProcessByNameAsync(string name);
        Task<SecurityExchangeProcessModel> AddSecurityExchangeProcessAsync(SecurityExchangeProcessModel secExchangeProcess);
        Task<SecurityExchangeProcessModel> UpdateSecurityExchangeProcessAsync(SecurityExchangeProcessModel secExchangeProcess);
        Task DeleteSecurityExchangeProcessAsync(Guid id);
    }
}