using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollSystem.Core;

namespace PayrollSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayrollCalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public ActionResult<decimal> Calculate(PayrollSystem.Core.Employee employee)
        {
            var calculator = new PayrollCalculator();
            return Ok(calculator.Calculate(employee));
        }
    }
}
