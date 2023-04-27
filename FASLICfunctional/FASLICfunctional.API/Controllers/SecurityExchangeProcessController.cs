using FASLICFunctional.DataAccess;
using FASLICFunctional.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FASLICFunctional.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityExchangeProcessController : ControllerBase
    {
        private readonly SecurityExchangeProcessService _securityExchangeProcessService;

        public SecurityExchangeProcessController(SecurityExchangeProcessService securityExchangeProcessService)
        {
            _securityExchangeProcessService = securityExchangeProcessService;
        }

        [HttpGet("/all")]
        public async Task<ActionResult<List<SecurityExchangeProcessModel>>> GetAllSecurityExchangeProcessAsync()
        {
            var securityExchangeProcesses = await _securityExchangeProcessService.GetAllSecurityExchangeProcessAsync();

            return securityExchangeProcesses;
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<SecurityExchangeProcessModel>> GetSecurityExchangeProcessByIdAsync(int id)
        {
            var securityExchangeProcess = await _securityExchangeProcessService.GetSecurityExchangeProcessByIdAsync(id);

            if (securityExchangeProcess == null)
            {
                return NotFound();
            }

            return securityExchangeProcess;
        }

        [HttpPost]
        public async Task<ActionResult<SecurityExchangeProcessModel>> InsertSecurityExchangeProcessAsync(SecurityExchangeProcessModel processModel)
        {
            var insertedSecurityExchangeProcess = await _securityExchangeProcessService.InsertSecurityExchangeProcessAsync(processModel);

            return CreatedAtAction(nameof(GetSecurityExchangeProcessByIdAsync), new { id = insertedSecurityExchangeProcess.Id }, insertedSecurityExchangeProcess);
        }

        [HttpPut]
        public async Task<ActionResult<SecurityExchangeProcessModel>> UpdateSecurityExchangeProcessAsync(SecurityExchangeProcessModel processModel)
        {
            var updatedSecurityExchangeProcess = await _securityExchangeProcessService.UpdateSecurityExchangeProcessAsync(processModel);

            if (updatedSecurityExchangeProcess == null)
            {
                return NotFound();
            }

            return updatedSecurityExchangeProcess;
        }

        [HttpDelete("/{id}")]
        public async Task<ActionResult> DeleteSecurityExchangeProcessAsync(int id)
        {
            await _securityExchangeProcessService.DeleteSecurityExchangeProcessAsync(id);

            return NoContent();
        }
    }
}