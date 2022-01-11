using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using PizzaOrderAPI.Controllers;
using PizzaOrderService;
using PizzaOrderService.DataObjects;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTest
{
    public class PizzaBaseControllerTest
    {

        public Mock<IServiceLogic> mockService;
        public Mock<ILogger<PizzaBaseController>> mockLogger;

        public PizzaBaseControllerTest()
        {
            mockService = new Mock<IServiceLogic>();
            mockLogger = new Mock<ILogger<PizzaBaseController>>();
        }

        private PizzaBaseController GetController()
        {
            return new PizzaBaseController(mockLogger.Object, mockService.Object);
        }


        [Fact(DisplayName = "get pizza size test")]
        public void GetPizzaSize_test()
        {
            var response = new List<PizzaItemInfo>();
            response.Add(new PizzaItemInfo { ItemName = "test", itemRate = 2 });

            mockService.Setup(x => x.GetPizzaSize()).Returns(response);
            var res = GetController().GetPizzaSize();

            //Assert
            var result =   Assert.IsType<OkObjectResult>(res);
            Assert.IsType<List<PizzaItemInfo>>(result.Value);

        }
    }
}
