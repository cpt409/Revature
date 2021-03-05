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

    }

}
