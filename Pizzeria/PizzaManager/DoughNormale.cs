using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.PizzaManager
{
    public class DoughNormale : Pizza
    {
        public DoughNormale(Pizza pizza) : base()
        {
            this.price = pizza.price + 1;
            this.basePizza = pizza.basePizza;
            this.dough = "Normale";
        }
    }
}
