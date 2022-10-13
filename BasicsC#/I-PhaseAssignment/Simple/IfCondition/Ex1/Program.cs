using System;
namespace Ex1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the password: ");
        string password = Console.ReadLine();
        
        if (password=="s3cr3t!P@ssw0rd")
        {
            System.Console.WriteLine("Welcome");
        }
        else
        {
            System.Console.WriteLine("Wrong password!");
        }

    }
}