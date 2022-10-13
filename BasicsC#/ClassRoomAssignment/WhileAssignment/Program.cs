using System;
namespace WhileAssignmet
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;
            while (number<25)
            {
                number +=1;
                if (number%2==0)
                {
                    System.Console.WriteLine(number);
                }
            }
            int num1;
            System.Console.WriteLine("Valid the input number: ");
            bool tem1 = int.TryParse(Console.ReadLine(),out num1);
            
            while (!tem1)
            {
                System.Console.WriteLine("Invalid input format. Please enter the input in number format.");

                System.Console.WriteLine("Valid the input number again:");
                tem1 = int.TryParse(Console.ReadLine(), out num1);
                
            }
            
        }
    }
}