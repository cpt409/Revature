using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    abstract public class Crust : AComponent
    {
        public Crust()
        {
            
        }

    }

    public class CheesyCrust : Crust 
    {
        public CheesyCrust()
        {
            Price = 0.50m;
            Name = "Cheesy Crust";
        }
    }

    public class StandardCrust : Crust
    {
        public StandardCrust()
        {
            Price = 0.50m;
            Name = "Standard Crust";
        }
    }


}