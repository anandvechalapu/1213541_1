using ctepl.anand.DTO;
using ctepl.anand.Service;
using Microsoft.AspNetCore.Mvc;

namespace ctepl.anand.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReopenClaimController : ControllerBase
    {
        private IReopenClaimService _reopenClaimService;

        public ReopenClaimController(IReopenClaimService reopenClaimService)
        {
            _reopenClaimService = reopenClaimService;
        }

        [HttpPost]
        public ActionResult ReopenClaimBasedOnLitigation(ReopenClaimDTO dto)
        {
            // Call service method to reopen claim
            var result = _reopenClaimService.ReopenClaimBasedOnLitigation(dto);

            return Ok(result);
        }
    }
}