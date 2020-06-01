using Employee.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace EmployeeConsole
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            

            Console.WriteLine("-----------------------Adding To Employees-------------------");
            await AddEmployeeAsync();

            Console.WriteLine("-------------------Getting List Of Employees----------------------------");
            List<Employee.Core.Employee> employees = await GetEmployeeAsync();

        }
        public static async Task<List<Employee.Core.Employee>> GetEmployeeAsync()
        {
            List<Employee.Core.Employee> employees = new List<Employee.Core.Employee>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:58064/api/Employee"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    employees = JsonConvert.DeserializeObject<List<Employee.Core.Employee>>(apiResponse);
                }
            }
            return employees;
        }

        public static async Task<Employee.Core.Employee> AddEmployeeAsync()
        {
            Employee.Core.Employee employee = new Employee.Core.Employee
            {
                EmployeeId = 5,
                FirstName = "kumar",
                LastName = "test",
                PostCode = "CM72TE",
                City = "Braintree",
                EmploymentType = EmploymentType.FullTime,
                Manager = "Test",
                Department = DepartmentType.Travel,
                UserID = 1,
                LoginTime = DateTime.Now.AddHours(-1)
            };

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(employee),
                    Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("http://localhost:58064/api/Employee", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    employee = JsonConvert.DeserializeObject<Employee.Core.Employee>(apiResponse);
                }
            }
            return employee;
        }


    }
}
