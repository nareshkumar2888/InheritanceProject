using System;
using System.Collections;
using System.Collections.Generic;



namespace InheritanceProject
{
    class Program
    {
        static void Main(string[] args)
        {
           Manager m = new Manager();
            Project p =new Project();
           

            int ch = 0;
            do
            {
                Console.WriteLine("Enter the option");
                Console.WriteLine("**************************************************************\n1:EMPLOYEE:\n2.PROJECT:\n3.AssignEmployee:\n4.AssignProject:\n5.DisplyEmployee\n6.DisplyProject\n7.Delete Employee From The Project\n8.Delete Project to The Employee\n9.Edit Employee\n10.Edit Project\n11.exit\n************************************************************************");
                string cmd = Console.ReadLine();

                if (cmd.Length == 0)
                    continue;               
                try
                {
                    ch = int.Parse(cmd);
                }
                catch (Exception InvalidCommand)
                {
                    Console.WriteLine(InvalidCommand);

                }
               
                switch (ch)
                {              
                        
                    case 1:
                        char x = '\0';
                        do
                        {
                            Console.WriteLine("----------------------EMPLOYEE----------------------");
                            Console.WriteLine("Employee:-\n1.AddEmployee\n2.EditEmployee\n3.DeleteEmployee\n4.DisplyEmployeet\n");
                            Console.WriteLine("Enter The Option:");
                            String s = Console.ReadLine();

                             
                            if (x == '0')
                                continue;
                            try
                            {
                                x = char.Parse(s);
                            }
                            catch (Exception InvalidCommand)
                            {
                                Console.WriteLine(InvalidCommand);
                            }

                            switch (x)
                            {
                                case '1':
                                    m.AddEmployee();
                                    Console.WriteLine("\npress (*) Back To MainMenu\n");
                                    break;
                                case '2':
                                    m.ModifyEmployee();
                                    Console.WriteLine("\npress (*) Back To MainMenu\n");
                                    break;
                                case '3':
                                    m.DeleteEmployee();
                                    Console.WriteLine("\npress (*) Back To MainMenu\n");
                                    Console.WriteLine("Employee Deleted");
                                    break;
                                case '4':
                                    m.EmployeeDetails();
                                    Console.WriteLine("\npress (*) Back To MainMenu\n");
                                    break;
                                case '*':
                                    break;
                            }


                        } while (x != '*');
                break;
                   case 2:
                        char y='\0';
                        do
                        {
                            Console.WriteLine("----------------------PROJECT----------------------");
                            Console.WriteLine("Project:-\n1.AddProject\n2.EditProject\n3.DeleteProject\n4.DisplyProject\n");
                            Console.WriteLine("Enter The Option:");
                            String s = Console.ReadLine();
                            if (y == '0')
                                continue;
                            try
                            {
                                y = char.Parse(s);
                            }catch(Exception InvalidCommand)
                            {
                                Console.WriteLine(InvalidCommand);
                            }
                            switch (y)
                            {
                                case '1':
                                    m.AddProject();
                                    Console.WriteLine("\npress (*) Back To MainMenu\n");
                                    break;
                                case '2':
                                    m.ModifyProject();
                                   
                                    Console.WriteLine("\npress (*) Back To MainMenu\n");
                                    break;
                                case '3':
                                    m.DeleteProject();
                                    Console.WriteLine("Project Deleted");
                                    Console.WriteLine("\npress (*) Back To MainMenu\n");
                                    break;
                                case '4':
                                    m.ProjectDetails();
                                    Console.WriteLine("\npress (*) Back To MainMenu\n");
                                    break;
                                case '*':
                                    break;
                            }
                        } while (y != '*');
                
                break;
                        

                    case 3:

                        m.AssignEmployee();
                break;

                    case 4:

                        m.AssignProject();
                break;

                    case 5:

                        m.DisplyEmployee();

                break;

                    case 6:
                        m.DisplyProject();

                break;
                    case 7:
                        m.DelEmpProject();
                        break;
                    case 8:
                        m.DelProEmployee();
                        break;
                    case 9:
                        m.EditEmpProject();
                        break;
                    case 10:
                        m.EditProEmployee();
                        break;

                    case 11:
                        Console.WriteLine("EXIT");
                break;


                }




            } while (ch != 11);

        }

    }
}
   
   
   