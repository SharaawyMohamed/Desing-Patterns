using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Core
{
    internal class PayrollCalculator
    {
        internal decimal Calculate(Employee employee)
        {
            Debug.WriteLine($"Calculating salary for Employee : {employee.FullName}");
            if (employee.PayItems?.Any() == false)
            {
                return 0;
            }
            var TotalMonth = employee.PayItems.Sum(v => v.Value);
            return Math.Round(TotalMonth / DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) * DateTime.Today.Day, 2);// calculat total Salary
        }
    }
}
