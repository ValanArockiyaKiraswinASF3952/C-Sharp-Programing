using System;
namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the input");
            int year = Convert.ToInt32(Console.ReadLine());
            
            if ((year%400==0) || (year%4==0 && year%100!=0))
            {
                System.Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                System.Console.WriteLine($"{year} is not leap year.");
            }
        }
    }
}