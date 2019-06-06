using ConsoleApp1.Factory;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Tuple<string, List<IProduct>>("John Doe",
                new List<IProduct>
                {
                    Factory.CreatePerPound("Pulled Pork", 6.99m, 0.5m, null, "PerPound"),
                    Factory.CreatePerItem("Coke", 3m, null, 2, "PerItem")
                }
            );

            var price = 0m;
            var orderSummary = new StringBuilder("ORDER SUMMARY FOR ");
            orderSummary.Append(order.Item1);
            orderSummary.Append(": \r\n");

            foreach (var orderProduct in order.Item2)
            {
                orderSummary.Append(orderProduct.ProductName);

                orderProduct.CreateString(ref price, ref orderSummary);

                orderSummary.Append( "\r\n");
            }

            Console.WriteLine(orderSummary);
            Console.WriteLine($"Total Price: ${price}");

            Console.ReadKey();
        }
    }
}

