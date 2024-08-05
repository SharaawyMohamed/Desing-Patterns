using Adapter.Core;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PayrollSystem
{
    internal class Program
    {
        internal static async Task Main(string[] args)
        {
            var payrrollCalculatorUrl = "https://localhost:7181/PayrollCalculatorController";// my local host
            var reader = new EmployeesDateReader();
            var employees = reader.GetEmployees();

            var client = new HttpClient();
            foreach (var employee in employees)
            {
                var request = new HttpRequestMessage(HttpMethod.Post, payrrollCalculatorUrl);
                var EmployeeAdaptor = new PayrollSystemEmployeeAdapter(employee);
                request.Content = new StringContent(JsonSerializer.Serialize(EmployeeAdaptor), Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                var responseJson = await response.Content.ReadAsStringAsync();
                var salary = decimal.Parse(responseJson);

                Console.WriteLine($"Salary For Employee {employee.FullName} : {salary}");
            }
        }

    }
}
