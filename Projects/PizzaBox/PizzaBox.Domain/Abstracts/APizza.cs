namespace PizzaBox.Domain.Abstracts
{
    abstract public class APizza
    {
        public APizza(string name)
        {
            Name = name;   
        }

        public string Name { get; set; }

    }






}
