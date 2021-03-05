using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class FreddyStore : AStore
    {
        public FreddyStore(string n) : base(n) {}

        public override string ToString()
        {
            return this.Name;
        }
    }

    public class MamasStore : AStore
    {
        public MamasStore(string n) : base(n) {}

        public override string ToString()
        {
            return this.Name;
        }
    }

    public class PapasStore : AStore
    {
        public PapasStore(string n) : base(n) {}

        public override string ToString()
        {
            return this.Name;
        }
    }

}
