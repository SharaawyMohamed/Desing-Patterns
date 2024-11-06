using DecoratorPattern.Core;
using System.Runtime.CompilerServices;

namespace DecoratorPattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IOrderProcessor processor = new OrderProcessor();

			var Order = new Order();
			Order.AddLine(1, 5, 1000);
			Order.AddLine(2, 3, 2500);
			Order.AddLine(3, 4, 12000);

			processor=new OrderProcessorProfilingDecorator(processor);
			processor.Process(Order);

			processor=new OrderProcessorQueuingDecorator(processor);
			processor.Process(Order);

			processor=new OrderProcessorExcepsionHandlingDecorator(new OrderProcessor());
			processor.Process(new Order());
		}
	}
}
