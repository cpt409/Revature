using System;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStores();
            System.Console.WriteLine();
            PrintPizzas();
        }

        public static void PrintPizzas()
        {
            var pizzaSingleton = new PizzaSingleton();

            System.Console.WriteLine("List of Pizzas: ");
            foreach(var pizza in pizzaSingleton.Pizzas)
            {
                System.Console.WriteLine(pizza);
            }
        }

        public static void PrintStores()
        {
            //var storeSingleton = StoreSingleton.Instance;

            System.Console.WriteLine("List of Stores: ");
            foreach(var store in StoreSingleton.Instance.Stores){
                System.Console.WriteLine(store);
            }
        }
    }
}
