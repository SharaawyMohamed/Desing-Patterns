using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Core
{
    internal class Customer
    {
        public int Id { get; set;   }
        public string Name { get; set; } = string.Empty;
        public CustomerCategory Category { get; set; }
    }
}
