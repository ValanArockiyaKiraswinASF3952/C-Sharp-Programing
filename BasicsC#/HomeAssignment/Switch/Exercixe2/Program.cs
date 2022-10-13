using System;
namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Number 1,2,3,4,5,6,7");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
            case 1:
            System.Console.WriteLine("Monday");
            break;
            
            case 2:             
            System.Console.WriteLine("Tuesday");
            break;

            case 3:
            System.Console.WriteLine("Wednesday");
            break;
            
            case 4:
            System.Console.WriteLine("Thursday");
            break;
            
            case 5:
            System.Console.WriteLine("Friday");
            break;

            case 6:
            System.Console.WriteLine("Saterday");
            break;

            case 7:
            System.Console.WriteLine("Sunday");
            break;
        
            default:
            System.Console.WriteLine("Unexpected Number");
            break;
            }
        }
    }
}