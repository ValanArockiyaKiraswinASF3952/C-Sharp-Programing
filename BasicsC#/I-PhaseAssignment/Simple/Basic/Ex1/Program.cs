using System;
namespace Ex1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        double number = double.Parse(Console.ReadLine());
        System.Console.WriteLine($"Converts the number from inches to centimeters:  \n{number}inch = {(double)number*2.54}cm");
    }
}