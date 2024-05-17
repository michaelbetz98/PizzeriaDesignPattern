using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.PizzaManager
{
    public class BaseBianca : Pizza
    {
        public BaseBianca(Pizza pizza) : base()
        {
            this.price = pizza.price+5;
            this.basePizza = "Bianca";
        }
    }
}
