using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using System.Linq;

namespace PizzaBox.Domain.Singletons
{
    public class StoreSingleton
    {
        private StoreSingleton()
        {
            // Use this method for creating new xml file
            // CreateStores();

            // Use this method for reading from existing file
            PopulateStores();

        }


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

            System.Console.WriteLine("(Creating new Store list)");
            Stores = new List<AStore>()
            {
                new MiamiStore("Miami Store"),
                new SantaFeStore("Santa Fe Store")
            };

            try
            {
                fs.WriteToXml(Stores);
            }
            catch(Exception ex)
            {
                PrintErrorMessage(ex);
            }

        }

        private void PopulateStores()
        {
            System.Console.WriteLine("(Reading Stores from file)");
            var fs = new FileStorage();
            if (Stores == null)
            {
                try
                {
                    Stores = fs.ReadFromXml<AStore>().ToList();
                }
                catch (Exception ex)
                {
                    PrintErrorMessage(ex);
                }
            }
        }

        private void PrintErrorMessage(Exception exception)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"{exception.Message}");
            System.Console.ResetColor();
            System.Console.WriteLine();
        }

    }

}