using System;
namespace Ex2;
class Program 
{
    public static void Main(string[] args)
    {
        int n1=0,n2=1,n3,i;
        System.Console.WriteLine("Enter the input number: ");
        int number = int.Parse(Console.ReadLine());
        
        Console.Write(n1+" "+n2+" "); //printing 0 and 1    
         for(i=2;i<number;++i) //loop starts from 2 because 0 and 1 are already printed    
         {    
          n3=n1+n2;    
          Console.Write(n3+" ");    
          n1=n2;    
          n2=n3;    
         }    
    }
}