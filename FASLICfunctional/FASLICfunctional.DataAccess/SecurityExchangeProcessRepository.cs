namespace FASLICFunctional
{
    using FASLICFunctional.DTO;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class SecurityExchangeProcessRepository : ISecurityExchangeProcessRepository
    {
        public async Task<List<SecurityExchangeProcessModel>> GetAllSecurityExchangeProcessAsync()
        {
            // Code to call the database and get all the security exchange process
            return new List<SecurityExchangeProcessModel>();
        }

        public async Task<SecurityExchangeProcessModel> GetSecurityExchangeProcessByIdAsync(int id)
        {
            // Code to call the database and get the security exchange process for the given Id
            return new SecurityExchangeProcessModel();
        }

        public async Task<SecurityExchangeProcessModel> InsertSecurityExchangeProcessAsync(SecurityExchangeProcessModel processModel)
        {
            // Code to call the database and insert the security exchange process
            return new SecurityExchangeProcessModel();
        }

        public async Task<SecurityExchangeProcessModel> UpdateSecurityExchangeProcessAsync(SecurityExchangeProcessModel processModel)
        {
            // Code to call the database and update the security exchange process
            return new SecurityExchangeProcessModel();
        }

        public async Task DeleteSecurityExchangeProcessAsync(int id)
        {
            // Code to call the database and delete the security exchange process for the given Id
        }
    }
}