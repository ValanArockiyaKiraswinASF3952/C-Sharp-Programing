using System;
namespace Exercise12;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month");
        DateTime month1=DateTime.ParseExact(Console.ReadLine(),"MM",null);
        System.Console.WriteLine("Enter the month");
        DateTime year1=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        System.Console.WriteLine($"The number  of the days: {month1.ToString("MMMM")} is {DateTime.DaysInMonth(year1.Year,month1.Month)}");

    }
}
