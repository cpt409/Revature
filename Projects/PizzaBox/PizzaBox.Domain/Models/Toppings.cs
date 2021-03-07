using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models
{
    abstract public class Topping : AComponent
    {

        public Topping()
        {
            
        }

    }

    public class Anchovie : Topping
    {
        public Anchovie()
        {
            Price = 0.50m;
            Name = "Anchovies";
        }
    }

    public class GroundBeef : Topping
    {
        public GroundBeef()
        {
            Price = 0.50m;
            Name = "Ground Beef";
        }
    }

    public class Brocolli : Topping
    {
        public Brocolli()
        {
            Price = 0.50m;
            Name = "Brocolli";
        }
    }

    public class Onion : Topping
    {
        public Onion()
        {
            Price = 0.50m;
            Name = "Onions";
        }
    }

    public class Pepperoni : Topping
    {
        public Pepperoni()
        {
            Price = 0.50m;
            Name = "Pepperoni";
        }
    }

    public class Cheese : Topping
    {
        public Cheese()
        {
            Price = 0.50m;
            Name = "Cheese";
        }
    }

}