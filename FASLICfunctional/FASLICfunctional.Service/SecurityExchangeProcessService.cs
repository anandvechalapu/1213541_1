using FASLICfunctional.DataAccess;
using FASLICfunctional.DTO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace FASLICfunctional.Service
{
    public class SecurityExchangeProcessService : ISecurityExchangeProcessService
    {
        private readonly FASLICContext _context;
        public SecurityExchangeProcessService(FASLICContext context)
        {
            _context = context;
        }

        // Create 
        public async Task<int> CreateSecurityExchangeProcessAsync(SecurityExchangeProcessModel securityExchangeProcessModel)
        {
            var securityExchangeProcess = new SecurityExchangeProcess
            {
                ExchageName = securityExchangeProcessModel.ExchageName,
                ExchangeCode = securityExchangeProcessModel.ExchangeCode,
                ExchangeType = securityExchangeProcessModel.ExchangeType,
                ExchangeLocation = securityExchangeProcessModel.ExchangeLocation,
                ExchangeCountry = securityExchangeProcessModel.ExchangeCountry,
                ExchangeWebsite = securityExchangeProcessModel.ExchangeWebsite
            };
            await _context.SecurityExchangeProcesses.AddAsync(securityExchangeProcess);
            await _context.SaveChangesAsync();
            return securityExchangeProcess.Id;
        }

        // Read
        public async Task<SecurityExchangeProcessModel> GetSecurityExchangeProcessAsync(int id)
        {
            var securityExchangeProcess = await _context.SecurityExchangeProcesses.FindAsync(id);
            return new SecurityExchangeProcessModel
            {
                Id = securityExchangeProcess.Id,
                ExchageName = securityExchangeProcess.ExchageName,
                ExchangeCode = securityExchangeProcess.ExchangeCode,
                ExchangeType = securityExchangeProcess.ExchangeType,
                ExchangeLocation = securityExchangeProcess.ExchangeLocation,
                ExchangeCountry = securityExchangeProcess.ExchangeCountry,
                ExchangeWebsite = securityExchangeProcess.ExchangeWebsite
            };
        }

        // Update
        public async Task<int> UpdateSecurityExchangeProcessAsync(SecurityExchangeProcessModel securityExchangeProcessModel)
        {
            var securityExchangeProcess = new SecurityExchangeProcess
            {
                Id = securityExchangeProcessModel.Id,
                ExchageName = securityExchangeProcessModel.ExchageName,
                ExchangeCode = securityExchangeProcessModel.ExchangeCode,
                ExchangeType = securityExchangeProcessModel.ExchangeType,
                ExchangeLocation = securityExchangeProcessModel.ExchangeLocation,
                ExchangeCountry = securityExchangeProcessModel.ExchangeCountry,
                ExchangeWebsite = securityExchangeProcessModel.ExchangeWebsite
            };
            _context.SecurityExchangeProcesses.Update(securityExchangeProcess);
            await _context.SaveChangesAsync();
            return securityExchangeProcess.Id;
        }

        // Delete
        public async Task<int> DeleteSecurityExchangeProcessAsync(int id)
        {
            var securityExchangeProcess = await _context.SecurityExchangeProcesses.FindAsync(id);
            _context.SecurityExchangeProcesses.Remove(securityExchangeProcess);
            await _context.SaveChangesAsync();
            return securityExchangeProcess.Id;
        }

        // GetAll
        public async Task<IEnumerable<SecurityExchangeProcessModel>> GetAllSecurityExchangeProcessesAsync()
        {
            var securityExchangeProcesses = await _context.SecurityExchangeProcesses.ToListAsync();
            return securityExchangeProcesses.Select(x => new SecurityExchangeProcessModel
            {
                Id = x.Id,
                ExchageName = x.ExchageName,
                ExchangeCode = x.ExchangeCode,
                ExchangeType = x.ExchangeType,
                ExchangeLocation = x.ExchangeLocation,
                ExchangeCountry = x.ExchangeCountry,
                ExchangeWebsite = x.ExchangeWebsite
            });
        }
    }
}