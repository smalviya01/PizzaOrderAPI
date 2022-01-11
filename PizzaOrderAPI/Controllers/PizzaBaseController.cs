using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaOrderService;
using PizzaOrderService.DataObjects;
using System.Collections.Generic;

namespace PizzaOrderAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaBaseController : ControllerBase
    {

        private readonly ILogger<PizzaBaseController> _logger;
        private readonly IServiceLogic ServiceLogic;

        public PizzaBaseController(ILogger<PizzaBaseController> logger, IServiceLogic serviceLogic)
        {
            _logger = logger;
            ServiceLogic = serviceLogic;
        }

        [HttpGet]
        [Route("GetPizzaSize")]
        [ProducesResponseType(typeof(List<PizzaItemInfo>), StatusCodes.Status200OK)]
        public IActionResult GetPizzaSize()
        {
            _logger.LogDebug($"Inside PizzaBaseController : GetPizzaSize");
            return Ok(ServiceLogic.GetPizzaSize());
        }

        [HttpGet]
        [Route("GetPizzaCrust")]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        public IActionResult GetPizzaCrust()
        {
            _logger.LogDebug($"Inside PizzaBaseController : GetPizzaSize");
            return Ok(ServiceLogic.GetPizzaCrust());
        }
    }
}
