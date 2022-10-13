using System;
namespace DoWhileAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            string conndition="";

            do
            {
                System.Console.WriteLine("Enter the input number: ");
                int number = int.Parse(Console.ReadLine());
                
                if (number%2==0)
                {
                    System.Console.WriteLine("Result: Given number is Even number");
                }
                else
                {
                    System.Console.WriteLine("Result: Given number is Odd number");
                }
                
                    System.Console.WriteLine("Check the another number click yes : ");
                    conndition = Console.ReadLine().ToLower();
                    
            }while (conndition=="yes");
        }
    }
}