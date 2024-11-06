using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Core
{
	internal class Order
	{
		List<OrderLine> _lines = new();
		public IEnumerable<OrderLine> Liens => _lines.AsReadOnly();
		public void AddLine(int itemId,double quantity,decimal unitPrice)
		{
			_lines.Add(new OrderLine { ItemId = itemId, Quantity = quantity, UnitPrice = unitPrice });
		}

	}
}
