using FASLICfunctional.DTO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FASLICfunctional.Service
{
    public interface ISecurityExchangeProcessService
    {
        Task<int> CreateSecurityExchangeProcessAsync(SecurityExchangeProcessModel securityExchangeProcessModel);
        Task<SecurityExchangeProcessModel> GetSecurityExchangeProcessAsync(int id);
        Task<int> UpdateSecurityExchangeProcessAsync(SecurityExchangeProcessModel securityExchangeProcessModel);
        Task<int> DeleteSecurityExchangeProcessAsync(int id);
        Task<IEnumerable<SecurityExchangeProcessModel>> GetAllSecurityExchangeProcessesAsync();
    }
}