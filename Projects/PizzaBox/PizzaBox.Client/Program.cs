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

            foreach(var pizza in pizzaSingleton.Pizzas)
            {
                System.Console.WriteLine(pizza);
            }
        }

        public static void PrintStores()
        {
            var storeSingleton = new StoreSingleton();

            foreach(var store in storeSingleton.Stores){
                System.Console.WriteLine(store);
            }

        }
    }
}
