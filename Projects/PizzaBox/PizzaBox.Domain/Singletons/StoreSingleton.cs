using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.IO;
using System.Xml.Serialization;

namespace PizzaBox.Domain.Singletons
{
    public class StoreSingleton
    {
        public List<AStore> Stores { get; set; }

        private static StoreSingleton _storeSingleton;
        public static StoreSingleton Instance
        { 
            get
            {
                if (_storeSingleton == null)
                {
                    _storeSingleton = new StoreSingleton();
                }

                return _storeSingleton;
            }
        }

        public void WriteToXML()
        {
            string path = @"store.xml";
            var writer = new StreamWriter(path);

            XmlSerializer serializer = new XmlSerializer(typeof(List<AStore>));

        }

        
        private StoreSingleton()
        {
            Stores = new List<AStore>()
            {
                new MiamiStore("Miami Store"),
                new BostonStore("Boston Store")
            };
        }


    }

}