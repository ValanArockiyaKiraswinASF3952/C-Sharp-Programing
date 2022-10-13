using System;
namespace Exercise11;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Thye Date");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine($"The Date Of the Day :{date1.ToShortDateString()}");
        for(int i=0;i<12;i++)
        {
             DateTime month=date1.AddMonths(i);
             System.Console.WriteLine(month.ToString("MMMM"));

        }
       
        
    }
}