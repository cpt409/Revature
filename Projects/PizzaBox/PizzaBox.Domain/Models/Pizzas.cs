using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class PepperoniPizza : APizza
    {
        public PepperoniPizza(string n) : base(n) {}

        public override string ToString()
        {
            return this.Name;
        }

        protected override void AddCrust()
        {

        }
        protected override void AddToppings()
        {
            new Topping();
            new Topping();
        }
        protected override void AddSize()
        {

        }

    }

    public class VeggiePizza : APizza
    {
        public VeggiePizza(string n) : base(n) {}

        public override string ToString()
        {
            return this.Name;
        }

        protected override void AddCrust()
        {

        }
        protected override void AddToppings()
        {
            new Topping();
            new Topping();
        }
        protected override void AddSize()
        {

        }

    }


    public class MeatLoversPizza : APizza
    {
        public MeatLoversPizza(string n) : base(n) { }

        public override string ToString()
        {
            return this.Name;
        }

        protected override void AddCrust()
        {
            crust = new Crust();
        }
        protected override void AddToppings()
        {
            new Topping();
            new Topping();
        }
        protected override void AddSize()
        {
            size = new Size();
        }



        
    }


}
