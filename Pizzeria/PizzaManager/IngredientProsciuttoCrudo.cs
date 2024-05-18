using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.PizzaManager
{
    public class IngredientProsciuttoCrudo : Pizza
    {
        public IngredientProsciuttoCrudo(Pizza pizza) : base()
        {
            this.price = pizza.price + 2;
            this.basePizza = pizza.basePizza;
            this.dough = pizza.dough;
            this.ingrediants = pizza.ingrediants;
            if (pizza.ingrediants == null)
            {
                this.ingrediants = new List<string> { "ProsciuttoCrudo" };
            }
            else
            {
                this.ingrediants.Add("ProsciuttoCrudo");
            }
        }
    }
}
