using System;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayWithStore();
            PlayWithPizza();
        }

        public static void PlayWithPizza()
        {
            var pizzaSingleton = new PizzaSingleton();

            foreach(var pizza in pizzaSingleton.Pizzas)
            {
                System.Console.WriteLine(pizza);
            }
        }

        public static void PlayWithStore()
        {
            var storeSingleton = new StoreSingleton();

            foreach(var store in storeSingleton.Stores){
                System.Console.WriteLine(store);
            }

            //System.Console.WriteLine(storeSingleton.Stores);

            // FreddyPizza fp = new FreddyPizza();
            // fp.Name = "Freddy's Pizza";

            // System.Console.WriteLine($"{fp.Name}");
        }
    }
}
