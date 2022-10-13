using System;
namespace ForLoopAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i=0; i<25; i=i+2)
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine("Enter the initial value: ");
            int initialValue = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter the final value: ");
            int finalValue = Convert.ToInt32(System.Console.ReadLine());
            int sum=0;
            for (int i= initialValue; i<finalValue; i++)
            {
                sum += i*i;
            }
             System.Console.WriteLine($"The sum of square of numbers in the above number limit is :{sum}");
        }
    }
}