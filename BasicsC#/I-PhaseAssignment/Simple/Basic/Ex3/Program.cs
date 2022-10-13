using System;
namespace Ex3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the celsius: ");
        double number = double.Parse(Console.ReadLine());
        System.Console.WriteLine($"degrees onFahrenheit scale: {Math.Round((double)(number*(9/5)+32),2)}");

    }
}