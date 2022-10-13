using System;
namespace Ex5;
class Program 
{
    public static void Main(string[] args)
    {
      System.Console.WriteLine("Enter the number: ");
      int number = int.Parse(Console.ReadLine());
      
      for (int i=1;i<number;i++)
      
        if (number%i==0)
        {
            System.Console.WriteLine("It is a prime number.");
            break;
        }
      System.Console.WriteLine("It is not a prime number.");
    }
}