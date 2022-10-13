using System;
namespace Exercise2;
class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter name:");
        string string1=Console.ReadLine();
        DateTime date1=DateTime.Parse(string1.ToString());
        Console.WriteLine("Complete Date: "+date1);
        Console.WriteLine("short day: "+date1.ToShortTimeString());
        Console.WriteLine(date1.ToLongDateString()+ "  "+date1.ToShortTimeString());
        Console.WriteLine(date1.ToString("dd/MM/yyyy"));
        Console.WriteLine(date1.ToString("hh/mm/ss"));
    }
}
        