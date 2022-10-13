using System;
namespace Exercise13;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Date");
        int date1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter The Month");
        int month1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter The Year");
        int year1=int.Parse(Console.ReadLine());
        DateTime day1=new DateTime(year1,month1,date1);
        System.Console.WriteLine("Input Date :"+day1.ToShortDateString());
        System.Console.WriteLine("The Last Day: "+day1.DayOfWeek);
    }
}