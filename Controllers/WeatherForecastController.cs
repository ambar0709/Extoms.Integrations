using Microsoft.AspNetCore.Mvc;

namespace Extoms.Integrations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IConfiguration _configuration;

        public WeatherForecastController(IConfiguration configuration, ILogger<WeatherForecastController> logger)
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