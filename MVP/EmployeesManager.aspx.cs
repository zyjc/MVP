using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVP
{
    public partial class EmployeesManager : System.Web.UI.Page, IEmployeeView
    {
        public EmployeePresenter Presenter{get;private set;}
        public event EventHandler<DepartmentSelectEventArgs> DepartmentSelected;

        public EmployeesManager()
        {
            Presenter = new EmployeePresenter(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Presenter.Initialize();
            }
        }

        public void BindEmployee(IEnumerable<EmployeeModel> employeeList)
        {
            dgEmployee.DataSource = employeeList;
            dgEmployee.DataBind();
        }

        public void BindDepartment(IEnumerable<string> departmentList)
        {
            ddlDepartment.DataSource = departmentList;
            ddlDepartment.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string departmentName = ddlDepartment.SelectedValue;
            DepartmentSelectEventArgs args = new DepartmentSelectEventArgs(departmentName);
            if (DepartmentSelected != null)
            {
                this.DepartmentSelected(this, args);
            }
        }
    }
}