using System;
namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age>17)
            {
                System.Console.WriteLine("Congratulation! ");
                System.Console.WriteLine("You are eligible for casting your vote.");
            }
            else
            {
                System.Console.WriteLine("You are Not eligible for casting your vote.");
            }
        }
    }
}