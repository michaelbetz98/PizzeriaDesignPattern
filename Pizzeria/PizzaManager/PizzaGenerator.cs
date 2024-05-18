using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.PizzaManager
{
    public class PizzaGenerator
    {
        public Pizza Generator(Pizza pizza, List<string> line)
        {
            if(line != null)
            {
                string basePizza = line[0];
                line.RemoveAt(0);
                string doughPizza = line[0];
                line.RemoveAt(0);
                List<string> ingredients = line;
                switch(basePizza)
                {
                    case "Bianca":
                        pizza = new BaseBianca(pizza);
                        break;
                    case "Margherita":
                        pizza = new BaseMargherita(pizza);
                        break;
                    case "Napoletana":
                        pizza = new BaseNapoletana(pizza);
                        break;
                }
                switch (doughPizza)
                {
                    case "Integrale":
                        pizza = new DoughIntegrale(pizza);
                        break;
                    case "Normale":
                        pizza = new DoughNormale(pizza);
                        break;
                }
                foreach(string ingredient in  ingredients)
                {
                    switch (ingredient)
                    {
                        case "ProsciuttoCotto":
                            pizza = new IngredientProsciuttoCotto(pizza);
                            break;
                        case "ProsciuttoCrudo":
                            pizza = new IngredientProsciuttoCrudo(pizza);
                            break;
                        case "Funghi":
                            pizza = new IngredientFunghi(pizza);
                            break;
                        case "Ananas":
                            pizza = new IngredientAnanas(pizza);
                            break;
                    }
                }
            }
            return pizza;
        }
    }
}
