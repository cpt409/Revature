using PizzaBox.Domain.Models;
using System.Collections.Generic;

namespace PizzaBox.Domain.Abstracts
{
    /// <summary>
    /// 
    /// </summary>
    abstract public class APizza
    {
        public APizza(string name)
        {
            Name = name;   
        }

        public string Name { get; set; }

        public Crust crust {get; set;}
        public Size size {get; set;}

        public List<Topping> Toppings {get; set;}

        private void ConstructPizza()
        {

        }


    }

}
