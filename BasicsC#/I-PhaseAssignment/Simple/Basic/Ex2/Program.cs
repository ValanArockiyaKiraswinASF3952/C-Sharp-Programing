using System;
namespace Ex2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius number: ");
        double number1 = double.Parse(Console.ReadLine());
        System.Console.WriteLine($"The radius of circle is: {Math.PI*number1*number1}");
        System.Console.WriteLine($"The parameter of circle is: {2*Math.PI*number1}");

         System.Console.WriteLine("Enter the radius number: ");
        double number2 = double.Parse(Console.ReadLine());
        System.Console.WriteLine($"The radius of circle is: {Math.PI*number2*number2}");
        System.Console.WriteLine($"The parameter of circle is: {2*Math.PI*number2}");

    }
}