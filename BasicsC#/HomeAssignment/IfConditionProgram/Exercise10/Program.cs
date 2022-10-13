using System;
namespace Exercise10
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Password: ");
            string password = Console.ReadLine();
            if (password=="HiTeam")
            {
                System.Console.WriteLine("Right password ");
            }
            else
            {
                System.Console.WriteLine("Wrong password");
            }
        }
    }
}