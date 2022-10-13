using System;  
namespace Ex1;
class Program
{  
    public static void Main()
  {
    int i,j,k,row1,column1,row2,column2,sum=0;
  
    int[,] array1 = new int[5,5];
    int[,] array2 = new int[5,5];
    int[,] multiplearray = new int[5,5]; 

    Console.WriteLine("Input the number of rows and columns of the first matrix :");    
    Console.Write("Rows : ");
    row1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Columns : ");  
    column1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input the number of rows of the second matrix :");  
    Console.Write("Rows : ");
    row2 = Convert.ToInt32(Console.ReadLine());
     Console.Write("Columns : ");   
    column2 = Convert.ToInt32(Console.ReadLine());  
  
    if(column1!=row2)
    {
      Console.WriteLine("Mutiplication of Matrix is not possible.");
      Console.WriteLine("Column of first matrix and row of second matrix must be same.");
    }
    else
    {
       Console.WriteLine("Input elements in the first matrix :");
       for(i=0;i<row1;i++)
        {
            for(j=0;j<column1;j++)
            {
            Console.Write($"element - [{i}],[{j}] : ");
            array1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }   
        Console.WriteLine("Input elements in the second matrix :");
        for(i=0;i<row2;i++)
        {
            for(j=0;j<column2;j++)
            {
            Console.Write($"element - [{i}],[{j}] : ");
            array2[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }    
        Console.WriteLine("The First matrix is :");
        for(i=0;i<row1;i++)
      {
         Console.Write("\n");
        for(j=0;j<column1;j++)
           Console.Write($"{array1[i,j]}\t");
      }
        Console.Write("\n");
        Console.WriteLine("The Second matrix is :");
        for(i=0;i<row2;i++)
      {
        Console.Write("\n");
        for(j=0;j<column2;j++)
        Console.Write($"{array2[i,j]}\t");
      }
       Console.Write("\n");
        for(i=0;i<row1;i++)
          for(j=0;j<column2;j++)
           multiplearray[i,j]=0;
             for(i=0;i<row1;i++) 
            { 
              for(j=0;j<column2;j++) 
              {  
                sum=0;
                for(k=0;k<column1;k++)
                sum=sum+array1[i,k]*array2[k,j];
                multiplearray[i,j]=sum;
              }
            }
            Console.WriteLine("The multiplication of two matrix is : ");
            for(i=0;i<row1;i++)
            {
              Console.Write("\n");
              for(j=0;j<column2;j++)
              {
                Console.Write($"{multiplearray[i,j]}\t");
              }
            }
        }
  }
}




