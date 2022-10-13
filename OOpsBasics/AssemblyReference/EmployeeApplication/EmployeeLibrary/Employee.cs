using System;
namespace EmployeeLibrary
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
        public EmployeeDetails(string name, string role, WorkLocation workLocation, string teamName,DateTime doj, int workingDays, int leaveTaken,Gender gender)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            Name=name;
            Role=role;
            WorkLocation=workLocation;
            TeamName = teamName;
            DOB = doj;
            WorkingDays=workingDays;
            LeaveTaken=leaveTaken;
            Gender =gender;
            
        }
        public void CalculateSalary()
        {
            int calculateSalary = (WorkingDays-LeaveTaken)*500;
            System.Console.WriteLine("The salary is: "+calculateSalary);
        }
    }
}