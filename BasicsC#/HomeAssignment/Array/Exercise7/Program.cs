using System;
namespace Exercise6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i,j;
            int[,] arr1 = new int[3,3];
 
        
            Console.WriteLine("Input elements in the matrix : ");
            for(i=0;i<3;i++)
            {
                 for(j=0;j<3;j++)
                {
                    Console.Write($"element - [{i},{j}] : ");
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }  
 
            Console.Write("The matrix is : ");
            for(i=0;i<3;i++)
            {
                Console.Write("\n");
                for(j=0;j<3;j++)
                Console.Write($"{arr1[i,j]}");
            }
        }
    }
}