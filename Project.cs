using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProject
{
    class Project
    {
       
        public String projectid
        {
            get; set;
        }
        public String projectname
        {
            get; set;
        }

        public String Manager
        {
            get; set;
        }
        public List<String> Emp = new List<String>();

        public Employee Employee
        {
            get;set;
        }
              Project(String pid,String pname,Employee Emp=null)
              {
               projectid = pid;
               projectname = pname;
               Employee = Emp;
             
              }
       public Project()
        {

        }
//

    }
}

