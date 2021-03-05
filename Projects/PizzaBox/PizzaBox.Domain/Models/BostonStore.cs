using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace PizzaBox.Domain.Models
{
    // [XmlInclude(typeof(BostonStore))]
    // [Serializable]

    public class BostonStore : AStore
    {
        public BostonStore(string n) : base(n)
        {
            Orders = new List<Order>();
        }

        public BostonStore()
        {
            Name = "Boston Store";
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}