using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Core
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public string Manager { get; set; }
        public DepartmentType Department { get; set; }
        public int UserID { get; set; }
        public DateTime LoginTime { get; set; }
    }
       public enum EmploymentType
    {
        FullTime,
        PartTime,
        Contractual,
        Other
    }
    public enum DepartmentType
    {
        Travel,
        Finance,
        Other
    }
}
