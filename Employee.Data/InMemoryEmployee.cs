using Employee.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee.Data
{
    public class InMemoryEmployee : IEmployee
    {
        List<Core.Employee> listEmployee;
        public InMemoryEmployee()
        {
            listEmployee = new List<Core.Employee> {
            new Core.Employee{
                EmployeeId=1,
                FirstName="xxxx",
                LastName="xxxxx",
                PostCode="CM72TE",
                City="Braintree",
                EmploymentType= EmploymentType.FullTime,
                Manager="Test",
                Department=DepartmentType.Finance,
                UserID=1,
                LoginTime=DateTime.Now.AddHours(-1)
            },
             new Core.Employee{
                EmployeeId=2,
                FirstName="yyyyy",
                LastName="yyyyy",
                PostCode="CM72TE",
                City="Braintree",
                EmploymentType= EmploymentType.FullTime,
                Manager="Test",
                Department=DepartmentType.Travel,
                UserID=1,
                LoginTime=DateTime.Now.AddHours(-1)
            },
              new Core.Employee{
                EmployeeId=3,
                FirstName="zzzz",
                LastName="zzzzz",
                PostCode="CM72TE",
                City="Braintree",
                EmploymentType= EmploymentType.FullTime,
                Manager="Test",
                Department=DepartmentType.Travel,
                UserID=1,
                LoginTime=DateTime.Now.AddHours(-1)
            },
               new Core.Employee{
                EmployeeId=4,
                FirstName="aaaa",
                LastName="aaaa",
                PostCode="CM72TE",
                City="Braintree",
                EmploymentType= EmploymentType.FullTime,
                Manager="Test",
                Department=DepartmentType.Other,
                UserID=1,
                LoginTime=DateTime.Now.AddHours(-1)
            }
            };
        }

        public Core.Employee Add(Core.Employee newEmployee)
        {
            listEmployee.Add(newEmployee);
            return newEmployee;

        }       

        public Core.Employee GetEmployeeById(int employeeId)
        {
            try
            {
                return listEmployee.SingleOrDefault(e => e.EmployeeId == employeeId);
            }
            catch (Exception employeeNotFound)
            {
                throw employeeNotFound;
            }

        }
        public List<Core.Employee> GetEmployees()
        {
            try
            {
                return listEmployee.ToList();
            }
            catch (Exception employeeNotFound)
            {
                throw employeeNotFound;
            }

        }
    }
}
