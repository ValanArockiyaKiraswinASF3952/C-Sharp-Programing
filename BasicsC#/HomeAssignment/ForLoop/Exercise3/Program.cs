using System;
namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the input number of times: ");
            double inputValue = double.Parse(Console.ReadLine());
            for (int i =1; i<=inputValue; i++)
            {
                System.Console.WriteLine($"The umber is {i} the cube of {i} is {i*i*i}");
            }
        }
    }
}