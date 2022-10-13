using System;
namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the input: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number%2==0)
            {
                System.Console.WriteLine($"{number} is an even integer");
            }
            else
            {
                System.Console.WriteLine($"{number} is an odd integer");
            }
        }
    }
}