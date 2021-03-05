using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;


namespace PizzaBox.Domain.Models
{
    public class MiamiStore : AStore
    {
        public MiamiStore(string n) : base(n)
        {
            Orders = new List<Order>();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}