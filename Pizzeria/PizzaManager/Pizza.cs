using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.PizzaManager
{
    public abstract class Pizza
    {
        public string basePizza {  get; set; }
        public string dough {  get; set; }
        public List<string>? ingrediants { get; set; }
        public float price { get; set; }

        public void CheckAnanas()//metti fuyori
        {
            if (ingrediants.Any(i => i.Contains("Ananas")))
            {
                this.price = 0f;
            }
        }
    }
}
