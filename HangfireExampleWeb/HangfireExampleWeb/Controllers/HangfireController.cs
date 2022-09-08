using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace HangfireExampleWeb.Controllers
{
    [ApiController]
    [Route("[controller1]")]
    public class HangFireController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<HangFireController> _logger;

        public HangFireController(ILogger<HangFireController> logger)
        {
            _logger = logger;
        }
    }
}
