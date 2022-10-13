using System;
namespace Exercise7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i,j,number;
            Console.Write("Enter the input number :");
            number = Convert.ToInt32(Console.ReadLine());    
            for(i=1;i<=number;i++)
            {
                for(j=number;j>i;j--)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}