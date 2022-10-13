using System;
namespace Exercise14;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter The Month");
        DateTime month1=DateTime.ParseExact(Console.ReadLine(),"MM",null);
        System.Console.WriteLine("Enter The Year");
        int leaveDays=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter The DAte");
        int salary=int.Parse( Console.ReadLine());
        
        int date1=DateTime.DaysInMonth(0001,month1.Month)-leaveDays;
        System.Console.WriteLine("Salary : "+date1*salary);
    }

}
