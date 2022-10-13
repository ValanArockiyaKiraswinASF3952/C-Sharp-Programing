using System;
namespace Ex3
{
    public class SalaryInfo:Attendance
    {
        public String SalaryMonth { get; set; }
        public string Month { get; set; }

        public SalaryInfo(DateTime date,int hours,String salaryMonth, string month):base(date,hours)
        {   
            SalaryMonth= salaryMonth;
            Month=month;
        }
        public void ShowSalary()
        {
            ShowAttendance();
            System.Console.WriteLine("Enter the Salary Month:"+SalaryMonth);
            System.Console.WriteLine("Enter the Salary Month:"+Month);

        }
    }
}