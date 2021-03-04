using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class PepperoniPizza : APizza
    {
        public override string ToString()
        {
            return this.Name;
        }
    }
}
