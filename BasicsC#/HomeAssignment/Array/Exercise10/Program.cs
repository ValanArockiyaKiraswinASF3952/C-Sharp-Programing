using System;  
namespace Exercise10;
public class Program 
{  
    public static void Main()
      {
        int i,j,r,c;
       int[,] arr1 = new int[50,50];
        int[,] brr1 = new int[50,50];

        Console.WriteLine("Input the number of rows and columns of the first matrix :");    
        Console.Write("Rows : ");
        r = Convert.ToInt32(Console.ReadLine());
        Console.Write("Columns : ");  
        c = Convert.ToInt32(Console.ReadLine());    
    

       Console.WriteLine("Input elements in the matrix :");
       for(i=0;i<r;i++)
        {
            for(j=0;j<c;j++)
            {
            Console.Write("element - [{0}],[{1}] : ",i,j);
             arr1[i,j]=Convert.ToInt32(Console.ReadLine());  
            }
        } 

        Console.WriteLine("The First matrix is :");
        for(i=0;i<r;i++)
      {
        Console.Write("\n");
        for(j=0;j<c;j++)
           Console.Write("{0}\t",arr1[i,j]);
      }
  
        for(i=0;i<r;i++)
      {
      for(j=0;j<c;j++)
           {

                   brr1[j,i]=arr1[i,j];
            }
       }

      Console.WriteLine("\nThe Transpose of a matrix is : ");
      for(i=0;i<c;i++)
        {
        Console.Write("\n");
        for(j=0;j<r;j++)
        {
           Console.Write("{0}\t",brr1[i,j]);
        }
    }
    }
}
