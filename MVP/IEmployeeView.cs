using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    public interface IEmployeeView
    {
        void BindEmployee(IEnumerable<EmployeeModel> employeeList);
        void BindDepartment(IEnumerable<string> department);
        event EventHandler<DepartmentSelectEventArgs> DepartmentSelected;
    }

    public class DepartmentSelectEventArgs : EventArgs
    {
        public string DepartmentName
        {
            set;
            get;
        }

        public DepartmentSelectEventArgs(string departmentName)
        {
            this.DepartmentName = departmentName;
        }
    }
}
