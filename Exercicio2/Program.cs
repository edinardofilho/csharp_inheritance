using Exercicio2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            
            Console.Write("Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string type = Console.ReadLine();
                switch (type)
                {
                    case "c":
                        {
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            list.Add(new Product(name, price));
                            break;
                        }
                    case "u":
                        {
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Manufacture date (DD/MM/YYYY): ");
                            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                            list.Add(new UsedProduct(name, price, manufactureDate));
                            break;
                        }
                    default:
                        {
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Customs fee: ");
                            double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            list.Add(new ImportedProduct(name, price, customsFee));
                            break;
                        }
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
