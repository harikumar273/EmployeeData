using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Data
{
    public interface IEmployee
    {
        Core.Employee Add(Core.Employee employee);
        Core.Employee GetEmployeeById(int employeeId);
        List<Core.Employee> GetEmployees();
    }
}
