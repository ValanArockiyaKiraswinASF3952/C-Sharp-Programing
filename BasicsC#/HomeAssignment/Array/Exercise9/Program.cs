using System;  
namespace Exercise9;
class Program
{  
    public static void Main()
{
    int i,j,k,r1,c1,r2,c2,sum=0;
  
    int[,] arr1 = new int[50,50];
    int[,] brr1 = new int[50,50];
    int[,] crr1 = new int[50,50]; 

    Console.WriteLine("Input the number of rows and columns of the first matrix :");    
    Console.Write("Rows : ");
    r1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Columns : ");  
    c1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input the number of rows of the second matrix :");  
    Console.Write("Rows : ");
    r2 = Convert.ToInt32(Console.ReadLine());
     Console.Write("Columns : ");   
    c2 = Convert.ToInt32(Console.ReadLine());  
  
    if(c1!=r2)
    {
      Console.WriteLine("Mutiplication of Matrix is not possible.");
      Console.WriteLine("Column of first matrix and row of second matrix must be same.");
    }
    else
    {
       Console.WriteLine("Input elements in the first matrix :");
       for(i=0;i<r1;i++)
        {
            for(j=0;j<c1;j++)
            {
            Console.Write("element - [{0}],[{1}] : ",i,j);
            arr1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }   
        Console.WriteLine("Input elements in the second matrix :");
        for(i=0;i<r2;i++)
        {
            for(j=0;j<c2;j++)
            {
            Console.Write("element - [{0}],[{1}] : ",i,j);
            brr1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }    
        Console.WriteLine("The First matrix is :");
        for(i=0;i<r1;i++)
      {
         Console.Write("\n");
        for(j=0;j<c1;j++)
           Console.Write("{0}\t",arr1[i,j]);
      }
        Console.Write("\n");
        Console.WriteLine("The Second matrix is :");
        for(i=0;i<r2;i++)
      {
        Console.Write("\n");
        for(j=0;j<c2;j++)
        Console.Write("{0}\t",brr1[i,j]);
      }
       Console.Write("\n");
      for(i=0;i<r1;i++)
          for(j=0;j<c2;j++)
           crr1[i,j]=0;
             for(i=0;i<r1;i++) 
                 { 
                   for(j=0;j<c2;j++) 
                     {  
                       sum=0;
                         for(k=0;k<c1;k++)
                           sum=sum+arr1[i,k]*brr1[k,j];
                           crr1[i,j]=sum;
                     }
                }
                Console.WriteLine("The multiplication of two matrix is : ");
                for(i=0;i<r1;i++)
                {
                 Console.Write("\n");
                for(j=0;j<c2;j++)
                {
                    Console.Write("{0}\t",crr1[i,j]);
                }
            }
        }
    }
}