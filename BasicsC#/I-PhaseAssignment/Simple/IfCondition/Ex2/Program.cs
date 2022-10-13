using System;
namespace Ex2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number<100)
        {
            System.Console.WriteLine("Less then 100");
        }
        else if (number>=100 && number<200)
        {
            System.Console.WriteLine("Between 100 and 200");
        }
        else
        {
            System.Console.WriteLine("Grater then 200");
        }

    }
}