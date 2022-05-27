using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //store + (product + price)
            Dictionary<string, Dictionary<string, double>> stores = new Dictionary<string, Dictionary<string, double>>();
            string input;

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] info = input.Split(", ");
                string store = info[0];
                string product = info[1];
                double price = double.Parse(info[2]);

                if (!stores.ContainsKey(store))
                {
                    stores.Add(store, new Dictionary<string, double>());
                }

                stores[store].Add(product, price);
            }

            foreach (var store in stores.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var (product, price) in store.Value)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }

        }
    }
}
