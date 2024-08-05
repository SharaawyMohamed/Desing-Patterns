using Strategy.Core;
using Strategy.Core.DiscountStrategies;
using System.Net.NetworkInformation;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new CustomerDataReader();
            var customers = dataReader.GetCustomers();
            while (true)
            {
                Console.WriteLine($"Customer List:\n[1] {customers[0].Name}\n[2] {customers[1].Name}");

                Console.WriteLine("Enter Customer ID:");
                var customerId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Item Quantity:");
                var quantity = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Unit Price:");
                var unitPrice = double.Parse(Console.ReadLine());

                var customer = customers.FirstOrDefault(x => x.Id == customerId);
                ICustomerDiscountStrategy _customerCategory;

                if (customer.Category == CustomerCategory.Gold)
                {
                    _customerCategory = new GoldCustomerDiscountStrategy();
                }
                else if (customer.Category == CustomerCategory.Silver)
                {
                    _customerCategory = new SilverCustomerDiscountStrategy();
                }
                else _customerCategory = new NewCustomerDiscountStrategy();

                var invoiceManager = new InvoiceManager();
                invoiceManager.SetDiscountStrategy(_customerCategory);
                var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);



                Console.WriteLine($"Invoice Created For {customer.Name} With Total Price {invoice.NetPrice}");
                Console.WriteLine("-----------------------------------------------------------\n");
                Console.ReadKey();
            }
        }
    }
}

