using System;
namespace Ex3;
class Program 
{
    public static void Main(string[] args)
    {
       int number=2;

        for (int i=1;i<=20;i++)
        {
            System.Console.WriteLine($"{number}*{i}={number*i}");
        }
        
    }
}