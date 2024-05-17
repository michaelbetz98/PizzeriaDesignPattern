
using FileManager;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pizzeria.PizzaManager;
using Pizzeria.ReceiptManager;

namespace Pizzeria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container = Container.CreateHostBuilder(args).Services;
            Pizza pizza = container.GetRequiredService<PizzaBase>();
            pizza = new BaseBianca(pizza);
            pizza = new DoughIntegrale(pizza);
            pizza = new IngredientFunghi(pizza);
            pizza = new IngredientAnanas(pizza);
            pizza.CheckAnanas();
            Console.WriteLine(pizza.price);

            List<string> Lines = ReadFile.ReadFileLines();
            Console.WriteLine(Lines[0]);

            var receiptGenerator = container.GetRequiredService<ReceiptGenerator>();
            string result = receiptGenerator.Generate(pizza);
            Console.WriteLine(result);
        }
    }

    public static class Container
    {
        public static IHost CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton<PizzaBase>();
                services.AddSingleton<BaseBianca>();
                services.AddSingleton<DoughIntegrale>();
                services.AddSingleton<IngredientFunghi>();

                services.AddSingleton<ReceiptGenerator>();
                services.AddSingleton<PriceTable>();
                /*services.AddSingleton<Greetings>((x) =>
                {
                    var nameNull = new NameNull();
                    var nameUpperCase = new NameUpperCase();
                    nameNull.SetSuccessor(nameUpperCase);
                    return nameNull;

                });*/
            }).Build();
    }
}
