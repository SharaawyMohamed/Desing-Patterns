using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Core
{
    public class PayrollSystemEmployeeAdapter
    {
        private readonly Employee _employee;
        private readonly IEnumerable<PayrollSystemPayItemAdapter> _payItems;
        public PayrollSystemEmployeeAdapter(Employee employee)
        {
            _employee = employee;
            _payItems = employee.PayItems.Select(payment => new PayrollSystemPayItemAdapter(payment)).ToList();
        }
        public string FullName { get; set; } = string.Empty;

        public IEnumerable<PayItem> PayItems { get; set; }

       
    }
}
