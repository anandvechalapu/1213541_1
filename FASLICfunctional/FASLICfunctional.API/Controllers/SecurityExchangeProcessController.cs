using FASLICfunctional.DataAccess;
using FASLICfunctional.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace FASLICfunctional.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityExchangeProcessController : ControllerBase
    {
        private readonly FASLICContext _context;
        private readonly SecurityExchangeProcessService _securityExchangeProcessService;
        public SecurityExchangeProcessController(FASLICContext context, SecurityExchangeProcessService securityExchangeProcessService)
        {
            _context = context;
            _securityExchangeProcessService = securityExchangeProcessService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSecurityExchangeProcessAsync([FromBody] SecurityExchangeProcessModel securityExchangeProcessModel)
        {
            var result = await _securityExchangeProcessService.CreateSecurityExchangeProcessAsync(securityExchangeProcessModel);
            if (result > 0)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetSecurityExchangeProcessAsync(int id)
        {
            var result = await _securityExchangeProcessService.GetSecurityExchangeProcessAsync(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSecurityExchangeProcessAsync([FromBody] SecurityExchangeProcessModel securityExchangeProcessModel)
        {
            var result = await _securityExchangeProcessService.UpdateSecurityExchangeProcessAsync(securityExchangeProcessModel);
            if (result > 0)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSecurityExchangeProcessAsync(int id)
        {
            var result = await _securityExchangeProcessService.DeleteSecurityExchangeProcessAsync(id);
            if (result > 0)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllSecurityExchangeProcessesAsync()
        {
            var result = await _securityExchangeProcessService.GetAllSecurityExchangeProcessesAsync();
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }
    }
}