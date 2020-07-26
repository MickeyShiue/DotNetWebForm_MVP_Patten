using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormMVP.Models;
using WebFormMVP.Repository;
using WebFormMVP.Views;

namespace WebFormMVP.Presenter
{
    public class EmployeePresenter
    {
        public IEmployeeView View { get; private set; }
        public EmployeeRespository Respository { get; private set; }

        public EmployeePresenter(IEmployeeView view)
        {
            this.View = view;
            this.Respository = new EmployeeRespository();
            this.View.DepartmentSelected += OnDepartmentSelected;
        }

        public void Initialize()
        {
            IEnumerable<Employee> employees = this.Respository.GetEmployees();
            this.View.BindEmployees(employees);

            string[] departments = new string[] { "", "銷售部", "採購部", "人事部", "IT部" };
            this.View.BindDepartments(departments);
        }

        private void OnDepartmentSelected(object sender, DepartmentSelectedEventArgs args)
        {
            string department = args.Department;
            var employees = this.Respository.GetEmployees(department);
            this.View.BindEmployees(employees);
        }
    }
}