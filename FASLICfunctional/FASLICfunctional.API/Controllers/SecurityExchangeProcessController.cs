using FASLICfunctional.DTO;
using FASLICfunctional.Service;
using Microsoft.AspNetCore.Mvc;

namespace FASLICfunctional.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityExchangeProcessController : ControllerBase
    {
        private readonly ISecurityExchangeProcessService _securityExchangeProcessService;

        public SecurityExchangeProcessController(ISecurityExchangeProcessService securityExchangeProcessService)
        {
            _securityExchangeProcessService = securityExchangeProcessService;
        }

        [HttpPost("Process")]
        public async Task<ActionResult> ProcessSecurityExchange([FromBody] SecurityExchangeProcessDTO securityExchangeProcessDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _securityExchangeProcessService.ProcessSecurityExchange(securityExchangeProcessDTO);
            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}