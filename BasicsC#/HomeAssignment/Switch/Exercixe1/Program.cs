using System;
namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Grade 'E','V','G','A','F'");
            char grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
            case 'E':
            System.Console.WriteLine("Excellent");
            break;
            
            case 'V':             
            System.Console.WriteLine("VerryGood");
            break;

            case 'G':
            System.Console.WriteLine("Good");
            break;
            
            case 'A':
            System.Console.WriteLine("Average");
            break;
            
            case 'F':
            System.Console.WriteLine("Fail");
            break;
        
            default:
            System.Console.WriteLine("Unexpected Grade");
            break;
            }
        }
    }
}