using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Core
{
	internal class OrderProcessor : IOrderProcessor
	{
		public void Process(Order order)
		{
			if (!order.Liens.Any())
			{
				throw new Exception("Order Is Empty!!");
			}
			Thread.Sleep(Random.Shared.Next(1000, 3000));
            Console.WriteLine("Order has been processed");
        }

	}
}
