using System;
namespace Exercise8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Time1");
        DateTime date1=DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Time2");
        DateTime date2=DateTime.Parse(Console.ReadLine());
        int result=DateTime.Compare(date1,date2);
        if(result<0)
        {
            System.Console.WriteLine($"{result}:{date1} is Earlier than {date2}");
        }
        else if(result==0)
            
        {
            System.Console.WriteLine($"{result}:{date1} is same as {date2}");

        }
        else{
            System.Console.WriteLine($"{result}:{date1} is Later than {date2}");
        }
    }
}