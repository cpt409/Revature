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
            crust = new StandardCrust();
        }
        protected override void AddToppings()
        {
            Toppings.Add(new Pepperoni());
            Toppings.Add(new Cheese());
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
            crust = new StandardCrust();
        }
        protected override void AddToppings()
        {
            Toppings.Add(new Brocolli());
            Toppings.Add(new Onion());
            Toppings.Add(new Cheese());
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
            crust = new StandardCrust();
        }
        protected override void AddToppings()
        {
            Toppings.Add(new Pepperoni());
            Toppings.Add(new GroundBeef());
            Toppings.Add(new Anchovie());
            Toppings.Add(new Cheese());
        }
        protected override void AddSize()
        {
            size = new Size();
        }

      
    }


}
