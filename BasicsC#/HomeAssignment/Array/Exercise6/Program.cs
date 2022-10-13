using System;
namespace Exercise6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp;

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Input {n} elements in the array ");
            for(i=0;i<n;i++)
            {
                Console.Write($"element - {i} : ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());  
            }

            for(i=0; i<n; i++)
            {
                for(j=i+1; j<n; j++)
                {
                    if(arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                     }
                }
            }
            Console.WriteLine("Elements of array in sorted ascending order:\n");
            for(i=0; i<n; i++)
            {
                Console.Write($"{arr1[i]}  ");
            }
        }
    }
}