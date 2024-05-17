using Pizzeria.PizzaManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.ReceiptManager
{
    public class ReceiptGenerator
    {
        public static int ReceiptId;
        private readonly PriceTable priceTable;

        public ReceiptGenerator(PriceTable priceTable)
        {
            this.priceTable = priceTable;
        }
        public string Generate(Pizza pizza)
        {
            string receipt = "";
            ReceiptId++;
            receipt += $"Receipt n° {ReceiptId}\n";
            receipt += $"base pizza: {pizza.basePizza} {priceTable.Price(pizza.basePizza)}\n";
            receipt += $"impasto: {ItemAndPrice(pizza.dough)}\n";
            foreach(string ingedient in pizza.ingrediants)
            {
                receipt += $"ingediente: {ItemAndPrice(ingedient)}\n";
            }
            receipt += $"TOTALE: {pizza.price}\n";
            return receipt;
        }

        private string ItemAndPrice(string item)
        {
            return $"{item} {priceTable.Price(item)}";
        }
    }
}
