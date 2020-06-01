using Employee.Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public Employee.Data.IEmployee Employee { get; }
        public EmployeeController(Employee.Data.IEmployee employee)
        {
            Employee = employee;
        }
        [HttpGet]
        public ActionResult<List<Employee.Core.Employee>> GetEmployee()
        {
            return Employee.GetEmployees();
        }

        [HttpGet("{employeeId}")]
        public ActionResult<Employee.Core.Employee> Get(int employeeId)
        {
            return Employee.GetEmployeeById(employeeId);
        }

        [HttpPost]
        public ActionResult<Employee.Core.Employee> Add(Employee.Core.Employee employee)
        {
            return Employee.Add(employee);
        }
    }
}
