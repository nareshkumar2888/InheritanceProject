using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProject
{
    class Employee :Project
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
      
    }
}

     
