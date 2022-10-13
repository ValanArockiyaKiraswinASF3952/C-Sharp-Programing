using System;
namespace Exercise7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input value a: ");
            double value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the input value b: ");
            double value2 = Convert.ToDouble(Console.ReadLine());
            double formula = (value1*value1)+(2*value1*value2)+(value2*value2);

            System.Console.WriteLine($"Output : {formula}");
        }
    }
}