using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_G2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> plist =new List<Product>() {
                 new Product() { Name = "lettuce", Price = 10.5, Quantity = 50, Type = "Leafy green" },
                 new Product() { Name = "cabbage", Price = 20, Quantity = 100, Type = "Cruciferous" },
                 new Product() { Name = "pumpkin", Price = 30, Quantity = 30, Type = "Marrow" },
                 new Product() { Name = "cauliflower", Price = 10, Quantity = 25, Type = "Cruciferous" },
                 new Product() { Name = "zucchini", Price = 20.5, Quantity = 50, Type = "Marrow" },
                 new Product() { Name = "yam", Price = 30, Quantity = 50, Type = "Root" },
                 new Product() { Name = "spinach", Price = 10, Quantity = 100, Type = "Leafy green" },
                 new Product() { Name = "broccoli", Price = 20.2, Quantity = 75, Type = "Cruciferous" },
                 new Product() { Name = "garlic", Price = 30, Quantity = 20, Type = "Leafy green" },
                 new Product() { Name = "silverbeet", Price = 10, Quantity = 50, Type = "Marrow" }
                 };
                 
            Console.WriteLine($"total number of Product : {plist.Count}");
            Console.WriteLine($"Adding potato");
            plist.Add(new Product() { Name = "Potato", Price = 10, Quantity = 50, Type = "Root" } );
            Console.WriteLine($"total number of Product : {plist.Count}");
            foreach (var product in plist)
            {
                if (product.Type.Equals("Leafy green"))
                    Console.WriteLine(product.Name);
            }

            var itemToRemove = plist.Single(r => r.Name == "garlic");
            if (itemToRemove != null)
              {  plist.Remove(itemToRemove);}
            Console.WriteLine($"total number of Product : {plist.Count}");

            string addproduct = "cabbage";
            int addquantity = 50;

            foreach (var product in plist )
            {
                    if(product.Name == addproduct)
                    {
                        product.Quantity = product.Quantity + addquantity ;

                        Console.WriteLine($"{addproduct} quantity is :{product.Quantity}");
                    }
            }

            double pricetotal = 0;
            foreach (var product in plist)
            {
                if (product.Name.Equals("lettuce"))
                {
                    pricetotal = pricetotal + (1)*product.Price;
                }
                if (product.Name.Equals("zucchini,"))
                {
                    pricetotal = pricetotal + (2) * product.Price;
                }
                if (product.Name.Equals("broccoli"))
                {
                    pricetotal = pricetotal + (1) * product.Price;
                }
              

            }
            Console.WriteLine("Price : {pricetotal}");
        }
    }
}