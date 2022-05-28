using Microsoft.AspNetCore.Mvc;

namespace CustomerRewardsProgram.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetServiceHealth()
        {
            _logger.LogInformation($"Service health check requested at {DateTime.Now}");
            return Ok("Service is Currently in Healthy State");
        }
    }
}