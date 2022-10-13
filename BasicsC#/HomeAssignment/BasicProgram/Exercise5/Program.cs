using System;
namespace Exercise5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Chemistry Mark: ");
            double chemistryMark = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Physics Mark: ");
            double physicsMark = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Maths Mark: ");
            double mathsMark = Convert.ToDouble(Console.ReadLine());
            double sumValue = chemistryMark+physicsMark+mathsMark;
            double percentage = (sumValue/300)*100;

            System.Console.WriteLine($"Physics- {physicsMark}");
            System.Console.WriteLine($"Chemistry- {chemistryMark}");
            System.Console.WriteLine($"Sum- {sumValue}");
            System.Console.WriteLine($"Percentage- {Math.Round(percentage)}");
        }
    }
}