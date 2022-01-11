using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaOrderService;
using PizzaOrderService.DataObjects;

namespace PizzaOrderAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly ILogger<LoginController> _logger;
        private readonly IServiceLogic ServiceLogic;

        public LoginController(ILogger<LoginController> logger, IServiceLogic serviceLogic)
        {
            _logger = logger;
            ServiceLogic = serviceLogic;
        }

        [HttpGet]
        [Route("Login/{userName}")]
        [ProducesResponseType(typeof(UserInfo),StatusCodes.Status200OK)]
        public IActionResult GetLoggedInUser(string userName)
        {
            _logger.LogDebug($"Inside LoginController : GetLoggedInUser - Username: {userName}");
            return Ok(ServiceLogic.GetLoggedInUser(userName));
        }
    }
}
