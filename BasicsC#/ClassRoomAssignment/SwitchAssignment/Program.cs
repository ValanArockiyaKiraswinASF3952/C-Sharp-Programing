using System;
namespace SwitchAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the Symbol('+','-','*','/','%'): ");
            char symbol = Convert.ToChar(Console.ReadLine());
            
            switch (symbol)
            {
                case '+':
                {
                     System.Console.WriteLine($"Add two number:{number1+number2}");
                     break;
                }
                case '-':
                {
                     System.Console.WriteLine($"Subract two number:{number1-number2}");
                     break;
                }
                case '*':
                {
                     System.Console.WriteLine($"Multiple two numbers:{number1*number2}");
                     break;
                }
                case '/':
                {
                     System.Console.WriteLine($"Divide two numbers:{number1/number2}");
                     break;
                }
                case '%':
                {
                     System.Console.WriteLine($"Modulo two number:{number1%number2}");
                     break;
                }
                default:
                {
                    System.Console.WriteLine("Operator Invalid");
                    break;
                }

            }

            
        }
    }
}