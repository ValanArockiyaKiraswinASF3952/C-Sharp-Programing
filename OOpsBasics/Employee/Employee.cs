using System;
namespace EmployeePayRoll
{
    public enum WorkLocation{Default,Madura,Eymard}
    public enum Gender{Default,Male,Female,TransGender}
    public class EmployeeDetails
    {
        private static int s_employeeID=3000;
        public string EmployeeID { get;  }  
        
        public string Name { get; set; } 
        public string Role { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public string TeamName { get; set; }
        public DateTime DOB { get; set; }
        public int WorkingDays { get; set; }
        public int LeaveTaken { get; set; }
        public Gender Gender { get; set; }
        //public int LeaveTaken { get; set; }
        //public int WorkingDays { get; set; }
        public EmployeeDetails(string name, string role, WorkLocation workLocation, string teamName,DateTime doj,Gender gender)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            Name=name;
            Role=role;
            WorkLocation=workLocation;
            TeamName = teamName;
            DOB = doj;
            Gender =gender;
            
        }
        public void CalculateSalary()
        {
            int calculateSalary = (WorkingDays-LeaveTaken)*500;
            System.Console.WriteLine("The salary is: "+calculateSalary);
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("\nEmployeeID is: "+(EmployeeID));
        System.Console.WriteLine($"Employee Name is {Name}");
        System.Console.WriteLine($"Employee Role is {Role}");
        System.Console.WriteLine($"Employee Work Location is {WorkLocation}");
        System.Console.WriteLine($"Employee Team Name is {TeamName}");
        System.Console.WriteLine($"Employee Date of Joining is {DOB.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Employee Gender is {Gender}");
        }
        
        public void Working()
        {
            System.Console.WriteLine("Enter the number of Days Working : ");
            int work = int.Parse(Console.ReadLine());
            WorkingDays = work;
        }
        public void GetLeave()
        {
            System.Console.WriteLine("Enter the number of Leave : ");
            int leave = int.Parse(Console.ReadLine());
            LeaveTaken = leave;
        }
        
    }
}