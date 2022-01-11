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
    public class NonPizzaItemController : ControllerBase
    {

        private readonly ILogger<NonPizzaItemController> _logger;
        private readonly IServiceLogic ServiceLogic;

        public NonPizzaItemController(ILogger<NonPizzaItemController> logger, IServiceLogic serviceLogic)
        {
            _logger = logger;
            ServiceLogic = serviceLogic;
        }

        [HttpGet]
        [Route("GetNonPizzaItems")]
        [ProducesResponseType(typeof(List<PizzaItemInfo>),StatusCodes.Status200OK)]
        public IActionResult GetNonPizzaItems()
        {
            _logger.LogDebug($"Inside PizzaBaseController : GetPizzaSize");
            return Ok(ServiceLogic.GetNonPizzaItems());
        }
    }
}
