using Products.Entities;
using System.Globalization;
using System;

namespace Products
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Classe Comum
            Product product = new Product("table", 100.10);
            Console.WriteLine(product.PriceTag());

            ImportedProduct importedProduct = new ImportedProduct("table", 100.10, 20.30);
            Console.WriteLine(importedProduct.PriceTag());


            DateTime date = DateTime.Parse("2009-05-01");
            UsedProduct usedProduct = new UsedProduct("table", 100.10, date);
            Console.WriteLine(usedProduct.PriceTag());
        }
    }
}