using System;
namespace Exercise9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Time1");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        System.Console.WriteLine("Enter the Time2");
        DateTime date2=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        for(int i=date1.Year;i<=date2.Year;i++)
        {
            if (DateTime.IsLeapYear(i))
            {
                DateTime dates1=new DateTime(i,2,29);
                DateTime dates2=dates1.AddYears(i);
                System.Console.WriteLine($" is leap year{i}");
                System.Console.WriteLine($"one year from{date1.ToShortDateString()} to {date2.ToShortDateString()}");
            }

        }
    }   
}