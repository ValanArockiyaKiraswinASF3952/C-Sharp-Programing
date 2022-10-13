using System;
namespace Exercise4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the Number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the input Number 1,2,3,4,5");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
            case 1:
            System.Console.WriteLine($"The Addition of {number1} and {number2}");
            System.Console.WriteLine($"Output is: {number1+number2}");
            break;
            
            case 2:             
            System.Console.WriteLine($"The Subraction of {number1} and {number2}");
            System.Console.WriteLine($"Output is: {number1-number2}");
            break;

            case 3:
            System.Console.WriteLine($"The Multiplication of {number1} and {number2}");
            System.Console.WriteLine($"Output is: {number1*number2}");
            break;
            
            case 4:
            System.Console.WriteLine($"The Division of {number1} and {number2}");
            System.Console.WriteLine($"Output is: {number1/number2}");
            break;
        
            default:
            System.Console.WriteLine("Exit");
            break;
            }
        }
    }
}