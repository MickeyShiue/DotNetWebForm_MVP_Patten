using System;
using System.Collections.Generic;
using WebFormMVP.Models;
using WebFormMVP.Presenter;
using WebFormMVP.Views;

namespace WebFormMVP
{
    public partial class Default : System.Web.UI.Page, IEmployeeView
    {
        public EmployeePresenter presenter { get; private set; }
        public event EventHandler<DepartmentSelectedEventArgs> DepartmentSelected;

        public Default()
        {
            this.presenter = new EmployeePresenter(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                this.presenter.Initialize();
        }

        public void BindDepartments(IEnumerable<string> departments)
        {
            this.DropDownListDepartments.DataSource = departments;
            this.DropDownListDepartments.DataBind();
        }

        public void BindEmployees(IEnumerable<Employee> employees)
        {
            this.GridViewEmployee.DataSource = employees;
            this.GridViewEmployee.DataBind();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            string department = this.DropDownListDepartments.SelectedValue;
            DepartmentSelectedEventArgs eventArgs = new DepartmentSelectedEventArgs(department);

            if (DepartmentSelected != null)
                DepartmentSelected(this, eventArgs);
        }
    }
}