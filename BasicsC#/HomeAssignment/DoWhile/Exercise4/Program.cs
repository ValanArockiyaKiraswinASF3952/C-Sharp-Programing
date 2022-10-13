using System;
namespace DoWhileAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = false;
            int number =0;
            System.Console.WriteLine("Enter the number: ");
            do
            {
                flag = int.TryParse(Console.ReadLine(), out number);
                if (!flag||number<1|| number>10)
                {
                    System.Console.WriteLine("Invalid input enter again: ");
                }

            }while (!flag||number<1||number>10);
            System.Console.WriteLine($"{number} is a valid integer.");
        }
    }
}