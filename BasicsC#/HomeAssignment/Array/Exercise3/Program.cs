using System;
namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] a= new int[100];
            int i, n, sum=0;

            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());
   
            Console.WriteLine($"Input {n} elements in the array : ");
            for(i=0;i<n;i++)
            {
                Console.Write($"element - {i} : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(i=0; i<n; i++)
            {
             sum += a[i];
            }

            Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
            
        }
        

    }
}