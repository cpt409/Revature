using PizzaBox.Domain.Models;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;

namespace PizzaBox.Domain.Abstracts
{

    [XmlInclude(typeof(SantaFeStore))]
    [XmlInclude(typeof(MiamiStore))]
    [Serializable]
    abstract public class AStore
    {

        public AStore()
        {
        }

        public AStore(string n)
        {
            Name = n;
        } 

        public string Name { get; set; }

        public List<Order> Orders { get; set; }
    }

}