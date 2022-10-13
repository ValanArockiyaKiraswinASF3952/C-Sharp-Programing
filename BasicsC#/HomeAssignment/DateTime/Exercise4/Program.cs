using System;
namespace Exercise4;
class Program
{
    public static void Main(string[] args)
    {
        
        
        DateTime date1=new DateTime(2000,12,31);
        Console.WriteLine("The day of the week for {0:d} is{1}.",date1,date1.DayOfWeek);
    }
}
        
