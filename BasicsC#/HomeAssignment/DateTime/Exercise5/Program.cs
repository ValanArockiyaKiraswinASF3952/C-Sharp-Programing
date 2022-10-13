using System;
namespace Exercise5;
class Program
{
    public static void Main(string[] args)
    {
        
        
        DateTime date1=new DateTime(2000,12,31);
        for(int i=0;i<=10;i++)
        {
            DateTime date2=date1.AddYears(i);
            System.Console.WriteLine("{0:d} : day{1} of {2}{3}",date2,date2.DayOfYear,date2.Year,DateTime.IsLeapYear(date2.Year)?"(Leap Year":"");
        }
    }
}