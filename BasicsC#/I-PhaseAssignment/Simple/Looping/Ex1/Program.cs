using System;
namespace Ex1;
class Program 
{
    public static void Main(string[] args)
    {
       

        for (int i=0;i<3;i++)
        {
             System.Console.WriteLine("Enter the value X: ");
        int x = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the value Y: ");
        int y = int.Parse(Console.ReadLine());
        
            System.Console.WriteLine("X power Y is: "+(Math.Pow(x,y)));
        }
        
    }
}