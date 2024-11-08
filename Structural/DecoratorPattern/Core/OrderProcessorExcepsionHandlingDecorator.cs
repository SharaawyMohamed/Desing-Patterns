﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Core
{
	internal class OrderProcessorExcepsionHandlingDecorator : IOrderProcessor
	{
		private readonly IOrderProcessor _orderProcessor;

		public OrderProcessorExcepsionHandlingDecorator(IOrderProcessor orderProcessor)
		{
			_orderProcessor = orderProcessor;
		}

		public void Process(Order order)
		{
			try
			{
				_orderProcessor.Process(order);
			}
			catch (Exception ex)
			{
                Console.WriteLine($"Exception: {ex.Message}");
            }
		}
	}
}
