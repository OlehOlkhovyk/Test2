using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factory
{
    public static class Factory
    {
        public static IProduct CreatePerPound()
        {
            return new PerPound();
        }
        public static IProduct CreatePerItem()
        {
            return new PerItem();
        }
        public static IProduct CreatePerPound(string productName, decimal price, decimal? weight, int? quantity, string pricingMethod)
        {
            return new PerPound() { ProductName = productName, Price = price, Weight = weight, Quantity = quantity, PricingMethod = pricingMethod };
        }
        public static IProduct CreatePerItem(string productName, decimal price, decimal? weight, int? quantity, string pricingMethod)
        {
            return new PerItem() { ProductName = productName, Price = price, Weight = weight, Quantity = quantity, PricingMethod = pricingMethod };
        }

    }
}
