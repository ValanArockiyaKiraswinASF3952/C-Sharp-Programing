using System;
namespace Exercise5
{
    class Program
    {
        public static void Main(string[] args)
        {
            double total=0,input1=0;
            System.Console.WriteLine("Enter the number: ");
            double value = double.Parse(Console.ReadLine());
            input1=value;
            while (input1!=0)
            {
                double digit = input1%10;
                total = total+digit;
                input1 = (int) input1/10;
            }
            System.Console.WriteLine($"Sum of digit {total}");
        }
    }
}