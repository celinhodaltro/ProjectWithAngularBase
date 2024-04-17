using Microsoft.AspNetCore.Mvc;
using System.BussinessRules;
using System.Entities;


namespace App.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogsController : ControllerBase
    {

        private readonly LogBusinessRules logBusinessRules;

        private readonly ILogger<LogsController> _logger;

        public LogsController(ILogger<LogsController> logger, LogBusinessRules _logBusinessRules)
        {
            _logger = logger;
            logBusinessRules = _logBusinessRules;
        }

        [HttpGet(Name = "GetLogs")]
        public IEnumerable<Log> Get()
        {
            return logBusinessRules.GetAllLogs();
        }
    }
}
