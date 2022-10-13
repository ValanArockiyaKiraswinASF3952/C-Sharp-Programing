using System;
namespace ExerciseOne
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello: "+name);
            Console.WriteLine("Hello: {0}",name);
            Console.WriteLine($"Hello: {name}");
        }
    }
}