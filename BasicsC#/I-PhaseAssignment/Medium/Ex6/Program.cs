using System;
namespace Ex6;
class Program 
{
  public static void Main(string[] args)
  {
    int [,] array1= new int[5,5];
    int [,] array2= new int[5,5];
    int [,] add2array= new int[5,5];
    int i,j;
    System.Console.WriteLine("Enter the first matrix input: ");

    for (i=1; i<=3;i++)
    {
        for (j=1; j<=3;j++)
        {
            System.Console.Write($"element [{i},{j}] : ");
            array1[i,j]=int.Parse(Console.ReadLine());
        }
    }
    System.Console.WriteLine("The first matrixis : ");

    for(i=1;i<=3;i++)
            {
                Console.WriteLine("\n");
                for(j=1;j<=3;j++)
                Console.Write(array1[i,j]+" ");
            }
    System.Console.WriteLine("\nEnter the second matrix input: ");
    for (i=1; i<=3;i++)
    {
        for (j=1; j<=3;j++)
        {
            System.Console.Write($"\nelement [{i},{j}] : ");
            array2[i,j]=int.Parse(Console.ReadLine());
        }
    }
    System.Console.WriteLine("The second matrixis : ");

    for(i=1;i<=3;i++)
      {
        Console.Write("\n");
        for(j=1;j<=3;j++)
        Console.Write(array2[i,j]+" ");
      }

  
      for(i=1;i<=3;i++)
      for(j=1;j<=3;j++)
      add2array[i,j]=array1[i,j]+array2[i,j];
      Console.WriteLine("\nThe Addition of two matrix is : ");
      for(i=1;i<=3;i++)
      {
        Console.Write("\n");
        for(j=1;j<=3;j++)
        Console.Write(add2array[i,j]+" ");
      }
  }
}