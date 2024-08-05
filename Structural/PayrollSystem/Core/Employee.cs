using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Core
{
    public class Employee
    {
        public string FullName { get; set; } = string.Empty;
        public IEnumerable<PayItem> PayItems { get; set; }
    }
}
