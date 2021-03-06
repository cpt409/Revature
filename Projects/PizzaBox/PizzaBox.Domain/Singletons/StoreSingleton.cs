using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.IO;
using System.Xml.Serialization;
using PizzaBox.Storing;
using System.Linq;

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

        private void CreateStores()
        {
            var fs = new FileStorage();

            Stores = new List<AStore>()
            {
                new MiamiStore("Miami Store"),
                new SantaFeStore("Santa Fe Store")
            };

            fs.WriteToXml(Stores);
        }

        // public void WriteToXML<T>(List<T> data)
        // {
        //     string path = @"store.xml";

        //     using (var writer = new StreamWriter(path))
        //     {
        //         var serializer = new XmlSerializer(typeof(List<T>));
        //         serializer.Serialize(writer, data);
        //     }

        // }

        private void PopulateStores()
        {
            System.Console.WriteLine("Reading Stores from file: ");
            var fs = new FileStorage();
            if (Stores == null)
            {
                Stores = fs.ReadFromXml<AStore>().ToList();
            }
        }


        private StoreSingleton()
        {
            // Use this method for creating new xml file
            //CreateStores();

            // Use this method for reading from existing file
            PopulateStores();

        }


    }

}