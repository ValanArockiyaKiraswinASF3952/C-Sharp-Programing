using System;
namespace Exercise4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the third input: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            if ((firstNumber>secondNumber) && (firstNumber>thirdNumber))
            {
                System.Console.WriteLine("The 1st number is the greates among three number");
            }
            else if ((secondNumber>firstNumber) && (secondNumber>thirdNumber))
            {
                System.Console.WriteLine("The 2nd number is the greatest among three number");
            }
            else
            {
                System.Console.WriteLine("The 3rd number is the greates among three number");
            }
        }
    }
}