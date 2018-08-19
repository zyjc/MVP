using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVP
{
    public class EmployeePresenter
    {
        public IEmployeeView View
        {
            private set;
            get;
        }
        public EmployeeRepository Repository
        {
            set;
            get;
        }

        public EmployeePresenter(IEmployeeView view)
        {
            this.View = view;
            this.Repository = new EmployeeRepository();
            this.View.DepartmentSelected += OnDepartmentSelected; ;
        }

        public void Initialize()
        {
            string[] departmentList = new string[] { "研发部", "财务部", "销售部" };
            this.View.BindDepartment(departmentList);

            IEnumerable<EmployeeModel> employeeModelList = this.Repository.GetEmployee();
            this.View.BindEmployee(employeeModelList);
        }

        public void OnDepartmentSelected(object sender, DepartmentSelectEventArgs args)
        {
            string departmentName = args.DepartmentName;
            IEnumerable<EmployeeModel> employeeModelList = this.Repository.GetEmployee(departmentName);
            this.View.BindEmployee(employeeModelList);
        }

    }
}