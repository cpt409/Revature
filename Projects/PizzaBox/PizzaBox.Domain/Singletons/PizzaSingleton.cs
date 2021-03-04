using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Singletons
{
    public class PizzaSingleton
    {
        public List<APizza> Pizzas { get; set; }

        public PizzaSingleton()
        {
            Pizzas = new List<APizza>()
            {
                new PepperoniPizza()
                {
                    Name = "Pepperoni Pizza"
                }
            };
            // Stores = new List<AStore>();
            // Stores.Add(new FreddyPizza());
            // Stores[0].Name = "Freddy Pizza";

            // {
            //     new FreddyPizza()
            //     {
            //         Name = "Freddy Pizza"  
            //     }
            // }
        }

    }

}