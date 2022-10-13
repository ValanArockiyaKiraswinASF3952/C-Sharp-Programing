using System;
namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];
            int i;

            System.Console.WriteLine("Input 10 elements in the array: ");
            for (i=0; i<10; i++)
            {
                System.Console.Write($"element - {i} : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.Write("Elements in array are: ");
            for ( i=0; i<10; i++)
            {
                System.Console.Write($"{array[i]} ");
            }
            
        }
        

    }
}