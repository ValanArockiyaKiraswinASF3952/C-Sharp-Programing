using System;
namespace Ex5;
class Program 
{
  public static void Main(string[] args)
  {
    System.Console.WriteLine("Enter the input: ");
    int number = int.Parse(Console.ReadLine());
    for (int i=1;i<number;i++)
    {
      if ((i%400==0) || (i%100!=0 && i%4==0))
      {
        System.Console.WriteLine(i);
      }
    }
  }
}