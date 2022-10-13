using System;
namespace Exercise6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the input Radius of circle : ");
            int radius = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the input 1,2,3 : ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
            case 1:
            System.Console.WriteLine("The area is:" +(3.14*radius*radius) );
            break;
            
            case 2:             
            System.Console.WriteLine("The parameter is:" +(2*3.14*radius));
            break;

            case 3:
            System.Console.WriteLine("The diameter is:" +(2*radius));
            break;
    
            default:
            System.Console.WriteLine("Unexpected Input");
            break;
            }
        }
    }
}