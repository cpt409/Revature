using PizzaBox.Domain.Models;
using System.Collections.Generic;

namespace PizzaBox.Domain.Abstracts
{
    abstract public class AStore
    {

        public AStore(string n)
        {
            Name = n;
        } 

        public string Name { get; protected set; }

        public List<Order> Orders { get; set; }
    }

}