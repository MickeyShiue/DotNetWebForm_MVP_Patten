using System;
using System.Collections.Generic;
using System.Linq;
using WebFormMVP.Models;

namespace WebFormMVP.Repository
{
    public class EmployeeRespository
    {
        private static IList<Employee> employees;

        static EmployeeRespository()
        {
            employees = new List<Employee>();
            employees.Add(new Employee("001", "Mickey", "男", new DateTime(1981, 8, 24), "銷售部"));
            employees.Add(new Employee("002", "Tom", "男", new DateTime(1981, 9, 24), "IT部"));
            employees.Add(new Employee("003", "David", "男", new DateTime(1981, 10, 24), "人事部"));
            employees.Add(new Employee("004", "Tanner", "男", new DateTime(1981, 11, 24), "採購部"));
            employees.Add(new Employee("005", "Bella", "女", new DateTime(1981, 12, 24), ""));
        }

        public IEnumerable<Employee> GetEmployees(string department = "")
        {
            if (string.IsNullOrEmpty(department))
                return employees;

            return employees.Where(r => r.Department == department).ToList();
        }
    }
}