using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderService.DataObjects
{
   public class PizzaItemInfo
    {
        public string ItemName { get; set; }

        public int itemRate { get; set; }

        public bool isSoftDrink { get; set; } = false;
    }
}
