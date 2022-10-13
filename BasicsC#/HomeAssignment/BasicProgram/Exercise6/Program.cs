using System;
namespace Exercise6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the total price Amount: ");
            double price = Convert.ToDouble(Console.ReadLine());
            double total = price+price*0.18;

            System.Console.WriteLine($"Total = {total}");
        }
    }
}