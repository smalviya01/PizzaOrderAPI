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
    public class IngredientsController : ControllerBase
    {

        private readonly ILogger<IngredientsController> _logger;
        private readonly IServiceLogic ServiceLogic;

        public IngredientsController(ILogger<IngredientsController> logger, IServiceLogic serviceLogic)
        {
            _logger = logger;
            ServiceLogic = serviceLogic;
        }

        [HttpGet]
        [Route("GetIngredients")]
        [ProducesResponseType(typeof(List<PizzaItemInfo>),StatusCodes.Status200OK)]
        public IActionResult GetIngredients()
        {
            _logger.LogDebug($"Inside PizzaBaseController : GetPizzaSize");
            return Ok(ServiceLogic.GetIngredients());
        }
    }
}
