using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Core
{
	internal class OrderProcessorProfilingDecorator : IOrderProcessor
	{
		private readonly IOrderProcessor _orderProcessor;

		public OrderProcessorProfilingDecorator(IOrderProcessor orderProcessor)
		{
			_orderProcessor = orderProcessor;
		}

		public void Process(Order order)
		{
			var stopWatch = new Stopwatch();
			stopWatch.Start();
			_orderProcessor.Process(order);
			stopWatch.Stop();
            Console.WriteLine($"Time Token:{stopWatch.Elapsed.TotalSeconds}s");
        }
	}
}
