using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.PizzaManager
{
    public class BaseMargherita : Pizza
    {
        public BaseMargherita(Pizza pizza) : base()
        {
            this.price = pizza.price + 7;
            this.basePizza = "Margherita";
        }
    }
}
