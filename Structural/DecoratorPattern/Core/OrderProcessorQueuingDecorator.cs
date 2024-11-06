using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Core
{
	internal class OrderProcessorQueuingDecorator : IOrderProcessor
	{
		private readonly IOrderProcessor _orderProcessor;
		private Queue<Order> _orders;
		public OrderProcessorQueuingDecorator(IOrderProcessor orderProcessor)
		{
			_orderProcessor = orderProcessor;
			_orders = new();
		}

		public void Process(Order order)
		{
			_orders.Enqueue(order);
            Console.WriteLine("Order has been queued.");
        }
	}
}
