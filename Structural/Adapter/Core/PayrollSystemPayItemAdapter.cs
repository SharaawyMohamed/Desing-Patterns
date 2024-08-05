using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Core
{
    internal class PayrollSystemPayItemAdapter
    {
        private readonly PayItem _payItem;

        public PayrollSystemPayItemAdapter(PayItem payItem)
        {
            _payItem = payItem;
        }
        public string Name => _payItem.Name;
        public decimal Value => _payItem.IsDeduction ? -_payItem.Value : _payItem.Value;
    }
}
