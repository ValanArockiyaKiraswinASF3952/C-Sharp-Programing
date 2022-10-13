using System;
namespace Ex3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the lower limit: ");
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the upper limit: ");
        int value2 = int.Parse(Console.ReadLine());
        

        int r,temp;   
          
       for (int i=n;i<=value2;i++)
       {
        int sum=0;
        temp=n;
       while(n>0)      
       {      
        r=n%10;      
        sum=sum+(r*r*r);      
        n=n/10;     
        System.Console.WriteLine(sum); 
       }      
       }
       
    }
}