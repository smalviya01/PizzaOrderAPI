using Microsoft.Extensions.Logging;
using PizzaOrderService.DataObjects;
using System;
using System.Collections.Generic;

namespace PizzaOrderService
{
    public class ServiceLogic : IServiceLogic
    {
        private readonly ILogger<ServiceLogic> logger;
        public ServiceLogic(ILogger<ServiceLogic> _logger)
        {
            logger = _logger;
        }

        #region login
        public UserInfo GetLoggedInUser(string userName)
        {
            logger.LogDebug($"Inside ServiceLogic: GetLoggedInUser - Username: {userName}");
            var userInfo = new UserInfo();
            userInfo.userFulName = "Shubham Malviya";
            userInfo.userEmailId = "123test@mial.com";
            return userInfo;
        }
        #endregion

        public List<PizzaItemInfo> GetPizzaSize()
        {
            logger.LogDebug($"Inside ServiceLogic: GetPizzaSize");
            var PizzaTypes = new List<PizzaItemInfo>();
            PizzaTypes.Add(new PizzaItemInfo { ItemName = "Small", itemRate = 4 });
            PizzaTypes.Add(new PizzaItemInfo { ItemName = "Medium", itemRate = 7 });
            PizzaTypes.Add(new PizzaItemInfo { ItemName = "Large", itemRate = 10 });
            PizzaTypes.Add(new PizzaItemInfo { ItemName = "Extra Large", itemRate = 13 });

            return PizzaTypes;
        }

       public  List<string> GetPizzaCrust()
        {
            logger.LogDebug($"Inside ServiceLogic: GetPizzaCrust");
            var pizzaCrust = new List<string>();
            pizzaCrust.Add("Normal");
            pizzaCrust.Add("cheesy");
            pizzaCrust.Add("Sausage");
            return pizzaCrust;
        }

        public List<PizzaItemInfo> GetIngredients()
        {
            logger.LogDebug($"Inside ServiceLogic: GetIngredients");
            var pizzaIngredients = new List<PizzaItemInfo>();
            pizzaIngredients.Add(new PizzaItemInfo { ItemName = "Pepperoni", itemRate = 1 });
            pizzaIngredients.Add(new PizzaItemInfo { ItemName = "Extra Cheese", itemRate = 1 });
            pizzaIngredients.Add(new PizzaItemInfo { ItemName = "Mushroom", itemRate = 1 });
            pizzaIngredients.Add(new PizzaItemInfo { ItemName = "Onion", itemRate = 1 });
            pizzaIngredients.Add(new PizzaItemInfo { ItemName = "Tomato", itemRate = 1 });
            pizzaIngredients.Add(new PizzaItemInfo { ItemName = "Spinach", itemRate = 1 });
            pizzaIngredients.Add(new PizzaItemInfo { ItemName = "Jalapeno", itemRate = 1 });
            return pizzaIngredients;
        }

        public List<PizzaItemInfo> GetNonPizzaItems()
        {
            logger.LogDebug($"Inside ServiceLogic: GetNonPizzaItems");
            var nonPizzaItems = new List<PizzaItemInfo>();
            nonPizzaItems.Add(new PizzaItemInfo { ItemName = "Chicken Wings", itemRate = 3 });
            nonPizzaItems.Add(new PizzaItemInfo { ItemName = "Poutine", itemRate = 3 });
            nonPizzaItems.Add(new PizzaItemInfo { ItemName = "Onion Rings", itemRate = 3 });
            nonPizzaItems.Add(new PizzaItemInfo { ItemName = "Garlic Bread", itemRate = 4 });
            nonPizzaItems.Add(new PizzaItemInfo { ItemName = "BBQ Dip", itemRate = 2 });
            nonPizzaItems.Add(new PizzaItemInfo { ItemName = "Coke", itemRate = 2 , isSoftDrink = true });
            nonPizzaItems.Add(new PizzaItemInfo { ItemName = "Diet Coke", itemRate = 2 , isSoftDrink = true });
            nonPizzaItems.Add(new PizzaItemInfo { ItemName = "Iced Tea", itemRate = 3, isSoftDrink = true });
            nonPizzaItems.Add(new PizzaItemInfo { ItemName = "Ginger Ale", itemRate = 2 , isSoftDrink = true});
            nonPizzaItems.Add(new PizzaItemInfo { ItemName = "Sprite", itemRate = 2 , isSoftDrink = true });
            nonPizzaItems.Add(new PizzaItemInfo { ItemName = "Water", itemRate = 1 , isSoftDrink = true });
            return nonPizzaItems;
        }
    }
}
