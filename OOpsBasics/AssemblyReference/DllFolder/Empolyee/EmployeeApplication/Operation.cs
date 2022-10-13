using System;
using System.Collections.Generic;
namespace EmployeeLibrary;
public class Operation
{
    public static void MainMenu()
    {
        List<EmployeeDetails> employeeList = new List<EmployeeDetails>();
        System.Console.WriteLine("\nEnter the Employee Details.");
        string willing = "";

        do
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
            System.Console.WriteLine("Enter number of working days in month : ");
            int workingDays = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter number leave Taken in month : ");
            int leaveTaken = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Gender (Default,Male,Female,TransGender): ");
            Gender gender =Enum.Parse<Gender>( Console.ReadLine(),true);

            EmployeeDetails employee1 = new EmployeeDetails(name,role,workLocation,teamName,doj,workingDays,leaveTaken,gender);  //Application form printout

            employeeList.Add(employee1);

            System.Console.WriteLine("Register number is: "+(employee1.EmployeeID));

            System.Console.WriteLine("\nEnter the another employee details type (yes).");
            willing = Console.ReadLine().ToLower();
        }while (willing=="yes");
        
        foreach(EmployeeDetails employee in employeeList)
        {
        System.Console.WriteLine("\nEmployeeID is: "+(employee.EmployeeID));
        System.Console.WriteLine($"Employee Name is {employee.Name}");
        System.Console.WriteLine($"Employee Role is {employee.Role}");
        System.Console.WriteLine($"Employee Work Location is {employee.WorkLocation}");
        System.Console.WriteLine($"Employee Team Name is {employee.TeamName}");
        System.Console.WriteLine($"Employee Date of Joining is {employee.DOB.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Employee Working Days is {employee.WorkingDays}");
        System.Console.WriteLine($"Employee Leave Taken is {employee.LeaveTaken}");
        System.Console.WriteLine($"Employee Gender is {employee.Gender}");

        employee.CalculateSalary();

        }
    }
}
