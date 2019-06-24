using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProject
{
    class Employee
    {
       
        //properties of Employee Class
      public String employeeid
        {
            get;
            set;
        }
        public String employeename
        {
            get;
            set;

        }

        public String designation
        {
            get;
            set;
        }

        public List<String> Prj = new List<String>();
        public Project project
        {
            get;set;
        }
        public Employee()
        {

        }
        Employee(String Eid,String Ename,String Des,Project pro = null)
        {
            employeeid = Eid;
            employeename = Ename;
            designation = Des;
            project = pro;
        }
      //
    }
}

     
