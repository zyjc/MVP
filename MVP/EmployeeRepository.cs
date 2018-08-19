using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVP
{
    public class EmployeeRepository
    {
        public static IList<EmployeeModel> employeeList;
        static EmployeeRepository()
        {
            employeeList = new List<EmployeeModel>();
            employeeList.Add(new EmployeeModel(1, "张一", "男", new DateTime(1999,8,2),   "研发部"));
            employeeList.Add(new EmployeeModel(1, "张二", "男", new DateTime(2000, 9, 2), "研发部"));
            employeeList.Add(new EmployeeModel(1, "张三", "男", new DateTime(2001, 10, 2),"研发部"));
            employeeList.Add(new EmployeeModel(1, "小红", "女", new DateTime(2002, 10, 2),"财务部"));
            employeeList.Add(new EmployeeModel(1, "小白", "女", new DateTime(2003, 10, 2),"财务部"));
        }

        public IEnumerable<EmployeeModel> GetEmployee(string department = "")
        {
            if(string.IsNullOrEmpty(department))
            {
                return employeeList;
            }
           return employeeList.Where(e=>e.Department == department).ToArray();
        }
    }
}