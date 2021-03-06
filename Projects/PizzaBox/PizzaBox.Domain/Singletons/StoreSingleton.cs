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


        // public void WriteToXML<T>(List<T> data)
        // {
        //     string path = @"store.xml";

        //     using (var writer = new StreamWriter(path))
        //     {
        //         var serializer = new XmlSerializer(typeof(List<T>));
        //         serializer.Serialize(writer, data);
        //     }

        // }




        private StoreSingleton()
        {
            // Stores = new List<AStore>()
            // {
            //     new MiamiStore("Miami Store"),
            //     new SantaFeStore("Santa Fe Store")
            // };

            //WriteToXML(Stores);



            var fs = new FileStorage();
            if (Stores == null){
                Stores = fs.ReadFromXml<AStore>().ToList();
            }

        }


    }

}