using System;
namespace Ex10;
class Program 
{
    public static void Main(string[] args)
    {
      System.Console.WriteLine("Enter the number: ");
      int number = int.Parse(Console.ReadLine());
      
      for (int i=1;i<number*4;i++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();

        for (int i=1;i<number;i++)
        {
            System.Console.Write("*");
            for (int j=1;j<(number*4)-2;j++)
            {
                System.Console.Write(" ");
            }
            System.Console.Write("*");
            System.Console.WriteLine();
        }
        for (int i=1;i<number*4;i++)
        {
            System.Console.Write("*");
        }
    }
}