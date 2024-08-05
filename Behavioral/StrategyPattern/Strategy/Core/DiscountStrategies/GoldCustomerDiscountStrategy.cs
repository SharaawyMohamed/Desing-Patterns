using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Core.DiscountStrategies
{
    internal class GoldCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice > 10000 ? totalPrice * 0.10 : totalPrice;
        }
    }
}
