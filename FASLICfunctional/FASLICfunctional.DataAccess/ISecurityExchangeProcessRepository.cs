namespace FASLICFunctional.Service
{
    using FASLICFunctional.DTO;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISecurityExchangeProcessRepository
    {
        Task<List<SecurityExchangeProcessModel>> GetAllSecurityExchangeProcessAsync();
        Task<SecurityExchangeProcessModel> GetSecurityExchangeProcessByIdAsync(int id);
        Task<SecurityExchangeProcessModel> InsertSecurityExchangeProcessAsync(SecurityExchangeProcessModel processModel);
        Task<SecurityExchangeProcessModel> UpdateSecurityExchangeProcessAsync(SecurityExchangeProcessModel processModel);
        Task DeleteSecurityExchangeProcessAsync(int id);
    }
}