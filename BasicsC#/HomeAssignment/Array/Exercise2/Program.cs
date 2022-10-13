using System;
namespace Exercise2jm
{
    class Program
    {
        public static void Main(string[] args)
        {
             int i,n;
            int[] a= new int[100];
   
            Console.Write("Input the number of elements to store in the array : ");
            n = Convert.ToInt32(Console.ReadLine());    
   
   
            Console.WriteLine($"Input {n} number of elements in the array : ");
            for(i=0;i<n;i++)
            {
                Console.Write($"element - {i} : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
     
            Console.Write("\nThe values store into the array are : ");
            for(i=0;i<n;i++)
            {
                Console.Write($"{a[i]} ");
            }
 
            Console.Write("\n\nThe values store into the array in reverse are : ");
            for(i=n-1;i>=0;i--)
            {
                Console.Write($"{a[i]} ");
            }
            
            
        }
        

    }
}