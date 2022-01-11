using PizzaOrderService.DataObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderService
{
    public interface IServiceLogic
    {
        UserInfo GetLoggedInUser(string userName);

        List<PizzaItemInfo> GetPizzaSize();

        List<string> GetPizzaCrust();

        List<PizzaItemInfo> GetIngredients();

        List<PizzaItemInfo> GetNonPizzaItems();
    }
}
