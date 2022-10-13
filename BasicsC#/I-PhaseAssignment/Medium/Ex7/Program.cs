using System;
namespace Ex7;
class Program 
{
    public static void Main(string[] args)
    {
        
        int a=5,count=0;
        System.Console.Write(a+"  ");
        for (int i=0;i<10-1;i++)
        {
            a=a+2;
            count +=a;
            System.Console.Write(a+"  ");
        }
        System.Console.WriteLine("\nSum of the number is: "+(count+5));
    }
}