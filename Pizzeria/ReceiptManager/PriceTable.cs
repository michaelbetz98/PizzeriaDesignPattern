using Pizzeria.PizzaManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.ReceiptManager
{
    public  class PriceTable
    {
        public  readonly Dictionary<string, float> table = new Dictionary<string, float>()
        {
            {"Bianca",5f},
            {"Margherita",7f},
            {"Napoletana",3f},
            {"Normale",0f},
            {"Integrale",1f},
            {"ProsiuttoCotto", 1f},
            {"Funghi", 2f},
            {"ProsciuttoCrudo", 2f},
            {"Ananas", 0f}
        };
        public  float Price(string toSearch)
        {
            float price = 0f;

            if (table.ContainsKey(toSearch))
            {
                price = table[toSearch];
            }
            return price;
        }
    }
}
