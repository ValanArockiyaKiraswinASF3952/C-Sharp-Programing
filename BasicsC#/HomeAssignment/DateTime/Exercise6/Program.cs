using System;
namespace Exercise6;
class Program
{
    public static void Main(string[] args)
    {
        
        
        DateTime date1=DateTime.Now;
        Console.WriteLine("today = "+DateTime.Now);
        TimeSpan date2=new TimeSpan(40,0,0,0);
        DateTime result=date1.Add(date2);
        Console.WriteLine("{0}",result.DayOfWeek);
    }
}