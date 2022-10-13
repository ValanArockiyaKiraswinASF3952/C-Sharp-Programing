using System;
namespace Ex4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("RATE: ");
        double currency = double.Parse(Console.ReadLine());
        System.Console.WriteLine($"USD : {(double)(currency+22)/100}");
        System.Console.WriteLine($"EUR : {(double)(currency+27)/100}");
        System.Console.WriteLine($"CNY : {(double)(currency+779)/100}");
    }
}