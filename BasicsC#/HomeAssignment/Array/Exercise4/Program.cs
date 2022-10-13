using System;
namespace Exercise4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1= new int[100];
            int i, max, min, n;


            Console.Write("Input the number of elements to be stored in the array :");
            n= Convert.ToInt32(Console.ReadLine());  
   
            Console.WriteLine($"Input {n} elements in the array : ");
            for(i=0;i<n;i++)
            {
                Console.Write($"element - {i} : ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());  
            }


            max = arr1[0];
            min = arr1[0];

            for(i=1; i<n; i++)
            {
                if(arr1[i]>max)
                {
                    max = arr1[i];
                }


                if(arr1[i]<min)
                {
                    min = arr1[i];
                }
            }
            Console.WriteLine($"Maximum element is : {max}");
            Console.WriteLine($"Minimum element is : {min}");
        }
        

    }
}