using System;
namespace Exercise10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Thye Date");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        DateTime yester1=date1.AddDays(-1);
        DateTime tommor1=date1.AddDays(1);
        System.Console.WriteLine($"yesterday: {yester1.ToShortDateString()}\nTomorrow : {tommor1.ToShortDateString()}");
        
    }
}
