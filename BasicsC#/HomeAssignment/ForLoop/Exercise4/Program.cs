using System;
namespace Exercise4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the input number: ");
            double inputValue = double.Parse(Console.ReadLine());
            for (int i =1; i<=10; i++)
            {
                System.Console.WriteLine($"{inputValue} * {i} = {inputValue*i}");
            }
        }
    }
}