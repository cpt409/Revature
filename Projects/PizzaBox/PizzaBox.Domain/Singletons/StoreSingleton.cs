using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Singletons
{
    public class StoreSingleton
    {
        public List<AStore> Stores { get; set; }

        public StoreSingleton()
        {
            Stores = new List<AStore>()
            {
                new FreddyStore("Freddy's Store"),
                new MamasStore("Mama's Store"),
                new PapasStore("Papa's Store")
            };

        }

    }

}