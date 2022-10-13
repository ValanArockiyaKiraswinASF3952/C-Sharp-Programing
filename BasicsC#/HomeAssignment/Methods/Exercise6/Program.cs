using System;
namespace Exercise6;
class Program
{
public static void Main(string[] args)
{
      decimal factorial;    
      Console.Write("Enter a number : ");
      int number= Convert.ToInt32(Console.ReadLine());
      factorial = factorialactorial(number);
      Console.WriteLine($"The factorialactorial ofactorial {number}! is  {factorial}");
}
static decimal factorialactorial(int n1)
    {
      if (n1 == 0)
        {
         return 1;
        }
       else
        {
          return n1 * factorialactorial(n1 - 1);
        }
    }
}