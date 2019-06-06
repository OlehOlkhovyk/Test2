using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class PerItem : IProduct
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal? Weight { get; set; }
        public int? Quantity { get; set; }
        public string PricingMethod { get; set; }

        public void CreateString(ref decimal price, ref StringBuilder orderSummary)
        {
            var productPrice = 0m;
            productPrice = (Quantity.Value * Price);
            price += productPrice;
            orderSummary.Append($" ${productPrice} ({Quantity} items at ${Price} each)");
        }
    }
}