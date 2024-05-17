using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.PizzaManager
{
    internal class IngredientAnanas : Pizza
    {
        public IngredientAnanas(Pizza pizza) : base()
        {
            this.price = 0;
            this.basePizza = pizza.basePizza;
            this.dough = pizza.dough;
            this.ingrediants = pizza.ingrediants;
            if (pizza.ingrediants == null)
            {
                this.ingrediants = new List<string> { "Ananas" };
            }
            else
            {
                this.ingrediants.Add("Ananas");
            }
        }
    }
}
