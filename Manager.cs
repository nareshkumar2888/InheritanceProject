using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace InheritanceProject
{
    class Manager
    {
        public String managername
        {
            get;
            set;

        }


        public List<Project> project = new List<Project>();

        public List<Employee> employee = new List<Employee>();

        Employee emp;
        public void AddEmployee()
        {
            Console.WriteLine("Enter The Number Of Emplyees You Want To Add:");

            int j = int.Parse(Console.ReadLine());
            for (int i = 1; i <= j; i++)
            {
                emp = new Employee();
                Console.WriteLine("Please Enter EmployeeId:");
                emp.employeeid = Console.ReadLine();

                while (emp.employeeid == "")
                {
                    Console.WriteLine("Employee ID is Mandatory:");
                    emp.employeeid = Console.ReadLine();
                }

                Console.WriteLine("Please Enter EmployeeName:");
                emp.employeename = Console.ReadLine();

                while (emp.employeename == "")
                {
                    Console.WriteLine("Employee Name is Mandatory:");
                    emp.employeename = Console.ReadLine();
                }

                Console.WriteLine("Please Enter Designation:");
                emp.designation = Console.ReadLine();

                while (emp.designation == "")
                {
                    Console.WriteLine("Employee Designation  is Mandatory:");
                    emp.designation = Console.ReadLine();

                };
                int flag = 0;
                foreach (Employee e in employee)
                {
                    if (e.employeeid.Equals(emp.employeeid))
                    {
                        flag = 1;
                        Console.WriteLine("EmployeeId Already Entered!!!");
                        break;
                    }
                }
                if (flag == 0)
                {
                    employee.Add(emp);

                    Console.WriteLine("Employee Added");
                }
                else
                {
                    Console.WriteLine("EmployeeId Already Entered!!!");
                }
            }
        }


        public void DeleteEmployee()
        {
            Console.WriteLine("Please Enter EmployeeId:");
            String Eid = Console.ReadLine();
            while (Eid == "")
            {
                Console.WriteLine("Employee ID is Mandatory:");
                emp.employeeid = Console.ReadLine();
            };
            employee.RemoveAll(Employee => Employee.employeeid == Eid);
        }


        public void ModifyEmployee()
        {
            Console.WriteLine("Please Enter EmployeeId:");
            String eid = Console.ReadLine();

            Console.WriteLine("***********Editing The Employee Details*********:\n");
            foreach (Employee emp in employee)
            {
                if (emp.employeeid.Equals(eid))
                {
                    Console.WriteLine("Edit Employee Name");
                    emp.employeename = Console.ReadLine();
                    while (emp.employeename == "")
                    {
                        Console.WriteLine("Employee Name is Mandatory:");
                        emp.employeename = Console.ReadLine();
                    }
                    Console.WriteLine("employee Name changed");
                    Console.WriteLine("Edit Designation:");

                    emp.designation = Console.ReadLine();
                    while (emp.designation == "")
                    {
                        Console.WriteLine("Employee Designation  is Mandatory:");
                        emp.designation = Console.ReadLine();

                    };
                    Console.WriteLine("designation Changed");
                    return;
                }
            }

            Console.WriteLine("Employee with id:" + eid + "does not exist");
        }



        public void EmployeeDetails()
        {
            Console.WriteLine("------------The Employee Details Are:----------------\n");
            foreach (Employee e in employee)
            {
                Console.WriteLine(e.employeeid + "          " + e.employeename + "           " + e.designation);
            }
        }



        //**************************************************************************************






        Project pro = null;


        public void AddProject()
        {
            pro = new Project();
            Console.WriteLine("**************Adding The Project**************\n");

            Console.WriteLine("Please Enter ProjectId:");
            pro.projectid = Console.ReadLine();
            while (pro.projectid == "")
            {
                Console.WriteLine("Please Enter Correct ID:");
                pro.projectid = Console.ReadLine();
            }

            Console.WriteLine("Please Enter ProjectName:");
            pro.projectname = Console.ReadLine();
            while (pro.projectname == "")
            {
                Console.WriteLine("Please Enter Correct Name:");
                pro.projectname = Console.ReadLine();
            }

            int flag = 0;
            foreach (Project p in project)
            {
                if (p.projectid.ToString().Equals(pro.projectid.ToString()))
                {

                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                project.Add(pro);

                Console.WriteLine("Project Added");
            }
            else
            {
                Console.WriteLine("ProjectId Already Entered!!!");
            }
        }


        public void ModifyProject()
        {
            Console.WriteLine("Please Enter ProjectId:");
            String pid = Console.ReadLine();
            while (pid == "")
            {
                Console.WriteLine("Please Enter Correct ID:");
                pid = Console.ReadLine();
            };
            Console.WriteLine("****************Editing The Project************\n");
            foreach (Project p in project)
            {
                if (p.projectid.Equals(pid))
                {

                    Console.WriteLine("edit praject Name:");

                    pro.projectname = Console.ReadLine();
                    while (pro.projectname == "")
                    {
                        Console.WriteLine("Please Enter Correct Name:");
                        pro.projectname = Console.ReadLine();
                    };

                    Console.WriteLine("Project Name changed:");
                    break;
                }

            }
            Console.WriteLine("Project ID Not Found!!!!");
        }



        public void DeleteProject()
        {
            Console.WriteLine("Please Enter ProjectId:");
            String projectid = Console.ReadLine();
            while (projectid == "")
            {
                Console.WriteLine("Please Enter Correct ID:");
                pro.projectid = Console.ReadLine();
            }
            project.RemoveAll(Project => Project.projectid == projectid);
        }


        public void ProjectDetails()
        {
            Console.WriteLine("---------------------The Project Details Are:---------------\n");
            foreach (Project p in project)
            {

                Console.WriteLine(p.projectid + "               " + p.projectname);
            }
        }
        //********************************************************************************************************


        public void AssignProject()
        {

            if (employee.Count() == 0 || project.Count() == 0)
            {
                if (employee.Count() == 0)
                {
                    Console.WriteLine("No Projects Added Yet...Please Add Projects.");
                }
                else
                {
                    Console.WriteLine("No Employees Added Yet....Please Add Employees");
                }
            }
            else
            {
                Console.WriteLine("Enter The Employee Id:");
                String Eid = Console.ReadLine();
                while (Eid == "")
                {
                    Console.WriteLine("Employee Id is Mandatory:");
                    Eid = Console.ReadLine();
                }

                foreach (Employee e in employee)
                {
                    if (e.employeeid.Equals(Eid))
                    {
                        Console.WriteLine("Please Enter no of Projects you want to Add:");
                        String ch = Console.ReadLine();

                        int n = int.Parse(ch);

                        for (int j = 1; j <= n; j++)
                        {
                            Console.WriteLine("--> the " + j + " Project:");
                            String Pid = Console.ReadLine();
                            Project p = VerifyProject(Pid);
                            if (!p.Equals(null))
                            {

                                p.Emp.Add(e.employeename);
                                e.Prj.Add(p.projectname);

                                Console.WriteLine("Project Added to Employee");
                            }
                            else
                            {
                                Console.WriteLine("Project  Id Invalid !");
                            }
                        }
                    }

                }
            }

            {
                Console.WriteLine("Enter the correct Project id");
            }
        }


        public void AssignEmployee()
        {

            if (project.Count() == 0 || employee.Count() == 0)
            {
                if (project.Count() == 0)
                {
                    Console.WriteLine("No Projects Added Yet...Please Add Projects.");
                }
                else
                {
                    Console.WriteLine("No Employees Added Yet....Please Add Employees");
                }
            }
            else
            {
                Console.WriteLine("Enter The Project Id:");
                String pid = Console.ReadLine();
                while (pid == "")
                {
                    Console.WriteLine("Project Id is Mandatory:");
                    pid = Console.ReadLine();
                }
                foreach (Project p in project)
                {
                    if (p.projectid.Equals(pid))
                    {

                        Console.WriteLine("Please Enter No of Emplyee You Want to Add:\n");
                        String ch = Console.ReadLine();
                        int n = int.Parse(ch);
                        for (int j = 1; j <= n; j++)
                        {
                            Console.WriteLine(" -->Enter " + j + " EmployeeId:");
                            String Eid = Console.ReadLine();
                            Employee e = VerifyEmployee(Eid);
                            try
                            {
                                if (!p.Emp.Contains(e.employeename))
                                {

                                    p.Emp.Add(e.employeename);
                                    e.Prj.Add(p.projectname);

                                    Console.WriteLine("Employee Added to Project");
                                }
                                else
                                {
                                    Console.WriteLine("Employee Already Added");
                                }
                            } catch (Exception NullReferenceException)
                            {
                                Console.WriteLine(NullReferenceException);
                            }

                        }
                    }

                }

            }
        }



        public void DisplyProject()
        {
            int Count = 0;
            foreach (Project p in project)
            {
                if (p.Emp.Count > 0)
                {
                    ++Count;
                }
            }
            if (Count == 0)
            {
                Console.WriteLine("Employees Not Added");

            }
            else
            {
                Console.WriteLine("Details of Employees working on Projects\n");
                foreach (Project p in project)
                {
                    for (int y = 0; y < p.Emp.Count(); y++)
                    {
                        Console.WriteLine("ProjectId:{0}      ProjectName:{1}\n ", p.projectid, p.projectname);
                        Console.WriteLine("EmployeeName:{0}", p.Emp[y]);
                    }
                }

            }
        }
        public void DisplyEmployee()
        {
            int Count1 = 0;
            foreach (Project p in project)
            {
                if (p.Emp.Count > 0)
                {
                    ++Count1;
                }
            }
            if (Count1 == 0)
            {
                Console.WriteLine("Projects Not Added");

            }
            else
            {
                Console.WriteLine("Deatils of Projects Assigning to Employees\n");
                foreach (Employee e in employee)
                {
                    Console.WriteLine();
                    for (int i = 0; i < e.Prj.Count(); i++)
                    {
                        Console.WriteLine("EmployeeId:{0}       EmployeeName:{1}     Designation:{2}", e.employeeid, e.employeename, e.designation);
                        Console.WriteLine("ProjectName:{0}", e.Prj[i]);
                    }

                }
            }
        }

        public void DelEmpProject()
        {
            Console.WriteLine("Enter ProjectId:");
            String pid = Console.ReadLine();
            foreach (Project p in project)
            {
                if (p.projectid.Equals(pid))
                {
                    Console.WriteLine("Enter EmployeeId");
                    String Eid = Console.ReadLine();
                    Employee e = VerifyEmployee(Eid);
                    if (!e.Equals(null))
                    {
                        p.Emp.Remove(e.employeename);
                        e.Prj.Remove(p.projectname);
                        Console.WriteLine("Employee Deleted From Project");
                    }
                    else
                    {
                        Console.WriteLine("Employee Id Invalid !");
                    }
                }

            }

        }

        public void DelProEmployee()
        {
            Console.WriteLine("Enter The Employee Id:");
            String Eid = Console.ReadLine();
            while (Eid == "")
            {
                Console.WriteLine("Employee Id is Mandatory:");
                Eid = Console.ReadLine();
            }
            foreach (Employee e in employee)
            {

                if (e.employeeid.Equals(Eid))
                {
                    Console.WriteLine("Enter ProjectId:");
                    String Pid = Console.ReadLine();
                    Project p = VerifyProject(Pid);
                    if (!p.Equals(null))
                    {
                        p.Emp.Remove(e.employeename);
                        e.Prj.Remove(p.projectname);
                        Console.WriteLine("Project Deleted From Employee");
                    }
                    else
                    {
                        Console.WriteLine("Project  Id Invalid !");
                    }
                }

            }

        }


        public Employee VerifyEmployee(String EmpId)
        {
            foreach (Employee e in employee)
            {
                //String x = null;
                if (e.employeeid.Equals(EmpId))
                {
                    // Console.WriteLine(e);
                    return e;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }


        public Project VerifyProject(String PId)
        {
            foreach (Project p in project)
            {
                if (p.projectid.Equals(PId))
                {
                    // Console.WriteLine(p);
                    return p;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        public void EditEmpProject()
        {
            int flag = 0;
            Console.WriteLine("Enter The Project Id:");
            String pid = Console.ReadLine();
            while (pid == "")
            {
                Console.WriteLine("Project Id is Mandatory:");
                pid = Console.ReadLine();
            }
            foreach (Project p in project)
            {
                if (p.projectid.Equals(pid))
                {
                    flag = 1;
                    Console.WriteLine("Enter EmployeeId");

                    String Eid = Console.ReadLine();
                    Employee e = VerifyEmployee(Eid);

                    if (e.employeeid.Equals(Eid))
                    {
                        Console.WriteLine("Enter The Employee:Name");
                        e.employeename = Console.ReadLine();
                        p.Emp.Add(e.employeename);
                        e.Prj.Add(p.projectname);
                        Console.WriteLine("Enter New EmployeeId");



                    }

                }
            }

        }



        public void EditProEmployee()
        {
            Console.WriteLine("Enter The Employee Id:");
            String Eid = Console.ReadLine();
            while (Eid == "")
            {
                Console.WriteLine("Employee Id is Mandatory:");
                Eid = Console.ReadLine();
            }
            foreach (Employee e in employee)
            {

                if (e.employeeid.Equals(Eid))
                {
                    Console.WriteLine("Enter ProjectId:");
                    String Pid = Console.ReadLine();
                    Project p = VerifyProject(Pid);

                    Console.WriteLine("Enter New Project Name:");

                    p.projectname = Console.ReadLine();
                    p.Emp.Add(e.employeename);
                    e.Prj.Add(p.projectname);
                    Console.WriteLine("Project Changed");

                }
                else
                {
                    Console.WriteLine("Project  Id Invalid !");
                }

            }

        }




    }
}




       

        





    


