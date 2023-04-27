using FASLICFunctional.DataAccess;
using FASLICFunctional.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FASLICFunctional.Service
{
    public class SecurityExchangeProcessService : ISecurityExchangeProcessService
    {
        private readonly ISecurityExchangeProcessRepository _securityExchangeProcessRepository;

        public SecurityExchangeProcessService(ISecurityExchangeProcessRepository securityExchangeProcessRepository)
        {
            _securityExchangeProcessRepository = securityExchangeProcessRepository;
        }

        public async Task<List<SecurityExchangeProcessModel>> GetAllSecurityExchangeProcessAsync()
        {
            return await _securityExchangeProcessRepository.GetAllSecurityExchangeProcessAsync();
        }

        public async Task<SecurityExchangeProcessModel> GetSecurityExchangeProcessByIdAsync(int id)
        {
            return await _securityExchangeProcessRepository.GetSecurityExchangeProcessByIdAsync(id);
        }

        public async Task<SecurityExchangeProcessModel> InsertSecurityExchangeProcessAsync(SecurityExchangeProcessModel processModel)
        {
            return await _securityExchangeProcessRepository.InsertSecurityExchangeProcessAsync(processModel);
        }

        public async Task<SecurityExchangeProcessModel> UpdateSecurityExchangeProcessAsync(SecurityExchangeProcessModel processModel)
        {
            return await _securityExchangeProcessRepository.UpdateSecurityExchangeProcessAsync(processModel);
        }

        public async Task DeleteSecurityExchangeProcessAsync(int id)
        {
            await _securityExchangeProcessRepository.DeleteSecurityExchangeProcessAsync(id);
        }
    }
}