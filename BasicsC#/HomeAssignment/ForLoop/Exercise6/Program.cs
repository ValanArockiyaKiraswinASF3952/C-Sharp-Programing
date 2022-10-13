using System;
namespace Exercise6
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i=1; i<=4; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }            
        }
    }
}