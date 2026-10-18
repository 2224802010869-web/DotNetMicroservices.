using Microsoft.AspNetCore.Mvc;

namespace PricingService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PricingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[]
            {
                new { Id = 1, Name = "Goi Co Ban", Price = 100000 },
                new { Id = 2, Name = "Goi Cao Cap", Price = 250000 }
            });
        }
    }
}