using System;
namespace ArthOperators
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int add= number1+number2;
            Console.WriteLine($"Add two numbers      :{number1+number2}");
            Console.WriteLine($"Subract two numbers  :{number1-number2}");
            Console.WriteLine($"Multiple two numbers :{number1*number2}");
            Console.WriteLine($"Divide two numbers   :{number1/number2}");
            Console.WriteLine($"Modulo two numbers   :{number1%number2}");
           
        }
    }
}