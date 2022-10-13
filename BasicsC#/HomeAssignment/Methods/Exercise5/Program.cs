using System;
namespace Exercise5;
class Program
{
    public static bool checkprime(int num)
    {
        for (int i=2; i < num; i++)
          if (num %i == 0) 
            return false;
        return true;
    }
    public static void Main(string[] args)
    {
      Console.Write("Input a number : ");
      int n= Convert.ToInt32(Console.ReadLine());   
    
        if (checkprime(n))
          Console.WriteLine($"{n} is a prime number");
        else
          Console.WriteLine($"{n} is not a prime number");
    }
}