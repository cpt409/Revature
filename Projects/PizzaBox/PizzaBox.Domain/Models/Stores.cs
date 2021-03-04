using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class FreddyPizza : AStore
    {
        public FreddyPizza(string n) : base(n) {}

        public override string ToString()
        {
            return this.Name;
        }
    }

    public class MamasPizza : AStore
    {
        public MamasPizza(string n) : base(n) {}

        public override string ToString()
        {
            return this.Name;
        }
    }

    public class PapasPizza : AStore
    {
        public PapasPizza(string n) : base(n) {}

        public override string ToString()
        {
            return this.Name;
        }
    }

}
