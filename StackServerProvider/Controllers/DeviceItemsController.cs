using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace StackServerProvider.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceItemsController : ControllerBase
    {
        private readonly ILogger<Models.DeviceItem> _logger;

        public DeviceItemsController(ILogger<Models.DeviceItem> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Models.DeviceItem> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Models.DeviceItem()
            {
                DeviceName = index.ToString(),
                IconName = "PlugConnected",
                DeviceId = index.ToString(),
            });
        }

    }
}