using FASLICFunctional.DataAccess;
using FASLICFunctional.DTO;

namespace FASLICFunctional.Service
{
    public interface ISecurityExchangeProcessService
    {
        Task<List<SecurityExchangeProcessModel>> GetAllSecurityExchangeProcessAsync();
        Task<SecurityExchangeProcessModel> GetSecurityExchangeProcessByIdAsync(int id);
        Task<SecurityExchangeProcessModel> InsertSecurityExchangeProcessAsync(SecurityExchangeProcessModel processModel);
        Task<SecurityExchangeProcessModel> UpdateSecurityExchangeProcessAsync(SecurityExchangeProcessModel processModel);
        Task DeleteSecurityExchangeProcessAsync(int id);
    }
}