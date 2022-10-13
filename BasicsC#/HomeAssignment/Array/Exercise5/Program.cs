using System;
namespace Exercise4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i,j=0,k=0,n;

            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());  
   
            Console.WriteLine($"Input {n} elements in the array : ");
            for(i=0;i<n;i++)
            {
                Console.Write($"element - {i} : ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());  
            }

            for(i=0;i<n;i++)
            {
                if (arr1[i]%2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.WriteLine("The Even elements are : ");
            for(i=0;i<j;i++)
            {
                Console.Write($"{arr2[i]} ");
             }

            Console.WriteLine("\nThe Odd elements are : ");
            for(i=0;i<k;i++)
            {
                Console.Write($"{arr3[i]} ");
            }
          
        }
        

    }
}