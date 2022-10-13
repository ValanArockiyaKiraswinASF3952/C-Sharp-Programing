using System;
using System.Collections.Generic;
namespace EmployeePayRoll;
public static class Operations 
{
    static EmployeeDetails currentEmployee = null;
    static int workingDays=0;
    static int leaveTaken=0;
    static List<EmployeeDetails> employeeList = new List<EmployeeDetails>();
    public static void MainMenu()
    {
        String choice = "yes";
        do
        {
            System.Console.WriteLine("Select the options 1.Registration 2.Login 3.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
        }while (choice=="yes");
    }

        public static void Registration()
        {
            System.Console.WriteLine("EmployeeDetails \n");
            System.Console.WriteLine("Enter Employee Name : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Employee Role : ");
            string role = Console.ReadLine();
            System.Console.WriteLine("Enter the work location (Default/Madura/Eymard): ");
            WorkLocation workLocation = Enum.Parse<WorkLocation>( Console.ReadLine(),true);
            System.Console.WriteLine("Enter Team Name : ");
            string teamName = Console.ReadLine();
            System.Console.WriteLine("Enter DOB in (dd/MM/yyyy)");
            DateTime doj = DateTime.Parse(Console.ReadLine());
            /*System.Console.WriteLine("Enter number of working days in month : ");
            int workingDays = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter number leave Taken in month : ");
            int leaveTaken = int.Parse(Console.ReadLine());*/
            System.Console.WriteLine("Enter the Gender (Default,Male,Female,TransGender): ");
            Gender gender =Enum.Parse<Gender>( Console.ReadLine(),true);

            EmployeeDetails employee1 = new EmployeeDetails(name,role,workLocation,teamName,doj,gender);  //Application form printout

            employeeList.Add(employee1);

            System.Console.WriteLine("Register number is: "+(employee1.EmployeeID));
        }

        public static void Login()
        {
            System.Console.WriteLine("Enter your Employee ID number: ");
            string employeeID = Console.ReadLine().ToUpper();
            foreach (EmployeeDetails employee in employeeList)
            {
                if (employee.EmployeeID==employeeID)
                {
                    System.Console.WriteLine("Login Sucessfull");
                    currentEmployee=employee;
                    SubMenu();
                }
            }
        }

        public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select SubMenu Options \n 1.Show Details 2.No of Working days 3.No of days leave taken 4.Calculate salary 5.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Details");
                        currentEmployee.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Enter No of days Working");
                        currentEmployee.Working();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Enter No of days Leave Taken");
                        currentEmployee.GetLeave();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Calculate Salary");
                        currentEmployee.CalculateSalary();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Exit SubMenu");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

    
}
