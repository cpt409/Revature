namespace PizzaBox.Domain.Abstracts
{
    abstract public class AStore
    {

        public AStore(string n)
        {
            Name = n;
        } 

        public string Name { get; protected set; }

    }

}