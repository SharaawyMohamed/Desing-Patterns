using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Core
{
    public class Employee
    {
        public string FristName { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FristName} {SecondName} {LastName}";

        public IEnumerable<PayItem> PayItems { get; set; }
    }
}
