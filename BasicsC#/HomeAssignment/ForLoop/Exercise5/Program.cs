using System;
namespace Exercise5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the input number: ");
            double inputValue = double.Parse(Console.ReadLine());
            double countValue = 0;
            System.Console.WriteLine("The odd number are: ");
            for (int i=1; i<20; i++)
            {
                if (i%2 != 0)
                {
                    System.Console.WriteLine(i);
                    countValue += i;
                }
            }
            System.Console.WriteLine($"The Sum of odd Natural Number upto 10 terms : {countValue}");
        }
    }
}