using FASLICfunctional;
using FASLICfunctional.DTO;

namespace FASLICfunctional.Service
{
    public interface ISecurityExchangeProcessRepository
    {
        Task<int> CreateSecurityExchangeProcessAsync(SecurityExchangeProcessModel securityExchangeProcessModel);
        Task<SecurityExchangeProcessModel> GetSecurityExchangeProcessAsync(int id);
        Task<int> UpdateSecurityExchangeProcessAsync(SecurityExchangeProcessModel securityExchangeProcessModel);
        Task<int> DeleteSecurityExchangeProcessAsync(int id);
        Task<IEnumerable<SecurityExchangeProcessModel>> GetAllSecurityExchangeProcessesAsync();
    }
}