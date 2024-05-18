using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.PizzaManager
{
    public class BaseNapoletana : Pizza
    {
        public BaseNapoletana(Pizza pizza) : base()
        {
            this.price = pizza.price + 3f;
            this.basePizza = "Napoletana";
        }
    }
}
