using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVP
{
    public class EmployeeModel
    {
        public int ID
        {
            get;
            private set;
        }

        public string UserName
        {
            get;
            private set;
        }


        public string Gender
        {
            get;
            private set;
        }

        public DateTime BirthDate
        {
            get;
            private set;
        }

        public string Department
        {
            get;
            private set;
        }

        public EmployeeModel(int ID,string userName,string gender,DateTime birthDate,string department)
        {
            this.ID = ID;
            this.UserName = userName;
            this.Gender = gender;
            this.BirthDate = birthDate;
            this.Department = department;
        }
    }
}