using System;
namespace Ex4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the name of month: ");
        string month = (Console.ReadLine());
        
        switch (month)
        {
            case "January":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int janNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(31*500)-(janNumber*500)}"));
            break;

            case "Feb":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int febNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(28*500)-(febNumber*500)}"));
            break;

            case "March":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int marchNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(31*500)-(marchNumber*500)}"));
            break;

            case "April":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int aprilNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(30*500)-(aprilNumber*500)}"));
            break;

            case "May":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int mayNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(31*500)-(mayNumber*500)}"));
            break;

            case "June":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int juneNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(30*500)-(juneNumber*500)}"));
            break;

            case "July":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int julyNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(31*500)-(julyNumber*500)}"));
            break;

            case "August":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int augNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(31*500)-(augNumber*500)}"));
            break;

            case "September":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int sebNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(30*500)-(sebNumber*500)}"));
            break;

            case "October":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int ocbNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(31*500)-(ocbNumber*500)}"));
            break;

            case "November":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int novNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(30*500)-(novNumber*500)}"));
            break;

            case "December":
            System.Console.WriteLine("Enter number of leaves taken in that month: ");
            int decNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine(($"Total salary : {(31*500)-(decNumber*500)}"));
            break;

            default:
            System.Console.WriteLine("Invalid!");
            break;
            
        }

    }
}