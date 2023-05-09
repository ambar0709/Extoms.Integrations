using Microsoft.AspNetCore.Mvc;

namespace Extoms.Integrations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IntegrationController : ControllerBase
    {
        private readonly ILogger<IntegrationController> _logger;

        private readonly IConfiguration _configuration;

        public IntegrationController(IConfiguration configuration, ILogger<IntegrationController> logger)
        {
            this._configuration = configuration;
            this._logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return _configuration["Test:Key1"];
        }
    }
}