using System;
namespace Exercise43;
class Program
{
    public static int Fibo(int nno)
    {
    int num1 = 0;
    int num2 = 1;
    
    for (int i = 0; i < nno; i++)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp + num2;
    }
    return num1;
    }
    public static void Main(string[] args)
    {
      Console.Write("Input number of Fibonacci Series : ");
      int n= Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("The Fibonacci series of "+n+" numbers is :");    
    for (int i = 0; i < n; i++)
    {
        Console.Write(Fibo(i)+"  ");
    }
    Console.WriteLine();
    }
}