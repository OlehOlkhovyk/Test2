using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public interface IProduct
    {
        string ProductName { get; set; }
        decimal Price { get; set; }
        decimal? Weight { get; set; }
        int? Quantity { get; set; }
        string PricingMethod { get; set; }

        void CreateString(ref decimal price, ref StringBuilder orderSummary);
    }
}
