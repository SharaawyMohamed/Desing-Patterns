using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Core
{
    internal class CustomerDataReader
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{
                    Id=1,
                    Name="Yasser Ali Malik",
                    Category=CustomerCategory.Gold
                },
                new Customer{
                    Id=2, Name="Ibrahim Khaled El-Naggar",
                    Category=CustomerCategory.Silver
                }
            };
        }
    }
}
