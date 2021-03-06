using System;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine("\n\n");
            PrintMessage(ConsoleColor.Magenta, "Welcome to Pizza Box USA");
            System.Console.WriteLine("\n\n");

            PrintStores();
            System.Console.WriteLine();
            PrintPizzas();
        }

        public static void PrintPizzas()
        {
            var pizzaSingleton = new PizzaSingleton();

            PrintMessage(ConsoleColor.Yellow, "Our List of Awesome Pizzas: ");
            foreach(var pizza in pizzaSingleton.Pizzas)
            {
                System.Console.WriteLine(pizza);
            }
        }

        public static void PrintStores()
        {
            PrintMessage(ConsoleColor.Yellow, "Our List of Locations:");
            // System.Console.ForegroundColor = ConsoleColor.Yellow;
            // System.Console.WriteLine("List of Pizza Box Stores: ");
            // System.Console.ResetColor();
            foreach(var store in StoreSingleton.Instance.Stores)
            {
                System.Console.WriteLine(store);
            }
        }

        private static void PrintMessage(ConsoleColor color,
                                                string message)
        {
            System.Console.ForegroundColor = color;
            System.Console.WriteLine($"{message}");
            System.Console.ResetColor();
        }
    }
}

