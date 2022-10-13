using System;
namespace ByNumberArgument;
class Program 
{
    static void Display(int number)
    {
        System.Console.WriteLine("Argument: "+number);
    }

    static void Display(int number1,int number2)
    {
        System.Console.WriteLine("Arguments "+number1+" and "+number2);
    }
    public static void Main(string[] args)
    {
        Display(100);
        Display(100,200);
    }
}