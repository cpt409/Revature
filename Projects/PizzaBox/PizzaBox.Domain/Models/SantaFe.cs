using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;

namespace PizzaBox.Domain.Models
{
    public class SantaFeStore : AStore
    {
        public SantaFeStore(string n) : base(n)
        {
            Orders = new List<Order>();
        }

        public SantaFeStore()
        {
            Name = "Santa Fe Store";
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}