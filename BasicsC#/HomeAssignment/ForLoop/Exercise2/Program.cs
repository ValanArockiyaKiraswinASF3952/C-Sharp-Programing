using System;
namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            double sumValue = 0;
            int countValue = 0;
            for (int i =1; i<=10; i++)
            {
                sumValue += i;
                countValue += 1;
            }
            System.Console.WriteLine(($"Sum : {sumValue}"));
            double averageValue = sumValue/countValue;
            System.Console.WriteLine($"Average : {averageValue}");
        }
    }
}