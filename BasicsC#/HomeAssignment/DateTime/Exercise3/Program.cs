using System;
namespace Exercise3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter name:");
        string string1=Console.ReadLine();
        DateTime date1=DateTime.Parse(string1.ToString());
        Console.WriteLine("Year :"+date1.Year);
        Console.WriteLine("Day :"+date1.Day);
        Console.WriteLine("Month :"+date1.Month);
        Console.WriteLine("Hour :"+date1.Hour);
        Console.WriteLine("Minutes :"+date1.Minute);
        Console.WriteLine("Seconds :"+date1.Second);
    }
}
        